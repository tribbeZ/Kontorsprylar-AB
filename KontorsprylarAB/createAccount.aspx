<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="createAccount.aspx.cs" Inherits="KontorsprylarAB.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="LabelCreateAccount" runat="server" Text="CREATE ACCOUNT"></asp:Label>
    <br /><br />
    <asp:TextBox ID="TextBoxFirstname"  placeholder="Firstname" runat="server" style="text-align:center"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" EnableClientScript="False" ErrorMessage="Please provide your first name" ForeColor="Red" ControlToValidate="TextBoxFirstname"></asp:RegularExpressionValidator>
    <br /><br />
    <asp:TextBox ID="TextBoxLastname"  placeholder="Lastname" runat="server" style="text-align:center"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" EnableClientScript="False" ErrorMessage="Please provide your last name" ForeColor="Red" ControlToValidate="TextBoxLastname"></asp:RegularExpressionValidator>
    <br /><br />
    <asp:TextBox ID="TextBoxEmail"  placeholder="E-mail" runat="server" style="text-align:center"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" EnableClientScript="False" ErrorMessage="Please provide your e-mail" ForeColor="Red" ControlToValidate="TextBoxEmail"></asp:RegularExpressionValidator>
    <br /><br />
    <asp:TextBox ID="TextBoxUsername"  placeholder="Username" runat="server" style="text-align:center"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" EnableClientScript="False" ErrorMessage="Please provide a username" ForeColor="Red" ControlToValidate="TextBoxUsername"></asp:RegularExpressionValidator>
    <br /><br />
    <asp:TextBox ID="TextBoxPassword"  placeholder="Password" runat="server" style="text-align:center"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" EnableClientScript="False" ErrorMessage="Please provide a password" ForeColor="Red" ControlToValidate="TextBoxPassword"></asp:RegularExpressionValidator>
    <br /><br />
    <asp:Button ID="ButtonRegistration" runat="server" Text="Register" />
    
</asp:Content>
