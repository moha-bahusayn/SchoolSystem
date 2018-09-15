<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewClassroom.aspx.cs" Inherits="SchoolSystem.ViewClassroom" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadScriptContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table class="table table-striped">
        <tr>
            <td>Classroom ID:</td>
            <td>
                <asp:Label ID="lbl_id" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td>Name:</td>
            <td>
                <asp:Label ID="lbl_name" runat="server" Text=""></asp:Label></td>
            <td>Capacity:</td>
            <td>
                <asp:Label ID="lbl_capacity" runat="server" Text=""></asp:Label></td>
        </tr>
    </table>

    <%--<p>
        Add Student to Classroom :
        <asp:DropDownList ID="Classroom_ddl" runat="server" DataSourceID="ClassroomSqlDataSource" DataTextField="Name" DataValueField="Name">
        </asp:DropDownList>
        <asp:Button ID="AddClassBtn" runat="server" Text="Add to Class." OnClick="AddClassBtn_Click" />
        <asp:SqlDataSource ID="ClassroomSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:DBConnect %>" SelectCommand="SELECT [Id], [Name], [Capacity] FROM [Classrooms]"></asp:SqlDataSource>
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