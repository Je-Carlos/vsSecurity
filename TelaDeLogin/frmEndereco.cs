﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaDeLogin
{
    public partial class frmEndereco : Form
    {
        public frmEndereco()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new FrmCotacaoCinco().Show();
            this.Hide();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new frmCotacaoQuatro().Show();
            this.Hide();
        }
    }
}
