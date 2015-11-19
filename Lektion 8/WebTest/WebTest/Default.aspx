<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebTest._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    
    <asp:GridView ID="gridAddresView" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCancelingEdit="gridAddresView_RowCancelingEdit" OnRowDeleting="gridAddresView_RowDeleting" OnRowEditing="gridAddresView_RowEditing" OnRowUpdating="gridAddresView_RowUpdating" AutoGenerateColumns="False" >
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField ShowEditButton="True"  ButtonType="Button" />
            <asp:CommandField ShowDeleteButton="True" ButtonType="Button" />
            <asp:TemplateField HeaderText="Road Name">
                <EditItemTemplate>
                    <asp:TextBox ID="txtRoadName" runat="server" Text='<%# Bind("RoadName") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate="txtRoadName" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Skal udfyldes" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("RoadName") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Number">
                <EditItemTemplate>
                    <asp:TextBox ID="txtNumber" runat="server" Text='<%# Bind("Number") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate="txtNumber" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Skal udfyldes" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("Number") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>

</asp:Content>
