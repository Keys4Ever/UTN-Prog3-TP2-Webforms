<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ejercicio2B.aspx.cs" Inherits="TP2_Grupo_8.ejercicio2B" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 23px;
        }
        .auto-style3 {
            width: 23px;
            height: 58px;
        }
        .auto-style4 {
            height: 58px;
        }
        .auto-style5 {
            width: 23px;
            height: 37px;
        }
        .auto-style6 {
            height: 37px;
        }
        .auto-style9 {
            height: 58px;
            width: 175px;
        }
        .auto-style10 {
            width: 175px;
        }
        .auto-style11 {
            height: 37px;
            width: 175px;
        }
        .auto-style12 {
            width: 23px;
            height: 31px;
        }
        .auto-style13 {
            height: 31px;
            width: 175px;
        }
        .auto-style14 {
            height: 31px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style9">
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="X-Large" Text="Resumen"></asp:Label>
                    </td>
                    <td class="auto-style4"></td>
                    <td class="auto-style4"></td>
                    <td class="auto-style4"></td>
                    <td class="auto-style4"></td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style10">
                        <asp:Label ID="Label3" runat="server" Font-Names="Arial" Text="Nombre:    "></asp:Label>
                        <asp:Label ID="txtNombre" runat="server" Font-Names="Arial Black"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style10">
                        <asp:Label ID="Label4" runat="server" Font-Names="Arial" Text="Apellido:    "></asp:Label>
                        <asp:Label ID="txtApellido" runat="server" Font-Names="Arial Black"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style10">
                        <asp:Label ID="Label5" runat="server" Font-Names="Arial" Text="Zona:       "></asp:Label>
                        <asp:Label ID="txtCiudad" runat="server" Font-Names="Arial Black"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style11">
                        <asp:Label ID="Label6" runat="server" Font-Names="Arial" Text="Los temas elegidos son:"></asp:Label>
                    </td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                </tr>
                <tr>
                    <td class="auto-style12"></td>
                    <td class="auto-style13">
                        <asp:Label ID="txtTemas" runat="server" Font-Names="Arial Black" EnableViewState="False"></asp:Label>
                    </td>
                    <td class="auto-style14"></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style14"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style10">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
