<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormularioPresentacion.aspx.cs" Inherits="Cotizador.FormularioPresentacion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="js/jquery.min.js"></script>
    <script src="js/jquery.js"></script>
    <link rel="stylesheet" type="text/css" href="css/Formulario1.css" />
    <meta name="viewport" content="width=device-width,height=device-height,initial-scale=1.0" />
    <title>Unity Promotores</title>
</head>
<body class="outer-container">
    <form id="form1" runat="server">
        <div class="outer-container">
            <div class="inner-container">
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                <table class="auto-style18" style="width: auto; height: 100%;">
                    <tr>
                        <td style="text-align: center;">
                            <asp:Image ID="Image2" runat="server" Height="62px" ImageUrl="~/Images/TarjetasDeCredito.png" Width="119px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    </tr>
                    <tr>
                        <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Request Code/Codigo de Pedido:</td>
                    </tr>
                    <tr>
                        <td class="f1" style="font-family: Arial, Helvetica, sans-serif; text-align: center;">
                            <table cellpadding="0" cellspacing="0" class="dxeErrorFrame" style="border-collapse: collapse; visibility: hidden;">
                                <tr>
                                    <td class="f1" style="font-family: Arial, Helvetica, sans-serif; text-align: center; visibility: visible; vertical-align: middle;">
                                        <table cellpadding="0" cellspacing="0" class="f1" style="border-collapse: collapse; border: 1px solid rgb(159, 159, 159); cursor: default; -webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Arial, Helvetica, sans-serif; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none; margin-bottom: 0px; width: 150px; background-color: white;">
                                            <tr>
                                                <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                                                    <asp:TextBox ID="txtCodigoPedido" runat="server" CssClass="dxeEditArea dxeEditAreaSys" Width="193px" AutoCompleteType="Disabled" Height="40px" ReadOnly="True"></asp:TextBox>
                                                </td>
                                                <td>&nbsp;&nbsp;<img alt="" class="auto-style2" src="../Images/Error.png" id="errNombre" style="visibility: hidden" /></td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td class="f1" style="font-family: Tahoma, Geneva, sans-serif; text-align: center; font-style: normal; font-variant: normal; font-weight: normal; font-stretch: normal; line-height: normal; color: red; padding-left: 4px; padding-right: 5px; vertical-align: middle;">
                                        <table cellpadding="0" cellspacing="0" style="width: 33px; border-collapse: collapse;">
                                            <tr>
                                                <td class="f1" style="font-family: Tahoma, Geneva, sans-serif; text-align: center; font-style: normal; font-variant: normal; font-weight: normal; font-stretch: normal; line-height: normal; color: red; padding-right: 5px;">
                                                    <img alt="" class="dxEditors_edtError" src="#" style="border-width: 0px; display: block; margin: auto; width: 14px; height: 14px; background-image: url(''); background-color: transparent; background-position: -170px 0px; background-repeat: no-repeat;" /></td>
                                                <td class="f1" style="font-family: Tahoma, Geneva, sans-serif; text-align: center; font-style: normal; font-variant: normal; font-weight: normal; font-stretch: normal; line-height: normal; color: red; width: 14px; white-space: nowrap;"></td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Email:</td>
                    </tr>
                    <tr>
                        <td class="f1" style="font-family: Arial, Helvetica, sans-serif; text-align: center;" class="auto-style1">
                            <table cellpadding="0" cellspacing="0" class="dxeErrorFrame" style="border-collapse: collapse; visibility: hidden;">
                                <tr>
                                    <td class="f1" style="font-family: Arial, Helvetica, sans-serif; text-align: center; visibility: visible; vertical-align: middle;">
                                        <table cellpadding="0" cellspacing="0" class="f1" style="border-collapse: collapse; border: 1px solid rgb(159, 159, 159); cursor: default; -webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Arial, Helvetica, sans-serif; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none; margin-bottom: 0px; width: 150px; background-color: white;">
                                            <tr>
                                                <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                                                    <asp:TextBox ID="txtCorreo" runat="server" CssClass="dxeEditArea dxeEditAreaSys" Width="193px" AutoCompleteType="Disabled" ReadOnly="True"></asp:TextBox>
                                                </td>
                                                <td class="auto-style8">&nbsp;&nbsp;<img alt="" class="auto-style2" src="../Images/Error.png" id="errCorreo" style="visibility: hidden" /></td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td class="f1" style="font-family: Tahoma, Geneva, sans-serif; text-align: center; font-style: normal; font-variant: normal; font-weight: normal; font-stretch: normal; line-height: normal; color: red; padding-left: 4px; padding-right: 5px; vertical-align: middle;">
                                        <table cellpadding="0" cellspacing="0" style="width: 33px; border-collapse: collapse;">
                                            <tr>
                                                <td class="f1" style="font-family: Tahoma, Geneva, sans-serif; text-align: center; font-style: normal; font-variant: normal; font-weight: normal; font-stretch: normal; line-height: normal; color: red; padding-right: 5px;">
                                                    <img alt="" class="dxEditors_edtError" src="#" style="border-width: 0px; display: block; margin: auto; width: 14px; height: 14px; background-image: url(''); background-color: transparent; background-position: -170px 0px; background-repeat: no-repeat;" /></td>
                                                <td class="f1" style="font-family: Tahoma, Geneva, sans-serif; text-align: center; font-style: normal; font-variant: normal; font-weight: normal; font-stretch: normal; line-height: normal; color: red; width: 14px; white-space: nowrap;"></td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Nit / Or CF if you dont have:</td>
                    </tr>
                    <tr>
                        <td class="f1" style="font-family: Arial, Helvetica, sans-serif; text-align: left; float: left;">
                            <table cellpadding="0" cellspacing="0" class="f1" style="border-collapse: collapse; border: 1px solid rgb(159, 159, 159); cursor: default; -webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Arial, Helvetica, sans-serif; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none; margin-bottom: 0px; width: 150px; background-color: white;">
                                <tr>
                                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                                        <asp:TextBox ID="txtNit" runat="server" CssClass="dxeEditArea dxeEditAreaSys" onkeypress="return isNumberKey(event)" Width="193px" MaxLength="8" AutoCompleteType="Disabled">CF</asp:TextBox>
                                    </td>
                                    <td>&nbsp;&nbsp;<img alt="" class="auto-style2" src="../Images/Error.png" id="errTelefono" style="visibility: hidden" /></td>
                        </td>
                    </tr>
                </table>
                </td>
           </tr>
                <tr>
                    <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                Name / Nombre<a id="Marca1">:</a>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                </tr>
                <tr>
                    <td class="f1" style="font-family: Arial, Helvetica, sans-serif; text-align: left; float: left;">
                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                            <ContentTemplate>
                                <div id="Marca2">
                                    <table cellpadding="0" cellspacing="0" style="border-collapse: collapse;">
                                        <tr>
                                            <td class="f1" style="font-family: Arial, Helvetica, sans-serif; text-align: center;">
                                                <table cellpadding="0" cellspacing="0" class="f1" style="border-collapse: collapse; border: 1px solid rgb(159, 159, 159); cursor: default; -webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Arial, Helvetica, sans-serif; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none; margin-bottom: 0px; width: 150px; background-color: white;">
                                                    <tr>
                                                        <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                                                            <asp:TextBox ID="txtNombre" runat="server" CssClass="dxeEditArea dxeEditAreaSys" Width="193px" AutoCompleteType="Disabled"></asp:TextBox>
                                                        </td>
                                                        <td>&nbsp;&nbsp;<img alt="" class="auto-style2" src="../Images/Error.png" id="errMarca" style="visibility: hidden" /></td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                </tr>
                <tr>
                    <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Address/Dirección:</td>
                </tr>
                <tr>
                    <td class="f1" style="font-family: Arial, Helvetica, sans-serif; text-align: left; float: left;">
                        <table cellpadding="0" cellspacing="0" class="f1" style="border: 1px solid rgb(159, 159, 159); font-style: normal; font-variant: normal; font-weight: normal; font-stretch: normal; line-height: normal; font-family: Tahoma, Geneva, sans-serif; cursor: default; -webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: auto; height: 15px; border-collapse: separate;">
                            <tr>
                                <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                                    <table>
                                        <tr>
                                            <td>
                                                <asp:TextBox ID="txtDireccion" runat="server" CssClass="dxeEditArea dxeEditAreaSys" Width="193px" AutoCompleteType="Disabled"></asp:TextBox>
                                            </td>
                                            <td>
                                                <img alt="" class="auto-style2" src="../Images/Error.png" id="errLinea" style="visibility: hidden" /></td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">
                        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                            <ContentTemplate>
                                <a id="Monto1">Credit Card Number/Numero TC:</a>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                </tr>
                <tr>
                    <td class="f1" style="font-family: Arial, Helvetica, sans-serif; text-align: left; float: left;">
                        <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                            <ContentTemplate>
                                <div id="Monto">
                                    <table cellpadding="0" cellspacing="0" style="border-collapse: collapse;">
                                        <tr>
                                            <td class="f1" style="font-family: Arial, Helvetica, sans-serif; text-align: center;">
                                                <table cellpadding="0" cellspacing="0" class="f1" style="border-collapse: collapse; border: 1px solid rgb(159, 159, 159); cursor: default; -webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Arial, Helvetica, sans-serif; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none; margin-bottom: 0px; width: 150px; background-color: white;">
                                                    <tr>
                                                        <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                                                            <asp:TextBox ID="txtTarjetaDeCredito" runat="server" CssClass="dxeEditArea dxeEditAreaSys" Width="193px" onkeypress="return isNumberKey(event)" AutoCompleteType="Disabled"></asp:TextBox>
                                                        </td>
                                                        <td>&nbsp;&nbsp;<img alt="" class="auto-style2" src="../Images/Error.png" id="errMontoAsegurado" style="visibility: hidden" /></td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                </tr>
                <tr>
                    <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">
                        <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                            <ContentTemplate>
                                <a>Credit Card Code/Codigo TC:</a>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                </tr>
                <tr>
                    <td class="f1" style="font-family: Arial, Helvetica, sans-serif; text-align: left; float: left;">
                        <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                            <ContentTemplate>
                                <div>
                                    <table cellpadding="0" cellspacing="0" style="border-collapse: collapse;">
                                        <tr>
                                            <td class="f1" style="font-family: Arial, Helvetica, sans-serif; text-align: center;">
                                                <table cellpadding="0" cellspacing="0" class="f1" style="border-collapse: collapse; border: 1px solid rgb(159, 159, 159); cursor: default; -webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Arial, Helvetica, sans-serif; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none; margin-bottom: 0px; width: 150px; background-color: white;">
                                                    <tr>
                                                        <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                                                            <asp:TextBox ID="txtCodigoTArjeta" runat="server" CssClass="dxeEditArea dxeEditAreaSys" Width="193px" onkeypress="return isNumberKey(event)" AutoCompleteType="Disabled"></asp:TextBox>
                                                        </td>
                                                        <td>&nbsp;&nbsp;<img alt="" class="auto-style2" src="../Images/Error.png" id="errMontoAsegurado" style="visibility: hidden" /></td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                </tr>
                <tr>
                    <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">
                        <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                            <ContentTemplate>
                                <a>Due Date/Fecha de Vencimiento:</a>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                </tr>
                <tr>
                    <td class="f1" style="font-family: Arial, Helvetica, sans-serif; text-align: left; float: left;">
                        <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                            <ContentTemplate>
                                <div>
                                    <table cellpadding="0" cellspacing="0" style="border-collapse: collapse;">
                                        <tr>
                                            <td class="f1" style="font-family: Arial, Helvetica, sans-serif; text-align: center;">
                                                <table cellpadding="0" cellspacing="0" class="f1" style="border-collapse: collapse; border: 1px solid rgb(159, 159, 159); cursor: default; -webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Arial, Helvetica, sans-serif; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none; margin-bottom: 0px; width: 150px; background-color: white;">
                                                    <tr>
                                                        <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                                                            <asp:TextBox ID="txtFechaExpiracion" runat="server" CssClass="dxeEditArea dxeEditAreaSys" Width="193px" onkeypress="return isNumberKey(event)" AutoCompleteType="Disabled"></asp:TextBox>
                                                        </td>
                                                        <td>&nbsp;&nbsp;<img alt="" class="auto-style2" src="../Images/Error.png" id="errMontoAsegurado" style="visibility: hidden" /></td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                </tr>
                <tr>
                    <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">
                        <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                            <ContentTemplate>
                                <a>Currency / Moneda:</a>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                </tr>
                <tr>
                    <td class="f1" style="font-family: Arial, Helvetica, sans-serif; text-align: left; float: left;">
                        <asp:UpdatePanel ID="UpdatePanel10" runat="server">
                            <ContentTemplate>
                                <table cellpadding="0" cellspacing="0" style="border-collapse: collapse;">
                                    <tr>
                                        <td class="f1" style="font-family: Arial, Helvetica, sans-serif; text-align: center;">
                                            <table cellpadding="0" cellspacing="0" class="f1" style="border-collapse: collapse; border: 1px solid rgb(159, 159, 159); cursor: default; -webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Arial, Helvetica, sans-serif; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none; margin-bottom: 0px; width: 150px; background-color: white;">
                                                <tr>
                                                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                                                        <span class="f1" style="font-style: normal; font-variant: normal; font-weight: normal; font-stretch: normal; line-height: normal; font-family: Tahoma, Geneva, sans-serif;">
                                                            <asp:DropDownList ID="cmbPais" runat="server">
                                                                <asp:ListItem>USD</asp:ListItem>
                                                                <asp:ListItem>GTQ</asp:ListItem>
                                                            </asp:DropDownList>
                                                        </span>
                                                    </td>
                                                    <td>&nbsp;&nbsp;<img alt="" class="auto-style2" src="../Images/Error.png" id="errMontoAsegurado" style="visibility: hidden" /></td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                </tr>
                <tr>
                    <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">
                        <asp:UpdatePanel ID="UpdatePanel11" runat="server">
                            <ContentTemplate>
                                <a>Total Payment/Total a Pagar:</a>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                </tr>
                <tr>
                    <td class="f1" style="font-family: Arial, Helvetica, sans-serif; text-align: left; float: left;">
                        <asp:UpdatePanel ID="UpdatePanel12" runat="server">
                            <ContentTemplate>
                                <div>
                                    <table cellpadding="0" cellspacing="0" style="border-collapse: collapse;">
                                        <tr>
                                            <td class="f1" style="font-family: Arial, Helvetica, sans-serif; text-align: center;">
                                                <table cellpadding="0" cellspacing="0" class="f1" style="border-collapse: collapse; border: 1px solid rgb(159, 159, 159); cursor: default; -webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Arial, Helvetica, sans-serif; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none; margin-bottom: 0px; width: 150px; background-color: white;">
                                                    <tr>
                                                        <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                                                            <asp:TextBox ID="txtMontoAPagar" runat="server" CssClass="dxeEditArea dxeEditAreaSys" Width="193px" onkeypress="return isNumberKey(event)" AutoCompleteType="Disabled"></asp:TextBox>
                                                        </td>
                                                        <td>&nbsp;&nbsp;<img alt="" class="auto-style2" src="../Images/Error.png" id="errMontoAsegurado" style="visibility: hidden" /></td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                </tr>
                <tr>
                    <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">
                        <asp:UpdatePanel ID="UpdatePanel13" runat="server">
                            <ContentTemplate>
                                <a>Captcha</a>/Prove you are not a Robot

                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                </tr>
                <tr>
                    <td class="f1" style="font-family: Arial, Helvetica, sans-serif; text-align: left; float: left;">
                        <asp:UpdatePanel ID="UpdatePanel14" runat="server">
                            <ContentTemplate>
                                <div>
                                    <table cellpadding="0" cellspacing="0" style="border-collapse: collapse;">
                                        <tr>
                                            <td class="f1" style="font-family: Arial, Helvetica, sans-serif; text-align: center;">
                                                <table cellpadding="0" cellspacing="0" class="f1" style="border-collapse: collapse; border: 1px solid rgb(159, 159, 159); cursor: default; -webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Arial, Helvetica, sans-serif; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none; margin-bottom: 0px; width: 150px; background-color: white;">
                                                    <tr>
                                                        <td>


                                                            <asp:Label ID="lblCaptchaMsg" runat="server" Font-Bold="True"
                                                                ForeColor="Red" Text=""></asp:Label>
                                                            <br />
                                </div>
                                <asp:TextBox ID="txtimgcode" runat="server"></asp:TextBox>
                                <br />
                                <asp:UpdatePanel ID="UpdatePanel15" runat="server">
                                    <ContentTemplate>
                                        <asp:Image ID="Image1" runat="server" ImageUrl="~/CImage.aspx" />
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                                <br />
                                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </div>

                    </td>
                </tr>
                <tr>
                    <td class="f5" style="font-family: Arial, Helvetica, sans-serif; text-align: center;" class="auto-style7"><span class="f1" style="font-style: normal; font-variant: normal; font-weight: normal; font-stretch: normal; line-height: normal; font-family: Tahoma, Geneva, sans-serif;">
                        <table cellpadding="0" cellspacing="0" style="height: 35px; width: 103px; border-collapse: separate;">
                            <tr>
                                <td style="text-align: center">
                                    <asp:Button ID="Button1" runat="server" BackColor="White" BorderColor="#336699" BorderStyle="Solid" BorderWidth="1px" CssClass="btn" Height="100%" OnClick="Button1_Click" Text="Send Payment" Width="145%" />
                                    <span class="f1" style="font-style: normal; font-variant: normal; font-weight: normal; font-stretch: normal; line-height: normal; font-family: Tahoma, Geneva, sans-serif;">
                                        <asp:Label ID="lblAprobación" runat="server" Text="."></asp:Label>


                                </td>
                            </tr>
                        </table></td>
                </tr>
                <tr>
                    <td class="f1" style="font-family: Arial, Helvetica, sans-serif; text-align: center;">
                        <asp:Label ID="lblMensajes" runat="server" ForeColor="Red" Text="."></asp:Label>
                    </td>
                </tr>
                <div style="float: left; text-align: left;">
                    <asp:Label ID="lblMsg" runat="server" Text="." ForeColor="Red"></asp:Label>
                </div>
            </div>
        </div>
        <b class="f0" style="display: block; clear: both; height: 0px; width: 0px; line-height: 0; overflow: hidden; visibility: hidden;"></b>
        </td></tr></table>


        </div>

 </div>


    </form>
</body>
</html>
