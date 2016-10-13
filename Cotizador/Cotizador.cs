using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections;
using System.Text;
using System.Data.OleDb;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Security.Cryptography;
using System.Configuration;
using System.IO;
using System.Web.Configuration;
using System.Net.Mail;
using System.Xml;
using System.Collections.Generic;
using System.Globalization;
using System;


namespace Cotizador
{
    public class Cotizadores
    {

        public DataView LlenaComboTipoVehiculo()
        {

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select indice, Descripcion from TipodeVehiculo order by Descripcion");
            DataView dv = new DataView(content);
            return dv;

        }

        public static List<CorreosInternos> EnviarCorreosInternos(string CodigoEmpresa)
        {

            List<CorreosInternos> data = new List<CorreosInternos>();

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("select Correo from maestro_correosinternos where CodigoEmpresa ='" + CodigoEmpresa + "'");
            foreach (DataRow rw in content.Rows)
            {
                CorreosInternos address = new CorreosInternos();
                address.Correo = rw[0].ToString();
                data.Add(address);
            }

            return data;

        }
        public static List<ImprimirEstado> ReporteEstado()
        {

            ImprimirEstado lista = new ImprimirEstado();
            List<ImprimirEstado> data = new List<ImprimirEstado>();
            DataTable content = AccesoDatos.RegresaTablaMySql("select indice as id, concat(Nombre,' ' , Apellidos) as Nombre, Correo, Telefono, Fecha, DateDiff(curdate(), Fecha) as Dias  from trans_correosenviados where ifnull(Paso3,0) != 1 order by Fecha desc");

            foreach (DataRow rw in content.Rows)
            {
                lista = new ImprimirEstado();
                lista.Id = rw["id"].ToString();
                lista.Nombre = rw["Nombre"].ToString();
                lista.Correo = rw["Correo"].ToString();
                lista.Telefono = rw["Telefono"].ToString();
                lista.Fecha = rw["Fecha"].ToString();
                lista.Dias = rw["Dias"].ToString();

                data.Add(lista);
            }

            return data;

        }
        public static List<ImpresionEsadistico> ReporteEstadistico(string FechaIni, string FechaFin, string CodigoEmpresa)
        {

            DataTable content = new DataTable();
            if (CodigoEmpresa == "Todas..")
            {
                content = AccesoDatos.RegresaTablaMySql("Select C.CodigoEmpresa, C.Cotizaciones, R.CierreReal, A.CierreAbandono, T.TransitoPendiente from  "
    + " (select CodigoEmpresa, count(*) as Cotizaciones from trans_correosenviados where Fecha between '" + FechaIni + "' and '" + FechaFin + "' group by CodigoEmpresa) C  "
    + " left join  "
    + " (select CodigoEmpresa, count(*) as CierreReal from trans_correosenviados where ifnull(abandono, '') = '' and ifnull(Paso3, 0) != 0 and Fecha between '" + FechaIni + "' and '" + FechaFin + "' group by CodigoEmpresa) R  "
    + " on C.CodigoEmpresa = R.CodigoEmpresa  "
    + " left join  "
    + " (select CodigoEmpresa, count(*) as CierreAbandono from trans_correosenviados where ifnull(abandono, '') != '' and ifnull(Paso3, 0) != 0 and Fecha between '" + FechaIni + "' and '" + FechaFin + "' group by CodigoEmpresa) A  "
    + " on C.CodigoEmpresa = A.CodigoEmpresa  "
    + " left join  "
    + " (select CodigoEmpresa, count(*) as TransitoPendiente from trans_correosenviados where ifnull(abandono, '') = '' and ifnull(Paso3, 0) = 0 and Fecha between '" + FechaIni + "' and '" + FechaFin + "' group by CodigoEmpresa) T  "
    + " on C.CodigoEmpresa = T.CodigoEmpresa " +
    " union all " +
    "Select 'Totales', sum( C.Cotizaciones) as Cotizaciones, sum(R.CierreReal) as CierreReal, sum(A.CierreAbandono) as CierreAbandono, sum(T.TransitoPendiente) as TransitoPendiente from  "
    + " (select CodigoEmpresa, count(*) as Cotizaciones from trans_correosenviados where Fecha between '" + FechaIni + "' and '" + FechaFin + "' group by CodigoEmpresa) C  "
    + " left join  "
    + " (select CodigoEmpresa, count(*) as CierreReal from trans_correosenviados where ifnull(abandono, '') = '' and ifnull(Paso3, 0) != 0 and Fecha between '" + FechaIni + "' and '" + FechaFin + "' group by CodigoEmpresa) R  "
    + " on C.CodigoEmpresa = R.CodigoEmpresa  "
    + " left join  "
    + " (select CodigoEmpresa, count(*) as CierreAbandono from trans_correosenviados where ifnull(abandono, '') != '' and ifnull(Paso3, 0) != 0 and Fecha between '" + FechaIni + "' and '" + FechaFin + "' group by CodigoEmpresa) A  "
    + " on C.CodigoEmpresa = A.CodigoEmpresa  "
    + " left join  "
    + " (select CodigoEmpresa, count(*) as TransitoPendiente from trans_correosenviados where ifnull(abandono, '') = '' and ifnull(Paso3, 0) = 0 and Fecha between '" + FechaIni + "' and '" + FechaFin + "' group by CodigoEmpresa) T  "
    + " on C.CodigoEmpresa = T.CodigoEmpresa "
    );
            }
            else
            {
                content = AccesoDatos.RegresaTablaMySql("Select C.CodigoEmpresa, C.Cotizaciones, R.CierreReal, A.CierreAbandono, T.TransitoPendiente from  "
+ " (select CodigoEmpresa, count(*) as Cotizaciones from trans_correosenviados where CodigoEmpresa = '" + CodigoEmpresa + "' and Fecha between '" + FechaIni + "' and '" + FechaFin + "' group by CodigoEmpresa) C  "
+ " left join  "
+ " (select CodigoEmpresa, count(*) as CierreReal from trans_correosenviados where CodigoEmpresa = '" + CodigoEmpresa + "' and  ifnull(abandono, '') = '' and ifnull(Paso3, 0) != 0 and Fecha between '" + FechaIni + "' and '" + FechaFin + "' group by CodigoEmpresa) R  "
+ " on C.CodigoEmpresa = R.CodigoEmpresa  "
+ " left join  "
+ " (select CodigoEmpresa, count(*) as CierreAbandono from trans_correosenviados where CodigoEmpresa = '" + CodigoEmpresa + "' and  ifnull(abandono, '') != '' and ifnull(Paso3, 0) != 0 and Fecha between '" + FechaIni + "' and '" + FechaFin + "' group by CodigoEmpresa) A  "
+ " on C.CodigoEmpresa = A.CodigoEmpresa  "
+ " left join  "
+ " (select CodigoEmpresa, count(*) as TransitoPendiente from trans_correosenviados where CodigoEmpresa = '" + CodigoEmpresa + "' and  ifnull(abandono, '') = '' and ifnull(Paso3, 0) = 0 and Fecha between '" + FechaIni + "' and '" + FechaFin + "' group by CodigoEmpresa) T  "
+ " on C.CodigoEmpresa = T.CodigoEmpresa " +
" union all " +
"Select 'Totales', sum(C.Cotizaciones) as Cotizaciones, sum( R.CierreReal) as CierreReal, sum(A.CierreAbandono) as CierreAbandono, sum( T.TransitoPendiente) as TransitoPendiente from  "
+ " (select CodigoEmpresa, count(*) as Cotizaciones from trans_correosenviados where CodigoEmpresa = '" + CodigoEmpresa + "' and Fecha between '" + FechaIni + "' and '" + FechaFin + "' group by CodigoEmpresa) C  "
+ " left join  "
+ " (select CodigoEmpresa, count(*) as CierreReal from trans_correosenviados where CodigoEmpresa = '" + CodigoEmpresa + "' and  ifnull(abandono, '') = '' and ifnull(Paso3, 0) != 0 and Fecha between '" + FechaIni + "' and '" + FechaFin + "' group by CodigoEmpresa) R  "
+ " on C.CodigoEmpresa = R.CodigoEmpresa  "
+ " left join  "
+ " (select CodigoEmpresa, count(*) as CierreAbandono from trans_correosenviados where CodigoEmpresa = '" + CodigoEmpresa + "' and  ifnull(abandono, '') != '' and ifnull(Paso3, 0) != 0 and Fecha between '" + FechaIni + "' and '" + FechaFin + "' group by CodigoEmpresa) A  "
+ " on C.CodigoEmpresa = A.CodigoEmpresa  "
+ " left join  "
+ " (select CodigoEmpresa, count(*) as TransitoPendiente from trans_correosenviados where CodigoEmpresa = '" + CodigoEmpresa + "' and  ifnull(abandono, '') = '' and ifnull(Paso3, 0) = 0 and Fecha between '" + FechaIni + "' and '" + FechaFin + "' group by CodigoEmpresa) T  "
+ " on C.CodigoEmpresa = T.CodigoEmpresa "
);

            }
            DataView dv = new DataView(content);
     
            List<ImpresionEsadistico> data = new List<ImpresionEsadistico>();
            foreach (DataRow rw in content.Rows)
            {
                ImpresionEsadistico lista = new ImpresionEsadistico();
                lista.CodigoEmpresa = rw["CodigoEmpresa"].ToString() ;
                lista.Cotizaciones = rw["Cotizaciones"].ToString();
                lista.CierreReal = rw["CierreReal"].ToString();
                lista.CierreAbandono = rw["CierreAbandono"].ToString();
                lista.TransitoPendiente = rw["TransitoPendiente"].ToString();
                lista.Rango = "Del " + FechaIni + " al " + FechaFin;
                data.Add(lista);
            }

            return data;

        }
        public static List<ImpresionAbandonos> ReporteAbandonos(string FechaIni, string FechaFin, string CodigoEmpresa)
        {

            DataTable content = new DataTable();
            if (CodigoEmpresa == "Todas..")
            {
                content = AccesoDatos.RegresaTablaMySql("Select concat(indice,' ',CodigoEmpresa ) as indice,  abandono   from  trans_correosenviados where ifnull(abandono,'') != '' and  Fecha between '" + FechaIni + "' and '" + FechaFin + "' group by indice , abandono order by CodigoEmpresa");

            }
            else
            {
                content = AccesoDatos.RegresaTablaMySql("Select concat(indice,' ',CodigoEmpresa ) as indice,  abandono   from  trans_correosenviados where ifnull(abandono,'') != '' and  CodigoEmpresa = '" + CodigoEmpresa + "' and  Fecha between '" + FechaIni + "' and '" + FechaFin + "'  group by indice , abandono order by CodigoEmpresa");
            }
            DataView dv = new DataView(content);
      
            List<ImpresionAbandonos> data = new List<ImpresionAbandonos>();
            foreach (DataRow rw in content.Rows)
            {

                ImpresionAbandonos lista = new ImpresionAbandonos();
                lista.id = rw["indice"].ToString();
                lista.motivo = rw["abandono"].ToString();
                
                data.Add(lista);
            }

            return data;

        }
        public static List<ImprimirFormato> ReporteAsr27(string indice)
        {

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select * from trans_correosenviados where indice = " + indice);
            DataView dv = new DataView(content);
            ImprimirFormato lista = new ImprimirFormato();
            List<ImprimirFormato> data = new List<ImprimirFormato>();
            string NombreP = "", NombreS = "", Nombres = "";
            string ApellidoP = "", ApellidoS = "", Apellido = "";
            foreach (DataRow rw in content.Rows)
            {
                Nombres = rw["Nombre"].ToString();
                if (Nombres.Trim().IndexOf(" ") == -1)
                {
                    NombreP = Nombres;
                }
                else
                {
                    NombreP = Nombres.Substring(0, Nombres.Trim().IndexOf(" "));
                    NombreS = Nombres.Substring(Nombres.Trim().IndexOf(" "), Nombres.Length - Nombres.Trim().IndexOf(" "));
                }
                Apellido = rw["Apellidos"].ToString();

                if (Apellido.Trim().IndexOf(" ") == -1)
                {
                    ApellidoP = Apellido;
                }
                else
                {
                    ApellidoP = Apellido.Substring(0, Apellido.Trim().IndexOf(" "));
                    ApellidoS = Apellido.Substring(Apellido.Trim().IndexOf(" "), Apellido.Length - Apellido.Trim().IndexOf(" "));
                }


                lista.Nombre = rw["Nombre"].ToString();
                lista.Apellidos = rw["Apellidos"].ToString();
                lista.Correo = rw["Correo"].ToString();
                lista.TipoDeVehiculo = rw["TipoDeVehiculo"].ToString();
                lista.Linea = rw["Linea"].ToString();
                lista.Marca = rw["Marca"].ToString();
                lista.Telefono = rw["Telefono"].ToString();
                lista.Modelo = rw["Modelo"].ToString();
                lista.SumaAsegurada = rw["SumaAsegurada"].ToString();
                lista.Fecha = rw["Fecha"].ToString();
                lista.TipoSeguro = rw["TipoSeguro"].ToString();
                lista.contactar = rw["contactar"].ToString();
                lista.CodigoEmpresa = rw["CodigoEmpresa"].ToString();
                lista.ComoContactar = rw["ComoContactar"].ToString();
                lista.Paso1 = rw["Paso1"].ToString();
                lista.Paso2 = rw["Paso2"].ToString();
                lista.Paso3 = rw["Paso3"].ToString();
                lista.Nit = rw["Nit"].ToString();
                lista.DPI = rw["DPI"].ToString();
                lista.Direccion = rw["Direccion"].ToString();
                lista.Zona = rw["Zona"].ToString();
                lista.Municipio = rw["Municipio"].ToString();
                lista.ingreso = rw["ingreso"].ToString();
                lista.status = rw["status"].ToString();
                lista.FechaInicio = rw["FechaInicio"].ToString();
                lista.Prima = rw["prima"].ToString();
                lista.Pasaporte = rw["passaporte"].ToString();
                lista.Nacimiento = rw["nacimiento"].ToString();
                lista.NombreP = NombreP;
                lista.NombreS = NombreS;
                lista.ApellidoP = ApellidoP;
                lista.ApellidoS = ApellidoS;

                data.Add(lista);
            }

            return data;

        }



