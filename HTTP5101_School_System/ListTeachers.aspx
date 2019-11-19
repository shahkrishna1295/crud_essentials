<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ListTeachers.aspx.cs" Inherits="HTTP5101_School_System.ListTeachers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
<h1>Teachers</h1>
    <div id="searchbox">
        <asp:label for="teacher_search" runat="server">Search:</asp:label>
        <asp:TextBox ID="teacher_search" runat="server"></asp:TextBox>
        <asp:Button runat="server" text="Search"/>
    </div>
    <div id="teachers_result" class="_table" runat="server">
        <div class="listitem">
            <div class="col6">FIRST NAME</div>
            <div class="col6">LAST NAME</div>
            <div class="col6">EMPLOYEE NUMBER</div>            
            <div class="col6">HIRE DATE</div>
            <div class="col6">SALARY</div>
            <div class="col6last">EDIT</div>
        </div>
    </div>
</asp:Content>
