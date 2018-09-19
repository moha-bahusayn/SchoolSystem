<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertStudent.aspx.cs" Inherits="SchoolSystem.InsertStudent" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">

    <script type="text/javascript">

        $(function () {

            $("#<%= txtDob.ClientID %>").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: 'dd/mm/yy'
            });

        });

        function pageLoad(sender, args) {

            if (args.get_isPartialLoad()) {

                $("#<%= txtDob.ClientID %>").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: 'dd/mm/yy'
            });

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
    <br />
    <asp:Label ID="lblhobbies" runat="server" Text="Hobbies"></asp:Label>
    <asp:TextBox ID="txtHobbies" runat="server"></asp:TextBox>
    <br />
        <asp:Label ID="lblclassroomName" runat="server" Text="    Classroom Name:"></asp:Label>

    <asp:DropDownList ID="Classroom_ddl" runat="server" DataSourceID="ClassroomSqlDataSource" DataTextField="Name" DataValueField="Id">
    </asp:DropDownList>
    <asp:SqlDataSource ID="ClassroomSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:DBConnect %>" SelectCommand="SELECT [Id], [Name] FROM [Classrooms]"></asp:SqlDataSource>

    <br />

    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />

    <asp:Button ID="BackBtn" runat="server" Text="Back To Dashboard" OnClick="BackBtn_Click" />
    <br />
    <asp:Label ID="CreationMesssage" runat="server" Text=""></asp:Label>
    <br />
    <asp:table ID="infoTable" runat="server" class="table table-striped">
        <asp:TableRow>
            <asp:TableCell>First Name:</asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lbltable_fName" runat="server" Text=""></asp:Label></asp:TableCell>
            </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Last Name:</asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lbltable_lName" runat="server" Text=""></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Mobile:</asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lbltable_mobile" runat="server" Text=""></asp:Label></asp:TableCell>
       </asp:TableRow>
        <asp:TableRow>     
            <asp:TableCell>Email:</asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lbltable_email" runat="server" Text=""></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Date Of Birth:</asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lbltable_dob" runat="server" Text=""></asp:Label></asp:TableCell>
            </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Hobbies:</asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lbltable_hobbies" runat="server" Text=""></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Classroom:</asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="lbltable_classroom" runat="server" Text=""></asp:Label></asp:TableCell>
        </asp:TableRow>
    </asp:table>
</asp:Content>