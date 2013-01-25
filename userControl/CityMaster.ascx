<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CityMaster.ascx.cs"
    Inherits="userControl_branch_details" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<link href="../css/trinity_admin.css" rel="stylesheet" type="text/css" />
<link href="../css/superAdmin.css" rel="stylesheet" type="text/css" />
<center>
   
   <div class="cmnClssRightTop1">Course Master</div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
      <div id="divbranchD1">
          <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                <ContentTemplate>        
                <asp:Label ID="lbl_submit" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="Small"></asp:Label>
        </ContentTemplate>
        </asp:UpdatePanel>
          <div id="divbranchD2">
          <table  cellpadding ="5" width ="530">    
    <tr class ="tbcolor1">
      
        <td >
            Course Name</td>
        <td>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:TextBox ID="txtcourse" runat="server" Width="150px"></asp:TextBox>
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
    <tr class ="tbcolor2">
        <td>
            No of Module</td>
        <td>
            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>
                    <asp:DropDownList ID="ddlmodule" runat="server" Width="180px" 
                        AutoPostBack="true">
                        <asp:ListItem Value="0">-Select-</asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem>7</asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                        <asp:ListItem>9</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                        <asp:ListItem>13</asp:ListItem>
                        <asp:ListItem>14</asp:ListItem>
                        <asp:ListItem>15</asp:ListItem>
                        <asp:ListItem>16</asp:ListItem>
                        <asp:ListItem>17</asp:ListItem>
                        <asp:ListItem>18</asp:ListItem>
                        <asp:ListItem>19</asp:ListItem>
                        <asp:ListItem>20</asp:ListItem>
                        <asp:ListItem>21</asp:ListItem>
                        <asp:ListItem>22</asp:ListItem>
                        <asp:ListItem>23</asp:ListItem>
                        <asp:ListItem>24</asp:ListItem>
                        <asp:ListItem>25</asp:ListItem>
                    </asp:DropDownList>
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
    <tr class ="tbcolor1">
    
        <td colspan ="2" align ="center">
            <asp:Button ID="btn_submit" runat="server" OnClick="btn_submit_Click" Text="Submit" />
        </td>
    </tr>
</table>
         </div>
         </div>
    

<br />
<div>
<asp:UpdatePanel ID="UpdatePanel4" runat="server">
<ContentTemplate>
    <asp:GridView ID="gridview1" runat="server"
                AutoGenerateColumns ="False"   DataKeyNames ="Id" AllowPaging="True" 
            CellPadding="4"   PagerSettings-Mode ="Numeric" PageSize="20" 
             BackColor="#CCCCBB" BorderColor="Black" BorderStyle="Solid" 
             BorderWidth="1px" ForeColor="Black" UseAccessibleHeader="False" 
            AllowSorting="True" 
        ShowFooter="True" onrowdeleting="gridview1_RowDeleting" >
            <Columns >
            <asp:BoundField DataField="Id" HeaderText="SNo" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="CourseName" HeaderText="Course" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                 <asp:BoundField DataField="NoofModule" HeaderText="No of Module" 
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
       </ContentTemplate>
 </asp:UpdatePanel>
</div>
</center>
