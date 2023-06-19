using CapaDados;
using CapaEntidade;
using iTextSharp.text;
using iTextSharp.text.pdf;
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
    public partial class relatorio_compra : Form
    {
        string jj = @"Data Source=DESKTOP-HKMIROJ\SQLEXPRESS;Initial Catalog=loja;Integrated Security=True";

        public relatorio_compra()
        {
            InitializeComponent();
        }

        conexao conexao = new conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;

        private void detalhes_compras_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = compra();
        }

        public DataTable compra()
        {
            SqlConnection conn = new SqlConnection(jj);
            DataTable dt = new DataTable();
            SqlDataAdapter apter = new SqlDataAdapter("select\r\nConvert(char(10),c.data_compra,103)[Data da compra],c.tipo_documento[Documento],\r\np.nome_produto[Produto],\r\nc.preco_compra[Preço de compra],c.quantidade[Quantidade],c.valor_total[Total],\r\npr.nif[NIF do Fornecedor],\r\nu.nome_completo[Registrado por]\r\nfrom compra c\r\n\r\ninner join usuario u on u.nome_completo = c.registrado_por\r\ninner join fornecedor pr on pr.cod_fornecedor = c.cod_fornecedor\r\ninner join produto p on p.cod_produto = c.cod_produto\r\n", conn);
            apter.Fill(dt);
            return dt;
        }

        private void txt_pes_Click(object sender, EventArgs e)
        {
            string pes = "SELECT SELECT cod_compra AS ID_COMPRA, cod_produto AS ID_PRODUTO, cod_fornecedor AS ID_FORNECEDOR, preco_compra AS PREÇO_COMPRA, quantidade AS QUANTIDADE, valor_total AS VALOR_TOTAL, tipo_documento AS DOCUMENTO, data_compra AS DATA, registrado_por AS ADD_POR FROM compra WHERE cod_compra LIKE @cod_compra";

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
                    Cmd.Parameters.AddWithValue(@"cod_compra", "%" + txt_buscar.Text + "%");
                    SqlDataAdapter data = new SqlDataAdapter(Cmd);
                    DataSet consulta = new DataSet();
                    data.Fill(consulta);
                    dataGridView1.DataSource = consulta.Tables[0];
                }
            }
            catch
            {
                MessageBox.Show("Este produto não foi encontrado no sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            txt_buscar.Clear();
            dataGridView1.DataSource = compra();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Detalhes de compra atualizado.pdf ";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("erro" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dataGridView1.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in dataGridView1.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));

                                pTable.AddCell(pCell);
                            }

                            foreach (DataGridViewRow viewRow in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    pTable.AddCell(dcell.Value.ToString());
                                }
                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Dados exportados com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao exportar pdf", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            else
            {
                MessageBox.Show("Nenhum Registro Encontrado no datagridview", "Info");
            }
        }
    }
}
