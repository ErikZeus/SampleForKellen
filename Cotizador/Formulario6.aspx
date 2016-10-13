<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario6.aspx.cs" Inherits="Cotizador.Formulario6" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

 
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="js/jquery.min.js"></script>
    <script src="js/jquery.js"></script>
    <script src="https://www.google-analytics.com/analytics.js" ></script>
    <link rel="stylesheet" type="text/css" href="http://testcotizador.unitypromotores.com/Cotizador/css/Formulario1.css"/>
    <meta name="viewport" content="width=device-width,height=device-height,initial-scale=1.0"/>
    <title>Cotizador Unity Promotores</title>
    <!-- Google Analytics -->
<script>
    (function (i, s, o, g, r, a, m) {
        i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function () {
            (i[r].q = i[r].q || []).push(arguments)
        }, i[r].l = 1 * new Date(); a = s.createElement(o),
        m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g; m.parentNode.insertBefore(a, m)
    })(window, document, 'script', 'https://www.google-analytics.com/analytics.js', 'ga');

    ga('create', 'UA-XXXXX-Y', 'auto');
    ga('send', 'pageview');
</script>
<!-- End Google Analytics -->
</head>
<body>
    <form id="form1" runat="server" class="outer-container" >
    <div class="inner-container">
      <div id="Asoc1" class="divX">
       <table style="width:500px;"><tr><td>&nbsp;</td></tr>
           <tr><td>&nbsp;</td></tr>
           <tr><td>&nbsp;</td></tr>
           <tr><td>&nbsp;</td></tr>
           <tr><td>&nbsp;</td></tr>
           <tr><td>&nbsp;</td></tr>
           <tr><td>&nbsp;</td></tr>
           <tr><td>&nbsp;</td></tr>
           <tr><td style="text-align:left; float:left;"><asp:Image ID="Image2" CssClass="cuadro" runat="server" Height="226px" ImageUrl="http://testcotizador.unitypromotores.com/Cotizador/imagenes/LogoBlancoUnityPromotores.png" Width="317px" /></td></tr>
       </table>
     

    </div>
                         <div class="divX">  
                           <table id="Principal"  class="centered-content"><tr><td class="auto-style10"> 
                                  <table aria-multiline="True"  >
                                    <tr>
                                        <td class="f1" style="font-family: Arial, Helvetica, sans-serif;  text-align: center; "><span id="TxtTitulo" class="f2" style="font-style: normal; font-variant: normal; font-weight: normal; font-stretch: normal;  line-height: normal; font-family: Arial, Helvetica, sans-serif; text-align: left; color: rgb(19, 27, 77); letter-spacing: 3px; text-decoration: none; text-transform: none;">DATOS A COTIZAR</span></td>
                                    </tr>
                                    <tr>
                                        <td class="f1" style="font-family: Arial, Helvetica, sans-serif; text-align: center;"  ><span id="TxtTipoPoliza" class="f3" style="font-style: normal; font-variant: normal; font-weight: normal; font-stretch: normal;  line-height: normal; font-family: Tahoma, Geneva, sans-serif; color: rgb(21, 27, 79); width: 262px; display: inline-block;">Solo se cotizan pólizas para vehículos particulares</span></td>
                                    </tr>
                                                 <asp:ScriptManager ID="ScriptManager1" runat="server">
                                                            </asp:ScriptManager>
                                </table>
                    
                                                                <div id="Page_Control2"   >
                                                                    <table class="auto-style18" style="width: auto; height:100%;">
                                                                        <tr>
                                                                            <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Nombres:</td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="f1" style="font-family: Arial, Helvetica, sans-serif;  text-align: center;">
                                                                                <table id="ASPxPageControl1_ASPxPageControl2_TxtPrimerNombre_ET" cellpadding="0" cellspacing="0" class="dxeErrorFrame" errorframe="errorFrame" style="border-collapse: collapse; visibility: hidden;">
                                                                                    <tr>
                                                                                        <td class="f1" style="font-family: Arial, Helvetica, sans-serif;  text-align: center; visibility: visible; vertical-align: middle;">
                                                                                            <table id="ASPxPageControl1_ASPxPageControl2_TxtPrimerNombre" cellpadding="0" cellspacing="0" class="f1" style="border-collapse: collapse; border: 1px solid rgb(159, 159, 159); cursor: default; -webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Arial, Helvetica, sans-serif; text-align: left; color: rgb(19, 27, 77);  text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none; margin-bottom: 0px; width: 150px; background-color: white;">
                                                                                                <tr>
                                                                                                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif;  text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden; ">
                                                                                                        <asp:TextBox ID="txtNombre" runat="server" CssClass="dxeEditArea dxeEditAreaSys" Width="193px"   AutoCompleteType="Disabled"></asp:TextBox>  
                                                                                                       </td><td>&nbsp;&nbsp;<img alt="" class="auto-style2" src="http://testcotizador.unitypromotores.com/Cotizador/imagenes/Error.png" id="errNombre" style="visibility: hidden" /></td>
                                                                                                </tr>
                                                                                            </table>
                                                                                        </td>
                                                                                        <td id="ASPxPageControl1_ASPxPageControl2_TxtPrimerNombre_EC" class="f1" style="font-family: Tahoma, Geneva, sans-serif;  text-align: center; font-style: normal; font-variant: normal; font-weight: normal; font-stretch: normal; line-height: normal; color: red; padding-left: 4px; padding-right: 5px; vertical-align: middle;">
                                                                                            <table cellpadding="0" cellspacing="0" style="width: 33px; border-collapse: collapse;">
                                                                                                <tr>
                                                                                                    <td class="f1" style="font-family: Tahoma, Geneva, sans-serif;  text-align: center; font-style: normal; font-variant: normal; font-weight: normal; font-stretch: normal; line-height: normal; color: red; padding-right: 5px;">
                                                                                                        <img id="ASPxPageControl1_ASPxPageControl2_TxtPrimerNombre_EI" alt="" class="dxEditors_edtError" src="#" style="border-width: 0px; display: block; margin: auto; width: 14px; height: 14px; background-image: url(''); background-color: transparent; background-position: -170px 0px; background-repeat: no-repeat;" /></td>
                                                                                                    <td id="ASPxPageControl1_ASPxPageControl2_TxtPrimerNombre_ETC" class="f1" style="font-family: Tahoma, Geneva, sans-serif;  text-align: center; font-style: normal; font-variant: normal; font-weight: normal; font-stretch: normal; line-height: normal; color: red; width: 14px; white-space: nowrap;"></td>
                                                                                                </tr>
                                                                                            </table>
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                            </td>
                                                                        </tr>
                                                                                                                                                     <tr>
                                                                            <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Apellidos:</td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="f1" style="font-family: Arial, Helvetica, sans-serif;  text-align: center;">
                                                                                <table id="ASPxPageControl1_ASPxPageControl2_TxtPrimerNombre_ET" cellpadding="0" cellspacing="0" class="dxeErrorFrame" errorframe="errorFrame" style="border-collapse: collapse; visibility: hidden;">
                                                                                    <tr>
                                                                                        <td class="f1" style="font-family: Arial, Helvetica, sans-serif;  text-align: center; visibility: visible; vertical-align: middle;">
                                                                                            <table id="ASPxPageControl1_ASPxPageControl2_TxtPrimerNombre" cellpadding="0" cellspacing="0" class="f1" style="border-collapse: collapse; border: 1px solid rgb(159, 159, 159); cursor: default; -webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Arial, Helvetica, sans-serif; text-align: left; color: rgb(19, 27, 77);  text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none; margin-bottom: 0px; width: 150px; background-color: white;">
                                                                                                <tr>
                                                                                                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif;  text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden; ">
                                                                                                        <asp:TextBox ID="txtApellido" runat="server" CssClass="dxeEditArea dxeEditAreaSys" Width="193px"   AutoCompleteType="Disabled"></asp:TextBox>  
                                                                                                       </td><td>&nbsp;&nbsp;<img alt="" class="auto-style2" src="http://testcotizador.unitypromotores.com/Cotizador/imagenes/Error.png" id="errApellido" style="visibility: hidden" /></td>
                                                                                                </tr>
                                                                                            </table>
                                                                                        </td>
                                                                                        <td id="ASPxPageControl1_ASPxPageControl2_TxtPrimerNombre_EC" class="f1" style="font-family: Tahoma, Geneva, sans-serif;  text-align: center; font-style: normal; font-variant: normal; font-weight: normal; font-stretch: normal; line-height: normal; color: red; padding-left: 4px; padding-right: 5px; vertical-align: middle;">
                                                                                            <table cellpadding="0" cellspacing="0" style="width: 33px; border-collapse: collapse;">
                                                                                                <tr>
                                                                                                    <td class="f1" style="font-family: Tahoma, Geneva, sans-serif;  text-align: center; font-style: normal; font-variant: normal; font-weight: normal; font-stretch: normal; line-height: normal; color: red; padding-right: 5px;">
                                                                                                        <img id="ASPxPageControl1_ASPxPageControl2_TxtPrimerNombre_EI" alt="" class="dxEditors_edtError" src="#" style="border-width: 0px; display: block; margin: auto; width: 14px; height: 14px; background-image: url(''); background-color: transparent; background-position: -170px 0px; background-repeat: no-repeat;" /></td>
                                                                                                    <td id="ASPxPageControl1_ASPxPageControl2_TxtPrimerNombre_ETC" class="f1" style="font-family: Tahoma, Geneva, sans-serif;  text-align: center; font-style: normal; font-variant: normal; font-weight: normal; font-stretch: normal; line-height: normal; color: red; width: 14px; white-space: nowrap;"></td>
                                                                                                </tr>
                                                                                            </table>
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                            </td>
                                                                        </tr>                                                                      <tr>
                                                                            <td class="f4" style="font-family: Roboto;  text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Fecha de Nacimiento:</td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="f1" style="font-family: Arial, Helvetica, sans-serif;  text-align: left; float:left;">
                                                                                <table id="ASPxPageControl1_ASPxPageControl2_txtcorreo_ET" cellpadding="0" cellspacing="0" errorframe="errorFrame" style="border-collapse: collapse;">
                                                                                    <tr>
                                                                                        <td id="ASPxPageControl1_ASPxPageControl2_txtcorreo_CC" class="f1" style="font-family: Arial, Helvetica, sans-serif;   text-align: center;">
                                                                                            <table id="ASPxPageControl1_ASPxPageControl2_txtcorreo" cellpadding="0" cellspacing="0" class="f1" style="border-collapse: collapse; border: 1px solid rgb(159, 159, 159); cursor: default; -webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Arial, Helvetica, sans-serif; text-align: left; color: rgb(19, 27, 77);  text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none; margin-bottom: 0px; width: 150px; background-color: white;">
                                                                                                <tr>
                                                                                                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif;   text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                                                                                                        <asp:HiddenField ID="HiddenField1" runat="server" />
                                                                                                        <input id="nacimiento" type="date" onchange="LlenarFecha()" />
                                                                                                         </td><td>&nbsp;&nbsp;<img alt="" class="auto-style2" src="http://testcotizador.unitypromotores.com/Cotizador/imagenes/Error.png" id="errFecha" style="visibility: hidden" /></td>
                                                                                                    </td>
                                                                                                </tr>
                                                                                            </table>
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                            </td>
                                                                        </tr> 
                                                                        <tr>
                                                                            <td class="f4" style="font-family: Roboto;  text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Email:</td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="f1" style="font-family: Arial, Helvetica, sans-serif;  text-align: center;" class="auto-style1">
                                                                                <table id="ASPxPageControl1_ASPxPageControl2_TxtPrimerApellido_ET" cellpadding="0" cellspacing="0" class="dxeErrorFrame" errorframe="errorFrame" style="border-collapse: collapse; visibility: hidden;">
                                                                                    <tr>
                                                                                        <td class="f1" style="font-family: Arial, Helvetica, sans-serif;   text-align: center; visibility: visible; vertical-align: middle;">
                                                                                            <table id="ASPxPageControl1_ASPxPageControl2_TxtPrimerApellido" cellpadding="0" cellspacing="0" class="f1" style="border-collapse: collapse; border: 1px solid rgb(159, 159, 159); cursor: default; -webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Arial, Helvetica, sans-serif; text-align: left; color: rgb(19, 27, 77);  text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none; margin-bottom: 0px; width: 150px; background-color: white;">
                                                                                                <tr>
                                                                                                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif;   text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                                                                                                    <asp:TextBox ID="txtCorreo" runat="server" CssClass="dxeEditArea dxeEditAreaSys" Width="193px" AutoCompleteType="Disabled"></asp:TextBox>  
                                                                                                         </td><td class="auto-style8">&nbsp;&nbsp;<img alt="" class="auto-style2" src="http://testcotizador.unitypromotores.com/Cotizador/imagenes/Error.png" id="errCorreo" style="visibility: hidden" /></td>
                                                                                                
                                                                                                </tr>
                                                                                            </table>
                                                                                        </td>
                                                                                        <td id="ASPxPageControl1_ASPxPageControl2_TxtPrimerApellido_EC" class="f1" style="font-family: Tahoma, Geneva, sans-serif;  text-align: center; font-style: normal; font-variant: normal; font-weight: normal; font-stretch: normal; line-height: normal; color: red; padding-left: 4px; padding-right: 5px; vertical-align: middle;">
                                                                                            <table cellpadding="0" cellspacing="0" style="width: 33px; border-collapse: collapse;">
                                                                                                <tr>
                                                                                                    <td class="f1" style="font-family: Tahoma, Geneva, sans-serif;   text-align: center; font-style: normal; font-variant: normal; font-weight: normal; font-stretch: normal; line-height: normal; color: red; padding-right: 5px;">
                                                                                                        <img id="ASPxPageControl1_ASPxPageControl2_TxtPrimerApellido_EI" alt="" class="dxEditors_edtError" src="#" style="border-width: 0px; display: block; margin: auto; width: 14px; height: 14px; background-image: url(''); background-color: transparent; background-position: -170px 0px; background-repeat: no-repeat;" /></td>
                                                                                                    <td id="ASPxPageControl1_ASPxPageControl2_TxtPrimerApellido_ETC" class="f1" style="font-family: Tahoma, Geneva, sans-serif;   text-align: center; font-style: normal; font-variant: normal; font-weight: normal; font-stretch: normal; line-height: normal; color: red; width: 14px; white-space: nowrap;"></td>
                                                                                                </tr>
                                                                                            </table>
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                            </td>
                                                                        </tr>
                                                                                                                                                       <tr>
                                                                            <td class="f4" style="font-family: Roboto;   text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Telefono:</td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="f1" style="font-family: Arial, Helvetica, sans-serif;   text-align: left; float:left;">
                                                                                <table id="ASPxPageControl1_ASPxPageControl2_TxtPrimerApellido" cellpadding="0" cellspacing="0" class="f1" style="border-collapse: collapse; border: 1px solid rgb(159, 159, 159); cursor: default; -webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Arial, Helvetica, sans-serif; text-align: left; color: rgb(19, 27, 77);  text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none; margin-bottom: 0px; width: 150px; background-color: white;">
                                                                                    <tr>
                                                                                        <td class="f0" style="font-family: Arial, Helvetica, sans-serif;  text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                                                                                                     <asp:TextBox ID="txtTelefono" runat="server" CssClass="dxeEditArea dxeEditAreaSys"  onkeypress="return isNumberKey(event)" Width="193px" MaxLength="8" AutoCompleteType="Disabled"></asp:TextBox> 
                                                                                                         </td><td>&nbsp;&nbsp;<img alt="" class="auto-style2" src="http://testcotizador.unitypromotores.com/Cotizador/imagenes/Error.png" id="errTelefono" style="visibility: hidden" /></td>

                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                            </td>
                                                                        </tr>
                                                                    
                                                                        <tr>
                                                                            <td class="f4" style="font-family: Roboto;  text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Tipo de Vehiculo:</td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="f1" style="font-family: Arial, Helvetica, sans-serif;   text-align: left; float:left;">
                                                                                              <asp:DropDownList ID="cmbTipoVehiculo" runat="server" Width="215px"></asp:DropDownList>

                                                                            </td>
                                                                        </tr>
                                                                       <tr>
                                                                            <td class="f4" style="font-family: Roboto;   text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;"><a>Marca:</a></td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="f1" style="font-family: Arial, Helvetica, sans-serif;  text-align: left; float:left;">
                                                                                <table id="ASPxPageControl1_ASPxPageControl2_sexo" cellpadding="0" cellspacing="0" class="f1" style="border: 1px solid rgb(159, 159, 159); font-style: normal; font-variant: normal; font-weight: normal; font-stretch: normal;   line-height: normal; font-family: Tahoma, Geneva, sans-serif; cursor: default; -webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: auto; height: 15px; border-collapse: separate;">
                                                                                    <tr>
                                                                                        <td class="f1" style="font-family: Arial, text-align:"left" Helvetica, sans-serif;  text-align: center; padding: 0px;">
                                                                                            <asp:DropDownList ID="cmbMarca" runat="server" Width="215px"  ClientIDMode="Static"  onchange="Marca()" ></asp:DropDownList>
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                            </td>
                                                                        </tr>
                                                                       <div id="Marca" style="display:none;">  
                                                                        <tr>
                                                                            <td class="f4" style="font-family: Roboto;  text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">
                                                                               <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                                                                    <ContentTemplate>
                                                                                   <a id="Marca1">Marca de su Vehiculo:</a>
                                                                                  </ContentTemplate>
                                                                                </asp:UpdatePanel>

                                                                            </td>
                                                                        </tr>
       
                                                                        <tr >
                                                                            <td class="f1" style="font-family: Arial, Helvetica, sans-serif;  text-align: left; float:left;">
                                                                               <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                                                                    <ContentTemplate>
                                                                                 <div id="Marca2">
                                                                                  <table id="ASPxPageControl1_ASPxPageControl2_txtcorreo_ET" cellpadding="0" cellspacing="0" errorframe="errorFrame" style="border-collapse: collapse;">
                                                                                    <tr>
                                                                                        <td class="f1" id="ASPxPageControl1_ASPxPageControl2_txtcorreo_CC" style="font-family: Arial, Helvetica, sans-serif;   text-align: center;">
                                                                                            <table id="ASPxPageControl1_ASPxPageControl2_TxtPrimerApellido" cellpadding="0" cellspacing="0" class="f1" style="border-collapse: collapse; border: 1px solid rgb(159, 159, 159); cursor: default; -webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Arial, Helvetica, sans-serif; text-align: left; color: rgb(19, 27, 77);  text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none; margin-bottom: 0px; width: 150px; background-color: white;">
                                                                                                <tr>
                                                                                                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                                                                                                    <asp:TextBox ID="txtMarca" runat="server" CssClass="dxeEditArea dxeEditAreaSys" Width="193px"  AutoCompleteType="Disabled"></asp:TextBox> 
                                                                                                </td><td>&nbsp;&nbsp;<img alt="" class="auto-style2" src="http://testcotizador.unitypromotores.com/Cotizador/imagenes/Error.png" id="errMarca" style="visibility: hidden" /></td>
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
                                                                           </div>      
                                                                     <tr>
                                                                            <td class="f4" style="font-family: Roboto;  text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Linea:</td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="f1" style="font-family: Arial, Helvetica, sans-serif;  text-align: left; float:left;">
                                                                                <table id="ASPxPageControl1_ASPxPageControl2_sexo" cellpadding="0" cellspacing="0" class="f1" style="border: 1px solid rgb(159, 159, 159); font-style: normal; font-variant: normal; font-weight: normal; font-stretch: normal;   line-height: normal; font-family: Tahoma, Geneva, sans-serif; cursor: default; -webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: auto; height: 15px; border-collapse: separate;">
                                                                                    <tr>
                                                                                       <td class="f0" style="font-family: Arial, Helvetica, sans-serif;  text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                                                                                         <table><tr><td><asp:TextBox ID="txtLinea" runat="server" CssClass="dxeEditArea dxeEditAreaSys"   Width="193px" AutoCompleteType="Disabled"></asp:TextBox> </td><td><img alt="" class="auto-style2" src="http://testcotizador.unitypromotores.com/Cotizador/imagenes/Error.png" id="errLinea" style="visibility: hidden" /></td></tr></table> 
                                                                                          </td>
                                                                                    </tr>
                                                                                </table>
                                                                            </td>
                                                                        </tr>
                                                                                                                                                <tr>
                                                                            <td class="f4" style="font-family: Roboto;   text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Modelo:</td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td  class="f1" style="font-family: Arial, Helvetica, sans-serif;   text-align: left; float:left;">
                                                                                <table id="ASPxPageControl1_ASPxPageControl2_sexo" cellpadding="0" cellspacing="0" class="f1" style="border: 1px solid rgb(159, 159, 159); font-style: normal; font-variant: normal; font-weight: normal; font-stretch: normal;  line-height: normal; font-family: Tahoma, Geneva, sans-serif; cursor: default; -webkit-tap-highlight-color: rgba(0, 0, 0, 0); width: auto; height: 15px; border-collapse: separate;">
                                                                                    <tr>
                                                                                        <td class="f1" style="font-family: Arial, text-align:"left" Helvetica, sans-serif;   text-align: center; padding: 0px;">
                                                                                            <asp:DropDownList ID="cmbModelo" runat="server" Width="215px"></asp:DropDownList>
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                            </td>
                                                                        </tr>
                                                                                                                                                      <tr>
                                                                            <td class="f1" style="font-family: Arial, Helvetica, sans-serif; text-align: left; float:left; height: 24px;">

                                                                                      <table><tr><td style="text-align:left;"><asp:RadioButton ID="rdSeguroCompleto" runat="server"  Text="Seguro Completo" ClientIDMode="Static" onclick="MostrarMonto()" CssClass="letra" /></td>
                                                                                          <td><img class="auto-style2" id="errDañosATerceros" src="http://testcotizador.unitypromotores.com/Cotizador/imagenes/Error.png"  style="visibility: hidden"/></td>
                                                                                          </tr></table>

                                                                            </td>
                                                                        </tr> 
                                                                        <tr>
                                                                            <td class="f1" style="font-family: Arial, Helvetica, sans-serif;  text-align: left; float:left; height: 24px;">
 
                                                                                     <table><tr><td style="text-align:left;">
                                                                                           <asp:RadioButton ID="rdResponsabilidadCivil" runat="server"  Text="Responsabilidad Civil" ClientIDMode="Static" onclick="EsconderMonto()" CssClass="letra"  />
                                                                                                <td><img class="auto-style2" id="errResponsabilidadCivil" src="http://testcotizador.unitypromotores.com/Cotizador/imagenes/Error.png" style="visibility: hidden" /></td>
                                                                                          </tr></table>
 
                                                                            </td>
                                                                        </tr>
                                                                         <tr>
                                                                            <td class="f4" style="font-family: Roboto;  text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">
                                                                               <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                                                                    <ContentTemplate>
                                                                                   <a id="Monto1">Valor del Mercado:</a>
                                                                                  </ContentTemplate>
                                                                                </asp:UpdatePanel>

                                                                            </td>
                                                                        </tr>
       
                                                                        <tr >
                                                                            <td class="f1" style="font-family: Arial, Helvetica, sans-serif;  text-align: left; float:left;">
                                                                               <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                                                                    <ContentTemplate>
                                                                                 <div id="Monto">
                                                                                  <table id="ASPxPageControl1_ASPxPageControl2_txtcorreo_ET" cellpadding="0" cellspacing="0" errorframe="errorFrame" style="border-collapse: collapse;">
                                                                                    <tr>
                                                                                        <td class="f1" id="ASPxPageControl1_ASPxPageControl2_txtcorreo_CC" style="font-family: Arial, Helvetica, sans-serif;   text-align: center;">
                                                                                            <table id="ASPxPageControl1_ASPxPageControl2_TxtPrimerApellido" cellpadding="0" cellspacing="0" class="f1" style="border-collapse: collapse; border: 1px solid rgb(159, 159, 159); cursor: default; -webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Arial, Helvetica, sans-serif; text-align: left; color: rgb(19, 27, 77);  text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none; margin-bottom: 0px; width: 150px; background-color: white;">
                                                                                                <tr>
                                                                                                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                                                                                                    <asp:TextBox ID="txtValorMercado" runat="server" CssClass="dxeEditArea dxeEditAreaSys" Width="193px" onkeypress="return isNumberKey(event)" AutoCompleteType="Disabled"></asp:TextBox> 
                                                                                                </td><td>&nbsp;&nbsp;<img alt="" class="auto-style2" src="http://testcotizador.unitypromotores.com/Cotizador/imagenes/Error.png" id="errMontoAsegurado" style="visibility: hidden" /></td>
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
                                                                        <%--   <tr>
                                                                            <td class="auto-style6" style="font-family: Roboto; font-size: 12px; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">
                                                                                   <a class="letraTitulo">Coberturas Adicionales:</a> 
                                                                             </td>
                                                                        </tr>
                                                                              <tr>
                                                                               <td class="auto-style9" style="font-family: Roboto; font-size: 15px; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">
                                                                                        <asp:CheckBox ID="chkRoboParcial" runat="server" Text="Robo parcial" CssClass="letra" AutoPostBack="True" OnCheckedChanged="chkRoboParcial_CheckedChanged"  />
                                                                                  &nbsp; <asp:ImageButton ID="ImageButton3" runat="server" 
                                                                             ImageUrl="~/imagenes/SignoInterrogacion1.png" ToolTip="Mas informacion" 
                                                                             OnClientClick="javascript:return false;" Height="15px" Width="15px" />
                                                                                        <asp:BalloonPopupExtender ID="ImageButton3_BalloonPopupExtender" runat="server" BalloonPopupControlID="Panel4" BalloonSize="Medium" CustomCssUrl="" DisplayOnClick="False" DisplayOnMouseOver="True" DynamicServicePath="" Enabled="True" ExtenderControlID="" TargetControlID="ImageButton3">
                                                                                        </asp:BalloonPopupExtender>
                                                                             <asp:BalloonPopupExtender ID="BalloonPopupExtender1" runat="server" BalloonPopupControlID="Panel3" CustomCssUrl="" DynamicServicePath="" Enabled="True" ExtenderControlID="" TargetControlID="ImageButton2" BalloonSize="Medium" DisplayOnClick="False" DisplayOnMouseOver="True">
                                                                             </asp:BalloonPopupExtender>

                                                                             </td>
                                                                        </tr>
                                                                                 <tr>
                                                                            <td class="justified_roboto" style="font-family: Roboto; font-size: 15px; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">
                                                                               <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                                                                    <ContentTemplate>
                                                                                   <a id="Robo1">Valor Estimado:</a>
                                                                                  </ContentTemplate>
                                                                                </asp:UpdatePanel>

                                                                            </td>
                                                                        </tr>
       
                                                                        <tr >
                                                                            <td style="font-family: Arial, Helvetica, sans-serif; font-size: 12px; text-align: left; float:left;">
                                                                               <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                                                                    <ContentTemplate>
                                                                                 <div id="Robo2">
                                                                                  <table id="ASPxPageControl1_ASPxPageControl2_txtcorreo_ET" cellpadding="0" cellspacing="0" errorframe="errorFrame" style="border-collapse: collapse;">
                                                                                    <tr>
                                                                                        <td id="ASPxPageControl1_ASPxPageControl2_txtcorreo_CC" style="font-family: Arial, Helvetica, sans-serif; font-size: 12px; text-align: center;">
                                                                                            <table id="ASPxPageControl1_ASPxPageControl2_TxtPrimerApellido" cellpadding="0" cellspacing="0" class="dxeTextBoxSys dxeTextBox just_morado" style="border-collapse: collapse; border: 1px solid rgb(159, 159, 159); cursor: default; -webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Arial, Helvetica, sans-serif; text-align: left; color: rgb(19, 27, 77); font-size: 12px; text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none; margin-bottom: 0px; width: 150px; background-color: white;">
                                                                                                <tr>
                                                                                                    <td class="dxic" style="font-family: Arial, Helvetica, sans-serif; font-size: 0px; text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                                                                                                    <asp:TextBox ID="txtValorEstimadoRoboParcial" runat="server" CssClass="dxeEditArea dxeEditAreaSys" Width="193px" onkeypress="return isNumberKey(event)" AutoCompleteType="Disabled"></asp:TextBox> 
                                                                                                </td><td>&nbsp;&nbsp;<img alt="" class="auto-style2" src="http://testcotizador.unitypromotores.com/Cotizador/imagenes/Error.png" id="errRoboParcial" style="visibility: hidden" /></td>
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
                                                                                    <td class="justified_roboto" style="font-family: Roboto; font-size: 15px; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">
                                                                                        <asp:CheckBox ID="chkMenores16" runat="server" Text="Menores. Coberturas desde 16  años" CssClass="letra" />
                                                                            &nbsp; <asp:ImageButton ID="btnAyudaTipoServicio" runat="server" 
                                                                             ImageUrl="~/imagenes/SignoInterrogacion1.png" ToolTip="Mas informacion" 
                                                                             OnClientClick="javascript:return false;" Height="15px" Width="15px" />
                                                                             <asp:BalloonPopupExtender ID="btnAyudaTipoServicio_BalloonPopupExtender" 
                                                                              runat="server" BalloonPopupControlID="Panel1" 
                                                                              BalloonSize="Medium"
                                                                              DisplayOnClick="False" DisplayOnMouseOver="True" DynamicServicePath="" 
                                                                              Enabled="True" ExtenderControlID="" ScrollBars="None"
                                                                              TargetControlID="btnAyudaTipoServicio" >
                                                                             </asp:BalloonPopupExtender>
                                                                                    </td>
                                                                        </tr>
         <tr>
                                                                                    <td class="justified_roboto" style="font-family: Roboto; font-size: 15px; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">
                                                                                        <asp:CheckBox ID="chkMenores18" runat="server" Text="Menores. Coberturas desde 18 años" CssClass="letra" />
                                                                            &nbsp; <asp:ImageButton ID="ImageButton1" runat="server" 
                                                                             ImageUrl="~/imagenes/SignoInterrogacion1.png" ToolTip="Mas informacion" 
                                                                             OnClientClick="javascript:return false;" Height="15px" Width="15px" />
                                                                                        <asp:BalloonPopupExtender ID="ImageButton1_BalloonPopupExtender" runat="server" CustomCssUrl="" DynamicServicePath="" Enabled="True" ExtenderControlID="" TargetControlID="ImageButton1" BalloonPopupControlID="Panel2" DisplayOnClick="False" DisplayOnMouseOver="True" BalloonSize="Medium">
                                                                                        </asp:BalloonPopupExtender>
 
                                                                             </td>
                                                                        </tr>
         <tr>
                                                                                    <td class="auto-style9" style="font-family: Roboto; font-size: 15px; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">
                                                                                        <asp:CheckBox ID="chkExcesoRC" runat="server" Text="Exceso de RC.   (ID 5)." CssClass="letra" />
                                                                                        &nbsp;<asp:ImageButton ID="ImageButton2" runat="server" 
                                                                             ImageUrl="~/imagenes/SignoInterrogacion1.png" ToolTip="Mas informacion" 
                                                                             OnClientClick="javascript:return false;" Height="15px" Width="15px" />
                                                                                        <asp:BalloonPopupExtender ID="ImageButton2_BalloonPopupExtender" runat="server" BalloonPopupControlID="Panel3" CustomCssUrl="" DynamicServicePath="" Enabled="True" ExtenderControlID="" TargetControlID="ImageButton2">
                                                                                        </asp:BalloonPopupExtender>
                                                                             </td>
                                                                        </tr>--%>
                 <tr>
                                                                                    <td class="f4" style="font-family: Roboto;  text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">
                                                                                        <a  class="letraTitulo">Como desea ser contactado?
                                                                                       
                                                                                    </td>
                                                                        </tr>
                         <tr>
                                                                                    <td class="f4" style="font-family: Roboto;  text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">
                                                                                        <asp:CheckBox ID="chkChat" runat="server" Text="Chat" /> 
                                                                                        &nbsp;&nbsp; <img alt="" class="auto-style2" src="http://testcotizador.unitypromotores.com/Cotizador/imagenes/Error.png" id="errChk1" style="visibility: hidden" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:CheckBox ID="chkTelefono" runat="server" Text="Telefono" />
                                                                                        <img alt="" class="auto-style2" src="http://testcotizador.unitypromotores.com/Cotizador/imagenes/Error.png" id="errChk2" style="visibility: hidden" /></td>
                                                                        </tr>
                         <tr>
                                                                                    <td class="f4" style="font-family: Roboto;  text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">
                                                                                        <a  class="letraTitulo">En qué horario desea ser contactado?
                                                                                       
                                                                                    </td>
                                                                        </tr>
                                 <tr>
                                                                                    <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">
                                                               <asp:DropDownList ID="cmbHora" runat="server" Width="215px">
                                                                   <asp:ListItem>Inmediatamente</asp:ListItem>
                                                                   <asp:ListItem>8 AM</asp:ListItem>
                                                                   <asp:ListItem>9 AM</asp:ListItem>
                                                                   <asp:ListItem>10 AM</asp:ListItem>
                                                                   <asp:ListItem>11 AM</asp:ListItem>
                                                                   <asp:ListItem>12 AM</asp:ListItem>
                                                                   <asp:ListItem>1 PM</asp:ListItem>
                                                                   <asp:ListItem>2 PM</asp:ListItem>
                                                                   <asp:ListItem>3 PM</asp:ListItem>
                                                                   <asp:ListItem>4 PM</asp:ListItem>
                                                                   <asp:ListItem>5 PM</asp:ListItem>
                                                                                        </asp:DropDownList>
                                                                                      &nbsp;&nbsp;<img alt="" class="auto-style2" src="http://testcotizador.unitypromotores.com/Cotizador/imagenes/Error.png" id="errHora" style="visibility: hidden" /></td>
                                                                        </tr>
         
                                                                        <tr>
                                                                            <td class="f5" style="font-family: Arial, Helvetica, sans-serif;   text-align: center;" class="auto-style7"><span id="ASPxPageControl1_ASPxPageControl2_ASPxLabel2" class="f1" style="font-style: normal; font-variant: normal; font-weight: normal; font-stretch: normal;   line-height: normal; font-family: Tahoma, Geneva, sans-serif;">
                                                                                <table id="ASPxPageControl1_ASPxPageControl2_BtnSiguiente" cellpadding="0" cellspacing="0" style="height: 35px; width: 103px; border-collapse: separate;">
                                                                                    <tr>
                                                                                       <td style="text-align:center"> 
 
                                                                                                    
                                                                                                   <asp:Button ID="Button1" runat="server" BackColor="White" BorderColor="#336699" BorderStyle="Solid" BorderWidth="1px" CssClass="btn" Height="100%" OnClick="Button1_Click" Text="Cotizar" Width="100%"  />
                                                                                             
 
                                                                                        </td>
                                                                                     
                                                                                    </tr>
                                                                                </table>
                                                                           </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="f1" style="font-family: Arial, Helvetica, sans-serif;   text-align: center;">
                                                                                
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    <div style="float:left; text-align:left;">
                                                                        <asp:Label ID="lblMsg" runat="server" Text="." ForeColor="Red"></asp:Label>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                            
                                                   
                                                        <b class="f0" style="display: block; clear: both; height: 0px; width: 0px;  line-height: 0; overflow: hidden; visibility: hidden;"></b>

        </td></tr></table>
 
  </div>  
     <div id="Asoc2" class="divX">
       <ul style="width:280px;">
    <li></li> 
    <li></li>
    <li></li>
    <li></li>
    <li></li>
    <li></li> 
    <li></li>
    <li></li>
    <li></li>
    <li></li>
    <li><div class="cuadro" style="text-align:right;"><asp:Image ID="Image5" CssClass="cuadro" runat="server" Height="94px" ImageUrl="http://testcotizador.unitypromotores.com/Cotizador/imagenes/citibank-logo.png" Width="94px" /></div></li> 
       </ul>
    </div>
    
