<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EntityframeworkWebForm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Add/ Update Food</h2>
    
     <%--<asp:updatepanel runat="server">
     <ContentTemplate>--%>
         <asp:Table ID="myTable" runat="server" Width="100%">
            <asp:TableRow>
                <asp:TableCell ColumnSpan="2">
                    Name:
                </asp:TableCell>
                <asp:TableCell ColumnSpan="2">
                    <asp:TextBox ID="name" runat="server" Width="174px" Height="38px"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell ColumnSpan="2">
                    Catagory:
                </asp:TableCell>
                <asp:TableCell ColumnSpan="2">
                    <asp:DropDownList ID="catagory" runat="server" Height="38px" Width="174px"></asp:DropDownList>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow id="currentsize">
                <asp:TableCell style="width: 31px">
                    size:
                </asp:TableCell>
                <asp:TableCell style="width: 99px">
                    <asp:DropDownList ID="sizeList" runat="server">
                        <asp:ListItem Value="">---Select---</asp:ListItem>
                        <asp:ListItem Value="small">Small</asp:ListItem>
                        <asp:ListItem Value="medium">Medium</asp:ListItem>
                        <asp:ListItem Value="large">Large</asp:ListItem>
                    </asp:DropDownList>
                </asp:TableCell>
                <asp:TableCell style="width: 44px">
                    price:
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="price" runat="server" CssClass="col-xs-offset-0" Height="23px" Width="115px"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            </asp:Table>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        <asp:Button ID="btn_save" runat="server" Text="submmit" OnClick="save_Click" Width="67px" style="margin-left: 108" />
        <asp:Button ID="btn_clear" runat="server" Text="Clear" OnClick="reset_Click" style="margin-left: 0px" Width="65px"/>
        <asp:Button ID="btn_delete" runat="server" Text="Delete All" />
        <asp:Button ID="btn_size" runat="server" Text="Add Size" OnClick="btn_size_Click"/>
     <%--</ContentTemplate>
     </asp:updatepanel>--%>
    

    <br />

    <br />
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    Food List
   <asp:GridView ID="FoodList" runat="server" AutoGenerateColumns="false" style="margin-left: 92px" Width="683px" AutoGenerateSelectButton="True" OnSelectedIndexChanged="FoodList_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="id" AccessibleHeaderText="id"  Visible="false"/>
                <asp:BoundField DataField="size_id" AccessibleHeaderText="size_id"  Visible="false"/>
                <asp:BoundField  DataField="name" HeaderText="name" />
                <asp:BoundField  DataField="category_name" HeaderText="category_name" />
                <asp:BoundField  DataField="size_name" HeaderText="size_name" />
                <asp:BoundField  DataField="price" HeaderText="price" />
                
            </Columns>
        </asp:GridView>

    <%--<script type="text/javascript">
        var i = 0;
        jQuery(document).ready(function () {
            $("#btn_size").click(function () {
                $(".table").append('<asp:TableRow id="currentsize">\
                                        <td>\
                                            size:\
                                        </td>\
                                        <td style="width: 129px">\
                                            <asp:DropDownList ID="sizeList'+i+'" runat="server">\
                                                <asp:ListItem Value="">---Select---</asp:ListItem>\
                                                <asp:ListItem Value="small">Small</asp:ListItem>\
                                                <asp:ListItem Value="medium">Medium</asp:ListItem>\
                                                <asp:ListItem Value="large">Large</asp:ListItem>\
                                            </asp:DropDownList>\
                                        </td>\
                                        <td style="width: 50px">\
                                            price:\
                                        </td>\
                                        <td>\
                                            <asp:TextBox ID="price'+i+'" runat="server" CssClass="col-xs-offset-0"></asp:TextBox>\
                                        </td>\
                                    </asp:TableRow>'
                                    );
                
                i++;
                return false;
            });

            $('body').on('click', '#btnremove', function () {
                $(this).parent('div.currentsize').remove()

            });
        });
    </script>--%>
</asp:Content>
