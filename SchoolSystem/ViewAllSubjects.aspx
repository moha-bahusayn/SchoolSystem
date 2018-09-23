<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewAllSubjects.aspx.cs" Inherits="SchoolSystem.ViewAllSubjects" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        <span style="text-decoration: underline"><strong>List of All Subjects.</strong></span>
    </p>
    <p>
        &nbsp;
    </p>
    <p>
        <asp:GridView ID="SubjectsGridView" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" OnRowCommand="SubjectsGridView_RowCommand">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Instructor_Id" HeaderText="Instructor_Id" SortExpression="Instructor_Id" />
                <asp:ButtonField ButtonType="Button" CommandName="select" HeaderText="Select" ShowHeader="True" Text="Select" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DBConnect %>" SelectCommand="SELECT [Id], [Name], [Instructor_Id] FROM [Subjects]"></asp:SqlDataSource>
    </p>
    <p>
        <asp:Button ID="BackBtn" runat="server" Text="Back To Dashboard" OnClick="BackBtn_Click" />
    </p>
</asp:Content>