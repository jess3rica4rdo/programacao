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
    public partial class prncipal : Form
    {
        public prncipal()
        {
            InitializeComponent();
        }

        private void menuusuario_Click(object sender, EventArgs e)
        {
            cadusuario f2 = new cadusuario();
            f2.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
