<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="checkout.aspx.cs" Inherits="KontorsprylarAB.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 50%;">
        <thead>
            <tr>
                <td>Product</td>
                <td>Specification</td>
                <td>Quantity</td>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>Paper</td>
                <td>A4</td>
                <td>200</td>
            </tr>
           <tr>
               <td></td>
               <td>
                   <input id="Button1" type="button" value="Checkout!" /></td>
           </tr>
        </tbody>


    </table>
</asp:Content>
