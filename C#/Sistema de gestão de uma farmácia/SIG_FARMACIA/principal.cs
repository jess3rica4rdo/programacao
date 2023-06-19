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
namespace SIG_FARMACIA
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void principal_Load(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SIG_FARMA;Data Source=DESKTOP-HKMIROJ\SQLEXPRESS");
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

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do sistema?", "SISGEST 1.0 FARMACÊUTICA 2023",
      MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
                  }
               }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label3.Text = DateTime.Now.ToShortTimeString();
            label4.Text = DateTime.Now.ToShortDateString();
                    }

        private void inventárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
             vendas f2 = new vendas();
            f2.Show();

                       }

        private void menuusuario_Click(object sender, EventArgs e)
        {
            try
            {

                if (Fun1.Text == "Admin")
                {
                    new cadusuarios().ShowDialog();
                }
                else
                {
                    MessageBox.Show("Contactar o Administrador!", "SISGEST 1.0 FARMACÊUTICA 2023?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            { }

                   }

        private void logarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new login().ShowDialog();

                    }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
             try
            {

                if (Fun1.Text == "Admin")
                {
                    new cadfarmacos().ShowDialog();
                }
                else
                {
                    MessageBox.Show("Contactar o Administrador!", "SISGEST 1.0 FARMACÊUTICA 2023?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            { }

                     }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
             try
            {

                if (Fun1.Text == "Admin")
                {
                    new cadfornecedores().ShowDialog();
                }
                else
                {
                    MessageBox.Show("Contactar o Administrador!", "SISGEST 1.0 FARMACÊUTICA 2023?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            { }

                        }

        private void inventárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Estoque f2 = new Estoque();
            f2.Show();

                        }
                       }
                     }
                 
                    
         
    
