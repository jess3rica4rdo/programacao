using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula
{
    public partial class Login : Form
    {
        string jj = @"Data Source=DESKTOP-HKMIROJ\SQLEXPRESS;Initial Catalog=Aula;Integrated Security=True";
        string sql = "select * from Usuario where Usuario=@Usuario and Senha=@Senha";

        public Login()
        {
            InitializeComponent();
        }

        private void btentrar_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(jj);

            try
            {
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.AddWithValue("@Usuario", txt_usuario.Text);
                cmd.Parameters.AddWithValue("@Senha", txt_senha.Text);

                Con.Open();
                SqlDataReader dtr = cmd.ExecuteReader();
                vm.NomeFuncionario1 = txt_usuario.Text;
                while (dtr.Read())
                {
                    this.Hide();
                    new Principal().ShowDialog();

                    this.Close();
                    this.Dispose();
                }
                dtr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro de Inserção : " + ex.Message);
            }
             
            txt_usuario.Text = "";
            txt_senha.Text = "";
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
         
             if (MessageBox.Show("Deseja realmente Cancelar?", "Informação",
      MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
              }
            } 
          }
        }
