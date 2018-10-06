using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO = PCFucktory.App;

namespace PCFuctory.web.Inventario.Articulo
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
                DTO.Categoria categoria = new DTO.Categoria();
                if (categoria.ReadAll())
                {
                    foreach (var tmp in categoria.Coleccion)
                    {
                        ddlArticulo.Items.Add(new ListItem() { Value = tmp.Categoria_ID.ToString(), Text = tmp.Nombre });
                    }
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DTO.Articulo articulo = new DTO.Articulo();
                articulo.Articulo_ID = txtArticuloID.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.StockMaximo = Convert.ToInt32(txtMaximo.Text);
                articulo.StockMinimo = Convert.ToInt32(txtMinimo.Text);
                articulo.StockCritico = Convert.ToInt32(txtCritico.Text);
                articulo.Categoria_ID = Convert.ToInt32(ddlArticulo.SelectedValue);

                articulo.Create();
            }
            catch (Exception ex)
            {
            }
        }
    }
}