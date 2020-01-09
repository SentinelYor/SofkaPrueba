<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ejercicio_2.aspx.cs" Inherits="Ejercicios.ejercicio_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>BOING 747</h3>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Peso"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtPeso" runat="server" Text=""></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btningresar" runat="server" Text="Ingresar" OnClick="btningresar_Click" /></td>
                    <td>
                        <asp:Label ID="lblMessage" ForeColor="Red" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Total bultos:"></asp:Label></td>
                    <td>
                        <asp:Label ID="lblTotalCantidad" runat="server" Text="0"></asp:Label></td>
                              <td>
                        <asp:Label ID="Label7" runat="server" Text="Total Peso bultos:"></asp:Label></td>
                    <td>
                        <asp:Label ID="lblTotalPesoBultos" runat="server" Text="0"></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Bulto mas pesado:"></asp:Label></td>
                    <td>
                        <asp:Label ID="lblBultoPesado" runat="server" Text="0"></asp:Label></td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Bulto mas liviano:"></asp:Label></td>
                    <td>
                        <asp:Label ID="lblBultoLiviano" runat="server" Text="0"></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Peso promedio Bulto"></asp:Label></td>
                    <td>
                        <asp:Label ID="lblPromedioBultos" runat="server" Text="0"></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Ingreso Pesos Carga:"></asp:Label></td>
                    <td>
                        <asp:Label ID="lblPesos" runat="server" Text="0"></asp:Label></td>
                    <td>
                        <asp:Label ID="Label8" runat="server" Text="Ingreso Dolares Carga:"></asp:Label></td>
                    <td>
                        <asp:Label ID="lblDolares" runat="server" Text="0"></asp:Label></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
