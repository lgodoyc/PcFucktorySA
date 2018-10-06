using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace PCFuctory.web.Login
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            ingresar();
        }

        void ingresar()
        {            
            string user = txtUsuario.Text;
            string pass = txtContraseña.Text;
            if (user.Equals("admin")&&pass.Equals("1234"))
            {
                Session["admin"] = "admin";
                FormsAuthentication.RedirectFromLoginPage("admin", false);
            }
            else
            {
                txtUsuario.Text = string.Empty;
                lblError.Text = "Usuario o contraseña invalidos";
            }
        }
    }
}