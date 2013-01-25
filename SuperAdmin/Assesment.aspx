<%@ Page Language="C#" MasterPageFile="~/SuperAdmin/sa.master" AutoEventWireup="true" CodeFile="Assesment.aspx.cs" Inherits="SuperAdmin_Assesment" Title="Untitled Page" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/superAdmin.css" rel="stylesheet" type="text/css" />
<link href="../css/trinity_admin.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

    <script type="text/javascript" src="https://www.google.com/jsapi"></script>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center >
<br />
    <div class="cmnClssRightTop1"> Assesment of Student </div>   
        <div id="divuserRegistD1">
         <div id="divuserRegistD2">
               <table width ="90%" cellpadding ="6" >
<tr class ="tbcolor1">
	<td colspan ="4" align="center" >
            
        <asp:Label ID="lbl_submit" runat="server"></asp:Label>
    </td>		
</tr>
<tr class ="tbcolor2">

	<td>Student Registration No</td>
	<td align="left">
        <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                <ContentTemplate>
         <asp:TextBox ID="txtstudentreg" runat="server" AutoPostBack="True" 
             ontextchanged="txtstudentreg_TextChanged" Width="150px"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
        </td>
	
	<td>
        Name</td>
	
	<td align="left"><asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
            <asp:TextBox ID="txtname" runat="server" ReadOnly="True" Width="150px" 
                        BackColor="#E6E6DD"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="txtname" ErrorMessage="#" ValidationGroup="a"></asp:RequiredFieldValidator>
                </ContentTemplate></asp:UpdatePanel>
    </td>
	
</tr>
<tr class ="tbcolor1">
	
	<td>Course</td>

	<td align="left">
        <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                <ContentTemplate>
         <asp:TextBox ID="txtcourse" runat="server" AutoPostBack="True" 
             ontextchanged="txtstudentreg_TextChanged" Width="150px" ReadOnly="True" 
                        BackColor="#E6E6DD"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
    </td>
		
<td>level</td>
		
	<td align="left"><asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>
            <asp:DropDownList ID="ddlyear" runat="server" Width="150px" ForeColor="Red" 
                AutoPostBack="True" onselectedindexchanged="ddlyear_SelectedIndexChanged">
                <asp:ListItem Value="0">-Select-</asp:ListItem>
                <asp:ListItem Value="1">4th</asp:ListItem>
                <asp:ListItem Value="2">5th</asp:ListItem>
                <asp:ListItem Value="3">6th</asp:ListItem>
            </asp:DropDownList></ContentTemplate></asp:UpdatePanel>
    </td>
		
</tr>
<tr class ="tbcolor2">
	<td>Select Module</td>	
	<td align="left">
        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                <ContentTemplate>
        <asp:DropDownList ID="ddlmodule" runat="server" Width="150px" 
            ForeColor="#FF3300" AutoPostBack="True" 
            onselectedindexchanged="ddlmodule_SelectedIndexChanged">
        </asp:DropDownList></ContentTemplate></asp:UpdatePanel>
        
    </td>
		
	<td>
                Assesment</td>
		
	<td align="left">
        <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                <ContentTemplate>
        <asp:DropDownList ID="ddlassesment" runat="server" Width="150px" 
            AutoPostBack="True" onselectedindexchanged="ddlassesment_SelectedIndexChanged">
            <asp:ListItem Value="0">Select</asp:ListItem>
            <asp:ListItem Value="1">Assessment-1</asp:ListItem>
            <asp:ListItem Value="2">Assessment-2</asp:ListItem>
            <asp:ListItem Value="3">Assessment-3</asp:ListItem>
            <asp:ListItem Value="4">Assessment-4</asp:ListItem>
            <asp:ListItem Value="5">Assessment-5</asp:ListItem>
            <asp:ListItem Value="6">Assessment-6</asp:ListItem>
            <asp:ListItem Value="7">Assessment-7</asp:ListItem>
            <asp:ListItem Value="8">Assessment-8</asp:ListItem>
            <asp:ListItem Value="9">Assessment-9</asp:ListItem>
            <asp:ListItem Value="10">Assessment-10</asp:ListItem>
        </asp:DropDownList></ContentTemplate></asp:UpdatePanel>
        
    </td>
		
