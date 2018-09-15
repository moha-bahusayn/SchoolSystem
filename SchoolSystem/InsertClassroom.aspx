<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertClassroom.aspx.cs" Inherits="SchoolSystem.testInsertClassroom" %>

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
    <asp:Button ID="BackBtn" runat="server" Text="Back To Dashboard" OnClick="BackBtn_Click" />
    <br />
    <asp:Label ID="CreationMesssage" runat="server" Text=""></asp:Label>
    <br />
    <table class="table table-striped">
        <tr>
            <td>Name:</td>
            <td>
                <asp:Label ID="lbltable_name" runat="server" Text=""></asp:Label></td>
            <td>Capacity:</td>
            <td>
                <asp:Label ID="lbltable_capacity" runat="server" Text=""></asp:Label></td>
        </tr>
    </table>
</asp:Content>