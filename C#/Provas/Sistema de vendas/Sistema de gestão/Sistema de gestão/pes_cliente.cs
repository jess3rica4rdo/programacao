using CapaDados;
using CapaEntidade;
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

namespace Sistema_de_gestão
{
    public partial class pes_cliente : Form
    {
        public clientes cclientes { get; set; }

        string jj = @"Data Source=DESKTOP-HKMIROJ\SQLEXPRESS;Initial Catalog=loja;Integrated Security=True";

        public pes_cliente()
        {
            InitializeComponent();
        }

        conexao conexao = new conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;

        public DataTable cliente()
        {
            SqlConnection conn = new SqlConnection(jj);
            DataTable dt = new DataTable();
            SqlDataAdapter apter = new SqlDataAdapter("SELECT cod_cliente AS ID, nome_completo AS Nome, telefone As Telefone FROM cliente", conn);
            apter.Fill(dt);
            return dt;
        }

        private void ca_cliente_Load(object sender, EventArgs e)
        {
            dgvfornecedor.DataSource = cliente();
        }

        private void dgvfornecedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow >= 0 && iColum > 0)
            {
                cclientes = new clientes()
                {
                    cod_cliente = Convert.ToInt32(dgvfornecedor.Rows[iRow].Cells[0].Value.ToString()),
                    nome_completo = dgvfornecedor.Rows[iRow].Cells[1].Value.ToString()
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            string pes = "SELECT cod_cliente AS ID, nome_completo AS Nome, telefone As Telefone FROM cliente WHERE nome_completo LIKE @nome_completo";

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
                    dgvfornecedor.DataSource = consulta.Tables[0];
                }
            }
            catch
            {
                MessageBox.Show("Este cliente não foi encontrado no sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}