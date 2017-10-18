<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="stock.aspx.cs" Inherits="KontorsprylarAB.WebForm5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
    <table style="width: 50%;">
        <thead>
        <tr>
            <th>StockID</th>
            <th>Quantity</th>
            <td>&nbsp;</td>
        </tr>
            </thead>
        <tr>
            <td>
                <asp:TextBox ID="TextBoxStockID" runat="server"></asp:TextBox>&nbsp;</td>
            <td>
                <asp:TextBox ID="TextBoxQuantity" runat="server"></asp:TextBox>&nbsp;</td>
            <td>
                <asp:Button ID="ButtonUpdateStock" runat="server" Text="Update Stock" OnClick="ButtonUpdateStock_Click" />&nbsp;</td>
        </tr>
    </table>
</asp:Content>
