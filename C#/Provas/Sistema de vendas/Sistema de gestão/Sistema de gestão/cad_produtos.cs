using CapaDados;
using CapaEntidade;
using DocumentFormat.OpenXml.Spreadsheet;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Sistema_de_gestão.utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Clipboard = System.Windows.Forms.Clipboard;
using DataObject = System.Windows.Forms.DataObject;
using MessageBox = System.Windows.Forms.MessageBox;



namespace Sistema_de_gestão
{
    public partial class cad_produtos : Form
    {
        string jj = @"Data Source=DESKTOP-HKMIROJ\SQLEXPRESS;Initial Catalog=loja;Integrated Security=True";

        public cad_produtos()
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
            SqlDataAdapter apter = new SqlDataAdapter("SELECT cod_produto AS ID, nome_produto AS Nome, categoria AS Categoria, estado AS Estado, stock AS Stock, preco_compra AS Preço_Compra, preco_venda AS Preço_venda, add_por AS Adicionado_por, data_registro AS Data FROM produto", conn);
            apter.Fill(dt);
            return dt;
        }

        private void cad_produtos_Load(object sender, EventArgs e)
        {

            string jj = @"Data Source=DESKTOP-HKMIROJ\SQLEXPRESS;Initial Catalog=loja;Integrated Security=True";
            string sql = "SELECT * FROM usuario WHERE nome_usuario=@nome_usuario";

            SqlConnection con = new SqlConnection(jj);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@nome_usuario", vm.NomeFuncionario1);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dgvusuario.DataSource = produto();

            while (dr.Read())
            {
                txt_addpor.Text = (string)dr["nome_completo"];
            }
            dr.Close();
        }

