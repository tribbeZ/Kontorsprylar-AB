<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="checkout.aspx.cs" Inherits="KontorsprylarAB.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 50%;">
       <thead>
            <tr>
                <th>Product</th>
                <th>Price</th>
            </tr>
        </thead>
        <tbody>
            <asp:Literal ID="CheckoutSumUp" runat="server"></asp:Literal>
            <asp:Literal ID="PriceSum" runat="server"></asp:Literal>
           <tr>
               <td>
                   <asp:Button ID="Button2" runat="server" Text="Continue Shopping" /></td>
               <td>
                   <input id="Button1" type="button" value="Checkout!" /></td>
           </tr>
        </tbody>


    </table>
</asp:Content>
