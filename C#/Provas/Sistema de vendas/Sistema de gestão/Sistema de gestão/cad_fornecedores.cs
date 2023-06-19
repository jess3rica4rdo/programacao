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
    public partial class cad_fornecedores : Form
    {
        string jj = @"Data Source=DESKTOP-HKMIROJ\SQLEXPRESS;Initial Catalog=loja;Integrated Security=True";

        public cad_fornecedores()
        {
            InitializeComponent();
        }

        conexao conexao = new conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;

        public DataTable fornecedor()
        {
            SqlConnection conn = new SqlConnection(jj);
            DataTable dt = new DataTable();
            SqlDataAdapter apter = new SqlDataAdapter("SELECT cod_fornecedor As ID, nif As NIF, razao_social As Razão_Social, email As Email, telefone As Telefone, add_por As Adicionado_por, data_registro as Data FROM fornecedor", conn);
            apter.Fill(dt);
            return dt;
        }

        private void cad_fornecedores_Load(object sender, EventArgs e)
        {
            string jj = @"Data Source=DESKTOP-HKMIROJ\SQLEXPRESS;Initial Catalog=loja;Integrated Security=True";
            string sql = "SELECT * FROM usuario WHERE nome_usuario=@nome_usuario";


            SqlConnection con = new SqlConnection(jj);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@nome_usuario", vm.NomeFuncionario1);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            dgvfornecedor.DataSource = fornecedor();

            while (dr.Read())
            {
                txt_addpor.Text = (string)dr["nome_completo"];
            }
            dr.Close();
        }

        public cad_fornecedores(String nif, String razao_social, String email, String telefone, String add_por, DateTime data_registro)
        {
            cmd.CommandText = "INSERT INTO fornecedor (nif, razao_social, email, telefone, add_por, data_registro) VALUES (@nif, @razao_social, @email, @telefone, @add_por, @data_registro)";
            cmd.Parameters.AddWithValue("@nif", nif);
            cmd.Parameters.AddWithValue("@razao_social", razao_social);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@add_por", add_por);
            cmd.Parameters.AddWithValue("@data_registro", data_registro);

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                MessageBox.Show("Fornecedor cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao cadastrar Fornecedor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if ((txt_nif.Text == "") || (txt_razaosocial.Text == "") || (txt_email.Text == "") || (txt_telefone.Text == "+244 "))
            {
                MessageBox.Show("preencha os espaços vazios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cad_fornecedores cad = new cad_fornecedores(txt_nif.Text, txt_razaosocial.Text, txt_email.Text, txt_telefone.Text, txt_addpor.Text, DateTime.Now);
                MessageBox.Show(cad.mensagem);

                txt_codusuario.Text = "0";
                txt_nif.Text = "";
                txt_email.Text = "";
                txt_telefone.Text = "+244 ";
                txt_razaosocial.Text = "";

                dgvfornecedor.DataSource = fornecedor();
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                string edit = "UPDATE fornecedor SET nif = @nif, razao_social = @razao_social, email = @email, telefone = @telefone, WHERE cod_forncedor = @cod_fornecedor";

                SqlConnection conn = new SqlConnection(jj);
                conn.Open();
                SqlCommand Cmd = new SqlCommand(edit, conn);
                Cmd.Parameters.AddWithValue(@"cod_fornecedor", txt_codusuario.Text);
                Cmd.Parameters.AddWithValue(@"nif", txt_nif.Text);
                Cmd.Parameters.AddWithValue(@"razao_social", txt_razaosocial.Text);
                Cmd.Parameters.AddWithValue(@"email", txt_email.Text);
                Cmd.Parameters.AddWithValue(@"telefone", txt_telefone.Text);

                Cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Deseja realmente editar as credenciais desse Fornecedor?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


                txt_codusuario.Text = "0";
                txt_nif.Text = "";
                txt_razaosocial.Text = "";
                txt_email.Text = "";
                txt_telefone.Text = "+244 ";

                dgvfornecedor.DataSource = fornecedor();
            }
            catch
            {
                MessageBox.Show("Erro ao editar as credenciais desse Fornecedor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            txt_codusuario.Text = "0";
            txt_nif.Text = "";
            txt_razaosocial.Text = "";
            txt_email.Text = "";
            txt_telefone.Text = "+244 ";
        }

        private void txt_pes_Click(object sender, EventArgs e)
        {
            string pes = "SELECT cod_fornecedor As ID, nif As NIF, razao_social As Razão_Social, email As Email, telefone As Telefone, add_por As Adicionado_por, data_registro as Data FROM fornecedor WHERE nif LIKE @nif";

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
                    Cmd.Parameters.AddWithValue(@"nif", "%" + txt_buscar.Text + "%");
                    SqlDataAdapter data = new SqlDataAdapter(Cmd);
                    DataSet consulta = new DataSet();
                    data.Fill(consulta);
                    dgvfornecedor.DataSource = consulta.Tables[0];
                }
            }
            catch
            {
                MessageBox.Show("Este fornecedor não foi encontrado no sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            txt_buscar.Text = "";

            dgvfornecedor.DataSource = fornecedor();


        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string del = "DELETE FROM fornecedor WHERE cod_fornecedor = @cod_fornecedor";

            try
            {
                if (txt_codusuario.Text == "0")
                {
                    MessageBox.Show("Informe o código do Fornecedor que deseja deletar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    SqlConnection conn = new SqlConnection(jj);
                    conn.Open();
                    SqlCommand Cmd = new SqlCommand(del, conn);
                    Cmd.Parameters.AddWithValue(@"cod_fornecedor", txt_codusuario.Text);
                    Cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Deseja realmente eliminar esse Fornecedor?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    txt_codusuario.Text = "0";
                    txt_nif.Text = "";
                    txt_razaosocial.Text = "";
                    txt_email.Text = "";
                    txt_telefone.Text = "+244 ";

                    dgvfornecedor.DataSource = fornecedor();
                }
            }
            catch
            {
                MessageBox.Show("Erro ao eliminar o Fornecedor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvfornecedor_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txt_codusuario.Text = dgvfornecedor.Rows[rowIndex].Cells[0].Value.ToString();
            txt_nif.Text = dgvfornecedor.Rows[rowIndex].Cells[1].Value.ToString();
            txt_razaosocial.Text = dgvfornecedor.Rows[rowIndex].Cells[2].Value.ToString();
            txt_email.Text = dgvfornecedor.Rows[rowIndex].Cells[3].Value.ToString();
            txt_telefone.Text = dgvfornecedor.Rows[rowIndex].Cells[4].Value.ToString();
        }
    }
}
