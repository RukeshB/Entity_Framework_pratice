<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FileUpload.aspx.cs" Inherits="EntityframeworkWebForm.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Upload File</h2>
    <asp:Table ID="FileTable" runat="server">
        <asp:TableRow>
                <asp:TableCell >
                    Upload File:
                </asp:TableCell>
                <asp:TableCell >
                    <%--<input id="File1" type="file" />--%>
                    <asp:FileUpload ID="FileUpload" runat="server" />
                </asp:TableCell>
            </asp:TableRow>
       
        <asp:TableRow>
            
            <asp:TableCell style="width: 129px">
                <asp:Button ID="btn_upload" runat="server" Text="Upload" OnClick="Upload_Click" Width="67px" />
                
            </asp:TableCell>
            <asp:TableCell style="width: 67px">
                <asp:Button ID="reset" runat="server" Text="Clear" OnClick="reset_Click" style="margin-left: 3px" Width="65px"/>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
