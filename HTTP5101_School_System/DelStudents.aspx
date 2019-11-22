<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="DelStudents.aspx.cs" Inherits="HTTP5101_School_System.DelStudents" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
     <div id="student" runat="server">
        <h2>Details for <span id="student_title_fname" runat="server"></span></h2>   
    <div>
        <label for="student_fname">Student First Name:</label>
        <span id="student_fname" runat="server"></span>
    </div>
    <div>
       <label for="student_lname">Student Last Name:</label>
       <span id="student_lname" runat="server"></span>
    </div>
    <div>
       <label for="student_number">Student Number:</label>
       <span id="student_number" runat="server"></span>
    </div>
    <div>  
       <label for="enrolment_date">Enrollment Date</label>
       <span id="enrolment_date" runat="server"></span>
    </div>

    <div id="confirmation">Are you sure you want to delete?</div>
    <asp:button type="button" runat="server" text="Delete" onclick="delete_function" CssClass="save_button" />
    <asp:button type="button" runat="server" text="Cancel" onclick="cancel_function" CssClass="cancel_button" />

      </div>
</asp:Content>
