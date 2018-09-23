<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewStudent.aspx.cs" Inherits="SchoolSystem.ViewStudent" %>

<asp:Content ID="Content2" ContentPlaceHolderID="HeadContent" runat="server">
    <%--<script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
    <script>
        swal("Hello world!");
    </script>--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="table table-striped">
        <tr>
            <td>Student ID:</td>
            <td>
                <asp:Label ID="lbl_id" runat="server" Text=""></asp:Label></td>
            <td>Classroom:</td>
            <td>
                <asp:Label ID="lbl_classroom" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>First Name:</td>
            <td>
                <asp:Label ID="lbl_fName" runat="server" Text=""></asp:Label></td>
            <td>Last Name:</td>
            <td>
                <asp:Label ID="lbl_lName" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td>Mobile:</td>
            <td>
                <asp:Label ID="lbl_mobile" runat="server" Text=""></asp:Label></td>
            <td>Email:</td>
            <td>
                <asp:Label ID="lbl_email" runat="server" Text=""></asp:Label></td>
        </tr>
    </table>

    <asp:Label ID="lbl_class" runat="server" Text="Classrooms :"></asp:Label>
    <asp:DropDownList ID="Classroom_ddl" runat="server" DataSourceID="ClassroomSqlDataSource" DataTextField="Name" DataValueField="Name">
    </asp:DropDownList>
    <asp:Button ID="ActionClassBtn" runat="server" Text="" OnClick="ActionClassBtn_Click" />
    <asp:SqlDataSource ID="ClassroomSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:DBConnect %>" SelectCommand="SELECT [Id], [Name], [Capacity] FROM [Classrooms]"></asp:SqlDataSource>
    <p>
        <asp:Button ID="DeleteBtn" class="btn btn-danger active" runat="server" Text="Delete" OnClick="DeleteBtn_Click" />
    </p>
    <br />
    <asp:Label ID="QueryMessage" runat="server" Text=""></asp:Label>
    <br />
    <p>
        <asp:Button ID="BackBtn" class="btn btn-default active" runat="server" Text="Back To Dashboard" OnClick="BackBtn_Click" />
    </p>
    <p>
        &nbsp;
    </p>
</asp:Content>