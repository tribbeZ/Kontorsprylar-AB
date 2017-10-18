<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="stock.aspx.cs" Inherits="KontorsprylarAB.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- läsa in värdena från sql:en in i tabellen nedan, lägga till update, create -->
    
    <table style="width: 80%;">
        <tr>
            <td>ID</td>
            <td>Product ID</td>
            <td>NumberOfProducts</td>
        </tr>
    </table>

</asp:Content>
