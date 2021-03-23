using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.ModuloUsuario
{
    public partial class frmIncluirUsuarioPIM : Form
    {
        public frmIncluirUsuarioPIM()
        {
            InitializeComponent();
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            //Fluxo de Exceção - Especificação do Caso de Uso
            try
            {
                //Boundry - frmIncluirUsuarioPIM
                //Validar preenchimento de campos obrigatorios
                if ((txtFirsName.Text == string.Empty) && (txtlastaName.Text == string.Empty) && (txtPassword.Text == string.Empty) && (txtUserName.Text == string.Empty))
                {
                    MessageBox.Show("Favor preencher dado!");
                }
                else
                {
                    //Entity - Usuario - preencher os atributos
                    usuario _usuario = new usuario();

                    #region Fluxo Alternativo - Especificação do Caso de Uso
                    if (txtFirsName.Text == string.Empty)
                    {
                        MessageBox.Show("Favor informar o valor do campo firstname");
                        txtFirsName.Focus();
                    }
                    if (txtlastaName.Text == string.Empty)
                    {
                        MessageBox.Show("Favor informar o valor do campo lastname");
                    }
                    if (txtUserName.Text == string.Empty)
                    {
                        MessageBox.Show("Favor informar o valor do campo username");
                    }
                    if (txtPassword.Text == string.Empty)
                    {
                        MessageBox.Show("Favor informar o valor do campo password");
                    }
                    #endregion
                    _usuario.firstName = txtFirsName.Text;
                    _usuario.lastName = txtlastaName.Text;
                    _usuario.userName = txtUserName.Text;
                    _usuario.password = txtPassword.Text;

                    //Control - IncluirUsuario
                    //int retornoIncluirUsuario = _usuario.incluirUsuario(_usuario.userName, _usuario.password, _usuario.firstName, _usuario.lastName);
                    int retornoIncluirUsuario = _usuario.incluirUsuario(_usuario);

                    //Diagrama de Caso de Uso
                    //Fluxo Principal e Alternativo - Especificação do Caso de Uso
                    if (retornoIncluirUsuario != 0)
                    {
                        //Fluxo Principal
                        //Retorno - Linha tracejada do diagrama de sequência
                        MessageBox.Show("Usuário cadastrado com sucesso!");
                    }
                    else
                    {
                        //Fluxo Alternativo
                        //Retorno - Linha tracejada do diagrama de sequência
                        MessageBox.Show("Falha ao efetuar inclusão do usuário.");
                    }
                }
            }
            //Fluxo de Exceção - Especificação do Caso de Uso
            catch (Exception ex)
            {
                //Retorno - Linha tracejada do diagrama de sequência
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
