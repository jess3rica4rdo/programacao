using CapaDados;
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
using Sistema_de_gestão.utilidades;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Sistema_de_gestão
{
    public partial class vendas : Form
    {
        string jj = @"Data Source=DESKTOP-HKMIROJ\SQLEXPRESS;Initial Catalog=loja;Integrated Security=True";

        public vendas()
        {
            InitializeComponent();
        }

        conexao conexao = new conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;

        private void btn_pesquisarfornecedor_Click(object sender, EventArgs e)
        {
            using (var modal = new pes_cliente())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txt_codcliente.Text = modal.cclientes.cod_cliente.ToString();
                    txt_nomecliente.Text = modal.cclientes.nome_completo.ToString();
                }
                else
                {
                    txt_nomecliente.Select();
                }
            }
        }

        private void vendas_Load(object sender, EventArgs e)
        {
            dgvcompra.ColumnCount = 8;
            dgvcompra.Columns[0].Name = "Produto";
            dgvcompra.Columns[1].Name = "Cliente";
            dgvcompra.Columns[2].Name = "Preço venda";
            dgvcompra.Columns[3].Name = "Quantidade";
            dgvcompra.Columns[4].Name = "Subtotal";
            dgvcompra.Columns[5].Name = "Data";
            dgvcompra.Columns[6].Name = "Tipo de Documento";
            dgvcompra.Columns[7].Name = "Registrado Por";

            dgvcompra.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvcompra.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvcompra.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvcompra.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvcompra.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvcompra.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvcompra.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvcompra.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            comb_tipodocumento.Items.Add(new opcaocombo() { Valor = "Cartão Multicaixa", Texto = "Cartão Multicaixa" });
            comb_tipodocumento.Items.Add(new opcaocombo() { Valor = "Transferência", Texto = "Transferência" });
            comb_tipodocumento.Items.Add(new opcaocombo() { Valor = "Cash", Texto = "Cash" });
            comb_tipodocumento.DisplayMember = "Texto";
            comb_tipodocumento.ValueMember = "Valor";
            comb_tipodocumento.SelectedIndex = 0;

            txt_data.Text = DateTime.Now.ToString("dd/MM/yyyy");

            txt_codcliente.Text = "1";
            txt_idproduto.Text = "0";

            txt_iva.Text = "14%";
            txt_valorcompra.Text = "0,00";
            txt_valortotal.Text = "0,00";
            txt_valorpago.Text = "0,00";
            txt_troco.Text = "0,00";

            string jj = @"Data Source=DESKTOP-HKMIROJ\SQLEXPRESS;Initial Catalog=loja;Integrated Security=True";
            string sql = "SELECT * FROM usuario WHERE nome_usuario=@nome_usuario";

            SqlConnection con = new SqlConnection(jj);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@nome_usuario", vm.NomeFuncionario1);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txt_nomeusuario.Text = Convert.ToString(dr["cod_usuario"]);
                txt_usu.Text = (string)dr["nome_completo"];
            }
            dr.Close();
        }

        private void btn_pesquisarproduto_Click(object sender, EventArgs e)
        {

            using (var modal = new pes_produto2())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txt_idproduto.Text = modal.cproduto.cod_produto.ToString();
                    txt_codproduto.Text = modal.cproduto.nome_produto.ToString();
                    txt_produto.Text = modal.cproduto.categoria.ToString();
                    txt_descricao.Text = modal.cproduto.descricao.ToString();
                    txt_estoque.Text = modal.cproduto.stock.ToString();
                    txt_precovenda.Text = modal.cproduto.preco_venda.ToString();
                }
                else
                {
                    txt_codproduto.Select();
                }
            }
        }

        private void txt_adicionar_Click(object sender, EventArgs e)
        {
            if ((txt_idproduto.Text == "0"))
            {
                MessageBox.Show("Selecione o produto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if ((txt_idproduto.Text == "0"))
            {
                MessageBox.Show("Preencha todos os dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (Convert.ToDecimal(txt_estoque.Text.ToString()) <= 2)
            {
                MessageBox.Show("Este produto atingiu o estoque mínimo, impossível vender", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (Convert.ToDecimal(txt_calculo.Text.ToString()) <= 2)
            {
                MessageBox.Show("Quantidade em estoque deste produto insuficiente", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else
            {
                dgvcompra.Rows.Add(txt_idproduto.Text, txt_codcliente.Text, txt_precovenda.Text, numeric_quantiidade.Value, txt_data.Text, txt_data.Text, comb_tipodocumento.Text, txt_nomeusuario.Text);

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
                txt_valorcompra.Text = tt.ToString();

            }

            double vl = Convert.ToDouble(txt_valorcompra.Text.ToString());
            double iva = 0.14;
            double result = vl * iva;
            txt_iva.Text = Convert.ToString(result);
            txt_iva.Text = string.Format("{0:n}", double.Parse((string)txt_iva.Text));

            double vt = Convert.ToDouble(txt_valorcompra.Text.ToString());
            double ivainc = Convert.ToDouble(txt_iva.Text.ToString());
            double resul = vt + ivainc;
            txt_valortotal.Text = Convert.ToString(resul);
            txt_valortotal.Text = string.Format("{0:n}", double.Parse((string)txt_valortotal.Text));
        }

        private void txt_valorpago_TextChanged(object sender, EventArgs e)
        {
            double vp = Convert.ToDouble(txt_valorpago.Text.ToString());
            double vlt = Convert.ToDouble(txt_valortotal.Text.ToString());
            double troc = vp - vlt;
            txt_troco.Text = Convert.ToString(troc);
            txt_troco.Text = string.Format("{0:n}", double.Parse((string)txt_troco.Text));
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {

            if ((txt_valorpago.Text == "0,00"))
            {
                MessageBox.Show("Selecione o valor pago pelo Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (Convert.ToDecimal(txt_troco.Text.ToString()) < 0)
            {
                MessageBox.Show("Valor pago insuficiente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            else
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
                cmd3.InsertCommand.Parameters.Add("@stock", SqlDbType.VarChar).Value = QuantidadeActual - Convert.ToInt32(numeric_quantiidade.Value);
                cmd3.InsertCommand.Parameters.Add("@cod_produto", SqlDbType.Int).Value = CodProduto;
                cmd3.InsertCommand.ExecuteNonQuery();

                conn123.Close();

                string js = @"Data Source=DESKTOP-HKMIROJ\SQLEXPRESS;Initial Catalog=loja;Integrated Security=True";
                SqlConnection conn = new SqlConnection(js);
                string sql = "INSERT INTO venda VALUES (@cod_produto, @cod_cliente, @preco_venda, @quantidade, @subtotal, @iva, @valor_total, @valor_pago, @troco, @data_venda, @forma_pagamento, @cod_usuario)";

                try
                {
                    conn.Open();
                    for (int i = 0; i < dgvcompra.Rows.Count - 0; i++)
                    {
                        SqlCommand Cmd = new SqlCommand(sql, conn);
                        Cmd.Parameters.AddWithValue("@cod_produto", dgvcompra.Rows[i].Cells["Produto"].Value);
                        Cmd.Parameters.AddWithValue("@cod_cliente", dgvcompra.Rows[i].Cells["Cliente"].Value);
                        Cmd.Parameters.AddWithValue("@preco_venda", dgvcompra.Rows[i].Cells["Preço venda"].Value);
                        Cmd.Parameters.AddWithValue("@quantidade", dgvcompra.Rows[i].Cells["Quantidade"].Value);
                        Cmd.Parameters.AddWithValue("@subtotal", dgvcompra.Rows[i].Cells["Subtotal"].Value);
                        Cmd.Parameters.AddWithValue("@iva", SqlDbType.VarChar).Value = txt_iva.Text;
                        Cmd.Parameters.AddWithValue("@valor_total", SqlDbType.VarChar).Value = txt_valortotal.Text;
                        Cmd.Parameters.AddWithValue("@valor_pago", SqlDbType.VarChar).Value = txt_valorpago.Text;
                        Cmd.Parameters.AddWithValue("@troco", SqlDbType.VarChar).Value = txt_troco.Text;
                        Cmd.Parameters.AddWithValue("@data_venda", dgvcompra.Rows[i].Cells["Data"].Value);
                        Cmd.Parameters.AddWithValue("@forma_pagamento", dgvcompra.Rows[i].Cells["Tipo de Documento"].Value);
                        Cmd.Parameters.AddWithValue("@cod_usuario", dgvcompra.Rows[i].Cells["Registrado por"].Value);

                        Cmd.CommandText = sql;
                        Cmd.ExecuteNonQuery();

                        if ((txt_troco.Text == "0,00"))
                        {
                            MessageBox.Show("Venda realizada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("O troco do(a) " + txt_nomecliente.Text + " é de:\n" + txt_troco.Text, "Venda efectuada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    try
                    {
                        clsFactura.CreaTicket Ticket1 = new clsFactura.CreaTicket();

                        Ticket1.TextoIzquierda("*******************************************************");
                        Ticket1.TextoIzquierda("                    Sistema de venda");
                        Ticket1.TextoIzquierda("");
                        Ticket1.TextoIzquierda("*******************************************************");

                        Ticket1.TextoIzquierda("Dirc: xxxx");
                        Ticket1.TextoIzquierda("Tel:xxxx ");
                        Ticket1.TextoIzquierda("Rnc: xxxx");
                        Ticket1.TextoIzquierda("");

                        Ticket1.TextoIzquierda("                    Fatura de venda");

                        Ticket1.TextoIzquierda("");
                        Ticket1.TextoIzquierda("Nº Fac: 202020");
                        Ticket1.TextoIzquierda("Data:" + DateTime.Now.ToShortDateString() + "  Hora:" + DateTime.Now.ToShortTimeString());
                        Ticket1.TextoIzquierda("Atendido por: " + txt_usu.Text);
                        Ticket1.TextoIzquierda("Cliente: " + txt_nomecliente.Text);
                        Ticket1.TextoIzquierda("");

                        clsFactura.CreaTicket.LineasGuion();
                        Ticket1.TextoIzquierda("                      Dados da compra");
                        clsFactura.CreaTicket.LineasGuion();
                        Ticket1.TextoIzquierda("Produto             Preço           Qnt.       Subtotal");
                        clsFactura.CreaTicket.LineasGuion();
                        Ticket1.TextoIzquierda(txt_codproduto.Text + "         " + txt_precovenda.Text + "       " + numeric_quantiidade.Text + "        " + txt_valorcompra.Text);
                        clsFactura.CreaTicket.LineasGuion();
                        Ticket1.TextoIzquierda(" ");
                        Ticket1.AgregaTotales("Iva:", double.Parse(txt_iva.Text));
                        Ticket1.AgregaTotales("Total:", double.Parse(txt_valortotal.Text));
                        Ticket1.AgregaTotales("Valor Pago:", double.Parse(txt_valorpago.Text));
                        Ticket1.AgregaTotales("Troco:", double.Parse(txt_troco.Text));

                        Ticket1.TextoIzquierda(" ");
                        Ticket1.TextoIzquierda("*******************************************************");
                        Ticket1.TextoIzquierda("                  Obrigado pela preferência");
                        Ticket1.TextoIzquierda("");
                        Ticket1.TextoIzquierda("*******************************************************");
                        Ticket1.TextoIzquierda(" ");
                        string impresora = "Microsoft XPS Document Writer";
                        Ticket1.ImprimirTiket(impresora);


                        MessageBox.Show("Factura salva nos Documentos", "FACTURA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txt_idproduto.Text = "0";
                        txt_codproduto.Text = "";
                        txt_produto.Text = "";
                        txt_descricao.Text = "";
                        txt_estoque.Text = "0";
                        txt_precovenda.Text = "0,00";
                        numeric_quantiidade.Value = 1;
                        txt_troco.Text = "0,00";
                        txt_valorpago.Text = "0,00";
                        txt_valortotal.Text = "0,00";
                        txt_iva.Text = "14%";
                        txt_valorcompra.Text = "0,00";
                        txt_codcliente.Text = "1";
                        txt_nomecliente.Text = "@Cliente";
                        dgvcompra.Rows.Clear();
                        txt_troco.Text = "0,00";

                    }
                    catch
                    {
                        MessageBox.Show("Erro ao imprimir fatura", "FATURA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Erro ao efectuar venda", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void txt_valorpago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 14)
            {
                e.Handled = true;
            }
        }

        private void numeric_quantiidade_ValueChanged(object sender, EventArgs e)
        {
            double est = Convert.ToDouble(txt_estoque.Text.ToString());
            double qnt = Convert.ToDouble(numeric_quantiidade.Value.ToString());
            double result = est - qnt;
            txt_calculo.Text = Convert.ToString(result);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            dgvcompra.Rows.Clear();
            txt_valortotal.Text = "0,00";
            txt_iva.Text = "14%";
            txt_valorcompra.Text = "0,00";
        }
    }
}