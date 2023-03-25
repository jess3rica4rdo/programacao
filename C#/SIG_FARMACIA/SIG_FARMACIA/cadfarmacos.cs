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
    public partial class cadfarmacos : Form
    {
        public cadfarmacos()
        {
            InitializeComponent();
        }

        String conexao = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SIG_FARMA;Data Source=DESKTOP-HKMIROJ\SQLEXPRESS";

        private void btadicionar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conexao);
            SqlDataAdapter Cmd = new SqlDataAdapter();
            Cmd.InsertCommand = new SqlCommand("INSERT INTO Farmacos VALUES(@Nome_farmaco,@Categoria,@Preco,@Qtd_Estoque,@Stock_minimo,@Fornecedor,@Data_registo,@Descrição)", conn);

            Cmd.InsertCommand.Parameters.Add("@Nome_farmaco", SqlDbType.VarChar).Value = txtNome.Text;
            Cmd.InsertCommand.Parameters.Add("@Categoria", SqlDbType.VarChar).Value = combocategoria.Text;
            Cmd.InsertCommand.Parameters.Add("@Preco", SqlDbType.VarChar).Value = txtpreco.Text;
            Cmd.InsertCommand.Parameters.Add("@Qtd_Estoque", SqlDbType.VarChar).Value = txtquantidade.Text;
            Cmd.InsertCommand.Parameters.Add("@Stock_minimo", SqlDbType.VarChar).Value = txtstockminmo.Text;
            Cmd.InsertCommand.Parameters.Add("@Fornecedor", SqlDbType.VarChar).Value = combofornecedor.Text;
            Cmd.InsertCommand.Parameters.Add("@Data_registo", SqlDbType.VarChar).Value = txtdata.Text;
            Cmd.InsertCommand.Parameters.Add("@Descrição", SqlDbType.VarChar).Value = txt_desc.Text;


            try
            {
                conn.Open();
                Cmd.InsertCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Fármaco cadastrado com sucesso!");
                txtNome.Text = "";
                combocategoria.Text = "";
                txtpreco.Text = "";
                txtquantidade.Text = "";
                txtstockminmo.Text = "";
                combofornecedor.Text = "";
                txtdata.Text = "";
                txt_desc.Text = "";
                txtNome.Focus();
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

        public DataTable Farmacos()
        {
            SqlConnection conn = new SqlConnection(conexao);
            DataTable dt = new DataTable();
            SqlDataAdapter apter = new SqlDataAdapter("select* from Farmacos", conn);
            apter.Fill(dt);
            return dt;
        }
        private void btactualizar_Click(object sender, EventArgs e)
        {
            datadridpp.DataSource = Farmacos();
        }

        private void btpesquisar_Click(object sender, EventArgs e)
        {
             SqlConnection conn = new SqlConnection(conexao);
           try{
               string str = "select * from Farmacos where Nome_farmaco like '%" + txtPesquisa.Text + "%'";
                SqlCommand cmd = new SqlCommand(str, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                datadridpp.DataSource = new BindingSource(dt, null);
                txtNome.Text = "";
                txtpreco.Text = "";
                combocategoria.SelectedIndex = -1;

           }
          catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
            conn.Close();

            //Fim Codigo de redução
           }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conexao);

            string EliminarProdutos = "delete  Farmacos where Cod_farmaco=@Cod_farmaco";
            try
            {
                SqlCommand cmd = new SqlCommand(EliminarProdutos, conn);
                cmd.Parameters.AddWithValue("@Cod_farmaco", this.txteliminar.Text);
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

        private void cadfarmacos_Load(object sender, EventArgs e)
        {

        }
    }
           }
     
