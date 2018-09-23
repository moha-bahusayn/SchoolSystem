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

    <asp:GridView ID="SubStdGridView" runat="server" DataSourceID="SubStdsSqlDataSource" AutoGenerateColumns="False" DataKeyNames="Subject_Id,Student_Id">
        <Columns>
            <asp:BoundField DataField="Subject_Id" HeaderText="Subject_Id" ReadOnly="True" SortExpression="Subject_Id" />
            <asp:BoundField DataField="Student_Id" HeaderText="Student_Id" ReadOnly="True" SortExpression="Student_Id" />
        </Columns>
    </asp:GridView>
    <br />

    <asp:Label ID="lbl_AddStudent" runat="server" Text="Add a Student to this Subject :"></asp:Label>
    <asp:DropDownList ID="Student_ddl" runat="server" DataSourceID="StudentSqlDataSource" DataTextField="FirstName" DataValueField="Id">
    </asp:DropDownList>
    <asp:Button ID="AddStudentBtn" runat="server" Text="Add" OnClick="AddStudentBtn_Click" />
    <asp:SqlDataSource ID="StudentSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:DBConnect %>" SelectCommand="SELECT [Id], [FirstName], [LastName] FROM [Students]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SubStdsSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:DBConnect %>" SelectCommand="SELECT * FROM [SubjectStudents] WHERE ([Subject_Id] = @Subject_Id)">
        <SelectParameters>
            <asp:ControlParameter ControlID="lbl_id" Name="Subject_Id" PropertyName="Text" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
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