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
using Npgsql;

namespace TelaDeLogin
{
    public partial class frmCotacaoUm : Form
    {
        public frmCotacaoUm()
        {
            InitializeComponent();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            controle controle = new controle();
            String mensagem = controle.cadastrarCarro(txbFabricante.Text, txbAno.Text, txbModelo.Text);
            if (controle.temCarro) //mensagem de sucesso
            {
                new frmCotacaoDois().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(controle.mensagem); //mensagem de erro
            }

        }

        private void txbFabricante_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txbAno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbModelo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
