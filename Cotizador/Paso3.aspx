<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Paso3.aspx.cs" Inherits="Cotizador.Paso3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Cotización El Roble</title>
    <script src="js/jquery.min.js"></script>
    <script src="js/jquery.js"></script>
    <link rel="stylesheet" type="text/css" href="http://testcotizador.unitypromotores.com/Cotizador/css/Formulario1.css"/>
<style type="text/css">
    .centro {
    display: inline-block; 
    }
    .pageCenter {
     margin-left: 20%;
    float:none;
    }
 
    #Talleres { font-family: 'Lucida Sans Unicode', 'Lucida Grande', Sans-Serif; font-size: 12px; left:20%; margin: 55px; width: 550px; 
    text-align: center; border-collapse: collapse; } 
    #Talleres th { font-size: 13px; font-weight: normal; padding: 8px; background: #b9c9fe; border-top: 4px solid #aabcfe;
    border-bottom: 1px solid #fff; color:#039; }
    #Talleres td { padding: 8px; background: #e8edff; border-bottom: 1px solid #fff; color: #669; border-top: 1px solid transparent; }
    #Talleres tr:hover td { background: #d0dafd;color: #339; }
    .editar {color: black; cursor:pointer;}

</style>
</head>
<body>
    <form id="form1" runat="server">
       
   <div class="pageCenter" >
   <table style="left:auto; right:auto;"><tr><td>
       <asp:HyperLink ID="HyperLink1" runat="server">
       <asp:Image ID="Image1" runat="server" /></asp:HyperLink></td><td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
       <td style="width:200px;">
           <asp:HyperLink ID="HyperLink2" runat="server">
           <asp:Image ID="Image2" runat="server" /></asp:HyperLink></td><td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
       <td>
               <asp:HyperLink ID="HyperLink3" runat="server">
               <asp:Image ID="Image3" runat="server" /></asp:HyperLink></td></tr></table>
   </div>
              <br /><br /><br />
        <div style="text-align:center; width:100%; height:100%"><span id="Tit" class="f2" style="font-style: normal; font-variant: normal; font-weight: bold; font-stretch: normal;  line-height: normal; 
