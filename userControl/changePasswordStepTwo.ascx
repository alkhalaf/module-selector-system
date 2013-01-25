<%@ Control Language="C#" AutoEventWireup="true" CodeFile="changePasswordStepTwo.ascx.cs" Inherits="userControl_changePasswordStepTwo" %>
<link href="../css/trinity_admin.css" rel="stylesheet" type="text/css" />
<link href="../css/superAdmin.css" rel="stylesheet" type="text/css" />

<center>
 <div class="cmnClssRightTop1">Change Password</div>
<br />
  <asp:Label ID="lbl_submit" runat="server"></asp:Label>
  <br />
<div id="divpasswordD1">
<div id="divpasswordD2">
  <table width ="525" cellpadding ="5">
<tr class="tbcolor1">
	<td>Your Current Password</td>
	<td> 
        <asp:TextBox ID="txt_current_password" runat="server" 
            TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txt_current_password" ErrorMessage="*"></asp:RequiredFieldValidator>
    </td>
	
</tr>
<tr class="tbcolor2">

	<td >New Password</td>
	<td > 
        <asp:TextBox ID="txt_new_password" runat="server" 
            TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="txt_new_password" ErrorMessage="*"></asp:RequiredFieldValidator>
    </td>

</tr>
<tr class="tbcolor1">
	<td>Verify New Password</td>
	<td > 
        <asp:TextBox ID="txt_verify_password" runat="server" 
            TextMode="Password"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ControlToCompare="txt_new_password" ControlToValidate="txt_verify_password" 
            ErrorMessage="Verify Password Wrong"></asp:CompareValidator>
    </td>
	
</tr>
<tr class="tbcolor3">	
	<td colspan ="2" align ="center">
        <asp:Button ID="btn_change_pass" runat="server" Text="SUBMIT" 
            onclick="btn_change_pass_Click"/>
    </td>
	
</tr>
</table>
</div>
</div>

</center>