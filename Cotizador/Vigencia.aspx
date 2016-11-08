<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Vigencia.aspx.cs" Inherits="Cotizador.Vigencia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Empresas con ProRateo</title>
    <script src="js/jquery.min.js"></script>
    <script src="js/jquery.js"></script>
    <link rel="stylesheet" type="text/css" href="http://localhost/Cotizador/css/Formulario1.css" />
    <meta name="viewport" content="width=device-width,height=device-height,initial-scale=1.0" />
<style type="text/css">
table.altrowstable {
	font-family: verdana,arial,sans-serif;
	font-size:14px;
	color:#333333;
	border-width: 1px;
	border-color: #a9c6c9;
	border-collapse: collapse;
}
table.altrowstable th {
	border-width: 1px;
	padding: 8px;
	border-style: solid;
	border-color: #a9c6c9;
}
 
.oddrowcolor{
	background-color:#d4e3e5;
}
.evenrowcolor{
	background-color:#c3dde0;
}
    .borderunique {
    border-width: 1px;
	padding: 8px;
	border-style: solid;
	border-color: #a9c6c9;
    }
</style>
 
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table    class="centered-content">
                <tr style="width: 1600px;">
                    <td class="auto-style9">
                        <asp:ScriptManager ID="ScriptManager1" runat="server">
                        </asp:ScriptManager>
                    </td>
                    <td>
                        <asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/LogoUnity.png" />
                    </td>
                    <td></td>
                    <td></td>
                </tr>

            </table>
        </div>
        <div>

            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <table id="alternatecolor" class="altrowstable">
                        <tr>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td></td>
                            <td class="borderunique"><a>Seleccione su Nombre</a></td>
                            <td class="borderunique">
                                <asp:DropDownList ID="cmbNombre" runat="server" Font-Size="Small" Height="33px" Width="151px" AutoPostBack="True">
                                </asp:DropDownList>
                            </td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Panel ID="Panel1" runat="server" Width="91px">
                                </asp:Panel>
                            </td>
                            <td>
                                <asp:Panel ID="Panel2" runat="server" Width="186px">
                                </asp:Panel>
                            </td>
                            <td class="borderunique"><a>Empresas :</a></td>
                            <td class="borderunique">
                                <asp:DropDownList ID="cmbEmpresasProRata" runat="server" Height="33px" OnSelectedIndexChanged="cmbEmpresasProRata_SelectedIndexChanged" Width="151px">
                                </asp:DropDownList>
                            </td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr style="width: 150px;">
                            <td></td>
                            <td></td>
                            <td class="auto-style8"></td>
                            <td></td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td></td>
                            <td class="borderunique"><a>Fecha de Vigencia </a></td>
                            <td class="borderunique">
                                <asp:Label ID="lblVigencia" runat="server" Text="."></asp:Label>
                            </td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td>
                                <asp:HiddenField ID="HiddenField1" runat="server" />
                            </td>
                            <td class="borderunique"><a>Seleccionar Nueva Fecha </a></td>
                            <td class="borderunique">
                        <input id="txtFecha" type="date" onchange="LlenarFecha()"/></td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td></td>
                            <td class="borderunique"><a>Guardar nueva Fecha </a></td>
                            <td class="borderunique">
                                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Guardar Vigencia" />
                            </td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr style="width: 150px;">
                            <td></td>
                            <td></td>
                            <td class="auto-style8">
                                <asp:Label ID="lblMensaje" runat="server" ForeColor="Red" Text="."></asp:Label>
                            </td>
                            <td></td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td></td>
                            <td class="borderunique"><a>Agregar Empresa a Calculo de ProRateo</a></td>
                            <td class="borderunique">
                                <asp:DropDownList ID="cmbEmpresas" runat="server" Height="33px" Width="151px" AutoPostBack="True">
                                </asp:DropDownList>
                            </td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td></td>
                            <td class="borderunique" id="lblMensajeEmpresa">
                                <asp:Label ID="lblMensajeEmpresa" runat="server" ForeColor="Red" Text="."></asp:Label>
                            </td>
                            <td class="borderunique">
                                <asp:Button ID="Button2" runat="server" Text="Agregar Empresa" OnClick="Button2_Click" />
                            </td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td></td>
                            <td class="borderunique"><a>Quitar Empresa del Calculo de Prorateo</a></td>
                            <td class="borderunique">
                                <asp:DropDownList ID="cmbEmpresasProRataQuitar" runat="server" Height="33px" Width="151px">
                                </asp:DropDownList>
                            </td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td></td>
                            <td class="borderunique">
                                <asp:Label ID="lblMensajeQuitarEmpresa" runat="server" ForeColor="Red" Text="."></asp:Label>
                            </td>
                            <td class="borderunique">
                                <asp:Button ID="Button3" runat="server" Text="Quitar Empresa" Width="151px" OnClick="Button3_Click" />
                            </td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                        </tr>
                    </table>
                </ContentTemplate>
        </asp:UpdatePanel>

        </div>
        <script type="text/javascript">
            function LlenarFecha() {
                var ver = document.getElementById("txtFecha").value;
                $("#HiddenField1").val(ver);
            }

        </script>
        

    </form>
</body>
</html>
