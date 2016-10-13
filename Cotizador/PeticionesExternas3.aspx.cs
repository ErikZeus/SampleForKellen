using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Cotizador
{
    public partial class PeticionesExternas3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string cotizacion = "";
            try
            {
                cotizacion = Request.QueryString["asdf"];
                if (cotizacion == "")
                {
                    Response.Redirect("Formulario3.aspx");
                }
            }
            catch (Exception)
            {

                Response.Redirect("Formulario3.aspx");
            }


          DataTable content = Cotizadores.Cotizacion(cotizacion);
          string tiposeguro = "";
          int moto = 0;
          Session["Cotizacion"] = cotizacion;
          foreach (DataRow rw in content.Rows)
          {
              Session["CodigoEmpresa"] =rw["CodigoEmpresa"];
              Session["SumaAsegurada"] = rw["SumaAsegurada"];
              Session["RoboParcial"] = "false";
              Session["Menores16"] = "false";
              Session["Menores18"] = "false";
              Session["ExcesosRC"] = "false";
              string SumAsegurada = rw["SumaAsegurada"].ToString();
              if (SumAsegurada == "")
                  SumAsegurada = "0";

              string CodigoEmpresa = rw["CodigoEmpresa"].ToString();
              string _RoboParcial = Cotizadores.ObtieneValor_deducible_robo_total(cotizacion, Decimal.Parse(SumAsegurada), CodigoEmpresa).ToString();
              Session["_RoboParcial"] = _RoboParcial;
              Session["NombreCliente"] = rw["NombreCliente"];
              Session["DescripcionVehiculo"] = rw["DescripcionVehiculo"];
              tiposeguro = rw["TipoSeguro"].ToString();
              if (int.Parse(rw["Moto"].ToString()) == 7)
              { Session["Moto"] = "7";
                 moto = 7;
              }
              else { Session["Moto"] = ""; }
              Session["mensajetipo"] = rw["mensajetipo"];
              break;
          }
          Cotizadores.ActualizaPaso1(cotizacion);
          string codigo = Cotizadores.GuardaCodigo(cotizacion);
          Session["Codigo"] = codigo;
       
          if (tiposeguro == "Seguro Completo")
          {
              Session["Seguro"] = "Seguro Completo";
              if (moto == 7)
              {
                  Response.Redirect("Rpt11.aspx");
              }
              else
              {
                  Response.Redirect("Rpt9.aspx");
              }
          }
          else {
              Session["Seguro"] = "Responsabilidad Civil";
              if (moto == 7)
              {
                  Response.Redirect("Rpt12.aspx"); 
              }
              else
              {
                  Response.Redirect("Rpt10.aspx");
              }

             
          }
 
        }
    }
}