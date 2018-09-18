<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertStudent.aspx.cs" Inherits="SchoolSystem.InsertStudent" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">

    <script type="text/javascript">

        $(function () {

            $("#<%= datepicker.ClientID %>").datepicker({ dateFormat: 'dd/mm/yy' });

        });

        function pageLoad(sender, args) {

            if (args.get_isPartialLoad()) {

                $("#<%= datepicker.ClientID %>").datepicker({ dateFormat: 'dd/mm/yy' });

            }

        };
    </script>

    <%--<script>
        $(function () {
            $("#<%=datepicker.ClientID%>").datepicker({
                changeMonth: true,
                changeYear: true
            });
        });
    </script>--%>
</asp:Content>
<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <span style="text-decoration: underline"><strong>- Add new Student Profile.<br />
    </strong></span>
    <br />
    <asp:Label ID="lblfName" runat="server" Text="First Name *"></asp:Label>
    <asp:TextBox ID="txtFName" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="lbllName" runat="server" Text="Last Name *"></asp:Label>
    <asp:TextBox ID="txtLName" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="lblmobile" runat="server" Text="Mobile Number"></asp:Label>
    <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="lblemail" runat="server" Text="Email Address"></asp:Label>
    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbldob" runat="server" Text="Date Of Birth"></asp:Label>
    <asp:TextBox ID="txtDob" runat="server"></asp:TextBox>

    <asp:TextBox ID="datepicker" runat="server"></asp:TextBox>

    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />

    <asp:Button ID="BackBtn" runat="server" Text="Back To Dashboard" OnClick="BackBtn_Click" />
    <br />
    <asp:Label ID="CreationMesssage" runat="server" Text=""></asp:Label>
    <br />
    <table class="table table-striped">
        <tr>
            <td>First Name:</td>
            <td>
                <asp:Label ID="lbltable_fName" runat="server" Text=""></asp:Label></td>
            <td>Last Name:</td>
            <td>
                <asp:Label ID="lbltable_lName" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td>Mobile:</td>
            <td>
                <asp:Label ID="lbltable_mobile" runat="server" Text=""></asp:Label></td>
            <td>Email:</td>
            <td>
                <asp:Label ID="lbltable_email" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td>Date Of Birth:</td>
            <td>
                <asp:Label ID="lbltable_dob" runat="server" Text=""></asp:Label></td>
        </tr>
    </table>
</asp:Content>