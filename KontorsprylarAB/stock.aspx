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

</asp:Content>
