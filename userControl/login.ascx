<%@ Control Language="C#" AutoEventWireup="true" CodeFile="login.ascx.cs" Inherits="userControl_login" %>
<div class="comman_clss">
<div class="comman_clss1">
<div class="comman_login">
<div class="l"><img src="images/login_top.png" alt="" /></div>
<div class="comman_login_bg">
<div class="comman_login_bg1">
<link href="css/trinity_admin.css" rel="stylesheet" type="text/css" />
<link href="css/superAdmin.css" rel="stylesheet" type="text/css" />
<table width="72%" border="0" align="center" cellpadding="0" cellspacing="8" class ="tbcolor3">
  <tr>
    <td width="25%" align="left" valign="top" style="padding-left:50px">&nbsp;</td>
    <td width="75%" align="left" valign="top">
                    <asp:LinkButton ID="lnk_register" runat="server" Font-Bold="False" 
                        Font-Italic="True" Font-Size="Large" ForeColor="#0066FF" 
                        OnInit="ImgSend_Init" onclick="lnk_register_Click" ValidationGroup="0">Student 
        Register Here</asp:LinkButton>
      </td>
  </tr>
  
  <tr>
    <td width="25%" align="left" valign="top" style="padding-left:50px"><strong>User Type </strong></td>
    <td width="75%" align="left" valign="top">&nbsp;<asp:DropDownList ID="ddl_usrType" runat="server" Height="24px" Width="300px">
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" 
            ControlToValidate="ddl_usrType" ErrorMessage="*" InitialValue="0"></asp:RequiredFieldValidator>
      </td>
  </tr>
  
   <tr>
    <td align="left" valign="top" style="padding-left:50px"><strong>User Name  </strong></td>
    <td align="left" valign="top">&nbsp;<asp:TextBox ID="txt_loginid" 
            runat="server" Height="18px" Width="295px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" 
            ControlToValidate="txt_loginid" ErrorMessage="*"></asp:RequiredFieldValidator>
       </td>
  </tr>
  
  
   <tr>
    <td align="left" valign="top" style="padding-left:50px"><strong>Password </strong></td>
    <td align="left" valign="top">&nbsp;<asp:TextBox ID="txt_pswd" 
            runat="server" Height="18px" Width="295px" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" 
            ControlToValidate="txt_pswd" ErrorMessage="*"></asp:RequiredFieldValidator>
       </td>
  </tr>
  
  
  <tr>
    <td align="left" valign="top" style="padding-left:50px"></td>
    <td align="left" valign="top" style="padding-top:5px; padding-bottom:10px;">
        <asp:ImageButton ID="btn_img_login" runat="server" Height="31px" 
            ImageUrl="~/images/login.jpg" Width="88px" onclick="btn_img_login_Click" />
        <asp:Label ID="lbl_login_error" runat="server" ForeColor="Red"></asp:Label>
      </td>
  </tr>
  
  
  <tr>
    <td align="left" valign="top">&nbsp;</td>
    <td align="left" valign="top">
        <asp:LinkButton ID="lkbtn_forget_pass" runat="server" Font-Bold="True" 
            Font-Names="Arial" Font-Size="12px" onclick="lkbtn_forget_pass_Click" 
            PostBackUrl="~/forgetPassStepOne.aspx" CausesValidation="False" 
            Visible="False">Forgot your Password?</asp:LinkButton>
      </td>
  </tr>
  
  
</table>




</div>
</div>
<div class="l"></div>
</div>
</div>
</div>