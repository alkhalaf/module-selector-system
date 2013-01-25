<%@ Page EnableEventValidation="true"  Title="" Language="C#" MasterPageFile="~/SuperAdmin/sa.master" AutoEventWireup="true" CodeFile="ModuleMaster.aspx.cs" Inherits="SuperAdmin_branch_details"%>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/trinity_admin.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
 function checklimit(id){
  
  if(isNaN(document.getElementById(id).value))
  {
   alert("Value should be numeric");
   document.getElementById(id).value="";
   document.getElementById(id).focus();
   return false; 
  }
  else
  {
//  if(parseInt(document.getElementById(id).value)>100)
//    {
//      alert("Value should be <=100");
//      document.getElementById(id).value="";
//      document.getElementById(id).focus();
//      return false;
//    }
//    
//    if(parseInt(document.getElementById(id).value)<100)
//    {
//      alert("Value should be <=100");
//      document.getElementById(id).value="";
//      document.getElementById(id).focus();
//      return false;
//    }
  }
 }
</script>
<link href="../css/superAdmin.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
   <div class="cmnClssRightTop1">Module Master</div>
   
   <div style="width:700px">
     <div style="float:left; width:200px">
         <asp:UpdatePanel ID="UpdatePanel5" runat="server">
            <ContentTemplate><asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" 
             Width="200px" CellPadding="2" 
             CellSpacing="2" >
             <ItemTemplate>
                 Course:
                <a href="ModuleMaster.aspx?Name=<%# Eval("CourseName") %>"><asp:Label ID="CourseLabel" runat="server" Text='<%# Eval("CourseName") %>' /></a>
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("Id") %>' Visible="false" /></a>
                 <br />
                 <br />
             </ItemTemplate>
         </asp:DataList></ContentTemplate>
                 </asp:UpdatePanel>
         <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
             ConnectionString="<%$ ConnectionStrings:SmsConnectionString2 %>" 
             SelectCommand="SELECT Distinct[CourseName],[Id] FROM [CourseMaster] where Status='y'"></asp:SqlDataSource>
       </div>
     
     <div style="float:left; width:500px">
    
       <center>
     <div>
      <asp:UpdatePanel ID="UpdatePanel18" runat="server">
            <ContentTemplate>
         <asp:Label ID="lbl_submit1" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="Small"></asp:Label></ContentTemplate>
         </asp:UpdatePanel>
        </div>
   <div> <div id="divuserRegistDmodule">
         <div id="divuserRegistmod">
          <table id="abc"  cellpadding ="5" width="100%">    
    <tr class ="tbcolor2">
        <td >You have Choosen</td>
        <td align="left">
            <asp:Label ID="lblcourse" runat="server" Font-Bold="True" Font-Italic="False" 
                Font-Size="Medium"></asp:Label>
        </td>
    </tr>
    <tr class ="tbcolor1">
      
        <td >
            Module</td>
        <td align="left">
            <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                <ContentTemplate>
            <asp:DropDownList ID="ddlmodule" runat="server" Width="150px">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                ControlToValidate="ddlmodule" ErrorMessage="#" InitialValue="0" 
                ValidationGroup="a"></asp:RequiredFieldValidator></ContentTemplate>
            </asp:UpdatePanel>
                          </td>
    </tr>
    <tr class ="tbcolor2">
      
        <td >
            Select year(Level)</td>
        <td align="left"><asp:UpdatePanel ID="UpdatePanel8" runat="server">
                <ContentTemplate>
            <asp:DropDownList ID="ddlyear" runat="server" Width="150px">
                <asp:ListItem Value="0">-Select-</asp:ListItem>
                <asp:ListItem Value="1">4th</asp:ListItem>
                <asp:ListItem Value="2">5th</asp:ListItem>
                <asp:ListItem Value="3">6th</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ControlToValidate="ddlyear" ErrorMessage="#" InitialValue="0" 
                ValidationGroup="a"></asp:RequiredFieldValidator>
                        </ContentTemplate></asp:UpdatePanel></td>
    </tr>
    <tr class ="tbcolor1">
        <td class="style12">
            Module Name</td>
        <td class="style12" align="left">
          <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                <ContentTemplate>
                    <asp:TextBox ID="txt_Module" runat="server" Width="150px" 
                        ValidationGroup="a"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_Module"
                        Display="Dynamic" ErrorMessage="#" ValidationGroup="a"></asp:RequiredFieldValidator></ContentTemplate></asp:UpdatePanel>
              
        </td>
    </tr>
    <tr class ="tbcolor2">
        <td>
            Module
            Code</td>
        <td align="left">
            <asp:UpdatePanel ID="UpdatePanel10" runat="server">
                <ContentTemplate><asp:TextBox ID="txtcode" runat="server" Width="150px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" 
                runat="server" ControlToValidate="txtcode"
                        Display="Dynamic" ErrorMessage="#" ValidationGroup="a"></asp:RequiredFieldValidator></ContentTemplate></asp:UpdatePanel>
              
        </td>
    </tr>
    <tr class ="tbcolor1">
        <td>
            Module Sem</td>
        <td align="left">
          <asp:UpdatePanel ID="UpdatePanel11" runat="server">
                <ContentTemplate>  <asp:DropDownList ID="ddlsem" runat="server" Width="150px">
                <asp:ListItem Value="0">Select</asp:ListItem>
                <asp:ListItem Value="1">Semester1</asp:ListItem>
                <asp:ListItem Value="2">Semester2</asp:ListItem>
            </asp:DropDownList></ContentTemplate></asp:UpdatePanel>
        </td>
    </tr>
    <tr class ="tbcolor2">
        <td colspan="2" align="center">
            <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Red" 
                Text="Lecture Slot"></asp:Label>
        </td>
    </tr>
    <tr class ="tbcolor1">
        <td class ="tbcolor1">
            <asp:UpdatePanel ID="UpdatePanel12" runat="server">
                <ContentTemplate><asp:DropDownList ID="Lec_ddday" runat="server">
                <asp:ListItem Value="0">Day</asp:ListItem>
                <asp:ListItem Value="1">Monday</asp:ListItem>
                <asp:ListItem Value="2">Tuesday</asp:ListItem>
                <asp:ListItem Value="3">Wednesday</asp:ListItem>
                <asp:ListItem Value="4">Thrusday</asp:ListItem>
                <asp:ListItem>Friday</asp:ListItem>
                <asp:ListItem Value="6">Saturday</asp:ListItem>
                <asp:ListItem Value="7">Sunday</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                ControlToValidate="Lec_ddday" ErrorMessage="#" InitialValue="0" 
                ValidationGroup="a"></asp:RequiredFieldValidator></ContentTemplate></asp:UpdatePanel>
        </td>
        <td valign="top" align="left">
           <asp:UpdatePanel ID="UpdatePanel13" runat="server">
                <ContentTemplate>
            From:-
            <asp:DropDownList ID="lec_fromtime" runat="server">
                <asp:ListItem Value="0">Time</asp:ListItem>
                <asp:ListItem Value="1">01</asp:ListItem>
                <asp:ListItem>02</asp:ListItem>
                <asp:ListItem>03</asp:ListItem>
                <asp:ListItem>04</asp:ListItem>
                <asp:ListItem>05</asp:ListItem>
                <asp:ListItem>06</asp:ListItem>
                <asp:ListItem>07</asp:ListItem>
                <asp:ListItem>08</asp:ListItem>
                <asp:ListItem>09</asp:ListItem>
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
            </asp:DropDownList>
