<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SuperuserDashboard.aspx.cs" Inherits="SchoolSystem.testSuperuserDashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        &nbsp;
    </p>
    <p style="text-decoration: underline">
        <strong>SuperUser Dashboard</strong>
    </p>
    <p>
        &nbsp;
    </p>

    <div class="row">
        <div class="col-md-3">Student</div>
        <div class="col-md-3">Instructor</div>
        <div class="col-md-3">Subject</div>
        <div class="col-md-3">Classroom</div>
    </div>

    <div class="row">
        <div class="col-md-3"><a class="btn btn-default active" href="ViewAllStudents.aspx" role="button">List All Students.</a></div>
        <div class="col-md-3"><a class="btn btn-default active" href="ViewAllInstructors.aspx" role="button">List All Instructors.</a></div>
        <div class="col-md-3"><a class="btn btn-default active" href="ViewAllSubjects.aspx" role="button">List All Subjects.</a></div>
        <div class="col-md-3"><a class="btn btn-default active" href="ViewAllClassrooms.aspx" role="button">List All Classrooms.</a></div>
    </div>

    <div class="row">
        <div class="col-md-3"><a class="btn btn-info active" href="SearchStudent.aspx" role="button">Search for a Student.</a></div>
        <div class="col-md-3"><a class="btn btn-info active" href="SearchInstructor.aspx" role="button">Search for an Instructor.</a></div>
        <div class="col-md-3"><a class="btn btn-info active" href="SearchSubject.aspx" role="button">Search for a Subject.</a></div>
        <div class="col-md-3"><a class="btn btn-info active" href="SearchClassroom.aspx" role="button">Search for a Classroom.</a></div>
    </div>

    <div class="row">
        <div class="col-md-3"><a class="btn btn-primary active" href="InsertStudent.aspx" role="button">Create a new Student Profile.</a></div>
        <div class="col-md-3"><a class="btn btn-primary active" href="InsertInstructor.aspx" role="button">Create a new Instructor Profile.</a></div>
        <div class="col-md-3"><a class="btn btn-primary active" href="InsertSubject.aspx" role="button">Create a new Subject Profile.</a></div>
        <div class="col-md-3"><a class="btn btn-primary active" href="InsertClassroom.aspx" role="button">Create a new Classroom Profile.</a></div>
    </div>
</asp:Content>