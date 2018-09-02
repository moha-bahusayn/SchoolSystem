<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="testInsertInstructor.aspx.cs" Inherits="SchoolSystem.testInsertInstructor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <br />
    <span style="text-decoration: underline"><strong>- Add new Instructor Profile.<br />
    </strong></span>
    <br />
    <asp:Label ID="lblfName" runat="server" Text="First Name *"></asp:Label>
    <asp:TextBox ID="txtFName" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="lbllName" runat="server" Text="Last Name *"></asp:Label>
    <asp:TextBox ID="txtLName" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="lblmobile" runat="server" Text="Mobile Number"></asp:Label>
    <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="lblemail" runat="server" Text="Email Address"></asp:Label>
    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
</asp:Content>
