﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="HTTP5101_School_System.AddStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <div>
        <div id="sql_debugger" runat="server"></div>
            <div>
                <h1>Add student here.!</h1>
            </div>
            <div>
                <asp:Label runat="server">FIRST NAME</asp:Label>
                <asp:TextBox runat="server" ID="fname_input"></asp:TextBox>
                <asp:RequiredFieldValidator  runat="server" EnableClientScript="true" ErrorMessage="Please provide the first name!" ControlToValidate="fname_input"></asp:RequiredFieldValidator>
            </div>
    
            <div>
                <asp:Label runat="server">LAST NAME</asp:Label>
                <asp:TextBox runat="server" ID="lname_input"></asp:TextBox>
                <asp:RequiredFieldValidator  runat="server" EnableClientScript="true" ErrorMessage="Please provide the last name!" ControlToValidate="lname_input"></asp:RequiredFieldValidator>
            </div>
    
            <div>
                <asp:Label runat="server">STUDENT NUMBER</asp:Label>
                <asp:TextBox runat="server" ID="studentno_input"></asp:TextBox>
                <asp:RequiredFieldValidator  runat="server" EnableClientScript="true" ErrorMessage="Please provide the student number!" ControlToValidate="studentno_input"></asp:RequiredFieldValidator>
            </div>
    
            <div>
                <asp:Label runat="server">ENROLLMENT DATE</asp:Label>
            <asp:TextBox runat="server" ID="enroldate_input"></asp:TextBox>
                <asp:RequiredFieldValidator  runat="server" EnableClientScript="true" ErrorMessage="Please provide the enrollement date!" ControlToValidate="enroldate_input"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div>
        <asp:Button runat="server" Text="Save" OnClick="Save_Student" CssClass="save_button"/>
    </div>
    <div id="students_result" runat="server">

    </div>
</asp:Content>
