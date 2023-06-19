using CapaDados;
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
using CapaEntidade;

namespace Sistema_de_gestão
{
    public partial class pes_fornecedor : Form
    {
        public fornecedor cfornecedor { get; set; }

        string jj = @"Data Source=DESKTOP-HKMIROJ\SQLEXPRESS;Initial Catalog=loja;Integrated Security=True";
        public pes_fornecedor()
        {
            InitializeComponent();
        }
        conexao conexao = new conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;

        public DataTable fornecedor()
        {
            SqlConnection conn = new SqlConnection(jj);
            DataTable dt = new DataTable();
            SqlDataAdapter apter = new SqlDataAdapter("SELECT cod_fornecedor AS ID, nif As NIF, razao_social As Razão_Social FROM fornecedor", conn);
            apter.Fill(dt);
            return dt;
        }
        private void ca_fornecedor_Load(object sender, EventArgs e)
        {
            dgvfornecedor.DataSource = fornecedor();

        }

        private void dgvfornecedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow >= 0 && iColum > 0)
            {
                cfornecedor = new fornecedor()
                {
                    cod_fornecedor = Convert.ToInt32(dgvfornecedor.Rows[iRow].Cells[0].Value.ToString()),
                    nif = dgvfornecedor.Rows[iRow].Cells[1].Value.ToString(),
                    razao_social = dgvfornecedor.Rows[iRow].Cells[2].Value.ToString()
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_pes_Click(object sender, EventArgs e)
        {
            string pes = "SELECT cod_fornecedor AS ID, nif As NIF, razao_social As Razão_Social FROM fornecedor WHERE nif LIKE @nif";

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
                    Cmd.Parameters.AddWithValue(@"nif", "%" + txt_buscar.Text + "%");
                    SqlDataAdapter data = new SqlDataAdapter(Cmd);
                    DataSet consulta = new DataSet();
                    data.Fill(consulta);
                    dgvfornecedor.DataSource = consulta.Tables[0];
                }
            }
            catch
            {
                MessageBox.Show("Este fornecedor não foi encontrado no sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
