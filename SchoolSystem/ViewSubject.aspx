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