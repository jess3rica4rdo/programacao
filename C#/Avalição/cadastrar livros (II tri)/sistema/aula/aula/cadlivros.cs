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

namespace aula
{
    public partial class cadlivros : Form
    {
        string jj = @"Data Source=DESKTOP-HKMIROJ\SQLEXPRESS;Initial Catalog=Biblioteca;Integrated Security=True";   

        public cadlivros()
        {
            InitializeComponent();
        }

        conexao conexao = new conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;

        public cadlivros(String NomeAutor, String Titulo, String Editora, String Edicao, String Endereco)
        {
            cmd.CommandText = "INSERT INTO Livro (NomeAutor, Titulo, Editora, Edicao, Endereco) VALUES (@NomeAutor, @Titulo, @Editora, @Edicao, @Endereco)";
            cmd.Parameters.AddWithValue("@NomeAutor", NomeAutor);
            cmd.Parameters.AddWithValue("@Titulo", Titulo);
            cmd.Parameters.AddWithValue("@Editora", Editora);
            cmd.Parameters.AddWithValue("@Edicao", Edicao);
            cmd.Parameters.AddWithValue("@Endereco", Endereco);

         try
         {
             cmd.Connection = conexao.conectar();
             cmd.ExecuteNonQuery();
             conexao.desconectar();
             this.mensagem = "Livro cadastrado com Sucesso";
         }
         catch (Exception)
         {
             this.mensagem = "Erro ao cadastrar Livro";
         }
        }

        public DataTable Livro()
        {
            SqlConnection conn = new SqlConnection(jj);
            DataTable dt = new DataTable();
            SqlDataAdapter apter = new SqlDataAdapter("select* from Livro", conn);
            apter.Fill(dt);
            return dt;
        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
              cadlivros l = new cadlivros(txt_nomeautor.Text, txt_titulo.Text, txt_editora.Text, txt_edicao.Text, txt_endereco.Text);
              MessageBox.Show(l.mensagem);
              txt_nomeautor.Clear();
              txt_titulo.Clear();
              txt_editora.Clear();
              txt_edicao.Clear();
              txt_endereco.Clear();
              dataGridView1.DataSource = Livro();
            }

        private void bt_visualizar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Livro();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string del = "DELETE FROM Livro WHERE CodLivro = @CodLivro";
            
            try
            {
                SqlConnection conn = new SqlConnection(jj);
                conn.Open();
                SqlCommand Cmd = new SqlCommand(del, conn);
                Cmd.Parameters.AddWithValue(@"CodLivro", txt_codlivro.Text);
                Cmd.ExecuteNonQuery();
                txt_nomeautor.Focus();
                conn.Close();
                MessageBox.Show("Livro Deletado com sucesso");
            }
            catch
            {
                MessageBox.Show("Erro ao Deletar o Livro");
            }

            txt_codlivro.Clear();
            dataGridView1.DataSource = Livro();
        }

        private void bt_pesquisar_Click(object sender, EventArgs e)
        {
            string pes = "SELECT Titulo, Edicao, NomeAutor FROM Livro WHERE Titulo LIKE @Titulo";

            try
            {
                SqlConnection conn = new SqlConnection(jj);
                conn.Open();
                SqlCommand Cmd = new SqlCommand(pes, conn);
                Cmd.Parameters.AddWithValue(@"Titulo", "%" + txt_titulo.Text + "%");
                SqlDataAdapter data = new SqlDataAdapter(Cmd);
                DataSet consulta = new DataSet();
                data.Fill(consulta);
                dataGridView1.DataSource = consulta.Tables[0];
            }
            catch
            {
                MessageBox.Show("Este Livro não está resgistrado no sistema");
            }

        }
     
    }
}



