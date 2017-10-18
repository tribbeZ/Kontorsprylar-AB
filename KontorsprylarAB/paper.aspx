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
                &nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:RadioButtonList runat="server" ID="PaperFormat" RepeatDirection="Vertical"  RepeatLayout="Flow">
                <asp:ListItem Text="A3 (3 kr per ark)" Value="A3"></asp:ListItem>
                <asp:ListItem Text="A4 (2 kr per ark)" Value="A4"></asp:ListItem>
                <asp:ListItem Text="A5 (1 kr per ark)" Value="A5"></asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td class="auto-style3">
                <asp:RadioButtonList runat="server" ID="PaperQuantity" RepeatDirection="Vertical"  RepeatLayout="Flow">
                <asp:ListItem Text="100-pack" Value="Quantity100"></asp:ListItem>
                <asp:ListItem Text="200-pack" Value="Quantity200"></asp:ListItem>
                <asp:ListItem Text="300-pack" Value="Quantity300"></asp:ListItem>
                </asp:RadioButtonList></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
    
    <asp:Button ID="ButtonAddToCart" runat="server" Text="Add to cart" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    
    </asp:Content>
