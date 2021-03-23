using System.Windows.Forms;
using CamadaModelo;
using CamadaControle;
using System;
using PIM.ModuloUsuario;

namespace PIM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIncluirUsuario_Click(object sender, System.EventArgs e)
        {

            mdlAluno _mdlAluno = new mdlAluno();
            ctlAluno _ctlAluno = new ctlAluno();

            try
            {
                _mdlAluno.nome = txtNome.Text;
                _mdlAluno.cpf = txtCPF.Text;
                _mdlAluno.rg = txtRG.Text;

                bool retorno = _ctlAluno.Cadastrar(_mdlAluno);

                if (retorno)
                {
                    txtNome.Text = string.Empty;
                    txtRG.Text = string.Empty;
                    txtCPF.Text = string.Empty;
                    txtNome.Focus();
                    MessageBox.Show("Dados do aluno incluídos com sucesso!");
                }
                else
                {
                    MessageBox.Show("Não foi possível realizar a inclusão.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void btnSair_Click(object sender, System.EventArgs e)
        {
            Close();
            
        }
    }
}
