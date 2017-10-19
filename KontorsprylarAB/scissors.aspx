<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="scissors.aspx.cs" Inherits="KontorsprylarAB.scissors" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
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
                <img src="Pictures/scissors.png" class="auto-style4" />&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
    
    <table class="auto-style11">
        <tr>
            <td class="auto-style5">
                Choose your product</td>
            <td class="auto-style6">
                </td>
            <td class="auto-style7"></td>
        </tr>
        <tr>
            <td class="auto-style9">
                <asp:RadioButtonList runat="server" ID="ScissorQuantity" RepeatDirection="Vertical"  RepeatLayout="Flow">
                <asp:ListItem Text="100-pack" Value="100"></asp:ListItem>
                <asp:ListItem Text="200-pack" Value="200"></asp:ListItem>
                <asp:ListItem Text="300-pack" Value="300"></asp:ListItem>
                </asp:RadioButtonList></td>
            
            <td class="auto-style10"></td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorQuantity" runat="server" ControlToValidate="ScissorQuantity" ErrorMessage="Select a quantity!" ForeColor="Red" EnableClientScript="False"></asp:RequiredFieldValidator>
            <td class="auto-style12"></td>
        </tr>
    </table>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
    
    <asp:Button ID="ButtonAddToCart" runat="server" Text="Add to cart"/>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    
    </asp:Content>
