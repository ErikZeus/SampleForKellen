<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Paso2.aspx.cs" Inherits="Cotizador.Paso2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Cotización El Roble</title>
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
       <td>
           <asp:HyperLink ID="HyperLink2" runat="server">
           <asp:Image ID="Image2" runat="server" /></asp:HyperLink></td><td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
       <td>
               <asp:HyperLink ID="HyperLink3" runat="server">
               <asp:Image ID="Image3" runat="server" /></asp:HyperLink></td></tr></table>
   </div>
                <br /><br /><br />
        <div style="text-align:center; width:100%; height:100%"><span id="TxtTitulo" class="f2" style="font-style: normal; font-variant: normal; font-weight: bold; font-stretch: normal;  line-height: normal; 
font-family: Arial, Helvetica, sans-serif; text-align: left; color: rgb(19, 27, 77); letter-spacing: 3px; text-decoration: none; 
text-transform: none;">Paso 2</span> </div>
     <div class="pageCenter" >
       <asp:Panel ID="Panel1" runat="server" >
       </asp:Panel>
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

