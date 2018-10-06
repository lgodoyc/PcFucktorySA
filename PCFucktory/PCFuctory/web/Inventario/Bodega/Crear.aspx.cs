using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO = PCFucktory.App;

namespace PCFuctory.web.Inventario.Bodega
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
                DTO.Ubicacion ubicacion = new DTO.Ubicacion();
                
                if (ubicacion.ReadAll())
                {
                    foreach (var tmp in ubicacion.Coleccion)
                    {
                        cboUbicacion.Items.Add(new ListItem() { Text = tmp.Nombre, Value = tmp.Ubicacion_ID.ToString() });
                    }
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DTO.Bodega bodega = new DTO.Bodega();

                bodega.Bodega_ID = Convert.ToInt32(txtBodegaID.Text);
                bodega.Nombre = txtNombre.Text;
                bodega.Ubicacion_ID = Convert.ToInt32(cboUbicacion.SelectedValue);
                
                bodega.Create();
            }
            catch (Exception ex)
            {

                
            }           
        }
    }
}