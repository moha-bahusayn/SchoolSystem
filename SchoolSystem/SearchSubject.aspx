<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchSubject.aspx.cs" Inherits="SchoolSystem.SearchSubject" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadScriptContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        Search for a Subject.
    </p>
    <p>
        <asp:TextBox ID="QueryBox" runat="server"></asp:TextBox>
        <asp:Label ID="lblExceptionsMsg" runat="server" Text=""></asp:Label>
    </p>
    <p>
        <asp:RadioButton ID="byId_rdb" runat="server" GroupName="SubjectSearch_rdbs" Text="by Subject ID" />
    </p>
    <p>
        <asp:RadioButton ID="byName_rdb" runat="server" GroupName="SubjectSearch_rdbs" Text="by Subject Name" />
    </p>
    <p>
        <asp:Button ID="SubmitBtn" runat="server" Text="Search!" OnClick="SubmitBtn_Click" />
    </p>
    <p>
        <asp:GridView ID="SubjectGridView" runat="server" EmptyDataText="No Records Found!" AllowPaging="True" AllowSorting="True" OnRowCommand="SubjectGridView_RowCommand">
            <Columns>
                <asp:ButtonField CommandName="select" Text="Select" />
            </Columns>
        </asp:GridView>
    </p>
    <p>
        <asp:Button ID="BackBtn" runat="server" Text="Back To Dashboard" OnClick="BackBtn_Click" />
    </p>
</asp:Content>