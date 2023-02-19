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
    public partial class Principal : Form
    {
        string jj = @"Data Source=DESKTOP-HKMIROJ\SQLEXPRESS;Initial Catalog=Biblioteca;Integrated Security=True";
        string sql = "select * from Usuario where Usuario=@Usuario";

        public Principal()
        {
            InitializeComponent();
        }

        private void menuusuario_Click(object sender, EventArgs e)
        {
            try
            {

                if (Fun1.Text == "Adm")
                {
                    new cadusuario().ShowDialog();
                }

                else
                {
                    MessageBox.Show("Contactar o Administrador!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            { }
    }

        private void menuproduto_Click_1(object sender, EventArgs e)
        {
            cadbebe p = new cadbebe();
            p.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Informação",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void prncipal_Load_1(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(jj);
            SqlCommand cmd = new SqlCommand(sql, Con);
            cmd.Parameters.AddWithValue("@Usuario", vm.NomeFuncionario1);
            Con.Open();
            SqlDataReader dtr = cmd.ExecuteReader();

            while (dtr.Read())
            {
                Utilizador.Text = (string)dtr["Nome_completo"];
                Fun1.Text = (string)dtr["Função"];
                codfuncionario.Text = Convert.ToString(dtr["CodUsuario"]);
            }
            dtr.Close();

        }

        }

    }

