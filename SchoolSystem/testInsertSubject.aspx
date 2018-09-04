<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="testInsertSubject.aspx.cs" Inherits="SchoolSystem.testInsertSubject" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <span style="text-decoration: underline"><strong>- Add new Subject Profile.<br />
    </strong></span>
    <br />
    <asp:Label ID="lblName" runat="server" Text="Name *"></asp:Label>
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <br />

    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
</asp:Content>