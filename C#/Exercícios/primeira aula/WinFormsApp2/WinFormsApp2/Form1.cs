namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
            int Valor1, Valor2, Resulatdo;
            Valor1 = Convert.ToInt32(txt_valor1.Text);
            Valor2 = Convert.ToInt32(txt_valor2.Text);
            Resulatdo = Valor1 + Valor2;
            txt_resultado.Text = Convert.ToString(Resulatdo);
        }

        private void btprincipal_Click(object sender, EventArgs e)
        {
            Form2 Outroform = new Form2();
            Outroform.Show();
            this.Visible = false;
        }

        private void btnmultiplicacao_Click(object sender, EventArgs e)
        {
            int Valor1, Valor2, Resulatdo;
            Valor1 = Convert.ToInt32(txt_valor1.Text);
            Valor2 = Convert.ToInt32(txt_valor2.Text);
            Resulatdo = Valor1 * Valor2;
            txt_resultado.Text = Convert.ToString(Resulatdo);
        }

        private void btnsubtracao_Click(object sender, EventArgs e)
        {
            int Valor1, Valor2, Resulatdo;
            Valor1 = Convert.ToInt32(txt_valor1.Text);
            Valor2 = Convert.ToInt32(txt_valor2.Text);
            Resulatdo = Valor1 - Valor2;
            txt_resultado.Text = Convert.ToString(Resulatdo);
        }

        private void btndivisao_Click(object sender, EventArgs e)
        {
            int Valor1, Valor2, Resulatdo;
            Valor1 = Convert.ToInt32(txt_valor1.Text);
            Valor2 = Convert.ToInt32(txt_valor2.Text);
            Resulatdo = Valor1 / Valor2;
            txt_resultado.Text = Convert.ToString(Resulatdo);
        }
    }
}