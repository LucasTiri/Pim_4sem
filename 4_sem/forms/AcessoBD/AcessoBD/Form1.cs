using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcessoBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admADM" && textBox2.Text == "admADM")
            {
                Form2 cadastro = new Form2();
                cadastro.ShowDialog();
            }
            else
            {
                MessageBox.Show("");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 configuração = new Form3();
            configuração.ShowDialog();
        }
    }
}
