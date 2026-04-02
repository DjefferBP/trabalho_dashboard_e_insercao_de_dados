using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace AppNuvemDesktop
{
    public class RegistroProducao
    {
        [DisplayName("Id")]
        public int id { get; set; }

        [DisplayName("Id da máquina")]
        public int maquina_id { get; set; }

        [DisplayName("Peças boas")]
        public int pecas_boas { get; set; }

        [DisplayName("Peças defeituosas")]
        public int pecas_defeituosas { get; set; }

        [DisplayName("Status")]
        public string status { get; set; }

        

        static MySqlConnection con = new MySqlConnection("server=sql.freedb.tech;port=3306;database=freedb_senai_db;user id=freedb_dj_userdb;password=GCqj7dqW8uqXKz!;charset=utf8;");

        public static List<RegistroProducao> listaRegistros()
        {
            List<RegistroProducao> li = new List<RegistroProducao>();
            string sql = "SELECT * FROM registros_producao;";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    RegistroProducao r = new RegistroProducao();
                    r.id = (int)dr["id"];
                    r.maquina_id = (int)dr["maquina_id"];
                    r.pecas_boas = (int)dr["pecas_boas"];
                    r.pecas_defeituosas = (int)dr["pecas_defeituosas"];
                    r.status = (string)dr["status"];
                    
                    li.Add(r);
                }
                dr.Close();
                return li;
            }
            catch (MySqlException erroMySql)
            {
                MessageBox.Show($"Ocorreu um erro no MySQL: {erroMySql.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { con.Close(); }
            return li;
            
        }


        public static RegistroProducao LocalizaRegistro(int id)
        {
            string sql = "SELECT * FROM registros_producao WHERE id = @Id;";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("Id", id);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    RegistroProducao r = new RegistroProducao();
                    
                    r.id = (int)dr["id"];
                    r.maquina_id = (int)dr["maquina_id"];
                    r.pecas_boas = (int)dr["pecas_boas"];
                    r.pecas_defeituosas = (int)dr["pecas_defeituosas"];
                    r.status = (string)dr["status"];
                    return r;
                }
                dr.Close();
            }
            catch (MySqlException erroMySql)
            {
                MessageBox.Show($"Ocorreu um erro no MySQL: {erroMySql.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { con.Close(); }
            return null;

        }


        

    }
}
