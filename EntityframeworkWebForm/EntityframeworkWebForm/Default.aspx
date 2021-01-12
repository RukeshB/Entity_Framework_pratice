<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EntityframeworkWebForm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    Food List
   <asp:GridView ID="FoodList" runat="server" AutoGenerateColumns="false" style="margin-left: 92px" Width="683px">
            <Columns>
                <asp:BoundField DataField="id" AccessibleHeaderText="id"  Visible="false"/>
                <asp:BoundField  DataField="name" HeaderText="name" />
                <asp:BoundField  DataField="category_name" HeaderText="category_name" />
                <asp:BoundField  DataField="size_name" HeaderText="size_name" />
                <asp:BoundField  DataField="price" HeaderText="price" />
                
            </Columns>
        </asp:GridView>
</asp:Content>
