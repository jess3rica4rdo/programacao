using CapaEntidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using CapaDados;

namespace Sistema_de_gestão
{
    public class cd_produtos
    {

        string jj = @"Data Source=DESKTOP-HKMIROJ\SQLEXPRESS;Initial Catalog=loja;Integrated Security=True";

        conexao conexao = new conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;

        public DataTable produto()
        {
            SqlConnection conn = new SqlConnection(jj);
            DataTable dt = new DataTable();
            SqlDataAdapter apter = new SqlDataAdapter("SELECT cod_produto AS Id, nome_produto AS Nome, descricao AS Descrição, cod_categoria AS Categoria, stock AS Stock, preco_compra AS Preço_Compra, preco_venda AS Preço_venda, add_por AS Adicionado_por, data_registro AS Data_Registro FROM produto", conn);
            apter.Fill(dt);
            return dt;
        }

    }
}