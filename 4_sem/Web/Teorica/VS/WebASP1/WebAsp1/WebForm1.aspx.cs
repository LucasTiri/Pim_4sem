using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAsp1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        protected void btnMessage_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                lblMessage.Text = "Ola Mundo Asp.Net";
            }
            else
            {
                lblMessage.Text = TextBox1 + "Bora Programar em ASP.NET";
            }
        }
    }
}