<%@ Page Title="" Language="C#" MasterPageFile="~/Master/MasterPage_1.Master" AutoEventWireup="true" CodeBehind="MasterPageDemo.aspx.cs" Inherits="WebformE.MasterPageDemo" %>
<%@ MasterType VirtualPath="~/Master/MasterPage_1.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <h2>This is Header</h2>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>this content Page1</h2>
    <asp:Label ID="lblPage1" runat="server"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cp2" runat="server">
    <h2>this content Page2</h2>
</asp:Content>
