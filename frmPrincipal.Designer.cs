namespace AppNuvemDesktop
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.chartRegistros = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.statusMaquinasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalProduzido = new System.Windows.Forms.Label();
            this.lblTaxaGeral = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProducaoMaquina = new System.Windows.Forms.Label();
            this.lblPerdaMaquina = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTaxaPerdaMaquina = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pbFundo = new System.Windows.Forms.Panel();
            this.pbPreenchimento = new System.Windows.Forms.Panel();
            this.lblPercentual = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusMaquinasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegistros.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvRegistros.Location = new System.Drawing.Point(522, 311);
            this.dgvRegistros.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.ReadOnly = true;
            this.dgvRegistros.RowHeadersWidth = 51;
            this.dgvRegistros.Size = new System.Drawing.Size(764, 441);
            this.dgvRegistros.TabIndex = 0;
            this.dgvRegistros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistros_CellClick);
            // 
            // chartRegistros
            // 
            this.chartRegistros.BorderlineColor = System.Drawing.Color.DarkGray;
            this.chartRegistros.BorderSkin.BackColor = System.Drawing.Color.Gainsboro;
            this.chartRegistros.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Sunken;
            chartArea4.Name = "ChartArea1";
            this.chartRegistros.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartRegistros.Legends.Add(legend4);
            this.chartRegistros.Location = new System.Drawing.Point(21, 311);
            this.chartRegistros.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.chartRegistros.Name = "chartRegistros";
            this.chartRegistros.Size = new System.Drawing.Size(491, 441);
            this.chartRegistros.TabIndex = 1;
            this.chartRegistros.Text = "Registros de produção";
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.BackColor = System.Drawing.Color.Teal;
            this.btnLocalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLocalizar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizar.Location = new System.Drawing.Point(1059, 216);
            this.btnLocalizar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(227, 67);
            this.btnLocalizar.TabIndex = 10;
            this.btnLocalizar.Text = "LOCALIZAR";
            this.btnLocalizar.UseVisualStyleBackColor = false;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(1059, 165);
            this.txtId.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(224, 31);
            this.txtId.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1053, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "TOTAL PRODUZIDO";
            // 
            // lblTotalProduzido
            // 
            this.lblTotalProduzido.AutoSize = true;
            this.lblTotalProduzido.Location = new System.Drawing.Point(34, 77);
            this.lblTotalProduzido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalProduzido.Name = "lblTotalProduzido";
            this.lblTotalProduzido.Size = new System.Drawing.Size(0, 27);
            this.lblTotalProduzido.TabIndex = 14;
            // 
            // lblTaxaGeral
            // 
            this.lblTaxaGeral.AutoSize = true;
            this.lblTaxaGeral.Location = new System.Drawing.Point(34, 201);
            this.lblTaxaGeral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaxaGeral.Name = "lblTaxaGeral";
            this.lblTaxaGeral.Size = new System.Drawing.Size(0, 27);
            this.lblTaxaGeral.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 27);
            this.label3.TabIndex = 15;
            this.label3.Text = "TAXA DE DEFEITO GERAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(360, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 27);
            this.label2.TabIndex = 17;
            this.label2.Text = "PRODUÇÃO TOTAL DA MÁQUINA";
            // 
            // lblProducaoMaquina
            // 
            this.lblProducaoMaquina.AutoSize = true;
            this.lblProducaoMaquina.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducaoMaquina.Location = new System.Drawing.Point(360, 75);
            this.lblProducaoMaquina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducaoMaquina.Name = "lblProducaoMaquina";
            this.lblProducaoMaquina.Size = new System.Drawing.Size(0, 27);
            this.lblProducaoMaquina.TabIndex = 18;
            // 
            // lblPerdaMaquina
            // 
            this.lblPerdaMaquina.AutoSize = true;
            this.lblPerdaMaquina.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerdaMaquina.Location = new System.Drawing.Point(360, 169);
            this.lblPerdaMaquina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerdaMaquina.Name = "lblPerdaMaquina";
            this.lblPerdaMaquina.Size = new System.Drawing.Size(0, 27);
            this.lblPerdaMaquina.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 131);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(298, 27);
            this.label6.TabIndex = 19;
            this.label6.Text = "PERDA TOTAL DA MÁQUINA";
            // 
            // lblTaxaPerdaMaquina
            // 
            this.lblTaxaPerdaMaquina.AutoSize = true;
            this.lblTaxaPerdaMaquina.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxaPerdaMaquina.Location = new System.Drawing.Point(767, 75);
            this.lblTaxaPerdaMaquina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaxaPerdaMaquina.Name = "lblTaxaPerdaMaquina";
            this.lblTaxaPerdaMaquina.Size = new System.Drawing.Size(0, 27);
            this.lblTaxaPerdaMaquina.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(767, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(285, 27);
            this.label7.TabIndex = 21;
            this.label7.Text = "TAXA DE PERDA MÁQUINA";
            // 
            // pbFundo
            // 
            this.pbFundo.BackColor = System.Drawing.Color.LightGray;
            this.pbFundo.Location = new System.Drawing.Point(41, 191);
            this.pbFundo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbFundo.Name = "pbFundo";
            this.pbFundo.Size = new System.Drawing.Size(236, 54);
            this.pbFundo.TabIndex = 24;
            // 
            // pbPreenchimento
            // 
            this.pbPreenchimento.BackColor = System.Drawing.Color.Red;
            this.pbPreenchimento.Location = new System.Drawing.Point(41, 191);
            this.pbPreenchimento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbPreenchimento.Name = "pbPreenchimento";
            this.pbPreenchimento.Size = new System.Drawing.Size(236, 54);
            this.pbPreenchimento.TabIndex = 25;
            // 
            // lblPercentual
            // 
            this.lblPercentual.AutoSize = true;
            this.lblPercentual.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentual.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentual.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPercentual.Location = new System.Drawing.Point(36, 249);
            this.lblPercentual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPercentual.Name = "lblPercentual";
            this.lblPercentual.Size = new System.Drawing.Size(38, 27);
            this.lblPercentual.TabIndex = 26;
            this.lblPercentual.Text = "0%";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1315, 772);
            this.Controls.Add(this.lblPercentual);
            this.Controls.Add(this.pbPreenchimento);
            this.Controls.Add(this.pbFundo);
            this.Controls.Add(this.lblTaxaPerdaMaquina);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPerdaMaquina);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblProducaoMaquina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTaxaGeral);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalProduzido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.chartRegistros);
            this.Controls.Add(this.dgvRegistros);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusMaquinasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRegistros;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource statusMaquinasBindingSource;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalProduzido;
        private System.Windows.Forms.Label lblTaxaGeral;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProducaoMaquina;
        private System.Windows.Forms.Label lblPerdaMaquina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTaxaPerdaMaquina;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pbFundo;
        private System.Windows.Forms.Panel pbPreenchimento;
        private System.Windows.Forms.Label lblPercentual;
    }
}

