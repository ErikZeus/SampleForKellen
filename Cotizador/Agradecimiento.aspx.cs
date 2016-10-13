using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cotizador
{
    public partial class Agradecimiento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string correo = "";
            string telefono = "";

            try
            {
                correo = Request.QueryString["correo"];
            }
            catch (Exception)
            { }

            try
            {
                telefono = Request.QueryString["telefono"];
            }
            catch (Exception)
            { }

            this.lblCorreo.Text = correo;
            this.lblTelefono.Text = telefono;
        }
    }
}