<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ListClasses.aspx.cs" Inherits="HTTP5101_School_System.ListClasses" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
     <h1>Classes</h1>
    <div id="classes_result" class="_table" runat="server">
        <div class="listitem">
            <div class="col4">CLASS CODE</div>
            <div class="col4">START DATE</div>            
            <div class="col4">FINISH DATE</div>
            <div class="col4last">CLASS NAME</div>
            
        </div>
    </div>
</asp:Content>
