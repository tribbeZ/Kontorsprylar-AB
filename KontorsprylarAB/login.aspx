<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="KontorsprylarAB.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="LOGIN"></asp:Label>
    <br /><br />
    &nbsp;<asp:TextBox ID="textBoxUsername" runat="server"></asp:TextBox>
    <br /><br />
    &nbsp;<asp:TextBox ID="textBoxPassword" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="buttonLogin" runat="server" Text="OK" OnClick="buttonLogin_Click" />
    <br />
    &nbsp;
</asp:Content>
