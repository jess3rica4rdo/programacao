using CapaDados;
using CapaEntidade;
using DocumentFormat.OpenXml.EMMA;
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
using System.Windows.Forms;


namespace Sistema_de_gestão
{
    public partial class compras : Form
    {

        string jj = @"Data Source=DESKTOP-HKMIROJ\SQLEXPRESS;Initial Catalog=loja;Integrated Security=True";

        conexao conexao = new conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;

        public compras()
        {
            InitializeComponent();
        }

        private void compras_Load(object sender, EventArgs e)
        {
            dgvcompra.ColumnCount = 8;
            dgvcompra.Columns[0].Name = "Produto";
            dgvcompra.Columns[1].Name = "Fornecedor";
            dgvcompra.Columns[2].Name = "Preço compra";
            dgvcompra.Columns[3].Name = "Quantidade";
            dgvcompra.Columns[4].Name = "Subtotal";
            dgvcompra.Columns[5].Name = "Data";
            dgvcompra.Columns[6].Name = "Tipo de Documento";
            dgvcompra.Columns[7].Name = "Registrado por";

            dgvcompra.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvcompra.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvcompra.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvcompra.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvcompra.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvcompra.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvcompra.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvcompra.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            comb_tipodocumento.Items.Add(new opcaocombo() { Valor = "Comprovativo", Texto = "Comprovativo" });
            comb_tipodocumento.Items.Add(new opcaocombo() { Valor = "Fatura", Texto = "Fatura" });
            comb_tipodocumento.DisplayMember = "Texto";
            comb_tipodocumento.ValueMember = "Valor";
            comb_tipodocumento.SelectedIndex = 0;

            txt_data.Text = DateTime.Now.ToString("dd/MM/yyyy");

            txt_idfornecedor.Text = "0";
            txt_idproduto.Text = "0";
            txt_valortotal.Text = "0";

            string jj = @"Data Source=DESKTOP-HKMIROJ\SQLEXPRESS;Initial Catalog=loja;Integrated Security=True";
            string sql = "SELECT * FROM usuario WHERE nome_usuario=@nome_usuario";

            SqlConnection con = new SqlConnection(jj);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@nome_usuario", vm.NomeFuncionario1);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txt_nomeusuario.Text = (string)dr["nome_completo"];
            }
            dr.Close();
        }

