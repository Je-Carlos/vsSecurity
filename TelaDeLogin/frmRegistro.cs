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
    public partial class frmRegister : Form
    {

        public frmRegister()
        {
            InitializeComponent();
         
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            controle controle = new controle();
            String mensagem = controle.cadastrar(txtusername.Text, txtPass.Text, txtComPassword.Text);
            if (controle.tem) //mensagem de sucesso
            {
                MessageBox.Show(mensagem,"Cadastro",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.mensagem); //mensagem de erro
            }
 
        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
            {
                txtPass.UseSystemPasswordChar = !txtPass.UseSystemPasswordChar;
                txtComPassword.UseSystemPasswordChar = !txtComPassword.UseSystemPasswordChar;
            }
            else
            {
                txtPass.UseSystemPasswordChar = !txtPass.UseSystemPasswordChar;
                txtComPassword.UseSystemPasswordChar = !txtComPassword.UseSystemPasswordChar;

            }

        }
        private void txtComPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtPass.Text = "";
            txtComPassword.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}