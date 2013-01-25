<%@ Page Language="C#" MasterPageFile="~/SuperAdmin/sa.master" AutoEventWireup="true" CodeFile="ResultSummery.aspx.cs" Inherits="SuperAdmin_Assesment" Title="Untitled Page" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/superAdmin.css" rel="stylesheet" type="text/css" />
<link href="../css/trinity_admin.css" rel="stylesheet" type="text/css" />

    <style type="text/css">
        .style12
        {
            width: 100%;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

    <asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center >
<br />
    <div class="cmnClssRightTop1">Final Assesment</div>   
        <div id="divuserRegistD1">
         <div id="divuserRegistD2">
               <table width ="90%" cellpadding ="6" >

<tr class ="tbcolor1">
	<td colspan ="2" align="center" >
            
        <asp:Label ID="lbl_submit" runat="server"></asp:Label>
    </td>
	
		
</tr>
<tr class ="tbcolor2">

	<td>Enter Your Enrollment No</td>
	<td align="left">
        
         <asp:TextBox ID="txtstudentreg" runat="server" AutoPostBack="True" 
             ontextchanged="txtstudentreg_TextChanged" Width="150px"></asp:TextBox>
        </td>
	
</tr>
<tr class ="tbcolor1">		
	<td colspan ="2" align ="center">
       
        <asp:Button ID="Button1" runat="server" Text="Enter" Width="80px" 
            onclick="Button1_Click" />
    </td>	
</tr>
</table>       
         </div>
        </div>
</center>
<center>
     <fieldset style="width:750px">
                    <legend style="border-width: medium; border-style: none; color: #FF0000; border-top-color: #008080; font-size: medium; text-decoration: blink; font-weight: bold;">
                        Overall Result</legend>
                     <div id="cngridviewsmall" class="cngdiv">
                         <table cellspacing="1" width="100%">
                             <tr>
                                 <td align="center">
                                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                     <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" 
                                         Text="Marks Statement"></asp:Label>
                                 </td>
                                 <td align="right" width="13%">
                                     &nbsp;</td>
                             </tr>
                             <tr>
                                 <td colspan="2" align="center">
                                 <asp:FormView ID="FormView1" runat="server" DataSourceID="SqlDataSource1" 
                                         Width="640px">
                                         <EditItemTemplate>
                                             Registration_No:
                                             <asp:TextBox ID="Registration_NoTextBox" runat="server" 
                                                 Text='<%# Bind("EnrollementNo") %>' />
                                             <br />
                                             Year:
                                             <asp:TextBox ID="YearTextBox" runat="server" Text='<%# Bind("Year") %>' />
                                             <br />
                                             Name:
                                             <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                                             <br />
                                             Dob:
                                             <asp:TextBox ID="DobTextBox" runat="server" Text='<%# Bind("Dob") %>' />
                                             <br />
                                             Gender:
                                             <asp:TextBox ID="GenderTextBox" runat="server" Text='<%# Bind("Gender") %>' />
                                             <br />
                                             Father:
                                             <asp:TextBox ID="FatherTextBox" runat="server" Text='<%# Bind("Father") %>' />
                                             <br />
                                             Present_Address:
                                             <asp:TextBox ID="Present_AddressTextBox" runat="server" 
                                                 Text='<%# Bind("Present_Address") %>' />
                                             <br />
                                             City:
                                             <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>' />
                                             <br />
                                             <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" 
                                                 CommandName="Update" Text="Update" />
                                             &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" 
                                                 CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                                         </EditItemTemplate>
                                         <InsertItemTemplate>
                                             Registration_No:
                                             <asp:TextBox ID="Registration_NoTextBox" runat="server" 
                                                 Text='<%# Bind("EnrollementNo") %>' />
                                             <br />
                                             Year:
                                             <asp:TextBox ID="YearTextBox" runat="server" Text='<%# Bind("Year") %>' />
                                             <br />
                                             Name:
                                             <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                                             <br />
                                             Dob:
                                             <asp:TextBox ID="DobTextBox" runat="server" Text='<%# Bind("Dob") %>' />
                                             <br />
                                             Gender:
                                             <asp:TextBox ID="GenderTextBox" runat="server" Text='<%# Bind("Gender") %>' />
                                             <br />
                                             Father:
                                             <asp:TextBox ID="FatherTextBox" runat="server" Text='<%# Bind("Father") %>' />
                                             <br />
                                             Present_Address:
                                             <asp:TextBox ID="Present_AddressTextBox" runat="server" 
                                                 Text='<%# Bind("Present_Address") %>' />
                                             <br />
                                             City:
                                             <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>' />
                                             <br />
                                             <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" 
                                                 CommandName="Insert" Text="Insert" />
                                             &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" 
                                                 CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                                         </InsertItemTemplate>
                                         <ItemTemplate>
                                             &nbsp;<table class="style12">
                                                 <tr>
                                                     <td width="20%">
                                                         Name</td>
                                                     <td width="30%">
                                                         <asp:Label ID="NameLabel" runat="server" Text='<%# Bind("Name") %>' />
                                                     </td>
                                                     <td width="20%">
                                                         Registration No</td>
                                                     <td width="30%">
                                                         <asp:Label ID="Registration_NoLabel" runat="server" 
                                                             Text='<%# Bind("EnrollementNo") %>' />
                                                     </td>
                                                 </tr>
                                                 <tr>
                                                     <td>
                                                         Gender</td>
                                                     <td>
                                                         <asp:Label ID="GenderLabel" runat="server" Text='<%# Bind("Gender") %>' />
                                                     </td>
                                                     <td>
                                                         Dob</td>
                                                     <td>
                                                         <asp:Label ID="DobLabel" runat="server" Text='<%# Bind("Dob") %>' />
                                                     </td>
                                                 </tr>
                                                 <tr>
                                                     <td>
                                                         Father</td>
                                                     <td>
                                                         <asp:Label ID="FatherLabel" runat="server" Text='<%# Bind("Father") %>' />
                                                     </td>
                                                     <td>
                                                         City</td>
                                                     <td>
                                                         <asp:Label ID="CityLabel" runat="server" Text='<%# Bind("City") %>' />
                                                     </td>
                                                 </tr>
                                                 <tr>
                                                     <td>
                                                         Address</td>
                                                     <td>
                                                         <asp:Label ID="Present_AddressLabel" runat="server" 
                                                             Text='<%# Bind("Present_Address") %>' />
                                                     </td>
                                                     <td>
                                                         &nbsp;</td>
                                                     <td>
                                                         &nbsp;</td>
                                                 </tr>
                                             </table>
                                             <br />
                                         </ItemTemplate>
                                     </asp:FormView>
                                     <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                         ConnectionString="<%$ ConnectionStrings:SmsConnectionString %>" 
                                         SelectCommand="SELECT [EnrollementNo], [Name], [Dob], [Gender], [Father], [Present_Address], [City]FROM [LoginDetails] WHERE ([EnrollementNo] = @EnrollementNo)">
                                         <SelectParameters>
                                             <asp:ControlParameter ControlID="txtstudentreg" Name="EnrollementNo" 
                                                 PropertyName="Text" Type="String" />
                                         </SelectParameters>
                                     </asp:SqlDataSource>
                                 </td>
                             </tr>
                             <tr>
                                 <td colspan="2" align="center">
                                     <asp:GridView ID="GridView1" runat="server"
                AutoGenerateColumns ="False"   DataKeyNames ="Id" 
                onrowediting="GridView1_RowEditing" AllowPaging="True" 
            CellPadding="4"   PagerSettings-Mode ="Numeric" PageSize="20" 
            onpageindexchanging="GridView1_PageIndexChanging" 
            onrowdeleting="GridView1_RowDeleting" 
            onselectedindexchanging="GridView1_SelectedIndexChanging" BorderColor="#CCCCCC" BorderStyle="Double" 
             BorderWidth="2px" ForeColor="Black" UseAccessibleHeader="False" 
            AllowSorting="True" onrowdatabound="GridView1_RowDataBound" ShowFooter="True" 
                                         onselectedindexchanged="GridView1_SelectedIndexChanged" Width="100%" >
            <Columns >
                <asp:BoundField DataField="Year" HeaderText="Year(Level)" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                 <asp:BoundField DataField="Course" HeaderText="Course" 
                HeaderStyle-HorizontalAlign="Center" Visible="false">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                 <asp:BoundField DataField="Module" HeaderText="Module" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Assesment" HeaderText="Assesment No" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Outof" HeaderText="Total Marks" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Marks" HeaderText="Marks" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
               
                <asp:CommandField ShowEditButton ="true" EditImageUrl="~/images/edit.png" 
                    HeaderText="Edit" ButtonType="Image" Visible="false"/>
                <asp:TemplateField ShowHeader="False" HeaderText="Delete" Visible="false" 
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
        </asp:GridView></td>
                             </tr>
                         </table>
</div>
          </fieldset>

</center>
<center>
     &nbsp;</center>
<center>
     &nbsp;</center>
</asp:Content>

