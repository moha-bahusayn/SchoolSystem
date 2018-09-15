<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertInstructor.aspx.cs" Inherits="SchoolSystem.testInsertInstructor" %>

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

    <asp:Button ID="BackBtn" runat="server" Text="Back To Dashboard" OnClick="BackBtn_Click" />
    <br />
    <asp:Label ID="CreationMesssage" runat="server" Text=""></asp:Label>
    <br />
    <table class="table table-striped">
        <tr>
            <td>First Name:</td>
            <td>
                <asp:Label ID="lbltable_fName" runat="server" Text=""></asp:Label></td>
            <td>Last Name:</td>
            <td>
                <asp:Label ID="lbltable_lName" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td>Mobile:</td>
            <td>
                <asp:Label ID="lbltable_mobile" runat="server" Text=""></asp:Label></td>
            <td>Email:</td>
            <td>
                <asp:Label ID="lbltable_email" runat="server" Text=""></asp:Label></td>
        </tr>
    </table>
</asp:Content>