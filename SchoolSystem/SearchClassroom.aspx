<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchClassroom.aspx.cs" Inherits="SchoolSystem.SearchClassroom" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        Search for a Classroom.
    </p>
    <p>
        <asp:TextBox ID="QueryBox" runat="server"></asp:TextBox>
        <asp:Label ID="lblExceptionsMsg" runat="server" Text=""></asp:Label>
    </p>
    <p>
        <asp:RadioButton ID="byId_rdb" runat="server" GroupName="ClassroomSearch_rdbs" Text="by Classroom ID" />
    </p>
    <p>
        <asp:RadioButton ID="byName_rdb" runat="server" GroupName="ClassroomSearch_rdbs" Text="by Classroom Name" />
    </p>
    <p>
        <asp:RadioButton ID="byCapacity_rdb" runat="server" GroupName="ClassroomSearch_rdbs" Text="by Classroom Capacity" />
    </p>
    <p>
        <asp:Button ID="SubmitBtn" runat="server" Text="Search!" OnClick="SubmitBtn_Click" />
    </p>
    <p>
        <asp:GridView ID="ClassroomGridView" runat="server" EmptyDataText="No Records Found!" AllowPaging="True" AllowSorting="True" OnRowCommand="ClassroomGridView_RowCommand">
            <Columns>
                <asp:ButtonField CommandName="select" Text="Select" />
            </Columns>
        </asp:GridView>
    </p>
    <p>
        <asp:Button ID="BackBtn" runat="server" Text="Back To Dashboard" OnClick="BackBtn_Click" />
    </p>
</asp:Content>