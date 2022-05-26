using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelaDeLogin.modelo;

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
            controle controle = new controle();
            String mensagem = controle.cadastrarEnd(txbRua.Text,txbNum.Text,txbBairro.Text,txbCid.Text);
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
