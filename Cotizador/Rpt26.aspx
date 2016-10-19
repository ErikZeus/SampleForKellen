﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Rpt26.aspx.cs" Inherits="Cotizador.Rpt26" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

 
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Cotización El Roble</title>
      <link rel="stylesheet" type="text/css" href="http://cotizador.unitypromotores.com/Cotizador/css/Formulario1.css"/>
    <style type="text/css">
        .centro {
            display: inline-block; 
        }
        .pageCenter {
	margin-left: 20%;
	margin-right: auto;
	max-width: 1000px;
	float: none;
}
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center; width:100%; height:100%"><span id="TxtTitulo" class="f2" style="font-style: normal; font-variant: normal; font-weight: bold; font-stretch: normal;  line-height: normal; 
font-family: Arial, Helvetica, sans-serif; text-align: left; color: rgb(19, 27, 77); letter-spacing: 3px; text-decoration: none; 
text-transform: none;">ReporteEstado</span> </div>
    <div style="text-align:center; width:100%; height:100%" >
  
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" Height="850px" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="12in" CssClass="centro" >
               <LocalReport ReportPath="Reportes\Estado.rdlc">
                   <DataSources>
                       <rsweb:ReportDataSource DataSourceId="Estado" Name="ASR27" />
                   </DataSources>
            </LocalReport>
        </rsweb:ReportViewer>

        <asp:ObjectDataSource ID="Estado" runat="server" SelectMethod="ReporteEstado" TypeName="Cotizador.Cotizadores"></asp:ObjectDataSource>

    </div>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
        </form>
    </body>
    <script type="text/javascript">

        window.onload = function () {

            $('td#oReportCell', window.parent.frames[0].frames[1].document).next().remove();
            $('div#oReportDiv table', window.parent.frames[0].frames[1].document).attr("align", "center");
        };

</script>
</html>
