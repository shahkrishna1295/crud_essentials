<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ListClasses.aspx.cs" Inherits="HTTP5101_School_System.ListClasses" %>
<asp:Content ID="classes_list" ContentPlaceHolderID="body" runat="server">
     <h1>Classes</h1>
    <div id="class_nav">
        <asp:label for="class_search" runat="server">Search:</asp:label>
        <asp:TextBox ID="class_search" runat="server"></asp:TextBox>
        <asp:Button runat="server" text="submit"/>
        <div id="sql_debugger" runat="server"></div>
    </div>
    <div id="add_button">
        <asp:Button runat="server" text="ADD"/>
    </div>
    <div class="_table" runat="server">
        <div class="listitem">
            <div class="col6">CLASS ID</div>
            <div class="col6">CLASS CODE</div>
            <div class="col6">TEACHER ID</div>
            <div class="col6">START DATE</div>            
            <div class="col6">FINISH DATE</div>
            <div class="col6last">CLASS NAME</div> 
        </div>
        <div id="classes_result" runat="server">

        </div>
    </div>
</asp:Content>
