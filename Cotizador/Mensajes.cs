using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;
using Microsoft.Reporting.WebForms;
using System.Web;
using System.IO;


namespace Cotizador
{
    public class Mensajes
    {
        public string Nombre = "";
        public string Correo = "";
        public string TipoDeVehiculo = "";
        public string Linea = "";
        public string Marca = "";
        public string Modelo = "";
        public string ValorMercado = "";
        public int MensajeTipo = 1;
        public string archivo = "";
        public string Paso1 = "";
        public string Paso2 = "";
        public string Paso3 = "";
        public string Link1 = "";
        public string Link2 = "";
        public string Link3 = "";
        public string valorprima = "";

        // This method will be called when the thread is started.
        public void DoWork()
        {

            Cotizadores Cotizar = new Cotizadores();
            Correo enviando = new Correo();
            StringBuilder msg = Cotizar.ObtieneMensaje(MensajeTipo);
            msg.Append("Valor Prima " + valorprima);
            msg.Append("Valor Prima " + valorprima);
            msg.Append(Environment.NewLine);
            msg.Append(Environment.NewLine);
            msg.Append("Atentamente,");
            msg.Append(Environment.NewLine);
            msg.Append("Departamento de Lineas Personales");

            string titulo = "Cotización de Seguro para " + TipoDeVehiculo + " " + Marca + " " + Modelo + " " + Linea;
            enviando.EnviarCorreo(Correo, msg, Nombre, MensajeTipo, archivo, titulo, Paso1, Paso2,Paso3, Link1, Link2, Link3);
            EnvioDeCorreoRapido.LimpiarArchivo(archivo);

        }
        public void RequestStop()
        {
            _shouldStop = true;
        }
        // Volatile is used as hint to the compiler that this data
        // member will be accessed by multiple threads.
        private volatile bool _shouldStop;
    }

    public class EnvioDeCorreoRapido
    {

        public static void EjecutarProceso(string Correo, string TipoDeVehiculo, string Linea, string Marca, string Modelo, string ValorMercado, int MensajeTipo, string Nombre, string CodigoEmpresa,bool RoboParcial,bool Menores16,bool Menores18,bool ExcesosRC,decimal _RoboParcial,string NombreCliente,string DescripcionVehiculo, string _id, string _valorprima)
        {

            // Create the thread object. This does not start the thread.
            Mensajes mensaje = new Mensajes();
            mensaje.Correo = Correo;
            mensaje.TipoDeVehiculo = TipoDeVehiculo;
            mensaje.Linea = Linea;
            mensaje.Marca = Marca;
            mensaje.Modelo = Modelo;
            mensaje.ValorMercado = ValorMercado;
            mensaje.MensajeTipo = MensajeTipo;
            mensaje.Nombre = Nombre;
            mensaje.valorprima = CodigoEmpresa + ": " + _valorprima;
            mensaje.Paso1 = Cotizadores.LinkPaso1(CodigoEmpresa, _id);
            mensaje.Paso2 = Cotizadores.LinkPaso2(CodigoEmpresa, _id);
            mensaje.Link1 = Cotizadores.LinkUbicaciones(CodigoEmpresa, "Link1") + "?asdf=" + _id;
            mensaje.Link2 = Cotizadores.LinkUbicaciones(CodigoEmpresa, "Link1") + "?asdf=" + _id;
            mensaje.Link3 = Cotizadores.LinkUbicaciones(CodigoEmpresa, "Link1") + "?asdf=" + _id;

            string archivo = "";
            if (MensajeTipo == 1)
            {   mensaje.Paso3 = Cotizadores.LinkPaso3(CodigoEmpresa, _id); 
               // archivo = EnvioDeCorreoRapido.AlmacenarPdf1(Nombre, CodigoEmpresa, Decimal.Parse(ValorMercado), RoboParcial, Menores16, Menores18, ExcesosRC, _RoboParcial, NombreCliente, DescripcionVehiculo); 
            }
            else {
                mensaje.Paso3 = Cotizadores.LinkPaso4(CodigoEmpresa, _id);
              //  archivo = EnvioDeCorreoRapido.AlmacenarPdf2(Nombre, CodigoEmpresa, Decimal.Parse(ValorMercado), RoboParcial, Menores16, Menores18, ExcesosRC, _RoboParcial, NombreCliente, DescripcionVehiculo); 
            }
            mensaje.archivo = archivo;

            Thread workerThread = new Thread(mensaje.DoWork);

            // Start the worker thread.
            workerThread.Start();

            // Loop until worker thread activates.
            while (!workerThread.IsAlive) ;

            // Put the main thread to sleep for 1 millisecond to
            // allow the worker thread to do some work:
            Thread.Sleep(1);

            // Request that the worker thread stop itself:
            mensaje.RequestStop();

            // Use the Join method to block the current thread 
            // until the object's thread terminates.
            workerThread.Join();

        }

