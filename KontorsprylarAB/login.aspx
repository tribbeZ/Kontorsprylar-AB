<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="KontorsprylarAB.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="LOGIN"></asp:Label>
    <br /><br />
    <input id="username" placeholder="Username" type="text" style="text-align:center"/>
    <asp:RequiredFieldValidator ID="RequiredFieldValidatorLogin" runat="server" EnableClientScript="False" ErrorMessage="Input username" ForeColor="Red"></asp:RequiredFieldValidator>
    <br /><br />
    <input id="password" placeholder="Password "type="password" style="text-align:center" />
    <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" runat="server" ErrorMessage="Input password"></asp:RequiredFieldValidator>
    <br /><br />
    <input id="ButtonLogin" type="button" value="Login" />
</asp:Content>
