using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appWebLogin
{
    public partial class RegistroUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Context.Items.Add("Nome",txtNome.Text);
            Context.Items.Add("Email", txtEmail);

            Server.Transfer("~/DetalhesUser.aspx");
        }
    }
}