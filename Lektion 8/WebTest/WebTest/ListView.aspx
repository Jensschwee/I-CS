<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListView.aspx.cs" Inherits="WebTest.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ListBox ID="list" runat="server" ViewStateMode="Enabled"></asp:ListBox>
    <br/>
    <asp:TextBox runat="server" ID="txtAdd"></asp:TextBox>
    <br/>
    <asp:Button runat="server" ID="btnAdd" Text="Add" OnClick="btnAdd_Click" />
    <asp:Button runat="server" ID="btnDelete" Text="Delete" OnClick="btnDelete_Click" />
</asp:Content>
