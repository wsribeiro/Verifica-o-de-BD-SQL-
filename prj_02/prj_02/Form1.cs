using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace prj_02
{
    public partial class Form1 : Form
    {
        static DataTable g_data_table = new DataTable();
        static string g_mysql_string_conection = "Server=localhost;" +
                                                 "port=3306; " +
                                                 "Database=meu_banco_de_dados; " +
                                                 "Uid=root; " +
                                                 "Pwd=root;";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executa_funcao_Click(object sender, EventArgs e)
        {
            string strSql_select_pessoas = "select * from pessoas;  ";

            MySqlConnection l_conect_MySql = new MySqlConnection("Server=" + txt_host.Text + ";" + "port=" + txt_port.Text + ";" +
            "Database=" + txt_db.Text + ";" + "Uid=" + txt_pwd.Text + ";" + "Pwd=" + txt_uid.Text + ";");
            
            try
            {
                l_conect_MySql.Open();
                status.Text = "Online";
                status.ForeColor = Color.Green;

            }
            catch
            {
                MessageBox.Show("Informações incorretas. Não foi possivel conectar-se ao banco de dados.",
                     "Acesso ao SGBD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                status.Text = "Offline";
                status.ForeColor = Color.Red;
                return;
            }            
            MySqlCommand l_command_MySql = l_conect_MySql.CreateCommand();

            l_command_MySql.Connection = l_conect_MySql;
            l_command_MySql.CommandText = strSql_select_pessoas;

            try
            {
                g_data_table.Load(l_command_MySql.ExecuteReader());
                dataGridView1.DataSource = g_data_table;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha leitura de PESSOAS." + erro.ToString(),
                    "Leitura de PESSOAS OJ (msg 002)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            l_conect_MySql.Close();
            l_conect_MySql.Dispose();
            l_conect_MySql.Dispose();
      }

      private void btn_search_Click(object sender, EventArgs e)
        {
            string strSql_select_pessoas = "select ";

            if (chk_nome.Checked)
            {
               strSql_select_pessoas = strSql_select_pessoas + "nome";
            }
            if (chk_idade.Checked)
            {
                strSql_select_pessoas = strSql_select_pessoas + "," + "idade";
            }
            if (chk_prof.Checked)
            {
                strSql_select_pessoas = strSql_select_pessoas + "," + "profissao";
            }
            if (chk_sexo.Checked)
            {
                strSql_select_pessoas = strSql_select_pessoas +"," + "sexo";
            }
            if (chk_peso.Checked)
            {
                strSql_select_pessoas = strSql_select_pessoas + "," + "peso";
            }
            if (chk_altura.Checked)
            {
                strSql_select_pessoas = strSql_select_pessoas + "," + "altura";
            }
            if (chk_nacionalidade.Checked)
            {
                strSql_select_pessoas = strSql_select_pessoas + "," + "nacionalidade";
            }
            if (chk_nascimento.Checked)
            {
                strSql_select_pessoas = strSql_select_pessoas + "," + "nascimento";
            }

            MySqlConnection l_conect_MySql = new MySqlConnection("Server=" + txt_host.Text + ";" + "port=" + txt_port.Text + ";" +
           "Database=" + txt_db.Text + ";" + "Uid=" + txt_pwd.Text + ";" + "Pwd=" + txt_uid.Text + ";");

            MySqlCommand l_command_MySql = l_conect_MySql.CreateCommand();
            l_command_MySql.Connection = l_conect_MySql;
            l_command_MySql.CommandText = strSql_select_pessoas + "from pessoas";
            l_conect_MySql.Open();
            try
            {
                g_data_table.Load(l_command_MySql.ExecuteReader());
                dataGridView1.DataSource = g_data_table;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha leitura de PESSOAS." + erro.ToString(),
                                   "Leitura de PESSOAS OJ (msg 002)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
