<%@ Page Title="Opgave 2" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Lektion9.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    Max Number:
    <asp:TextBox ID="txtInput" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server" ControlToValidate="txtInput" ErrorMessage="Required field">*</asp:RequiredFieldValidator>
    <asp:RangeValidator ID="RangeValidator" runat="server" ControlToValidate="txtInput" MinimumValue="0" MaximumValue="100" ErrorMessage="Number need to be between 0 and 100">*</asp:RangeValidator>
    <asp:Button ID="btnRandom" runat="server" Text="Genreate" OnClick="btnRandom_Click" />
    <br/>
    Average numbers:
    <asp:TextBox ID="txtResult"  runat="server"></asp:TextBox>
    <asp:Button ID="btnNext" runat="server" Text="Next" OnClick="btnNext_Click" />
    
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
</asp:Content>
