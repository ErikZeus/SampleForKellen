<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CS.aspx.cs" Inherits="Cotizador.CS" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script type="text/javascript" src="js/jquery.min.js"></script>
    <script type="text/javascript" src="js/jquery.js"></script>
    <link rel="stylesheet" type="text/css" href="http://testcotizador.unitypromotores.com/Cotizador/css/Formulario1.css" />
    <meta name="viewport" content="width=device-width,height=device-height,initial-scale=1.0" />
    <title></title>
    <style type="text/css">
        .autocomplete_completionListElement {
            visibility: hidden;
            margin: 0px /*!important*/;
            background-color: white;
            color: windowtext;
            border: buttonshadow;
            border-width: 1px;
            border-style: solid;
            cursor: pointer;
            overflow: auto;
            max-height: 300px;
            text-align: left;
            list-style-type: none;
            font-family: Arial;
            font-size: 9pt;
            list-style-type: none;
            padding: 0px 0px 0px 0px;
            width: 500px;
        }

        /* AutoComplete highlighted item */

        .autocomplete_highlightedListItem {
            background-color: #ffff99;
            color: black;
            padding: 1px;
            list-style-type: none;
        }


        /* AutoComplete item */

        .autocomplete_listItem {
            background-color: window;
            color: windowtext;
            padding: 1px;
            list-style-type: none;
        }
        .auto-style8 {
            height: 30px;
        }
        .auto-style9 {
            width: 89%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="outer-container">
        <asp:ScriptManager ID="ScriptManager2" runat="server">
        </asp:ScriptManager>

        <div class="inner-container">
            <table id="Principal" class="centered-content">
                <tr>
                    <td colspan="2">

                        <table>
                            <tr>
                                <td class="auto-style8" style="font-family: Arial, Helvetica, sans-serif; text-align: center;"><span id="TxtTitulo" class="f2" style="font-style: normal; font-variant: normal; font-weight: normal; font-stretch: normal; line-height: normal; font-family: Arial, Helvetica, sans-serif; text-align: left; color: rgb(19, 27, 77); letter-spacing: 3px; text-decoration: none; text-transform: none;">BUSCAR COTIZACIONES</span></td>
                            </tr>
                            <tr>
                                <td style="text-align:left; font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif; font-size: large; font-weight: bold; font-style: normal;">Por Nombre&nbsp;&nbsp;&nbsp;
                                    <table>

                                        <tr>
                                            <td style="text-align:left; font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif; font-size: large; font-weight: bold; font-style: normal;">
                                                <asp:TextBox ID="txtContactsSearch" runat="server" autocomplete="off" Font-Size="12px" onclick="Vaciar();" Width="26.2em" Height="16px"></asp:TextBox>
                                                <cc1:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" CompletionInterval="100" CompletionListCssClass="autocomplete_completionListElement" CompletionListHighlightedItemCssClass="autocomplete_highlightedListItem" CompletionListItemCssClass="autocomplete_listItem" CompletionSetCount="50" EnableCaching="false" FirstRowSelected="false" MinimumPrefixLength="2" ServiceMethod="SearchCustomers" TargetControlID="txtContactsSearch">
                                                </cc1:AutoCompleteExtender>
                                                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Buscar" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="text-align:right">
                                                <table><tr><td class="auto-style9" style="text-align:left; font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif; font-size: large; font-weight: bold; font-style: normal">Por Id <asp:TextBox ID="txtId" runat="server" Height="17px" Width="261px" autocomplete="off"></asp:TextBox>
                                                    <cc1:FilteredTextBoxExtender ID="txtId_FilteredTextBoxExtender" runat="server" FilterType="Numbers" TargetControlID="txtId">
                                                    </cc1:FilteredTextBoxExtender>
                                                    </td><td><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Buscar" /></td></tr></table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="text-align:right">
                                                <table><tr><td>Imprimir ASR27.......................................</td><td style="text-align:right"><asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="ASR27" Width="150px" /></td></tr></table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="text-align:right">
                                               <table><tr><td>Cotizaciones en Tramite........................</td><td  style="text-align:right"><asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="En Tramite" Width="150px" /></td></tr></table> 
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="text-align:right">
                                            <table><tr><td>Estadisticas................................................</td><td style="text-align:right"><asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Ver Gráficas" Width="150px" /></td></tr></table>    
                                            </td>
                                        </tr>
                                    </table>




                                </td>
                </tr>
                </table>
 
                    </td>
                </tr>
                <tr>
                    <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Nombres:</td>
                    <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Apellidos:</td>
                </tr>
                <tr>
                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                        <asp:TextBox ID="txtNombre" runat="server" AutoCompleteType="Disabled" CssClass="dxeEditArea dxeEditAreaSys" ReadOnly="True" Width="193px" BackColor="#FFFFCC" Font-Bold="False" Font-Names="Candara" Font-Size="15px"></asp:TextBox>
                    </td>
                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                        <asp:TextBox ID="txtApellido" runat="server" AutoCompleteType="Disabled" CssClass="dxeEditArea dxeEditAreaSys" ReadOnly="True" Width="193px" BackColor="#FFFFCC" Font-Bold="False" Font-Names="Candara" Font-Size="15px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Correo:</td>
                    <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Tipo de Vehiculo:</td>
                </tr>
                <tr>
                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                        <asp:TextBox ID="txtCorreo" runat="server" AutoCompleteType="Disabled" CssClass="dxeEditArea dxeEditAreaSys" ReadOnly="True" Width="193px" BackColor="#FFFFCC" Font-Bold="False" Font-Names="Candara" Font-Size="15px"></asp:TextBox>
                    </td>
                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                        <asp:TextBox ID="txtTipoVehiculo" runat="server" AutoCompleteType="Disabled" CssClass="dxeEditArea dxeEditAreaSys" ReadOnly="True" Width="193px" BackColor="#FFFFCC" Font-Bold="False" Font-Names="Candara" Font-Size="15px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Linea:</td>
                    <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Marca:</td>
                </tr>
                <tr>
                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                        <asp:TextBox ID="txtLinea" runat="server" AutoCompleteType="Disabled" CssClass="dxeEditArea dxeEditAreaSys" ReadOnly="True" Width="193px" BackColor="#FFFFCC" Font-Bold="False" Font-Names="Candara" Font-Size="15px"></asp:TextBox>
                    </td>
                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                        <asp:TextBox ID="txtMarca" runat="server" AutoCompleteType="Disabled" CssClass="dxeEditArea dxeEditAreaSys" ReadOnly="True" Width="193px" BackColor="#FFFFCC" Font-Bold="False" Font-Names="Candara" Font-Size="15px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Telefono:</td>
                    <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Modelo:</td>
                </tr>
                <tr>
                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                        <asp:TextBox ID="txtTelefono" runat="server" AutoCompleteType="Disabled" CssClass="dxeEditArea dxeEditAreaSys" ReadOnly="True" Width="193px" BackColor="#FFFFCC" Font-Bold="False" Font-Names="Candara" Font-Size="15px"></asp:TextBox>
                    </td>
                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                        <asp:TextBox ID="txtModelo" runat="server" AutoCompleteType="Disabled" CssClass="dxeEditArea dxeEditAreaSys" ReadOnly="True" Width="193px" BackColor="#FFFFCC" Font-Bold="False" Font-Names="Candara" Font-Size="15px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Suma Asegurada:</td>
                    <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Fecha:</td>
                </tr>
                <tr>
                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                        <asp:TextBox ID="txtSumaAsegurada" runat="server" AutoCompleteType="Disabled" CssClass="dxeEditArea dxeEditAreaSys" ReadOnly="True" Width="193px" BackColor="#FFFFCC" Font-Bold="False" Font-Names="Candara" Font-Size="15px"></asp:TextBox>
                    </td>
                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                        <asp:TextBox ID="txtFecha" runat="server" AutoCompleteType="Disabled" CssClass="dxeEditArea dxeEditAreaSys" ReadOnly="True" Width="193px" BackColor="#FFFFCC" Font-Bold="False" Font-Names="Candara" Font-Size="15px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Tipo de Seguro:</td>
                    <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Contactar:</td>
                </tr>
                <tr>
                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                        <asp:TextBox ID="txtTipoSeguro" runat="server" AutoCompleteType="Disabled" CssClass="dxeEditArea dxeEditAreaSys" ReadOnly="True" Width="193px" BackColor="#FFFFCC" Font-Bold="False" Font-Names="Candara" Font-Size="15px"></asp:TextBox>
                    </td>
                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                        <asp:TextBox ID="txtContactar" runat="server" AutoCompleteType="Disabled" CssClass="dxeEditArea dxeEditAreaSys" ReadOnly="True" Width="193px" BackColor="#FFFFCC" Font-Bold="False" Font-Names="Candara" Font-Size="15px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Empresa :</td>
                    <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Como Contactar:</td>
                </tr>
                <tr>
                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                        <asp:TextBox ID="txtCodigoEmpresa" runat="server" AutoCompleteType="Disabled" CssClass="dxeEditArea dxeEditAreaSys" ReadOnly="True" Width="193px" BackColor="#FFFFCC" Font-Bold="False" Font-Names="Candara" Font-Size="15px"></asp:TextBox>
                    </td>
                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                        <asp:TextBox ID="txtComoContactar" runat="server" AutoCompleteType="Disabled" CssClass="dxeEditArea dxeEditAreaSys" ReadOnly="True" Width="193px" BackColor="#FFFFCC" Font-Bold="False" Font-Names="Candara" Font-Size="15px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Paso 1:</td>
                    <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Paso 2:</td>
                </tr>
                <tr>
                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                        <asp:TextBox ID="txtPaso1" runat="server" AutoCompleteType="Disabled" BackColor="#FFFFCC" CssClass="dxeEditArea dxeEditAreaSys" ReadOnly="True" Width="193px" Font-Bold="False" Font-Names="Candara" Font-Size="15px"></asp:TextBox>
                    </td>
                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                        <asp:TextBox ID="txtPaso2" runat="server" AutoCompleteType="Disabled" BackColor="#FFFFCC" CssClass="dxeEditArea dxeEditAreaSys" ReadOnly="True" Width="193px" Font-Bold="False" Font-Names="Candara" Font-Size="15px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Paso 3:</td>
                    <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Nit:</td>
                </tr>
                <tr>
                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                        <asp:TextBox ID="txtPaso3" runat="server" AutoCompleteType="Disabled" BackColor="#FFFFCC" CssClass="dxeEditArea dxeEditAreaSys" ReadOnly="True" Width="193px" Font-Bold="False" Font-Names="Candara" Font-Size="15px"></asp:TextBox>
                    </td>
                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                        <asp:TextBox ID="txtNit" runat="server" AutoCompleteType="Disabled" CssClass="dxeEditArea dxeEditAreaSys" ReadOnly="True" Width="193px" BackColor="#FFFFCC" Font-Bold="False" Font-Names="Candara" Font-Size="15px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">DPI:</td>
                    <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Direccion:</td>
                </tr>
                <tr>
                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                        <asp:TextBox ID="txtDPI" runat="server" AutoCompleteType="Disabled" CssClass="dxeEditArea dxeEditAreaSys" ReadOnly="True" Width="193px" BackColor="#FFFFCC" Font-Bold="False" Font-Names="Candara" Font-Size="15px"></asp:TextBox>
                    </td>
                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                        <asp:TextBox ID="txtDireccion" runat="server" AutoCompleteType="Disabled" CssClass="dxeEditArea dxeEditAreaSys" ReadOnly="True" Width="193px" BackColor="#FFFFCC" Font-Bold="False" Font-Names="Candara" Font-Size="15px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Zona:</td>
                    <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Municipio:</td>
                </tr>
                <tr>
                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                        <asp:TextBox ID="txtZona" runat="server" AutoCompleteType="Disabled" CssClass="dxeEditArea dxeEditAreaSys" ReadOnly="True" Width="193px" BackColor="#FFFFCC" Font-Bold="False" Font-Names="Candara" Font-Size="15px"></asp:TextBox>
                    </td>
                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                        <asp:TextBox ID="txtMunicipio" runat="server" AutoCompleteType="Disabled" CssClass="dxeEditArea dxeEditAreaSys" ReadOnly="True" Width="193px" BackColor="#FFFFCC" Font-Bold="False" Font-Names="Candara" Font-Size="15px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Ingreso:</td>
                    <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Status:</td>
                </tr>
                <tr>
                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                        <asp:TextBox ID="txtIngreso" runat="server" AutoCompleteType="Disabled" CssClass="dxeEditArea dxeEditAreaSys" ReadOnly="True" Width="193px" BackColor="#FFFFCC" Font-Bold="False" Font-Names="Candara" Font-Size="15px"></asp:TextBox>
                    </td>
                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                        <asp:TextBox ID="txtStatus" runat="server" AutoCompleteType="Disabled" CssClass="dxeEditArea dxeEditAreaSys" ReadOnly="True" Width="193px" BackColor="#FFFFCC" Font-Bold="False" Font-Names="Candara" Font-Size="15px"></asp:TextBox>
                    </td>
                </tr>
                <tr><td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Motivo :</td></tr>
                 <tr>
                    <td colspan="2" class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                        <asp:TextBox ID="txtMotivo" runat="server" AutoCompleteType="Disabled" CssClass="dxeEditArea dxeEditAreaSys"  Width="275px" BackColor="#FFFFCC" Font-Bold="False" Font-Names="Candara" Font-Size="15px" Height="16px"></asp:TextBox>
                        <asp:Button ID="Button6" runat="server" Text="Cierre por Abandono" OnClick="Button6_Click" />
                    </td>
                </tr>
            </table>
        </div>


        <%--"Nombre","Apellidos","Correo","TipoDeVehiculo","Linea","Marca","Telefono","Modelo","SumaAsegurada","Fecha","TipoSeguro"
     "contactar","CodigoEmpresa","ComoContactar","Paso1","Paso2","Paso3","Nit","DPI","Direccion","Zona","Municipio"
     "ingreso","status"--%>
    </form>
    <script type="text/javascript">
        function onListPopulated() {

            var completionList = $find("AutoCompleteEx").get_completionList();
            completionList.style.width = 'auto';
        }
        function Vaciar() {
            $("#txtContactsSearch").val("");

        }


        $(document).ready(function () {
            $("#txtContactsSearch").keypress(function (e) {
                if (e.which == 13) {
                    return false;
                }
            });
        });
    </script>
</body>
</html>
