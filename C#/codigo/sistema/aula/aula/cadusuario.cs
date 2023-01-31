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

namespace aula
{
    public class cadusuario
    {
        conexao conexao = new conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;

        public cadusuario(String Nome_completo, String Usuario, String Senha, String Função)
        {
            //Comando Sql  ---SqlCommand
            cmd.CommandText = "insert into Cadastros (Nome_completo, Usuario, Senha, Função) values (@Nome_completo, @Usuario, @Senha, @Função)";

            //parametros
            cmd.Parameters.AddWithValue("@Nome_completo", Nome_completo);
            cmd.Parameters.AddWithValue("@Usuario", Usuario);
            cmd.Parameters.AddWithValue("@Senha", Senha);
            cmd.Parameters.AddWithValue("@Função", Função);

            //conectar com banco -- conexao
            try
            {
                cmd.Connection = conexao.conectar();

                //executar comando
                cmd.ExecuteNonQuery();

                
                //desconectar
                conexao.desconectar();

                //mostrar mensagem de erro ou sucesso -- variavel
                this.mensagem = "Usuario cadastrado com Sucesso!!";


            }
            catch (Exception e)
            {
                this.mensagem = "Erro ao cadastrar Usuario";
            }


    }
    }

