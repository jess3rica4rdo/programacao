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

namespace sistema_Aula
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        String Y = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Aula;Data Source=DESKTOP-QJSJVU3\SQLEXPRESS"; 

        private void btentrar_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(Y);
            try
            {

                string sql = "select * from Usuários where Usuario=@Usuario and Senha=@Senha";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.AddWithValue("@Usuario", txt_usuario.Text);
                cmd.Parameters.AddWithValue("@Senha", txtsenha.Text);
                // cmd.Parameters.AddWithValue("@Usuário", cmbFuncao.Text);
                Con.Open();
                SqlDataReader dtr = cmd.ExecuteReader();
                vm.NomeFuncionario1 = txt_usuario.Text;
                while (dtr.Read())
                {
                    this.Hide();
                    new principal().ShowDialog();

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
            txtsenha.Text = "";
              }

            private void btcancelar_Click(object sender, EventArgs e)
        {
             if (MessageBox.Show("Deseja realmente Cancelar?", "PembeleSoft2023",
      MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
                }
              } 
            }
          }
        
 
