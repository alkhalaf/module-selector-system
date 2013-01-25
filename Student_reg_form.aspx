<%@ Page Language="C#" MasterPageFile="~/mstr.master" AutoEventWireup="true" CodeFile="Student_reg_form.aspx.cs" Inherits="Student_reg_form" Title="Untitled Page" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/superAdmin.css" rel="stylesheet" type="text/css" />
<link href="css/trinity_admin.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server"> 
    <asp:ToolkitScriptManager ID="ToolkitScriptManager2" runat="server">
        </asp:ToolkitScriptManager> 
    <center >
<br />
    <div class="cmnClssRightTop1"> Student-Registration (<asp:HyperLink 
            ID="HyperLink1" runat="server" Font-Bold="True" ForeColor="#003a99" NavigateUrl="~/Default.aspx">(Go To Home)</asp:HyperLink>
        )</div>   
        <div id="divuserRegistD1">
         <div id="divuserRegistD2">
               <table width ="100%" cellpadding ="6" >

<tr class ="tbcolor1">
	<td colspan ="4" align="center" >
            
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
        <asp:Label ID="lbl_submit" runat="server" Font-Bold="True" 
            Font-Size="Small" ForeColor="#FF3300"></asp:Label></ContentTemplate>
        </asp:UpdatePanel>
    </td>
	
		
</tr>
<tr class ="tbcolor2">

	<td>Auto
		    Enrollment No</td>
	<td align="left" style="color: #FF0000; font-size: medium; font-style: normal; font-family: Arial;">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
        <asp:TextBox ID="txtenrollment" runat="server" Width="150px" ReadOnly="True"></asp:TextBox>
   </ContentTemplate>
        </asp:UpdatePanel></td>
	
	<td>
        Password</td>
	
	<td align="left">
        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
            <ContentTemplate>
            <asp:TextBox ID="txtpassword" runat="server" Width="150px"></asp:TextBox></ContentTemplate>
        </asp:UpdatePanel>
    </td>
	
</tr>
<tr class ="tbcolor2">

	<td>Student Name</td>
	<td align="left">
        <asp:UpdatePanel ID="UpdatePanel4" runat="server">
            <ContentTemplate>
        <asp:TextBox ID="txt_studentname" runat="server" Width="150px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="txt_studentname" ErrorMessage="#" ValidationGroup="a"></asp:RequiredFieldValidator>
            </ContentTemplate>
        </asp:UpdatePanel>
         <%-- <asp:FilteredTextBoxExtender ID="txt_fname_FilteredTextBoxExtender1" 
                runat="server" Enabled="True" TargetControlID="txt_studentname" ValidChars="abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ">
            </asp:FilteredTextBoxExtender>--%>
        </td>
	
	<td>
        Course</td>
	
	<td align="left">
        <asp:UpdatePanel ID="UpdatePanel5" runat="server">
            <ContentTemplate><asp:DropDownList ID="ddlcourse" runat="server" AutoPostBack="True" 
                onselectedindexchanged="ddlcourse_SelectedIndexChanged" Width="150px">
            </asp:DropDownList></ContentTemplate>
        </asp:UpdatePanel> 
    </td>
	
</tr>
<tr class ="tbcolor1">
	
	<td>Gender</td>

	<td align="left">
        <asp:UpdatePanel ID="UpdatePanel6" runat="server">
            <ContentTemplate>
        <asp:DropDownList ID="ddlgender" runat="server" Width="150px" 
            onselectedindexchanged="ddlgender_SelectedIndexChanged" 
            AutoPostBack="True">
            <asp:ListItem Value="0">Select</asp:ListItem>
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
            ControlToValidate="ddlgender" ErrorMessage="#" ValidationGroup="a" 
            InitialValue="0"></asp:RequiredFieldValidator></ContentTemplate>
        </asp:UpdatePanel>
    </td>
		
