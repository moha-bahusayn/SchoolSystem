<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="testInsertClassroom.aspx.cs" Inherits="SchoolSystem.testInsertClassroom" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <span style="text-decoration: underline"><strong>- Add new Classroom Profile.<br />
    </strong></span>
    <br />
    <asp:Label ID="lblName" runat="server" Text="Name *"></asp:Label>
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblCapacity" runat="server" Text="Capacity *"></asp:Label>
    <asp:TextBox ID="txtCapacity" runat="server"></asp:TextBox>
    <br />


    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
</asp:Content>