</div>     


 
    </form>

    <script type="text/javascript">
        function isNumberKey(evt) {
            var charCode = (evt.which) ? evt.which : event.keyCode
            if (charCode != 46 && charCode > 31
              && (charCode < 48 || charCode > 57))
                return false;

            return true;
        }

        $(document).ready(function () {

            var Completo = document.getElementById("rdSeguroCompleto").checked;
            var Civil = document.getElementById("rdResponsabilidadCivil").checked;


            if (Completo == true && Civil == false) {

                document.getElementById("Monto").style.display = "inline";
                document.getElementById("Monto1").style.display = "inline";
                document.getElementById("Monto").style.visibility = "visible";
                document.getElementById("Monto1").style.visibility = "visible";
            }

            if (Completo == false && Civil == false) {

                document.getElementById("Monto").style.display = "none";
                document.getElementById("Monto1").style.display = "none";
                document.getElementById("Monto").style.visibility = "hidden";
                document.getElementById("Monto1").style.visibility = "hidden";
            }

            if (Completo == false && Civil == true) {

                document.getElementById("Monto").style.display = "none";
                document.getElementById("Monto1").style.display = "none";
                document.getElementById("Monto").style.visibility = "hidden";
                document.getElementById("Monto1").style.visibility = "hidden";
            }

            // ProcesarRobo();


            var _Marca = document.getElementById("cmbMarca").options[document.getElementById("cmbMarca").selectedIndex].text;

            if (_Marca != "...OTRAS MARCAS") {

                document.getElementById("Marca1").style.visibility = "hidden";
                document.getElementById("Marca1").style.display = "none";
                document.getElementById("Marca2").style.visibility = "hidden";
                document.getElementById("Marca2").style.display = "none";
            }

        });


        function EsconderMonto() {
            document.getElementById("Monto").style.display = "none";
            document.getElementById("Monto1").style.display = "none";
            document.getElementById("Monto").style.visibility = "hidden";
            document.getElementById("Monto1").style.visibility = "hidden";

            document.getElementById("rdSeguroCompleto").checked = false;
            document.getElementById("rdResponsabilidadCivil").checked = true;
            ApagarFocoRd();

        }
        function MostrarMonto() {
            document.getElementById("Monto").style.display = "inline";
            document.getElementById("Monto1").style.display = "inline";
            document.getElementById("Monto").style.visibility = "visible";
            document.getElementById("Monto1").style.visibility = "visible";
            document.getElementById("rdSeguroCompleto").checked = true;
            document.getElementById("rdResponsabilidadCivil").checked = false;
            ApagarFocoRd();;

        }

        function ProcesarRobo() {
            if (document.getElementById("chkRoboParcial").checked == true) {
                document.getElementById("Robo1").style.display = "inline";
                document.getElementById("Robo2").style.display = "inline";
                document.getElementById("Robo1").style.visibility = "visible";
                document.getElementById("Robo2").style.visibility = "visible";
            } else {
                document.getElementById("Robo1").style.display = "none";
                document.getElementById("Robo2").style.display = "none";
                document.getElementById("Robo1").style.visibility = "hidden";
                document.getElementById("Robo2").style.visibility = "hidden";
            }

        }
        function ApagarFocoRd() {
            document.getElementById("errDañosATerceros").style.visibility = "hidden";
            document.getElementById("errResponsabilidadCivil").style.visibility = "hidden";
        }
        function LlenarFecha() {
            var ver = document.getElementById("nacimiento").value;
            $("#HiddenField1").val(ver);
        }
        function Marca() {
            var _Marca = document.getElementById("cmbMarca").options[document.getElementById("cmbMarca").selectedIndex].text;

            if (_Marca != "...OTRAS MARCAS") {

                document.getElementById("Marca1").style.visibility = "hidden";
                document.getElementById("Marca1").style.display = "none";
                document.getElementById("Marca2").style.visibility = "hidden";
                document.getElementById("Marca2").style.display = "none";
            } else {
                document.getElementById("Marca1").style.visibility = "visible";
                document.getElementById("Marca1").style.display = "inline-block";
                document.getElementById("Marca2").style.visibility = "visible";
                document.getElementById("Marca2").style.display = "inline-block";

            }
        }
    </script>
</body>
</html>
