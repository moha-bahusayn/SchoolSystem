<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewSubject.aspx.cs" Inherits="SchoolSystem.ViewSubject" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table class="table table-striped">
        <tr>
            <td>Subject ID:</td>
            <td>
                <asp:Label ID="lbl_id" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td>Name:</td>
            <td>
                <asp:Label ID="lbl_name" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td>Schedule Day:</td>
            <td>
                <asp:Label ID="lbl_schedule" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td>Instructor:</td>
            <td>
                <asp:Label ID="lbl_instructor" runat="server" Text=""></asp:Label></td>
        </tr>
    </table>
    <asp:Label ID="lbl_assignInstructor" runat="server" Text="Assign an Instructor to this Subject :"></asp:Label>
    <asp:DropDownList ID="Instructor_ddl" runat="server" DataSourceID="InstructorSqlDataSource" DataTextField="FirstName" DataValueField="Id">
    </asp:DropDownList>
    <asp:Button ID="AssignInstructorBtn" runat="server" Text="Assign" OnClick="AssignInstructorBtn_Click" />
    <asp:SqlDataSource ID="InstructorSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:DBConnect %>" SelectCommand="SELECT [Id], [FirstName], [LastName] FROM [Instructors]"></asp:SqlDataSource>
    <p>
        <asp:Button ID="DeleteBtn" class="btn btn-danger active" runat="server" Text="Delete" OnClick="DeleteBtn_Click" />
    </p>
    <br />
    <asp:Label ID="QueryMessage" runat="server" Text=""></asp:Label>
    <br />
    <p>
        <asp:Button ID="BackBtn" class="btn btn-default active" runat="server" Text="Back To Dashboard" OnClick="BackBtn_Click" />
    </p>
</asp:Content>