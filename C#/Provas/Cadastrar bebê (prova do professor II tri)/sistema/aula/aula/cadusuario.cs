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
    public partial class cadusuario : Form
    {
        string jj = @"Data Source=DESKTOP-HKMIROJ\SQLEXPRESS;Initial Catalog=Bercario;Integrated Security=True";
        string del = "delete from Usuario where CodUsuario = @CodUsuario";
        
        public cadusuario()
        {
          InitializeComponent();
        }

        conexao conexao = new conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;

        public cadusuario(String Nome_completo, String Usuario, String Senha, String Função)
        {
          cmd.CommandText = "insert into Usuario (Nome_completo, Usuario, Senha, Função) values (@Nome_completo, @Usuario, @Senha, @Função)";
          cmd.Parameters.AddWithValue("@Nome_completo", Nome_completo);
          cmd.Parameters.AddWithValue("@Usuario", Usuario);
          cmd.Parameters.AddWithValue("@Senha", Senha);
          cmd.Parameters.AddWithValue("@Função", Função);

           try
           {
             cmd.Connection = conexao.conectar();
             cmd.ExecuteNonQuery();
             conexao.desconectar();
             this.mensagem = "Usuario cadastrado com Sucesso";
             
          
           }
             catch (Exception)
           {
             this.mensagem = "Erro ao cadastrar Usuario";
           }
         }

    private void btcadastrar_Click(object sender, EventArgs e)
    {
         cadusuario cad = new cadusuario(txtnomecompleto.Text, txt_usuario.Text, txt_senha.Text, combfun.Text);
         MessageBox.Show(cad.mensagem);
    }

        public DataTable Usuario()
        {
            SqlConnection conn = new SqlConnection(jj);
            DataTable dt = new DataTable();
            SqlDataAdapter apter = new SqlDataAdapter("select* from Usuario", conn);
            apter.Fill(dt);
            return dt;
        }

        private void btvisualizar_Click(object sender, EventArgs e)
        {
         dataGridView1.DataSource = Usuario(); 
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection conn = new SqlConnection(jj);
                conn.Open();
                SqlCommand Cmd = new SqlCommand(del, conn);
                Cmd.Parameters.AddWithValue(@"CodUsuario", txt_codusuario.Text);
                Cmd.ExecuteNonQuery();
                txtnomecompleto.Focus();
                conn.Close();
                MessageBox.Show("Usuario Deletado com sucesso");
            }
            catch
            {
                MessageBox.Show("Erro ao Deletar o Usuario");
            }
        }

     }
  }
    
    

