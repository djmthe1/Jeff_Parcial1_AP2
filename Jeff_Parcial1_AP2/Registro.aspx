<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Jeff_Parcial1_AP2.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: right;
            width: 266px;
        }
        .auto-style3 {
            width: 266px;
        }
        .auto-style5 {
            text-align: right;
            width: 262px;
        }
        .auto-style6 {
            margin-left: 6px;
        }
        .auto-style7 {
            width: 262px;
        }
        .auto-style8 {
            text-align: right;
        }
        .auto-style9 {
            text-align: center;
        }
        .auto-style10 {
            text-align: left;
        }
        .auto-style11 {
            width: 233px;
        }
        .auto-style12 {
            width: 280px;
        }
        .auto-style13 {
            width: 132px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Id</td>
                <td class="auto-style13">
                    <asp:TextBox ID="IdTextBox" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="BuscarButton" runat="server" Text="Buscar" style="width: 56px" OnClick="BuscarButton_Click" />
                </td>
            </tr>
        </table>
    
    </div>
    <table style="width:100%;">
        <tr>
            <td class="auto-style5">Razon</td>
            <td>
                <asp:TextBox ID="RazonTextBox" runat="server" CssClass="auto-style6"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <table style="width:100%;">
        <tr>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style12">Material&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Cantidad</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style12">
                <asp:TextBox ID="MaterialTextBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="CantidadTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="AgregarButton" runat="server" Text="Agregar" OnClick="AgregarButton_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style12">
                <asp:GridView ID="MaterialesGridView" runat="server" Width="276px" AutoGenerateColumns="False">
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
        <table style="width:100%;">
            <tr>
                <td class="auto-style8">
                    <asp:Button ID="NuevoButton" runat="server" Text="Nuevo" OnClick="NuevoButton_Click" />
                </td>
                <td class="auto-style9">
                    <asp:Button ID="GuardarButton" runat="server" Text="Guardar" OnClick="GuardarButton_Click" />
                </td>
                <td class="auto-style10">
                    <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" OnClick="EliminarButton_Click" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
    </body>
</html>
