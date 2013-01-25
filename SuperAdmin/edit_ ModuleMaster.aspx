<%@ Page EnableEventValidation="true"  Title="" Language="C#" MasterPageFile="~/SuperAdmin/sa.master" AutoEventWireup="true" CodeFile="edit_ ModuleMaster.aspx.cs" Inherits="SuperAdmin_branch_details"%>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/trinity_admin.css" rel="stylesheet" type="text/css" />
<link href="../css/superAdmin.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
   <div class="cmnClssRightTop1">Edit Module Master</div>
   
   <div style="width:700px">
     <div style="float:left; width:200px">
       </div>
     
    
    
       <center>
     <div><asp:Label ID="lbl_submit" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="Small"></asp:Label></div>
   <div> <div id="divuserRegistDmodule">
         <div id="divuserRegistmod">
          <table id="abc"  cellpadding ="5" width="100%">    
    <tr class ="tbcolor1">
      
        <td >
            Module</td>
        <td align="left">
            <asp:DropDownList ID="ddlmodule" runat="server" Width="150px">
            </asp:DropDownList>
                          </td>
    </tr>
    <tr class ="tbcolor2">
      
        <td >
            Select year(Level)</td>
        <td align="left">
            <asp:DropDownList ID="ddlyear" runat="server" Width="150px">
                <asp:ListItem Value="0">-Select-</asp:ListItem>
                <asp:ListItem Value="1">1st</asp:ListItem>
                <asp:ListItem Value="2">2nd</asp:ListItem>
                <asp:ListItem Value="3">3rd</asp:ListItem>
                <asp:ListItem Value="4">4th</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ControlToValidate="ddlyear" ErrorMessage="#" InitialValue="0" 
                ValidationGroup="a"></asp:RequiredFieldValidator>
                          </td>
    </tr>
    <tr class ="tbcolor1">
        <td class="style12">
            Module Name</td>
        <td class="style12" align="left">
          
                    <asp:TextBox ID="txt_Module" runat="server" Width="150px" 
                        ValidationGroup="a"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_Module"
                        Display="Dynamic" ErrorMessage="*" ValidationGroup="a"></asp:RequiredFieldValidator>
              
        </td>
    </tr>
    <tr class ="tbcolor2">
        <td>
            Module
            Code</td>
        <td align="left">
            <asp:TextBox ID="txtcode" runat="server" Width="150px"></asp:TextBox>
        </td>
    </tr>
    <tr class ="tbcolor1">
        <td>
            Module Sem</td>
        <td align="left">
            <asp:DropDownList ID="ddlsem" runat="server" Width="150px">
                <asp:ListItem>Select</asp:ListItem>
                <asp:ListItem Value="1">Semester1</asp:ListItem>
                <asp:ListItem Value="2">Semester2</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr class ="tbcolor2">
        <td>
            Lecture Slot</td>
        <td valign="top" align="left">
           
            From:-<asp:TextBox ID="txtfrom" runat="server" Width="60px"></asp:TextBox>
            &nbsp;&nbsp;To:-<asp:TextBox 
                ID="txtto" runat="server" Width="60px"></asp:TextBox>
       </td>
    </tr>
    <tr class ="tbcolor1" valign="top">
        <td>
            Tutorial Slot</td>
        <td valign="top" align="left">
            From:-<asp:TextBox ID="txtfrommod" runat="server" Width="60px"></asp:TextBox>
            &nbsp; To:-<asp:TextBox 
                ID="txttomod" runat="server" Width="60px"></asp:TextBox>
        </td>
    </tr>
    <tr class ="tbcolor2">
        <td>
            Description of Module</td>
        <td align="left">
            <asp:TextBox ID="txtdescription" runat="server" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
    
    <tr class ="tbcolor2">
     
        <td colspan="2" align="center">
        
        </td>
    </tr>
    </table>

<table id="Table1"  cellpadding ="5" width="100%">    
    <tr class ="tbcolor1" runat ="server" id="r1">
      
        <td >
            <asp:Label ID="lblassesment" runat="server"></asp:Label>
        </td>
        <td align="left">
            <asp:TextBox ID="ass1" runat="server" Width="150px"></asp:TextBox>
            <asp:DropDownList ID="ddlassesment" runat="server" AutoPostBack="True" 
                Width="75px" onselectedindexchanged="ddlassesment_SelectedIndexChanged1" 
                Visible="False">
                <asp:ListItem Selected="True" Value ="0">Select</asp:ListItem>
                <asp:ListItem Value ="1">1</asp:ListItem>
                <asp:ListItem Value ="2">2</asp:ListItem>
                <asp:ListItem Value ="3">3</asp:ListItem>
                <asp:ListItem Value ="4">4</asp:ListItem>
                <asp:ListItem Value ="5">5</asp:ListItem>
                <asp:ListItem Value ="6">6</asp:ListItem>
            </asp:DropDownList>
           
                          </td>
    </tr>
    <tr class ="tbcolor3" id="r7" runat="server">
    
        <td colspan ="2" align ="center">
           
            <asp:Button ID="btnupdate" runat="server" OnClick="btnupdate_Click" 
                Text="Update" ValidationGroup="a" style="height: 26px" />
            
        </td>
    </tr>
</table>
</div></div>
</div>
       </center>
    
     
       </div> 
</asp:Content>

