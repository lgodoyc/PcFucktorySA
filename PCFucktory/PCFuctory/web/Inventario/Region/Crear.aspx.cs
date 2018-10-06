using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO = PCFucktory.App;

namespace PCFuctory.web.Inventario.Region
{
    public partial class Crear : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                FormsAuthentication.SignOut();
                Response.Redirect("~/web/Login/Default.aspx");
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DTO.Region region = new DTO.Region();
                region.Region_ID = Convert.ToInt32(txtID.Text);
                region.Nombre = txtNombre.Text;

                if (region.Create())
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Guardado con exito.');", true);
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Error.');", true);
                }
            }
            catch (Exception ex)
            {

                txtNombre.Text = ex.Message;
            }
        }
    }
}