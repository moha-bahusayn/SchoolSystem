<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchStudent.aspx.cs" Inherits="SchoolSystem.testSearchStudent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        Search for a Student.
    </p>
    <p>
        <asp:TextBox ID="QueryBox" runat="server"></asp:TextBox>
        <asp:Label ID="lblExceptionsMsg" runat="server" Text=""></asp:Label>
    </p>
    <p>
        <asp:RadioButton ID="byId_rdb" runat="server" GroupName="StudSearch_rdbs" Text="by Student ID" />
    </p>
    <p>
        <asp:RadioButton ID="byFname_rdb" runat="server" GroupName="StudSearch_rdbs" Text="by Student First Name" />
    </p>
    <p>
        <asp:RadioButton ID="byLname_rdb" runat="server" GroupName="StudSearch_rdbs" Text="by Student Last Name" />
    </p>
    <p>
        <asp:Button ID="SubmitBtn" runat="server" Text="Search!" OnClick="SubmitBtn_Click" />
    </p>
    <p>
        <asp:GridView ID="StudentGridView" runat="server" EmptyDataText="No Records Found!" AllowPaging="True" AllowSorting="True" OnRowCommand="StudentGridView_RowCommand">
            <Columns>
                <asp:ButtonField CommandName="select" Text="Select" />
            </Columns>
        </asp:GridView>
    </p>
    <p>
        <asp:Button ID="BackBtn" runat="server" Text="Back To Dashboard" OnClick="BackBtn_Click" />
    </p>
</asp:Content>