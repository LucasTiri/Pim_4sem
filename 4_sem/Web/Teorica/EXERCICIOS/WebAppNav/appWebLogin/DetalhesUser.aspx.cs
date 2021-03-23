using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appWebLogin
{
    public partial class DetalhesUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(PreviousPage!= null)
            {
                Response.Write(((TextBox)Page.PreviousPage.FindControl("txtNome")).Text);
            }
            else
            {
                Response.Write("Sem Previous Page");
            }
            /*
             try{
                Response.Write(string.Format("Nome do User: {0}",Context.Items["Nome"].ToString()));
                Response.Write(string.Format("Email: {0}",Context.Items["Email"].ToString()));
            }
            catch(NullReferenceException e)
            {
            Response.Write(e.Message);
            }
             */
        }
    }
}