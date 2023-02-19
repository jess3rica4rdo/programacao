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
    public partial class cadbebe : Form
    {
        string jj = @"Data Source=DESKTOP-HKMIROJ\SQLEXPRESS;Initial Catalog=Bercario;Integrated Security=True";
        string del = "delete from Bebe where CodBebe = @CodBebe";
        string pes = "select CodBebe, NomeBebe, Peso, Altura, Sexo, Mae, Medico, Data_nascimento from Bebe where NomeBebe LIKE @NomeBebe";

        public cadbebe()
        {
            InitializeComponent();
        }

        conexao conexao = new conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;

        public cadbebe(String NomeBebe, String Data_nascimento, String Peso, String Altura, String Sexo, String Mae, String Medico)
        {
            cmd.CommandText = "insert into Bebe (NomeBebe, Data_nascimento, Peso, Altura, Sexo, Mae, Medico) values (@NomeBebe, @Data_nascimento, @Peso, @Altura, @Sexo, @Mae, @Medico)";
            cmd.Parameters.AddWithValue("@NomeBebe", NomeBebe);
            cmd.Parameters.AddWithValue("@Data_nascimento", Data_nascimento);
            cmd.Parameters.AddWithValue("@Peso", Peso);
            cmd.Parameters.AddWithValue("@Altura", Altura);
            cmd.Parameters.AddWithValue("@Sexo", Sexo);
            cmd.Parameters.AddWithValue("@Mae", Mae);
            cmd.Parameters.AddWithValue("@Medico", Medico);

         try
         {
             cmd.Connection = conexao.conectar();
             cmd.ExecuteNonQuery();
             conexao.desconectar();
             this.mensagem = "Bebê cadastrado com Sucesso";
         }
         catch (Exception)
         {
             this.mensagem = "Erro ao cadastrar Bebê";
         }
        }

        public DataTable Bebe()
        {
            SqlConnection conn = new SqlConnection(jj);
            DataTable dt = new DataTable();
            SqlDataAdapter apter = new SqlDataAdapter("select* from Bebe", conn);
            apter.Fill(dt);
            return dt;
        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
          cadbebe c = new cadbebe(txt_nomebebe.Text, txt_datanascimento.Text, txt_peso.Text, txt_altura.Text, txt_sexo.Text, txt_mae.Text, txt_medico.Text);
          MessageBox.Show(c.mensagem);
        }


        private void bt_visualizar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Bebe();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection conn = new SqlConnection(jj);
                conn.Open();
                SqlCommand Cmd = new SqlCommand(del, conn);
                Cmd.Parameters.AddWithValue(@"CodBebe", txt_codbebe.Text);
                Cmd.ExecuteNonQuery();
                txt_nomebebe.Focus();
                conn.Close();
                MessageBox.Show("Bebe Deletado com sucesso");
            }
            catch
            {
                MessageBox.Show("Erro ao Deletar o Bebê");
            }

            txt_codbebe.Text = "";
        }

        private void bt_pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(jj);
                conn.Open();
                SqlCommand Cmd = new SqlCommand(pes, conn);
                Cmd.Parameters.AddWithValue(@"NomeBebe", "%" + txt_datanascimento.Text + "%");
                SqlDataAdapter data = new SqlDataAdapter(Cmd);
                DataSet consulta = new DataSet();
                data.Fill(consulta);
                dataGridView1.DataSource = consulta.Tables[0];
            }
            catch
            {
            }

        }
     
    }
}



