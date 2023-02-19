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
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
             if (MessageBox.Show("Deseja realmente sair?", "PembeleSoft2023",
      MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
                }
             }

        private void menuusuario_Click(object sender, EventArgs e)
        {
            // Código para chamar um formulário sem fechar o actual 
            //cadusuarios f2 = new cadusuarios();
            //f2.Show()

             try
            {

                if (Fun1.Text == "Admin")
                {
                    new cadusuarios().ShowDialog();
                }
                else
                {
                    MessageBox.Show("Contactar o Administrador!", "PembeleSoft?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            { }

             }

        private void principal_Load(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Aula;Data Source=DESKTOP-QJSJVU3\SQLEXPRESS");
            string sql = "select * from Usuários where Usuario=@Usuario";
            SqlCommand cmd = new SqlCommand(sql, Con);
            cmd.Parameters.AddWithValue("@Usuario", vm.NomeFuncionario1);
            Con.Open();
            SqlDataReader dtr = cmd.ExecuteReader();
            while (dtr.Read())
            {
                Utilizador.Text = (string)dtr["Nome"];
                Fun1.Text = (string)dtr["Funcao"];
                codfuncionario.Text = Convert.ToString(dtr["Codusuario"]);
            }
            dtr.Close();

             }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vendas f2 = new Vendas();
            f2.Show();
               }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            cadprodutos pembele = new cadprodutos
            ();
            pembele.Show();
          
            }
           } 
        }
     