<td>DOB</td>
		
	<td align="left">
        <asp:UpdatePanel ID="UpdatePanel7" runat="server">
            <ContentTemplate>
        <asp:TextBox ID="txt_login_expiry_Date" runat="server" Width="150px"></asp:TextBox>
            <asp:CalendarExtender ID="txt_login_expiry_Date_CalendarExtender" 
                runat="server" TargetControlID="txt_login_expiry_Date" Format="dd-MM-yyyy" Animated="true" FirstDayOfWeek="Sunday" Enabled="true"
                 PopupPosition="TopLeft" PopupButtonID="img_calendar_login_expiry">
            </asp:CalendarExtender>
            <asp:ImageButton ID="img_calendar_login_expiry" runat="server" Height="25px" 
                ImageUrl="~/images/calendar2.gif" Width="25px" ToolTip="Click Me to select Date" CausesValidation="false" ImageAlign="AbsBottom"  />
            
    </ContentTemplate>
        </asp:UpdatePanel></td>
		
</tr>
<tr class ="tbcolor2">
	<td>Occupation</td>	
	<td align="left">
        <asp:UpdatePanel ID="UpdatePanel9" runat="server">
            <ContentTemplate> <asp:TextBox ID="txt_occupation" runat="server" Width="150px" AutoPostBack="true" 
                MaxLength="50"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                ControlToValidate="txt_occupation" ErrorMessage="#" 
            ValidationGroup="a"></asp:RequiredFieldValidator></ContentTemplate>
        </asp:UpdatePanel>
    </td>
		
	<td>
        Father Name</td>
		
	<td align="left">
        <asp:UpdatePanel ID="UpdatePanel10" runat="server">
            <ContentTemplate><asp:TextBox ID="txt_FatherName" runat="server" Width="150px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
            ControlToValidate="txt_FatherName" ErrorMessage="#" ValidationGroup="a"></asp:RequiredFieldValidator></ContentTemplate>
        </asp:UpdatePanel> 
            
    </td>
		
</tr>
<tr class ="tbcolor1">
	<td > Email Id</td>
		<td align="left">
            <asp:UpdatePanel ID="UpdatePanel11" runat="server">
                <ContentTemplate><asp:TextBox ID="txt_email" runat="server" Width="150px" 
                ontextchanged="txt_email_TextChanged"></asp:TextBox>
                
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ControlToValidate="txt_email" ErrorMessage="Invalid" 
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                ValidationGroup="a"></asp:RegularExpressionValidator></ContentTemplate>
            </asp:UpdatePanel>
                
    </td>
	
		<td>
        Address</td>
	
		<td align="left"> 
            <asp:UpdatePanel ID="UpdatePanel12" runat="server">
                <ContentTemplate>
            <asp:TextBox ID="txt_Presentadd" runat="server" Width="150px" TextMode="MultiLine"></asp:TextBox>
          </ContentTemplate>
            </asp:UpdatePanel>
    </td>
	
	</tr>
<tr class ="tbcolor2">
	  <td> Emergency Contact </td>
		<td align="left">
            <asp:UpdatePanel ID="UpdatePanel13" runat="server">
                <ContentTemplate><asp:TextBox ID="txt_Emergency" runat="server" 
            Width="150px" CssClass="multilinetextarea"></asp:TextBox>
            <asp:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" 
                runat="server" Enabled="True" TargetControlID="txt_Emergency" 
            ValidChars="0123456789"></asp:FilteredTextBoxExtender></ContentTemplate>
            </asp:UpdatePanel> 
       
       </td>
	   
		<td>
		    Phone</td>
	   
		<td align="left">
            <asp:UpdatePanel ID="UpdatePanel14" runat="server">
                <ContentTemplate>
            <asp:TextBox ID="txt_Phone" runat="server" Width="150px"></asp:TextBox>
         <asp:FilteredTextBoxExtender ID="FilteredTextBoxExtender2" 
                runat="server" Enabled="True" TargetControlID="txt_Phone" 
            ValidChars="0123456789"></asp:FilteredTextBoxExtender></ContentTemplate>
            </asp:UpdatePanel> </td>
	   
</tr>
<tr class ="tbcolor3">		
	<td colspan ="4" align ="center">
        <asp:UpdatePanel ID="UpdatePanel8" runat="server">
            <ContentTemplate> 
                <asp:Button ID="btn_submit" runat="server" Text="Save" 
            onclick="btn_submit_Click" ValidationGroup="a" Width="100px"/>
        <asp:Button ID="btn_clear" runat="server" CausesValidation="False" 
            Text="Reset" onclick="btn_clear_Click" Width="100px" /></ContentTemplate>
        </asp:UpdatePanel>
    </td>	
</tr>
</table>       
         </div>
        </div>
</center>
</asp:Content>

