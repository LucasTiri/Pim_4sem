using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox_Radio
{
    public partial class Form1 : Form
    {
        public string conteudo = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificacao_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("Radio AM");
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("Radio FM");
            }
            else
            {
                MessageBox.Show("Nenhum Radio Acionado");
            }
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                conteudo += checkBox1.Text;
            }
            if (checkBox2.Checked)
            {
                conteudo += "\n" + checkBox2.Text;
            }
            if (checkBox3.Checked)
            {
                conteudo += "\n" + checkBox3.Text;
            }
            MessageBox.Show(conteudo);
            conteudo = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Uva");
            comboBox1.Items.Add("Maça");
            comboBox1.Items.Add("Pera");
            comboBox1.Items.Add("Limão");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string repetidos = "";
            repetidos = comboBox1.Text;
            if (comboBox1.Text == repetidos)
            {
                comboBox1.Items.Remove("Uva");
                comboBox1.Items.Remove("Maça");
                comboBox1.Items.Remove("Pera");
                comboBox1.Items.Remove("Limão");
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string repetidos = "";
            repetidos = comboBox1.Text;
            if (comboBox1.Text != null)
            {
                if (comboBox1.FindString(repetidos) < 0)
                {
                    comboBox1.Items.Add(repetidos);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string repetidos1 = "";
            repetidos1 = comboBox1.Text;
            if (comboBox1.Text != null)
            {
                if (comboBox1.FindString(repetidos1) < 0)
                {
                    comboBox1.Items.Remove(repetidos1);
                }
            }
        }
    }
}
