using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace Cotizador
{
    public partial class Formulario5 : System.Web.UI.Page
    {
        Cotizadores  Cotizar = new Cotizadores();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
           
                CargarCombos();

            }

        }

        private void CargarCombos()
        {

            this.cmbTipoVehiculo.DataValueField = "indice";
            this.cmbTipoVehiculo.DataTextField = "Descripcion";
            this.cmbTipoVehiculo.DataSource = Cotizar.LlenaComboTipoVehiculo();
            this.cmbTipoVehiculo.DataBind();

            //this.cmbLinea.DataValueField = "indice";
            //this.cmbLinea.DataTextField = "Descripcion";
            //this.cmbLinea.DataSource = Cotizar.LlenaComboLinea();
            //this.cmbLinea.DataBind();

            this.cmbMarca.DataValueField = "indice";
            this.cmbMarca.DataTextField = "Descripcion";
            this.cmbMarca.DataSource = Cotizar.LlenaComboMarca();
            this.cmbMarca.DataBind();

            this.cmbModelo.DataValueField = "indice";
            this.cmbModelo.DataTextField = "Descripcion";
            this.cmbModelo.DataSource = Cotizar.LlenaComboModelo();
            this.cmbModelo.DataBind();


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Decimal SumaAsegurada = 0;
            Decimal NetaAnual = 0;
            Decimal RoboParcial = 0;

            bool Incompleto = false;
            if (this.txtNombre.Text.Trim() == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "errNombre", "document.getElementById('errNombre').style.visibility = 'visible';", true);
                Incompleto = true;
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "errNombre", "document.getElementById('errNombre').style.visibility = 'hidden';", true);
            }
            if (this.txtApellido.Text.Trim() == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "errApellido", "document.getElementById('errApellido').style.visibility = 'visible';", true);
                Incompleto = true;
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "errApellido", "document.getElementById('errApellido').style.visibility = 'hidden';", true);
            }

            if (this.txtCorreo.Text.Trim() == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "errCorreo", "document.getElementById('errCorreo').style.visibility = 'visible';", true);
                Incompleto = true;
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "errCorreo", "document.getElementById('errCorreo').style.visibility = 'hidden';", true);
            }
            if (this.txtTelefono.Text.Trim() == "" || this.txtTelefono.Text.ToString().Length != 8)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "errTelefono", "document.getElementById('errTelefono').style.visibility = 'visible';", true);
                Incompleto = true;
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "errTelefono", "document.getElementById('errTelefono').style.visibility = 'hidden';", true);
            }
            string ValorMercado = "";

            if (this.rdSeguroCompleto.Checked == true)
            {
            
                if (this.txtValorMercado.Text.Trim() == "")
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "errMontoAsegurado", "document.getElementById('errMontoAsegurado').style.visibility = 'visible';", true);
                    Incompleto = true;
                }
                else
                {
                    ValorMercado = this.txtValorMercado.Text.Trim();
                    ClientScript.RegisterStartupScript(this.GetType(), "errMontoAsegurado", "document.getElementById('errMontoAsegurado').style.visibility = 'hidden';", true);
                }
            }
            if (this.rdSeguroCompleto.Checked == false && this.rdResponsabilidadCivil.Checked == false)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "errDañosATerceros", "document.getElementById('errDañosATerceros').style.visibility = 'visible';", true);
                ClientScript.RegisterStartupScript(this.GetType(), "errResponsabilidadCivil", "document.getElementById('errResponsabilidadCivil').style.visibility = 'visible';", true);

                Incompleto = true;
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "errDañosATerceros", "document.getElementById('errDañosATerceros').style.visibility = 'hidden';", true);
                ClientScript.RegisterStartupScript(this.GetType(), "errResponsabilidadCivil", "document.getElementById('errResponsabilidadCivil').style.visibility = 'hidden';", true);
            }

         
            bool isEmail = Regex.IsMatch(this.txtCorreo.Text.Trim().ToString(), @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (isEmail == false)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "errCorreo", "document.getElementById('errCorreo').style.visibility = 'visible';", true);
                Incompleto = true;
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "errCorreo", "document.getElementById('errCorreo').style.visibility = 'hidden';", true);
            }
            if (this.HiddenField1.Value.ToString() == "" || this.HiddenField1.Value.ToString() == "dd/mm/aaaa")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "errFecha", "document.getElementById('errFecha').style.visibility = 'visible';", true);
                Incompleto = true;
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "errFecha", "document.getElementById('errFecha').style.visibility = 'hidden';", true);
            }
            if (this.cmbHora.SelectedItem.Text.ToString() == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "errHora", "document.getElementById('errHora').style.visibility = 'visible';", true);
                Incompleto = true;
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "errHora", "document.getElementById('errHora').style.visibility = 'hidden';", true);
            }
            
            if (this.txtLinea.Text.ToString() == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "errLinea", "document.getElementById('errLinea').style.visibility = 'visible';", true);
                Incompleto = true;
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "errLinea", "document.getElementById('errLinea').style.visibility = 'hidden';", true);
            }

            if (this.chkChat.Checked == false && this.chkTelefono.Checked == false)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "errChk1", "document.getElementById('errChk1').style.visibility = 'visible';", true);
                ClientScript.RegisterStartupScript(this.GetType(), "errChk2", "document.getElementById('errChk2').style.visibility = 'visible';", true);
                Incompleto = true;
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "errChk1", "document.getElementById('errChk1').style.visibility = 'hidden';", true);
                ClientScript.RegisterStartupScript(this.GetType(), "errChk2", "document.getElementById('errChk2').style.visibility = 'hidden';", true);

            }

            string Marca = "";
            if (this.cmbMarca.SelectedItem.Text.Trim() != "")
            {
                Marca = this.cmbMarca.SelectedItem.Text.Trim();
            }
            if (cmbMarca.SelectedItem.Text == "...OTRAS MARCAS")
            {
                if (this.txtMarca.Text == "")
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "errMarca", "document.getElementById('errMarca').style.visibility = 'visible';", true);
                    ClientScript.RegisterStartupScript(this.GetType(), "errMarca", "document.getElementById('errMarca').style.display = 'inline-block';", true);
                    Incompleto = true;
                }
                else
                {
                    Marca = this.txtMarca.Text;
                    ClientScript.RegisterStartupScript(this.GetType(), "errMarca", "document.getElementById('errMarca').style.visibility = 'hidden';", true);
                    ClientScript.RegisterStartupScript(this.GetType(), "errMarca", "document.getElementById('errMarca').style.display = 'none';", true);

                }
            }

            if (ValorMercado == "")
                ValorMercado = "0";

            //if (this.chkRoboParcial.Checked)
            //{
            //    if (this.txtValorEstimadoRoboParcial.Text.ToString() == "")
            //    {
            //        ClientScript.RegisterStartupScript(this.GetType(), "errRoboParcial", "document.getElementById('errRoboParcial').style.visibility = 'visible';", true);
            //        Incompleto = true;
            //    }
            //    else
            //    {
            //        ClientScript.RegisterStartupScript(this.GetType(), "errRoboParcial", "document.getElementById('errRoboParcial').style.visibility = 'hidden';", true);
            //        RoboParcial = Decimal.Parse(this.txtValorEstimadoRoboParcial.Text.ToString().Trim());
            //    }
            //    decimal equipo_especial = 0;
            //    decimal cien = 100;
            //    decimal mil = 1000;

            //    equipo_especial = decimal.Parse(ValorMercado) * (cien) / (mil);
            //    if (RoboParcial > equipo_especial)
            //    {
            //        ClientScript.RegisterStartupScript(this.GetType(), "errRoboParcial", "document.getElementById('errRoboParcial').style.visibility = 'visible';", true);
            //        ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('El valor del equipo especial nunca podrá ser mayor al 10% del valor del vehículo asegurado, maximo permitido :" + equipo_especial.ToString() + ".');", true);
            //        this.txtValorEstimadoRoboParcial.Text = equipo_especial.ToString();
            //        Incompleto = true;
            //    }
            //    else
            //    {
            //        ClientScript.RegisterStartupScript(this.GetType(), "errRoboParcial", "document.getElementById('errRoboParcial').style.visibility = 'hidden';", true);
            //    }

            //}

            this.lblMsg.Text = "";

            string _tipo_seguro = "";
            int MensajeTipo = 1;
            if (this.rdSeguroCompleto.Checked == true)
            { _tipo_seguro = "Seguro Completo";
               MensajeTipo = 1;
            }
            else
            { _tipo_seguro = "Responsabilidad Civil";
              MensajeTipo = 2;
            }

            if (cmbTipoVehiculo.SelectedValue == "7" && _tipo_seguro == "Seguro Completo")
            {
                MensajeTipo = 7;
            }

            if (cmbTipoVehiculo.SelectedValue == "7" && _tipo_seguro == "Responsabilidad Civil")
            {
                MensajeTipo = 8;
            }

            if (cmbTipoVehiculo.SelectedValue == "41" && _tipo_seguro == "Responsabilidad Civil")
            {
                MensajeTipo = 3;
            }

            if (Incompleto)
                return;

            string contactar = "";
            if (this.chkChat.Checked)
                contactar = "Por Chat";

            if (this.chkTelefono.Checked)
                contactar = "Por Telefono";
            contactar += " - " + this.cmbHora.SelectedItem.Text;
            string DescripcionVehiculo = this.cmbTipoVehiculo.SelectedItem.Text + " - " + this.cmbMarca.SelectedItem.Text + " - " + this.cmbModelo.SelectedItem.Text + " - " + this.txtLinea.Text;
            string id = Cotizar.GuardaCotizacion(this.txtNombre.Text.Trim(), this.txtApellido.Text.Trim(), this.txtCorreo.Text.Trim(), this.cmbTipoVehiculo.SelectedItem.Text.Trim(), this.txtLinea.Text.Trim(), Marca, this.txtTelefono.Text.Trim(), this.cmbModelo.SelectedItem.Text.Trim(), Decimal.Parse(ValorMercado), _tipo_seguro, this.txtCorreo.Text.ToString(), "CEG", contactar, "0", this.HiddenField1.Value.ToString(), MensajeTipo.ToString());

             SumaAsegurada = Decimal.Parse(ValorMercado);
          //   Valores Calculo = new Valores("CEG", SumaAsegurada, this.chkRoboParcial.Checked, this.chkMenores16.Checked, this.chkMenores18.Checked, this.chkExcesoRC.Checked, RoboParcial, MensajeTipo);
             Valores Calculo = new Valores("CEG", SumaAsegurada, false, false, false, false, RoboParcial, MensajeTipo);
             this.lblMsg.Text = Calculo.PrimaTotalProRata.ToString();
             string valorprima = Calculo.PrimaTotalProRata.ToString();
             Cotizadores.ActualizaPrima(id, Calculo.PrimaTotalProRata.ToString());
             // ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('La cotización ha sido enviada a su correo: " + this.txtCorreo.Text + ");", true);
             //  EnvioDeCorreoRapido.EjecutarProceso(this.txtCorreo.Text.Trim(), this.cmbTipoVehiculo.SelectedItem.Text.Trim(), this.txtLinea.Text.Trim(), Marca, this.cmbModelo.SelectedItem.Text.Trim(), ValorMercado, MensajeTipo, this.txtNombre.Text.Trim(), "CEG", this.chkRoboParcial.Checked, this.chkMenores16.Checked, this.chkMenores18.Checked, this.chkExcesoRC.Checked, RoboParcial, this.txtNombre.Text.Trim(), DescripcionVehiculo);
             EnvioDeCorreoRapido.EjecutarProceso(this.txtCorreo.Text.Trim(), this.cmbTipoVehiculo.SelectedItem.Text.Trim(), this.txtLinea.Text.Trim(), Marca, this.cmbModelo.SelectedItem.Text.Trim(), ValorMercado, MensajeTipo, this.txtNombre.Text.Trim(), "CEG", false, false, false, false, RoboParcial, this.txtNombre.Text.Trim(), DescripcionVehiculo, id, valorprima);
             List<CorreosInternos> correo = new List<CorreosInternos>();
             correo = Cotizadores.EnviarCorreosInternos("CEG");
             string lineaTitulo = this.txtNombre.Text + " Tel: " + this.txtTelefono.Text + " Correo: " + this.txtCorreo.Text;


             if (correo.Count != 0)
             {
                 foreach (var item in correo)
                 {
                     // EnvioDeCorreoRapido.EjecutarProceso(item.Correo, this.cmbTipoVehiculo.SelectedItem.Text.Trim(), this.txtLinea.Text.Trim(), Marca, this.cmbModelo.SelectedItem.Text.Trim(), ValorMercado, MensajeTipo, this.txtNombre.Text.Trim(), "CEG", this.chkRoboParcial.Checked, this.chkMenores16.Checked, this.chkMenores18.Checked, this.chkExcesoRC.Checked, RoboParcial, this.txtNombre.Text.Trim(), DescripcionVehiculo);
                     EnvioDeCorreoRapido.EjecutarProceso(item.Correo, this.cmbTipoVehiculo.SelectedItem.Text.Trim(), this.txtLinea.Text.Trim()+ " " + lineaTitulo, Marca, this.cmbModelo.SelectedItem.Text.Trim(), ValorMercado, MensajeTipo, this.txtNombre.Text.Trim(), "CEG", false, false, false, false, RoboParcial, this.txtNombre.Text.Trim(), DescripcionVehiculo, id, valorprima);
                 }
             }

             if (this.chkChat.Checked)
             {
                 string nombrechat = Cotizadores.Base64Encode(this.txtNombre.Text.ToString() + " " + this.txtApellido.Text.ToString());
                 string correochat = Cotizadores.Base64Encode(this.txtCorreo.Text.ToString());
                 string telefonochat = Cotizadores.Base64Encode(this.txtTelefono.Text.ToString());
                 string url = "http://chat.unityseguros.com/chat/unity_promotores/chat.php?a=c8c50&intgroup=Q290aXphY2nDs24gU2VndXJvIFZlaMOtY3Vsb3M_&en=" + nombrechat + "&ee=" + correochat + "&ep=" + telefonochat + "&mp=MQ__";
                 Response.Redirect(url);
             }
             else
             {
                 string _correo = this.txtCorreo.Text;
                 string _telefono = this.txtTelefono.Text;

                 Response.Redirect("Agradecimiento.aspx?correo=" + _correo + "&telefono=" + _telefono);
             }

            //if (MensajeTipo == 1)
            // {
            //     Response.Redirect("Rpt1.aspx");
            // }
            // else {
            //     Response.Redirect("Rpt2.aspx");
            // }

        }

        //protected void cmbMarca_TextChanged(object sender, EventArgs e)
        //{
        //    if (cmbMarca.SelectedItem.Text == "...OTRAS MARCAS")
        //    {
        //        ClientScript.RegisterStartupScript(this.GetType(), "Marca_1", "document.getElementById('Marca1').style.visibility = 'visible';", true);
        //        ClientScript.RegisterStartupScript(this.GetType(), "Marca_2", "document.getElementById('Marca1').style.display = 'inline-block';", true);
        //        ClientScript.RegisterStartupScript(this.GetType(), "Marca_3", "document.getElementById('Marca2').style.visibility = 'visible';", true);
        //        ClientScript.RegisterStartupScript(this.GetType(), "Marca_4", "document.getElementById('Marca2').style.display = 'inline-block';", true);
        //    }
        //    else {
        //        ClientScript.RegisterStartupScript(this.GetType(), "Marca_1", "document.getElementById('Marca1').style.visibility = 'hidden';", true);
        //        ClientScript.RegisterStartupScript(this.GetType(), "Marca_2", "document.getElementById('Marca1').style.display = 'none';", true);
        //        ClientScript.RegisterStartupScript(this.GetType(), "Marca_3", "document.getElementById('Marca2').style.visibility = 'hidden';", true);
        //        ClientScript.RegisterStartupScript(this.GetType(), "Marca_4", "document.getElementById('Marca2').style.display = 'none';", true);
        //    }

        //}

        //protected void chkRoboParcial_CheckedChanged(object sender, EventArgs e)
        //{
           
        //    if (rdResponsabilidadCivil.Checked)
        //    {
        //        ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('El robo parcial aplica solo para el seguro completo.');", true);
        //        this.chkRoboParcial.Checked = false;
        //        return;
        //    }

        //    if (this.rdSeguroCompleto.Checked == false && rdResponsabilidadCivil.Checked == false)
        //    {
        //        ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('Esta opcion es aplicable al seleccionar el seguro completo e ingresar el valor de su vehiculo.');", true);
        //        this.chkRoboParcial.Checked = false;
        //        return;
        //    }
        //    if (this.rdSeguroCompleto.Checked)
        //    {
        //        ClientScript.RegisterStartupScript(this.GetType(), "SeguroRobo", "ProcesarRobo()", true);
        //    }

        //}

 


    }
}