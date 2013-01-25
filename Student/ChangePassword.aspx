<%@ Page Language="C#" MasterPageFile="~/Student/Student.master" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="Student_ChangePassword" Title="Untitled Page" %>
<%@ Register Src="~/userControl/changePasswordStepTwo.ascx" TagName="brnchdtl" TagPrefix="brnch" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
<brnch:brnchdtl ID="branch" runat="server"/>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