&nbsp;To:-<asp:DropDownList ID="lec_totime" runat="server">
                <asp:ListItem Value="0">Time</asp:ListItem>
                <asp:ListItem Value="1">01</asp:ListItem>
                <asp:ListItem>02</asp:ListItem>
                <asp:ListItem>03</asp:ListItem>
                <asp:ListItem>04</asp:ListItem>
                <asp:ListItem>05</asp:ListItem>
                <asp:ListItem>06</asp:ListItem>
                <asp:ListItem>07</asp:ListItem>
                <asp:ListItem>08</asp:ListItem>
                <asp:ListItem>09</asp:ListItem>
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
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                ControlToValidate="lec_totime" ErrorMessage="#" InitialValue="0" 
                ValidationGroup="a"></asp:RequiredFieldValidator></ContentTemplate></asp:UpdatePanel>
        </td>
    </tr>
    <tr class ="tbcolor2" valign="top">
        <td colspan="2" align="center">
            <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="Red" 
                Text="Tutorial Slot"></asp:Label>
        </td>
    </tr>
    <tr class ="tbcolor1">
        <td><asp:UpdatePanel ID="UpdatePanel14" runat="server">
                <ContentTemplate>
            <asp:DropDownList ID="tutday" runat="server">
                <asp:ListItem Value="0">Day</asp:ListItem>
                <asp:ListItem Value="1">Monday</asp:ListItem>
                <asp:ListItem Value="2">Tuesday</asp:ListItem>
                <asp:ListItem Value="3">Wednesday</asp:ListItem>
                <asp:ListItem Value="4">Thrusday</asp:ListItem>
                <asp:ListItem>Friday</asp:ListItem>
                <asp:ListItem Value="6">Saturday</asp:ListItem>
                <asp:ListItem Value="7">Sunday</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                ControlToValidate="tutday" ErrorMessage="#" InitialValue="0" 
                ValidationGroup="a"></asp:RequiredFieldValidator>
        </ContentTemplate></asp:UpdatePanel></td>
        <td align="left" valign="top">
           <asp:UpdatePanel ID="UpdatePanel15" runat="server">
                <ContentTemplate> From:-<asp:DropDownList ID="tuttimefrom" runat="server">
                <asp:ListItem Value="0">Time</asp:ListItem>
                <asp:ListItem Value="1">01</asp:ListItem>
                <asp:ListItem>02</asp:ListItem>
                <asp:ListItem>03</asp:ListItem>
                <asp:ListItem>04</asp:ListItem>
                <asp:ListItem>05</asp:ListItem>
                <asp:ListItem>06</asp:ListItem>
                <asp:ListItem>07</asp:ListItem>
                <asp:ListItem>08</asp:ListItem>
                <asp:ListItem>09</asp:ListItem>
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
            </asp:DropDownList>
            To:-<asp:DropDownList ID="tuttimeto" runat="server">
                <asp:ListItem Value="0">Time</asp:ListItem>
                <asp:ListItem Value="1">01</asp:ListItem>
                <asp:ListItem>02</asp:ListItem>
                <asp:ListItem>03</asp:ListItem>
                <asp:ListItem>04</asp:ListItem>
                <asp:ListItem>05</asp:ListItem>
                <asp:ListItem>06</asp:ListItem>
                <asp:ListItem>07</asp:ListItem>
                <asp:ListItem>08</asp:ListItem>
                <asp:ListItem>09</asp:ListItem>
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
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                ControlToValidate="tuttimeto" ErrorMessage="#" InitialValue="0" 
                ValidationGroup="a"></asp:RequiredFieldValidator></ContentTemplate></asp:UpdatePanel>
        </td>
    </tr>
    <tr class ="tbcolor1">
        <td>Credits of Module</td>
        <td align="left" valign="top">
            <asp:UpdatePanel ID="UpdatePanel17" runat="server">
                <ContentTemplate>
            <asp:TextBox ID="txtcredits" runat="server" onkeyup="checklimit(this.id)"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                ControlToValidate="txtcredits" ErrorMessage="#" 
                ValidationGroup="a" Display="Dynamic"></asp:RequiredFieldValidator></ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
    <tr class ="tbcolor2">
        <td>
            Description of Module</td>
        <td align="left">
           <asp:UpdatePanel ID="UpdatePanel16" runat="server">
                <ContentTemplate> <asp:TextBox ID="txtdescription" runat="server" TextMode="MultiLine"></asp:TextBox></ContentTemplate></asp:UpdatePanel>
        </td>
    </tr>
    <tr class ="tbcolor1">
        <td>
            No of Assessment</td>
        <td align="left">
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
            <asp:DropDownList ID="ddlassesment" runat="server" AutoPostBack="True" 
                Width="150px" onselectedindexchanged="ddlassesment_SelectedIndexChanged1">
                <asp:ListItem Selected="True" Value ="0">Select</asp:ListItem>
                <asp:ListItem Value ="1">1</asp:ListItem>
                <asp:ListItem Value ="2">2</asp:ListItem>
                <asp:ListItem Value ="3">3</asp:ListItem>
                <asp:ListItem Value ="4">4</asp:ListItem>
                <asp:ListItem Value ="5">5</asp:ListItem>
                <asp:ListItem Value ="6">6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
            </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                    ControlToValidate="ddlassesment" ErrorMessage="#" InitialValue="0" 
                    ValidationGroup="a"></asp:RequiredFieldValidator>
                </ContentTemplate>
            </asp:UpdatePanel>
           
        </td>
    </tr>
    
    <tr class ="tbcolor2">
     
        <td colspan="2" align="center">
         <asp:UpdatePanel ID="UpdatePanel6" runat="server">
            <ContentTemplate>
         <asp:Label ID="lbl_submit" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="Small"></asp:Label></ContentTemplate>
         </asp:UpdatePanel></td>
    </tr>
    </table>
<asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
<table id="Table1"  cellpadding ="5" width="100%">    
    <tr class ="tbcolor1" runat ="server" id="r1">
      
        <td >
            Assessment:1(Max Marks)</td>
        <td align="left">
            <asp:TextBox ID="ass1" runat="server" Width="100px" onkeyup="checklimit(this.id)"></asp:TextBox>
                          </td>
        <td align="left">
            <asp:Label ID="Label4" runat="server" Text="Weight(%)"></asp:Label>
        </td>
        <td align="left">
            <asp:TextBox ID="txtw1" runat="server" Width="100px" onkeyup="checklimit(this.id)"></asp:TextBox>
        </td>
    </tr>
    <tr class ="tbcolor2" id="r2" runat="server" >
      
        <td >
            Assessment:2(Max Marks)</td>
        <td align="left">
            <asp:TextBox ID="ass2" runat="server" Width="100px" onkeyup="checklimit(this.id)"></asp:TextBox>
                          </td>
        <td align="left">
            <asp:Label ID="Label5" runat="server" Text="Weight(%)"></asp:Label>
        </td>
        <td align="left">
            <asp:TextBox ID="txtw2" runat="server" Width="100px" onkeyup="checklimit(this.id)"></asp:TextBox>
        </td>
    </tr>
    <tr class ="tbcolor1" id="r3" runat="server">
        <td class="style12">
            Assessment:3(Max Marks)</td>
        <td class="style12" align="left">
          
            <asp:TextBox ID="ass3" runat="server" Width="100px" onkeyup="checklimit(this.id)"></asp:TextBox>
              
        </td>
        <td align="left" class="style12">
            <asp:Label ID="Label6" runat="server" Text="Weight(%)"></asp:Label>
        </td>
        <td align="left" class="style12">
            <asp:TextBox ID="txtw3" runat="server" Width="100px" onkeyup="checklimit(this.id)"></asp:TextBox>
        </td>
    </tr>
    <tr class ="tbcolor2" id="r4" runat="server">
        <td>
            Assessment:4(Max Marks)</td>
        <td align="left">
            <asp:TextBox ID="ass4" runat="server" Width="100px" onkeyup="checklimit(this.id)"></asp:TextBox>
        </td>
        <td align="left">
            <asp:Label ID="Label7" runat="server" Text="Weight(%)"></asp:Label>
        </td>
        <td align="left">
            <asp:TextBox ID="txtw4" runat="server" Width="100px" onkeyup="checklimit(this.id)"></asp:TextBox>
        </td>
    </tr>
    <tr class ="tbcolor1" id="r5" runat="server">
        <td>
            Assessment:5(Max Marks)</td>
        <td align="left">
            <asp:TextBox ID="ass5" runat="server" Width="100px" onkeyup="checklimit(this.id)"></asp:TextBox>
        </td>
        <td align="left">
            <asp:Label ID="Label8" runat="server" Text="Weight(%)"></asp:Label>
        </td>
        <td align="left">
            <asp:TextBox ID="txtw5" runat="server" Width="100px" onkeyup="checklimit(this.id)"></asp:TextBox>
        </td>
    </tr>
    <tr class ="tbcolor2" id="r6" runat="server">
        <td>
            Assessment:6(Max Marks)</td>
        <td valign="top" align="left">
           
            <asp:TextBox ID="ass6" runat="server" Width="100px" onkeyup="checklimit(this.id)"></asp:TextBox>
       </td>
        <td align="left" valign="top">
            <asp:Label ID="Label9" runat="server" Text="Weight(%)"></asp:Label>
        </td>
        <td align="left" valign="top">
            <asp:TextBox ID="txtw6" runat="server" Width="100px" onkeyup="checklimit(this.id)"></asp:TextBox>
        </td>
    </tr>
    <tr class ="tbcolor1" id="r7" runat="server">
        <td>
            Assessment:7(Max Marks)</td>
        <td valign="top" align="left">
           
            <asp:TextBox ID="ass7" runat="server" Width="100px" onkeyup="checklimit(this.id)"></asp:TextBox>
       </td>
        <td align="left" valign="top">
            <asp:Label ID="Label10" runat="server" Text="Weight(%)"></asp:Label>
        </td>
        <td align="left" valign="top">
            <asp:TextBox ID="txtw7" runat="server" Width="100px" onkeyup="checklimit(this.id)"></asp:TextBox>
        </td>
    </tr>
    <tr class ="tbcolor2" id="r8" runat="server">
        <td>
            Assessment:8(Max Marks)</td>
        <td valign="top" align="left">
           
            <asp:TextBox ID="ass8" runat="server" Width="100px" onkeyup="checklimit(this.id)"></asp:TextBox>
       </td>
        <td align="left" valign="top">
            <asp:Label ID="Label11" runat="server" Text="Weight(%)"></asp:Label>
        </td>
        <td align="left" valign="top">
            <asp:TextBox ID="txtw8" runat="server" Width="100px" onkeyup="checklimit(this.id)"></asp:TextBox>
        </td>
    </tr>
    <tr class ="tbcolor1" id="r9" runat="server">
        <td>
            Assessment:9(Max Marks)</td>
        <td valign="top" align="left">
           
            <asp:TextBox ID="ass9" runat="server" Width="100px" onkeyup="checklimit(this.id)"></asp:TextBox>
       </td>
        <td align="left" valign="top">
            <asp:Label ID="Label12" runat="server" Text="Weight(%)"></asp:Label>
        </td>
        <td align="left" valign="top">
            <asp:TextBox ID="txtw9" runat="server" Width="100px" onkeyup="checklimit(this.id)"></asp:TextBox>
        </td>
    </tr>
    <tr class ="tbcolor2" id="r10" runat="server">
        <td>
            Assessment:10(Max Marks)</td>
        <td valign="top" align="left">
           
            <asp:TextBox ID="ass10" runat="server" Width="100px" onkeyup="checklimit(this.id)"></asp:TextBox>
       </td>
        <td align="left" valign="top">
            <asp:Label ID="Label13" runat="server" Text="Weight(%)"></asp:Label>
        </td>
        <td align="left" valign="top">
            <asp:TextBox ID="txtw10" runat="server" Width="100px" onkeyup="checklimit(this.id)"></asp:TextBox>
        </td>
    </tr>
    <tr class ="tbcolor1" id="r77" runat="server">
    
        <td colspan ="2" align ="center">
            <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                <ContentTemplate>
            <asp:Button ID="Button2" runat="server" OnClick="btn_submit_Click" 
                Text="Submit" ValidationGroup="a" style="height: 26px" />
            </ContentTemplate>
            </asp:UpdatePanel>
        </td>
        <td align="center">
            &nbsp;</td>
        <td align="center">
            &nbsp;</td>
    </tr>
