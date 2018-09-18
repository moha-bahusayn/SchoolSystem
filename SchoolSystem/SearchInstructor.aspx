<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchInstructor.aspx.cs" Inherits="SchoolSystem.SearchInstructor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        Search for an Instructor.
    </p>
    <p>
        <asp:TextBox ID="QueryBox" runat="server"></asp:TextBox>
        <asp:Label ID="lblExceptionsMsg" runat="server" Text=""></asp:Label>
    </p>
    <p>
        <asp:RadioButton ID="byId_rdb" runat="server" GroupName="InstructSearch_rdbs" Text="by Instructor ID" />
    </p>
    <p>
        <asp:RadioButton ID="byFname_rdb" runat="server" GroupName="InstructSearch_rdbs" Text="by Instructor First Name" />
    </p>
    <p>
        <asp:RadioButton ID="byLname_rdb" runat="server" GroupName="InstructSearch_rdbs" Text="by Instructor Last Name" />
    </p>
    <p>
        <asp:Button ID="SubmitBtn" runat="server" Text="Search!" OnClick="SubmitBtn_Click" />
    </p>
    <p>
        <asp:GridView ID="InstructorGridView" runat="server" EmptyDataText="No Records Found!" AllowPaging="True" AllowSorting="True" OnRowCommand="InstructorGridView_RowCommand">
            <Columns>
                <asp:ButtonField CommandName="select" Text="Select" />
            </Columns>
        </asp:GridView>
    </p>
    <p>
        <asp:Button ID="BackBtn" runat="server" Text="Back To Dashboard" OnClick="BackBtn_Click" />
    </p>
</asp:Content>