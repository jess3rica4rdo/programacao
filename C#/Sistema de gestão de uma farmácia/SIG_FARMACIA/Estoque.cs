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
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
        }

        private void btvoltar_Click(object sender, EventArgs e)
        {
            Close();
            principal log = new principal();
        }
         String conexao = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SIG_FARMA;Data Source=DESKTOP-HKMIROJ\SQLEXPRESS";

        private void btpesquisar_Click(object sender, EventArgs e)
        {
             SqlConnection conn = new SqlConnection(conexao);
           try{
               string str = "select * from Farmacos where Nome_farmaco like '%" + txtpesqu.Text + "%'";
                SqlCommand cmd = new SqlCommand(str, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
                txtpesqu.Text = "";
               

           }
           
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
            conn.Close();

                   }

        private void btsair_Click(object sender, EventArgs e)
        {
            Application.Exit(); 

                }

        private void Estoque_Load(object sender, EventArgs e)
        {

        }

        private void btexportar_Click(object sender, EventArgs e)
        {

        }
    }
           }

