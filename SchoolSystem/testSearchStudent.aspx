<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="testSearchStudent.aspx.cs" Inherits="SchoolSystem.testSearchStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        Search for a Student.</p>
    <p>
        <asp:TextBox ID="QueryBox" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:SqlDataSource ID="SqlDataSourceStudent" runat="server" ConnectionString="<%$ ConnectionStrings:DBConnect %>" SelectCommand="SELECT [Id], [FirstName], [LastName] FROM [Students]"></asp:SqlDataSource>
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
        <asp:Label ID="testFoundRecord_lbl" runat="server" Text=""></asp:Label>
    </p>
    <p>
        <asp:Button ID="SubmitBtn" runat="server" Text="Search!" OnClick="SubmitBtn_Click" />
    </p>
    <p>
        <asp:GridView ID="StudentGridView" runat="server" ShowHeaderWhenEmpty="false" EmptyDataText="No Records Found!" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSourceStudent">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
            </Columns>
        </asp:GridView>
    </p>
</asp:Content>