        public static string AlmacenarPdf1(string nombre, string CodigoEmpresa, decimal SumaAsegurada, bool RoboParcial, bool Menores16, bool Menores18, bool ExcesosRC, decimal _RoboParcial, string NombreCliente, string DescripcionVehiculo)
        {
            //// Setup DataSet


            //// Create Report DataSource
            //ReportDataSource rds = new ReportDataSource("CotizadorRoble", Cotizadores.ReporteCotizacion1( CodigoEmpresa, SumaAsegurada, RoboParcial,  Menores16,  Menores18, ExcesosRC,  _RoboParcial, NombreCliente,  DescripcionVehiculo,"0"));
            string path = HttpContext.Current.Request.PhysicalApplicationPath;
            string archivo = path + @"Documentos\" + nombre.Replace(" ", "_").Replace(".", "") + ".pdf";
            //// Variables
            //Warning[] warnings;
            //string[] streamIds;
            //string mimeType = string.Empty;
            //string encoding = string.Empty;
            //string extension = string.Empty;
            //LimpiarArchivo(archivo);
            //// Setup the report viewer object and get the array of bytes
            //ReportViewer viewer = new ReportViewer();
            //viewer.ProcessingMode = ProcessingMode.Local;
            //viewer.LocalReport.ReportPath = path + @"Reportes\CotizadorRoble.rdlc";
            //viewer.LocalReport.DataSources.Add(rds); // Add datasource here

            //byte[] info = viewer.LocalReport.Render("PDF", null, out mimeType, out encoding, out extension, out streamIds, out warnings);
            //try
            //{
            //    using (FileStream fs = new FileStream(path + @"Documentos\" + nombre.Replace(" ", "_").Replace(".", "") + ".pdf",
            //        FileMode.Create, FileAccess.Write, FileShare.None))
            //    {

            //        fs.Write(info, 0, info.Length);
            //        if (fs != null)
            //        {
            //            ((IDisposable)fs).Dispose();
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{

            //    Helper.RegistrarEvento("Error al escribir el archivo pdf " + ex.Message);
            //}
  


            // viewer.Dispose();
           
             return archivo; 
        
        }
        public static string AlmacenarPdf2(string nombre, string CodigoEmpresa, decimal SumaAsegurada, bool RoboParcial, bool Menores16, bool Menores18, bool ExcesosRC, decimal _RoboParcial, string NombreCliente, string DescripcionVehiculo)
        {
            // Setup DataSet


            // Create Report DataSource
            // ReportDataSource rds = new ReportDataSource("CotizadorRoble", Cotizadores.ReporteCotizacion1(CodigoEmpresa, SumaAsegurada, RoboParcial, Menores16, Menores18, ExcesosRC, _RoboParcial, NombreCliente, DescripcionVehiculo,"0"));
            string path = HttpContext.Current.Request.PhysicalApplicationPath;
            string archivo = path + @"Documentos\" + nombre.Replace(" ", "_").Replace(".", "") + "2.pdf";
            //// Variables
            //Warning[] warnings;
            //string[] streamIds;
            //string mimeType = string.Empty;
            //string encoding = string.Empty;
            //string extension = string.Empty;
            //LimpiarArchivo(archivo);
            //// Setup the report viewer object and get the array of bytes
            //ReportViewer viewer = new ReportViewer();
            //viewer.ProcessingMode = ProcessingMode.Local;
            //viewer.LocalReport.ReportPath = path + @"Reportes\CotizadorRobleRCivil.rdlc";
            //viewer.LocalReport.DataSources.Add(rds); // Add datasource here

            //byte[] info = viewer.LocalReport.Render("PDF", null, out mimeType, out encoding, out extension, out streamIds, out warnings);
            //try
            //{
            //    using (FileStream fs = new FileStream(path + @"Documentos\" + nombre.Replace(" ", "_").Replace(".", "") + "2.pdf",
            //        FileMode.Create, FileAccess.Write, FileShare.None))
            //    {

            //        fs.Write(info, 0, info.Length);
            //        if (fs != null)
            //        {
            //            ((IDisposable)fs).Dispose();
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{

            //    Helper.RegistrarEvento("Error al escribir el archivo pdf " + ex.Message);
            //}



            //viewer.Dispose();

            return archivo; 

        }
        public static void LimpiarArchivo(string archivo)
        {

            if (System.IO.File.Exists(archivo))
            {
                // Use a try block to catch IOExceptions, to 
                // handle the case of the file already being 
                // opened by another process. 
                try
                {
                    System.IO.File.Delete(archivo);
                }
                catch (System.IO.IOException e)
                {
                    
                    return;
                }
            }
        }

        public static void EjecutarAvisoDeActualizacion(string Para, string Nombre, string Descripcion, string titulo)
        {

            // Create the thread object. This does not start the thread.
            Aviso mensaje = new Aviso();
            mensaje.Para = Para;
            mensaje.Nombre = Nombre;
            mensaje.Descripcion = Descripcion;
            mensaje.Titulo = titulo;

            Thread workerThread = new Thread(mensaje.DoWork);

            // Start the worker thread.
            workerThread.Start();

            // Loop until worker thread activates.
            while (!workerThread.IsAlive) ;

            // Put the main thread to sleep for 1 millisecond to
            // allow the worker thread to do some work:
            Thread.Sleep(1);

            // Request that the worker thread stop itself:
            mensaje.RequestStop();

            // Use the Join method to block the current thread 
            // until the object's thread terminates.
            workerThread.Join();

        }


    }

    public class Aviso
    {
   
        public string Para = "";
        public string Nombre = "";
        public string Descripcion = "";
        public string Titulo = "";

        // This method will be called when the thread is started.
        public void DoWork()
        {

            Correo enviando = new Correo();
            string titulo = "Actualización de datos para el Seguro de " + Titulo;
            enviando.EnviarAviso( Para, Nombre, Descripcion, Titulo);


        }
        public void RequestStop()
        {
            _shouldStop = true;
        }
        // Volatile is used as hint to the compiler that this data
        // member will be accessed by multiple threads.
        private volatile bool _shouldStop;
    }

}