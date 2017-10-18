﻿<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="paper.aspx.cs" Inherits="KontorsprylarAB.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 177px;
            height: 27px;
        }
        .auto-style3 {
            width: 133px;
            height: 27px;
        }
        .auto-style4 {
            width: 286px;
            height: 204px;
        }
        .auto-style5 {
            width: 177px;
            height: 36px;
        }
        .auto-style6 {
            width: 133px;
            height: 36px;
        }
        .auto-style7 {
            height: 36px;
        }
        .auto-style8 {
            width: 177px;
            height: 79px;
        }
        .auto-style9 {
            width: 133px;
            height: 79px;
        }
        .auto-style10 {
            height: 79px;
        }
        .auto-style11 {
            width: 100%;
            margin-bottom: 6px;
        }
        .auto-style12 {
            height: 27px;
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
    
    <table class="auto-style11">
        <tr>
            <td class="auto-style5">
                Choose format and quantity</td>
            <td class="auto-style6">
                </td>
            <td class="auto-style7"></td>
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:RadioButtonList runat="server" ID="PaperFormat" RepeatDirection="Vertical"  RepeatLayout="Flow">
                <asp:ListItem Text="A3 (3 SEK per sheet)" Value="A3"></asp:ListItem>
                <asp:ListItem Text="A4 (2 SEK per sheet)" Value="A4"></asp:ListItem>
                <asp:ListItem Text="A5 (1 SEK per sheet)" Value="A5"></asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td class="auto-style9">
                <asp:RadioButtonList runat="server" ID="PaperQuantity" RepeatDirection="Vertical"  RepeatLayout="Flow">
                <asp:ListItem Text="100-pack" Value="Quantity100"></asp:ListItem>
                <asp:ListItem Text="200-pack" Value="Quantity200"></asp:ListItem>
                <asp:ListItem Text="300-pack" Value="Quantity300"></asp:ListItem>
                </asp:RadioButtonList></td>
            
            <td class="auto-style10"></td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorPaperFormat" ControlToValidate="PaperFormat" runat="server" ErrorMessage="Select a format !" ForeColor="Red" EnableClientScript="False"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style3">
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorQuantity" runat="server" ControlToValidate="PaperQuantity" ErrorMessage="Select a quantity!" ForeColor="Red" EnableClientScript="False"></asp:RequiredFieldValidator>
            <td class="auto-style12"></td>
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
