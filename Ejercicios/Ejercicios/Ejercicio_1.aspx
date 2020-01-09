<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio_1.aspx.cs" Inherits="Ejercicios.Ejercicio_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Distancia"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtDistanica" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Dias"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtDias" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClick="btnCalcular_Click" /></td>
                    <td>
                        <asp:Label ID="lblValor" runat="server" Text=""></asp:Label></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
