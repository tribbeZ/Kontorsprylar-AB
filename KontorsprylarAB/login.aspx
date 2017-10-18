<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="KontorsprylarAB.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="LOGIN"></asp:Label>
    <br /><br />
    <input id="username" placeholder="Username" type="text" style="text-align:center"/>
    <br /><br />
    <input id="password" placeholder="Password "type="password" style="text-align:center" />
    <br /><br />
    <input id="ButtonLogin" type="button" value="Login" />
</asp:Content>
