using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace sistema_Aula
{
    public partial class cadprodutos : Form
    {
        public cadprodutos()
        {
            InitializeComponent();
           }

        string pembele = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Aula;Data Source=DESKTOP-QJSJVU3\SQLEXPRESS"; 

        private void btcadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(pembele);
            SqlDataAdapter Cmd = new SqlDataAdapter();
            // Código para inserir dados na base de dados a partir do C#
            Cmd.InsertCommand = new SqlCommand("INSERT INTO Produtos VALUES(@Nome_produto,@Tipo_produto,@Preco,@Qtd_Estoque)", conn);
            // Paramentros dos campos que existe na base de dados 
            Cmd.InsertCommand.Parameters.Add("@Nome_produto", SqlDbType.VarChar).Value = Nome_produto.Text;
            Cmd.InsertCommand.Parameters.Add("@Tipo_produto", SqlDbType.VarChar).Value = Tipo_produto.Text;
            Cmd.InsertCommand.Parameters.Add("@Preco", SqlDbType.VarChar).Value = Preco.Text;
            Cmd.InsertCommand.Parameters.Add("@Qtd_Estoque", SqlDbType.VarChar).Value = Qtd_Estoque.Text;
            try
            {
                conn.Open();
                Cmd.InsertCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Usuario cadastrado com sucesso!");
                Nome_produto.Text = "";
                Tipo_produto.Text = "";
                Preco.Text = "";
                Qtd_Estoque.Text = "";
                Nome_produto.Focus();
            }
            catch
            {
                MessageBox.Show("Erro ao Cadastrar o Usuario");
                // Fim código cadastro de Usuários incluindo as duas chavetas abaixo 
                }
              }
          }
        }
      

