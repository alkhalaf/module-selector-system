<%@ Page Language="C#" MasterPageFile="~/SuperAdmin/sa.master" AutoEventWireup="true" CodeFile="Barchart.aspx.cs" Inherits="SuperAdmin_Barchart" Title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
<meta http-equiv="content-type" content="text/html; charset=utf-8"/>
     <title>
         Google Visualization API Sample
     </title>
     <%--the below two javascripts  are needed to run this program you can
      also download this script from the below link --%>
  
    <script type="text/javascript" src="https://www.google.com/jsapi"></script>
     <script type="text/javascript">
       google.load('visualization', '1', {packages: ['corechart']});
     </script>
<link href="../css/trinity_admin.css" rel="stylesheet" type="text/css" />
<link href="../css/superAdmin.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center>
   
   <div class="cmnClssRightTop1">Bar-Chart</div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
      <div id="divbranchD1">
          <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                <ContentTemplate>        
                <asp:Label ID="lbl_submit" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="Small"></asp:Label>
        </ContentTemplate>
        </asp:UpdatePanel>
          <div id="divbranchD2">
          <table  cellpadding ="5" width ="530">    
    <tr class ="tbcolor1">
      
        <td >
            Course</td>
        <td>
           <%-- <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>--%>
                    <asp:DropDownList ID="ddlcourse" runat="server" Width="150px" 
                        AutoPostBack="True" 
                        onselectedindexchanged="ddlmodule_SelectedIndexChanged">
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                <%--</ContentTemplate>
            </asp:UpdatePanel>--%>
        </td>
        <td>
            Level</td>
        <td><%--<asp:UpdatePanel ID="UpdatePanel5" runat="server">
                <ContentTemplate>--%>
            <asp:DropDownList ID="ddlyear" runat="server" Width="150px" AutoPostBack="True" 
                onselectedindexchanged="ddlyear_SelectedIndexChanged">
                <asp:ListItem Value="0">-Select-</asp:ListItem>
                <asp:ListItem Value="1">4th</asp:ListItem>
                <asp:ListItem Value="2">5th</asp:ListItem>
                <asp:ListItem Value="3">6th</asp:ListItem>
            </asp:DropDownList><%--</ContentTemplate></asp:UpdatePanel>--%>
        </td>
    </tr>
    <tr class ="tbcolor2">
        <td>
            Student Enroll. No</td>
        <td>
            <asp:DropDownList ID="ddlregno" runat="server" Width="150px" AutoPostBack="True" 
                onselectedindexchanged="ddlass_SelectedIndexChanged">
                <asp:ListItem Value="0">-Select-</asp:ListItem>
                <asp:ListItem Value="1">Assesment-1</asp:ListItem>
                <asp:ListItem Value="2">Assesment-2</asp:ListItem>
                <asp:ListItem Value="3">Assesment-3</asp:ListItem>
                <asp:ListItem Value="4">Assesment-4</asp:ListItem>
                <asp:ListItem Value="5">Assesment-5</asp:ListItem>
                <asp:ListItem Value="6">Assesment-6</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            Choose Order</td>
        <td>
                <asp:DropDownList ID="ddorder" runat="server" Width="150px" AutoPostBack="True" 
                onselectedindexchanged="DropDownList4_SelectedIndexChanged">
                    <asp:ListItem Value="0">-Select-</asp:ListItem>
                    <asp:ListItem Value="1">Alphabetical Order</asp:ListItem>
                    <asp:ListItem Value="2">Ascending</asp:ListItem>
                    <asp:ListItem Value="3">Descending</asp:ListItem>
                </asp:DropDownList>
           
        </td>
    </tr>
    <tr class ="tbcolor1">
     
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    </table>
         </div>
         </div>
    

<br />
<div>

<asp:UpdatePanel ID="UpdatePanel4" runat="server">
        </asp:UpdatePanel>
</div>
</center>
 <center>
    <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                <ContentTemplate> <asp:Literal ID="lt" runat="server"></asp:Literal></ContentTemplate></asp:UpdatePanel>

    <div id="chart_div" style="width:500px; height: 400px;">
    <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                <ContentTemplate></ContentTemplate></asp:UpdatePanel>
    
    </div>

</center>

</asp:Content>

