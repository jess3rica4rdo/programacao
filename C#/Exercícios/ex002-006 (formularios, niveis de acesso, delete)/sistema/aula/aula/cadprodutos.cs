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
    public partial class cadprodutos : Form
    {
        string jj = @"Data Source=DESKTOP-HKMIROJ\SQLEXPRESS;Initial Catalog=Aula;Integrated Security=True";

        public cadprodutos()
        {
            InitializeComponent();
        }

        conexao conexao = new conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;

        public cadprodutos(String Nome, String Tipo, String Preço, String Estoque, String Data_registo)
        {
         cmd.CommandText = "insert into Produto (Nome, Tipo, Preço, Estoque, Data_registo) values (@Nome, @Tipo, @Preço, @Estoque, @Data_registo)";
         cmd.Parameters.AddWithValue("@Nome", Nome);
         cmd.Parameters.AddWithValue("@Tipo", Tipo);
         cmd.Parameters.AddWithValue("@Preço", Preço);
         cmd.Parameters.AddWithValue("@Estoque", Estoque);
         cmd.Parameters.AddWithValue("@Data_registo", Data_registo);

         try
         {
             cmd.Connection = conexao.conectar();
             cmd.ExecuteNonQuery();
             conexao.desconectar();
             this.mensagem = "Produto cadastrado com Sucesso";
         }
         catch (Exception)
         {
             this.mensagem = "Erro ao cadastrar Produto";
         }
        }
        public DataTable Produto()
        {
            SqlConnection conn = new SqlConnection(jj);
            DataTable dt = new DataTable();
            SqlDataAdapter apter = new SqlDataAdapter("select* from Produto", conn);
            apter.Fill(dt);
            return dt;
        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
          cadprodutos c = new cadprodutos(txt_nomeproduto.Text, txt_tipo.Text, txt_preco.Text, txt_estoque.Text, txt_dataregisto.Text);
          MessageBox.Show(c.mensagem);
        }

        private void bt_visualizar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Produto();
        }
     
    }
}



