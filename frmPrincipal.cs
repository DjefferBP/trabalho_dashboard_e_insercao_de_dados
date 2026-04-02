using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AppNuvemDesktop
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

            AtualizarDashboardGeral();
        }

        private void AtualizarDashboardGeral()
        {
            List<RegistroProducao> lista = RegistroProducao.listaRegistros();
            dgvRegistros.DataSource = lista;

            int totalBoas = lista.Sum(r => r.pecas_boas);
            int totalRuins = lista.Sum(r => r.pecas_defeituosas);
            int totalPecas = totalBoas + totalRuins;

            chartRegistros.Series.Clear();
            Series dados = new Series("Produção")
            {
                ChartType = SeriesChartType.Pie
            };
            dados.Points.AddXY($"RUINS: {((double)totalRuins / totalPecas) * 100:0.##}%", totalRuins);
            dados.Points.AddXY($"BOAS: {((double)totalBoas / totalPecas) * 100:0.##}%", totalBoas);
            dados.Points[0].Color = Color.Red;
            dados.Points[1].Color = Color.Green;
            chartRegistros.Series.Add(dados);

            double taxaDefeito = totalPecas > 0 ? ((double)totalRuins / totalPecas) * 100 : 0;
            AtualizarTaxaDefeito(taxaDefeito);

            lblTotalProduzido.Text = $"Total Produzido: {totalPecas}";
        }
        private void AtualizarTaxaDefeito(double taxa)
        {
            int larguraMax = pbFundo.Width;
            int larguraPreenchida = (int)(larguraMax * (taxa / 100));
            pbPreenchimento.Width = larguraPreenchida;

            lblPercentual.Text = $"{taxa:0.##}%";



            if (taxa < 10) pbPreenchimento.BackColor = Color.Green;
            else if (taxa < 30) pbPreenchimento.BackColor = Color.Orange;
            else pbPreenchimento.BackColor = Color.Red;
        }


        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("É necessário o ID para buscar o registro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int idMaquina;
            if (!int.TryParse(txtId.Text, out idMaquina))
            {
                MessageBox.Show("ID inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            RegistroProducao rp = RegistroProducao.LocalizaRegistro(idMaquina);

            if (rp == null)
            {
                MessageBox.Show("Nenhum registro encontrado para essa máquina!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int pecasBoas = rp.pecas_boas;
            int pecasRuins = rp.pecas_defeituosas;
            int totalMaquina = pecasBoas + pecasRuins;
            double taxaPerda = totalMaquina > 0 ? ((double)pecasRuins / totalMaquina) * 100 : 0;


            lblProducaoMaquina.Text = $"Produção: {pecasBoas}";
            lblPerdaMaquina.Text = $"Perda: {pecasRuins}";
            lblTaxaPerdaMaquina.Text = $"Taxa de Perda: {taxaPerda:0.##}%";
        }

        private void dgvRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtId.Text = dgvRegistros.Rows[e.RowIndex].Cells[0].Value.ToString();

                int pecasBoas = Convert.ToInt32(dgvRegistros.Rows[e.RowIndex].Cells[2].Value.ToString());
                int pecasRuins = Convert.ToInt32(dgvRegistros.Rows[e.RowIndex].Cells[3].Value.ToString());
                int totalMaquina = pecasBoas + pecasRuins;
                double taxaPerda = totalMaquina > 0 ? ((double)pecasRuins / totalMaquina) * 100 : 0;


                lblProducaoMaquina.Text = $"Produção: {pecasBoas}";
                lblPerdaMaquina.Text = $"Perda: {pecasRuins}";
                lblTaxaPerdaMaquina.Text = $"Taxa de Perda: {taxaPerda:0.##}%";

            }
        }
    }
}