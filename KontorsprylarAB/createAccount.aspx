<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="createAccount.aspx.cs" Inherits="KontorsprylarAB.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="LabelCreateAccount" runat="server" Text="CREATE ACCOUNT"></asp:Label>
    <br /><br />
    <asp:TextBox ID="TextBoxFirstname"  placeholder="Firstname" runat="server" style="text-align:center"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxFirstname" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red"></asp:RequiredFieldValidator>
    <br /><br />
    <asp:TextBox ID="TextBoxLastname"  placeholder="Lastname" runat="server" style="text-align:center"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxLastname" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red"></asp:RequiredFieldValidator>
    <br /><br />
    <asp:TextBox ID="TextBoxEmail"  placeholder="E-mail" runat="server" style="text-align:center"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxEmail" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red"></asp:RequiredFieldValidator>
    <br /><br />
    <asp:TextBox ID="TextBoxUsername"  placeholder="Username" runat="server" style="text-align:center"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBoxUsername" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red"></asp:RequiredFieldValidator>
    <br /><br />
    <asp:TextBox ID="TextBoxPassword"  placeholder="Password" runat="server" style="text-align:center"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBoxPassword" EnableClientScript="False" ErrorMessage="RequiredFieldValidator" ForeColor="Red"></asp:RequiredFieldValidator>
    <br /><br />
    <asp:Button ID="ButtonRegistration" runat="server" Text="Register" OnClick="ButtonRegistration_Click" />
    
</asp:Content>
