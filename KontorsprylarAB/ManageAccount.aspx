<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="ManageAccount.aspx.cs" Inherits="KontorsprylarAB.ManageAccount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table style="width: 80%;">
        <thead>
            <tr>
                <th>First name</th>
                <th>Last name</th>
                <th>E-mail</th>
                <th>Username</th>
                <th>Password</th>
            </tr>

        </thead>
        <tbody>

            <asp:Literal ID="Stock" runat="server"></asp:Literal>
        </tbody>
    </table>
    <table>

        <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update password" />

    </table>
    <table>
        <tr>
            <th>Your last order</th>
        </tr>
    </table>
    <table style="width: 80%;">
        <tr>
            
           
            <th>OrderDate</th>
            <th>OrderSum</th>
            <th>OrderQuantity</th>
            

            <asp:Literal ID="OrderLiteral" runat="server"></asp:Literal>
        </tr>
    </table>

</asp:Content>
