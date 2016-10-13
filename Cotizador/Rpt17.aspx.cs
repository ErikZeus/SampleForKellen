using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;

namespace Cotizador
{
    public partial class Rpt17 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cotizacion = "";
            try
            {
                cotizacion = Request.QueryString["asdf"];
            }
            catch (Exception)
            { }
            try
            {
                cotizacion = Session["Cotizacion"].ToString();
            }
            catch (Exception)
            { }
            string empresa = "";
            string url = "";
            try
            {
                empresa = Session["CodigoEmpresa"].ToString();
                url = Cotizadores.LinkUbicaciones(empresa, "Redireccion");
            }
            catch (Exception)
            {
                Response.Redirect("SinConexion.aspx");
            }

            if (cotizacion == "")
            {
                Response.Redirect(url);
            }
            string codigo = "";
            string revison_codigo = "";
            try
            {
                codigo = Session["Codigo"].ToString();
                revison_codigo = Cotizadores.ObtieneCodigo(cotizacion);
                if (codigo != revison_codigo)
                {
                    Response.Redirect(url);
                }
            }
            catch (Exception)
            {

                 Response.Redirect(url);
             
            }

            try
            {
                string codigoempresa = Session["CodigoEmpresa"].ToString();
                this.Image1.ImageUrl = Cotizadores.LinkPaso1(codigoempresa, cotizacion);
                this.Image2.ImageUrl = Cotizadores.LinkPaso2(codigoempresa, cotizacion);
                this.Image3.ImageUrl = Cotizadores.LinkPaso3(codigoempresa, cotizacion);
                this.Image1.Width = 150;
                this.Image1.Height = 150;
                this.Image2.Width = 150;
                this.Image2.Height = 150;
                this.Image3.Width = 150;
                this.Image3.Height = 150;
                this.HyperLink1.NavigateUrl = Cotizadores.LinkUbicaciones(codigoempresa, "Link4") + "?asdf=" + cotizacion;  
                this.HyperLink2.NavigateUrl = Cotizadores.LinkUbicaciones(codigoempresa, "Link2") + "?asdf=" + cotizacion;
                this.HyperLink3.NavigateUrl = Cotizadores.LinkUbicaciones(codigoempresa, "Link3") + "?asdf=" + cotizacion;
                try
                {
                    string tiposeguro = Session["Seguro"].ToString(); ;
                    if (tiposeguro != "Seguro Completo")
                    {
                        this.Image2.Visible = false;
                    }

                }
                catch (Exception)
                {

                    Response.Redirect(url);
                }
            }
            catch (Exception)
            {

                Response.Redirect(url);
            }


           
        }
    }
}