        private void btn_pesquisarfornecedor_Click(object sender, EventArgs e)
        {
            using (var modal = new pes_fornecedor())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txt_idfornecedor.Text = modal.cfornecedor.cod_fornecedor.ToString();
                    txt_nif.Text = modal.cfornecedor.nif.ToString();
                    txt_razaosocial.Text = modal.cfornecedor.razao_social.ToString();
                }
                else
                {
                    txt_nif.Select();
                }
            }
        }

        private void btn_pesquisarproduto_Click(object sender, EventArgs e)
        {
            using (var modal = new pes_produto1())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txt_idproduto.Text = modal.cproduto.cod_produto.ToString();
                    txt_codproduto.Text = modal.cproduto.nome_produto.ToString();
                    txt_produto.Text = modal.cproduto.categoria.ToString();
                    txt_precocompra.Text = modal.cproduto.preco_compra.ToString();
                }
                else
                {
                    txt_codproduto.Select();
                }
            }
        }

        private void txt_adicionar_Click(object sender, EventArgs e)
        {
            decimal precocompra = 0;

            if (int.Parse(txt_idproduto.Text) == 0)
            {
                MessageBox.Show("Selecione o produto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txt_precocompra.Text, out precocompra))
            {
                MessageBox.Show("formato de preço de compra incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            else
            {
                if ((txt_codproduto.Text == "") || (txt_idproduto.Text == "0") || (txt_produto.Text == "") || (txt_precocompra.Text == ""))
                {
                    MessageBox.Show("Preencha todos os dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else
                {
                    dgvcompra.Rows.Add(txt_idproduto.Text, txt_idfornecedor.Text, txt_precocompra.Text, numeric_quantiidade.Value, txt_data.Text, txt_data.Text, comb_tipodocumento.Text, txt_nomeusuario.Text);

                    if (dgvcompra.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow row in dgvcompra.Rows)
                        {
                            double preco, quant, total;

                            preco = Convert.ToDouble(row.Cells[2].Value.ToString());
                            quant = Convert.ToDouble(row.Cells[3].Value.ToString());

                            total = preco * quant;

                            row.Cells[4].Value = Convert.ToString(total);
                            row.Cells[4].Value = string.Format("{0:n}", double.Parse((string)row.Cells[4].Value));
                        }
                    }
                    decimal tt = 0;
                    foreach (DataGridViewRow row in dgvcompra.Rows)
                    {
                        tt += Convert.ToDecimal(row.Cells["Subtotal"].Value);
                    }
                    txt_valortotal.Text = tt.ToString();
                }
            }
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            string jn = @"Data Source=DESKTOP-HKMIROJ\SQLEXPRESS;Initial Catalog=loja;Integrated Security=True";
            SqlConnection conn123 = new SqlConnection(jn);
            string Sql1 = "select cod_produto from produto where nome_produto = @nome_produto  and stock != 0";
            SqlCommand cmd1 = new SqlCommand(Sql1, conn123);
            conn123.Open();
            cmd1.Parameters.AddWithValue("@nome_produto", txt_codproduto.Text);
            int CodProduto = (int)cmd1.ExecuteScalar();

            string Sql2 = "select stock from produto where nome_produto = @nome_produto  and stock != 0";
            SqlCommand cmd2 = new SqlCommand(Sql2, conn123);
            cmd2.Parameters.AddWithValue("@nome_produto", txt_codproduto.Text);
            int QuantidadeActual = (int)cmd2.ExecuteScalar();

            SqlDataAdapter cmd3 = new SqlDataAdapter();
            cmd3.InsertCommand = new SqlCommand("update produto set stock = @stock where cod_produto = @cod_produto", conn123);
            cmd3.InsertCommand.Parameters.Add("@stock", SqlDbType.VarChar).Value = QuantidadeActual + Convert.ToInt32(numeric_quantiidade.Value);
            cmd3.InsertCommand.Parameters.Add("@cod_produto", SqlDbType.Int).Value = CodProduto;
            cmd3.InsertCommand.ExecuteNonQuery();

            conn123.Close();

            string jj = @"Data Source=DESKTOP-HKMIROJ\SQLEXPRESS;Initial Catalog=loja;Integrated Security=True";
            SqlConnection conn = new SqlConnection(jj);
            string sql = "INSERT INTO compra VALUES (@cod_produto, @cod_fornecedor, @preco_compra, @quantidade, @subtotal, @valor_total, @data_compra, @tipo_documento, @registrado_por)";

            try
            {
                conn.Open();
                for (int i = 0; i < dgvcompra.Rows.Count - 0; i++)
                {
                    SqlCommand comando = new SqlCommand(sql, conn);
                    comando.Parameters.AddWithValue("@cod_produto", dgvcompra.Rows[i].Cells["Produto"].Value);
                    comando.Parameters.AddWithValue("@cod_fornecedor", dgvcompra.Rows[i].Cells["Fornecedor"].Value);
                    comando.Parameters.AddWithValue("@preco_compra", dgvcompra.Rows[i].Cells["Preço compra"].Value);
                    comando.Parameters.AddWithValue("@quantidade", dgvcompra.Rows[i].Cells["Quantidade"].Value);
                    comando.Parameters.AddWithValue("@subtotal", dgvcompra.Rows[i].Cells["Subtotal"].Value);
                    comando.Parameters.AddWithValue("@valor_total", SqlDbType.VarChar).Value = txt_valortotal.Text;
                    comando.Parameters.AddWithValue("@data_compra", dgvcompra.Rows[i].Cells["Data"].Value);
                    comando.Parameters.AddWithValue("@tipo_documento", dgvcompra.Rows[i].Cells["Tipo de Documento"].Value);
                    comando.Parameters.AddWithValue("@registrado_por", dgvcompra.Rows[i].Cells["Registrado por"].Value);

                    comando.CommandText = sql;
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Compra reistrada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_codproduto.Text = "";
                    txt_idproduto.Text = "0";
                    txt_produto.Text = "";
                    txt_precocompra.Text = "";
                    numeric_quantiidade.Value = 1;
                    txt_idfornecedor.Text = "";
                    txt_nif.Text = "";
                    txt_razaosocial.Text = "";
                    txt_valortotal.Text = "";
                    dgvcompra.Rows.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                conn.Close();
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            txt_valortotal.Text = "";
            dgvcompra.Rows.Clear();
        }
    }
}
