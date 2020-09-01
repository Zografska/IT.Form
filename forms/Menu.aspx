<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="forms.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="col-md-6">
           <br /><br />
        Name <asp:TextBox ID="Name" runat="server"></asp:TextBox>
        <br />
        Age <asp:TextBox ID="Age" runat="server"></asp:TextBox>
        <hr />
        Destination <asp:ListBox ID="Dest" runat="server"></asp:ListBox>
        <hr />
        Class <asp:CheckBoxList ID="Class" runat="server">
               <asp:ListItem>Economy</asp:ListItem>
               <asp:ListItem>Business</asp:ListItem>
               <asp:ListItem>Extra</asp:ListItem>
           </asp:CheckBoxList>
        <hr />
        Date(Day,Month)<asp:DropDownList ID="Day" runat="server"></asp:DropDownList><asp:DropDownList ID="Month" runat="server"></asp:DropDownList>
<br />      
        Mode<asp:DropDownList ID="Mode" runat="server" OnSelectedIndexChanged="Mode_SelectedIndexChanged">
               <asp:ListItem Value="plane.jpg">Plane</asp:ListItem>
               <asp:ListItem Value="train.jfif">train</asp:ListItem>
           </asp:DropDownList>
        <br />
        <hr />
        <asp:Button ID="Button" runat="server" Text="Submit" OnClick="Button_Click" />

    </div>
    <div class="col-md-6">
        <br /><br />
            <hr />
            <br /><br />   <br /><br />   <br />

        <asp:Panel ID="Panel1" runat="server" Width="200" Height="200" Visible="False">
            
            
        The passinger   <asp:TextBox ID="NameVal" runat="server" Enabled="False"></asp:TextBox><br />
        Aged    <asp:TextBox ID="AgeVal" runat="server" Enabled="False"></asp:TextBox><br />
        Picked a destination going <asp:TextBox ID="DestVal" runat="server" Enabled="False"></asp:TextBox> on the day
        <asp:TextBox ID="DateVal" runat="server" Enabled="False"></asp:TextBox><br />
        with class <asp:TextBox ID="ClassVal" runat="server" Enabled="False"></asp:TextBox> 
            <br />
            Mode of transport:
            <asp:Image ID="Image1" runat="server" />

        </asp:Panel>
     </div>
</asp:Content>
