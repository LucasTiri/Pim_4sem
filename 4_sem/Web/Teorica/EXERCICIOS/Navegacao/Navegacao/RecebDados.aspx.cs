using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Navegacao
{
    public partial class RecebDados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null)
            {
                Label1.Text = ((TextBox)Page.PreviousPage.FindControl("TextBox1"));
            }
            else
            {
                Label1.Text = "Sem Previous Page";
            }
        }
    }
}