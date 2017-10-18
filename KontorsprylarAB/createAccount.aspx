<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="createAccount.aspx.cs" Inherits="KontorsprylarAB.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="LabelCreateAccount" runat="server" Text="CREATE ACCOUNT"></asp:Label>
    <br /><br />
    <input id="textFirstname" placeholder="Firstname" type="text" style="text-align:center"/>
    <br /><br />
    <input id="textLastname" placeholder="Lastname" type="text" style="text-align:center"/>
    <br /><br />
    <input id="textEmail" placeholder="E-mail" type="text" style="text-align:center"/>
    <br /><br />
    <input id="textUsername" placeholder="Username" type="text" style="text-align:center"/>
    <br /><br />
    <input id="passwordCreateAccount" placeholder="Password" type="password" style="text-align:center" />
    <br /><br />
    <input id="buttonRegister" type="button" value="Register" />
</asp:Content>
