using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidade;
using FontAwesome.Sharp;
using System.Data.SqlClient;
using Sistema_de_gestão.utilidades;

namespace Sistema_de_gestão
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            string jj = @"Data Source=DESKTOP-HKMIROJ\SQLEXPRESS;Initial Catalog=loja;Integrated Security=True";
            string sql = "select * from Usuario where nome_usuario=@nome_usuario and senha=@senha";

            SqlConnection Con = new SqlConnection(jj);

            try
            {
                if ((txt_usuario.Text == "") || (txt_senha.Text == ""))
                {
                    MessageBox.Show("Insira o nome de usuário e a senha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    SqlCommand cmd = new SqlCommand(sql, Con);
                    cmd.Parameters.AddWithValue("@nome_usuario", txt_usuario.Text);
                    cmd.Parameters.AddWithValue("@senha", txt_senha.Text);

                    Con.Open();
                    SqlDataReader dtr = cmd.ExecuteReader();

                    vm.NomeFuncionario1 = txt_usuario.Text;
                    while (dtr.Read())
                    {
                        painel_principal h = new painel_principal();
                        h.Show();
                        this.Hide();
                    }
                    dtr.Close();

                    txt_usuario.Text = "";
                    txt_senha.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de Inserção : " + ex.Message);
            }
        }
    }
}