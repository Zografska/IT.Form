<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Items.aspx.cs" Inherits="forms.Items" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col-md-12">
       <h1> <asp:Label ID="header" runat="server" Text="Label"></asp:Label> </h1>
    </div>
    <div class="col-md-6">
        <asp:ListBox ID="items" runat="server" AutoPostBack="True" OnSelectedIndexChanged="items_SelectedIndexChanged"></asp:ListBox>
        <br />
           
        <asp:LinkButton ID="goback" runat="server" OnClick="goback_Click">Go Back</asp:LinkButton>
    </div>
    <div class="col-md-6">
        <asp:ListBox ID="prices" runat="server" AutoPostBack="True"></asp:ListBox>
        <br />
        <asp:ListBox ID="cart" runat="server"></asp:ListBox>
        <br />
        <asp:LinkButton ID="addtocart" runat="server" OnClick="addtocart_Click">Add To Cart</asp:LinkButton>
        <br />

        <asp:LinkButton ID="checkout" runat="server" OnClick="checkout_Click">Checkout(Buy)</asp:LinkButton>
        <br />
        Total price:
        <asp:Label ID="price" runat="server" Text="0"></asp:Label>
    </div>
</asp:Content>
