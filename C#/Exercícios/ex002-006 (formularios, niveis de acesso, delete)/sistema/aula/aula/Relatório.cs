﻿using System;
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
    public partial class Relatório : Form
    {
        public Relatório()
        {
            InitializeComponent();
        }

        private void txt_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
