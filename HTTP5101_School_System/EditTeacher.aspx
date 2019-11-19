<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="EditTeacher.aspx.cs" Inherits="HTTP5101_School_System.EditTeacher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <div id="teacher" runat="server">
        <section>
            <h1>Update Teacher Details</h1>
            <div>
                <label for="teacher_fname">First Name:</label>
                <asp:TextBox runat="server" id="teacher_fname"></asp:TextBox>
                <asp:RequiredFieldValidator  runat="server" EnableClientScript="true" ErrorMessage="Please provide the first name!" ControlToValidate="teacher_fname"></asp:RequiredFieldValidator>
            </div>
            <div>
                <label for="teacher_lname">Last Name:</label>
                <asp:TextBox runat="server" id="teacher_lname"></asp:TextBox>
                <asp:RequiredFieldValidator  runat="server" EnableClientScript="true" ErrorMessage="Please provide the last name!" ControlToValidate="teacher_lname"></asp:RequiredFieldValidator>
            </div>
            <div>
                <label for="employee_number">Employee Number</label>
                <asp:TextBox runat="server" id="employee_number"></asp:TextBox>
                <asp:RequiredFieldValidator  runat="server" EnableClientScript="true" ErrorMessage="Please provide the employee number!" ControlToValidate="employee_number"></asp:RequiredFieldValidator>
            </div>
            <div>
                <label for="hire_date">Hire Date</label>
                <asp:TextBox runat="server" id="hire_date"></asp:TextBox>
                <asp:RequiredFieldValidator  runat="server" EnableClientScript="true" ErrorMessage="Please provide the hire date!" ControlToValidate="hire_date"></asp:RequiredFieldValidator>
            </div>
            <div>
                <label for="salary">Salary</label>
                <asp:TextBox runat="server" id="salary"></asp:TextBox>
                <asp:RequiredFieldValidator  runat="server" EnableClientScript="true" ErrorMessage="Please provide the salary!" ControlToValidate="salary"></asp:RequiredFieldValidator>
            </div>
        </section>
         <section>
            <asp:Button runat="server" Text="Submit"/>
        </section>
    </div>
</asp:Content>
