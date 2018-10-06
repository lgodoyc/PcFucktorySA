using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO = PCFucktory.App;

namespace PCFuctory.web.Transferencias
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
                DTO.Articulo articulos = new DTO.Articulo();
                DTO.Bodega bodegas = new DTO.Bodega();

                if (articulos.ReadAll())
                {
                    foreach(var tmp in articulos.Coleccion)
                    {
                        ddArticulo.Items.Add(new ListItem() { Text = tmp.Articulo_ID, Value=tmp.Articulo_ID });
                    }
                }
                if (bodegas.ReadAll())
                {
                    foreach (var tmp in bodegas.Coleccion)
                    {
                        ddBodegaEntrada.Items.Add(new ListItem() { Text = tmp.Nombre, Value = tmp.Bodega_ID.ToString() });
                        ddBodegaSalida.Items.Add(new ListItem() { Text = tmp.Nombre, Value = tmp.Bodega_ID.ToString() });
                    }
                }
            }
        }
    }
}