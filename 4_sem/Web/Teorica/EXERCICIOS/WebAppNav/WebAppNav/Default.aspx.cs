using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppNav
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Cadastro.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/Cadastro.aspx");
        }
    }
}