        public class ImprimirEstado
        {
            public ImprimirEstado() { }

            private string _Id = "";
            public string Id
            {
                get { return _Id; }
                set { this._Id = value; }
            }

            private string _Nombre = "";
            public string Nombre
            {
                get { return _Nombre; }
                set { this._Nombre = value; }
            }

            private string _Correo = "";
            public string Correo
            {
                get { return _Correo; }
                set { this._Correo = value; }
            }

            private string _Telefono = "";
            public string Telefono
            {
                get { return _Telefono; }
                set { this._Telefono = value; }
            }

            private string _Fecha = "";
            public string Fecha
            {
                get { return _Fecha; }
                set { this._Fecha = value; }
            }
            private string _Dias = "";
            public string Dias
            {
                get { return _Dias; }
                set { this._Dias = value; }
            }


        }

        public static List<Impresion> ReporteCotizacion1(string CodigoEmpresa, decimal SumaAsegurada, bool RoboParcial, bool Menores16, bool Menores18, bool ExcesosRC, decimal _RoboParcial, string NombreCliente, string DescripcionVehiculo, string mensajetipo)
        {

            Valores Calculo = new Valores(CodigoEmpresa, SumaAsegurada, RoboParcial, Menores16, Menores18, ExcesosRC, _RoboParcial, int.Parse(mensajetipo));
            Impresion lista = new Impresion();
            List<Impresion> data = new List<Impresion>();
            lista.SumaAsegurada = Calculo.SumaAsegurada;
            lista.Codigo = Calculo.Codigo;
            lista.PrimaNeta = Calculo.PrimaNeta;
            lista.PrimaNetaProRata = Calculo.PrimaNetaProRata;
            lista.MontoBase = Calculo.MontoBase;
            lista.SumaLimiteParaCalculo = Calculo.SumaLimiteParaCalculo;
            lista.Porcentaje_Menor_100 = Calculo.Porcentaje_Menor_100;
            lista.Porcentaje_Mayor_100 = Calculo.Porcentaje_Mayor_100;
            lista.Costo = Calculo.Costo;
            lista.RoboParcial = Calculo.RoboParcial;
            lista.MenoresDesde16 = Calculo.MenoresDesde16;
            lista.MenoresDesde18 = Calculo.MenoresDesde18;
            lista.ExcesoRC = Calculo.ExcesoRC;
            lista.GastosPorEmision = Calculo.GastosPorEmision;
            lista.GastosPorEmisionProRata = Calculo.GastosPorEmisionProRata;
            lista.Asisto = Calculo.Asisto;
            lista.Iva = Calculo.Iva;
            lista.IvaProRata = Calculo.IvaProRata;
            lista.CoberturaAdicional = Calculo.CoberturaAdicional;
            lista.PrimaTotal = Calculo.PrimaTotal;
            lista.PrimaTotalProRata = Calculo.PrimaTotalProRata;
            lista.CalculoIva = Calculo.CalculoIva;
            lista.DiasAnuales = Calculo.DiasAnuales;
            lista.DiasTotales = Calculo.DiasTotales;
            lista.CadaPago = Calculo.CadaPago;
            lista.Exceso_RC_ElevacionDeCobertura = Calculo.Exceso_RC_ElevacionDeCobertura;
            lista.Exceso_RC_Base = Calculo.Exceso_RC_Base;
            lista.DañosATerceros = Calculo.DañosATerceros;
            lista.NombreCliente = NombreCliente;
            lista.NombreAgente = "";
            lista.DescripcionVehiculo = DescripcionVehiculo;
            lista.MotoDeduciblePorDañosyAccidentes = Calculo.MotoDeduciblesPorDañosyAccidentes;
            lista.MotoDeducibleRobo = Calculo.MotoDeducibles_Robo;
            lista.DeduciblePerdidaParcial = Calculo.deducible_parcial;
            lista.DeducibleRoboTotal = Calculo.deducible_robo_total;
            data.Add(lista);

            return data;

        }
        public DataView LlenaComboMarca()
        {

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql(" SELECT A.* FROM(select * from marca ORDER BY DESCRIPCION) A union all " +
 "Select 0000, '...OTRAS MARCAS'");
            DataView dv = new DataView(content);
            return dv;

        }
        public DataView LlenaComboLinea()
        {

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select indice, Descripcion from linea order by Descripcion");
            DataView dv = new DataView(content);
            return dv;

        }
        public DataView LlenaComboModelo()
        {

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select indice, Descripcion from modelo order by Descripcion");
            DataView dv = new DataView(content);
            return dv;

        }
        public DataView LlenaComboEmpresa()
        {

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql(" Select 'Todas..' as empresa union all select CodigoEmpresa as empresa from maestro_reglasnegocio group by CodigoEmpresa");
            DataView dv = new DataView(content);
            return dv;

        }



