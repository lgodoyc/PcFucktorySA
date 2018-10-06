using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO = PCFucktory.App;

namespace PCFuctory.web.Inventario.Comuna
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
            if (!IsPostBack)
            {
                DTO.Region region = new DTO.Region();

                if (region.ReadAll())
                {
                    foreach (var tmp in region.Coleccion)
                    {
                        ddlComuna.Items.Add(new ListItem() { Text = tmp.Nombre, Value = tmp.Region_ID.ToString() });
                    }
                }
            }
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DTO.Comuna comuna = new DTO.Comuna();
                comuna.Comuna_ID = Convert.ToInt32(txtComunaID.Text);
                comuna.Nombre = txtNombre.Text;
                comuna.Region_ID = Convert.ToInt32(ddlComuna.SelectedValue);

                comuna.Create();
            }
            catch (Exception ex)
            {
            }
        }
    }
}