font-family: Arial, Helvetica, sans-serif; text-align: left; color: rgb(19, 27, 77); letter-spacing: 3px; text-decoration: none; 
text-transform: none;">Ultimo Paso </span>&nbsp;</div>
     <div style="text-align:center; width:100%; height:100%" >
       <asp:Panel ID="Panel1" runat="server" style="text-align:center; width:100%; height:100%" >
           <div style="text-align:center; width:100%; height:100%">  
                           <asp:HiddenField ID="HiddenField1" runat="server" />
                           <table id="Principal"  class="centered-content"><tr><td class="auto-style10"> 
                                  <table aria-multiline="True"  >
                                    <tr>
                                        <td class="f1" style="font-family: Arial, Helvetica, sans-serif;  text-align: center; "><span id="TxtTitulo" class="f2" style="font-style: normal; font-variant: normal; font-weight: normal; font-stretch: normal;  line-height: normal; font-family: Arial, Helvetica, sans-serif; text-align: left; color: rgb(19, 27, 77); letter-spacing: 3px; text-decoration: none; text-transform: none;">Ingreso de Información<asp:ScriptManager ID="ScriptManager1" runat="server">
                                            </asp:ScriptManager>
                                            </span></td>
                                    </tr>
                                    <tr>
                                        <td class="f1" style="font-family: Arial, Helvetica, sans-serif; text-align: center;"  ><span id="TxtTipoPoliza" class="f3" style="font-style: normal; font-variant: normal; font-weight: normal; font-stretch: normal;  line-height: normal; font-family: Tahoma, Geneva, sans-serif; color: rgb(21, 27, 79); width: 262px; display: inline-block;">Datos Complementarios ASR27&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
                                    </tr>
        

                                </table>
                    
                                                                <div id="Page_Control2"   >
                                                                    <table class="auto-style18" style="width: auto; height:100%;">
                                                                        <tr>
                                                                            <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Nit:</td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="f1" style="font-family: Arial, Helvetica, sans-serif;  text-align: center;">
                                                                                <table id="ASPxPageControl1_ASPxPageControl2_TxtPrimerNombre_ET" cellpadding="0" cellspacing="0" class="dxeErrorFrame" errorframe="errorFrame" style="border-collapse: collapse; visibility: hidden;">
                                                                                    <tr>
                                                                                        <td class="f1" style="font-family: Arial, Helvetica, sans-serif;  text-align: center; visibility: visible; vertical-align: middle;">
                                                                                            <table id="ASPxPageControl1_ASPxPageControl2_TxtPrimerNombre" cellpadding="0" cellspacing="0" class="f1" style="border-collapse: collapse; border: 1px solid rgb(159, 159, 159); cursor: default; -webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Arial, Helvetica, sans-serif; text-align: left; color: rgb(19, 27, 77);  text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none; margin-bottom: 0px; width: 150px; background-color: white;">
                                                                                                <tr>
                                                                                                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif;  text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden; ">
                                                                                                        <asp:TextBox ID="txtNit" runat="server" CssClass="dxeEditArea dxeEditAreaSys" Width="193px"   AutoCompleteType="Disabled"></asp:TextBox>  
                                                                                                       </td><td>&nbsp;&nbsp;<img alt="" class="auto-style2" src="http://testcotizador.unitypromotores.com/Cotizador/imagenes/Error.png" id="errNit" style="visibility: hidden" /></td>
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
                                                                            <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Dpi:</td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="f1" style="font-family: Arial, Helvetica, sans-serif;  text-align: center;">
                                                                                <table id="ASPxPageControl1_ASPxPageControl2_TxtPrimerNombre_ET" cellpadding="0" cellspacing="0" class="dxeErrorFrame" errorframe="errorFrame" style="border-collapse: collapse; visibility: hidden;">
                                                                                    <tr>
                                                                                        <td class="f1" style="font-family: Arial, Helvetica, sans-serif;  text-align: center; visibility: visible; vertical-align: middle;">
                                                                                            <table id="ASPxPageControl1_ASPxPageControl2_TxtPrimerNombre" cellpadding="0" cellspacing="0" class="f1" style="border-collapse: collapse; border: 1px solid rgb(159, 159, 159); cursor: default; -webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Arial, Helvetica, sans-serif; text-align: left; color: rgb(19, 27, 77);  text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none; margin-bottom: 0px; width: 150px; background-color: white;">
                                                                                                <tr>
                                                                                                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif;  text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden; ">
                                                                                                        <asp:TextBox ID="txtDPI" runat="server" CssClass="dxeEditArea dxeEditAreaSys" Width="193px"   AutoCompleteType="Disabled"></asp:TextBox>  
                                                                                                       </td><td>&nbsp;&nbsp;<img alt="" class="auto-style2" src="http://testcotizador.unitypromotores.com/Cotizador/imagenes/Error.png" id="errDpi" style="visibility: hidden" /></td>
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
                                                                            <td class="f4" style="font-family: Roboto; text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Pasaporte:</td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="f1" style="font-family: Arial, Helvetica, sans-serif;  text-align: center;">
                                                                                <table id="ASPxPageControl1_ASPxPageControl2_TxtPrimerNombre_ET" cellpadding="0" cellspacing="0" class="dxeErrorFrame" errorframe="errorFrame" style="border-collapse: collapse; visibility: hidden;">
                                                                                    <tr>
                                                                                        <td class="f1" style="font-family: Arial, Helvetica, sans-serif;  text-align: center; visibility: visible; vertical-align: middle;">
                                                                                            <table id="ASPxPageControl1_ASPxPageControl2_TxtPrimerNombre" cellpadding="0" cellspacing="0" class="f1" style="border-collapse: collapse; border: 1px solid rgb(159, 159, 159); cursor: default; -webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Arial, Helvetica, sans-serif; text-align: left; color: rgb(19, 27, 77);  text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none; margin-bottom: 0px; width: 150px; background-color: white;">
                                                                                                <tr>
                                                                                                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif;  text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden; ">
                                                                                                        <asp:TextBox ID="txtPasaporte" runat="server" CssClass="dxeEditArea dxeEditAreaSys" Width="193px"   AutoCompleteType="Disabled"></asp:TextBox>  
                                                                                                       </td><td>&nbsp;&nbsp;<img alt="" class="auto-style2" src="http://testcotizador.unitypromotores.com/Cotizador/imagenes/Error.png" id="errDpi" style="visibility: hidden" /></td>
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
                                                                            <td class="f4" style="font-family: Roboto;  text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Dirección:</td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="f1" style="font-family: Arial, Helvetica, sans-serif;  text-align: center;" class="auto-style1">
                                                                                <table id="ASPxPageControl1_ASPxPageControl2_TxtPrimerApellido_ET" cellpadding="0" cellspacing="0" class="dxeErrorFrame" errorframe="errorFrame" style="border-collapse: collapse; visibility: hidden;">
                                                                                    <tr>
                                                                                        <td class="f1" style="font-family: Arial, Helvetica, sans-serif;   text-align: center; visibility: visible; vertical-align: middle;">
                                                                                            <table id="ASPxPageControl1_ASPxPageControl2_TxtPrimerApellido" cellpadding="0" cellspacing="0" class="f1" style="border-collapse: collapse; border: 1px solid rgb(159, 159, 159); cursor: default; -webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Arial, Helvetica, sans-serif; text-align: left; color: rgb(19, 27, 77);  text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none; margin-bottom: 0px; width: 150px; background-color: white;">
                                                                                                <tr>
                                                                                                    <td class="f0" style="font-family: Arial, Helvetica, sans-serif;   text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                                                                                                    <asp:TextBox ID="txtDireccion" runat="server" CssClass="dxeEditArea dxeEditAreaSys" Width="193px" AutoCompleteType="Disabled"></asp:TextBox>  
                                                                                                         </td><td class="auto-style8">&nbsp;&nbsp;<img alt="" class="auto-style2" src="http://testcotizador.unitypromotores.com/Cotizador/imagenes/Error.png" id="errDireccion" style="visibility: hidden" /></td>
                                                                                                
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
                                                                            <td class="f4" style="font-family: Roboto;   text-align: left; color: rgb(19, 27, 77); text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none;">Zona:</td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="f1" style="font-family: Arial, Helvetica, sans-serif;   text-align: left; float:left;">
                                                                                <table id="ASPxPageControl1_ASPxPageControl2_TxtPrimerApellido" cellpadding="0" cellspacing="0" class="f1" style="border-collapse: collapse; border: 1px solid rgb(159, 159, 159); cursor: default; -webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: Arial, Helvetica, sans-serif; text-align: left; color: rgb(19, 27, 77);  text-decoration: none; font-weight: normal; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; text-transform: none; margin-bottom: 0px; width: 150px; background-color: white;">
                                                                                    <tr>
                                                                                        <td class="f0" style="font-family: Arial, Helvetica, sans-serif;  text-align: center; width: 142px; padding: 3px 3px 2px; overflow: hidden;">
                                                                                                     <asp:TextBox ID="txtZona" runat="server" CssClass="dxeEditArea dxeEditAreaSys"  onkeypress="return isNumberKey(event)" Width="193px" MaxLength="8" AutoCompleteType="Disabled"></asp:TextBox> 
                                                                                                         </td><td>&nbsp;&nbsp;<img alt="" class="auto-style2" src="http://testcotizador.unitypromotores.com/Cotizador/imagenes/Error.png" id="errZona" style="visibility: hidden" /></td>

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
                                                                                        Municipio<a id="Marca1">:</a>
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
                                                                                                    <asp:TextBox ID="txtMunicipio" runat="server" CssClass="dxeEditArea dxeEditAreaSys" Width="193px"  AutoCompleteType="Disabled"></asp:TextBox> 
                                                                                                </td><td>&nbsp;&nbsp;<img alt="" class="auto-style2" src="http://testcotizador.unitypromotores.com/Cotizador/imagenes/Error.png" id="errMunicipio" style="visibility: hidden" /></td>
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
                                                                            <td class="f5" style="font-family: Arial, Helvetica, sans-serif;   text-align: center;" class="auto-style7"><span id="ASPxPageControl1_ASPxPageControl2_ASPxLabel2" class="f1" style="font-style: normal; font-variant: normal; font-weight: normal; font-stretch: normal;   line-height: normal; font-family: Tahoma, Geneva, sans-serif;">
                                                                                <table id="ASPxPageControl1_ASPxPageControl2_BtnSiguiente" cellpadding="0" cellspacing="0" style="height: 35px; width: 103px; border-collapse: separate;">
                                                                                    <tr>
                                                                                       <td style="text-align:center"> 
 
                                                                                                    
                                                                                                   <asp:Button ID="Button1" runat="server" BackColor="White" BorderColor="#336699" BorderStyle="Solid" BorderWidth="1px" CssClass="btn" Height="100%" OnClick="Button1_Click" Text="Guardar" Width="100%"  />
                                                                                             
 
                                                                                        </td>
                                                                                     
                                                                                    </tr>
                                                                                </table>
                                                                           </td>
                                                                        </tr>
                                                                           <tr><td style="text-align:left;"><p><a style="color:red; font-size:30px;">*</a>La inspección fisica del vehiculo <br /> &nbsp;&nbsp;es necesaria para que quede asegurado.</p></td></tr>
                                                                           </div>      
                                                             
                                                                       </table>
 </div>
       </asp:Panel>
     </div>
        </form>
    </body>
    <script type="text/javascript">

        window.onload = function () {


        };

</script>
</html>

