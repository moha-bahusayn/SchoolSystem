<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertSubject.aspx.cs" Inherits="SchoolSystem.testInsertSubject" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <span style="text-decoration: underline"><strong>- Add new Subject Profile.<br />
    </strong></span>
    <br />
    <asp:Label ID="lblName" runat="server" Text="Name *"></asp:Label>
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <br />
    Instructor Name*:
    <asp:DropDownList ID="Instructor_ddl" runat="server" DataSourceID="InstructorSqlDataSource" DataTextField="FirstName" DataValueField="FirstName">
    </asp:DropDownList>
    <asp:SqlDataSource ID="InstructorSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:DBConnect %>" SelectCommand="SELECT [Id], [FirstName], [LastName] FROM [Instructors]"></asp:SqlDataSource>
    <br />

    <%-- <asp:Label ID="LabelCode" runat="server" Text="Code *"></asp:Label>
    <asp:TextBox ID="txtCode" runat="server"></asp:TextBox>
    <br />--%>

    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /><asp:Button ID="BackBtn" runat="server" Text="Back To Dashboard" OnClick="BackBtn_Click" />
    <br />
    <asp:Label ID="CreationMesssage" runat="server" Text=""></asp:Label>
    <br />
    <table class="table table-striped">
        <tr>
            <td>Name:</td>
            <td>
                <asp:Label ID="lbltable_name" runat="server" Text=""></asp:Label></td>
        </tr>

        <td>Instructor:</td>
        <td>
            <asp:Label ID="lbltable_iName" runat="server" Text=""></asp:Label></td>
        </tr>
    </table>
</asp:Content>