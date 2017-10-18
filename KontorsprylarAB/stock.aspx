<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="stock.aspx.cs" Inherits="KontorsprylarAB.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- läsa in värdena från sql:en in i tabellen nedan, lägga till update, create -->
    
    <table style="width: 80%">
        <thead>
            <tr>
                <td>ID</td>
                <td>Product ID</td>
                <td>NumberOfProducts</td>
           </tr>
       </thead>
        <tbody>
        </tbody>
     
    </table>
     <asp:Button ID="ButtonAdd" runat="server" Text="Add" />
    <br /><br />
     <asp:Button ID="ButtonLogOut" runat="server" Text="Log out" />
    

</asp:Content>
