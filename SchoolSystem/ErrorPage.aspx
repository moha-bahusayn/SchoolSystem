<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ErrorPage.aspx.cs" Inherits="SchoolSystem.ErrorPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadScriptContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h1>There's an error occured</h1>
    <asp:Button ID="BackBtn" class="btn btn-default active" runat="server" Text="Back To Previous Page" OnClick="BackBtn_Click" />
    <p>
        &nbsp;
    </p>
</asp:Content>