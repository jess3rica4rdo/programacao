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

namespace SIG_FARMACIA
{
    public partial class cadusuarios : Form
    {
        public cadusuarios()
        {
            InitializeComponent();
        }

        String conexao = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SIG_FARMA;Data Source=DESKTOP-HKMIROJ\SQLEXPRESS";
        private void btcadastrar_Click(object sender, EventArgs e)
        {
             SqlConnection conn = new SqlConnection(conexao);
            SqlDataAdapter Cmd = new SqlDataAdapter();
            // Código para inserir dados na base de dados a partir do C#
            Cmd.InsertCommand = new SqlCommand("INSERT INTO Usuários VALUES(@Nome,@Usuario,@Senha,@Funcao)", conn);
            // Paramentros dos campos que existe na base de dados 
            Cmd.InsertCommand.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtnomecompleto.Text;
            Cmd.InsertCommand.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = txt_usuario.Text;
            Cmd.InsertCommand.Parameters.Add("@Senha", SqlDbType.VarChar).Value = txt_senha.Text;
            Cmd.InsertCommand.Parameters.Add("@Funcao", SqlDbType.VarChar).Value = comboBox1.Text;
            try

            {
                conn.Open();
                Cmd.InsertCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Usuario cadastrado com sucesso!");
                txtnomecompleto.Text = "";
                txt_usuario.Text = "";
                txt_senha.Text = "";
                comboBox1.Text = "";
                txtnomecompleto.Focus();
            }
            catch
            {
                MessageBox.Show("Erro ao Cadastrar o Usuario");
                // Fim código cadastro de Usuários incluindo as duas chavetas abaixo 
                }
              }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar a operação?", "SISGEST 1.0 FARMACÊUTICA 2023",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
           }

         public DataTable Usuários()
        {
            SqlConnection conn = new SqlConnection(conexao);
            DataTable dt = new DataTable();
            SqlDataAdapter apter = new SqlDataAdapter("select* from Usuários", conn);
            apter.Fill(dt);
            return dt;
        }
        private void btvisualizar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Usuários(); 

              }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conexao);
           try{
               string str = "select * from Usuários where Nome like '%" + txtPesquisa.Text + "%'";
                SqlCommand cmd = new SqlCommand(str, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
                txtnomecompleto.Text = "";
                txt_usuario.Text = "";
                txt_senha.Text = "";
                comboBox1.SelectedIndex = -1;

           }

   catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
            conn.Close();

                  }

        private void btvoltar_Click(object sender, EventArgs e)
        {
            Close();
            principal log = new principal();
            
                  }

        private void cadusuarios_Load(object sender, EventArgs e)
        {

        }
    }
               }
           
          
      

