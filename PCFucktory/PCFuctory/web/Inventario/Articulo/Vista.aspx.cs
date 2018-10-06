using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PCFuctory.web.Inventario.Articulo
{
    public partial class Vista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                FormsAuthentication.SignOut();
                Response.Redirect("~/web/Login/Default.aspx");
            }
        }
    }
}