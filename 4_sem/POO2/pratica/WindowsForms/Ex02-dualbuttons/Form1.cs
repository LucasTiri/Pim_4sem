using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex02_dualbuttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblCorinthians.Text = "Corinthians é melhor que palmeiras";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblSemMundial.Text = "Palmeiras não tem mundial";
        }
    }
}
