<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="EntityframeworkWebForm.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Add/ Update Food</h2>
    <table>
        <tr>
            <td colspan="2">
                Name:
            </td>
            <td colspan="2">
                <asp:TextBox ID="name" runat="server" Width="157px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                Catagory:
            </td>
            <td colspan="2">
                <asp:DropDownList ID="catagory" runat="server" Height="16px" Width="161px"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                size:
            </td>
            <td style="width: 129px">
                <asp:DropDownList ID="sizeList" runat="server">
                    <asp:ListItem Value="">---Select---</asp:ListItem>
                    <asp:ListItem Value="small">Small</asp:ListItem>
                    <asp:ListItem Value="medium">Medium</asp:ListItem>
                    <asp:ListItem Value="large">Large</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="width: 67px">
                price:
            </td>
            <td>
                <asp:TextBox ID="price" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td></td>
            <td style="width: 129px">
                <asp:Button ID="save" runat="server" Text="submmit" OnClick="save_Click" Width="67px" />
                
            </td>
            <td style="width: 67px">
                <asp:Button ID="reset" runat="server" Text="Clear" OnClick="reset_Click" style="margin-left: 3px" Width="65px"/>
            </td>
        </tr>
    </table>
</asp:Content>
