using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Troca_valores
{
    public partial class frmTroca_val : Form
    {
        public frmTroca_val()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmTroca_val_Load(object sender, EventArgs e)
        {

        }

        private void btnTrocar_Click(object sender, EventArgs e)
        {
            //troca os valores de posição
            string auxiliar = txtValor1.Text;
            txtValor1.Text = txtValor2.Text;
            txtValor2.Text = auxiliar;

            //apresenta uma caixa de mensagem ao usuário sobre a troca
            MessageBox.Show("Troca de Valores Concluída", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
