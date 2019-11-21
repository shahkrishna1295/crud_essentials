<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="AddClass.aspx.cs" Inherits="HTTP5101_School_System.AddClass" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <div>
        <div id="sql_debugger" runat="server"></div>
        <div>
            <asp:Label runat="server">CLASSCODE</asp:Label>
            <asp:TextBox runat="server" ID="classcode_input"></asp:TextBox>
        </div>
    
        <div>
            <asp:Label runat="server">TEACHERID</asp:Label>
            <asp:TextBox runat="server" ID="teacherid_input"></asp:TextBox>
        </div>
    
        <div>
            <asp:Label runat="server">STARTDATE</asp:Label>
            <asp:TextBox runat="server" ID="startdate_input"></asp:TextBox>
        </div>
    
        <div>
            <asp:Label runat="server">FINISHDATE</asp:Label>
        <asp:TextBox runat="server" ID="finishdate_input"></asp:TextBox>
        </div>
    
        <div>
            <asp:Label runat="server">CLASSNAME</asp:Label>
        <asp:TextBox runat="server" ID="classname_input"></asp:TextBox>
        </div>
    </div>
    <div>
        <asp:Button runat="server" Text="Add"/>
    </div>
    <div id="classes_result" runat="server">

    </div>
</asp:Content>
