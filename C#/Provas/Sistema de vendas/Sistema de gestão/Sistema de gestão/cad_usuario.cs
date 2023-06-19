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
using System.Windows.Markup;
using CapaDados;
using Sistema_de_gestão.utilidades;

namespace Sistema_de_gestão
{
    public partial class cad_usuario : Form
    {
        string jj = @"Data Source=DESKTOP-HKMIROJ\SQLEXPRESS;Initial Catalog=loja;Integrated Security=True";

        public cad_usuario()
        {
            InitializeComponent();
        }

        conexao conexao = new conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;

        public DataTable usuario()
        {
            SqlConnection conn = new SqlConnection(jj);
            DataTable dt = new DataTable();
            SqlDataAdapter apter = new SqlDataAdapter("SELECT cod_usuario AS ID, nome_completo AS Nome, idade AS Idade, genero AS Gênero, telefone AS Telefone, nome_usuario AS Usuário, senha AS Senha, funcao AS Função, add_por AS Adicionado_por, data_registro As Data FROM usuario", conn);
            apter.Fill(dt);
            return dt;
        }

        public cad_usuario(String nome_completo, String idade, String genero, String telefone, String nome_usuario, String senha, String funcao, String add_por, DateTime data_registro)
        {
            cmd.CommandText = "INSERT INTO usuario (nome_completo, idade, genero, telefone, nome_usuario, senha, funcao, add_por, data_registro) VALUES (@nome_completo, @idade, @genero, @telefone, @nome_usuario, @senha, @funcao, @add_por, @data_registro)";
            cmd.Parameters.AddWithValue("@nome_completo", nome_completo);
            cmd.Parameters.AddWithValue("@idade", idade);
            cmd.Parameters.AddWithValue("@genero", genero);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@nome_usuario", nome_usuario);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@funcao", funcao);
            cmd.Parameters.AddWithValue("@add_por", add_por);
            cmd.Parameters.AddWithValue("@data_registro", data_registro);

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                MessageBox.Show("Usuário cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao cadastrar Usuario", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cad_usuario_Load(object sender, EventArgs e)
        {
            string jj = @"Data Source=DESKTOP-HKMIROJ\SQLEXPRESS;Initial Catalog=loja;Integrated Security=True";
            string sql = "SELECT * FROM usuario WHERE nome_usuario=@nome_usuario";

            SqlConnection con = new SqlConnection(jj);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@nome_usuario", vm.NomeFuncionario1);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txt_addpor.Text = (string)dr["nome_completo"];

            }
            dr.Close();

            dgvusuario.DataSource = usuario();

        }
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {

            if ((txt_nomecompleto.Text == "") || (txt_senha.Text == "") || (comb_idade.Text == "") || (comb_genero.Text == "") || (txt_telefone.Text == "+244 ") || (txt_usuario.Text == "") || (txt_senha.Text == "") || (comb_funcao.Text == ""))
            {
                MessageBox.Show("preencha os espaços vazios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cad_usuario cad = new cad_usuario(txt_nomecompleto.Text, comb_idade.Text, comb_genero.Text, txt_telefone.Text, txt_usuario.Text, txt_senha.Text, comb_funcao.Text, txt_addpor.Text, DateTime.Now);
                MessageBox.Show(cad.mensagem);

                txt_codusuario.Text = "0";
                txt_nomecompleto.Clear();
                comb_idade.Text = "";
                comb_genero.Text = "";
                txt_telefone.Text = "+244 ";
                txt_usuario.Clear();
                txt_senha.Clear();
                comb_funcao.Text = "";

                dgvusuario.DataSource = usuario();
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string del = "DELETE FROM usuario WHERE cod_Usuario = @cod_usuario";

            try
            {
                if (txt_codusuario.Text == "0")
                {
                    MessageBox.Show("Informe o código do Usuario que deseja deletar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    SqlConnection conn = new SqlConnection(jj);
                    conn.Open();
                    SqlCommand Cmd = new SqlCommand(del, conn);
                    Cmd.Parameters.AddWithValue(@"cod_usuario", txt_codusuario.Text);
                    Cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Deseja realmente eliminar esse Usuário?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao eliminar o Usuario", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txt_codusuario.Text = "0";
            txt_nomecompleto.Clear();
            comb_idade.Text = "";
            comb_genero.Text = "";
            txt_telefone.Text = "+244 ";
            txt_usuario.Clear();
            txt_senha.Clear();
            comb_funcao.Text = "";

            dgvusuario.DataSource = usuario();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            txt_buscar.Clear();

            dgvusuario.DataSource = usuario();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

            try
            {
                string edit = "UPDATE usuario SET nome_completo = @nome_completo, idade = @idade, genero = @genero, telefone = @telefone, nome_usuario = @nome_usuario, senha = @senha, funcao = @funcao WHERE cod_Usuario = @cod_usuario";

                SqlConnection conn = new SqlConnection(jj);
                conn.Open();
                SqlCommand Cmd = new SqlCommand(edit, conn);
                Cmd.Parameters.AddWithValue(@"cod_usuario", txt_codusuario.Text);
                Cmd.Parameters.AddWithValue(@"nome_completo", txt_nomecompleto.Text);
                Cmd.Parameters.AddWithValue(@"idade", comb_idade.Text);
                Cmd.Parameters.AddWithValue(@"genero", comb_genero.Text);
                Cmd.Parameters.AddWithValue(@"telefone", txt_telefone.Text);
                Cmd.Parameters.AddWithValue(@"nome_usuario", txt_usuario.Text);
                Cmd.Parameters.AddWithValue(@"senha", txt_senha.Text);
                Cmd.Parameters.AddWithValue(@"funcao", comb_funcao.Text);
                Cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Deseja realmente editar as credenciais desse usuário?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                txt_codusuario.Text = "0";
                txt_nomecompleto.Clear();
                comb_idade.Text = "";
                comb_genero.Text = "";
                txt_telefone.Text = "+244 ";
                txt_usuario.Clear();
                txt_senha.Clear();
                comb_funcao.Text = "";

                dgvusuario.DataSource = usuario();
            }
            catch
            {
                MessageBox.Show("Erro ao editar as credenciais desse usuário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvusuario_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txt_codusuario.Text = dgvusuario.Rows[rowIndex].Cells[0].Value.ToString();
            txt_nomecompleto.Text = dgvusuario.Rows[rowIndex].Cells[1].Value.ToString();
            comb_idade.Text = dgvusuario.Rows[rowIndex].Cells[2].Value.ToString();
            comb_genero.Text = dgvusuario.Rows[rowIndex].Cells[3].Value.ToString();
            txt_telefone.Text = dgvusuario.Rows[rowIndex].Cells[4].Value.ToString();
            txt_usuario.Text = dgvusuario.Rows[rowIndex].Cells[5].Value.ToString();
            txt_senha.Text = dgvusuario.Rows[rowIndex].Cells[6].Value.ToString();
            comb_funcao.Text = dgvusuario.Rows[rowIndex].Cells[7].Value.ToString();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            txt_codusuario.Text = "0";
            txt_nomecompleto.Clear();
            comb_idade.Text = "";
            comb_genero.Text = "";
            txt_telefone.Text = "+244 ";
            txt_usuario.Clear();
            txt_senha.Clear();
            comb_funcao.Text = "";
        }

        private void txt_pes_Click(object sender, EventArgs e)
        {
            string pes = "SELECT cod_usuario AS ID, nome_completo AS Nome, idade AS Idade, genero AS Gênero, telefone AS Telefone, nome_usuario AS Usuário, senha AS Senha, funcao AS Função, add_por AS Adicionado_por, data_registro As Data FROM usuario WHERE nome_completo LIKE @nome_completo";

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
                    dgvusuario.DataSource = consulta.Tables[0];
                }
            }
            catch
            {
                MessageBox.Show("Este usuário não foi encontrado no sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txt_telefone_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}