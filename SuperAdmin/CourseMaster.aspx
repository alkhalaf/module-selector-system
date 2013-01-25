<%@ Page Title="" Language="C#" MasterPageFile="~/SuperAdmin/sa.master" AutoEventWireup="true" CodeFile="CourseMaster.aspx.cs" Inherits="SuperAdmin_branch_details" %>
<%@ Register Src="~/userControl/CityMaster.ascx" TagName="brnchdtl" TagPrefix="brnch" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
  
<link href="../css/trinity_admin.css" rel="stylesheet" type="text/css" />
<link href="../css/superAdmin.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <brnch:brnchdtl ID="branch" runat="server"/>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

