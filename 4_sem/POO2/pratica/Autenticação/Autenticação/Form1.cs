using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autenticação
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "aluno" && txtSenha.Text == "1234")
            {
                MessageBox.Show("Bem vindo Aluno");
            }
            else if (txtUser.Text == "professor" && txtSenha.Text == "1234")
            {
                MessageBox.Show("Bem vindo professor");
                tela_prof Tela_prof = new tela_prof();
                Tela_prof.Show();
                this.Hide();
                //Form form1 = new Form();
                //form1.Show();
                
            }
            else
            {
                MessageBox.Show("Usuario ou senha invalidos");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtSenha.Clear();
            MessageBox.Show("Volte mais tarde");
        }
    }
}
