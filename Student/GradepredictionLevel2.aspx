<%@ Page Language="C#" MasterPageFile="~/Student/Student.master" AutoEventWireup="true" CodeFile="GradepredictionLevel2.aspx.cs" Inherits="Student_Gradeprediction" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <style type ="text/css" >
    html
    {
  
    }
    .menuTabs
    { position:relative;
      top:1px;
        }
    	.tab
    	{ border:solid 1px back;
    	   border-bottom:none;
    	   padding:0px 10px;
    	   background-color:White;
    		}
    	
    	.selectedTab
    	{ border:solid 1px black;
    	  border-bottom:solid 1px white;
    	  padding :0px 10px;
    	   background-color:White;
    		}	
    		.tabBosy
    		{
    			 border :solid 1px black;
    			 padding:20px;
    		 	background-color:#F5F5DC;
    		    border-bottom-style:none;
    		    border-right-style:none;
    		    border-left-style:none;
    			}
    
     .tdbodertop
    {
    	 border-top:1px #111111 solid;
    	 
    }
    .style12
    {
        width: 100%;
    }
    </style>
   <script type="text/javascript">
 function checklimit(id){
  
  if(isNaN(document.getElementById(id).value)){
   alert("Value should be numeric");
   document.getElementById(id).value="";
   document.getElementById(id).focus();
   return false; 
  }
  else{
  if(parseInt(document.getElementById(id).value)>100){
  alert("Value should be <=100");
  document.getElementById(id).value="";
  document.getElementById(id).focus();
  return false;
  }
  }
 }
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center>
<div style="background-color:#FFF0F5">
    <%--<asp:Menu ID="menuTabss" CssClass ="menuTabs" 
        StaticMenuItemStyle-CssClass="tab" StaticSelectedStyle-CssClass ="selectedTab"  
        runat ="server" Orientation="Horizontal" 
        onmenuitemclick="menuTabss_MenuItemClick" BorderColor="#999999" 
        BorderStyle="Outset" BorderWidth="4px">
<StaticSelectedStyle CssClass="selectedTab"></StaticSelectedStyle>
<StaticMenuItemStyle CssClass="tab"></StaticMenuItemStyle>
    <Items>
      <asp:MenuItem Text ="Level-4"></asp:MenuItem>
      <asp:MenuItem Text ="Level-5"></asp:MenuItem>
      <asp:MenuItem Text ="Level-6"></asp:MenuItem>
      <asp:MenuItem Text ="Summery View"></asp:MenuItem>
    </Items>
    </asp:Menu>--%>
    <asp:Menu ID="menuTabss" CssClass ="menuTabs" 
        StaticMenuItemStyle-CssClass="tab" StaticSelectedStyle-CssClass ="selectedTab"  
        runat ="server" Orientation="Horizontal" 
        onmenuitemclick="menuTabss_MenuItemClick" BackColor="#999999" 
        BorderStyle="Outset" BorderWidth="4px">
<StaticSelectedStyle CssClass="selectedTab"></StaticSelectedStyle>
<StaticMenuItemStyle CssClass="tab"></StaticMenuItemStyle>
    <Items>
      <asp:MenuItem Text ="Level-4"></asp:MenuItem>
      <asp:MenuItem Text ="Level-5"></asp:MenuItem>
      <asp:MenuItem Text ="Level-6"></asp:MenuItem>
      <asp:MenuItem Text ="Summary"></asp:MenuItem>
    </Items>
    </asp:Menu>
    </div>
    </center>
    <div>
<asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex ="0" >
 <asp:View  ID="View1" runat ="server">
 <center>
 <asp:Panel ID="Panel1" runat="server" ScrollBars="Horizontal" Width="820px"> 
     <table width="100%" cellpadding="0px" cellspacing="0px" style="border: thin double #000000; background-color:ActiveBorder">
         <tr>
             <td align="center" colspan="12" bgcolor="LavenderBlush">
                 <asp:Label ID="Label111" runat="server" Font-Bold="True" Font-Size="Medium" 
                     Font-Underline="True" ForeColor="#FF3300" Text="At Level-5"></asp:Label>
             </td>
         </tr>
         <tr>
             <td align="center" bgcolor="#E8E8E8" colspan="12">
                 <table class="style12">
                     <tr>
                         <td align="right" valign="top" width="50%">
                             <asp:Label ID="lblmsg" runat="server"></asp:Label>
                         </td>
                         <td align="left" width="50%">
                             &nbsp;</td>
                     </tr>
                     <tr>
                         <td align="right" valign="top" width="50%">
                             <asp:TextBox ID="txtavg1styear" runat="server" ReadOnly="True"></asp:TextBox>
                         </td>
                         <td align="left" width="50%">
                             <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                                 Text="Calculate" />
                             <asp:Button ID="btnnext" runat="server" onclick="btnnext_Click" Text="-Next-" 
                                 Width="90px" />
                         </td>
                     </tr>
                     <tr>
                         <td align="right" valign="top" width="50%">
                             &nbsp;</td>
                         <td align="left" width="50%">
                             &nbsp;</td>
                     </tr>
                 </table>
             </td>
         </tr>
         <tr >
             <td class="tdbodertop">
                 <asp:Label ID="lblmod1" runat="server" Font-Bold="True" ForeColor="#0066FF" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass1mod1" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass2mod1" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass3mod1" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass4mod1" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass5mod1" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass6mod1" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass7mod1" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass8mod1" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass9mod1" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass10mod1" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="Label12" runat="server" ForeColor="#FF3300">T.(100%)</asp:Label>
             </td>
         </tr>
         <tr bgcolor="LavenderBlush">
             <td class="tdbodertop">
                 &nbsp;</td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                 <asp:TextBox ID="txtass1mod1" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass1mod1_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate>
                 </asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate> <asp:TextBox ID="txtass2mod1" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass2mod1_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass3mod1" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass3mod1_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                    <ContentTemplate> <asp:TextBox ID="txtass4mod1" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass4mod1_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass5mod1" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass5mod1_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                    <ContentTemplate> <asp:TextBox ID="txtass6mod1" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass6mod1_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                    <ContentTemplate> <asp:TextBox ID="txtass7mod1" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass7mod1_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass8mod1" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass8mod1_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass9mod1" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass9mod1_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel10" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass10mod1" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass10mod1_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                <asp:UpdatePanel ID="UpdatePanel11" runat="server">
                    <ContentTemplate> <asp:TextBox ID="TextBox12" runat="server" Width="40px" 
                            onkeyup="checklimit(this.id)" ReadOnly="True"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
         </tr>
         <tr>
             <td class="tdbodertop">
                 <asp:Label ID="lblmod2" runat="server" ForeColor="#0066FF" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass1mod2" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass2mod2" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass3mod2" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass4mod2" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass5mod2" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass6mod2" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass7mod2" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass8mod2" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass9mod2" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass10mod2" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="Label105" runat="server" ForeColor="#FF3300">T.(100%)</asp:Label>
             </td>
         </tr>
         <tr bgcolor="LavenderBlush">
             <td class="tdbodertop">
                 &nbsp;</td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel12" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass1mod2" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass1mod2_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel13" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass2mod2" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass2mod2_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel14" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass3mod2" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass3mod2_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                <asp:UpdatePanel ID="UpdatePanel15" runat="server">
                    <ContentTemplate> <asp:TextBox ID="txtass4mod2" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass4mod2_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                <asp:UpdatePanel ID="UpdatePanel16" runat="server">
                    <ContentTemplate> <asp:TextBox ID="txtass5mod2" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass5mod2_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                <asp:UpdatePanel ID="UpdatePanel17" runat="server">
                    <ContentTemplate> <asp:TextBox ID="txtass6mod2" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass6mod2_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td >
            <td class="tdbodertop">
                  <asp:UpdatePanel ID="UpdatePanel18" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass7mod2" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass7mod2_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel19" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass8mod2" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass8mod2_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                <asp:UpdatePanel ID="UpdatePanel20" runat="server">
                    <ContentTemplate> <asp:TextBox ID="txtass9mod2" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass9mod2_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                <asp:UpdatePanel ID="UpdatePanel21" runat="server">
                    <ContentTemplate> <asp:TextBox ID="txtass10mod2" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass10mod2_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel22" runat="server">
                    <ContentTemplate><asp:TextBox ID="TextBox23" runat="server" Width="40px" 
                            onkeyup="checklimit(this.id)" ReadOnly="True"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
         </tr>
         <tr>
             <td class="tdbodertop">
                 <asp:Label ID="lblmod3" runat="server" ForeColor="#0066FF" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass1mod3" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass2mod3" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass3mod3" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass4mod3" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass5mod3" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass6mod3" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass7mod3" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass8mod3" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass9mod3" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass10mod3" runat="server" CssClass="#85582C" ForeColor="#85582C" 
                     Font-Bold="True" Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="Label106" runat="server" ForeColor="#FF3300">T.(100%)</asp:Label>
             </td>
         </tr>
         <tr bgcolor="LavenderBlush">
             <td class="tdbodertop">
                 &nbsp;</td>
             <td class="tdbodertop">
                <asp:UpdatePanel ID="UpdatePanel23" runat="server">
                    <ContentTemplate> <asp:TextBox ID="txtass1mod3" runat="server" Width="40px" 
                     ontextchanged="txtass1mod3_TextChanged" AutoPostBack="True" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel24" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass2mod3" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass2mod3_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                <asp:UpdatePanel ID="UpdatePanel25" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass3mod3" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass3mod3_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel26" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass4mod3" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass4mod3_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel27" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass5mod3" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass5mod3_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel28" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass6mod3" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass6mod3_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel29" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass7mod3" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass7mod3_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel30" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass8mod3" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass8mod3_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel31" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass9mod3" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass9mod3_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel32" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass10mod3" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass10mod3_TextChanged" onkeyup="checklimit(this.id)" ></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                <asp:UpdatePanel ID="UpdatePanel33" runat="server">
                    <ContentTemplate> <asp:TextBox ID="TextBox34" runat="server" Width="40px" 
                            AutoPostBack="True" onkeyup="checklimit(this.id)" ReadOnly="True"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
         </tr>
         <tr>
             <td class="tdbodertop">
                 <asp:Label ID="lblmod4" runat="server" ForeColor="#0066FF" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass1mod4" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass2mod4" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass3mod4" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass4mod4" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass5mod4" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass6mod4" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass7mod4" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass8mod4" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass9mod4" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass10mod4" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="Label107" runat="server" ForeColor="#FF3300">T.(100%)</asp:Label>
             </td>
         </tr>
         <tr bgcolor="LavenderBlush">
             <td class="tdbodertop">
                 &nbsp;</td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel34" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass1mod4" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass1mod4_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel35" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass2mod4" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass2mod4_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel36" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass3mod4" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass3mod4_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel37" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass4mod4" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass4mod4_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel38" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass5mod4" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass5mod4_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel39" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass6mod4" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass6mod4_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel40" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass7mod4" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass7mod4_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel41" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass8mod4" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass8mod4_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel42" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass9mod4" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass9mod4_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel43" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass10mod4" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass10mod4_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel44" runat="server">
                    <ContentTemplate><asp:TextBox ID="TextBox45" runat="server" Width="40px" 
                            onkeyup="checklimit(this.id)" ReadOnly="True"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
         </tr>
         <tr>
             <td class="tdbodertop">
                 <asp:Label ID="lblmod5" runat="server" ForeColor="#0066FF" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop"> 
                 <asp:Label ID="ass1mod5" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass2mod5" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass3mod5" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass4mod5" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass5mod5" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass6mod5" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass7mod5" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass8mod5" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass9mod5" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass10mod5" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="Label108" runat="server" ForeColor="#FF3300">T.(100%)</asp:Label>
             </td>
         </tr>
         <tr bgcolor="LavenderBlush">
             <td class="tdbodertop">
                 &nbsp;</td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel45" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass1mod5" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass1mod5_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel46" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass2mod5" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass2mod5_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                <asp:UpdatePanel ID="UpdatePanel47" runat="server">
                    <ContentTemplate> <asp:TextBox ID="txtass3mod5" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass3mod5_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                <asp:UpdatePanel ID="UpdatePanel48" runat="server">
                    <ContentTemplate> <asp:TextBox ID="txtass4mod5" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass4mod5_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel49" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass5mod5" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass5mod5_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel50" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass6mod5" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass6mod5_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel51" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass7mod5" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass7mod5_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel52" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass8mod5" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass8mod5_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel53" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass9mod5" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass9mod5_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel54" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass10mod5" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass10mod5_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                <asp:UpdatePanel ID="UpdatePanel55" runat="server">
                    <ContentTemplate><asp:TextBox ID="TextBox56" runat="server" Width="40px" 
                            onkeyup="checklimit(this.id)" ReadOnly="True"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
         </tr>
         <tr>
             <td class="tdbodertop">
                 <asp:Label ID="lblmod6" runat="server" ForeColor="#0066FF" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass1mod6" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass2mod6" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass3mod6" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass4mod6" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass5mod6" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass6mod6" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass7mod6" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass8mod6" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass9mod6" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass10mod6" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="Label109" runat="server" ForeColor="#FF3300">T.(100%)</asp:Label>
             </td>
         </tr>
         <tr bgcolor="LavenderBlush">
             <td class="tdbodertop">
                 &nbsp;</td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel56" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass1mod6" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass1mod6_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel57" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass2mod6" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass2mod6_TextChanged" ForeColor="#85582C" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel58" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass3mod6" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass3mod6_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel59" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass4mod6" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass4mod6_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel60" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass5mod6" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass5mod6_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel61" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass6mod6" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass6mod6_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                <asp:UpdatePanel ID="UpdatePanel62" runat="server">
                    <ContentTemplate> <asp:TextBox ID="txtass7mod6" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass7mod6_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel63" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass8mod6" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass8mod6_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel64" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass9mod6" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass9mod6_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel65" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass10mod6" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass10mod6_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel66" runat="server">
                    <ContentTemplate><asp:TextBox ID="TextBox67" runat="server" Width="40px" 
                            onkeyup="checklimit(this.id)" ReadOnly="True"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
         </tr>
         <tr>
             <td class="tdbodertop">
                 <asp:Label ID="lblmod7" runat="server" ForeColor="#0066FF" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass1mod7" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass2mod7" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass3mod7" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td>
                 <asp:Label ID="ass4mod7" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass5mod7" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass6mod7" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass7mod7" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass8mod7" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass9mod7" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass10mod7" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="Label110" runat="server" ForeColor="#FF3300">T.(100%)</asp:Label>
             </td>
         </tr>
         <tr bgcolor="LavenderBlush">
             <td class="tdbodertop">
                 &nbsp;</td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel67" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass1mod7" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass1mod7_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                <asp:UpdatePanel ID="UpdatePanel68" runat="server">
                    <ContentTemplate> <asp:TextBox ID="txtass2mod7" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass2mod7_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                <asp:UpdatePanel ID="UpdatePanel69" runat="server">
                    <ContentTemplate> <asp:TextBox ID="txtass3mod7" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass3mod7_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel70" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass4mod7" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass4mod7_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                <asp:UpdatePanel ID="UpdatePanel71" runat="server">
                    <ContentTemplate> <asp:TextBox ID="txtass5mod7" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass5mod7_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                <asp:UpdatePanel ID="UpdatePanel72" runat="server">
                    <ContentTemplate> <asp:TextBox ID="txtass6mod7" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass6mod7_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel73" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass7mod7" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass7mod7_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel74" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass8mod7" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass8mod7_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                <asp:UpdatePanel ID="UpdatePanel75" runat="server">
                    <ContentTemplate> <asp:TextBox ID="txtass9mod7" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass9mod7_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel76" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass10mod7" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass10mod7_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel77" runat="server">
                    <ContentTemplate><asp:TextBox ID="TextBox78" runat="server" Width="40px" 
                     ontextchanged="TextBox78_TextChanged" onkeyup="checklimit(this.id)" 
                            ReadOnly="True"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
         </tr>
         <tr>
             <td class="tdbodertop">
                 <asp:Label ID="lblmod8" runat="server" ForeColor="#0066FF" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td>
                 <asp:Label ID="ass1mod8" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass2mod8" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass3mod8" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass4mod8" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass5mod8" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass6mod8" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass7mod8" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td>
                 <asp:Label ID="ass8mod8" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass9mod8" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="ass10mod8" runat="server" ForeColor="#85582C" Font-Bold="True" 
                     Font-Size="X-Small"></asp:Label>
             </td>
             <td class="tdbodertop">
                 <asp:Label ID="Label103" runat="server" ForeColor="#FF3300">T.(100%)</asp:Label>
             </td>
         </tr>
         <tr bgcolor="LavenderBlush">
             <td class="tdbodertop">
                 &nbsp;</td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel78" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass1mod8" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass1mod8_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                <asp:UpdatePanel ID="UpdatePanel79" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass2mod8" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass2mod8_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                <asp:UpdatePanel ID="UpdatePanel80" runat="server">
                    <ContentTemplate> <asp:TextBox ID="txtass3mod8" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass3mod8_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                <asp:UpdatePanel ID="UpdatePanel81" runat="server">
                    <ContentTemplate> <asp:TextBox ID="txtass4mod8" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass4mod8_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel82" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass5mod8" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass5mod8_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                <asp:UpdatePanel ID="UpdatePanel83" runat="server">
                    <ContentTemplate> <asp:TextBox ID="txtass6mod8" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass6mod8_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                <asp:UpdatePanel ID="UpdatePanel84" runat="server">
                    <ContentTemplate> <asp:TextBox ID="txtass7mod8" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass7mod8_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel85" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass8mod8" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass8mod8_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                <asp:UpdatePanel ID="UpdatePanel86" runat="server">
                    <ContentTemplate> <asp:TextBox ID="txtass9mod8" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass9mod8_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel87" runat="server">
                    <ContentTemplate><asp:TextBox ID="txtass10mod8" runat="server" Width="40px" AutoPostBack="True" 
                     ontextchanged="txtass10mod8_TextChanged" onkeyup="checklimit(this.id)"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
             <td class="tdbodertop">
                 <asp:UpdatePanel ID="UpdatePanel88" runat="server">
                    <ContentTemplate><asp:TextBox ID="TextBox89" runat="server" Width="40px" 
                            AutoPostBack="True" onkeyup="checklimit(this.id)" ReadOnly="True"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
             </td>
         </tr>
     </table></asp:Panel></center>
 </asp:View>
<asp:View  ID="View2" runat ="server">     
</asp:View>
<asp:View  ID="View3" runat ="server">
</asp:View>
<asp:View  ID="View4" runat ="server">
</asp:View>         
  </asp:MultiView>
</div>
</asp:Content>

