using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;

namespace Cotizador
{
    public partial class Rpt25 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Id = "";
            try
            {
                Id = Session["Id"].ToString();
            }
            catch (Exception)
            {
                Response.Redirect("http://testcotizador.unitypromotores.com/Cotizador/SinConexion.aspx");
            }

            if (Id == "")
            {
                Response.Redirect("http://testcotizador.unitypromotores.com/Cotizador/SinConexion.aspx");
            }

        }
    }
}