</tr>
<tr class ="tbcolor1">
	<td>Max Marks</td>	
	<td align="left">
        <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                <ContentTemplate>
                <asp:TextBox ID="txtmaxmarks" runat="server" Width="150px" ReadOnly="True"></asp:TextBox>
        
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtmaxmarks" ErrorMessage="#" ValidationGroup="a"></asp:RequiredFieldValidator>
        
   </ContentTemplate></asp:UpdatePanel> </td>
		
	<td>
        Marks Obtained</td>
		
	<td align="left">
        
        <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                <ContentTemplate>
                <asp:TextBox ID="txtmarks" runat="server" Width="150px"></asp:TextBox>
        
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtmarks" ErrorMessage="#" ValidationGroup="a"></asp:RequiredFieldValidator>
        
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToCompare="txtmaxmarks" ControlToValidate="txtmarks" 
                        ErrorMessage="Less or equal to Maximum marks" Operator="LessThanEqual" 
                        Type="Integer" ValidationGroup="a"></asp:CompareValidator>
        
   </ContentTemplate></asp:UpdatePanel></td>
		
</tr>
<tr class ="tbcolor2">		
	<td colspan ="4" align ="center">
       
        <asp:Button ID="Button1" runat="server" Text="Save" Width="80px" 
            onclick="Button1_Click" ValidationGroup="a" />
        <asp:Button ID="Button2" runat="server" Text="Reset" Width="80px" 
            onclick="Button2_Click" />
    </td>	
</tr>
</table>       
         </div>
        </div>
</center>
<center>
     <fieldset style="width:750px">
                    <legend style="border-width: medium; border-style: none; color: #FF0000; border-top-color: #008080; font-size: medium; text-decoration: blink; font-weight: bold;">
                        Assesment Summary</legend>
                     <div id="cngridviewsmall" class="cngridviewsmallAssesment">
<asp:UpdatePanel ID="UpdatePanel5" runat="server">
<ContentTemplate>
<asp:GridView ID="GridView1" runat="server"
                AutoGenerateColumns ="False"   DataKeyNames ="Id" 
                onrowediting="GridView1_RowEditing" AllowPaging="True" 
            CellPadding="4"   PagerSettings-Mode ="Numeric" PageSize="20" 
            onpageindexchanging="GridView1_PageIndexChanging" 
            onrowdeleting="GridView1_RowDeleting" 
            onselectedindexchanging="GridView1_SelectedIndexChanging" 
             BackColor="#CCCCBB" BorderColor="Black" BorderStyle="Solid" 
             BorderWidth="1px" ForeColor="Black" UseAccessibleHeader="False" 
            AllowSorting="True" onrowdatabound="GridView1_RowDataBound" 
        ShowFooter="True" >
            <Columns >
                <asp:BoundField DataField="Year" HeaderText="Year(Level)" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                 <asp:BoundField DataField="Module" HeaderText="Module-Name" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Assesment" HeaderText="Assesment No" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Outof" HeaderText="Max Marks" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Marks" HeaderText="Marks" 
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
           
            <PagerStyle ForeColor="Black" HorizontalAlign="Right" BackColor="White" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
        </asp:GridView>
 </ContentTemplate></asp:UpdatePanel> 
</div>
          </fieldset>
</center>
<%--<center>
<asp:Literal ID="lt" runat="server"></asp:Literal>
<fieldset style="width:750px">
                    <legend style="border-width: medium; border-style: none; color: #FF0000; border-top-color: #008080; font-size: medium; text-decoration: blink; font-weight: bold;">Pie Chart Representation</legend>
 <div id="chart_div" class="cngridviewsmallAssesment"></div>
 </fieldset>
</center>--%>
</asp:Content>

