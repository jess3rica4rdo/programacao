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
    public partial class vendas : Form
    {
        public vendas()
        {
            InitializeComponent();
        }

        private void btvoltar_Click(object sender, EventArgs e)
        {
            Close();
            principal log = new principal();
                   }
        String conexao = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SIG_FARMA;Data Source=DESKTOP-HKMIROJ\SQLEXPRESS";
        private void btnVender_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(conexao);
            con.Open();
            try
            {
                //Pegar o codigo do produto e quantidade actual
                string Sql = "select Cod_farmaco from Farmacos where Nome_farmaco = @Nome_farmaco  and Qtd_Estoque != 0";
                SqlCommand cmd = new SqlCommand(Sql, con);
                cmd.Parameters.AddWithValue("@Nome_farmaco", txtNome.Text);
                int CodProduto = (int)cmd.ExecuteScalar();

                string Sql2 = "select Qtd_Estoque from Farmacos where Nome_farmaco = @Nome_farmaco  and Qtd_Estoque != 0";
                SqlCommand cmd2 = new SqlCommand(Sql2, con);
                cmd2.Parameters.AddWithValue("@Nome_farmaco", txtNome.Text);
                int QuantidadeActual = (int)cmd2.ExecuteScalar();

                //Realizar a redução da quantidade
                SqlDataAdapter Cmd = new SqlDataAdapter();
                Cmd.InsertCommand = new SqlCommand("update Farmacos set Qtd_Estoque = @Qtd_Estoque where Cod_farmaco = @Cod_farmaco", con);
                Cmd.InsertCommand.Parameters.Add("@Qtd_Estoque", SqlDbType.Int).Value = QuantidadeActual - Convert.ToInt32(txtQuantidade2.Text);
                Cmd.InsertCommand.Parameters.Add("@Cod_farmaco", SqlDbType.Int).Value = CodProduto;
                Cmd.InsertCommand.ExecuteNonQuery();
                txt_nfactura.Text = "";
                txtNome.Text = "";
                txtQuantidade2.Text = "";
                textBox1.Text = ""; 
                txt_nfactura.Focus();
             
                                  }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
            con.Close();

                 //Fim Codigo de redução
                     }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar a operação?", "SISGEST 1.0 FARMACÊUTICA 2023",
      MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();

                         }
                       }

        public DataTable Farmacos()
        {
            SqlConnection conn = new SqlConnection(conexao);
            DataTable dt = new DataTable();
            SqlDataAdapter apter = new SqlDataAdapter("select* from Farmacos", conn);
            apter.Fill(dt);
            return dt;
        }
        private void btvisualizar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Farmacos(); 

                        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conexao);
            try
            {
                string str = "select * from Farmacos where Nome_farmaco like '%" + txtPesquisa.Text + "%'";
                SqlCommand cmd = new SqlCommand(str, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = new BindingSource(dt, null);
                txtNome.Text = "";

            }
           
   catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
            conn.Close();

            //Fim Codigo de redução
                                     }

        private void vendas_Load(object sender, EventArgs e)
        {

        }
    }
                             }
                     
               

   