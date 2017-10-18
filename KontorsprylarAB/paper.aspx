<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="paper.aspx.cs" Inherits="KontorsprylarAB.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 146px;
        }
        .auto-style3 {
            width: 133px;
        }
        .auto-style4 {
            width: 268px;
            height: 204px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;">
        <tr>
            <td>
                <img src="Pictures/paperpicture.png" class="auto-style4" />&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
    
    <table style="width: 100%;">
        <tr>
            <td class="auto-style2">
                <asp:RadioButton ID="RadioButtonA3" Text="  A3" runat="server" />
            </td>
            <td class="auto-style3">
                <asp:RadioButton ID="RadioButtonQuantity100" Text="100-pack" runat="server" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:RadioButton ID="RadioButtonA4" Text="A4" runat="server" />
            </td>
            <td class="auto-style3">
                <asp:RadioButton ID="RadioButtonQuantity200" Text="200-pack" runat="server" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:RadioButton ID="RadioButtonA5" Text="A5" runat="server" />
            </td>
            <td class="auto-style3">
                <asp:RadioButton ID="RadioButtonQuantity300" Text="300-pack" runat="server" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    
    <asp:Button ID="ButtonAddToCart" runat="server" Text="Add to cart" />
</asp:Content>
