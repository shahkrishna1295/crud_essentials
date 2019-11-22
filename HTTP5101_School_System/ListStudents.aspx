<%@ Page Title="Specific" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ListStudents.aspx.cs" Inherits="HTTP5101_School_System.ListStudents" %>

<asp:Content ID="students_list" ContentPlaceHolderID="body" runat="server">
    <h1>Students</h1>
    <div id="student_nav">
        <asp:label runat="server">Search:</asp:label>
        <asp:TextBox ID="student_search" runat="server"></asp:TextBox>
        <asp:Button runat="server" text="Search" CssClass="search_button"/>
        <div id="sql_debugger" runat="server"></div>
      
    </div>
    <div>
        <asp:Button runat="server" text="ADD" OnClick="Add_Student" CssClass="add_button"/>
    </div>
    <div class="_table" runat="server">
        <div class="listitem">
            <div class="col6">FIRST NAME</div>
            <div class="col6">LAST NAME</div>
            <div class="col6">STUDENT NUMBER</div>
            <div class="col6">ENROLMENT DATE</div>
            <div class="col6"></div>
            <div class="col6last"></div> 
        </div>
        <div id="students_result" runat="server">

        </div>
    </div>
</asp:Content>