        public StringBuilder ObtieneMensaje(int MensajeTipo)
        {
            StringBuilder mensaje = new StringBuilder();

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select mensaje from  maestro_correoautomatico where codigo = " + MensajeTipo.ToString());
            foreach (DataRow rw in content.Rows)
            {
                mensaje.Append(rw[0].ToString());
            }

            return mensaje;

        }

        public string GuardaCotizacion(string _Nombre, string Apellidos, string _Correo, string _TipoDeVehiculo, string _Linea, string _Marca, string _Telefono, string _Modelo, decimal _SumaAsegurada, string _TipoSeguro, string Hora, string _CodigoEmpresa, string _ComoContactar, string prima, string _nacimiento, string _mensajetipo)
        {
            string id = "";
            string sql = " insert into trans_correosenviados(Nombre, Apellidos, Correo, TipoDeVehiculo, Linea, Marca, Telefono, Modelo, SumaAsegurada, TipoSeguro, contactar, CodigoEmpresa,ComoContactar, prima, nacimiento, mensajetipo)";
            sql += " values('" + _Nombre.Trim().Replace("-", "").Replace("'", "") + "','" + Apellidos.Trim().Replace("-", "").Replace("'", "") + "','" + _Correo.Replace("-", "").Replace("'", "") + "','" + _TipoDeVehiculo.Replace("-", "").Replace("'", "") + "','" + _Linea.Replace("-", "").Replace("'", "") + "','" + _Marca.Replace("-", "").Replace("'", "") + "','" + _Telefono.Replace("-", "").Replace("'", "") + "','" + _Modelo.Replace("-", "").Replace("'", "") + "'," + _SumaAsegurada.ToString() + ",'" + _TipoSeguro.Replace("-", "").Replace("'", "") + "','" + Hora.Replace("-", "").Replace("'", "") + "','" + _CodigoEmpresa.Replace("-", "").Replace("'", "") + "','" + _ComoContactar.Replace("-", "").Replace("'", "") + "', " + prima.Replace("-", "").Replace("'", "") + " ,'" + _nacimiento.Replace("-", "").Replace("'", "") + "', " + _mensajetipo.Replace("-", "").Replace("'", "") + " )";
            AccesoDatos.EjecutaQueryMySql(sql);
            id = AccesoDatos.RegresaCadena_1_ResultadoMysql("select max(indice) from trans_correosenviados where Nombre = '" + _Nombre.Trim() + "' and Apellidos = '" + Apellidos.Trim() + "'");
            return id;
        }
        public static decimal ObtienePorcentajeMenor(string Codigo)
        {
            decimal resultado = 0;

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select porcentaje_menor_100 from maestro_reglasnegocio where CodigoEmpresa = '" + Codigo + "'");
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = decimal.Parse(rw[0].ToString());
                }
            }

