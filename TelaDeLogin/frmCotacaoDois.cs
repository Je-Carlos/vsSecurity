using System;
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
    public partial class frmCotacaoDois : Form
    {
        public frmCotacaoDois()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new frmCotacaoTres().Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new frmCotacaoUm().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
