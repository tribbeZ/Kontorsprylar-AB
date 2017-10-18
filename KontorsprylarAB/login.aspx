<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="KontorsprylarAB.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="LOGIN"></asp:Label>
    <br />&nbsp;<asp:Label ID="labelUserPrompt" runat="server" ForeColor="Red" Text="Wrong username or password" Visible="False"></asp:Label>
<br />
    &nbsp;<asp:TextBox ID="textBoxUsername" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidatorLogin" runat="server" ControlToValidate="textBoxUsername" EnableClientScript="False" ErrorMessage="Please enter username" ForeColor="Red"></asp:RequiredFieldValidator>
    <br /><br />
    &nbsp;<asp:TextBox ID="textBoxPassword" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" runat="server" ControlToValidate="textBoxPassword" EnableClientScript="False" ErrorMessage="Please enter password" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />
    <asp:Button ID="buttonLogin" runat="server" Text="OK" OnClick="buttonLogin_Click" />
    <br />
    &nbsp;
</asp:Content>
