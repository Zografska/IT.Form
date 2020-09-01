<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="forms.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col-md-12 text-center">
        <h1>Categories</h1>
    </div>
    <div class="col-md-6 text-center">
     
        <hr />
 
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Math</asp:LinkButton>

        <hr />
            <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Bio</asp:LinkButton>
        <hr />

    </div>

</asp:Content>
