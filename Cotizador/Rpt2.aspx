<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Rpt2.aspx.cs" Inherits="Cotizador.Rpt2" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Cotización El Roble</title>
    <link rel="stylesheet" type="text/css" href="http://testcotizador.unitypromotores.com/Cotizador/css/Formulario1.css" />
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
        <div class="pageCenter">
            <table style="left: auto; right: auto;">
                <tr>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server">
                            <asp:Image ID="Image1" runat="server" />
                        </asp:HyperLink>
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                    <td style="width: 200px;">
                        <asp:HyperLink ID="HyperLink2" runat="server">
                            <asp:Image ID="Image2" runat="server" />
                        </asp:HyperLink>
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                    <td>
                        <asp:HyperLink ID="HyperLink3" runat="server">
                            <asp:Image ID="Image3" runat="server" />
                        </asp:HyperLink></td>
                </tr>
            </table>
        </div>
        <br />
        <br />
        <br />
        <div style="text-align: center; width: 100%; height: 100%">
            <span id="TxtTitulo" class="f2" style="font-style: normal; font-variant: normal; font-weight: bold; font-stretch: normal; line-height: normal; font-family: Arial, Helvetica, sans-serif; text-align: left; color: rgb(19, 27, 77); letter-spacing: 3px; text-decoration: none; text-transform: none;">Paso 1</span>
        </div>
        <div style="text-align: center; width: 100%; height: 100%">

            <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" Height="2190px" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="8in" CssClass="centro">
                <LocalReport ReportPath="Reportes\CotizadorCodisaRCivil.rdlc">
                    <DataSources>
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="CotizadorRoble" />
                    </DataSources>
                </LocalReport>
            </rsweb:ReportViewer>

            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="ReporteCotizacion1" TypeName="Cotizador.Cotizadores">
                <SelectParameters>
                    <asp:SessionParameter DefaultValue="&quot;&quot;" Name="CodigoEmpresa" SessionField="CodigoEmpresa" Type="String" />
                    <asp:SessionParameter DefaultValue="0" Name="SumaAsegurada" SessionField="SumaAsegurada" Type="Decimal" />
                    <asp:SessionParameter DefaultValue="false" Name="RoboParcial" SessionField="RoboParcial" Type="Boolean" />
                    <asp:SessionParameter DefaultValue="false" Name="Menores16" SessionField="Menores16" Type="Boolean" />
                    <asp:SessionParameter DefaultValue="false" Name="Menores18" SessionField="Menores18" Type="Boolean" />
                    <asp:SessionParameter DefaultValue="false" Name="ExcesosRC" SessionField="ExcesosRC" Type="Boolean" />
                    <asp:SessionParameter DefaultValue="0" Name="_RoboParcial" SessionField="_RoboParcial" Type="Decimal" />
                    <asp:SessionParameter DefaultValue="&quot;&quot;" Name="NombreCliente" SessionField="NombreCliente" Type="String" />
                    <asp:SessionParameter DefaultValue="&quot;&quot;" Name="DescripcionVehiculo" SessionField="DescripcionVehiculo" Type="String" />
                    <asp:SessionParameter DefaultValue="&quot;&quot;" Name="mensajetipo" SessionField="mensajetipo" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>

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
