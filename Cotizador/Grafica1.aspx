﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Grafica1.aspx.cs" Inherits="Cotizador.Grafica1" %>

<%@ Register Assembly="WebChart" Namespace="WebChart" TagPrefix="Web" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <script src="js/jquery.min.js"></script>
    <script src="js/jquery.js"></script>
    <title></title>
    <style type="text/css">
        .centro {
            display: inline-block;
        }

        .pageCenter {
            margin-left: 15%;
            margin-right: auto;
            max-width: 1000px;
            float: none;
        }

        html, body {
            height: 100%;
        }

        html {
            background: #eee;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="pageCenter">

            <table>
                <tr>
                    <td>
                        <asp:ScriptManager ID="ScriptManager1" runat="server">
                                    </asp:ScriptManager>
                        <table>
                            <tr style="background-color: SteelBlue"><td colspan="3"><a style="color:white; font-size: x-large; font-weight: bold;">De que Año quiere ver la información:
                                <asp:TextBox ID="txtAño" runat="server" Font-Size="X-Large" TextMode="Number" Font-Bold="False" Font-Names="Candara" Height="23px" Width="85px"></asp:TextBox>
                                </a></td></tr>
                            <tr style="background-color: SteelBlue">
                                <td colspan="2">
                                    <a style="color:white; font-size: x-large; font-weight: bold;">De que Empresa :</a>
                                    <asp:DropDownList ID="cmbEmpresas" runat="server" Height="35px" OnSelectedIndexChanged="cmbEmpresas_SelectedIndexChanged" Width="310px" AutoPostBack="False" onclick="MostrarSeleccion();" Font-Bold="False" Font-Names="Candara" Font-Size="X-Large">
                                    </asp:DropDownList>

                                </td>
                                <td>
                                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="&lt;--Regresar" Width="150px" />
                                    </td>

                            </tr>
                            <tr style="background-color: SteelBlue">
                                <td>
                                    <asp:Button ID="btnPie" runat="server" Text="Pie Chart Anual" OnClick="btnPie_Click" Width="150px" />
                                   </td>
                                    <td>
                                        <asp:Button ID="btnLine" runat="server" Text="Line Graph Anual" OnClick="btnLine_Click" Width="150px" /></td>
                                    <td>
                                        <asp:Button ID="btnBar" runat="server" Text="Bar Graph Anual" OnClick="btnBar_Click" Width="150px" /></td>
                            </tr>
                            <tr style="background-color: SteelBlue">
                                <td><a style="color:white">Fecha Inicial :</a> 
                                    <asp:HiddenField ID="HiddenField1" runat="server" />
                                    <input id="FechaIni" type="date" onchange="LlenarFechaIni()" /></td>
                                <td><a style="color:white">Fecha Final : </a>
                                    <asp:HiddenField ID="HiddenField2" runat="server" />
                                    <input id="FechaFin" type="date" onchange="LlenarFechaFin()" />
                                </td>
                                <td>
                                    <asp:Button ID="Button1" runat="server" Text="Reporte por Fechas" OnClick="Button1_Click" Width="150px" /></td>
                            </tr>
                            <tr>
                                <td colspan="3">
                                    <asp:Label ID="lblMsg" runat="server" Text="." Font-Size="X-Large" ForeColor="Red"></asp:Label></td>
                            </tr>
                        </table>

                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Image ID="Chart1" runat="server" />
                         <Web:ChartControl ID="ChartControl1" runat="server" BorderStyle="Solid" BorderWidth="1px" Height="550px" Width="864px" ChartPadding="30" HasChartLegend="False" ShowTitlesOnBackground="False" TopPadding="20" YCustomEnd="0" YCustomStart="0" YValuesInterval="0" LeftChartPadding="2" Padding="2">
                            <Border LineJoin="Round" />

<Background Color="#000099" ForeColor="White"></Background>

                            <PlotBackground Angle="90" EndPoint="100, 400" ForeColor="#FFFFC0" LinearGradientMode="ForwardDiagonal" />

                            <ChartTitle StringFormat="Center,Near,Character,LineLimit" Font="Tahoma, 10pt, style=Bold" ForeColor="White"></ChartTitle>

                            <XAxisFont StringFormat="Center,Near,Character,LineLimit"></XAxisFont>

                            <YAxisFont StringFormat="Far,Near,Character,LineLimit"></YAxisFont>

                            <XTitle StringFormat="Center,Far,Character,LineLimit" Font="Tahoma, 8pt, style=Bold" ForeColor="SteelBlue"></XTitle>

                            <YTitle StringFormat="Near,Near,Character,DirectionVertical" Font="Tahoma, 8pt, style=Bold" ForeColor="SteelBlue"></YTitle>
                        </Web:ChartControl>
                    
                        
                    
                        <cc1:RoundedCornersExtender ID="RoundedCornersExtender2" runat="server" Enabled="True" TargetControlID="ChartControl2">
                        </cc1:RoundedCornersExtender>
                    
                        
                    
                        <cc1:RoundedCornersExtender ID="RoundedCornersExtender3" runat="server" Enabled="True" TargetControlID="ChartControl2">
                        </cc1:RoundedCornersExtender>
                    
                    
                        <cc1:RoundedCornersExtender ID="RoundedCornersExtender1" runat="server" Enabled="True" TargetControlID="ChartControl2">
                        </cc1:RoundedCornersExtender>
                    
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Image ID="Chart2" runat="server" />
                         <Web:ChartControl ID="ChartControl2" runat="server" BorderStyle="Solid" BorderWidth="1px" Height="550px" Width="864px" ChartPadding="30" HasChartLegend="False" ShowTitlesOnBackground="False" TopPadding="20" YCustomEnd="0" YCustomStart="0" YValuesInterval="0" LeftChartPadding="2" Padding="2">
                            <Border LineJoin="Round" />

<Background Color="#000099" ForeColor="White"></Background>

                            <PlotBackground Angle="90" EndPoint="100, 400" ForeColor="#FFFFC0" LinearGradientMode="ForwardDiagonal" />

                            <ChartTitle StringFormat="Center,Near,Character,LineLimit" Font="Tahoma, 10pt, style=Bold" ForeColor="White"></ChartTitle>

                            <XAxisFont StringFormat="Center,Near,Character,LineLimit"></XAxisFont>

                            <YAxisFont StringFormat="Far,Near,Character,LineLimit"></YAxisFont>

                            <XTitle StringFormat="Center,Far,Character,LineLimit" Font="Tahoma, 8pt, style=Bold" ForeColor="SteelBlue"></XTitle>

                            <YTitle StringFormat="Near,Near,Character,DirectionVertical" Font="Tahoma, 8pt, style=Bold" ForeColor="SteelBlue"></YTitle>
                        </Web:ChartControl>
                    
                        
                    
                        
                        <cc1:RoundedCornersExtender ID="ChartControl2_RoundedCornersExtender" runat="server" Enabled="True" TargetControlID="ChartControl2">
                        </cc1:RoundedCornersExtender>
                    </td>

                </tr>
               <tr>
                    <td>
                         <asp:Image ID="Chart3" runat="server" />
                             <Web:ChartControl ID="ChartControl3" runat="server" BorderStyle="Solid" BorderWidth="1px" Height="550px" Width="864px" ChartPadding="30" HasChartLegend="False" ShowTitlesOnBackground="False" TopPadding="20" YCustomEnd="0" YCustomStart="0" YValuesInterval="0" LeftChartPadding="2" Padding="2">
                            <Border LineJoin="Round" />

<Background Color="#000099" ForeColor="White"></Background>

                            <PlotBackground Angle="90" EndPoint="100, 400" ForeColor="#FFFFC0" LinearGradientMode="ForwardDiagonal" />

                            <ChartTitle StringFormat="Center,Near,Character,LineLimit" Font="Tahoma, 10pt, style=Bold" ForeColor="White"></ChartTitle>

                            <XAxisFont StringFormat="Center,Near,Character,LineLimit"></XAxisFont>

                            <YAxisFont StringFormat="Far,Near,Character,LineLimit"></YAxisFont>

                            <XTitle StringFormat="Center,Far,Character,LineLimit" Font="Tahoma, 8pt, style=Bold" ForeColor="SteelBlue"></XTitle>

                            <YTitle StringFormat="Near,Near,Character,DirectionVertical" Font="Tahoma, 8pt, style=Bold" ForeColor="SteelBlue"></YTitle>
                        </Web:ChartControl>
                    
                    </td>

                </tr>

            </table>

        </div>
    </form>
</body>
<script type="text/javascript">

    window.onload = function () {

        $('td#oReportCell', window.parent.frames[0].frames[1].document).next().remove();
        $('div#oReportDiv table', window.parent.frames[0].frames[1].document).attr("align", "center");
    };
    function LlenarFechaIni() {
        var ver1 = document.getElementById("FechaIni").value;
    
        $("#HiddenField1").val(ver1);
    }
    function LlenarFechaFin() {
        var ver2 = document.getElementById("FechaFin").value;
 
        $("#HiddenField2").val(ver2);
    }


</script>
</html>
