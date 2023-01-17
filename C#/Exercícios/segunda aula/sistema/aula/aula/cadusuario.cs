using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace aula
{
    public partial class cadusuario : Form
    {
        public cadusuario()
        {
            InitializeComponent();
        }

        string PP = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Aula;Data Source=DESKTOP-HKMIROJ\SQLEXPRESS
"; 

        private void btcadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(PP);
            SqlDataAdapter Cmd = new SqlDataAdapter();

            Cmd.InsertCommand = new SqlCommand("INSERT INTO Cadastros VALUES(@Nome_completo,@Usuario,@Senha,@Função)", conn);

            Cmd.InsertCommand.Parameters.Add("@Nome_completo", SqlDbType.VarChar).Value = txtnomecompleto.Text;
            Cmd.InsertCommand.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = txt_usuario.Text;
            Cmd.InsertCommand.Parameters.Add("@Senha", SqlDbType.VarChar).Value = txt_senha.Text;
            Cmd.InsertCommand.Parameters.Add("@Função", SqlDbType.VarChar).Value = combfun.Text;
            try
            {
                conn.Open();
                Cmd.InsertCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Usuario cadastrado com sucesso");
                txtnomecompleto.Text = "";
                txt_usuario.Text = "";
                txt_senha.Text = "";
                combfun.Text = "";
                txtnomecompleto.Focus();
            }
            catch
            {
                MessageBox.Show("Erro ao Cadastrar o Usuario");
            }
          }

        public DataTable Cadastros()
        {
            SqlConnection conn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Aula;Data Source=DESKTOP-HKMIROJ\SQLEXPRESS");
            DataTable dt = new DataTable();
            SqlDataAdapter apter = new SqlDataAdapter("select* from Cadastros", conn);
            apter.Fill(dt);
            return dt;
        }

        private void btvisualizar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Cadastros(); 
           }

        private void cadusuario_Load(object sender, EventArgs e)
        {

        }
    }
    }

