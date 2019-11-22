<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="EditStudent.aspx.cs" Inherits="HTTP5101_School_System.EditStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <div id="student" runat="server">
        <section>
            <h1>Update Student Details</h1>
            <div>
                <label for="student_fname">First Name:</label>
                <asp:TextBox runat="server" id="student_fname"></asp:TextBox>
                <asp:RequiredFieldValidator  runat="server" EnableClientScript="true" ErrorMessage="Please provide the first name!" ControlToValidate="student_fname"></asp:RequiredFieldValidator>
            </div>
            <div>
                <label for="student_lname">Last Name:</label>
                <asp:TextBox runat="server" id="student_lname"></asp:TextBox>
                <asp:RequiredFieldValidator  runat="server" EnableClientScript="true" ErrorMessage="Please provide the last name!" ControlToValidate="student_lname"></asp:RequiredFieldValidator>
            </div>
            <div>
                <label for="student_number">Student Number</label>
                <asp:TextBox runat="server" id="student_number"></asp:TextBox>
                <asp:RequiredFieldValidator  runat="server" EnableClientScript="true" ErrorMessage="Please provide the student number!" ControlToValidate="student_number"></asp:RequiredFieldValidator>
            </div>
            <div>
                <label for="enrollment_date">Enrollment Date</label>
                <asp:TextBox runat="server" id="enrollment_date"></asp:TextBox>
                <asp:RequiredFieldValidator  runat="server" EnableClientScript="true" ErrorMessage="Please provide the enrollment date!" ControlToValidate="enrollment_date"></asp:RequiredFieldValidator>
            </div>
        </section>
         <section>
            <asp:Button runat="server" Text="Save" CssClass="save_button"/>
        </section>
    </div>
</asp:Content>
