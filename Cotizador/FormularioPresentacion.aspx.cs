using System;
using System.Web.UI;


namespace Cotizador
{
    public partial class FormularioPresentacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (this.txtimgcode.Text == this.Session["CaptchaImageText"].ToString())
            {
                lblCaptchaMsg.Text = "Excellent.......";
            }
            else
            {
                lblCaptchaMsg.Text = "image code is not valid.";
            }
            this.txtimgcode.Text = "";


        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            GeneraNueva();


        }
        private void GeneraNueva()
        {
            // ScriptManager.RegisterStartupScript(Page, GetType(), "disp_confirm", "<script>disp_confirm()</script>", false)

            UpdatePanel15.Update();


        }
    }
}









