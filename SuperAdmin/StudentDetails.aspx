<%@ Page Language="C#" MasterPageFile="~/SuperAdmin/sa.master" AutoEventWireup="true" CodeFile="StudentDetails.aspx.cs" Inherits="SuperAdmin_StudentDetails" Title="Untitled Page" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/superAdmin.css" rel="stylesheet" type="text/css" />
<link href="../css/trinity_admin.css" rel="stylesheet" type="text/css" />
<link href="../css/trinity.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center >
<br />
      <div class="cmnClssRightTop1">Search Student Here</div>   
      <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
        <div id="divuserRegistD1">
         <div id="divuserRegistD2">
               <table width ="100%" cellpadding ="8" >

<tr class ="tbcolor2">
	<td colspan ="4" align="center" >
            
        <asp:TextBox CssClass="txtalignCntr" ID="txt_sno" runat="server" 
            ReadOnly="True" Width="30px" Visible="False"></asp:TextBox>
            
            <asp:Label ID="lbl_submit" runat="server" Font-Bold="True" Font-Size="X-Small"></asp:Label>
    </td>
	
		
</tr>
<tr class ="tbcolor1">
	
	<td>Course</td>
	<td>
            <asp:DropDownList ID="ddlmodule" runat="server" Width="150px" 
                onselectedindexchanged="ddlmodule_SelectedIndexChanged">
            </asp:DropDownList>
    </td>
	
	<td>
        Date of Registration</td>
	
	<td><asp:UpdatePanel ID="UpdatePanel6" runat="server">
        <ContentTemplate>
            <asp:TextBox ID="txt_date_of_joining" runat="server" Width="150px"></asp:TextBox>
            <asp:CalendarExtender ID="txt_date_of_joining_CalendarExtender" 
    Animated="true" FirstDayOfWeek="Sunday" Enabled="true"
                runat="server" TargetControlID="txt_date_of_joining" 
                Format="dd-M-yyyy"  PopupPosition="TopLeft" 
    PopupButtonID="img_doj" >
            </asp:CalendarExtender>
            <asp:ImageButton ID="img_doj" runat="server" CausesValidation="false" 
                Height="25px" ImageAlign="AbsBottom" ImageUrl="~/images/calendar2.gif" 
                ToolTip="Click Me to select Date" Width="25px" />
        </ContentTemplate>
        </asp:UpdatePanel>
    
    </td>
	
</tr>
<tr class ="tbcolor2">

	<td>Name </td>
	<td>
            <asp:TextBox ID="txtname" runat="server" Width="150px"></asp:TextBox>
        </td>
	
	<td>
        &nbsp;</td>
	
	<td>
           &nbsp;</td>
	
</tr>
<tr class ="tbcolor1">		
	<td colspan ="4" align ="center">
        <asp:Button ID="btn_submit" runat="server" Text="Search"
            onclick="btn_submit_Click"/>
        <asp:Button ID="Reset" runat="server" onclick="Reset_Click1" Text="Reset" />
    </td>

	
</tr>

</table>       
         </div>
        </div>



</center>
<center >
   <div id="cngridviewsmall" class="cngridviewsmall">
<asp:UpdatePanel ID="UpdatePanel5" runat="server">
    <ContentTemplate>
        <asp:GridView ID="GridView1" runat="server"
                AutoGenerateColumns ="False"   DataKeyNames ="SNo" 
                onrowediting="GridView1_RowEditing" AllowPaging="True" 
            CellPadding="4"   PagerSettings-Mode ="Numeric" 
            onpageindexchanging="GridView1_PageIndexChanging" 
            onrowdeleting="GridView1_RowDeleting" 
            onselectedindexchanging="GridView1_SelectedIndexChanging" 
             BackColor="#CCCCBB" BorderColor="Black" BorderStyle="Double" 
             BorderWidth="1px" ForeColor="Black" UseAccessibleHeader="False" >
            <Columns >
               
                <asp:BoundField DataField="EnrollementNo" HeaderText="Enroll.No/UID" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
               
               
                <asp:BoundField DataField="Pswd" HeaderText="Password" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
               
                <asp:BoundField DataField="Name" HeaderText="Name of Student" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
               
                <asp:BoundField DataField="Dob" HeaderText="DOB" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Gender" HeaderText="Gender" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Father" HeaderText="Name Of Father" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="RegDate" HeaderText="Date Of Reg" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Occupation" HeaderText="Occupation" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
              
                <asp:BoundField DataField="Present_Address" HeaderText="Present Add." 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Email" HeaderText="Email Id" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
              
                <asp:BoundField DataField="Emergency_Contact" HeaderText="Emergency Cont." 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Phone" HeaderText="Phone No" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:CommandField ShowEditButton ="true" EditImageUrl="~/images/edit.png" 
                    HeaderText="Edit" ButtonType="Image" Visible="false"/>
                <asp:TemplateField ShowHeader="False" HeaderText="Delete" 
                                                            ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                        <asp:ImageButton ID="lnkDeleteQuantity"  ImageUrl="~/images/delete.png" 
                                                                    runat= "server" 
                            CausesValidation="False" CommandName="Delete" 
                                                                    Text="Delete" 
                                                                    
                                                                    
                            OnClientClick="javascript:return confirm('Are you Sure ,You want to Delete The Item?');" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <PagerStyle ForeColor="Black" HorizontalAlign="Right" BackColor="White" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
        </asp:GridView>
    </ContentTemplate>
 </asp:UpdatePanel> 
</div>
</center>
</asp:Content>

