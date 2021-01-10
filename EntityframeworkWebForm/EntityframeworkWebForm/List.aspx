<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="EntityframeworkWebForm.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="gridView" CssClass="studentDiv" runat="server" AllowCustomPaging="true" 
        AllowPaging="true" OnPageIndexChanging="gridView_PageIndexChanging" PagerStyle-CssClass="pagingDiv" 
        AutoGenerateColumns="false" OnRowCommand="gridView_RowCommand" OnRowEditing="gridView_RowEditing" 
        OnRowDeleting="gridView_RowDeleting">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" />
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="Address" HeaderText="Address" />
                <asp:BoundField DataField="Age" HeaderText="Age" />
                <asp:BoundField DataField="Standard" HeaderText="Standard" />
                <asp:BoundField DataField="Percent" HeaderText="Percent" />
                <asp:BoundField DataField="AddedOn" HeaderText="AddedOn" />
                <asp:TemplateField HeaderText="Status">
                    <ItemTemplate>
                        <%#Eval("Status") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Edit">
                    <ItemTemplate>
                        <asp:ImageButton ID="editImageButton" runat="server" CommandName="edit" CommandArgument='<%#Eval("Id") %>' ImageUrl="Image/edit-icon.png" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Delete">
                    <ItemTemplate>
                        <asp:ImageButton ID="deleteImageButton" runat="server" CommandName="delete" CommandArgument='<%#Eval("Id") %>' ImageUrl="Image/delete-icon.png" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </table>
</asp:Content>
