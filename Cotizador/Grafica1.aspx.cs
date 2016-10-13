using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using WebChart;
using System.Drawing;

namespace Cotizador
{
    public partial class Grafica1 : System.Web.UI.Page
    {
        DataTable dt = new DataTable("Chart");
        DataTable dt1 = new DataTable("Chart1");
        DataTable dt2 = new DataTable("Chart2");
        string X, Y;
        string X1, Y1;
        string X2, Y2;
        Cotizadores Cotizar = new Cotizadores();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                LoadGraphData(dt, Anual());
                LoadGraphData1(dt1, Anual());
                LoadGraphData2(dt2, Anual());
                btnLine_Click(sender, e);

                this.cmbEmpresas.DataValueField = "empresa";
                this.cmbEmpresas.DataTextField = "empresa";
                this.cmbEmpresas.DataSource = Cotizar.LlenaComboEmpresa();
                this.cmbEmpresas.DataBind();
                this.lblMsg.Text = "Grafica para " + this.cmbEmpresas.Text;
                this.txtAño.Text = System.DateTime.Now.Year.ToString();

            }
            else {

                LoadGraphData(dt, Anual());
                LoadGraphData1(dt1, Anual());
                LoadGraphData2(dt2, Anual());
                btnLine_Click(sender, e);
            }


        }

        protected void btnPie_Click(object sender, EventArgs e)
        {
            Chart1Pie();
            Chart2Pie();
            Chart3Pie();
        }
        private void Chart1Pie()
        {
            DataTable dt = new DataTable("Chart");

            LoadGraphData(dt, Anual());
            PieChart chart = new PieChart();

            chart.Fill.Color = Color.FromArgb(50, Color.SteelBlue);
            chart.Line.Color = Color.SteelBlue;
            chart.Line.Width = 1;
            chart.ShowLineMarkers = true;
            chart.DataLabels.Visible = true;

            X = "Mes";
            Y = "Cotizacion";

            chart.DataXValueField = X;
            chart.DataYValueField = Y;
            int bandera = 0;
            //looping through datatable and adding to chart control
            foreach (DataRow dr2 in dt.Rows)
            {
                chart.Data.Add(new ChartPoint(dr2["Mes"].ToString(), (int)System.Convert.ToSingle(dr2["Cotizacion"])));
                bandera += (int)System.Convert.ToSingle(dr2["Cotizacion"]);
            }

            chart.ShowLegend = true;

            ConfigureColors1();
            if (bandera == 0)
            {
                ChartControl1.Width = 0;
                ChartControl1.Height = 0;
                ChartControl1.Charts.Clear();
                ChartControl1.Charts.Add(chart);
                ChartControl1.HasChartLegend = true;
                ChartControl1.Legend.Width = 140;
                ChartControl1.ToolTip = "Cotizaciones Realizadas por Mes";
                this.Chart1.Visible = true;
                this.Chart1.ImageUrl = "http://testcotizador.unitypromotores.com/Cotizador/imagenes/NoData.png";
                this.Chart1.ToolTip = "Cotizaciones Realizadas por Mes";
            }
            else
            {
                ChartControl1.Width = 864;
                ChartControl1.Height = 550;
                ChartControl1.Charts.Clear();
                ChartControl1.Charts.Add(chart);
                ChartControl1.HasChartLegend = true;
                ChartControl1.Legend.Width = 140;
                this.Chart1.Visible = false;
            }
            ChartControl1.RedrawChart();




            dt.Clear();
            dt.Dispose();
        }
        private void Chart2Pie()
        {
            DataTable dt1 = new DataTable("Chart1");

            LoadGraphData1(dt1, Anual());
            PieChart chart = new PieChart();

            chart.Fill.Color = Color.FromArgb(50, Color.SteelBlue);
            chart.Line.Color = Color.SteelBlue;
            chart.Line.Width = 1;
            chart.ShowLineMarkers = true;
            chart.DataLabels.Visible = true;

            X1 = "Mes";
            Y1 = "Cotizacion";

            chart.DataXValueField = X1;
            chart.DataYValueField = Y1;
            int bandera = 0;

            //looping through datatable and adding to chart control
            foreach (DataRow dr2 in dt1.Rows)
            {
                chart.Data.Add(new ChartPoint(dr2["Mes"].ToString(), (int)System.Convert.ToSingle(dr2["Cotizacion"])));
                bandera += (int)System.Convert.ToSingle(dr2["Cotizacion"]);
            }

            chart.ShowLegend = true;

            ConfigureColors2();
            if(bandera == 0)
            {
                ChartControl2.Width = 0;
                ChartControl2.Height = 0;
                ChartControl2.Charts.Clear();
                ChartControl2.Charts.Add(chart);
                ChartControl2.HasChartLegend = true;
                ChartControl2.Legend.Width = 140;
                this.Chart2.Visible = true;
                ChartControl2.ToolTip = "Cierres Reales por Mes";
                this.Chart2.ImageUrl = "http://testcotizador.unitypromotores.com/Cotizador/imagenes/NoData.png";
                this.Chart2.ToolTip = "Cierres Reales por Mes";
            }
            else
            {
                ChartControl2.Width = 864;
                ChartControl2.Height = 550;
                ChartControl2.Charts.Clear();
                ChartControl2.Charts.Add(chart);
                ChartControl2.HasChartLegend = true;
                ChartControl2.Legend.Width = 140;
                this.Chart2.Visible = false;
            }

         
            try
            {
                ChartControl2.RedrawChart();
            }
            catch (Exception es)
            {
                string chk = es.Message;    
            }
     

            dt1.Clear();
            dt1.Dispose();
        }
        private void Chart3Pie()
        {
            DataTable dt2 = new DataTable("Chart2");

            LoadGraphData2(dt2, Anual());
            PieChart chart = new PieChart();

            chart.Fill.Color = Color.FromArgb(50, Color.SteelBlue);
            chart.Line.Color = Color.SteelBlue;
            chart.Line.Width = 1;
            chart.ShowLineMarkers = true;
            chart.DataLabels.Visible = true;

            X2 = "Mes";
            Y2 = "Cotizacion";

            chart.DataXValueField = X2;
            chart.DataYValueField = Y2;
            int bandera = 0;
            //looping through datatable and adding to chart control
            foreach (DataRow dr2 in dt2.Rows)
            {
                chart.Data.Add(new ChartPoint(dr2["Mes"].ToString(), (int)System.Convert.ToSingle(dr2["Cotizacion"])));
                bandera += (int)System.Convert.ToSingle(dr2["Cotizacion"]);
            }

            chart.ShowLegend = true;

            ConfigureColors3();
            if (bandera == 0)
            {
                ChartControl3.Width = 0;
                ChartControl3.Height = 0;
                ChartControl3.Charts.Clear();
                ChartControl3.Charts.Add(chart);
                ChartControl3.HasChartLegend = true;
                ChartControl3.Legend.Width = 140;
                ChartControl3.ToolTip = "Cierres Abandonados por Mes";
                this.Chart3.Visible = true;
                this.Chart3.ImageUrl = "http://testcotizador.unitypromotores.com/Cotizador/imagenes/NoData.png";
                this.Chart3.ToolTip = "Cierres Abandonados por Mes";
              
            }
            else
            {
                // Height="550px" Width="864px"
                ChartControl3.Width = 864;
                ChartControl3.Height = 550;
                ChartControl3.Charts.Clear();
                ChartControl3.Charts.Add(chart);
                ChartControl3.HasChartLegend = true;
                ChartControl3.Legend.Width = 140;
                this.Chart3.Visible = false;
            }


            ChartControl3.RedrawChart();
            dt2.Clear();
            dt2.Dispose();

        }


        private string Anual()
        {
            string year = this.txtAño.Text;
            if (year == "")
            {
                year = System.DateTime.Now.Year.ToString();
            }
            return year;
        }
        protected void btnLine_Click(object sender, EventArgs e)
        {
            Chart1Line();
            Chart2Line();
            Chart3Line();
        }

        private void Chart1Line()
        {
            DataTable dt = new DataTable("Chart");

            LoadGraphData(dt, Anual());

            LineChart chart = new LineChart();

            chart.Fill.Color = Color.FromArgb(50, Color.SteelBlue);
            chart.Line.Color = Color.SteelBlue;
            chart.Line.Width = 1;
            chart.ShowLineMarkers = true;
            chart.DataLabels.Visible = true;

            X = "Mes";
            Y = "Cotizacion";

            chart.DataXValueField = X;
            chart.DataYValueField = Y;

            //looping through datatable and adding to chart control
            foreach (DataRow dr2 in dt.Rows)
            {
                chart.Data.Add(new ChartPoint(dr2["Mes"].ToString(), (int)System.Convert.ToSingle(dr2["Cotizacion"])));
            }

            ConfigureColors1();
            ChartControl1.Width = 864;
            ChartControl1.Height = 550;
            ChartControl1.Charts.Clear();
            ChartControl1.Charts.Add(chart);

            ChartControl1.HasChartLegend = true;
            chart.ShowLegend = false;
            ChartControl1.RedrawChart();
            dt.Clear();
            dt.Dispose();
            try
            {
                this.Chart1.Visible = false;
                this.Chart2.Visible = false;
                this.Chart3.Visible = false;
            }
            catch (Exception)
            { }
        }
        private void Chart2Line()
        {
            DataTable dt1 = new DataTable("Chart1");

            LoadGraphData1(dt1, Anual());

            LineChart chart = new LineChart();

            chart.Fill.Color = Color.FromArgb(50, Color.SteelBlue);
            chart.Line.Color = Color.SteelBlue;
            chart.Line.Width = 1;
            chart.ShowLineMarkers = true;
            chart.DataLabels.Visible = true;

            X1 = "Mes";
            Y1 = "Cotizacion";

            chart.DataXValueField = X1;
            chart.DataYValueField = Y1;

            //looping through datatable and adding to chart control
            foreach (DataRow dr2 in dt1.Rows)
            {
                chart.Data.Add(new ChartPoint(dr2["Mes"].ToString(), (int)System.Convert.ToSingle(dr2["Cotizacion"])));
            }

            ConfigureColors2();
            ChartControl2.Width = 864;
            ChartControl2.Height = 550;
            ChartControl2.Charts.Clear();
            ChartControl2.Charts.Add(chart);

            ChartControl2.HasChartLegend = true;
            chart.ShowLegend = false;
            ChartControl2.RedrawChart();
            dt1.Clear();
            dt1.Dispose();
            try
            {
                this.Chart1.Visible = false;
                this.Chart2.Visible = false;
                this.Chart3.Visible = false;
            }
            catch (Exception)
            { }
        }

        private void Chart3Line()
        {
            DataTable dt2 = new DataTable("Chart2");

            LoadGraphData2(dt2, Anual());

            LineChart chart = new LineChart();

            chart.Fill.Color = Color.FromArgb(50, Color.SteelBlue);
            chart.Line.Color = Color.SteelBlue;
            chart.Line.Width = 1;
            chart.ShowLineMarkers = true;
            chart.DataLabels.Visible = true;

            X2 = "Mes";
            Y2 = "Cotizacion";

            chart.DataXValueField = X2;
            chart.DataYValueField = Y2;

            //looping through datatable and adding to chart control
            foreach (DataRow dr2 in dt2.Rows)
            {
                chart.Data.Add(new ChartPoint(dr2["Mes"].ToString(), (int)System.Convert.ToSingle(dr2["Cotizacion"])));
            }

            ConfigureColors3();
            ChartControl3.Width = 864;
            ChartControl3.Height = 550;
            ChartControl3.Charts.Clear();
            ChartControl3.Charts.Add(chart);

            ChartControl3.HasChartLegend = true;
            chart.ShowLegend = false;
            ChartControl3.RedrawChart();
            dt2.Clear();
            dt2.Dispose();
            try
            {
                this.Chart1.Visible = false;
                this.Chart2.Visible = false;
                this.Chart3.Visible = false;
            }
            catch (Exception)
            { }
        }

        private void ConfigureColors1()
        {
            ChartControl1.Legend.Position = LegendPosition.Bottom;
            ChartControl1.Legend.Width = 80;
            ChartControl1.YAxisFont.ForeColor = Color.Black;
            ChartControl1.XAxisFont.ForeColor = Color.Black;
            ChartControl1.ChartTitle.Text = "Cotizaciones Realizadas por Mes";
            ChartControl1.ChartTitle.ForeColor = Color.White;
            ChartControl1.XTitle.Text = "Mes";
            ChartControl1.YTitle.Text = "Cantidad";



        }
        private void ConfigureColors2()
        {

            ChartControl2.Legend.Position = LegendPosition.Bottom;
            ChartControl2.Legend.Width = 80;
            ChartControl2.YAxisFont.ForeColor = Color.Black;
            ChartControl2.XAxisFont.ForeColor = Color.Black;
            ChartControl2.ChartTitle.Text = "Cierres Reales por Mes";
            ChartControl2.ChartTitle.ForeColor = Color.White;
            ChartControl2.XTitle.Text = "Mes";
            ChartControl2.YTitle.Text = "Cantidad";



        }
        private void ConfigureColors3()
        {


            ChartControl3.Legend.Position = LegendPosition.Bottom;
            ChartControl3.Legend.Width = 80;
            ChartControl3.YAxisFont.ForeColor = Color.Black;
            ChartControl3.XAxisFont.ForeColor = Color.Black;
            ChartControl3.ChartTitle.Text = "Cierres Abandonados por Mes";
            ChartControl3.ChartTitle.ForeColor = Color.White;
            ChartControl3.XTitle.Text = "Mes";
            ChartControl3.YTitle.Text = "Cantidad";

        }
        private  void LoadGraphData( DataTable dt, string _year)
        {
            // Preparing Data Source For Chart Control
            string empresa = "";
            try
            {
                empresa = this.cmbEmpresas.SelectedItem.Text;
            }
            catch (Exception)
            {

                empresa = this.cmbEmpresas.Text;
            }
         
 
            if (empresa == "Todas..")
            {
                empresa = "";
            }

            
            DataColumn dc = new DataColumn("Mes", typeof(string));
            DataColumn dc1 = new DataColumn("Cotizacion", typeof(int));
            dt.Columns.Add(dc);
            dt.Columns.Add(dc1);
            DataRow dr1 = dt.NewRow();
            dr1[0] = "Enero";
            dr1[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMes("1", empresa, _year);
            dt.Rows.Add(dr1);
            DataRow dr2 = dt.NewRow();
            dr2[0] = "Febrero";
            dr2[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMes("2", empresa, _year);
            dt.Rows.Add(dr2);
            DataRow dr3 = dt.NewRow();
            dr3[0] = "Marzo";
            dr3[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMes("3", empresa, _year);
            dt.Rows.Add(dr3);
            DataRow dr4 = dt.NewRow();
            dr4[0] = "Abril";
            dr4[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMes("4", empresa, _year);
            dt.Rows.Add(dr4);
            DataRow dr5 = dt.NewRow();
            dr5[0] = "Mayo";
            dr5[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMes("5", empresa, _year);
            dt.Rows.Add(dr5);
            DataRow dr6 = dt.NewRow();
            dr6[0] = "Junio";
            dr6[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMes("6", empresa, _year);
            dt.Rows.Add(dr6);
            DataRow dr7 = dt.NewRow();
            dr7[0] = "Julio";
            dr7[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMes("7", empresa, _year);
            dt.Rows.Add(dr7);
            DataRow dr8 = dt.NewRow();
            dr8[0] = "Agosto";
            dr8[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMes("8", empresa, _year);
            dt.Rows.Add(dr8);
            DataRow dr9 = dt.NewRow();
            dr9[0] = "Septiembre";
            dr9[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMes("9", empresa, _year);
            dt.Rows.Add(dr9);
            DataRow dr10 = dt.NewRow();
            dr10[0] = "Octubre";
            dr10[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMes("10", empresa, _year);
            dt.Rows.Add(dr10);
            DataRow dr11 = dt.NewRow();
            dr11[0] = "Noviembre";
            dr11[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMes("11", empresa, _year);
            dt.Rows.Add(dr11);
            DataRow dr12 = dt.NewRow();
            dr12[0] = "Diciembre";
            dr12[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMes("12", empresa, _year);
            dt.Rows.Add(dr12);

        }
        private void LoadGraphData1( DataTable dt1, string _year)
        {
            // Preparing Data Source For Chart Control
            string empresa = "";
            try
            {
                empresa = this.cmbEmpresas.SelectedItem.Text;
            }
            catch (Exception)
            {

                empresa = this.cmbEmpresas.Text;
            }


            if (empresa == "Todas..")
            {
                empresa = "";
            }


            DataColumn dc = new DataColumn("Mes", typeof(string));
            DataColumn dc1 = new DataColumn("Cotizacion", typeof(int));
            dt1.Columns.Add(dc);
            dt1.Columns.Add(dc1);
            DataRow dr1 = dt1.NewRow();
            dr1[0] = "Enero";
            dr1[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMesReales("1", empresa, _year);
            dt1.Rows.Add(dr1);
            DataRow dr2 = dt1.NewRow();
            dr2[0] = "Febrero";
            dr2[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMesReales("2", empresa, _year);
            dt1.Rows.Add(dr2);
            DataRow dr3 = dt1.NewRow();
            dr3[0] = "Marzo";
            dr3[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMesReales("3", empresa, _year);
            dt1.Rows.Add(dr3);
            DataRow dr4 = dt1.NewRow();
            dr4[0] = "Abril";
            dr4[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMesReales("4", empresa, _year);
            dt1.Rows.Add(dr4);
            DataRow dr5 = dt1.NewRow();
            dr5[0] = "Mayo";
            dr5[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMesReales("5", empresa, _year);
            dt1.Rows.Add(dr5);
            DataRow dr6 = dt1.NewRow();
            dr6[0] = "Junio";
            dr6[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMesReales("6", empresa, _year);
            dt1.Rows.Add(dr6);
            DataRow dr7 = dt1.NewRow();
            dr7[0] = "Julio";
            dr7[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMesReales("7", empresa, _year);
            dt1.Rows.Add(dr7);
            DataRow dr8 = dt1.NewRow();
            dr8[0] = "Agosto";
            dr8[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMesReales("8", empresa, _year);
            dt1.Rows.Add(dr8);
            DataRow dr9 = dt1.NewRow();
            dr9[0] = "Septiembre";
            dr9[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMesReales("9", empresa, _year);
            dt1.Rows.Add(dr9);
            DataRow dr10 = dt1.NewRow();
            dr10[0] = "Octubre";
            dr10[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMesReales("10", empresa, _year);
            dt1.Rows.Add(dr10);
            DataRow dr11 = dt1.NewRow();
            dr11[0] = "Noviembre";
            dr11[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMesReales("11", empresa, _year);
            dt1.Rows.Add(dr11);
            DataRow dr12 = dt1.NewRow();
            dr12[0] = "Diciembre";
            dr12[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMesReales("12", empresa, _year);
            dt1.Rows.Add(dr12);

        }
        private void LoadGraphData2( DataTable dt2, string _year)
        {
            // Preparing Data Source For Chart Control
            string empresa = "";
            try
            {
                empresa = this.cmbEmpresas.SelectedItem.Text;
            }
            catch (Exception)
            {

                empresa = this.cmbEmpresas.Text;
            }


            if (empresa == "Todas..")
            {
                empresa = "";
            }


            DataColumn dc = new DataColumn("Mes", typeof(string));
            DataColumn dc1 = new DataColumn("Cotizacion", typeof(int));
            dt2.Columns.Add(dc);
            dt2.Columns.Add(dc1);
            DataRow dr1 = dt2.NewRow();
            dr1[0] = "Enero";
            dr1[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMesAbandonados("1", empresa, _year);
            dt2.Rows.Add(dr1);
            DataRow dr2 = dt2.NewRow();
            dr2[0] = "Febrero";
            dr2[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMesAbandonados("2", empresa, _year);
            dt2.Rows.Add(dr2);
            DataRow dr3 = dt2.NewRow();
            dr3[0] = "Marzo";
            dr3[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMesAbandonados("3", empresa, _year);
            dt2.Rows.Add(dr3);
            DataRow dr4 = dt2.NewRow();
            dr4[0] = "Abril";
            dr4[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMesAbandonados("4", empresa, _year);
            dt2.Rows.Add(dr4);
            DataRow dr5 = dt2.NewRow();
            dr5[0] = "Mayo";
            dr5[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMesAbandonados("5", empresa, _year);
            dt2.Rows.Add(dr5);
            DataRow dr6 = dt2.NewRow();
            dr6[0] = "Junio";
            dr6[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMesAbandonados("6", empresa, _year);
            dt2.Rows.Add(dr6);
            DataRow dr7 = dt2.NewRow();
            dr7[0] = "Julio";
            dr7[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMesAbandonados("7", empresa, _year);
            dt2.Rows.Add(dr7);
            DataRow dr8 = dt2.NewRow();
            dr8[0] = "Agosto";
            dr8[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMesAbandonados("8", empresa, _year);
            dt2.Rows.Add(dr8);
            DataRow dr9 = dt2.NewRow();
            dr9[0] = "Septiembre";
            dr9[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMesAbandonados("9", empresa, _year);
            dt2.Rows.Add(dr9);
            DataRow dr10 = dt2.NewRow();
            dr10[0] = "Octubre";
            dr10[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMesAbandonados("10", empresa, _year);
            dt2.Rows.Add(dr10);
            DataRow dr11 = dt2.NewRow();
            dr11[0] = "Noviembre";
            dr11[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMesAbandonados("11", empresa, _year);
            dt2.Rows.Add(dr11);
            DataRow dr12 = dt2.NewRow();
            dr12[0] = "Diciembre";
            dr12[1] = Cotizador.Cotizadores.ObtieneEstadisticaPorMesAbandonados("12", empresa, _year);
            dt2.Rows.Add(dr12);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string path = HttpContext.Current.Request.PhysicalApplicationPath;
            Cotizadores.LimpiarGraficas(path);
            string _fechaini = this.HiddenField1.Value.ToString();
            string _fechafin = this.HiddenField2.Value.ToString();
            string _CodigoEmpresa = this.cmbEmpresas.Text;
            if (_CodigoEmpresa == "")
                _CodigoEmpresa = "Todas..";

            Session.Add("FechaIni", _fechaini);
            Session.Add("FechaFin", _fechafin);
            Session.Add("CodigoEmpresa", _CodigoEmpresa);

            Response.Redirect("Rpt27.aspx");


        }

        protected void cmbEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblMsg.Text = "Grafica para " +  this.cmbEmpresas.Text;
        }

        protected void btnBar_Click(object sender, EventArgs e)
        {
            Chart1Bar();
            Chart2Bar();
            Chart3Bar();
        }
        private void Chart1Bar()
        {
            DataTable dt = new DataTable("Chart");
            LoadGraphData(dt, Anual());

            ColumnChart chart = new ColumnChart();
            chart.Fill.Color = Color.FromArgb(50, Color.SteelBlue);
            chart.Line.Color = Color.Black;
            chart.Line.Width = 1;
            chart.ShowLineMarkers = true;
            chart.DataLabels.Visible = true;

            X = "Mes";
            Y = "Cotizacion";

            chart.DataXValueField = X;
            chart.DataYValueField = Y;

            //looping through datatable and adding to chart control
            foreach (DataRow dr2 in dt.Rows)
            {
                chart.Data.Add(new ChartPoint(dr2["Mes"].ToString(), (int)System.Convert.ToSingle(dr2["Cotizacion"])));
            }

            ConfigureColors1();
            ChartControl1.Width = 864;
            ChartControl1.Height = 550;
            ChartControl1.Charts.Clear();
            ChartControl1.Charts.Add(chart);

            ChartControl1.HasChartLegend = true;
            chart.ShowLegend = false;
            ChartControl1.RedrawChart();

            dt.Clear();
            dt.Dispose();
            try
            {
                this.Chart1.Visible = false;
                this.Chart2.Visible = false;
                this.Chart3.Visible = false;
            }
            catch (Exception)
            { }
        }
        private void Chart2Bar()
        {
            DataTable dt1 = new DataTable("Chart1");
            LoadGraphData1(dt1, Anual());

            ColumnChart chart = new ColumnChart();
            chart.Fill.Color = Color.FromArgb(50, Color.SteelBlue);
            chart.Line.Color = Color.Black;
            chart.Line.Width = 1;
            chart.ShowLineMarkers = true;
            chart.DataLabels.Visible = true;

            X1 = "Mes";
            Y1 = "Cotizacion";

            chart.DataXValueField = X1;
            chart.DataYValueField = Y1;

            //looping through datatable and adding to chart control
            foreach (DataRow dr2 in dt1.Rows)
            {
                chart.Data.Add(new ChartPoint(dr2["Mes"].ToString(), (int)System.Convert.ToSingle(dr2["Cotizacion"])));
            }

            ConfigureColors2();
            ChartControl2.Width = 864;
            ChartControl2.Height = 550;
            ChartControl2.Charts.Clear();
            ChartControl2.Charts.Add(chart);

            ChartControl2.HasChartLegend = true;
            chart.ShowLegend = false;
            ChartControl2.RedrawChart();

            dt1.Clear();
            dt1.Dispose();
            try
            {
                this.Chart1.Visible = false;
                this.Chart2.Visible = false;
                this.Chart3.Visible = false;
            }
            catch (Exception)
            { }
        }
        private void Chart3Bar()
        {
            DataTable dt2 = new DataTable("Chart2");
            LoadGraphData2(dt2, Anual());

            ColumnChart chart = new ColumnChart();
            chart.Fill.Color = Color.FromArgb(50, Color.SteelBlue);
            chart.Line.Color = Color.Black;
            chart.Line.Width = 1;
            chart.ShowLineMarkers = true;
            chart.DataLabels.Visible = true;

            X2 = "Mes";
            Y2 = "Cotizacion";

            chart.DataXValueField = X2;
            chart.DataYValueField = Y2;

            //looping through datatable and adding to chart control
            foreach (DataRow dr2 in dt2.Rows)
            {
                chart.Data.Add(new ChartPoint(dr2["Mes"].ToString(), (int)System.Convert.ToSingle(dr2["Cotizacion"])));
            }

            ConfigureColors3();
            ChartControl3.Width = 864;
            ChartControl3.Height = 550;
            ChartControl3.Charts.Clear();
            ChartControl3.Charts.Add(chart);

            ChartControl3.HasChartLegend = true;
            chart.ShowLegend = false;
            ChartControl3.RedrawChart();

            dt2.Clear();
            dt2.Dispose();
            try
            {
                this.Chart1.Visible = false;
                this.Chart2.Visible = false;
                this.Chart3.Visible = false;
            }
            catch (Exception)
            {   }

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            string path = HttpContext.Current.Request.PhysicalApplicationPath;
            Cotizadores.LimpiarGraficas(path);
            Response.Redirect("CS.aspx");
        }
    }
}