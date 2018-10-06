using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO = PCFucktory.App;

namespace PCFuctory.web.Inventario.Ubicacion
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
                DTO.Comuna comuna = new DTO.Comuna();

                if (comuna.ReadAll())
                {
                    foreach (var tmp in comuna.Coleccion)
                    {
                        ddlComuna.Items.Add(new ListItem() { Text = tmp.Nombre, Value = tmp.Comuna_ID.ToString() });
                    }
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
                
            try
            {
                if (txtDepto.Text.Equals(""))
                {
                    txtDepto.Text = "0";
                }
                if (txtTorreBlock.Text.Equals(""))
                {
                    txtTorreBlock.Text = "0";
                }
                DTO.Ubicacion ubicacion = new DTO.Ubicacion();
                ubicacion.Ubicacion_ID = Convert.ToInt32(txtUbicacionID.Text);
                ubicacion.Nombre = txtNombreUbicacion.Text;
                ubicacion.Direccion = txtDireccion.Text;             
                ubicacion.NroDpto = Convert.ToInt32(txtDepto.Text);
                ubicacion.TorreBlock = txtTorreBlock.Text;
                ubicacion.Numero = Convert.ToInt32(txtNumero.Text);
                ubicacion.Comuna_ID = Convert.ToInt32(ddlComuna.SelectedValue);

                ubicacion.Create();
            }
            catch (Exception ex)
            {
            }
        }
    }
}