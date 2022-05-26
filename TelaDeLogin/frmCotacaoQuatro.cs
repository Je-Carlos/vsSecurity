using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using TelaDeLogin.modelo;

namespace TelaDeLogin
{
    public partial class frmCotacaoQuatro : Form
    {
        public frmCotacaoQuatro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            controle controle = new controle();
            String mensagem = controle.cadastrarCep(txbCep.Text);
            if (controle.temEnd) //mensagem de sucesso
            {
                new FrmCotacaoCinco().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(controle.mensagem); //mensagem de erro
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            new frmCotacaoTres().Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new frmEndereco().Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
