<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ejercicio1.aspx.cs" Inherits="TP2_Grupo_8.ejercicio1" %>

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
            width: 30px;
        }
        .auto-style3 {
            width: 239px;
        }
        .auto-style4 {
            width: 271px;
        }
        .auto-style5 {
            width: 90px;
        }
        .auto-style6 {
            width: 194px;
        }
        .auto-style7 {
            width: 30px;
            height: 26px;
        }
        .auto-style8 {
            width: 239px;
            height: 26px;
        }
        .auto-style9 {
            width: 271px;
            height: 26px;
        }
        .auto-style10 {
            width: 90px;
            height: 26px;
        }
        .auto-style11 {
            width: 194px;
            height: 26px;
        }
        .auto-style12 {
            height: 26px;
        }
        .auto-style13 {
            width: 30px;
            height: 31px;
        }
        .auto-style14 {
            width: 239px;
            height: 31px;
        }
        .auto-style15 {
            width: 271px;
            height: 31px;
        }
        .auto-style18 {
            height: 31px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style8">
                        <asp:Label ID="lblProducto1" runat="server" Font-Size="14pt" Text="Ingrese nombre del producto:"></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <asp:TextBox ID="txtBxProducto1" runat="server" Font-Size="13.5pt" OnTextChanged="txtBxProducto1_TextChanged" Width="173px"></asp:TextBox>
                    </td>
                    <td class="auto-style10">
                        <asp:Label ID="lblCantidad1" runat="server" Font-Size="14pt" Text="Cantidad:"></asp:Label>
                    </td>
                    <td class="auto-style11">
                        <asp:TextBox ID="txtBxCantidad1" runat="server" AutoPostBack="True" Font-Size="13.5pt" OnTextChanged="txtBxCantidad1_TextChanged"></asp:TextBox>
                    </td>
                    <td class="auto-style12"></td>
                    <td class="auto-style12"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13"></td>
                    <td class="auto-style14">
                        <asp:Label ID="lblProducto2" runat="server" Font-Size="14pt" Text="Ingrese nombre del producto:"></asp:Label>
                    </td>
                    <td class="auto-style15">
                        <asp:TextBox ID="txtBxProducto2" runat="server" Font-Size="13.5pt" OnTextChanged="txtBxProducto2_TextChanged" Width="173px"></asp:TextBox>
                    </td>
                  
                    <td class="auto-style18">
                        <asp:Label ID="lblCantidad2" runat="server" Font-Size="14pt" Text="Cantidad:"></asp:Label>
                    </td>
                    <td class="auto-style18">
                        <asp:TextBox ID="txtBxCantidad2" runat="server" AutoPostBack="True" Font-Size="13.5pt" OnTextChanged="txtBxCantidad2_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
