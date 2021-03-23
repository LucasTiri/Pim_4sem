using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Navegacao
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HyperLink link = new HyperLink();
            link.Text = "Link da Pagina Contato gerado via código";
            link.NavigateUrl = "~/WebForm2.aspx";

            Page.Controls.Add(link);

        }
    }
}