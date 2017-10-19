<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="stock.aspx.cs" Inherits="KontorsprylarAB.WebForm5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        height: 61px;
        width: 194px;
    }
    .auto-style6 {
        width: 194px;
    }
    .auto-style7 {
        width: 66%;
    }
    .auto-style8 {
        width: 409px;
    }
    .auto-style9 {
        height: 61px;
        width: 409px;
    }
    .auto-style10 {
        width: 416px;
    }
    .auto-style11 {
        height: 61px;
        width: 416px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <table style="width: 80%;">
        <thead>
            <tr>
                <th>ID</th>
                <th>Product ID</th>
                <th>NumberOfProducts</th>
            </tr>
        </thead>
        <tbody>
            <asp:Literal ID="Stock" runat="server"></asp:Literal>
        </tbody>
    </table>
    <table class="auto-style7">
        <thead>
        <tr>
            <th class="auto-style8">StockID</th>
            <th class="auto-style10">Quantity</th>
            <td class="auto-style6">&nbsp;</td>
        </tr>
            </thead>
        <tr>
            <td class="auto-style9">
                <asp:TextBox ID="TextBoxStockID" runat="server"></asp:TextBox>&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxStockID" EnableClientScript="False" ErrorMessage="Input Stock ID" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style11">
                <asp:TextBox ID="TextBoxQuantity" runat="server"></asp:TextBox>&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxQuantity" EnableClientScript="False" ErrorMessage="Input Quantity" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style1">
                <asp:Button ID="ButtonUpdateStock" runat="server" Text="Update Stock" OnClick="ButtonUpdateStock_Click" />&nbsp;</td>
        </tr>
    </table>
</asp:Content>
