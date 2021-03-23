using System;
using System.Windows.Forms;
using CamadaControle;

namespace PIM.ModuloUsuario
{
    public partial class frmConsultarAluno : Form
    {
        public frmConsultarAluno()
        {
            InitializeComponent();
        }

        private void btnConsultarAluno_Click(object sender, EventArgs e)
        {
            ctlAluno _ctlAluno = new ctlAluno();
            dgAluno.DataSource = _ctlAluno.ConsultarTodosAluno();
        }
    }
}