</table>
</ContentTemplate></asp:UpdatePanel></div></div>
</div>
 <div id="cngridviewsmall" class="cngridviewsmallAssesment">
     <asp:UpdatePanel ID="UpdatePanel3" runat="server">
        <ContentTemplate>
<asp:GridView ID="GridView1" runat="server"
                AutoGenerateColumns ="False"   DataKeyNames ="Id" 
                onrowediting="GridView1_RowEditing" 
            CellPadding="4"   PagerSettings-Mode ="Numeric" PageSize="20" 
            onrowdeleting="GridView1_RowDeleting" 
            onselectedindexchanging="GridView1_SelectedIndexChanging" 
             BackColor="#CCCCCC" BorderColor="Black" BorderStyle="Inset" 
             BorderWidth="1px" ForeColor="Black" UseAccessibleHeader="False" 
            AllowSorting="True" onrowdatabound="GridView1_RowDataBound">
            <Columns >
                <asp:BoundField DataField="Course" HeaderText="Course" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Year" HeaderText="Year(Level)" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="ModuleName" HeaderText="Module-Name" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="ModuleCode" HeaderText="ModuleCode" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
              
                <asp:BoundField DataField="ModuleSem" HeaderText="Semester" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                
                <asp:BoundField DataField="Lecture" HeaderText="Lecture" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Wrap="false">
              <HeaderStyle Width="1000px"></HeaderStyle>
	<ItemStyle Width="1000px"></ItemStyle>
                </asp:BoundField>
                
                <asp:BoundField DataField="Tutorial" HeaderText="Tutorial" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                
                 <asp:BoundField DataField="Assesment1" HeaderText="Assesment" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                
                 <asp:BoundField DataField="Assesment2" HeaderText="Max Marks" 
                HeaderStyle-HorizontalAlign="Center">
                    <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
               
                <asp:CommandField ShowEditButton ="true" EditImageUrl="~/images/edit.png" 
                    HeaderText="Edit" ButtonType="Image" />
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
      </div>
     
       </div> 
</asp:Content>

