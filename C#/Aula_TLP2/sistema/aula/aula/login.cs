using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btentrar_Click(object sender, EventArgs e)
        {
            prncipal pp = new prncipal();
            pp.Show();
            this.Visible = false;
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
