<%@ Page Title="" Language="C#" MasterPageFile="~/mstr.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="images_Default" %>
<%@ Register Src="~/userControl/login.ascx" TagName="lgn" TagPrefix="luc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <luc1:lgn ID="loginid" runat="server" />
</asp:Content>

