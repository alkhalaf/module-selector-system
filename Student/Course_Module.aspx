<%@ Page Language="C#" MasterPageFile="~/Student/Student.master" AutoEventWireup="true" CodeFile="Course_Module.aspx.cs" Inherits="Student_Default" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="~/css/superAdmin.css" rel="stylesheet" type="text/css" />
<link href="~/css/trinity_admin.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style12
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <center >
    <div  style="background-color:White;width:750;border:0.5px; border-color:Gray; vertical-align:middle; border-style:solid; border-color:Gray; border-width:thin; background-color:White">
     <table cellpadding ="5" cellspacing ="0" border ="0" width="750" style="background-color:ActiveBorder" >
     <tr>
     <td colspan ="5" align ="center">
         <table class="style12">
             <tr>
                 <td width="30%">
                     &nbsp;</td>
                 <td align="center" style="font-size: medium">
                     Select Level</td>
                                                    <td align="left">
                                                        <asp:UpdatePanel ID="UpdatePanel7" runat="server"><ContentTemplate>
                                                         <asp:DropDownList ID="ddllavel" runat="server" AutoPostBack="True" 
                                                            onselectedindexchanged="ddllavel_SelectedIndexChanged" Width="140px">
                                                            <asp:ListItem Value="0">-Select-</asp:ListItem>
                                                            <asp:ListItem Value="1">4th</asp:ListItem>
                                                            <asp:ListItem Value="2">5th</asp:ListItem>
                                                            <asp:ListItem Value="3">6th</asp:ListItem>
                                                        </asp:DropDownList></ContentTemplate></asp:UpdatePanel>
                                                    </td>
                                                    <td width="30%">
                                                        &nbsp;</td>
                                                </tr>
                                            </table>
     </td>
     </tr>
     <tr>
     <td colspan ="5" align ="center">
         <asp:UpdatePanel ID="UpdatePanel5" runat="server">
            <ContentTemplate>
         <asp:Label ID="lbl_submit" runat ="server" Font-Bold="True" Font-Size="Medium" 
             ForeColor="Red"></asp:Label></ContentTemplate>
         </asp:UpdatePanel>
     </td>
     </tr>
   <tr>
   <td style ="color:#CC3300;" class ="tbcolor3">List Of Modules</td>
   <td colspan ="4" align ="center" style="color:#CC3300;" class ="tbcolor3">&nbsp;</td>
   </tr>
   <tr>
   <td rowspan ="6" valign ="top" align="left">
       <asp:UpdatePanel ID="UpdatePanel1" runat="server">
       <ContentTemplate>
   <asp:ListBox ID="modulebound" runat="server" Width="250px" 
           Height="365px" BackColor="White" AutoPostBack="True"
           onselectedindexchanged="modulebound_SelectedIndexChanged"></asp:ListBox></ContentTemplate>
       </asp:UpdatePanel>
           
   </td>
   </tr>
   <tr class ="tbcolor1">
                <td align="left"  >&nbsp;</td>
                <td align="left">
                    &nbsp;</td>
                <td align="left" >&nbsp;</td>   
                <td align="left"> 
                    &nbsp;</td>                             
            </tr>
            <tr class ="tbcolor3">
             <td align="left" class="style12" colspan="4" valign="top" >
             <fieldset>
                    <legend style="border-width: medium; border-style: none; color: #FF0000; border-top-color: #008080; font-size: medium; text-decoration: blink; font-weight: bold;">Time Table</legend>
             <div id="cngridviewsmall" class="cngridviewsmallforstudent">
                 <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                 <ContentTemplate>  
                 <asp:GridView ID="GridView1" runat="server"
                AutoGenerateColumns ="False"   DataKeyNames ="Id" 
            CellPadding="4"   PagerSettings-Mode ="Numeric" PageSize="20" 
             BackColor="#CCCCBB" BorderColor="#CCCCCC" BorderStyle="Double" 
             BorderWidth="2px" ForeColor="Black" UseAccessibleHeader="False" 
            AllowSorting="True" Width="529px" style="margin-right: 8px" >
            <Columns >
                <asp:BoundField DataField="ModuleName" HeaderText="Module Name" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                 <asp:BoundField DataField="Lectore" HeaderText="Lecture Slot" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="tutorail" HeaderText="Tutorial Slot" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="ModuleSem" HeaderText="Semester" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
               
                <asp:CommandField ShowEditButton ="true" EditImageUrl="~/images/edit.png" 
                    HeaderText="Edit" ButtonType="Image" Visible="false"/>
                <asp:TemplateField ShowHeader="False" HeaderText="Delete" 
                                                            ItemStyle-HorizontalAlign="Center" Visible="false">
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
        </asp:GridView></div></fieldset></td>
           </ContentTemplate></asp:UpdatePanel></tr> 
            <tr class ="tbcolor1">
                <td align="left" >
                    &nbsp;</td>
                <td align="left">
              
            <%--//<asp:TextBox ID="ItemPriceGeneral" runat="server" Width="150" ></asp:TextBox>--%>
                </td>
                 <td align="center">
                   <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                 <ContentTemplate>
                     <asp:Button ID="BtSave" runat="server" Text="Add Module" 
                        ValidationGroup="a" Width="100px" onclick="BtSave_Click"  />
 <asp:Button ID="btnquit" runat="server" onclick="btnquit_Click" Text="Confirm" Width="100px" 
                         onclientclick="return confirm('Are you sure you want to freeze you Cannot Modify?')"/>  
                        </ContentTemplate>
                    </asp:UpdatePanel></td>
                <td align ="left">
                    &nbsp;</td>
                
              
            </tr>
            
            
            
            
            <tr class ="tbcolor3">
                 <td colspan ="4" align ="center" >
                 <fieldset>
                    <legend style="border-width: medium; border-style: none; color: #FF0000; border-top-color: #008080; font-size: medium; text-decoration: blink; font-weight: bold;">Selected Module</legend>
                 <div id="Div1" class="cngridviewsmallforstudent11">
                <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                 <ContentTemplate>
                     <asp:GridView ID="GridView2" runat="server"
                AutoGenerateColumns ="False"   DataKeyNames ="Id" 
            CellPadding="4"   PagerSettings-Mode ="Numeric" PageSize="20" 
             BackColor="#CCCCBB" BorderColor="#CCCCCC" BorderStyle="Double" 
             BorderWidth="2px" ForeColor="Black" UseAccessibleHeader="False" 
            AllowSorting="True" Width="528px" onrowdeleting="GridView2_RowDeleting" >
            <Columns >
                <asp:BoundField DataField="ModuleName" HeaderText="Module Name" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                 <asp:BoundField DataField="Lecture" HeaderText="Lecture Slot" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Tutorial" HeaderText="Tutorial Slot" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="ModuleSem" HeaderText="Semester" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                
                 <asp:BoundField DataField="Year" HeaderText="Year" 
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
        </asp:GridView></ContentTemplate></asp:UpdatePanel></div></fieldset></td>
            </tr>        
   </table>
   <br />
   <table cellpadding ="8" cellspacing ="0" border ="0" style="width: 750px" >
    <tr class ="tbcolor3">
                  <td style="color:#CC3300;" class ="lineBoth" align="left" width="30%" >
                      Module-Description</td>
                  <td class ="lineBoth" align="left" width="40%">
                      <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                        <ContentTemplate>
                      <asp:TextBox ID="txtdescription" runat="server" Height="50px" 
                          TextMode="MultiLine" Width="300px" ReadOnly="True"></asp:TextBox>
                  </ContentTemplate>
                      </asp:UpdatePanel></td>
                  <td class ="lineBoth">&nbsp;</td>
              
                  <td  class ="lineBoth" width="10%" >
                       </td>
                  <td class ="lineBoth" width="10%" >
                
                      &nbsp;</td>
                
                <td class ="lineBoth">&nbsp;</td>
                  <td class ="lineBoth" width="10%" >
                   
                      &nbsp;</td>
                
               
              
              
                </tr> 
                </table>
</div>        
       

 
 
 
 
</center>
</asp:Content>

