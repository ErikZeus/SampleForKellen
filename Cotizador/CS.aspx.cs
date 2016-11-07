using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace Cotizador
{
    public partial class CS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [System.Web.Script.Services.ScriptMethod()]
        [System.Web.Services.WebMethod]
        public static List<string> SearchCustomers(string prefixText, int count)
        {
            string item = "({0}) {1}";
            string Codigo = "";
            string Nombre = "";
            List<string> Result = new List<string>();
            List<string> Content = new List<string>();
            prefixText = prefixText.Replace("-", "").Replace("'", "");
            Content = Cotizadores.Autocomplete(prefixText);
            try
            {
                if (Content.Count > 0)
                {
                    foreach (string linea in Content)
                    {
                        Codigo = linea.Substring(linea.IndexOf(">") + 1, linea.Length - linea.IndexOf(">") - 1);
                        Nombre = linea.Substring(0, linea.IndexOf(">"));
                        item = AjaxControlToolkit.AutoCompleteExtender.CreateAutoCompleteItem(linea, Nombre);
                        if (item == "({0}) {1}")
                            item = "--No se encontraron coincidencias--";

                        Result.Add(item);
                    }
                }
                else
                {

                    if (!string.IsNullOrEmpty(item))
                    {
                        if (item == "({0}) {1}")
                            item = "--No se encontraron coincidencias--";

                        Result.Add(item);
                    }
                }
            }
            catch (Exception)
            {

                string items = "--No se encontraron coincidencias--";


                Result.Add(items);
            }


            return Result;
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (this.txtContactsSearch.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Debe seleccionar un nombre para poder buscarlo.');", true);
                return;
            }

            string seleccion = this.txtContactsSearch.Text;
            seleccion = seleccion.Substring(seleccion.IndexOf('>') + 1, seleccion.ToString().Length - seleccion.IndexOf('>') - 1);
            this.txtId.Text = seleccion;

            Limpiar();
            DataTable content = Cotizadores.Datos(seleccion);

            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                this.txtNombre.Text = rw["Nombre"].ToString();
                this.txtApellido.Text = rw["Apellidos"].ToString();
                this.txtCorreo.Text = rw["Correo"].ToString();
                this.txtTipoVehiculo.Text = rw["TipoDeVehiculo"].ToString();
                this.txtLinea.Text = rw["Linea"].ToString();
                this.txtMarca.Text = rw["Marca"].ToString();
                this.txtTelefono.Text = rw["Telefono"].ToString();
                this.txtModelo.Text = rw["Modelo"].ToString();
                this.txtSumaAsegurada.Text = rw["SumaAsegurada"].ToString();
                this.txtFecha.Text = rw["Fecha"].ToString();
                this.txtTipoSeguro.Text = rw["TipoSeguro"].ToString();
                this.txtContactar.Text = rw["contactar"].ToString();
                this.txtCodigoEmpresa.Text = rw["CodigoEmpresa"].ToString();
                this.txtComoContactar.Text = rw["ComoContactar"].ToString();
                string pass = "";
                if (rw["Paso1"].ToString() == "1") { pass = "Si"; } else { pass = "No"; }
                this.txtPaso1.Text = pass;
                if (rw["Paso2"].ToString() == "1") { pass = "Si"; } else { pass = "No"; }
                this.txtPaso2.Text = pass;
                if (rw["Paso3"].ToString() == "1") { pass = "Si"; } else { pass = "No"; }
                this.txtPaso3.Text = pass;
                this.txtNit.Text = rw["Nit"].ToString();
                this.txtDPI.Text = rw["DPI"].ToString();
                this.txtDireccion.Text = rw["Direccion"].ToString();
                this.txtZona.Text = rw["Zona"].ToString();
                this.txtMunicipio.Text = rw["Municipio"].ToString();
                this.txtIngreso.Text = rw["ingreso"].ToString();
                this.txtStatus.Text = rw["status"].ToString();
            }
            if (content.Rows.Count == 0 || content.Rows.Count == -1)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('No se encontraron datos.');", true);
                Limpiar();
            }


        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (this.txtId.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Debe seleccionar un id para poder buscarlo.');", true);
                return;
            }

            string seleccion = this.txtId.Text;

            Limpiar();
            DataTable content = Cotizadores.Datos(seleccion);

            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                this.txtNombre.Text = rw["Nombre"].ToString();
                this.txtApellido.Text = rw["Apellidos"].ToString();
                this.txtCorreo.Text = rw["Correo"].ToString();
                this.txtTipoVehiculo.Text = rw["TipoDeVehiculo"].ToString();
                this.txtLinea.Text = rw["Linea"].ToString();
                this.txtMarca.Text = rw["Marca"].ToString();
                this.txtTelefono.Text = rw["Telefono"].ToString();
                this.txtModelo.Text = rw["Modelo"].ToString();
                this.txtSumaAsegurada.Text = rw["SumaAsegurada"].ToString();
                this.txtFecha.Text = rw["Fecha"].ToString();
                this.txtTipoSeguro.Text = rw["TipoSeguro"].ToString();
                this.txtContactar.Text = rw["contactar"].ToString();
                this.txtCodigoEmpresa.Text = rw["CodigoEmpresa"].ToString();
                this.txtComoContactar.Text = rw["ComoContactar"].ToString();
                string pass = "";
                if (rw["Paso1"].ToString() == "1") { pass = "Si"; } else { pass = "No"; }
                this.txtPaso1.Text = pass;
                if (rw["Paso2"].ToString() == "1") { pass = "Si"; } else { pass = "No"; }
                this.txtPaso2.Text = pass;
                if (rw["Paso3"].ToString() == "1") { pass = "Si"; } else { pass = "No"; }
                this.txtPaso3.Text = pass;
                this.txtNit.Text = rw["Nit"].ToString();
                this.txtDPI.Text = rw["DPI"].ToString();
                this.txtDireccion.Text = rw["Direccion"].ToString();
                this.txtZona.Text = rw["Zona"].ToString();
                this.txtMunicipio.Text = rw["Municipio"].ToString();
                this.txtIngreso.Text = rw["ingreso"].ToString();
                this.txtStatus.Text = rw["status"].ToString();
            }

            if (content.Rows.Count == 0 || content.Rows.Count == -1)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('No se encontraron datos.');", true);
                Limpiar();
            }
        }

        private void Limpiar()
        {
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";
            this.txtCorreo.Text = "";
            this.txtTipoVehiculo.Text = "";
            this.txtLinea.Text = "";
            this.txtMarca.Text = "";
            this.txtTelefono.Text = "";
            this.txtModelo.Text = "";
            this.txtSumaAsegurada.Text = "";
            this.txtFecha.Text = "";
            this.txtTipoSeguro.Text = "";
            this.txtContactar.Text = "";
            this.txtCodigoEmpresa.Text = "";
            this.txtComoContactar.Text = "";
            string pass = "";
            this.txtPaso1.Text = pass;
            this.txtPaso2.Text = pass;
            this.txtPaso3.Text = pass;
            this.txtNit.Text = "";
            this.txtDPI.Text = "";
            this.txtDireccion.Text = "";
            this.txtZona.Text = "";
            this.txtMunicipio.Text = "";
            this.txtIngreso.Text = "";
            this.txtStatus.Text = "";



        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (this.txtId.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Debe seleccionar un id para imprimir el ARS27.');", true);
                return;
            }
            try
            {
                string _id = this.txtId.Text;
                HttpContext context = HttpContext.Current;
                context.Session["Id"] = _id;
                Response.Redirect("Rpt25.aspx");
            }
            catch (Exception)
            {


            }


        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Rpt26.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Grafica1.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string _id = this.txtId.Text;
            string _motivo = this.txtMotivo.Text;

            if (_motivo == "")
            { return; }

            if (_id == "") { return; }


            Cotizadores.CierrePorAbandono(_id, _motivo);

        }

    }

}