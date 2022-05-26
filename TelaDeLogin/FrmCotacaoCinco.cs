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
    public partial class FrmCotacaoCinco : Form
    {
        public FrmCotacaoCinco()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            controle controle = new controle();
            String mensagem = controle.cadastrarCpf(txbCpf.Text);
            if (controle.temEnd) //mensagem de sucesso
            {
                MessageBox.Show("Um email será enviado para seu cadastro, Obrigado por cotar conosco!", "Finalização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            else
            {
                MessageBox.Show(controle.mensagem); //mensagem de erro
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new frmCotacaoQuatro().Show();
            this.Hide();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
