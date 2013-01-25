<%@ Page Language="C#" MasterPageFile="~/Student/Student.master" AutoEventWireup="true" CodeFile="Summery.aspx.cs" Inherits="Student_Gradeprediction" Title="Untitled Page" %>
<%@ Register Src="~/userControl/ProgressBar.ascx" TagName="Progressbar" TagPrefix="uc1" %>
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
 <asp:View  ID="View2" runat ="server"> 
    <center>
 <asp:Panel ID="Panel1" runat="server" ScrollBars="Horizontal" Width="820px">
     <table  cellpadding="0px" cellspacing="0px" width="90%">
        <tr>
            <td width="20%">
                &nbsp;</td>
            <td width="20%">
                &nbsp;</td>
            <td width="20%">
                &nbsp;</td>
            <td width="30%">
                <asp:Label ID="labelTogetFirst" runat="server" Text="..."></asp:Label>
            </td>
            <td width="10%">
                &nbsp;</td>
        </tr>
         <tr>
             <td width="20%">
                 &nbsp;</td>
             <td align="right" colspan="2" style="width: 40%" width="20%">
                 <asp:Label ID="Label16" runat="server" Font-Bold="True" Font-Size="Large" 
                     Font-Underline="True" ForeColor="#33CC33" Text="Your Degree Class Is:"></asp:Label>
             </td>
             <td align="left" width="30%" valign="top">
                 <asp:Label ID="lbldegree" runat="server" Font-Bold="True" Font-Italic="True" 
                     Font-Size="Medium"></asp:Label>
                 <asp:ImageButton ID="ImageButton1" runat="server" 
                     ImageUrl="~/images/imagesexpression.jpg" />
                 <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/images/sad.bmp" />
             </td>
             <td width="10%">
                 &nbsp;</td>
         </tr>
         <tr>
             <td width="20%">
                 &nbsp;</td>
             <td width="20%">
                 &nbsp;</td>
             <td width="20%">
                 &nbsp;</td>
             <td width="30%">
                 &nbsp;</td>
             <td width="10%">
                 &nbsp;</td>
         </tr>
        <tr>
            <td align="center">
                <asp:UpdatePanel ID="UpdatePanel45" runat="server">
                    <ContentTemplate>
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Small" 
                    Font-Underline="False" Text="Year One Result"></asp:Label>
           </ContentTemplate>
                </asp:UpdatePanel> </td>
            <td align="center">
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Small" 
                    Font-Underline="False" Text="Year Two Result"></asp:Label>
            </td>
            <td align="center">
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Small" 
                    Font-Underline="False" Text="Year Three Result"></asp:Label>
            </td>
            <td align="center">
                <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Small" 
                    Font-Underline="False" Text="Progress Bars"></asp:Label>
            </td>
            <td align="center">
                <asp:Label ID="Label17" runat="server" Font-Bold="True" Font-Size="Small" 
                    Font-Underline="False" Text="(%)"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="center">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate><asp:ImageButton ID="imgbtny1m1" runat="server" 
                    ImageUrl="~/images/modul1.jpg" onclick="imgbtny1m1_Click" /></ContentTemplate>
                </asp:UpdatePanel>
            </td>
            <td align="center">
                 <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate><asp:ImageButton ID="imgbtny2m1" runat="server"  ImageUrl="~/images/modul1.jpg" 
                    onclick="imgbtny2m1_Click"/></ContentTemplate></asp:UpdatePanel>
            </td>
            <td align="center"> <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                    <ContentTemplate>
                <asp:ImageButton ID="imgbtny3m1" runat="server"  ImageUrl="~/images/modul1.jpg" 
                    onclick="imgbtny3m1_Click"/></ContentTemplate></asp:UpdatePanel>
            </td>
            <td align="right"> <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                    <ContentTemplate>
                        <asp:Label ID="labelBar1" runat="server" Text="Assignemnt 1"></asp:Label>
                        <uc1:Progressbar ID="Progressbar1" runat="server" 
                    BGColor="White" Blocks="20" BorderColor="Black"
            BorderSize="1" Cellpadding="1" CellSpacing="1" FillColor="Green" Height="20" Value="10"
            Width="175" />
                        
                    </ContentTemplate></asp:UpdatePanel></td>
            <td align="center">
                 <asp:UpdatePanel ID="UpdatePanel35" runat="server">
                    <ContentTemplate><asp:Label ID="Label5" runat="server"></asp:Label></ContentTemplate></asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="center">
                <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                    <ContentTemplate> <asp:ImageButton ID="imgbtny1m2" runat="server" 
                    ImageUrl="~/images/modul2.jpg" onclick="imgbtny1m2_Click" />
            </ContentTemplate></asp:UpdatePanel></td>
            <td align="center">
                 <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                    <ContentTemplate><asp:ImageButton ID="imgbtny2m2" runat="server"  ImageUrl="~/images/modul2.jpg" 
                    onclick="imgbtny2m2_Click"/></ContentTemplate></asp:UpdatePanel>
            </td>
            <td align="center">
                 <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                    <ContentTemplate><asp:ImageButton ID="imgbtny3m2" runat="server"  ImageUrl="~/images/modul2.jpg" 
                    onclick="imgbtny3m2_Click" /></ContentTemplate></asp:UpdatePanel>
            </td>
            <td align="right">
                <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                    <ContentTemplate> 
                        <asp:Label ID="labelBar2" runat="server" Text="Assignemnt 2"></asp:Label>
                        <uc1:Progressbar ID="Progressbar2" runat="server" BGColor="White" Blocks="20" 
                    BorderColor="Black" BorderSize="1" Cellpadding="1" CellSpacing="1" 
                    FillColor="Green" Height="20" Value="10" Width="175" /></ContentTemplate></asp:UpdatePanel>
            </td>
            <td align="center"><asp:UpdatePanel ID="UpdatePanel36" runat="server">
                    <ContentTemplate>
                <asp:Label ID="Label6" runat="server"></asp:Label></ContentTemplate></asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="center">
                 <asp:UpdatePanel ID="UpdatePanel12" runat="server">
                    <ContentTemplate><asp:ImageButton ID="imgbtny1m3" runat="server" 
                    ImageUrl="~/images/modul3.jpg" onclick="imgbtny1m3_Click" /></ContentTemplate></asp:UpdatePanel>
            </td>
            <td align="center">
                 <asp:UpdatePanel ID="UpdatePanel11" runat="server">
                    <ContentTemplate><asp:ImageButton ID="imgbtny2m3" runat="server"  ImageUrl="~/images/modul3.jpg" 
                    onclick="imgbtny2m3_Click"/></ContentTemplate></asp:UpdatePanel>
            </td>
            <td align="center"> <asp:UpdatePanel ID="UpdatePanel10" runat="server">
                    <ContentTemplate>
                <asp:ImageButton ID="imgbtny3m3" runat="server"  ImageUrl="~/images/modul3.jpg" 
                    onclick="imgbtny3m3_Click"/></ContentTemplate></asp:UpdatePanel>
            </td>
            <td align="right"> <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                    <ContentTemplate>
                        <asp:Label ID="labelBar3" runat="server" Text="Assignemnt 3"></asp:Label>
                <uc1:Progressbar ID="Progressbar3" runat="server" BGColor="White" Blocks="20" 
                    BorderColor="Black" BorderSize="1" Cellpadding="1" CellSpacing="1" 
                    FillColor="Green" Height="20" Value="10" Width="175" />
            </ContentTemplate></asp:UpdatePanel></td>
            <td align="center">
               <asp:UpdatePanel ID="UpdatePanel37" runat="server">
                    <ContentTemplate> <asp:Label ID="Label7" runat="server"></asp:Label></ContentTemplate></asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="center">
                <asp:UpdatePanel ID="UpdatePanel13" runat="server">
                    <ContentTemplate> <asp:ImageButton ID="imgbtny1m4" runat="server" 
                    ImageUrl="~/images/modul4.jpg" onclick="imgbtny1m4_Click" /></ContentTemplate></asp:UpdatePanel>
            </td>
            <td align="center">
                 <asp:UpdatePanel ID="UpdatePanel14" runat="server">
                    <ContentTemplate><asp:ImageButton ID="imgbtny2m4" runat="server"  ImageUrl="~/images/modul4.jpg" 
                    onclick="imgbtny2m4_Click"/></ContentTemplate></asp:UpdatePanel>
            </td>
            <td align="center">
                <asp:UpdatePanel ID="UpdatePanel15" runat="server">
                    <ContentTemplate> <asp:ImageButton ID="imgbtny3m4" runat="server"  ImageUrl="~/images/modul4.jpg" 
                    onclick="imgbtny3m4_Click"/></ContentTemplate></asp:UpdatePanel>
            </td>
            <td align="right">
                 <asp:UpdatePanel ID="UpdatePanel16" runat="server">
                    <ContentTemplate>
                        <asp:Label ID="labelBar4" runat="server" Text="Assignment 4"></asp:Label>
                        <uc1:Progressbar ID="Progressbar4" runat="server" BGColor="White" Blocks="20" 
                    BorderColor="Black" BorderSize="1" Cellpadding="1" CellSpacing="1" 
                    FillColor="Green" Height="20" Value="10" Width="175" /></ContentTemplate></asp:UpdatePanel>
            </td>
            <td align="center">
                <asp:UpdatePanel ID="UpdatePanel38" runat="server">
                    <ContentTemplate><asp:Label ID="Label8" runat="server"></asp:Label></ContentTemplate></asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="center"> <asp:UpdatePanel ID="UpdatePanel17" runat="server">
                    <ContentTemplate>
                <asp:ImageButton ID="imgbtny1m5" runat="server"  ImageUrl="~/images/modul5.jpg" 
                    onclick="imgbtny1m5_Click" /></ContentTemplate></asp:UpdatePanel>
            </td>
            <td align="center">
                <asp:UpdatePanel ID="UpdatePanel18" runat="server">
                    <ContentTemplate> <asp:ImageButton ID="imgbtny2m5" runat="server"  ImageUrl="~/images/modul5.jpg" 
                    onclick="imgbtny2m5_Click"/></ContentTemplate></asp:UpdatePanel>
            </td>
            <td align="center"> <asp:UpdatePanel ID="UpdatePanel19" runat="server">
                    <ContentTemplate>
                <asp:ImageButton ID="imgbtny3m5" runat="server"  ImageUrl="~/images/modul5.jpg" 
                    onclick="imgbtny3m5_Click" /></ContentTemplate></asp:UpdatePanel>
            </td>
            <td align="right"> <asp:UpdatePanel ID="UpdatePanel20" runat="server">
                    <ContentTemplate>
                        <asp:Label ID="labelBar5" runat="server" Text="Assignemnt 5"></asp:Label>
                <uc1:Progressbar ID="Progressbar5" runat="server" BGColor="White" Blocks="20" 
                    BorderColor="Black" BorderSize="1" Cellpadding="1" CellSpacing="1" 
                    FillColor="Green" Height="20" Value="10" Width="175" /></ContentTemplate></asp:UpdatePanel>
            </td>
            <td align="center">
                <asp:UpdatePanel ID="UpdatePanel39" runat="server">
                    <ContentTemplate><asp:Label ID="Label9" runat="server"></asp:Label></ContentTemplate></asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="center"> <asp:UpdatePanel ID="UpdatePanel21" runat="server">
                    <ContentTemplate>
                <asp:ImageButton ID="imgbtny1m6" runat="server"  ImageUrl="~/images/modul6.jpg" 
                    onclick="imgbtny1m6_Click"/></ContentTemplate></asp:UpdatePanel>
            </td>
            <td align="center"> <asp:UpdatePanel ID="UpdatePanel22" runat="server">
                    <ContentTemplate>
                <asp:ImageButton ID="imgbtny2m6" runat="server"  ImageUrl="~/images/modul6.jpg" 
                    onclick="imgbtny2m6_Click"/></ContentTemplate></asp:UpdatePanel>
            </td>
            <td align="center"> <asp:UpdatePanel ID="UpdatePanel23" runat="server">
                    <ContentTemplate>
                <asp:ImageButton ID="imgbtny3m6" runat="server"  ImageUrl="~/images/modul6.jpg" 
                    onclick="imgbtny3m6_Click"/></ContentTemplate></asp:UpdatePanel>
            </td>
            <td align="right"> <asp:UpdatePanel ID="UpdatePanel24" runat="server">
                    <ContentTemplate>
                        <asp:Label ID="labelBar6" runat="server" Text="Assignemnt 6"></asp:Label>
                <uc1:Progressbar ID="Progressbar6" runat="server" BGColor="White" Blocks="20" 
                    BorderColor="Black" BorderSize="1" Cellpadding="1" CellSpacing="1" 
                    FillColor="Green" Height="20" Value="10" Width="175" /></ContentTemplate></asp:UpdatePanel>
            </td>
            <td align="center">
                <asp:UpdatePanel ID="UpdatePanel40" runat="server">
                    <ContentTemplate><asp:Label ID="Label10" runat="server"></asp:Label></ContentTemplate></asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="center"> <asp:UpdatePanel ID="UpdatePanel25" runat="server">
                    <ContentTemplate>
                <asp:ImageButton ID="imgbtny1m7" runat="server"  ImageUrl="~/images/modul7.jpg" 
                    onclick="imgbtny1m7_Click" /></ContentTemplate></asp:UpdatePanel>
            </td>
            <td align="center">
                 <asp:UpdatePanel ID="UpdatePanel26" runat="server">
                    <ContentTemplate><asp:ImageButton ID="imgbtny2m7" runat="server"  ImageUrl="~/images/modul7.jpg" 
                    onclick="imgbtny2m7_Click" /></ContentTemplate></asp:UpdatePanel>
            </td>
            <td align="center">
                 <asp:UpdatePanel ID="UpdatePanel27" runat="server">
                    <ContentTemplate><asp:ImageButton ID="imgbtny3m7" runat="server"  ImageUrl="~/images/modul7.jpg" 
                    onclick="imgbtny3m7_Click"/></ContentTemplate></asp:UpdatePanel>
            </td>
            <td align="right">
                 <asp:UpdatePanel ID="UpdatePanel28" runat="server">
                    <ContentTemplate>
                        <asp:Label ID="labelBar7" runat="server" Text="Assignemnt 7"></asp:Label>
                        <uc1:Progressbar ID="Progressbar7" runat="server" BGColor="White" Blocks="20" 
                    BorderColor="Black" BorderSize="1" Cellpadding="1" CellSpacing="1" 
                    FillColor="Green" Height="20" Value="10" Width="175" /></ContentTemplate></asp:UpdatePanel>
            </td>
            <td align="center">
                <asp:UpdatePanel ID="UpdatePanel41" runat="server">
                    <ContentTemplate><asp:Label ID="Label11" runat="server"></asp:Label></ContentTemplate></asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="center">
                 <asp:UpdatePanel ID="UpdatePanel29" runat="server">
                    <ContentTemplate><asp:ImageButton ID="imgbtny1m8" runat="server"  ImageUrl="~/images/modul8.jpg" 
                    onclick="imgbtny1m8_Click"/></ContentTemplate></asp:UpdatePanel>
            </td>
            <td align="center">
                 <asp:UpdatePanel ID="UpdatePanel30" runat="server">
                    <ContentTemplate><asp:ImageButton ID="imgbtny2m8" runat="server"  ImageUrl="~/images/modul8.jpg" 
                    onclick="imgbtny2m8_Click"/></ContentTemplate></asp:UpdatePanel>
            </td>
            <td align="center">
                <asp:UpdatePanel ID="UpdatePanel31" runat="server">
                    <ContentTemplate> <asp:ImageButton ID="imgbtny3m8" runat="server"  ImageUrl="~/images/modul8.jpg" 
                    onclick="imgbtny3m8_Click"/></ContentTemplate></asp:UpdatePanel>
            </td>
            <td align="right"> <asp:UpdatePanel ID="UpdatePanel32" runat="server">
                    <ContentTemplate>
                        <asp:Label ID="labelBar8" runat="server" Text="Assignemnt 8"></asp:Label>
                <uc1:Progressbar ID="Progressbar8" runat="server" BGColor="White" Blocks="20" 
                    BorderColor="Black" BorderSize="1" Cellpadding="1" CellSpacing="1" 
                    FillColor="Green" Height="20" Value="10" Width="175" /></ContentTemplate></asp:UpdatePanel>
            </td>
            <td align="center">
               <asp:UpdatePanel ID="UpdatePanel42" runat="server">
                    <ContentTemplate><asp:Label ID="Label12" runat="server"></asp:Label></ContentTemplate></asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td align="right"> <asp:UpdatePanel ID="UpdatePanel33" runat="server">
                    <ContentTemplate>
                        <asp:Label ID="labelBar9" runat="server" Text="Assignemnt 9"></asp:Label>
                <uc1:Progressbar ID="Progressbar9" runat="server" BGColor="White" Blocks="20" 
                    BorderColor="Black" BorderSize="1" Cellpadding="1" CellSpacing="1" 
                    FillColor="Green" Height="20" Value="10" Width="175" /></ContentTemplate></asp:UpdatePanel>
            </td>
            <td align="center">
               <asp:UpdatePanel ID="UpdatePanel43" runat="server">
                    <ContentTemplate> <asp:Label ID="Label13" runat="server"></asp:Label></ContentTemplate></asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td align="center">
                &nbsp;</td>
            <td align="center">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td align="right"><asp:UpdatePanel ID="UpdatePanel34" runat="server">
                    <ContentTemplate>
                        <asp:Label ID="labelBar10" runat="server" Text="Assignemnt 10"></asp:Label>
                <uc1:Progressbar ID="Progressbar10" runat="server" BGColor="White" Blocks="20" 
                    BorderColor="Black" BorderSize="1" Cellpadding="1" CellSpacing="1" 
                    FillColor="Green" Height="20" Value="10" Width="175" /></ContentTemplate></asp:UpdatePanel>
            </td>
            <td align="center">
                <asp:UpdatePanel ID="UpdatePanel44" runat="server">
                    <ContentTemplate><asp:Label ID="Label14" runat="server"></asp:Label></ContentTemplate></asp:UpdatePanel>
            </td>
        </tr>
    </table></asp:Panel></center>
 </asp:View>
<asp:View  ID="View3" runat ="server">     
</asp:View>
<asp:View  ID="View4" runat ="server">
</asp:View>
<asp:View  ID="View5" runat ="server">
</asp:View>
  </asp:MultiView>
</div>
</asp:Content>

