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
using CapaDados;
using Sistema_de_gestão.utilidades;

namespace Sistema_de_gestão
{
    public partial class pes_produto : Form
    {
        string jj = @"Data Source=DESKTOP-HKMIROJ\SQLEXPRESS;Initial Catalog=loja;Integrated Security=True";

        public pes_produto()
        {
            InitializeComponent();
        }

        conexao conexao = new conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;

        public DataTable produto()
        {
            SqlConnection conn = new SqlConnection(jj);
            DataTable dt = new DataTable();
            SqlDataAdapter apter = new SqlDataAdapter("SELECT cod_produto AS ID, nome_produto AS Nome, categoria AS Categoria, estado AS Estado, stock AS Stock, preco_venda AS Preço_venda, add_por AS Adicionado_por, data_registro AS Data FROM produto", conn);
            apter.Fill(dt);
            return dt;
        }

        private void pes_produto_Load(object sender, EventArgs e)
        {
            dgvusuario.DataSource = produto();
        }

        private void txt_pes_Click(object sender, EventArgs e)
        {
            string pes = "SELECT cod_produto AS ID, nome_produto AS Nome, categoria AS Categoria, estado AS Estado, stock AS Stock, preco_venda AS Preço_venda, add_por AS Adicionado_por, data_registro AS Data FROM produto WHERE nome_produto LIKE @nome_produto";

            try
            {
                if (txt_buscar.Text == "")
                {
                    MessageBox.Show("A barra de pesquisa não pode estar em branco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                else
                {
                    SqlConnection conn = new SqlConnection(jj);
                    conn.Open();
                    SqlCommand Cmd = new SqlCommand(pes, conn);
                    Cmd.Parameters.AddWithValue(@"nome_produto", "%" + txt_buscar.Text + "%");
                    SqlDataAdapter data = new SqlDataAdapter(Cmd);
                    DataSet consulta = new DataSet();
                    data.Fill(consulta);

                    dgvusuario.DataSource = consulta.Tables[0];
                }
            }
            catch
            {
                MessageBox.Show("Este produto não foi encontrado no sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            txt_buscar.Text = "";
            dgvusuario.DataSource = produto();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog SaveFileDialog = new SaveFileDialog();
                SaveFileDialog.InitialDirectory = "c:\\";
                SaveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|Excel 2019 (*.xls)|*.xls";
                SaveFileDialog.FilterIndex = 1;

                if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    DataTable dt = excel.DataGridView_To_Datatable(dgvusuario);
                    dt.exportToExcel(SaveFileDialog.FileName);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