            return resultado;
        }
        public static decimal ObtieneMotoDañosATercerosBase(string Codigo)
        {
            decimal resultado = 0;

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select MotoDanosATercerosBase from maestro_reglasnegocio where CodigoEmpresa = '" + Codigo + "'");
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = decimal.Parse(rw[0].ToString());
                }
            }

            return resultado;
        }
 
         public static void LimpiarGraficas(string path)
        {
            path += @"\WebCharts";
            string[] fileEntries = Directory.GetFiles(path);
            try
            {
                foreach (string fileName in fileEntries)
                {
                    File.Delete(fileName);
                }
            }
            catch (System.Exception es)
            {
                Helper.RegistrarEvento(es.Message);
            }
 
        }
         public static void LimpiarDocumentos(string path)
         {
             path += @"\Documentos";
             string[] fileEntries = Directory.GetFiles(path);
             try
             {
                 foreach (string fileName in fileEntries)
                 {
                     File.Delete(fileName);
                 }
             }
             catch (System.Exception es)
             {
                 Helper.RegistrarEvento(es.Message);
             }

         }
        public static decimal ObtieneMotoPorcentaje_DeducibleDañosYAccidentes(string Codigo)
        {
            decimal resultado = 0;

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select MotoPorcentaje_DeducibleDañosYAccidentes from maestro_reglasnegocio where CodigoEmpresa = '" + Codigo + "'");
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = decimal.Parse(rw[0].ToString());
                }
            }

            return resultado;
        }


        public static decimal ObtieneMotoPorcentaje_DeducibleRobo(string Codigo)
        {
            decimal resultado = 0;

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select MotoPorcentaje_DeducibleRobo from maestro_reglasnegocio where CodigoEmpresa = '" + Codigo + "'");
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = decimal.Parse(rw[0].ToString());
                }
            }

            return resultado;
        }

        public static decimal ObtieneMotoPorcentaje_Cobro(string Codigo)
        {
            decimal resultado = 0;

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select MotoPorcentaje_Cobro from maestro_reglasnegocio where CodigoEmpresa = '" + Codigo + "'");
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = decimal.Parse(rw[0].ToString());
                }
            }

            return resultado;
        }

        public static decimal ObtieneMotoCobro_PorServicio(string Codigo)
        {
            decimal resultado = 0;

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select MotoCobro_PorServicio from maestro_reglasnegocio where CodigoEmpresa = '" + Codigo + "'");
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = decimal.Parse(rw[0].ToString());
                }
            }

            return resultado;
        }

        public static decimal ObtieneMotoPorcentaje_PorServicio(string Codigo)
        {
            decimal resultado = 0;

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select MotoPorcentaje_PorServicio from maestro_reglasnegocio where CodigoEmpresa = '" + Codigo + "'");
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = decimal.Parse(rw[0].ToString());
                }
            }

            return resultado;
        }

        public static decimal MotoSumaLimiteParaCalculo(string Codigo)
        {
            decimal resultado = 0;

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select MotoSumaLimiteParaCalculo from maestro_reglasnegocio where CodigoEmpresa = '" + Codigo + "'");
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = decimal.Parse(rw[0].ToString());
                }
            }

            return resultado;
        }

        public static decimal ObtienePorcentajeMayor(string Codigo)
        {
            decimal resultado = 0;

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select porcentaje_mayor_100 from maestro_reglasnegocio where CodigoEmpresa = '" + Codigo + "'");
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = decimal.Parse(rw[0].ToString());
                }
            }

            return resultado;
        }
        public static decimal ObtieneCosto(string Codigo)
        {
            decimal resultado = 0;

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select costo from maestro_reglasnegocio where CodigoEmpresa = '" + Codigo + "'");
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = decimal.Parse(rw[0].ToString());
                }
            }

            return resultado;
        }

        public static string ObtieneCorreoDeCierre(string _id)
        {
            string resultado = "";
            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select correocierre from  trans_correosenviados where indice = " + _id);
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = rw[0].ToString();
                }
            }

            return resultado;
        }

        public static int ObtieneEstadisticaPorMes(string _Mes, string _Empresa = "", string _year = "2016")
        {
            string resultado = "";
            DataTable content = new DataTable();
            if (_Empresa == "")
            {
                content = AccesoDatos.RegresaTablaMySql("Select count(*)  from trans_correosenviados where  year(Fecha) = "+ _year +"  and  month(Fecha)  = " + _Mes);
            }
            else
            {
                content = AccesoDatos.RegresaTablaMySql("Select count(*)  from trans_correosenviados where year(Fecha) =   " + _year + " and month(Fecha)  = " + _Mes + " and CodigoEmpresa = '" + _Empresa + "'");
            }

            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = rw[0].ToString();
                }
            }

            return int.Parse(resultado);
        }

        public static int ObtieneEstadisticaPorMesAbandonados(string _Mes, string _Empresa = "", string _year = "2016")
        {
            string resultado = "";
            string sql = "";

            DataTable content = new DataTable();
            if (_Empresa == "")
            {
                sql = "Select count(*)  from trans_correosenviados where ifnull(abandono,'') != '' and  ifnull(Paso3,0) != 0 and   year(FechaInicio) = " + _year + "  and  month(FechaInicio)  = " + _Mes ;
                content = AccesoDatos.RegresaTablaMySql(sql);
            }
            else
            {
                sql = "Select count(*)  from trans_correosenviados where ifnull(abandono,'') != '' and  ifnull(Paso3,0) != 0 and  year(FechaInicio) =   " + _year + " and month(FechaInicio)  = " + _Mes + " and CodigoEmpresa = '" + _Empresa + "'";
                content = AccesoDatos.RegresaTablaMySql(sql);
            }

            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = rw[0].ToString();
                }
            }

            return int.Parse(resultado);
        }
        public static int ObtieneEstadisticaPorMesReales(string _Mes, string _Empresa = "", string _year = "2016")
        {
            string resultado = "";
            DataTable content = new DataTable();
            if (_Empresa == "")
            {
                content = AccesoDatos.RegresaTablaMySql("Select count(*)  from trans_correosenviados where ifnull(abandono,'') = '' and  ifnull(Paso3,0) != 0 and   year(FechaInicio) = " + _year + "  and  month(FechaInicio)  = " + _Mes);
            }
            else
            {
                content = AccesoDatos.RegresaTablaMySql("Select count(*)  from trans_correosenviados where ifnull(abandono,'') = '' and  ifnull(Paso3,0) != 0 and  year(FechaInicio) =   " + _year + " and month(FechaInicio)  = " + _Mes + " and CodigoEmpresa = '" + _Empresa + "'");
            }

            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = rw[0].ToString();
                }
            }

            return int.Parse(resultado);
        }

        public static string ObtieneEstadisticaPorRangoDeFecha(string _Mes, string _FechaIni, string _FechaFin, string _Empresa = "")
        {
            string resultado = "";
            DataTable content = new DataTable();
            if (_Empresa == "")
            {
                content = AccesoDatos.RegresaTablaMySql("Select count(*)  from trans_correosenviados where Fecha between '" + _FechaIni + "' and '" + _FechaFin + "' and month(Fecha)  = " + _Mes);
            }
            else
            {
                content = AccesoDatos.RegresaTablaMySql("Select count(*)  from trans_correosenviados where  Fecha between '" + _FechaIni + "' and '" + _FechaFin + "'  and month(Fecha)  = " + _Mes + " and CodigoEmpresa = '" + _Empresa + "'");
            }

            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = rw[0].ToString();
                }
            }

            return resultado;
        }

        public static decimal ObtieneBase(string Codigo)
        {
            decimal resultado = 0;

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select base from maestro_reglasnegocio where CodigoEmpresa = '" + Codigo + "'");
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = decimal.Parse(rw[0].ToString());
                }
            }

            return resultado;
        }
        public static decimal ObtieneLimiteDeSeguros(string Codigo)
        {
            decimal resultado = 0;

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select suma_asegurada_limite from maestro_reglasnegocio where CodigoEmpresa = '" + Codigo + "'");
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = decimal.Parse(rw[0].ToString());
                }
            }

            return resultado;
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public static decimal ObtieneElecacionDeCoberturaRC(string Codigo)
        {
            decimal resultado = 0;

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select Exceso_RC_ElevacionDeCobertura from maestro_reglasnegocio where CodigoEmpresa = '" + Codigo + "'");
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = decimal.Parse(rw[0].ToString());
                }
            }

            return resultado;
        }
        public static decimal ObtienePorcentajeResponsabilidadCivil(string Codigo)
        {
            decimal resultado = 0;

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select PorcentajeResponsabilidadCivil from maestro_reglasnegocio where CodigoEmpresa = '" + Codigo + "'");
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = decimal.Parse(rw[0].ToString());
                }
            }

            return resultado;
        }


        public static decimal ObtienePrimaNetaRC(string Codigo)
        {
            decimal resultado = 0;

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select PrimaNetaRC from maestro_reglasnegocio where CodigoEmpresa = '" + Codigo + "'");
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = decimal.Parse(rw[0].ToString());
                }
            }

            return resultado;
        }
        //_Pickup
        public static decimal ObtienePrimaNetaRC_Pickup(string Codigo)
        {
            decimal resultado = 0;

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select PrimaNetaPickUpRC from maestro_reglasnegocio where CodigoEmpresa = '" + Codigo + "'");
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = decimal.Parse(rw[0].ToString());
                }
            }

            return resultado;
        }
        public static decimal ObtienePrimaNetaRC_Moto(string Codigo)
        {
            decimal resultado = 0;

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select PrimaNetaMotoRC from maestro_reglasnegocio where CodigoEmpresa = '" + Codigo + "'");
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = decimal.Parse(rw[0].ToString());
                }
            }

            return resultado;
        }

        public static void ActualizaPaso1(string _id)
        {
            string sql = "update trans_correosenviados  set Paso1 = 1 where indice = " + _id;
            AccesoDatos.EjecutaQueryMySql(sql);
        }
        public static void CierrePorAbandono(string _id, string _motivo)
        {
            string fecha = System.DateTime.Now.ToString();
            string verifica = AccesoDatos.RegresaCadena_1_ResultadoMysql("Select count(*) from trans_correosenviados where indice =" + _id + " and Paso3 = 1");
            _motivo += " " + fecha;
            if (verifica != "0")
            { }
            else
            {
                string sql = "update trans_correosenviados set abandono ='" + _motivo + "', Paso3 = 1, FechaInicio = curdate() where indice = " + _id;
                AccesoDatos.EjecutaQueryMySql(sql);
            }
        }

        public static void ActualizaPaso2(string _id)
        {
            string sql = "update trans_correosenviados  set Paso2 = 1 where indice = " + _id;
            AccesoDatos.EjecutaQueryMySql(sql);
        }
        public static void ActualizaPaso3(string _id)
        {
            string sql = "update trans_correosenviados  set Paso3 = 1 where indice = " + _id;
            AccesoDatos.EjecutaQueryMySql(sql);
        }
        public static void Actualiza3Paso(string _id, string _nit, string _dpi, string _direccion, string _zona, string _municipio, string numero_pasaporte)
        {
            string sql = "update trans_correosenviados  set nit = '" + _nit + "', dpi = '" + _dpi + "', direccion = '" + _direccion + "', zona = '" + _zona + "', municipio = '" + _municipio + "', FechaInicio = curdate() , passaporte = '" + numero_pasaporte + "'  where indice = " + _id;
            AccesoDatos.EjecutaQueryMySql(sql);

        }
        public static void ActualizaPrima(string _id, string _prima)
        {
            string sql = "update trans_correosenviados  set prima = " + _prima + "  where indice = " + _id;
            AccesoDatos.EjecutaQueryMySql(sql);

        }

        public static bool VerificaExistenciaDato3Paso(string _id)
        {
            string sql = "Select count(*) from trans_correosenviados where indice = " + _id + " and ifnull(dpi,'') = ''";
            string verifica = AccesoDatos.RegresaCadena_1_ResultadoMysql(sql);

            if (verifica != "0")
            {
                return false;
            }
            else { return true; }

        }

        public static string GuardaCodigo(string _id)
        {
            string resultado = "";
            string sql = "call Generacodigo()";
            resultado = AccesoDatos.RegresaCadena_1_ResultadoMysql(sql);

            sql = "update trans_correosenviados  set ingreso = '" + resultado + "' where indice = " + _id;
            AccesoDatos.EjecutaQueryMySql(sql);
            return resultado;

        }
        public static string ObtieneCodigo(string _id)
        {
            string resultado = "";

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select ingreso  from trans_correosenviados where indice = " + _id);
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = rw[0].ToString();
                    break;
                }
            }

            return resultado;
        }

        public static List<string> Autocomplete(string _nombre)
        {
            List<string> retorna = new List<string>();
            string linea = "";
            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select concat(Apellidos , ',' , Nombre , '/ ' , TipoDeVehiculo , ' ' , Marca , ' Modelo=', Modelo, ' Fecha Solicitud: ' , Fecha) as Nombre, indice as id  from trans_correosenviados where concat(Apellidos, ' ', Nombre) like '%" + _nombre + "%' or  concat(Nombre, ' ', Apellidos) like '%" + _nombre + "%' group by concat(Apellidos , ',' , Nombre , '/ ' , TipoDeVehiculo , ' ' , Marca , ' Modelo=', Modelo, ' Fecha Solicitud: ' , Fecha)  order by concat(Apellidos, ',', Nombre), Fecha desc");
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                linea = rw[0] + " >" + rw[1];
                retorna.Add(linea);
            }
            return retorna;
        }

        public static DataTable Datos(string _indice)
        {
            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select * from trans_correosenviados where indice = " + _indice);
            return content;
        }

        public static DataTable Cotizacion(string _id)
        {
            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select  tv.indice as moto, ce.CodigoEmpresa, ce.SumaAsegurada, Concat( ce.Nombre , ' ' , ce.Apellidos) as NombreCliente , Concat(ce.TipoDeVehiculo , ' ' , ce.Marca , ' ' , ce.Modelo , ' ' ,  ce.Linea) as DescripcionVehiculo, ce.TipoSeguro, ce.TipoDeVehiculo, ce.mensajetipo from  trans_correosenviados ce, tipodevehiculo tv where ce.TipoDeVehiculo =  tv.Descripcion and ce.indice =  " + _id);
            DataView dv = new DataView(content);
            return content;
        }


        public static decimal ObtieneExcesoRC_Base(string Codigo)
        {
            decimal resultado = 0;

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select Exceso_RC_Base from maestro_reglasnegocio where CodigoEmpresa = '" + Codigo + "'");
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = decimal.Parse(rw[0].ToString());
                }
            }

            return resultado;
        }
        public static decimal ObtieneValor_RoboParcial(string Codigo)
        {
            decimal resultado = 0;

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select robo_parcial from maestro_reglasnegocio where CodigoEmpresa = '" + Codigo + "'");
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = decimal.Parse(rw[0].ToString());
                }
            }

            return resultado;
        }
        public static decimal ObtieneValor_Menores_desde_16(string Codigo)
        {
            decimal resultado = 0;

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select Menores_desde_16 from maestro_reglasnegocio where CodigoEmpresa = '" + Codigo + "'");
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = decimal.Parse(rw[0].ToString());
                }
            }

            return resultado;
        }
        public static decimal ObtieneValor_Menores_desde_18(string Codigo)
        {
            decimal resultado = 0;

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select Menores_desde_18 from maestro_reglasnegocio where CodigoEmpresa = '" + Codigo + "'");
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = decimal.Parse(rw[0].ToString());
                }
            }

            return resultado;
        }
        public static decimal ObtieneValor_Exceso_RC(string Codigo)
        {
            decimal resultado = 0;

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select Exceso_RC from maestro_reglasnegocio where CodigoEmpresa = '" + Codigo + "'");
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = decimal.Parse(rw[0].ToString());
                }
            }

            return resultado;
        }
        public static decimal ObtieneValor_GastosEmision(string Codigo)
        {
            decimal resultado = 0;

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select gastos_emision from maestro_reglasnegocio where CodigoEmpresa = '" + Codigo + "'");
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = decimal.Parse(rw[0].ToString());
                }
            }

            return resultado;
        }
        public static decimal ObtieneValor_Mensualidades(string Codigo)
        {
            decimal resultado = 0;

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select mensualidades from maestro_reglasnegocio where CodigoEmpresa = '" + Codigo + "'");
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = decimal.Parse(rw[0].ToString());
                }
            }

            return resultado;
        }
        public static decimal ObtieneValor_deducible_parcial(string Codigo)
        {
            decimal resultado = 0;

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select deducible_parcial from maestro_reglasnegocio where CodigoEmpresa = '" + Codigo + "'");
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = decimal.Parse(rw[0].ToString());
                }
            }

            return resultado;
        }

        public static decimal ObtieneValor_deducible_robo_total(string _id, decimal _SumaAsegurada, string CodigoEmpresa)
        {
            decimal resultado = 0;
            string año_evaluado = AccesoDatos.RegresaCadena_1_ResultadoMysql("Select Modelo from trans_correosenviados where indice = " + _id);
            string marca = AccesoDatos.RegresaCadena_1_ResultadoMysql("Select Marca from trans_correosenviados where indice = " + _id);
            string linea = AccesoDatos.RegresaCadena_1_ResultadoMysql("Select Linea from trans_correosenviados where indice = " + _id);
            string tipovehiculo = AccesoDatos.RegresaCadena_1_ResultadoMysql("Select TipoDeVehiculo from trans_correosenviados where indice = " + _id);
            string codigo_marca = AccesoDatos.RegresaCadena_1_ResultadoMysql("Select indice from marca where descripcion = '" + marca + "'");
            decimal porcentaje_general = Decimal.Parse( AccesoDatos.RegresaCadena_1_ResultadoMysql("Select  deducible_parcial  from maestro_reglasnegocio where CodigoEmpresa= '"+ CodigoEmpresa  +"'"));
            string año = "";
            string MayorMenor = "";
            decimal Porcentaje = 0;
            string _tipo_vehiculo = "";

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select Año, MayorMenor, Porcentaje, TipoVehiculo from maestro_reglasdevehiculos where Marca = '" + codigo_marca + "' and upper(linea) = upper('" + linea + "')");

            foreach (DataRow rw in content.Rows)
            {
                 año = rw["Año"].ToString();
                 MayorMenor = rw["MayorMenor"].ToString();
                 Porcentaje = decimal.Parse(rw["Porcentaje"].ToString());
                 _tipo_vehiculo = rw["TipoVehiculo"].ToString();
                 break;
            }
            if (content.Rows.Count > 0)
            {

                if (MayorMenor == ">")
                {
                    if (Decimal.Parse(año_evaluado) > Decimal.Parse(año) || Decimal.Parse(año) == 0 )
                    {
                        resultado = (_SumaAsegurada * Porcentaje)/100 ;
                    }
                }

                if (MayorMenor == "*")
                {
  
                        resultado = (_SumaAsegurada * Porcentaje)/100;
    
                }

            }

            string vehiculo = ConfigurationManager.AppSettings["VehiculoExcluido"].ToString();
            DataTable Tipo = new DataTable();
            Tipo = AccesoDatos.RegresaTablaMySql("Select  Porcentaje from maestro_reglasdevehiculos where Marca = '" + codigo_marca + "' and TipoVehiculo = '" + vehiculo + "'");
            if (Tipo.Rows.Count > 0)
            {
                foreach (DataRow rw in Tipo.Rows)
                {
                    Porcentaje = decimal.Parse(rw["Porcentaje"].ToString());
                    break;
                }
                 resultado = _SumaAsegurada * Porcentaje / 100;
            }

            if (resultado == 0)
            { resultado = _SumaAsegurada * porcentaje_general; }

            return resultado;
        }

        public static decimal ObtieneValor_Asisto(string Codigo)
        {
            decimal resultado = 0;

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select asisto from maestro_reglasnegocio where CodigoEmpresa = '" + Codigo + "'");
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = decimal.Parse(rw[0].ToString());
                }
            }

            return resultado;
        }
        public static decimal ObtieneIva(string Codigo)
        {
            decimal resultado = 0;

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select iva from maestro_reglasnegocio where CodigoEmpresa = '" + Codigo + "'");
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = decimal.Parse(rw[0].ToString());
                }
            }

            return resultado;
        }

        public static List<Impresion> ReporteFormato1()
        {
            List<Impresion> data = new List<Impresion>();
            Impresion lista = new Impresion();
            data.Add(lista);

            return data;

        }

        public static string StatusDescripcionPaso1(string _id)
        {

            string resultado = "";

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("select case when ifnull(Paso1,0) = 0 then 'Paso1' else   'Paso11'   end from trans_correosenviados where indice = " + _id);
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = rw[0].ToString();
                }
            }

            return resultado;
        }
        public static string CorreoCliente(string _id)
        {
            string resultado = "";

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("select correo from trans_correosenviados where indice = " + _id);
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = rw[0].ToString();
                    break;
                }
            }

            return resultado;
        }
        public static string CodigoEmpresaCliente(string _id)
        {
            string resultado = "";

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("select CodigoEmpresa from trans_correosenviados where indice = " + _id);
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = rw[0].ToString();
                    break;
                }
            }

            return resultado;
        }
        public static string TelefonoCliente(string _id)
        {
            string resultado = "";

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("select Telefono from trans_correosenviados where indice = " + _id);
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = rw[0].ToString();
                    break;
                }
            }

            return resultado;
        }

        public static bool RestringirCorreoAvisoCliente(string _id)
        {
            bool resultado = false;

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("select status from trans_correosenviados where indice = " + _id);
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = bool.Parse(rw[0].ToString());
                    break;
                }
            }

            return resultado;
        }

        public static string NombreCliente(string _id)
        {
            string resultado = "";

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("select Nombre from trans_correosenviados where indice = " + _id);
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = rw[0].ToString();
                    break;
                }
            }

            return resultado;
        }
        public static string ApellidosCliente(string _id)
        {
            string resultado = "";

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("select Apellidos from trans_correosenviados where indice = " + _id);
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = rw[0].ToString();
                    break;
                }
            }

            return resultado;
        }
        public static string MensajesAutomaticos(string _codigo)
        {
            string resultado = "";

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("select mensaje from maestro_correoautomatico where codigo = '" + _codigo + "'");
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = rw[0].ToString();
                    break;
                }
            }

            return resultado;
        }
        public static string StatusDescripcionPaso2(string _id)
        {
            string resultado = "";

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("select case when ifnull(Paso2,0) = 0 then 'Paso2' else   'Paso22'   end from trans_correosenviados where indice = " + _id);
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = rw[0].ToString();
                }
            }

            return resultado;
        }
        public static string StatusDescripcionPaso3(string _id)
        {
            string resultado = "";

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("select case when ifnull(Paso3,0) = 0 then 'Paso3' else   'Paso33'   end from trans_correosenviados where indice = " + _id);
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = rw[0].ToString();
                }
            }

            return resultado;
        }
        public static string StatusDescripcionPaso4(string _id)
        {
            string resultado = "";

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("select case when ifnull(Paso3,0) = 0 then 'Paso4' else   'Paso44'   end from trans_correosenviados where indice = " + _id);
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = rw[0].ToString();
                }
            }

            return resultado;
        }
        public static string LinkPaso1(string _CodigoEmpresa, string _id)
        {
            string resultado = "";
            string descripcion = StatusDescripcionPaso1(_id);

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select Link from maestro_link_externo where CodigoEmpresa = '" + _CodigoEmpresa + "' and Descripcion = '" + descripcion + "'");
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = rw[0].ToString();
                }
            }

            return resultado;
        }

        public static string LinkPaso2(string _CodigoEmpresa, string _id)
        {
            string resultado = "";
            string descripcion = StatusDescripcionPaso2(_id);

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select Link from maestro_link_externo where CodigoEmpresa = '" + _CodigoEmpresa + "' and Descripcion = '" + descripcion + "'");
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = rw[0].ToString();
                }
            }

            return resultado;
        }
        public static string LinkPaso3(string _CodigoEmpresa, string _id)
        {
            string resultado = "";
            string descripcion = StatusDescripcionPaso3(_id);

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select Link from maestro_link_externo where CodigoEmpresa = '" + _CodigoEmpresa + "' and Descripcion = '" + descripcion + "'");
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = rw[0].ToString();
                }
            }

            return resultado;
        }
        public static string LinkPaso4(string _CodigoEmpresa, string _id)
        {
            string resultado = "";
            string descripcion = StatusDescripcionPaso4(_id);

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select Link from maestro_link_externo where CodigoEmpresa = '" + _CodigoEmpresa + "' and Descripcion = '" + descripcion + "'");
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = rw[0].ToString();
                }
            }

            return resultado;
        }


        public static string LinkUbicaciones(string _CodigoEmpresa, string _Descripcion)
        {
            string resultado = "";

            DataTable content = new DataTable();
            content = AccesoDatos.RegresaTablaMySql("Select Link from maestro_link_externo where CodigoEmpresa = '" + _CodigoEmpresa + "' and Descripcion = '" + _Descripcion + "'");
            DataView dv = new DataView(content);
            foreach (DataRow rw in content.Rows)
            {
                if (rw[0].ToString() != null && rw[0].ToString().Trim() != "")
                {
                    resultado = rw[0].ToString();
                }
            }

            return resultado;
        }


    }

    public class Valores
    {
        public decimal SumaAsegurada = 0;
        public string Codigo = "";
        public decimal PrimaNeta = 0;
        public decimal PrimaNetaProRata = 0;
        public decimal MontoBase = 0;
        public decimal SumaLimiteParaCalculo = 0;
        public decimal Porcentaje_Menor_100 = 0;
        public decimal Porcentaje_Mayor_100 = 0;
        public decimal Costo = 0;
        public decimal RoboParcial = 0;
        public decimal MenoresDesde16 = 0;
        public decimal MenoresDesde18 = 0;
        public decimal ExcesoRC = 0;
        public decimal GastosPorEmision = 0;
        public decimal PorcenajeGastosPorEmision = 0;
        public decimal GastosPorEmisionProRata = 0;
        public decimal PrimaNetaPickUpRC = 0;
        public decimal Asisto = 0;
        public decimal Iva = 0;
        public decimal IvaProRata = 0;
        public decimal CoberturaAdicional = 0;
        public decimal PrimaTotal = 0;
        public decimal PrimaTotalProRata = 0;
        public decimal CalculoIva = 0;
        public int DiasAnuales = 0;
        public int DiasTotales = 0;
        public decimal CadaPago = 0;
        public decimal Exceso_RC_ElevacionDeCobertura = 0;
        public decimal Exceso_RC_Base = 0;
        public decimal DañosATerceros = 0;
        public decimal PorcentajeResponsabilidadCivil = 0;
        public decimal MotoDeduciblesPorDañosyAccidentes = 0;
        public decimal MotoDeducibles_Robo = 0;
        public decimal PrimaNetaMotoRC = 0;
        public decimal deducible_parcial = 0;
        public decimal deducible_robo_total = 0;
        /// <summary>
        /// Ejecuta los valores de las formulas de acuerdo a la empresa para el calculo de la cotización.
        /// </summary>
        /// <param name="_Codigo"></param>
        /// <param name="_SumaAsegurada"></param>
        /// <param name="_roboParcial"></param>
        /// <param name="_MenoresDesde16"></param>
        /// <param name="_MenoresDesde18"></param>
        /// <param name="_ExcesoRC"></param>
        /// <param name="_RoboParcial"></param>
        /// <param name="MensajeTipo"></param>
        public Valores(string _Codigo, decimal _SumaAsegurada, bool _roboParcial, bool _MenoresDesde16, bool _MenoresDesde18, bool _ExcesoRC, decimal _RoboTotal, int MensajeTipo)
        {
            decimal equipo_especial = 0;
            decimal cien = 100;
            decimal mil = 1000;
            decimal docientoscincuenta = 250;
            decimal PrimaNetaRC = Cotizadores.ObtienePrimaNetaRC(_Codigo);
            PrimaNetaPickUpRC = Cotizadores.ObtienePrimaNetaRC_Pickup(_Codigo);
            PrimaNetaMotoRC = Cotizadores.ObtienePrimaNetaRC_Moto(_Codigo);
            decimal MotoDañosATerceros = Cotizadores.ObtieneMotoDañosATercerosBase(_Codigo);
            decimal MotoPorcentaje_DeducibleDañosYAccidentes = Cotizadores.ObtieneMotoPorcentaje_DeducibleDañosYAccidentes(_Codigo);
            decimal MotoSumaLimiteParaCalculo = Cotizadores.MotoSumaLimiteParaCalculo(_Codigo);
            decimal MotoPorcentaje_DeducibleRobo = Cotizadores.ObtieneMotoPorcentaje_DeducibleRobo(_Codigo);
            decimal MotoPorcentaje_Cobro = Cotizadores.ObtieneMotoPorcentaje_Cobro(_Codigo);
            decimal MotoCobro_PorServicio = Cotizadores.ObtieneMotoCobro_PorServicio(_Codigo);
            decimal MotoPorcentaje_PorServicio = Cotizadores.ObtieneMotoPorcentaje_PorServicio(_Codigo);
            decimal emision = 0;
            decimal PorcenajeGastosPorEmision = Cotizadores.ObtieneValor_GastosEmision(_Codigo);
            decimal Mensualidades = Cotizadores.ObtieneValor_Mensualidades(_Codigo);

            deducible_parcial = Cotizadores.ObtieneValor_deducible_parcial(_Codigo);
            deducible_parcial = _SumaAsegurada * deducible_parcial;
            deducible_robo_total = _RoboTotal;

            Codigo = _Codigo;
            SumaAsegurada = _SumaAsegurada;
            Exceso_RC_ElevacionDeCobertura = Cotizadores.ObtieneElecacionDeCoberturaRC(_Codigo);
            Exceso_RC_Base = Cotizadores.ObtieneExcesoRC_Base(_Codigo);
            MontoBase = Cotizadores.ObtieneBase(_Codigo);
            SumaLimiteParaCalculo = Cotizadores.ObtieneLimiteDeSeguros(_Codigo);
            Porcentaje_Menor_100 = Cotizadores.ObtienePorcentajeMenor(_Codigo);
            Porcentaje_Mayor_100 = Cotizadores.ObtienePorcentajeMayor(_Codigo);
            Costo = Cotizadores.ObtieneCosto(_Codigo);
            RoboParcial = 0;
            MenoresDesde16 = 0;
            MenoresDesde18 = 0;
            ExcesoRC = Cotizadores.ObtieneValor_Exceso_RC(_Codigo);
            Asisto = Cotizadores.ObtieneValor_Asisto(_Codigo);
            CalculoIva = Cotizadores.ObtieneIva(_Codigo);
            System.DateTime olddate = System.DateTime.Today;
            System.DateTime newDate = new System.DateTime(olddate.Year, olddate.Month, 1, 0, 0, 0, olddate.Kind);
            System.DateTime nextyear = newDate.AddYears(1);
            DiasAnuales = int.Parse((newDate - nextyear).TotalDays.ToString()) * -1;
            DiasTotales = int.Parse((nextyear - olddate).TotalDays.ToString());
            DañosATerceros = Exceso_RC_Base;
            PorcentajeResponsabilidadCivil = Cotizadores.ObtienePorcentajeResponsabilidadCivil(_Codigo);

            if (MensajeTipo == 1)
            {
                if (SumaAsegurada < SumaLimiteParaCalculo)
                {
                    if (((SumaAsegurada * Porcentaje_Menor_100 / 100) + Costo + Asisto) < MontoBase)
                    {
                        PrimaNeta = MontoBase + Costo ;
                        GastosPorEmision = PrimaNeta * PorcenajeGastosPorEmision;
                        PrimaNeta = PrimaNeta + GastosPorEmision + Asisto;
                        Iva = PrimaNeta * CalculoIva;
                        PrimaNeta = (PrimaNeta + Iva);
                        //=SI((B6*0.025+500)<1000,1000,(B6*0.025+500))+D5
                    }
                    else
                    {
                        PrimaNeta = ((SumaAsegurada * Porcentaje_Menor_100 / 100) + Costo );
                        GastosPorEmision = PrimaNeta * PorcenajeGastosPorEmision;
                        PrimaNeta = PrimaNeta + GastosPorEmision + Asisto;
                        Iva = PrimaNeta * CalculoIva;
                        PrimaNeta = (PrimaNeta + Iva);
                        //=SI((B6*0.02+500)<1000,1000,(B6*0.02+500))+D5
                    }

                }

                if (SumaAsegurada >= SumaLimiteParaCalculo)
                {
                    if (((SumaAsegurada * Porcentaje_Mayor_100 / 100) + Costo + Asisto) < MontoBase)
                    {
                        PrimaNeta = MontoBase + Costo + Asisto;
                        //GastosPorEmision = PrimaNeta * PorcenajeGastosPorEmision;
                        GastosPorEmision = Costo + Asisto;
                        Iva = PrimaNeta * CalculoIva;
                        PrimaNeta = (PrimaNeta + Iva);
                        //=SI((B6*0.025+500)<1000,1000,(B6*0.025+500))+D5

                    }
                    else
                    {
                        PrimaNeta = ((SumaAsegurada * Porcentaje_Mayor_100 / 100) + Costo + Asisto);
                        GastosPorEmision = Costo + Asisto;
                        Iva = PrimaNeta * CalculoIva;
                        PrimaNeta = (PrimaNeta + Iva);
                        //=SI((B6*0.02+500)<1000,1000,(B6*0.02+500))+D5
                    }

                }

            }

            if (MensajeTipo == 2)
            {
                emision = (PrimaNetaRC * PorcentajeResponsabilidadCivil) / 100;
                PrimaNeta = PrimaNetaRC + emision + Asisto;
                Iva = PrimaNeta * CalculoIva;
                PrimaNeta = PrimaNeta + Iva;

                // Le agregas 5% de emisión + 145.45 de asisto+12% de iva en ese orden  
            }

            if (MensajeTipo == 3)
            {
                emision = (PrimaNetaPickUpRC * PorcentajeResponsabilidadCivil) / 100;
                PrimaNeta = PrimaNetaPickUpRC + emision + Asisto;
                Iva = PrimaNeta * CalculoIva;
                PrimaNeta = PrimaNeta + Iva;


                // Le agregas 5% de emisión + 145.45 de asisto+12% de iva en ese orden  
            }


            if (MensajeTipo == 7)
            {
                if (((SumaAsegurada * MotoPorcentaje_PorServicio) / 100) + MotoCobro_PorServicio < MotoSumaLimiteParaCalculo)
                {

                    emision = (MotoSumaLimiteParaCalculo * MotoPorcentaje_PorServicio) / 100;
                    PrimaNeta = MotoSumaLimiteParaCalculo + emision + MotoCobro_PorServicio;
                    Iva = PrimaNeta * CalculoIva;
                    PrimaNeta = PrimaNeta + Iva;

                }
                else
                {

                    PrimaNeta = ((SumaAsegurada * MotoPorcentaje_PorServicio) / 100) + MotoCobro_PorServicio;
                    Iva = PrimaNeta * CalculoIva;
                    PrimaNeta = PrimaNeta + Iva;

                }

            }

            if (MensajeTipo == 8)
            {
                emision = (PrimaNetaMotoRC * PorcentajeResponsabilidadCivil) / 100;
                PrimaNeta = PrimaNetaMotoRC + emision + Asisto;
                Iva = PrimaNeta * CalculoIva;
                PrimaNeta = PrimaNeta + Iva;

            }



            //if (_roboParcial)
            //{
            //    equipo_especial = SumaAsegurada * (cien) / (mil);
            //    if (_RoboParcial > equipo_especial)
            //    {
            //        RoboParcial = equipo_especial * (cien) / (mil);
            //    }
            //    else
            //    {
            //        RoboParcial = _RoboParcial * (cien) / (mil);
            //    }

            //    CoberturaAdicional += RoboParcial;

            //}
            //else
            //{
            //    equipo_especial = SumaAsegurada * (cien) / (mil);
            //    if (_RoboParcial > equipo_especial)
            //    {
            //        RoboParcial = equipo_especial * (cien) / (mil);
            //    }
            //    else
            //    {
            //        RoboParcial = _RoboParcial * (cien) / (mil);
            //    }
            //}


            if (_MenoresDesde16)
            {
                MenoresDesde16 = PrimaNeta * (docientoscincuenta) / (mil);
                CoberturaAdicional += MenoresDesde16;
            }
            else { MenoresDesde16 = PrimaNeta * (docientoscincuenta) / (mil); }

            if (_MenoresDesde18)
            {
                MenoresDesde18 = PrimaNeta * (docientoscincuenta) / (mil);
                CoberturaAdicional += MenoresDesde18;
            }
            else
            {
                MenoresDesde18 = PrimaNeta * (docientoscincuenta) / (mil);
            }


            if (_ExcesoRC)
            {
                if (_MenoresDesde16 == true || _MenoresDesde18 == true)
                {
                    ExcesoRC += PrimaNeta * (docientoscincuenta) / (mil);
                }

                DañosATerceros += Exceso_RC_ElevacionDeCobertura;
                CoberturaAdicional += ExcesoRC;
            }


            IvaProRata = CoberturaAdicional * CalculoIva;
            Iva += IvaProRata;
            CoberturaAdicional += IvaProRata;

            PrimaTotal = CoberturaAdicional + PrimaNeta;
            PrimaTotalProRata = PrimaTotal;
            PrimaNetaProRata = PrimaNeta;
            GastosPorEmisionProRata = GastosPorEmision;

            Iva = decimal.Parse(Iva.ToString("F", CultureInfo.InvariantCulture));
            IvaProRata = decimal.Parse(IvaProRata.ToString("F", CultureInfo.InvariantCulture));
            PrimaNetaProRata = decimal.Parse(PrimaNetaProRata.ToString("F", CultureInfo.InvariantCulture));
            PrimaTotal = decimal.Parse(PrimaTotal.ToString("F", CultureInfo.InvariantCulture));
            PrimaTotalProRata = decimal.Parse(PrimaTotalProRata.ToString("F", CultureInfo.InvariantCulture));
            GastosPorEmisionProRata = decimal.Parse(GastosPorEmisionProRata.ToString("F", CultureInfo.InvariantCulture));
            CadaPago = decimal.Parse((PrimaTotalProRata / Mensualidades).ToString("F", CultureInfo.InvariantCulture));
            RoboParcial = decimal.Parse(RoboParcial.ToString("F", CultureInfo.InvariantCulture));
            MenoresDesde16 = decimal.Parse(MenoresDesde16.ToString("F", CultureInfo.InvariantCulture));
            MenoresDesde18 = decimal.Parse(MenoresDesde18.ToString("F", CultureInfo.InvariantCulture));
            ExcesoRC = decimal.Parse(ExcesoRC.ToString("F", CultureInfo.InvariantCulture));

        }

    }

    public class CorreosInternos
    {
        public string Correo = "";
        public CorreosInternos() { }
    }

    public class ImprimirFormato
    {
        public ImprimirFormato()
        { }
        private string _Nombre = "";
        public string Nombre
        {
            get { return _Nombre; }
            set { this._Nombre = value; }
        }
        private string _Apellidos = "";
        public string Apellidos
        {
            get { return _Apellidos; }
            set { this._Apellidos = value; }
        }
        private string _Correo = "";
        public string Correo
        {
            get { return _Correo; }
            set { this._Correo = value; }
        }

        private string _TipoDeVehiculo = "";
        public string TipoDeVehiculo
        {
            get { return _TipoDeVehiculo; }
            set { this._TipoDeVehiculo = value; }
        }
        private string _Linea = "";
        public string Linea
        {
            get { return _Linea; }
            set { this._Linea = value; }
        }
        private string _Marca = "";
        public string Marca
        {
            get { return _Marca; }
            set { this._Marca = value; }
        }
        private string _Telefono = "";
        public string Telefono
        {
            get { return _Telefono; }
            set { this._Telefono = value; }
        }

        private string _Modelo = "";
        public string Modelo
        {
            get { return _Modelo; }
            set { this._Modelo = value; }
        }

        private string _SumaAsegurada = "";
        public string SumaAsegurada
        {
            get { return _SumaAsegurada; }
            set { this._SumaAsegurada = value; }
        }
        private string _Fecha = "";
        public string Fecha
        {
            get { return _Fecha; }
            set { this._Fecha = value; }
        }
        private string _TipoSeguro = "";
        public string TipoSeguro
        {
            get { return _TipoSeguro; }
            set { this._TipoSeguro = value; }
        }
        private string _contactar = "";
        public string contactar
        {
            get { return _contactar; }
            set { this._contactar = value; }
        }
        private string _CodigoEmpresar = "";
        public string CodigoEmpresa
        {
            get { return _CodigoEmpresar; }
            set { this._CodigoEmpresar = value; }
        }
        private string _ComoContactar = "";
        public string ComoContactar
        {
            get { return _ComoContactar; }
            set { this._ComoContactar = value; }
        }
        private string _Paso1 = "";
        public string Paso1
        {
            get { return _Paso1; }
            set { this._Paso1 = value; }
        }

        private string _Paso2 = "";
        public string Paso2
        {
            get { return _Paso2; }
            set { this._Paso2 = value; }
        }

        private string _Paso3 = "";
        public string Paso3
        {
            get { return _Paso3; }
            set { this._Paso3 = value; }
        }
        private string _Nit = "";
        public string Nit
        {
            get { return _Nit; }
            set { this._Nit = value; }
        }
        private string _DPI = "";
        public string DPI
        {
            get { return _DPI; }
            set { this._DPI = value; }
        }
        private string _Direccion = "";
        public string Direccion
        {
            get { return _Direccion; }
            set { this._Direccion = value; }
        }
        private string _Zona = "";
        public string Zona
        {
            get { return _Zona; }
            set { this._Zona = value; }
        }
        private string _Municipio = "";
        public string Municipio
        {
            get { return _Municipio; }
            set { this._Municipio = value; }
        }
        private string _ingreso = "";
        public string ingreso
        {
            get { return _ingreso; }
            set { this._ingreso = value; }
        }
        private string _status = "";
        public string status
        {
            get { return _status; }
            set { this._status = value; }
        }

        private string _FechaInicio = "";
        public string FechaInicio
        {
            get { return _FechaInicio; }
            set { this._FechaInicio = value; }
        }

        private string _Prima = "";
        public string Prima
        {
            get { return _Prima; }
            set { this._Prima = value; }
        }

        private string _Pasaporte = "";
        public string Pasaporte
        {
            get { return _Pasaporte; }
            set { this._Pasaporte = value; }
        }
        private string _Nacimiento = "";
        public string Nacimiento
        {
            get { return _Nacimiento; }
            set { this._Nacimiento = value; }
        }
        private string _ApellidoP = "";
        public string ApellidoP
        {
            get { return _ApellidoP; }
            set { this._ApellidoP = value; }
        }
        private string _ApellidoS = "";
        public string ApellidoS
        {
            get { return _ApellidoS; }
            set { this._ApellidoS = value; }
        }
        private string _NombreP = "";
        public string NombreP
        {
            get { return _NombreP; }
            set { this._NombreP = value; }
        }
        private string _NombreS = "";
        public string NombreS
        {
            get { return _NombreS; }
            set { this._NombreS = value; }
        }
    }

    public class ImpresionEsadistico
    {

        public ImpresionEsadistico() { }

        public string _CodigoEmpresa = "";
        public string CodigoEmpresa
        {
            get { return _CodigoEmpresa; }
            set { this._CodigoEmpresa = value; }
        }
        public string _Cotizaciones = "";
        public string Cotizaciones
        {
            get { return _Cotizaciones; }
            set { this._Cotizaciones = value; }
        }
        public string _CierreReal = "";
        public string CierreReal
        {
            get { return _CierreReal; }
            set { this._CierreReal = value; }
        }
        public string _CierreAbandono = "";
        public string CierreAbandono
        {
            get { return _CierreAbandono; }
            set { this._CierreAbandono = value; }
        }
        public string _TransitoPendiente = "";
        public string TransitoPendiente
        {
            get { return _TransitoPendiente; }
            set { this._TransitoPendiente = value; }
        }
        public string _Rango = "";
        public string Rango
        {
            get { return _Rango; }
            set { this._Rango = value; }
        }


    }

    public class ImpresionAbandonos
    {
        public ImpresionAbandonos() { }

        public string _id = "";
        public string id
        {
            get { return _id; }
            set { this._id = value; }

        }
        public string _motivo = "";
        public string motivo
        {
            get { return _motivo; }
            set { this._motivo = value; }

        }
    }


    public class Impresion
    {

        public Impresion()
        {
        }
        private decimal _SumaAsegruada = 0;
        public decimal SumaAsegurada
        {
            get { return _SumaAsegruada; }
            set { this._SumaAsegruada = value; }
        }
        private string _Codigo = "";
        public string Codigo
        {
            get { return _Codigo; }
            set { this._Codigo = value; }
        }
        private decimal _PrimaNeta = 0;
        public decimal PrimaNeta
        {
            get { return _PrimaNeta; }
            set { this._PrimaNeta = value; }
        }
        private decimal _PrimaNetaProRata = 0;
        public decimal PrimaNetaProRata
        {
            get { return _PrimaNetaProRata; }
            set { this._PrimaNetaProRata = value; }
        }
        private decimal _MontoBase = 0;
        public decimal MontoBase
        {
            get { return _MontoBase; }
            set { this._MontoBase = value; }
        }
        private decimal _SumaLimitieParaCalculo = 0;
        public decimal SumaLimiteParaCalculo
        {
            get { return _SumaLimitieParaCalculo; }
            set { this._SumaLimitieParaCalculo = value; }
        }
        private decimal _Porcentaje_Menor_100 = 0;
        public decimal Porcentaje_Menor_100
        {
            get { return _Porcentaje_Menor_100; }
            set { this._Porcentaje_Menor_100 = value; }
        }
        private decimal _Porcentaje_Mayor_100 = 0;
        public decimal Porcentaje_Mayor_100
        {
            get { return _Porcentaje_Mayor_100; }
            set { this._Porcentaje_Mayor_100 = value; }
        }
        private decimal _Costo = 0;
        public decimal Costo
        {
            get { return _Costo; }
            set { this._Costo = value; }
        }
        private decimal _RoboParcial = 0;
        public decimal RoboParcial
        {
            get { return _RoboParcial; }
            set { this._RoboParcial = value; }
        }
        private decimal _MenoresDeEdad16 = 0;
        public decimal MenoresDesde16
        {
            get { return _MenoresDeEdad16; }
            set { this._MenoresDeEdad16 = value; }
        }
        private decimal _MenoresDesde18 = 0;
        public decimal MenoresDesde18
        {
            get { return _MenoresDesde18; }
            set { this._MenoresDesde18 = value; }
        }
        private decimal _ExcesoRC = 0;
        public decimal ExcesoRC
        {
            get { return _ExcesoRC; }
            set { this._ExcesoRC = value; }
        }
        private decimal _GastosPorEmision = 0;
        public decimal GastosPorEmision
        {
            get { return _GastosPorEmision; }
            set { this._GastosPorEmision = value; }
        }
        private decimal _GastosPorEmisionProRata = 0;
        public decimal GastosPorEmisionProRata
        {
            get { return _GastosPorEmisionProRata; }
            set { this._GastosPorEmisionProRata = value; }
        }
        private decimal _Asisto = 0;
        public decimal Asisto
        {
            get { return _Asisto; }
            set { this._Asisto = value; }
        }
        private decimal _Iva = 0;
        public decimal Iva
        {
            get { return _Iva; }
            set { this._Iva = value; }
        }
        private decimal _IvaProRata = 0;
        public decimal IvaProRata
        {
            get { return _IvaProRata; }
            set { this._IvaProRata = value; }
        }
        private decimal _CoberturaAdicional = 0;
        public decimal CoberturaAdicional
        {
            get { return _CoberturaAdicional; }
            set { this._CoberturaAdicional = value; }
        }
        private decimal _Primatotal = 0;
        public decimal PrimaTotal
        {
            get { return _Primatotal; }
            set { this._Primatotal = value; }
        }
        private decimal _PrimaTotalProRata = 0;
        public decimal PrimaTotalProRata
        {
            get { return _PrimaTotalProRata; }
            set { this._PrimaTotalProRata = value; }
        }
        private decimal _CalculoIva = 0;
        public decimal CalculoIva
        {
            get { return _CalculoIva; }
            set { this._CalculoIva = value; }
        }
        private decimal _DiasAnuales = 0;
        public decimal DiasAnuales
        {
            get { return _DiasAnuales; }
            set { this._DiasAnuales = value; }
        }
        private int _DiasTotales = 0;
        public int DiasTotales
        {
            get { return _DiasTotales; }
            set { this._DiasTotales = value; }
        }
        private decimal _CadaPago = 0;
        public decimal CadaPago
        {
            get { return _CadaPago; }
            set { this._CadaPago = value; }
        }
        private decimal _Exceso_RC_ElevacionDeCobertura = 0;
        public decimal Exceso_RC_ElevacionDeCobertura
        {
            get { return _Exceso_RC_ElevacionDeCobertura; }
            set { this._Exceso_RC_ElevacionDeCobertura = value; }
        }
        private decimal _Exceso_RC_Base = 0;
        public decimal Exceso_RC_Base
        {
            get { return _Exceso_RC_Base; }
            set { this._Exceso_RC_Base = value; }
        }
        private decimal _DañosATerceros = 0;
        public decimal DañosATerceros
        {
            get { return _DañosATerceros; }
            set { this._DañosATerceros = value; }
        }
        private string _NombreCliente = "";
        public string NombreCliente
        {
            get { return _NombreCliente; }
            set { this._NombreCliente = value; }
        }
        private string _NombreAgente = "";
        public string NombreAgente
        {
            get { return _NombreAgente; }
            set { this._NombreAgente = value; }
        }
        private string _DescripcionVehiculo = "";
        public string DescripcionVehiculo
        {
            get { return _DescripcionVehiculo; }
            set { this._DescripcionVehiculo = value; }
        }
        private decimal _MotoDeduciblePorDañosyAccidentes = 0;
        public decimal MotoDeduciblePorDañosyAccidentes
        {
            get { return _MotoDeduciblePorDañosyAccidentes; }
            set { this._MotoDeduciblePorDañosyAccidentes = value; }
        }
        private decimal _MotoDeducibleRobo = 0;
        public decimal MotoDeducibleRobo
        {
            get { return _MotoDeducibleRobo; }
            set { this._MotoDeducibleRobo = value; }
        }
        private decimal _DeduciblePerdidaParcial = 0;
        public decimal DeduciblePerdidaParcial
        {
            get { return _DeduciblePerdidaParcial; }
            set { this._DeduciblePerdidaParcial = value; }
        }
        private decimal _DeducibleRoboTotal = 0;
        public decimal DeducibleRoboTotal
        {
            get { return _DeducibleRoboTotal; }
            set { this._DeducibleRoboTotal = value; }
        }

    }

}