        public cad_produtos(String nome_produto, String categoria, String descricao, String estado, String stock, String preco_compra, String preco_venda, String add_por, DateTime data_registro)
        {
            cmd.CommandText = "INSERT INTO produto (nome_produto, categoria, descricao, estado, stock, preco_compra, preco_venda, add_por, data_registro) VALUES (@nome_produto, @categoria, @descricao, @estado, @stock, @preco_compra, @preco_venda, @add_por, @data_registro)";
            cmd.Parameters.AddWithValue("@nome_produto", nome_produto);
            cmd.Parameters.AddWithValue("@categoria", categoria);
            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@estado", estado);
            cmd.Parameters.AddWithValue("@stock", stock);
            cmd.Parameters.AddWithValue("@preco_compra", preco_compra);
            cmd.Parameters.AddWithValue("@preco_venda", preco_venda);
            cmd.Parameters.AddWithValue("@add_por", add_por);
            cmd.Parameters.AddWithValue("@data_registro", data_registro);

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                MessageBox.Show("Produto cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao produto Usuario", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if ((txt_nomeproduto.Text == "") || (comb_categoria.Text == "") || (txt_descricao.Text == "") || (txt_estado.Text == "") || (txt_estoque.Text == "") || (txt_precocompra.Text == "") || (txt_precovenda.Text == ""))
            {
                MessageBox.Show("preencha os espaços vazios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cad_produtos c = new cad_produtos(txt_nomeproduto.Text, comb_categoria.Text, txt_descricao.Text, txt_estado.Text, txt_estoque.Text, txt_precocompra.Text, txt_precovenda.Text, txt_addpor.Text, DateTime.Now);
                MessageBox.Show(c.mensagem);

                txt_codusuario.Text = "0";
                txt_nomeproduto.Text = "";
                comb_categoria.Text = "";
                txt_descricao.Text = "";
                txt_estado.Text = "";
                txt_estoque.Text = "";
                txt_precocompra.Text = "";
                txt_precovenda.Text = "";

                dgvusuario.DataSource = produto();
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string del = "DELETE FROM produto WHERE cod_produto = @cod_produto";

            try
            {
                if (txt_codusuario.Text == "0")
                {
                    MessageBox.Show("Informe o código do Produto que deseja deletar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    SqlConnection conn = new SqlConnection(jj);
                    conn.Open();
                    SqlCommand Cmd = new SqlCommand(del, conn);
                    Cmd.Parameters.AddWithValue(@"cod_produto", txt_codusuario.Text);
                    Cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Deseja realmente eliminar esse Produto?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    txt_codusuario.Text = "0";
                    txt_nomeproduto.Text = "";
                    comb_categoria.Text = "";
                    txt_descricao.Text = "";
                    txt_estado.Text = "";
                    txt_estoque.Text = "";
                    txt_precocompra.Text = "";
                    txt_precovenda.Text = "";

                    dgvusuario.DataSource = produto();
                }
            }
            catch
            {
                MessageBox.Show("Erro ao eliminar o Produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_limpar_Click(object sender, EventArgs e)
        {
            txt_codusuario.Text = "0";
            txt_nomeproduto.Text = "";
            comb_categoria.Text = "";
            txt_descricao.Text = "";
            txt_estado.Text = "";
            txt_estoque.Text = "";
            txt_precocompra.Text = "";
            txt_precovenda.Text = "";
        }

        private void txt_pes_Click(object sender, EventArgs e)
        {
            string pes = "SELECT cod_produto AS ID, nome_produto AS Nome, categoria AS Categoria, descricao AS Descrição, estado AS Estado, stock AS Stock, preco_compra AS Preço_Compra, preco_venda AS Preço_venda, add_por AS Adicionado_por, data_registro AS Data FROM produto WHERE nome_produto LIKE @nome_produto";

            try
            {
                if (txt_pesquisar.Text == "")
                {
                    MessageBox.Show("A barra de pesquisa não pode estar em branco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                else
                {
                    SqlConnection conn = new SqlConnection(jj);
                    conn.Open();
                    SqlCommand Cmd = new SqlCommand(pes, conn);
                    Cmd.Parameters.AddWithValue(@"nome_produto", "%" + txt_pesquisar.Text + "%");
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

        private void txt_apagar_Click(object sender, EventArgs e)
        {
            txt_pesquisar.Text = "";

            dgvusuario.DataSource = produto();
        }

        private void dgvusuario_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txt_codusuario.Text = dgvusuario.Rows[rowIndex].Cells[0].Value.ToString();
            txt_nomeproduto.Text = dgvusuario.Rows[rowIndex].Cells[1].Value.ToString();
            comb_categoria.Text = dgvusuario.Rows[rowIndex].Cells[2].Value.ToString();
            txt_estado.Text = dgvusuario.Rows[rowIndex].Cells[3].Value.ToString();
            txt_estoque.Text = dgvusuario.Rows[rowIndex].Cells[4].Value.ToString();
            txt_precocompra.Text = dgvusuario.Rows[rowIndex].Cells[5].Value.ToString();
            txt_precovenda.Text = dgvusuario.Rows[rowIndex].Cells[6].Value.ToString();
            txt_addpor.Text = dgvusuario.Rows[rowIndex].Cells[7].Value.ToString();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                string edit = "UPDATE produto SET nome_produto = @nome_produto, categoria = @categoria, descricao = @descricao, estado = @estado, stock = @stock, preco_compra = @preco_compra, preco_venda = @preco_venda WHERE cod_produto = @cod_produto";

                SqlConnection conn = new SqlConnection(jj);
                conn.Open();
                SqlCommand Cmd = new SqlCommand(edit, conn);
                Cmd.Parameters.AddWithValue(@"cod_produto", txt_codusuario.Text);
                Cmd.Parameters.AddWithValue(@"nome_produto", txt_nomeproduto.Text);
                Cmd.Parameters.AddWithValue(@"categoria", comb_categoria.Text);
                Cmd.Parameters.AddWithValue(@"descricao", txt_descricao.Text);
                Cmd.Parameters.AddWithValue(@"estado", txt_estado.Text);
                Cmd.Parameters.AddWithValue(@"stock", txt_estoque.Text);
                Cmd.Parameters.AddWithValue(@"preco_compra", txt_precocompra.Text);
                Cmd.Parameters.AddWithValue(@"preco_venda", txt_precovenda.Text);
                Cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Deseja realmente editar os detalhes desse produto?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


                txt_codusuario.Text = "0";
                txt_nomeproduto.Text = "";
                comb_categoria.Text = "";
                txt_descricao.Text = "";
                txt_estado.Text = "";
                txt_estoque.Text = "";
                txt_precocompra.Text = "";
                txt_precovenda.Text = "";
                dgvusuario.DataSource = produto();
            }
            catch
            {
                MessageBox.Show("Erro ao editar os detalhes desse produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}