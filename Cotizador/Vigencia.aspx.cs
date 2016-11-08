using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Cotizador
{
    public partial class Vigencia : System.Web.UI.Page
    {
        Cotizadores Cotizar = new Cotizadores();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarCombos();
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void CargarCombos()
        {




            this.cmbEmpresas.DataValueField = "indice";
            this.cmbEmpresas.DataTextField = "CodigoEmpresa";
            this.cmbEmpresas.DataSource = Cotizar.LlenaComboNombreEmpresas();
            this.cmbEmpresas.DataBind();
            this.cmbEmpresas.Items.Insert(0, "Seleccione..");

            this.cmbEmpresasProRata.DataValueField = "indice";
            this.cmbEmpresasProRata.DataTextField = "CodigoEmpresa";
            this.cmbEmpresasProRata.DataSource = Cotizar.LlenaComboEmpresaProRata();
            this.cmbEmpresasProRata.DataBind();
            this.cmbEmpresasProRata.Items.Insert(0, "Seleccione..");

            this.cmbEmpresasProRataQuitar.DataValueField = "indice";
            this.cmbEmpresasProRataQuitar.DataTextField = "CodigoEmpresa";
            this.cmbEmpresasProRataQuitar.DataSource = Cotizar.LlenaComboEmpresaProRata();
            this.cmbEmpresasProRataQuitar.DataBind();
            this.cmbEmpresasProRataQuitar.Items.Insert(0, "Seleccione..");

            this.cmbNombre.DataValueField = "Correo";
            this.cmbNombre.DataTextField = "Nombre";
            this.cmbNombre.DataSource = Cotizar.LlenaComboNombreEjecutivo();
            this.cmbNombre.DataBind();
            this.cmbNombre.Items.Insert(0, "Seleccione..");




        }

        protected void cmbEmpresasProRata_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbEmpresasProRata.SelectedItem.Text.ToString().Trim() != "Seleccione..")
            {
                string resultado = cmbEmpresasProRata.SelectedItem.Text.ToString().Trim();
                this.lblVigencia.Text = Cotizar.ObtieneFechaVigencia(resultado);
            }
            else {
                this.lblVigencia.Text = ".";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (this.cmbNombre.SelectedItem.Text == "Seleccione..")
            {
                this.lblMensaje.Text = "Debe indicar un nombre.";
                return;
            }
            else {
                this.lblMensaje.Text = ".";
            }
            if (this.cmbEmpresasProRata.SelectedItem.Text == "Seleccione..")
            {
                this.lblMensaje.Text = "Debe indicar la empresa para ver su vigencia.";
                return;
            }
            else
            {
                this.lblMensaje.Text = ".";
            }

            string Fecha = this.HiddenField1.Value;

            if (Fecha == "")
            {
                this.lblMensaje.Text = "Debe indicar una fecha.";
                return;
            }
            string correo = this.cmbNombre.SelectedValue.ToString();
            string codigoempresa = this.cmbEmpresasProRata.SelectedItem.Text;

            Cotizar.ActualizarFecha(correo, Fecha, codigoempresa);
            this.lblMensaje.Text = "Vigencia Actualizada Exitosamente.";
            this.HiddenField1.Value = "";
            this.lblMensajeEmpresa.Text = ".";
            this.lblMensajeQuitarEmpresa.Text = ".";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (this.cmbNombre.SelectedItem.Text == "Seleccione..")
            {
                this.lblMensajeEmpresa.Text = "Debe indicar un nombre.";
                return;
            }
            else
            {
                this.lblMensajeEmpresa.Text = ".";
            }

            if (this.cmbEmpresas.SelectedItem.Text == "Seleccione..")
            {
                this.lblMensajeEmpresa.Text = "Debe indicar la empresa para ver su vigencia.";
                return;
            }
            else
            {
                this.lblMensajeEmpresa.Text = ".";
            }
            string correo = this.cmbNombre.SelectedValue.ToString();
            string codigoempresa = this.cmbEmpresas.SelectedItem.Text;
            Cotizar.AgregarEmpresaProrateo(correo, codigoempresa);
            this.lblMensajeEmpresa.Text = "Empresa Agregada Exitosamente.";
            CargarCombos();
            this.lblMensajeQuitarEmpresa.Text = ".";
            this.lblMensaje.Text = ".";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (this.cmbNombre.SelectedItem.Text == "Seleccione..")
            {
                this.lblMensajeQuitarEmpresa.Text = "Debe indicar un nombre.";
                return;
            }
            else
            {
                this.lblMensajeQuitarEmpresa.Text = ".";
            }

            if (this.cmbEmpresasProRataQuitar.SelectedItem.Text == "Seleccione..")
            {
                this.lblMensajeQuitarEmpresa.Text = "Debe indicar la empresa para ver su vigencia.";
                return;
            }
            else
            {
                this.lblMensajeQuitarEmpresa.Text = ".";
            }

            string correo = this.cmbNombre.SelectedValue.ToString();
            string codigoempresa = this.cmbEmpresasProRataQuitar.SelectedItem.Text;
            Cotizar.QuitarEmpresaProrateo(correo, codigoempresa);
            this.lblMensajeQuitarEmpresa.Text = "La empresa se removio del calculo para Prorateo";
            CargarCombos();
            this.lblMensaje.Text = ".";
            this.lblMensajeEmpresa.Text = ".";
        }
    }
}