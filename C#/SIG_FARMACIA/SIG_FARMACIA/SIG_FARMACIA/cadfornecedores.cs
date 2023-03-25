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
    public partial class cadfornecedores : Form
    {
        public cadfornecedores()
        {
            InitializeComponent();
        }
        String conexao = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SIG_FARMA;Data Source=DESKTOP-QJSJVU3\SQLEXPRESS"; 
        private void btcadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conexao);
            SqlDataAdapter Cmd = new SqlDataAdapter();
            Cmd.InsertCommand = new SqlCommand("INSERT INTO Forncedores VALUES(@Nome,@Telefone,@NIF,@Email,@Endereco,@Data_Fornecedor)", conn);

            Cmd.InsertCommand.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtfornecedor.Text;
            Cmd.InsertCommand.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txttelefone.Text;
            Cmd.InsertCommand.Parameters.Add("@NIF", SqlDbType.VarChar).Value = txtnif.Text;
            Cmd.InsertCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtemail.Text;
            Cmd.InsertCommand.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = txtendereco.Text;
            Cmd.InsertCommand.Parameters.Add("@Data_Fornecedor", SqlDbType.VarChar).Value = txtdata.Text;

            try
            {
                conn.Open();
                Cmd.InsertCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Fármaco cadastrado com sucesso!");
                txtfornecedor.Text = "";
                txttelefone.Text = "";
                txtnif.Text = "";
                txtemail.Text = "";
                txtendereco.Text = "";
                txtdata.Text = "";
                txtfornecedor.Focus();
            }
            catch
            {
                MessageBox.Show("Erro ao Cadastrar o Fármaco");

            }
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar a operação?", "SISGEST 1.0 FARMACÊUTICA 2023",
      MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();

            }
        }
        public DataTable Forncedores()
        {
            SqlConnection conn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SIG_FARMA;Data Source=DESKTOP-QJSJVU3\SQLEXPRESS");
            DataTable dt = new DataTable();
            SqlDataAdapter apter = new SqlDataAdapter("select* from Forncedores", conn);
            apter.Fill(dt);
            return dt;
        }
        private void btvisualizar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Forncedores();

        }

        String Y = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SIG_FARMA;Data Source=DESKTOP-QJSJVU3\SQLEXPRESS"; 

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Y);

            string EliminarFornecedor = "delete  Forncedores where Cod_fornecedor=@Cod_fornecedor";
            try
            {
                SqlCommand cmd = new SqlCommand(EliminarFornecedor, conn);
                cmd.Parameters.AddWithValue("@Cod_fornecedor", this.txteliminar.Text);
                txteliminar.Text = "";
                conn.Open();
                cmd.ExecuteNonQuery();

                // MessageBox.Show("Dados Eliminado com Sucesso!");

                if (MessageBox.Show("Deseja realmente Eliminar este Fármaco?", "SISGEST 1.0 FARMACÊUTICA 2023",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txteliminar.Text = "";
                }

                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Eliminar Dados");
            }
        }

        private void btvoltar_Click(object sender, EventArgs e)
        {
            Close();
            principal log = new principal();
            log.Show();

           }
        }
     }

