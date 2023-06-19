using CapaEntidade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Data.SqlClient;
using CapaDados;
using Sistema_de_gestão.utilidades;

namespace Sistema_de_gestão
{
    public partial class painel_principal : Form
    {
        private static usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        public painel_principal()
        {
            InitializeComponent();
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;

            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;
            painel.Controls.Add(formulario);
            formulario.Show();
        }

        private void home_Load(object sender, EventArgs e)
        {
            string jj = @"Data Source=DESKTOP-HKMIROJ\SQLEXPRESS;Initial Catalog=loja;Integrated Security=True";
            string sql = "select * from usuario where nome_usuario=@nome_usuario";

            SqlConnection con = new SqlConnection(jj);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@nome_usuario", vm.NomeFuncionario1);
            con.Open();
            SqlDataReader dtr = cmd.ExecuteReader();

            while (dtr.Read())
            {
                nome_usuario.Text = (string)dtr["nome_completo"];
                funcao_usuario.Text = (string)dtr["funcao"];
                codusuario.Text = Convert.ToString(dtr["cod_usuario"]);
                haraact.Text = DateTime.Now.ToShortTimeString();
                dataact.Text = DateTime.Now.ToShortDateString();
            }
            dtr.Close();

            if (funcao_usuario.Text == "OPERADOR DE CAIXA")
            {
                menufornecedores.Visible = false;
                menuusuarios.Visible = false;
                menucompras.Visible = false;
                menurelatorio.Visible = false;
                gestãoDeProdutosToolStripMenuItem.Visible = false;
            }
        }

        private void menuclientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuclientes, new cad_clientes());
        }

        private void menufornecedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menufornecedores, new cad_fornecedores());
        }

        private void menuusuarios_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(menuusuarios, new cad_usuario());
        }

        private void terminarSessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gestãoDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuservicos, new cad_produtos());
        }

        private void pesquisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuservicos, new pes_produto());
        }

        private void menuvendas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuvendas, new vendas());
        }

        private void menucompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new compras());
        }

        private void geralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menurelatorio, new relatorio_compra());
        }

        private void específicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menurelatorio, new relatorio_venda());
        }

        private void menuacercade_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuacercade, new acerca_de());
        }
    }
}