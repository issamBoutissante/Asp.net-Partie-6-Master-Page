using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Partie_6_Master_Page
{
    public partial class PageMaitre : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Acceil_Click(object sender, EventArgs e)
        {
            Response.Redirect("Acceil.aspx");
        }

        protected void Profil_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profil.aspx");
        }

        protected void Contact_Click(object sender, EventArgs e)
        {
            Response.Redirect("Contact.aspx");
        }
    }
}