<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Agradecimiento.aspx.cs" Inherits="Cotizador.Agradecimiento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width,height=device-height,initial-scale=1.0" />
    <title></title>
    <style>
        @media screen and (max-device-height: 150px) {

            body {
                zoom: 100%;
            }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <div style="background-image:url('http://testcotizador.unitypromotores.com/Cotizador/imagenes/Agradecimiento/Agradecimiento1.jpg'); height: 862px; background-size:contain; background-repeat: no-repeat; background-attachment: fixed; width: 562px;">
            <table style="width:562px;">
                <tr><td colspan="2">
                    &nbsp;</td></tr>
                <tr><td colspan="2" style="text-align:center;">
                    <asp:Label ID="lblCorreo0" runat="server" Font-Bold="True" Font-Names="Candara" Font-Size="X-Large" ForeColor="White" Text="Correo">Gracias por confiar en:</asp:Label></td></tr>
                <tr><td colspan="2" style="text-align:center;">
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/Agradecimiento/Unity Promotores- Logo en blanco.png" Width="387px" />&nbsp;&nbsp;&nbsp;</td></tr>
                <tr><td colspan="2" style="text-align:center;">
                    <asp:Label ID="lblCorreo1" runat="server" Font-Bold="True" Font-Names="Candara" Font-Size="X-Large" ForeColor="White" Text="Correo">La propuesta ha sido enviada</asp:Label>
                    </td></tr>
                <tr><td colspan="2" style="text-align:center;"><asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Candara" Font-Size="X-Large" ForeColor="White" Text="Correo">a su correo personal exitosamente</asp:Label></td></tr>
                <tr><td colspan="2" style="text-align:center;"><a style="color:white;">@   </a><asp:Label ID="lblCorreo" runat="server" Font-Bold="True" Font-Names="Candara" Font-Size="X-Large" ForeColor="White" Text="Correo">Correo</asp:Label></td></tr>
                <tr><td style="text-align:center;"><asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Candara" Font-Size="X-Large" ForeColor="White" Text="Correo">En breve un ejecutivo lo estara</asp:Label></td></tr>
                <tr><td style="text-align:center;"><asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Candara" Font-Size="X-Large" ForeColor="White" Text="Correo">contactando</asp:Label></td></tr>
                <tr><td style="text-align:center;"><a style="color:white;">&#9743;   </a><asp:Label ID="lblTelefono" runat="server" Font-Bold="True" Font-Names="Candara" Font-Size="X-Large" ForeColor="White" Text="Telefono">Telefono</asp:Label></td></tr>
   </table>

         </div>
    </form>

</body>
</html>
