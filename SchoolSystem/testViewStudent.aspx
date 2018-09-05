<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="testViewStudent.aspx.cs" Inherits="SchoolSystem.testViewStudent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        &nbsp;- Control Student Data ( By First Name ).
    </p>
    <p>
        &nbsp;
    </p>
    <p>
        <asp:TextBox ID="View_txt" runat="server"></asp:TextBox>
        <asp:Button ID="ViewBtn" runat="server" Text="View By First Name!" OnClick="ViewBtn_Click" />
    </p>
    <p>
        &nbsp;
    </p>
    <p>
        <asp:TextBox ID="Update_txt" runat="server"></asp:TextBox>
        <asp:Button ID="UpdateBtn" runat="server" Text="Update First Name!" OnClick="UpdateBtn_Click" />
    </p>
    <p>
        Information of Student :
        <asp:Label ID="lblFirstName" runat="server" Text=""></asp:Label>
    </p>
    <p>
        &nbsp;
    </p>
    <asp:GridView ID="StudentGridView" runat="server" EmptyDataText="No Records Found!" AllowPaging="True" AllowSorting="True" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>
    <p>
        <asp:Button ID="DeleteBtn" runat="server" Text="Delete Student From Table!" />
    </p>
    <p>
        &nbsp;
    </p>
    <p>
        &nbsp;
    </p>
    <p>
        &nbsp;
    </p>
</asp:Content>