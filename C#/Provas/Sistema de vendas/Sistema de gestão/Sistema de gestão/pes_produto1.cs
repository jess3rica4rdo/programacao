using CapaDados;
using CapaEntidade;
using DocumentFormat.OpenXml.Office2010.Excel;
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

namespace Sistema_de_gestão
{
    public partial class pes_produto1 : Form
    {
        public produto cproduto { get; set; }

        string jj = @"Data Source=DESKTOP-HKMIROJ\SQLEXPRESS;Initial Catalog=loja;Integrated Security=True";

        public pes_produto1()
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
            SqlDataAdapter apter = new SqlDataAdapter("SELECT cod_produto AS ID, nome_produto AS Nome, categoria AS Categoria, preco_compra AS Preço_compra FROM produto", conn);
            apter.Fill(dt);
            return dt;
        }

        private void ca_produto_Load(object sender, EventArgs e)
        {
            dgvproduto.DataSource = produto();
        }

        private void dgvproduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow >= 0 && iColum > 0)
            {
                cproduto = new produto()
                {
                    cod_produto = Convert.ToInt32(dgvproduto.Rows[iRow].Cells[0].Value.ToString()),
                    nome_produto = dgvproduto.Rows[iRow].Cells[1].Value.ToString(),
                    categoria = dgvproduto.Rows[iRow].Cells[2].Value.ToString(),
                    preco_compra = dgvproduto.Rows[iRow].Cells[3].Value.ToString()

                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_pes_Click(object sender, EventArgs e)
        {
            string pes = "SELECT cod_produto AS ID, nome_produto AS Nome, categoria AS Categoria, preco_compra AS Preço_compra FROM produto WHERE nome_produto LIKE @nome_produto";

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
                    dgvproduto.DataSource = consulta.Tables[0];
                }
            }
            catch
            {
                MessageBox.Show("Este produto não foi encontrado no sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
