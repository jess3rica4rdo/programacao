using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaEntidade;

namespace CapaDados
{
    public class cd_usuario
    {

        string jj = @"Data Source=DESKTOP-HKMIROJ\SQLEXPRESS;Initial Catalog=loja;Integrated Security=True";

        conexao conexao = new conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;

        public DataTable usuario()
        {
            SqlConnection conn = new SqlConnection(jj);
            DataTable dt = new DataTable();
            SqlDataAdapter apter = new SqlDataAdapter("SELECT cod_usuario AS id, nome_completo AS Nome, idade AS Idade, genero AS Gênero, telefone AS Telefone, nome_usuario AS Usuário, senha AS Senha, funcao AS Função, add_por AS Adicionado_por, data_registro As Data FROM usuario", conn);
            apter.Fill(dt);
            return dt;
        }
    }
}
