<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewInstructor.aspx.cs" Inherits="SchoolSystem.ViewInstructor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadScriptContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table class="table table-striped">
        <tr>
            <td>Instructor ID:</td>
            <td>
                <asp:Label ID="lbl_id" runat="server" Text=""></asp:Label></td>
            <%--<td>Subject:</td>
            <td>
                <asp:Label ID="lbl_subject" runat="server" Text=""></asp:Label>
            </td>--%>
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

    <%-- <p>
        Assign Instructor to Subject :
        <asp:DropDownList ID="Subject_ddl" runat="server" DataSourceID="SubjectSqlDataSource" DataTextField="Name" DataValueField="Name">
        </asp:DropDownList>
        <asp:Button ID="AddsubjectBtn" runat="server" Text="Assign to Subject." OnClick="AddSubjectBtn_Click" />
        <asp:SqlDataSource ID="SubjectSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:DBConnect %>" SelectCommand="SELECT [Id], [Name], [ScheduleDay] FROM [Subjects]"></asp:SqlDataSource>
    </p>--%>
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