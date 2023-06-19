using CapaDados;
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
    public partial class cad_clientes : Form
    {
        string jj = @"Data Source=DESKTOP-HKMIROJ\SQLEXPRESS;Initial Catalog=loja;Integrated Security=True";

        public cad_clientes()
        {
            InitializeComponent();
        }

        conexao conexao = new conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;

        public DataTable cliente()
        {
            SqlConnection conn = new SqlConnection(jj);
            DataTable dt = new DataTable();
            SqlDataAdapter apter = new SqlDataAdapter("SELECT cod_cliente AS ID, nome_completo AS Nome, email AS Email, telefone AS Telefone, add_por AS Adicionado_por, data_registro AS Data FROM cliente", conn);
            apter.Fill(dt);
            return dt;
        }

        private void cad_clientes_Load(object sender, EventArgs e)
        {
            string jj = @"Data Source=DESKTOP-HKMIROJ\SQLEXPRESS;Initial Catalog=loja;Integrated Security=True";
            string sql = "SELECT * FROM usuario WHERE nome_usuario=@nome_usuario";


            SqlConnection con = new SqlConnection(jj);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@nome_usuario", vm.NomeFuncionario1);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dgvcliente.DataSource = cliente();

            while (dr.Read())
            {
                txt_addpor.Text = (string)dr["nome_completo"];
                txt_funcao.Text = (string)dr["funcao"];
            }
            dr.Close();

            if (txt_funcao.Text == "OPERADOR DE CAIXA")
            {
                btn_eliminar.Visible = false;
                iconButton3.Visible = false;
                btn_editar.Visible = false;
            }

            dgvcliente.DataSource = cliente();
        }

        public cad_clientes(String nome_completo, String email, String telefone, String add_por, DateTime data_registro)
        {
            cmd.CommandText = "INSERT INTO cliente (nome_completo, email, telefone, add_por, data_registro) VALUES (@nome_completo, @email, @telefone, @add_por, @data_registro)";
            cmd.Parameters.AddWithValue("@nome_completo", nome_completo);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@add_por", add_por);
            cmd.Parameters.AddWithValue("@data_registro", data_registro);

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                MessageBox.Show("Cliente cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao cadastrar Cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if ((txt_nomecompleto.Text == "") || (txt_email.Text == "") || (txt_telefone.Text == "+244 "))
            {
                MessageBox.Show("preencha os espaços vazios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cad_clientes cad = new cad_clientes(txt_nomecompleto.Text, txt_email.Text, txt_telefone.Text, txt_addpor.Text, DateTime.Now);
                MessageBox.Show(cad.mensagem);

                txt_codusuario.Text = "0";
                txt_nomecompleto.Clear();
                txt_email.Text = "";
                txt_telefone.Text = "+244 ";

                dgvcliente.DataSource = cliente();
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                string edit = "UPDATE cliente SET nome_completo = @nome_completo, email = @email, telefone = @telefone, WHERE cod_cliente = @cod_cliente";

                SqlConnection conn = new SqlConnection(jj);
                conn.Open();
                SqlCommand Cmd = new SqlCommand(edit, conn);
                Cmd.Parameters.AddWithValue(@"cod_cliente", txt_codusuario.Text);
                Cmd.Parameters.AddWithValue(@"nome_completo", txt_nomecompleto.Text);
                Cmd.Parameters.AddWithValue(@"email", txt_email.Text);
                Cmd.Parameters.AddWithValue(@"telefone", txt_telefone.Text);

                Cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Deseja realmente editar as credenciais desse Cliente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


                txt_codusuario.Text = "0";
                txt_nomecompleto.Clear();
                txt_email.Text = "";
                txt_telefone.Text = "+244 ";

                dgvcliente.DataSource = cliente();
            }
            catch
            {
                MessageBox.Show("Erro ao editar as credenciais desse Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvcliente_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txt_codusuario.Text = dgvcliente.Rows[rowIndex].Cells[0].Value.ToString();
            txt_nomecompleto.Text = dgvcliente.Rows[rowIndex].Cells[1].Value.ToString();
            txt_email.Text = dgvcliente.Rows[rowIndex].Cells[2].Value.ToString();
            txt_telefone.Text = dgvcliente.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            txt_codusuario.Text = "0";
            txt_nomecompleto.Text = "";
            txt_email.Text = "";
            txt_telefone.Text = "+244 ";
        }

        private void txt_pes_Click(object sender, EventArgs e)
        {
            string pes = "SELECT cod_cliente AS ID, nome_completo AS Nome, email AS Email, telefone AS Telefone, add_por AS Adicionado_por, data_registro AS Data FROM cliente WHERE nome_completo LIKE @nome_completo";

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
                    Cmd.Parameters.AddWithValue(@"nome_completo", "%" + txt_buscar.Text + "%");
                    SqlDataAdapter data = new SqlDataAdapter(Cmd);
                    DataSet consulta = new DataSet();
                    data.Fill(consulta);
                    dgvcliente.DataSource = consulta.Tables[0];
                }
            }
            catch
            {
                MessageBox.Show("Este cliente não foi encontrado no sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            txt_buscar.Text = "";

            dgvcliente.DataSource = cliente();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string del = "DELETE FROM cliente WHERE cod_cliente = @cod_cliente";

            try
            {
                if (txt_codusuario.Text == "0")
                {
                    MessageBox.Show("Informe o código do Cliente que deseja deletar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    SqlConnection conn = new SqlConnection(jj);
                    conn.Open();
                    SqlCommand Cmd = new SqlCommand(del, conn);
                    Cmd.Parameters.AddWithValue(@"cod_cliente", txt_codusuario.Text);
                    Cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Deseja realmente eliminar esse Cliente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    txt_codusuario.Text = "0";
                    txt_nomecompleto.Text = "";
                    txt_email.Text = "";
                    txt_telefone.Text = "+244 ";

                    dgvcliente.DataSource = cliente();
                }
            }
            catch
            {
                MessageBox.Show("Erro ao eliminar o Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvcliente_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txt_codusuario.Text = dgvcliente.Rows[rowIndex].Cells[0].Value.ToString();
            txt_nomecompleto.Text = dgvcliente.Rows[rowIndex].Cells[1].Value.ToString();
            txt_email.Text = dgvcliente.Rows[rowIndex].Cells[2].Value.ToString();
            txt_telefone.Text = dgvcliente.Rows[rowIndex].Cells[3].Value.ToString();
        }
    }
}
