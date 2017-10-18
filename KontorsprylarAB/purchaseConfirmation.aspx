<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="purchaseConfirmation.aspx.cs" Inherits="KontorsprylarAB.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Thank you for your purchase (loginrutans text namn)!<br />
    <br />
&nbsp;<asp:Button ID="ButtonContinueShopping" runat="server" Text="Continue shopping" />
    <br />
    <asp:Button ID="ButtonLogOut" runat="server" Text="Log out" />
&nbsp;
</asp:Content>
