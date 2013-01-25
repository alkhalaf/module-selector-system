using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class Student_Gradeprediction : System.Web.UI.Page
{
 
    protected void Page_Load(object sender, EventArgs e)
    {
        ImageButton1.Visible = false; ImageButton2.Visible = false;
        Label5.Text = ""; Label6.Text = ""; Label7.Text = ""; Label8.Text = "";
        Label9.Text = ""; Label10.Text = ""; Label11.Text = ""; Label12.Text = "";
        Label13.Text = ""; Label14.Text = ""; labelTogetFirst.Text = "";
        declarationdegree();
        if (!Page.IsPostBack)
        {
            Progressbar1.Visible = false; Progressbar4.Visible = false; Progressbar7.Visible = false; Progressbar9.Visible = false;
            Progressbar2.Visible = false; Progressbar5.Visible = false; Progressbar8.Visible = false; Progressbar10.Visible = false;
            Progressbar3.Visible = false; Progressbar6.Visible = false; labelBar1.Visible = false; labelBar2.Visible = false;
            labelBar3.Visible = false; labelBar4.Visible = false; labelBar5.Visible = false; labelBar6.Visible = false;
            labelBar7.Visible = false; labelBar8.Visible = false; labelBar9.Visible = false; labelBar10.Visible = false;
        }

    }
    protected void menuTabss_MenuItemClick(object sender, MenuEventArgs e)
    {
        switch (e.Item.Text)
        {

            case "Level-4":
                MultiView1.ActiveViewIndex = 0;
                Response.Redirect("Gradeprediction.aspx");
                break;

            case "Level-5":
                MultiView1.ActiveViewIndex = 1;
                Response.Redirect("GradepredictionLevel2.aspx");
                break;
            case "Level-6":
                MultiView1.ActiveViewIndex = 2;
                Response.Redirect("GradepredictionLevel3.aspx");
                break;

            case "Summary":
                MultiView1.ActiveViewIndex = 2;
                Response.Redirect("Summery.aspx");
                break;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    { 
    }
    protected void imgbtny1m1_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["l1txt1"] != null)
        {
            Progressbar1.Visible = true;
            labelBar1.Visible = true;
            Progressbar1.Value = Convert.ToInt32(Session["l1txt1"].ToString());
            Label5.Text = Session["l1txt1"].ToString()+'%';
        }
        else
        {
            Progressbar1.Visible = false;
            labelBar1.Visible = false;
        }
        if (Session["l1txt2"] != null)
        {
            Progressbar2.Visible = true;
            labelBar2.Visible = true;
            Progressbar2.Value = Convert.ToInt32(Session["l1txt2"].ToString());
            Label6.Text = Session["l1txt2"].ToString() + '%';
        }
        else
        {
            Progressbar2.Visible = false;
            labelBar2.Visible = false;
        }
        if (Session["l1txt3"] != null)
        {
            Progressbar3.Visible = true;
            labelBar3.Visible = true;
            Progressbar3.Value = Convert.ToInt32(Session["l1txt3"].ToString());
            Label7.Text = Session["l1txt3"].ToString() + '%';
        }
        else
        {
            Progressbar3.Visible = false;
            labelBar3.Visible = false;
        }
        if (Session["l1txt4"] != null)
        {
            Progressbar4.Visible = true;
            labelBar4.Visible = true;
            Progressbar4.Value = Convert.ToInt32(Session["l1txt4"].ToString());
            Label8.Text = Session["l1txt4"].ToString() + '%';
        }
        else
        {
            Progressbar4.Visible = false;
            labelBar4.Visible = false;
        }
        if (Session["l1txt5"] != null)
        {
            Progressbar5.Visible = true;
            labelBar5.Visible = true;
            Progressbar5.Value = Convert.ToInt32(Session["l1txt5"].ToString());
            Label9.Text = Session["l1txt5"].ToString() + '%';
        }
        else
        {
            Progressbar5.Visible = false;
            labelBar5.Visible = false;
        }
        if (Session["l1txt6"] != null)
        {
            Progressbar6.Visible = true;
            labelBar6.Visible = true;
            Progressbar6.Value = Convert.ToInt32(Session["l1txt6"].ToString());
            Label10.Text = Session["l1txt6"].ToString() + '%';
        }
        else
        {
            Progressbar6.Visible = false;
            labelBar6.Visible = false;
        }
        if (Session["l1txt7"] != null)
        {
            Progressbar7.Visible = true;
            labelBar7.Visible = true;
            Progressbar7.Value = Convert.ToInt32(Session["l1txt7"].ToString());
            Label11.Text = Session["l1txt7"].ToString() + '%';
        }
        else
        {
            Progressbar7.Visible = false;
            labelBar7.Visible = false;
        }
        if (Session["l1txt8"] != null)
        {
            Progressbar8.Visible = true;
            labelBar8.Visible = true;
            Progressbar8.Value = Convert.ToInt32(Session["l1txt8"].ToString());
            Label11.Text = Session["l1txt8"].ToString() + '%';
        }
        else
        {
            labelBar8.Visible = false;
            Progressbar8.Visible = false;
        }
        if (Session["l1txt9"] != null)
        {
            Progressbar9.Visible = true;
            labelBar9.Visible = true;
            Progressbar9.Value = Convert.ToInt32(Session["l1txt9"].ToString());
            Label12.Text = Session["l1txt9"].ToString() + '%';
        }
        else
        {
            Progressbar9.Visible = false;
            labelBar9.Visible = false;
        }
        if (Session["l1txt10"] != null)
        {
            Progressbar10.Visible = true;
            labelBar10.Visible = true;
            Progressbar10.Value = Convert.ToInt32(Session["l1txt10"].ToString());
            Label13.Text = Session["l1txt10"].ToString() + '%';
        }
        else
        {
            Progressbar10.Visible = false;
            labelBar10.Visible = false;
        }
    }
    protected void imgbtny1m2_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["l1txt11"] != null)
        {
            Progressbar1.Visible = true;
            labelBar1.Visible = true;
            Progressbar1.Value = Convert.ToInt32(Session["l1txt11"].ToString());
            Label5.Text = Session["l1txt11"].ToString() + '%';
        }
        else
        {
            Progressbar1.Visible = false;
            labelBar1.Visible = false;
        }
        if (Session["l1txt12"] != null)
        {
            Progressbar2.Visible = true;
            labelBar2.Visible = true;
            Progressbar2.Value = Convert.ToInt32(Session["l1txt12"].ToString());
            Label6.Text = Session["l1txt12"].ToString() + '%';
        }
        else
        {
            Progressbar2.Visible =false;
            labelBar2.Visible = false;
        }
        if (Session["l1txt13"] != null)
        {
            Progressbar3.Visible = true;
            labelBar3.Visible = true;
            Progressbar3.Value = Convert.ToInt32(Session["l1txt13"].ToString());
            Label7.Text = Session["l1txt13"].ToString() + '%';
        }
        else
        {
            Progressbar3.Visible = false;
            labelBar3.Visible = false;
        }
        if (Session["l1txt14"] != null)
        {
            Progressbar4.Visible = true;
            labelBar4.Visible = true;
            Progressbar4.Value = Convert.ToInt32(Session["l1txt14"].ToString());
            Label8.Text = Session["l1txt14"].ToString() + '%';
        }
        else
        {
            Progressbar4.Visible = false;
            labelBar4.Visible = false;
        }
        if (Session["l1txt15"] != null)
        {
            Progressbar5.Visible = true;
            labelBar5.Visible = true;
            Progressbar5.Value = Convert.ToInt32(Session["l1txt15"].ToString());
            Label9.Text = Session["l1txt15"].ToString() + '%';
        }
        else
        {
            Progressbar5.Visible = false;
            labelBar5.Visible = false;
        }
        if (Session["l1txt16"] != null)
        {
            Progressbar6.Visible = true;
            labelBar6.Visible = true;
            Progressbar6.Value = Convert.ToInt32(Session["l1txt16"].ToString());
            Label10.Text = Session["l1txt17"].ToString() + '%';
        }
        else
        {
            Progressbar6.Visible = false;
            labelBar6.Visible = false;
        }
        if (Session["l1txt17"]!= null)
        {
            Progressbar7.Visible = true;
            labelBar7.Visible = true;
            Progressbar7.Value = Convert.ToInt32(Session["l1txt17"].ToString());
            Label11.Text = Session["l1txt17"].ToString() + '%';
        }
        else
        {
            Progressbar7.Visible = false;
            labelBar7.Visible = false;
        }
        if (Session["l1txt18"]!= null)
        {
            Progressbar8.Visible = true;
            labelBar8.Visible = true;
            Progressbar8.Value = Convert.ToInt32(Session["l1txt18"].ToString());
            Label12.Text = Session["l1txt18"].ToString() + '%';
        }
        else
        {
            Progressbar8.Visible = false;
            labelBar8.Visible = false;
        }
        if (Session["l1txt19"]!= null)
        {
            Progressbar9.Visible = true;
            labelBar9.Visible = true;
            Progressbar9.Value = Convert.ToInt32(Session["l1txt19"].ToString());
            Label13.Text = Session["l1txt19"].ToString() + '%';
        }
        else
        {
            Progressbar9.Visible = false;
            labelBar9.Visible = false;
        }
        if (Session["l1txt20"]!= null)
        {
            Progressbar10.Visible = true;
            labelBar10.Visible = true;
            Progressbar10.Value = Convert.ToInt32(Session["l1txt20"].ToString());
            Label14.Text = Session["l1txt20"].ToString() + '%';
        }
        else
        {
            Progressbar10.Visible = false;
            labelBar10.Visible = false;
        }
    }
    protected void imgbtny1m3_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["l1txt21"] != null)
        {
            Progressbar1.Visible = true;
            labelBar1.Visible = true;
            Progressbar1.Value = Convert.ToInt32(Session["l1txt21"].ToString());
            Label5.Text = Session["l1txt21"].ToString() + '%';
        }
        else
        {
            Progressbar1.Visible = false;
            labelBar1.Visible = false;
        }
        if (Session["l1txt22"] != null)
        {
            Progressbar2.Visible = true;
            labelBar2.Visible = true;
            Progressbar2.Value = Convert.ToInt32(Session["l1txt22"].ToString());
            Label6.Text = Session["l1txt22"].ToString() + '%';
        }
        else
        {
            Progressbar2.Visible = false;
            labelBar2.Visible = false;
        }
        if (Session["l1txt23"] != null)
        {
            Progressbar3.Visible = true;
            labelBar3.Visible = true;
            Progressbar3.Value = Convert.ToInt32(Session["l1txt23"].ToString());
            Label7.Text = Session["l1txt23"].ToString() + '%';
        }
        else
        {
            Progressbar3.Visible = false;
            labelBar3.Visible = false;
        }
        if (Session["l1txt24"] != null)
        {
            Progressbar4.Visible = true;
            labelBar4.Visible = true;
            Progressbar4.Value = Convert.ToInt32(Session["l1txt24"].ToString());
            Label8.Text = Session["l1txt24"].ToString() + '%';
        }
        else
        {
            Progressbar4.Visible = false;
            labelBar4.Visible = false;
        }
        if (Session["l1txt25"] != null)
        {
            Progressbar5.Visible = true;
            labelBar5.Visible = true;
            Progressbar5.Value = Convert.ToInt32(Session["l1txt25"].ToString());
            Label9.Text = Session["l1txt25"].ToString() + '%';
        }
        else
        {
            Progressbar5.Visible = false;
            labelBar5.Visible = false;
        }
        if (Session["l1txt26"] != null)
        {
            Progressbar6.Visible = true;
            labelBar6.Visible = true;
            Progressbar6.Value = Convert.ToInt32(Session["l1txt26"].ToString());
            Label10.Text = Session["l1txt26"].ToString() + '%';
        }
        else
        {
            Progressbar6.Visible = false;
            labelBar6.Visible = false;
        }
        if (Session["l1txt27"] != null)
        {
            Progressbar7.Visible = true;
            labelBar7.Visible = true;
            Progressbar7.Value = Convert.ToInt32(Session["l1txt27"].ToString());
            Label11.Text = Session["l1txt27"].ToString() + '%';
        }
        else
        {
            Progressbar7.Visible = false;
            labelBar7.Visible = false;
        }
        if (Session["l1txt28"] != null)
        {
            Progressbar8.Visible = true;
            labelBar8.Visible = true;
            Progressbar8.Value = Convert.ToInt32(Session["l1txt28"].ToString());
            Label12.Text = Session["l1txt28"].ToString() + '%';
        }
        else
        {
            Progressbar8.Visible = false;
            labelBar8.Visible = false;
        }
        if (Session["l1txt29"] != null)
        {
            Progressbar9.Visible = true;
            labelBar9.Visible = true;
            Progressbar9.Value = Convert.ToInt32(Session["l1txt29"].ToString());
            Label13.Text = Session["l1txt29"].ToString() + '%';
        }
        else
        {
            Progressbar9.Visible = false;
            labelBar9.Visible = false;
        }
        if (Session["l1txt30"] != null)
        {
            Progressbar10.Visible = true;
            labelBar10.Visible = true;
            Progressbar10.Value = Convert.ToInt32(Session["l1txt30"].ToString());
            Label14.Text = Session["l1txt30"].ToString() + '%';
        }
        else
        {
            Progressbar10.Visible = false;
            labelBar10.Visible = false;
        }

    }
    protected void imgbtny1m4_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["l1txt31"] != null)
        {
            Progressbar1.Visible = true;
            labelBar1.Visible = true;
            Progressbar1.Value = Convert.ToInt32(Session["l1txt31"].ToString());
            Label5.Text = Session["l1txt31"].ToString() + '%';
        }
        else
        {
            Progressbar1.Visible = false;
            labelBar1.Visible = false;
        }
        if (Session["l1txt32"] != null)
        {
            Progressbar2.Visible = true;
            labelBar2.Visible = true;
            Progressbar2.Value = Convert.ToInt32(Session["l1txt32"].ToString());
            Label6.Text = Session["l1txt31"].ToString() + '%';
        }
        else
        {
            Progressbar2.Visible = false;
            labelBar2.Visible = false;
        }
        if (Session["l1txt33"] != null)
        {
            Progressbar3.Visible = true;
            labelBar3.Visible = true;
            Progressbar3.Value = Convert.ToInt32(Session["l1txt33"].ToString());
            Label7.Text = Session["l1txt33"].ToString() + '%';
        }
        else
        {
            Progressbar3.Visible = false;
            labelBar3.Visible = false;
        }
        if (Session["l1txt34"] != null)
        {
            Progressbar4.Visible = true;
            labelBar4.Visible = true;
            Progressbar4.Value = Convert.ToInt32(Session["l1txt34"].ToString());
            Label8.Text = Session["l1txt34"].ToString() + '%';
        }
        else
        {
            Progressbar4.Visible = false;
            labelBar4.Visible = false;
        }
        if (Session["l1txt35"] != null)
        {
            Progressbar5.Visible = true;
            labelBar5.Visible = true;
            Progressbar5.Value = Convert.ToInt32(Session["l1txt35"].ToString());
            Label9.Text = Session["l1txt35"].ToString() + '%';
        }
        else
        {
            Progressbar5.Visible = false;
            labelBar5.Visible = false;
        }
        if (Session["l1txt36"] != null)
        {
            Progressbar6.Visible = true;
            labelBar6.Visible = true;
            Progressbar6.Value = Convert.ToInt32(Session["l1txt36"].ToString());
            Label10.Text = Session["l1txt36"].ToString() + '%';
        }
        else
        {
            Progressbar6.Visible = false;
            labelBar6.Visible =false;
        }
        if (Session["l1txt37"] != null)
        {
            Progressbar7.Visible = true;
            labelBar7.Visible = true;
            Progressbar7.Value = Convert.ToInt32(Session["l1txt37"].ToString());
            Label11.Text = Session["l1txt37"].ToString() + '%';
        }
        else
        {
            Progressbar7.Visible = false;
            labelBar7.Visible = false;
        }
        if (Session["l1txt38"] != null)
        {
            Progressbar8.Visible = true;
            labelBar8.Visible = true;
            Progressbar8.Value = Convert.ToInt32(Session["l1txt38"].ToString());
            Label12.Text = Session["l1txt38"].ToString() + '%';
        }
        else
        {
            Progressbar8.Visible = false;
            labelBar8.Visible = false;
        }
        if (Session["l1txt39"] != null)
        {
            Progressbar9.Visible = true;
            labelBar9.Visible = true;
            Progressbar9.Value = Convert.ToInt32(Session["l1txt39"].ToString());
            Label13.Text = Session["l1txt39"].ToString() + '%';
        }
        else
        {
            Progressbar9.Visible = false;
            labelBar9.Visible = false;
        }
        if (Session["l1txt40"] != null)
        {
            Progressbar10.Visible = true;
            labelBar10.Visible = true;
            Progressbar10.Value = Convert.ToInt32(Session["l1txt40"].ToString());
            Label14.Text = Session["l1txt40"].ToString() + '%';
        }
        else
        {
            Progressbar10.Visible = false;
            labelBar10.Visible = false;
        }
    }
    protected void imgbtny1m5_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["l1txt41"] != null)
        {
            Progressbar1.Visible = true;
            labelBar1.Visible = true;
            Progressbar1.Value = Convert.ToInt32(Session["l1txt41"].ToString());
            Label5.Text = Session["l1txt41"].ToString() + '%';
        }
        else
        {
            Progressbar1.Visible = false;
            labelBar1.Visible = false;
        }
        if (Session["l1txt42"] != null)
        {
            Progressbar2.Visible = true;
            labelBar2.Visible = true;
            Progressbar2.Value = Convert.ToInt32(Session["l1txt42"].ToString());
            Label6.Text = Session["l1txt42"].ToString() + '%';
        }
        else
        {
            Progressbar2.Visible = false;
            labelBar2.Visible = false;
        }
        if (Session["l1txt43"] != null)
        {
            Progressbar3.Visible = true;
            labelBar3.Visible = true;
            Progressbar3.Value = Convert.ToInt32(Session["l1txt43"].ToString());
            Label7.Text = Session["l1txt43"].ToString() + '%';
        }
        else
        {
            Progressbar3.Visible =false;
            labelBar3.Visible = false;
        }
        if (Session["l1txt44"] != null)
        {
            Progressbar4.Visible = true;
            labelBar4.Visible = true;
            Progressbar4.Value = Convert.ToInt32(Session["l1txt44"].ToString());
            Label8.Text = Session["l1txt44"].ToString() + '%';
        }
        else
        {
            Progressbar4.Visible = false;
            labelBar4.Visible = false;
        }
        if (Session["l1txt45"] != null)
        {
            Progressbar5.Visible = true;
            labelBar5.Visible = true;
            Progressbar5.Value = Convert.ToInt32(Session["l1txt45"].ToString());
            Label9.Text = Session["l1txt45"].ToString() + '%';
        }
        else
        {
            Progressbar5.Visible = false;
            labelBar5.Visible =false;
        }
        if (Session["l1txt46"] != null)
        {
            Progressbar6.Visible = true;
            labelBar6.Visible = true;
            Progressbar6.Value = Convert.ToInt32(Session["l1txt46"].ToString());
            Label10.Text = Session["l1txt46"].ToString() + '%';
        }
        else
        {
            Progressbar6.Visible = false;
            labelBar6.Visible = false;
        }
        if (Session["l1txt47"] != null)
        {
            Progressbar7.Visible = true;
            labelBar7.Visible = true;
            Progressbar7.Value = Convert.ToInt32(Session["l1txt47"].ToString());
            Label11.Text = Session["l1txt47"].ToString() + '%';
        }
        else
        {
            Progressbar7.Visible = false;
            labelBar7.Visible = false;
        }
        if (Session["l1txt48"] != null)
        {
            Progressbar8.Visible = true;
            labelBar8.Visible = true;
            Progressbar8.Value = Convert.ToInt32(Session["l1txt48"].ToString());
            Label12.Text = Session["l1txt48"].ToString() + '%';
        }
        else
        {
            Progressbar8.Visible = false;
            labelBar8.Visible = false;
        }
        if (Session["l1txt49"] != null)
        {
            Progressbar9.Visible = true;
            labelBar9.Visible = true;
            Progressbar9.Value = Convert.ToInt32(Session["l1txt49"].ToString());
            Label13.Text = Session["l1txt49"].ToString() + '%';
        }
        else
        {
            Progressbar9.Visible = false;
            labelBar9.Visible = false;
        }
        if (Session["l1txt50"] != null)
        {
            Progressbar10.Visible = true;
            labelBar10.Visible = true;
            Progressbar10.Value = Convert.ToInt32(Session["l1txt50"].ToString());
            Label14.Text = Session["l1txt50"].ToString() + '%';
        }
        else
        {
            Progressbar10.Visible = false;
            labelBar10.Visible = false;
        }

    }
    protected void imgbtny1m6_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["l1txt51"] != null)
        {
            Progressbar1.Visible = true;
            labelBar1.Visible = true;
            Progressbar1.Value = Convert.ToInt32(Session["l1txt51"].ToString());
            Label5.Text = Session["l1txt51"].ToString() + '%';
        }
        else
        {
            Progressbar1.Visible = false;
            labelBar1.Visible = false;
        }
        if (Session["l1txt52"] != null)
        {
            Progressbar2.Visible = true;
            labelBar2.Visible = true;
            Progressbar2.Value = Convert.ToInt32(Session["l1txt52"].ToString());
            Label6.Text = Session["l1txt52"].ToString() + '%';
        }
        else
        {
            Progressbar2.Visible = false;
            labelBar2.Visible = false;
        }
        if (Session["l1txt53"] != null)
        {
            Progressbar3.Visible = true;
            labelBar3.Visible = true;
            Progressbar3.Value = Convert.ToInt32(Session["l1txt53"].ToString());
            Label7.Text = Session["l1txt53"].ToString() + '%';
        }
        else
        {
            Progressbar3.Visible =false;
            labelBar3.Visible = false;
        }
        if (Session["l1txt54"] != null)
        {
            Progressbar4.Visible = true;
            labelBar4.Visible = true;
            Progressbar4.Value = Convert.ToInt32(Session["l1txt54"].ToString());
            Label8.Text = Session["l1txt54"].ToString() + '%';
        }
        else
        {
            Progressbar4.Visible = false;
            labelBar4.Visible = false;
        }
        if (Session["l1txt55"] != null)
        {
            Progressbar5.Visible = true;
            labelBar5.Visible = true;
            Progressbar5.Value = Convert.ToInt32(Session["l1txt55"].ToString());
            Label9.Text = Session["l1txt55"].ToString() + '%';
        }
        else
        {
            Progressbar5.Visible = false;
            labelBar5.Visible = false;
        }
        if (Session["l1txt56"] != null)
        {
            Progressbar6.Visible = true;
            labelBar6.Visible = true;
            Progressbar6.Value = Convert.ToInt32(Session["l1txt56"].ToString());
            Label10.Text = Session["l1txt56"].ToString() + '%';
        }
        else
        {
            Progressbar6.Visible = false;
            labelBar6.Visible = false;
        }
        if (Session["l1txt57"] != null)
        {
            Progressbar7.Visible = true;
            labelBar7.Visible = true;
            Progressbar7.Value = Convert.ToInt32(Session["l1txt57"].ToString());
            Label11.Text = Session["l1txt57"].ToString() + '%';
        }
        else
        {
            Progressbar7.Visible = false;
            labelBar7.Visible = false;
        }
        if (Session["l1txt58"] != null)
        {
            Progressbar8.Visible = true;
            labelBar8.Visible = true;
            Progressbar8.Value = Convert.ToInt32(Session["l1txt58"].ToString());
            Label12.Text = Session["l1txt58"].ToString() + '%';
        }
        else
        {
            Progressbar8.Visible =false;
            labelBar8.Visible = false;
        }
        if (Session["l1txt59"] != null)
        {
            Progressbar9.Visible = true;
            labelBar9.Visible = true;
            Progressbar9.Value = Convert.ToInt32(Session["l1txt59"].ToString());
            Label13.Text = Session["l1txt59"].ToString() + '%';
        }
        else
        {
            Progressbar9.Visible = false;
            labelBar9.Visible = false;
        }
        if (Session["l1txt60"] != null)
        {
            Progressbar10.Visible = true;
            labelBar10.Visible = true;
            Progressbar10.Value = Convert.ToInt32(Session["l1txt60"].ToString());
            Label10.Text = Session["l1txt60"].ToString() + '%';
        }
        else
        {
            Progressbar10.Visible = false;
            labelBar10.Visible = false;
        }
    }
    protected void imgbtny1m7_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["l1txt61"] != null)
        {
            Progressbar1.Visible = true;
            labelBar1.Visible = true;
            Progressbar1.Value = Convert.ToInt32(Session["l1txt61"].ToString());
            Label5.Text = Session["l1txt61"].ToString() + '%';
        }
        else
        {
            Progressbar1.Visible = false;
            labelBar1.Visible = false;
        }
        if (Session["l1txt62"] != null)
        {
            Progressbar2.Visible = true;
            labelBar2.Visible = true;
            Progressbar2.Value = Convert.ToInt32(Session["l1txt62"].ToString());
            Label6.Text = Session["l1txt62"].ToString() + '%';
        }
        else
        {
            Progressbar2.Visible = false;
            labelBar2.Visible = false;
        }
        if (Session["l1txt63"] != null)
        {
            Progressbar3.Visible = true;
            labelBar3.Visible = true;
            Progressbar3.Value = Convert.ToInt32(Session["l1txt63"].ToString());
            Label7.Text = Session["l1txt63"].ToString() + '%';
        }
        else
        {
            Progressbar3.Visible = false;
            labelBar3.Visible = false;
        }
        if (Session["l1txt64"] != null)
        {
            Progressbar4.Visible = true;
            labelBar3.Visible = true;
            Progressbar4.Value = Convert.ToInt32(Session["l1txt64"].ToString());
            Label8.Text = Session["l1txt64"].ToString() + '%';
        }
        else
        {
            Progressbar4.Visible = false;
            labelBar4.Visible = false;
        }
        if (Session["l1txt65"] != null)
        {
            Progressbar5.Visible = true;
            labelBar5.Visible = true;
            Progressbar5.Value = Convert.ToInt32(Session["l1txt65"].ToString());
            Label9.Text = Session["l1txt65"].ToString() + '%';
        }
        else
        {
            Progressbar5.Visible = false;
            labelBar5.Visible = false;
        }
        if (Session["l1txt66"] != null)
        {
            Progressbar6.Visible = true;
            labelBar6.Visible = true;
            Progressbar6.Value = Convert.ToInt32(Session["l1txt66"].ToString());
            Label10.Text = Session["l1txt66"].ToString() + '%';
        }
        else
        {
            Progressbar6.Visible = false;
            labelBar6.Visible = false;
        }
        if (Session["l1txt67"] != null)
        {
            Progressbar7.Visible = true;
            labelBar7.Visible = true;
            Progressbar7.Value = Convert.ToInt32(Session["l1txt67"].ToString());
            Label11.Text = Session["l1txt67"].ToString() + '%';
        }
        else
        {
            Progressbar7.Visible = false;
            labelBar7.Visible = false;
        }
        if (Session["l1txt68"] != null)
        {
            Progressbar8.Visible = true;
            labelBar8.Visible = true;
            Progressbar8.Value = Convert.ToInt32(Session["l1txt68"].ToString());
            Label12.Text = Session["l1txt68"].ToString() + '%';
        }
        else
        {
            Progressbar8.Visible = false;
            labelBar8.Visible = false;
        }
        if (Session["l1txt69"] != null)
        {
            //Start Adding labelBar8.Visible = true;
            Progressbar9.Visible = true;
            labelBar9.Visible = true;
            Progressbar9.Value = Convert.ToInt32(Session["l1txt69"].ToString());
            Label13.Text = Session["l1txt69"].ToString() + '%';
        }
        else
        {
            Progressbar9.Visible = false;
            labelBar9.Visible = false;
        }
        if (Session["l1txt70"] != null)
        {
            Progressbar10.Visible = true;
            labelBar10.Visible = true;
            Progressbar10.Value = Convert.ToInt32(Session["l1txt70"].ToString());
            Label14.Text = Session["l1txt70"].ToString() + '%';
        }
        else
        {
            Progressbar10.Visible = false;
            labelBar10.Visible = false;
        }
    }
    protected void imgbtny1m8_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["l1txt71"] != null)
        {
            Progressbar1.Visible = true;
            labelBar1.Visible = true;
            Progressbar1.Value = Convert.ToInt32(Session["l1txt71"].ToString());
            Label5.Text = Session["l3txt71"].ToString() + '%';
        }
        else
        {
            Progressbar1.Visible = false;
            labelBar1.Visible = false;
        }
        if (Session["l1txt72"] != null)
        {
            Progressbar2.Visible = true;
            labelBar2.Visible = true;
            Progressbar2.Value = Convert.ToInt32(Session["l1txt72"].ToString());
            Label6.Text = Session["l1txt72"].ToString() + '%';
        }
        else
        {
            Progressbar2.Visible = false;
            labelBar2.Visible = false;
        }
        if (Session["l1txt73"] != null)
        {
            Progressbar3.Visible = true;
            labelBar3.Visible = true;
            Progressbar3.Value = Convert.ToInt32(Session["l1txt73"].ToString());
            Label7.Text = Session["l3txt73"].ToString() + '%';
        }
        else
        {
            Progressbar3.Visible = false;
            labelBar3.Visible = false;
        }
        if (Session["l1txt74"] != null)
        {
            Progressbar4.Visible = true;
            labelBar4.Visible = true;
            Progressbar4.Value = Convert.ToInt32(Session["l1txt74"].ToString());
            Label8.Text = Session["l3txt74"].ToString() + '%';
        }
        else
        {
            Progressbar4.Visible = false;
            labelBar4.Visible = false;
        }
        if (Session["l1txt75"] != null)
        {
            Progressbar5.Visible = true;
            labelBar5.Visible = true;
            Progressbar5.Value = Convert.ToInt32(Session["l1txt75"].ToString());
            Label9.Text = Session["l3txt75"].ToString() + '%';
        }
        else
        {
            Progressbar5.Visible = false;
            labelBar5.Visible = false;
        }
        if (Session["l1txt76"] != null)
        {
            Progressbar6.Visible = true;
            labelBar6.Visible = true;
            Progressbar6.Value = Convert.ToInt32(Session["l1txt76"].ToString());
            Label10.Text = Session["l3txt76"].ToString() + '%';
        }
        else
        {
            Progressbar6.Visible = false;
            labelBar6.Visible = false;
        }
        if (Session["l1txt77"] != null)
        {
            Progressbar7.Visible = true;
            labelBar7.Visible = true;
            Progressbar7.Value = Convert.ToInt32(Session["l1txt77"].ToString());
            Label11.Text = Session["l3txt77"].ToString() + '%';
        }
        else
        {
            Progressbar7.Visible = false;
            labelBar7.Visible = false;
        }
        if (Session["l1txt78"] != null)
        {
            Progressbar8.Visible = true;
            labelBar8.Visible = true;
            Progressbar8.Value = Convert.ToInt32(Session["l1txt78"].ToString());
            Label12.Text = Session["l3txt78"].ToString() + '%';
        }
        else
        {
            Progressbar8.Visible = false;
            labelBar8.Visible = false;
        }
        if (Session["l1txt79"] != null)
        {
            Progressbar9.Visible = true;
            labelBar9.Visible = true;
            Progressbar9.Value = Convert.ToInt32(Session["l1txt79"].ToString());
            Label13.Text = Session["l3txt79"].ToString() + '%';
        }
        else
        {
            Progressbar9.Visible = false;
            labelBar9.Visible = false;
        }
        if (Session["l1txt80"] != null)
        {
            Progressbar10.Visible = true;
            labelBar10.Visible = true;
            Progressbar10.Value = Convert.ToInt32(Session["l1txt80"].ToString());
            Label14.Text = Session["l3txt80"].ToString() + '%';
        }
        else
        {
            Progressbar10.Visible = false;
            labelBar10.Visible = false;
        }
    }
    protected void imgbtny2m1_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["l2txt1"] != null)
        {
            Progressbar1.Visible = true;
            labelBar1.Visible = true;
            Progressbar1.Value = Convert.ToInt32(Session["l2txt1"].ToString());
            Label5.Text = Session["l2txt1"].ToString() + '%';
        }
        else
        {
            Progressbar1.Visible = false;
            labelBar1.Visible = false;
        }
        if (Session["l2txt2"] != null)
        {
            Progressbar2.Visible = true;
            labelBar2.Visible = true;
            Progressbar2.Value = Convert.ToInt32(Session["l2txt2"].ToString());
            Label6.Text = Session["l2txt2"].ToString() + '%';
        }
        else
        {
            Progressbar2.Visible = false;
            labelBar2.Visible = false;
        }
        if (Session["l2txt3"] != null)
        {
            Progressbar3.Visible = true;
            labelBar3.Visible = true;
            Progressbar3.Value = Convert.ToInt32(Session["l2txt3"].ToString());
            Label7.Text = Session["l2txt3"].ToString() + '%';
        }
        else
        {
            Progressbar3.Visible = false;
            labelBar3.Visible = false;
        }
        if (Session["l2txt4"] != null)
        {
            Progressbar4.Visible = true;
            labelBar4.Visible = true;
            Progressbar4.Value = Convert.ToInt32(Session["l2txt4"].ToString());
            Label8.Text = Session["l2txt4"].ToString() + '%';
        }
        else
        {
            Progressbar4.Visible = false;
            labelBar4.Visible = false;
        }
        if (Session["l2txt5"] != null)
        {
            Progressbar5.Visible = true;
            labelBar5.Visible = true;
            Progressbar5.Value = Convert.ToInt32(Session["l2txt5"].ToString());
            Label9.Text = Session["l2txt5"].ToString() + '%';
        }
        else
        {
            Progressbar5.Visible = false;
            labelBar5.Visible = false;
        }
        if (Session["l2txt6"] != null)
        {
            Progressbar6.Visible = true;
            labelBar6.Visible = true;
            Progressbar6.Value = Convert.ToInt32(Session["l2txt6"].ToString());
            Label10.Text = Session["l2txt6"].ToString() + '%';
        }
        else
        {
            Progressbar6.Visible = false;
            labelBar6.Visible = false;
        }
        if (Session["l2txt7"] != null)
        {
            Progressbar7.Visible = true;
            labelBar7.Visible = true;
            Progressbar7.Value = Convert.ToInt32(Session["l2txt7"].ToString());
            Label11.Text = Session["l2txt7"].ToString() + '%';
        }
        else
        {
            Progressbar7.Visible = false;
            labelBar7.Visible = false;
        }
        if (Session["l2txt8"] != null)
        {
            Progressbar8.Visible = true;
            labelBar8.Visible = true;
            Progressbar8.Value = Convert.ToInt32(Session["l2txt8"].ToString());
            Label12.Text = Session["l2txt8"].ToString() + '%';
        }
        else
        {
            labelBar8.Visible = false;
            Progressbar8.Visible = false;
        }
        if (Session["l2txt9"] != null)
        {
            Progressbar9.Visible = true;
            labelBar9.Visible = true;
            Progressbar9.Value = Convert.ToInt32(Session["l2txt9"].ToString());
            Label13.Text = Session["l2txt9"].ToString() + '%';
        }
        else
        {
            Progressbar9.Visible = false;
            labelBar9.Visible = false;
        }
        if (Session["l2txt10"] != null)
        {
            Progressbar10.Visible = true;
            labelBar10.Visible = true;
            Progressbar10.Value = Convert.ToInt32(Session["l2txt10"].ToString());
            Label14.Text = Session["l2txt10"].ToString() + '%';
        }
        else
        {
            Progressbar10.Visible = false;
            labelBar10.Visible = false;
        }
    }
    protected void imgbtny2m2_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["l2txt11"] != null)
        {
            Progressbar1.Visible = true;
            labelBar1.Visible = true;
            Progressbar1.Value = Convert.ToInt32(Session["l2txt11"].ToString());
            Label5.Text = Session["l2txt11"].ToString() + '%';
        }
        else
        {
            Progressbar1.Visible = false;
            labelBar1.Visible = false;
        }
        if (Session["l2txt12"] != null)
        {
            Progressbar2.Visible = true;
            labelBar2.Visible = true;
            Progressbar2.Value = Convert.ToInt32(Session["l2txt12"].ToString());
            Label6.Text = Session["l2txt12"].ToString() + '%';
        }
        else
        {
            Progressbar2.Visible = false;
            labelBar2.Visible = false;
        }
        if (Session["l2txt13"] != null)
        {
            Progressbar3.Visible = true;
            labelBar3.Visible = true;
            Progressbar3.Value = Convert.ToInt32(Session["l2txt13"].ToString());
            Label7.Text = Session["l2txt13"].ToString() + '%';
        }
        else
        {
            Progressbar3.Visible = false;
            labelBar3.Visible = false;
        }
        if (Session["l2txt14"] != null)
        {
            Progressbar4.Visible = true;
            labelBar4.Visible = true;
            Progressbar4.Value = Convert.ToInt32(Session["l2txt14"].ToString());
            Label8.Text = Session["l2txt14"].ToString() + '%';
        }
        else
        {
            Progressbar4.Visible = false;
            labelBar4.Visible = false;
        }
        if (Session["l2txt15"] != null)
        {
            Progressbar5.Visible = true;
            labelBar5.Visible = true;
            Progressbar5.Value = Convert.ToInt32(Session["l2txt15"].ToString());
            Label9.Text = Session["l2txt15"].ToString() + '%';
        }
        else
        {
            Progressbar5.Visible = false;
            labelBar5.Visible = false;
        }
        if (Session["l2txt16"] != null)
        {
            Progressbar6.Visible = true;
            labelBar6.Visible = true;
            Progressbar6.Value = Convert.ToInt32(Session["l2txt16"].ToString());
            Label10.Text = Session["l2txt16"].ToString() + '%';
        }
        else
        {
            Progressbar6.Visible = false;
            labelBar6.Visible = false;
        }
        if (Session["l2txt17"] != null)
        {
            Progressbar7.Visible = true;
            labelBar7.Visible = true;
            Progressbar7.Value = Convert.ToInt32(Session["l2txt17"].ToString());
            Label11.Text = Session["l2txt17"].ToString() + '%';
        }
        else
        {
            Progressbar7.Visible = false;
            labelBar7.Visible = false;
        }
        if (Session["l2txt18"] != null)
        {
            Progressbar8.Visible = true;
            labelBar8.Visible = true;
            Progressbar8.Value = Convert.ToInt32(Session["l2txt18"].ToString());
            Label12.Text = Session["l2txt18"].ToString() + '%';
        }
        else
        {
            Progressbar8.Visible = false;
            labelBar8.Visible = false;
        }
        if (Session["l2txt19"] != null)
        {
            Progressbar9.Visible = true;
            labelBar9.Visible = true;
            Progressbar9.Value = Convert.ToInt32(Session["l2txt19"].ToString());
            Label13.Text = Session["l2txt19"].ToString() + '%';
        }
        else
        {
            Progressbar9.Visible = false;
            labelBar9.Visible = false;
        }
        if (Session["l2txt20"] != null)
        {
            Progressbar10.Visible = true;
            labelBar10.Visible = true;
            Progressbar10.Value = Convert.ToInt32(Session["l2txt20"].ToString());
            Label14.Text = Session["l2txt20"].ToString() + '%';
        }
        else
        {
            Progressbar10.Visible = false;
            labelBar10.Visible = false;
        }
    }
    protected void imgbtny2m3_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["l1txt21"] != null)
        {
            Progressbar1.Visible = true;
            labelBar1.Visible = true;
            Progressbar1.Value = Convert.ToInt32(Session["l1txt21"].ToString());
            Label5.Text = Session["l1txt21"].ToString() + '%';
        }
        else
        {
            Progressbar1.Visible = false;
            labelBar1.Visible = false;
        }
        if (Session["l1txt22"] != null)
        {
            Progressbar2.Visible = true;
            labelBar2.Visible = true;
            Progressbar2.Value = Convert.ToInt32(Session["l1txt22"].ToString());
            Label6.Text = Session["l1txt22"].ToString() + '%';
        }
        else
        {
            Progressbar2.Visible = false;
            labelBar2.Visible = false;
        }
        if (Session["l1txt23"] != null)
        {
            Progressbar3.Visible = true;
            labelBar3.Visible = true;
            Progressbar3.Value = Convert.ToInt32(Session["l1txt23"].ToString());
            Label7.Text = Session["l1txt23"].ToString() + '%';
        }
        else
        {
            Progressbar3.Visible = false;
            labelBar3.Visible = false;
        }
        if (Session["l1txt24"] != null)
        {
            Progressbar4.Visible = true;
            labelBar4.Visible = true;
            Progressbar4.Value = Convert.ToInt32(Session["l1txt24"].ToString());
            Label8.Text = Session["l1txt24"].ToString() + '%';
        }
        else
        {
            Progressbar4.Visible = false;
            labelBar4.Visible = false;
        }
        if (Session["l1txt25"] != null)
        {
            Progressbar5.Visible = true;
            labelBar5.Visible = true;
            Progressbar5.Value = Convert.ToInt32(Session["l1txt25"].ToString());
            Label9.Text = Session["l1txt25"].ToString() + '%';
        }
        else
        {
            Progressbar5.Visible = false;
            labelBar5.Visible = false;
        }
        if (Session["l1txt26"] != null)
        {
            Progressbar6.Visible = true;
            labelBar6.Visible = true;
            Progressbar6.Value = Convert.ToInt32(Session["l1txt26"].ToString());
            Label10.Text = Session["l1txt26"].ToString() + '%';
        }
        else
        {
            Progressbar6.Visible = false;
            labelBar6.Visible = false;
        }
        if (Session["l1txt27"] != null)
        {
            Progressbar7.Visible = true;
            labelBar7.Visible = true;
            Progressbar7.Value = Convert.ToInt32(Session["l1txt27"].ToString());
            Label11.Text = Session["l1txt27"].ToString() + '%';
        }
        else
        {
            Progressbar7.Visible = false;
            labelBar7.Visible = false;
        }
        if (Session["l1txt28"] != null)
        {
            Progressbar8.Visible = true;
            labelBar8.Visible = true;
            Progressbar8.Value = Convert.ToInt32(Session["l1txt28"].ToString());
            Label12.Text = Session["l1txt28"].ToString() + '%';
        }
        else
        {
            Progressbar8.Visible = false;
            labelBar8.Visible = false;
        }
        if (Session["l1txt29"] != null)
        {
            Progressbar9.Visible = true;
            labelBar9.Visible = true;
            Progressbar9.Value = Convert.ToInt32(Session["l1txt29"].ToString());
            Label13.Text = Session["l1txt29"].ToString() + '%';
        }
        else
        {
            Progressbar9.Visible = false;
            labelBar9.Visible = false;
        }
        if (Session["l1txt30"] != null)
        {
            Progressbar10.Visible = true;
            labelBar10.Visible = true;
            Progressbar10.Value = Convert.ToInt32(Session["l1txt30"].ToString());
            Label14.Text = Session["l1txt30"].ToString() + '%';
        }
        else
        {
            Progressbar10.Visible = false;
            labelBar10.Visible = false;
        }

    }
    //protected void imgbtny1m4_Click(object sender, ImageClickEventArgs e)
    //{
    //    if (Session["l2txt31"] != null)
    //    {
    //        Progressbar1.Visible = true;
    //        Progressbar1.Value = Convert.ToInt32(Session["l2txt31"].ToString());
    //    }
    //    else
    //    {
    //        Progressbar1.Visible = false;
    //    }
    //    if (Session["l2txt32"] != null)
    //    {
    //        Progressbar2.Visible = true;
    //        Progressbar2.Value = Convert.ToInt32(Session["l2txt32"].ToString());
    //    }
    //    else
    //    {
    //        Progressbar2.Visible = false;
    //    }
    //    if (Session["l2txt33"] != null)
    //    {
    //        Progressbar3.Visible = true;
    //        Progressbar3.Value = Convert.ToInt32(Session["l2txt33"].ToString());
    //    }
    //    else
    //    {
    //        Progressbar3.Visible = false;
    //    }
    //    if (Session["l2txt34"] != null)
    //    {
    //        Progressbar4.Visible = true;
    //        Progressbar4.Value = Convert.ToInt32(Session["l2txt34"].ToString());
    //    }
    //    else
    //    {
    //        Progressbar4.Visible = false;
    //    }
    //    if (Session["l2txt35"] != null)
    //    {
    //        Progressbar5.Visible = true;
    //        Progressbar5.Value = Convert.ToInt32(Session["l2txt35"].ToString());
    //    }
    //    else
    //    {
    //        Progressbar5.Visible = false;
    //    }
    //    if (Session["l2txt36"] != null)
    //    {
    //        Progressbar6.Visible = true;
    //        Progressbar6.Value = Convert.ToInt32(Session["l2txt36"].ToString());
    //    }
    //    else
    //    {
    //        Progressbar6.Visible = false;
    //    }
    //    if (Session["l2txt37"] != null)
    //    {
    //        Progressbar7.Visible = true;
    //        Progressbar7.Value = Convert.ToInt32(Session["l2txt37"].ToString());
    //    }
    //    else
    //    {
    //        Progressbar7.Visible = false;
    //    }
    //    if (Session["l2txt38"] != null)
    //    {
    //        Progressbar8.Visible = true;
    //        Progressbar8.Value = Convert.ToInt32(Session["l2txt38"].ToString());
    //    }
    //    else
    //    {
    //        Progressbar8.Visible = false;
    //    }
    //    if (Session["l2txt39"] != null)
    //    {
    //        Progressbar9.Visible = true;
    //        Progressbar9.Value = Convert.ToInt32(Session["l2txt39"].ToString());
    //    }
    //    else
    //    {
    //        Progressbar9.Visible = false;
    //    }
    //    if (Session["l2txt40"] != null)
    //    {
    //        Progressbar10.Visible = true;
    //        Progressbar10.Value = Convert.ToInt32(Session["l2txt40"].ToString());
    //    }
    //    else
    //    {
    //        Progressbar10.Visible = false;
    //    }
    //}
    protected void imgbtny2m4_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["l2txt31"] != null)
        {
            Progressbar1.Visible = true;
            labelBar1.Visible = true;
            Progressbar1.Value = Convert.ToInt32(Session["l2txt31"].ToString());
            Label5.Text = Session["l2txt31"].ToString() + '%';
        }
        else
        {
            Progressbar1.Visible = false;
            labelBar1.Visible = false;
        }
        if (Session["l2txt32"] != null)
        {
            Progressbar2.Visible = true;
            labelBar2.Visible = true;
            Progressbar2.Value = Convert.ToInt32(Session["l2txt32"].ToString());
            Label6.Text = Session["l2txt32"].ToString() + '%';
        }
        else
        {
            Progressbar2.Visible = false;
            labelBar2.Visible = false;
        }
        if (Session["l2txt33"] != null)
        {
            Progressbar3.Visible = true;
            labelBar3.Visible = true;
            Progressbar3.Value = Convert.ToInt32(Session["l2txt33"].ToString());
            Label7.Text = Session["l2txt33"].ToString() + '%';
        }
        else
        {
            Progressbar3.Visible = false;
            labelBar3.Visible = false;
        }
        if (Session["l2txt34"] != null)
        {
            Progressbar4.Visible = true;
            labelBar4.Visible = true;
            Progressbar4.Value = Convert.ToInt32(Session["l2txt34"].ToString());
            Label8.Text = Session["l2txt34"].ToString() + '%';
        }
        else
        {
            Progressbar4.Visible = false;
            labelBar4.Visible = false;
        }
        if (Session["l2txt35"] != null)
        {
            Progressbar5.Visible = true;
            labelBar5.Visible = true;
            Progressbar5.Value = Convert.ToInt32(Session["l2txt35"].ToString());
            Label9.Text = Session["l2txt35"].ToString() + '%';
        }
        else
        {
            Progressbar5.Visible = false;
            labelBar5.Visible = false;
        }
        if (Session["l2txt36"] != null)
        {
            Progressbar6.Visible = true;
            labelBar6.Visible = true;
            Progressbar6.Value = Convert.ToInt32(Session["l2txt36"].ToString());
            Label10.Text = Session["l2txt36"].ToString() + '%';
        }
        else
        {
            Progressbar6.Visible = false;
            labelBar6.Visible = false;
        }
        if (Session["l2txt37"] != null)
        {
            Progressbar7.Visible = true;
            labelBar7.Visible = true;
            Progressbar7.Value = Convert.ToInt32(Session["l2txt37"].ToString());
            Label11.Text = Session["l2txt37"].ToString() + '%';
        }
        else
        {
            Progressbar7.Visible = false;
            labelBar7.Visible = false;
        }
        if (Session["l2txt38"] != null)
        {
            Progressbar8.Visible = true;
            labelBar8.Visible = true;
            Progressbar8.Value = Convert.ToInt32(Session["l2txt38"].ToString());
            Label12.Text = Session["l2txt38"].ToString() + '%';
        }
        else
        {
            Progressbar8.Visible = false;
            labelBar8.Visible = false;
        }
        if (Session["l2txt39"] != null)
        {
            Progressbar9.Visible = true;
            labelBar9.Visible = true;
            Progressbar9.Value = Convert.ToInt32(Session["l2txt39"].ToString());
            Label13.Text = Session["l2txt39"].ToString() + '%';
        }
        else
        {
            Progressbar9.Visible = false;
            labelBar9.Visible = false;
        }
        if (Session["l2txt40"] != null)
        {
            Progressbar10.Visible = true;
            labelBar10.Visible = true;
            Progressbar10.Value = Convert.ToInt32(Session["l2txt40"].ToString());
            Label14.Text = Session["l2txt40"].ToString() + '%';
        }
        else
        {
            Progressbar10.Visible = false;
            labelBar10.Visible = false;
        }
    }
    protected void imgbtny2m5_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["l2txt41"] != null)
        {
            Progressbar1.Visible = true;
            labelBar1.Visible = true;
            Progressbar1.Value = Convert.ToInt32(Session["l2txt41"].ToString());
            Label5.Text = Session["l2txt41"].ToString() + '%';
        }
        else
        {
            Progressbar1.Visible = false;
            labelBar1.Visible = false;
        }
        if (Session["l2txt42"] != null)
        {
            Progressbar2.Visible = true; 
            labelBar2.Visible = true;
            Progressbar2.Value = Convert.ToInt32(Session["l2txt42"].ToString());
            Label6.Text = Session["l2txt42"].ToString() + '%';
        }
        else
        {
            Progressbar2.Visible = false;
            labelBar2.Visible = false;
        }
        if (Session["l2txt43"] != null)
        {
            Progressbar3.Visible = true;
            labelBar3.Visible = true;
            Progressbar3.Value = Convert.ToInt32(Session["l2txt43"].ToString());
            Label7.Text = Session["l2txt43"].ToString() + '%';
        }
        else
        {
            Progressbar3.Visible = false;
            labelBar3.Visible = false;
        }
        if (Session["l2txt44"] != null)
        {
            Progressbar4.Visible = true;
            labelBar4.Visible = true;
            Progressbar4.Value = Convert.ToInt32(Session["l2txt44"].ToString());
            Label8.Text = Session["l2txt44"].ToString() + '%';
        }
        else
        {
            Progressbar4.Visible = false;
            labelBar4.Visible = false;
        }
        if (Session["l2txt45"] != null)
        {
            Progressbar5.Visible = true;
            labelBar5.Visible = true;
            Progressbar5.Value = Convert.ToInt32(Session["l2txt45"].ToString());
            Label9.Text = Session["l2txt45"].ToString() + '%';
        }
        else
        {
            Progressbar5.Visible = false;
            labelBar5.Visible = false;
        }
        if (Session["l2txt46"] != null)
        {
            Progressbar6.Visible = true;
            labelBar6.Visible = true;
            Progressbar6.Value = Convert.ToInt32(Session["l2txt46"].ToString());
            Label10.Text = Session["l2txt46"].ToString() + '%';
        }
        else
        {
            Progressbar6.Visible = false;
            labelBar6.Visible = false;
        }
        if (Session["l2txt47"] != null)
        {
            Progressbar7.Visible = true;
            labelBar7.Visible = true;
            Progressbar7.Value = Convert.ToInt32(Session["l2txt47"].ToString());
            Label11.Text = Session["l2txt47"].ToString() + '%';
        }
        else
        {
            Progressbar7.Visible = false;
            labelBar7.Visible = false;
        }
        if (Session["l2txt48"] != null)
        {
            Progressbar8.Visible = true;
            labelBar8.Visible = true;
            Progressbar8.Value = Convert.ToInt32(Session["l2txt48"].ToString());
            Label12.Text = Session["l2txt48"].ToString() + '%';
        }
        else
        {
            Progressbar8.Visible = false;
            labelBar8.Visible = false;
        }
        if (Session["l2txt49"] != null)
        {
            Progressbar9.Visible = true;
            labelBar9.Visible = true;
            Progressbar9.Value = Convert.ToInt32(Session["l2txt49"].ToString());
            Label13.Text = Session["l2txt49"].ToString() + '%';
        }
        else
        {
            Progressbar9.Visible = false;
            labelBar9.Visible = false;
        }
        if (Session["l2txt50"] != null)
        {
            Progressbar10.Visible = true;
            labelBar10.Visible = true;
            Progressbar10.Value = Convert.ToInt32(Session["l2txt50"].ToString());
            Label14.Text = Session["l2txt50"].ToString() + '%';
        }
        else
        {
            Progressbar10.Visible = false;
            labelBar10.Visible = false;
        }

    }
    protected void imgbtny2m6_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["l2txt51"] != null)
        {
            Progressbar1.Visible = true;
            labelBar1.Visible = true;
            Progressbar1.Value = Convert.ToInt32(Session["l2txt51"].ToString());
            Label5.Text = Session["l2txt51"].ToString() + '%';
        }
        else
        {
            Progressbar1.Visible = false;
            labelBar1.Visible = false;
        }
        if (Session["l2txt52"] != null)
        {
            Progressbar2.Visible = true;
            labelBar2.Visible = true;
            Progressbar2.Value = Convert.ToInt32(Session["l2txt52"].ToString());
            Label6.Text = Session["l2txt52"].ToString() + '%';
        }
        else
        {
            Progressbar2.Visible = false;
            labelBar2.Visible = false;
        }
        if (Session["l2txt53"] != null)
        {
            Progressbar3.Visible = true;
            labelBar3.Visible = true;
            Progressbar3.Value = Convert.ToInt32(Session["l2txt53"].ToString());
            Label7.Text = Session["l2txt53"].ToString() + '%';
        }
        else
        {
            Progressbar3.Visible = false;
            labelBar3.Visible = false;
        }
        if (Session["l2txt54"] != null)
        {
            Progressbar4.Visible = true;
            labelBar4.Visible = true;
            Progressbar4.Value = Convert.ToInt32(Session["l2txt54"].ToString());
            Label8.Text = Session["l2txt54"].ToString() + '%';
        }
        else
        {
            Progressbar4.Visible = false;
            labelBar4.Visible = false;
        }
        if (Session["l2txt55"] != null)
        {
            Progressbar5.Visible = true;
            labelBar5.Visible = true;
            Progressbar5.Value = Convert.ToInt32(Session["l2txt55"].ToString());
            Label9.Text = Session["l2txt55"].ToString() + '%';
        }
        else
        {
            Progressbar5.Visible = false;
            labelBar5.Visible = false;
        }
        if (Session["l2txt56"] != null)
        {
            Progressbar6.Visible = true;
            labelBar6.Visible = true;
            Progressbar6.Value = Convert.ToInt32(Session["l2txt56"].ToString());
            Label10.Text = Session["l2txt56"].ToString() + '%';
        }
        else
        {
            Progressbar6.Visible = false;
            labelBar6.Visible = false;
        }
        if (Session["l2txt57"] != null)
        {
            Progressbar7.Visible = true;
            labelBar7.Visible = true;
            Progressbar7.Value = Convert.ToInt32(Session["l2txt57"].ToString());
            Label11.Text = Session["l2txt57"].ToString() + '%';
        }
        else
        {
            Progressbar7.Visible = false;
            labelBar7.Visible = false;
        }
        if (Session["l2txt58"] != null)
        {
            Progressbar8.Visible = true;
            labelBar8.Visible = true;
            Progressbar8.Value = Convert.ToInt32(Session["l2txt58"].ToString());
            Label12.Text = Session["l2txt58"].ToString() + '%';
        }
        else
        {
            Progressbar8.Visible = false;
            labelBar8.Visible = false;
        }
        if (Session["l2txt59"] != null)
        {
            Progressbar9.Visible = true;
            labelBar9.Visible = true;
            Progressbar9.Value = Convert.ToInt32(Session["l2txt59"].ToString());
            Label13.Text = Session["l2txt59"].ToString() + '%';
        }
        else
        {
            Progressbar9.Visible = false;
            labelBar9.Visible = false;
        }
        if (Session["l2txt60"] != null)
        {
            Progressbar10.Visible = true;
            labelBar10.Visible = true;
            Progressbar10.Value = Convert.ToInt32(Session["l2txt60"].ToString());
            Label14.Text = Session["l2txt60"].ToString() + '%';
        }
        else
        {
            Progressbar10.Visible = false;
            labelBar10.Visible = false;
        }
    }
    protected void imgbtny2m7_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["l2txt61"] != null)
        {
            Progressbar1.Visible = true;
            labelBar1.Visible = true;
            Progressbar1.Value = Convert.ToInt32(Session["l2txt61"].ToString());
            Label5.Text = Session["l2txt61"].ToString() + '%';
        }
        else
        {
            Progressbar1.Visible = false;
            labelBar1.Visible = false;
        }
        if (Session["l2txt62"] != null)
        {
            Progressbar2.Visible = true;
            labelBar2.Visible = true;
            Progressbar2.Value = Convert.ToInt32(Session["l2txt62"].ToString());
            Label6.Text = Session["l2txt62"].ToString() + '%';
        }
        else
        {
            Progressbar2.Visible = false;
            labelBar2.Visible = false;
        }
        if (Session["l2txt63"] != null)
        {
            Progressbar3.Visible = true;
            labelBar3.Visible = true;
            Progressbar3.Value = Convert.ToInt32(Session["l2txt63"].ToString());
            Label7.Text = Session["l2txt63"].ToString() + '%';
        }
        else
        {
            Progressbar3.Visible = false;
            labelBar3.Visible = false;
        }
        if (Session["l2txt64"] != null)
        {
            Progressbar4.Visible = true;
            labelBar4.Visible = true;
            Progressbar4.Value = Convert.ToInt32(Session["l2txt64"].ToString());
            Label8.Text = Session["l2txt64"].ToString() + '%';
        }
        else
        {
            Progressbar4.Visible = false;
            labelBar4.Visible = false;
        }
        if (Session["l2txt65"] != null)
        {
            Progressbar5.Visible = true;
            labelBar5.Visible = true;
            Progressbar5.Value = Convert.ToInt32(Session["l2txt65"].ToString());
            Label9.Text = Session["l2txt65"].ToString() + '%';
        }
        else
        {
            Progressbar5.Visible = false;
            labelBar5.Visible = false;
        }
        if (Session["l2txt66"] != null)
        {
            Progressbar6.Visible = true;
            labelBar6.Visible = true;
            Progressbar6.Value = Convert.ToInt32(Session["l2txt66"].ToString());
            Label10.Text = Session["l2txt66"].ToString() + '%';
        }
        else
        {
            Progressbar6.Visible = false;
            labelBar6.Visible = false;
        }
        if (Session["l2txt67"] != null)
        {
            Progressbar7.Visible = true;
            labelBar7.Visible = true;
            Progressbar7.Value = Convert.ToInt32(Session["l2txt67"].ToString());
            Label11.Text = Session["l2txt67"].ToString() + '%';
        }
        else
        {
            Progressbar7.Visible = false;
            labelBar7.Visible = false;
        }
        if (Session["l2txt68"] != null)
        {
            Progressbar8.Visible = true;
            labelBar8.Visible = true;
            Progressbar8.Value = Convert.ToInt32(Session["l2txt68"].ToString());
            Label12.Text = Session["l2txt68"].ToString() + '%';
        }
        else
        {
            Progressbar8.Visible = false;
            labelBar8.Visible = false;
        }
        if (Session["l2txt69"] != null)
        {
            Progressbar9.Visible = true;
            labelBar9.Visible = true;
            Progressbar9.Value = Convert.ToInt32(Session["l2txt69"].ToString());
            Label13.Text = Session["l2txt69"].ToString() + '%';
        }
        else
        {
            Progressbar9.Visible = false;
            labelBar9.Visible = false;
        }
        if (Session["l2txt70"] != null)
        {
            Progressbar10.Visible = true;
            labelBar10.Visible = true;
            Progressbar10.Value = Convert.ToInt32(Session["l2txt70"].ToString());
            Label14.Text = Session["l2txt70"].ToString() + '%';
        }
        else
        {
            Progressbar10.Visible = false;
            labelBar10.Visible = false;
        }
    }
    protected void imgbtny2m8_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["l2txt71"] != null)
        {
            Progressbar1.Visible = true;
            labelBar1.Visible = true;
            Progressbar1.Value = Convert.ToInt32(Session["l2txt71"].ToString());
            Label5.Text = Session["l2txt71"].ToString() + '%';
        }
        else
        {
            Progressbar1.Visible = false;
            labelBar1.Visible = false;
        }
        if (Session["l2txt72"] != null)
        {
            Progressbar2.Visible = true;
            labelBar2.Visible = true;
            Progressbar2.Value = Convert.ToInt32(Session["l2txt72"].ToString());
            Label6.Text = Session["l2txt72"].ToString() + '%';
        }
        else
        {
            Progressbar2.Visible = false;
            labelBar2.Visible = false;
        }
        if (Session["l2txt73"] != null)
        {
            Progressbar3.Visible = true;
            labelBar3.Visible = true;
            Progressbar3.Value = Convert.ToInt32(Session["l2txt73"].ToString());
            Label7.Text = Session["l2txt73"].ToString() + '%';
        }
        else
        {
            Progressbar3.Visible = false;
            labelBar3.Visible = false;
        }
        if (Session["l2txt74"] != null)
        {
            Progressbar4.Visible = true;
            labelBar4.Visible = true;
            Progressbar4.Value = Convert.ToInt32(Session["l2txt74"].ToString());
            Label8.Text = Session["l2txt74"].ToString() + '%';
        }
        else
        {
            Progressbar4.Visible = false;
            labelBar4.Visible = false;
        }
        if (Session["l2txt75"] != null)
        {
            Progressbar5.Visible = true;
            labelBar5.Visible = true;
            Progressbar5.Value = Convert.ToInt32(Session["l2txt75"].ToString());
            Label9.Text = Session["l2txt75"].ToString() + '%';
        }
        else
        {
            Progressbar5.Visible = false;
            labelBar5.Visible = false;
        }
        if (Session["l2txt76"] != null)
        {
            Progressbar6.Visible = true;
            labelBar6.Visible = true;
            Progressbar6.Value = Convert.ToInt32(Session["l2txt76"].ToString());
            Label10.Text = Session["l2txt76"].ToString() + '%';
        }
        else
        {
            Progressbar6.Visible = false;
            labelBar6.Visible = false;
        }
        if (Session["l2txt77"] != null)
        {
            Progressbar7.Visible = true;
            labelBar7.Visible = true;
            Progressbar7.Value = Convert.ToInt32(Session["l2txt77"].ToString());
            Label11.Text = Session["l2txt77"].ToString() + '%';
        }
        else
        {
            Progressbar7.Visible = false;
            labelBar7.Visible = false;
        }
        if (Session["l2txt78"] != null)
        {
            Progressbar8.Visible = true;
            labelBar8.Visible = true;
            Progressbar8.Value = Convert.ToInt32(Session["l2txt78"].ToString());
            Label12.Text = Session["l2txt78"].ToString() + '%';
        }
        else
        {
            Progressbar8.Visible = false;
            labelBar8.Visible = false;
        }
        if (Session["l2txt79"] != null)
        {
            Progressbar9.Visible = true;
            labelBar9.Visible = true;
            Progressbar9.Value = Convert.ToInt32(Session["l2txt79"].ToString());
            Label13.Text = Session["l2txt79"].ToString() + '%';
        }
        else
        {
            Progressbar9.Visible = false;
            labelBar9.Visible = false;
        }
        if (Session["l2txt80"] != null)
        {
            Progressbar10.Visible = true;
            labelBar10.Visible = true;
            Progressbar10.Value = Convert.ToInt32(Session["l2txt80"].ToString());
            Label14.Text = Session["l2txt80"].ToString() + '%';
        }
        else
        {
            Progressbar10.Visible = false;
            labelBar10.Visible = false;
        }
    }
    protected void imgbtny3m1_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["l3txt1"] != null)
        {
            Progressbar1.Visible = true;
            labelBar1.Visible = true;
            Progressbar1.Value = Convert.ToInt32(Session["l3txt1"].ToString());
            Label5.Text = Session["l3txt1"].ToString() + '%';
        }
        else
        {
            Progressbar1.Visible = false;
            labelBar1.Visible = false;
        }
        if (Session["l3txt2"] != null)
        {
            Progressbar2.Visible = true;
            labelBar2.Visible = true;
            Progressbar2.Value = Convert.ToInt32(Session["l3txt2"].ToString());
            Label6.Text = Session["l3txt2"].ToString() + '%';
        }
        else
        {
            Progressbar2.Visible = false;
            labelBar2.Visible = false;
        }
        if (Session["l3txt3"] != null)
        {
            Progressbar3.Visible = true;
            labelBar3.Visible = true;
            Progressbar3.Value = Convert.ToInt32(Session["l3txt3"].ToString());
            Label7.Text = Session["l3txt3"].ToString() + '%';
        }
        else
        {
            Progressbar3.Visible = false;
            labelBar3.Visible = false;
        }
        if (Session["l3txt4"] != null)
        {
            Progressbar4.Visible = true;
            labelBar4.Visible = true;
            Progressbar4.Value = Convert.ToInt32(Session["l3txt4"].ToString());
            Label8.Text = Session["l3txt4"].ToString() + '%';
        }
        else
        {
            Progressbar4.Visible = false;
            labelBar4.Visible = false;
        }
        if (Session["l3txt5"] != null)
        {
            Progressbar5.Visible = true;
            labelBar5.Visible = true;
            Progressbar5.Value = Convert.ToInt32(Session["l3txt5"].ToString());
            Label9.Text = Session["l3txt5"].ToString() + '%';
        }
        else
        {
            Progressbar5.Visible = false;
            labelBar5.Visible = false;
        }
        if (Session["l3txt6"] != null)
        {
            Progressbar6.Visible = true;
            labelBar6.Visible = true;
            Progressbar6.Value = Convert.ToInt32(Session["l3txt6"].ToString());
            Label10.Text = Session["l3txt6"].ToString() + '%';
        }
        else
        {
            Progressbar6.Visible = false;
            labelBar6.Visible = false;
        }
        if (Session["l3txt7"] != null)
        {
            Progressbar7.Visible = true;
            labelBar7.Visible = true;
            Progressbar7.Value = Convert.ToInt32(Session["l3txt7"].ToString());
            Label11.Text = Session["l3txt7"].ToString() + '%';
        }
        else
        {
            Progressbar7.Visible = false;
            labelBar7.Visible = false;
        }
        if (Session["l3txt8"] != null)
        {
            Progressbar8.Visible = true;
            labelBar8.Visible = true;
            Progressbar8.Value = Convert.ToInt32(Session["l3txt8"].ToString());
            Label12.Text = Session["l3txt8"].ToString() + '%';
        }
        else
        {
            labelBar8.Visible = false;
            Progressbar8.Visible = false;
        }
        if (Session["l3txt9"] != null)
        {
            Progressbar9.Visible = true;
            labelBar9.Visible = true;
            Progressbar9.Value = Convert.ToInt32(Session["l3txt9"].ToString());
            Label13.Text = Session["l3txt9"].ToString() + '%';
        }
        else
        {
            Progressbar9.Visible = false;
            labelBar9.Visible = false;
        }
        if (Session["l3txt10"] != null)
        {
            Progressbar10.Visible = true;
            labelBar10.Visible = true;
            Progressbar10.Value = Convert.ToInt32(Session["l3txt10"].ToString());
            Label14.Text = Session["l3txt10"].ToString() + '%';
        }
        else
        {
            Progressbar10.Visible = false;
            labelBar10.Visible = false;
        }
    }
    protected void imgbtny3m2_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["l3txt11"] != null)
        {
            Progressbar1.Visible = true;
            labelBar1.Visible = true;
            Progressbar1.Value = Convert.ToInt32(Session["l3txt11"].ToString());
            Label5.Text = Session["l3txt11"].ToString() + '%';
        }
        else
        {
            Progressbar1.Visible = false;
            labelBar1.Visible = false;
        }
        if (Session["l3txt12"] != null)
        {
            Progressbar2.Visible = true;
            labelBar2.Visible = true;
            Progressbar2.Value = Convert.ToInt32(Session["l3txt12"].ToString());
            Label6.Text = Session["l3txt12"].ToString() + '%';
        }
        else
        {
            Progressbar2.Visible = false;
            labelBar2.Visible = false;
        }
        if (Session["l3txt13"] != null)
        {
            Progressbar3.Visible = true;
            labelBar3.Visible = true;
            Progressbar3.Value = Convert.ToInt32(Session["l3txt13"].ToString());
            Label7.Text = Session["l3txt13"].ToString() + '%';
        }
        else
        {
            Progressbar3.Visible = false;
            labelBar3.Visible = false;
        }
        if (Session["l3txt14"] != null)
        {
            Progressbar4.Visible = true;
            labelBar4.Visible = true;
            Progressbar4.Value = Convert.ToInt32(Session["l3txt14"].ToString());
            Label8.Text = Session["l3txt14"].ToString() + '%';
        }
        else
        {
            Progressbar4.Visible = false;
            labelBar4.Visible = false;
        }
        if (Session["l3txt15"] != null)
        {
            Progressbar5.Visible = true;
            labelBar5.Visible = true;
            Progressbar5.Value = Convert.ToInt32(Session["l3txt15"].ToString());
            Label9.Text = Session["l3txt15"].ToString() + '%';
        }
        else
        {
            Progressbar5.Visible = false;
            labelBar5.Visible = false;
        }
        if (Session["l3txt16"] != null)
        {
            Progressbar6.Visible = true;
            labelBar6.Visible = true;
            Progressbar6.Value = Convert.ToInt32(Session["l3txt16"].ToString());
            Label10.Text = Session["l3txt16"].ToString() + '%';
        }
        else
        {
            Progressbar6.Visible = false;
            labelBar6.Visible = false;
        }
        if (Session["l3txt17"] != null)
        {
            Progressbar7.Visible = true;
            labelBar7.Visible = true;
            Progressbar7.Value = Convert.ToInt32(Session["l3txt17"].ToString());
            Label11.Text = Session["l3txt17"].ToString() + '%';
        }
        else
        {
            Progressbar7.Visible = false;
            labelBar7.Visible = false;
        }
        if (Session["l3txt18"] != null)
        {
            Progressbar8.Visible = true;
            labelBar8.Visible = true;
            Progressbar8.Value = Convert.ToInt32(Session["l3txt18"].ToString());
            Label12.Text = Session["l3txt18"].ToString() + '%';
        }
        else
        {
            Progressbar8.Visible = false;
            labelBar8.Visible = false;
        }
        if (Session["l3txt19"] != null)
        {
            Progressbar9.Visible = true;
            labelBar9.Visible = true;
            Progressbar9.Value = Convert.ToInt32(Session["l3txt19"].ToString());
            Label13.Text = Session["l3txt19"].ToString() + '%';
        }
        else
        {
            Progressbar9.Visible = false;
            labelBar9.Visible = false;
        }
        if (Session["l3txt20"] != null)
        {
            Progressbar10.Visible = true;
            labelBar10.Visible = true;
            Progressbar10.Value = Convert.ToInt32(Session["l3txt20"].ToString());
            Label14.Text = Session["l3txt20"].ToString() + '%';
        }
        else
        {
            Progressbar10.Visible = false;
            labelBar10.Visible = false;
        }
    }
    protected void imgbtny3m3_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["l3txt21"] != null)
        {
            Progressbar1.Visible = true;
            labelBar1.Visible = true;
            Progressbar1.Value = Convert.ToInt32(Session["l3txt21"].ToString());
            Label5.Text = Session["l3txt21"].ToString() + '%';
        }
        else
        {
            Progressbar1.Visible = false;
            labelBar1.Visible = false;
        }
        if (Session["l3txt22"] != null)
        {
            Progressbar2.Visible = true;
            labelBar2.Visible = true;
            Progressbar2.Value = Convert.ToInt32(Session["l3txt22"].ToString());
            Label6.Text = Session["l3txt22"].ToString() + '%';
        }
        else
        {
            Progressbar2.Visible = false;
            labelBar2.Visible = false;
        }
        if (Session["l3txt23"] != null)
        {
            Progressbar3.Visible = true;
            labelBar3.Visible = true;
            Progressbar3.Value = Convert.ToInt32(Session["l3txt23"].ToString());
            Label7.Text = Session["l3txt23"].ToString() + '%';
        }
        else
        {
            Progressbar3.Visible = false;
            labelBar3.Visible = false;
        }
        if (Session["l3txt24"] != null)
        {
            Progressbar4.Visible = true;
            labelBar4.Visible = true;
            Progressbar4.Value = Convert.ToInt32(Session["l3txt24"].ToString());
            Label8.Text = Session["l3txt24"].ToString() + '%';
        }
        else
        {
            Progressbar4.Visible = false;
            labelBar4.Visible = false;
        }
        if (Session["l3txt25"] != null)
        {
            Progressbar5.Visible = true;
            labelBar5.Visible = true;
            Progressbar5.Value = Convert.ToInt32(Session["l3txt25"].ToString());
            Label9.Text = Session["l3txt25"].ToString() + '%';
        }
        else
        {
            Progressbar5.Visible = false;
            labelBar5.Visible = false;
        }
        if (Session["l3txt26"] != null)
        {
            Progressbar6.Visible = true;
            labelBar6.Visible = true;
            Progressbar6.Value = Convert.ToInt32(Session["l3txt26"].ToString());
            Label10.Text = Session["l3txt26"].ToString() + '%';
        }
        else
        {
            Progressbar6.Visible = false;
            labelBar6.Visible = false;
        }
        if (Session["l3txt27"] != null)
        {
            Progressbar7.Visible = true;
            labelBar7.Visible = true;
            Progressbar7.Value = Convert.ToInt32(Session["l3txt27"].ToString());
            Label11.Text = Session["l3txt27"].ToString() + '%';
        }
        else
        {
            Progressbar7.Visible = false;
            labelBar7.Visible = false;
        }
        if (Session["l3txt28"] != null)
        {
            Progressbar8.Visible = true;
            labelBar8.Visible = true;
            Progressbar8.Value = Convert.ToInt32(Session["l3txt28"].ToString());
            Label12.Text = Session["l3txt28"].ToString() + '%';
        }
        else
        {
            Progressbar8.Visible = false;
            labelBar8.Visible = false;
        }
        if (Session["l3txt29"] != null)
        {
            Progressbar9.Visible = true;
            labelBar9.Visible = true;
            Progressbar9.Value = Convert.ToInt32(Session["l3txt29"].ToString());
            Label13.Text = Session["l3txt29"].ToString() + '%';
        }
        else
        {
            Progressbar9.Visible = false;
            labelBar9.Visible = false;
        }
        if (Session["l3txt30"] != null)
        {
            Progressbar10.Visible = true;
            labelBar10.Visible = true;
            Progressbar10.Value = Convert.ToInt32(Session["l3txt30"].ToString());
            Label14.Text = Session["l3txt30"].ToString() + '%';
        }
        else
        {
            Progressbar10.Visible = false;
            labelBar10.Visible = false;
        }
    }
    protected void imgbtny3m4_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["l3txt31"] != null)
        {
            Progressbar1.Visible = true;
            labelBar1.Visible = true;
            Progressbar1.Value = Convert.ToInt32(Session["l3txt31"].ToString());
            Label5.Text = Session["l3txt31"].ToString() + '%';
        }
        else
        {
            Progressbar1.Visible = false;
            labelBar1.Visible = false;
        }
        if (Session["l3txt32"] != null)
        {
            Progressbar2.Visible = true;
            labelBar2.Visible = true;
            Progressbar2.Value = Convert.ToInt32(Session["l3txt32"].ToString());
            Label6.Text = Session["l3txt32"].ToString() + '%';
        }
        else
        {
            Progressbar2.Visible = false;
            labelBar2.Visible = false;
        }
        if (Session["l3txt33"] != null)
        {
            Progressbar3.Visible = true;
            labelBar3.Visible = true;
            Progressbar3.Value = Convert.ToInt32(Session["l3txt33"].ToString());
            Label7.Text = Session["l3txt33"].ToString() + '%';
        }
        else
        {
            Progressbar3.Visible = false;
            labelBar3.Visible = false;
        }
        if (Session["l3txt34"] != null)
        {
            Progressbar4.Visible = true;
            labelBar4.Visible = true;
            Progressbar4.Value = Convert.ToInt32(Session["l3txt34"].ToString());
            Label8.Text = Session["l3txt34"].ToString() + '%';
        }
        else
        {
            Progressbar4.Visible = false;
            labelBar4.Visible = false;
        }
        if (Session["l3txt35"] != null)
        {
            Progressbar5.Visible = true;
            labelBar5.Visible = true;
            Progressbar5.Value = Convert.ToInt32(Session["l3txt35"].ToString());
            Label9.Text = Session["l3txt35"].ToString() + '%';
        }
        else
        {
            Progressbar5.Visible = false;
            labelBar5.Visible = false;
        }
        if (Session["l3txt36"] != null)
        {
            Progressbar6.Visible = true;
            labelBar6.Visible = true;
            Progressbar6.Value = Convert.ToInt32(Session["l3txt36"].ToString());
            Label10.Text = Session["l3txt36"].ToString() + '%';
        }
        else
        {
            Progressbar6.Visible = false;
            labelBar6.Visible = false;
        }
        if (Session["l3txt37"] != null)
        {
            Progressbar7.Visible = true;
            labelBar7.Visible = true;
            Progressbar7.Value = Convert.ToInt32(Session["l3txt37"].ToString());
            Label11.Text = Session["l3txt37"].ToString() + '%';
        }
        else
        {
            Progressbar7.Visible = false;
            labelBar7.Visible = false;
        }
        if (Session["l3txt38"] != null)
        {
            Progressbar8.Visible = true;
            labelBar8.Visible = true;
            Progressbar8.Value = Convert.ToInt32(Session["l3txt38"].ToString());
            Label12.Text = Session["l3txt38"].ToString() + '%';
        }
        else
        {
            Progressbar8.Visible = false;
            labelBar8.Visible = false;
        }
        if (Session["l3txt39"] != null)
        {
            Progressbar9.Visible = true;
            labelBar9.Visible = true;
            Progressbar9.Value = Convert.ToInt32(Session["l3txt39"].ToString());
            Label13.Text = Session["l3txt39"].ToString() + '%';
        }
        else
        {
            Progressbar9.Visible = false;
            labelBar9.Visible = false;
        }
        if (Session["l3txt40"] != null)
        {
            Progressbar10.Visible = true;
            labelBar10.Visible = true;
            Progressbar10.Value = Convert.ToInt32(Session["l3txt40"].ToString());
            Label14.Text = Session["l3txt40"].ToString() + '%';
        }
        else
        {
            Progressbar10.Visible = false;
            labelBar10.Visible = false;
        }
    }
    protected void imgbtny3m5_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["l3txt41"] != null)
        {
            Progressbar1.Visible = true;
            labelBar1.Visible = true;
            Progressbar1.Value = Convert.ToInt32(Session["l3txt41"].ToString());
            Label5.Text = Session["l3txt41"].ToString() + '%';
        }
        else
        {
            Progressbar1.Visible = false;
            labelBar1.Visible = false;
        }
        if (Session["l3txt42"] != null)
        {
            Progressbar2.Visible = true;
            labelBar2.Visible = true;
            Progressbar2.Value = Convert.ToInt32(Session["l3txt42"].ToString());
            Label6.Text = Session["l3txt42"].ToString() + '%';
        }
        else
        {
            Progressbar2.Visible = false;
            labelBar2.Visible = false;
        }
        if (Session["l3txt43"] != null)
        {
            Progressbar3.Visible = true;
            labelBar3.Visible = true;
            Progressbar3.Value = Convert.ToInt32(Session["l3txt43"].ToString());
            Label7.Text = Session["l3txt43"].ToString() + '%';
        }
        else
        {
            Progressbar3.Visible = false;
            labelBar3.Visible = false;
        }
        if (Session["l3txt44"] != null)
        {
            Progressbar4.Visible = true;
            labelBar4.Visible = true;
            Progressbar4.Value = Convert.ToInt32(Session["l3txt44"].ToString());
            Label8.Text = Session["l3txt44"].ToString() + '%';
        }
        else
        {
            Progressbar4.Visible = false;
            labelBar4.Visible = false;
        }
        if (Session["l3txt45"] != null)
        {
            Progressbar5.Visible = true;
            labelBar5.Visible = true;
            Progressbar5.Value = Convert.ToInt32(Session["l3txt45"].ToString());
            Label9.Text = Session["l3txt45"].ToString() + '%';
        }
        else
        {
            Progressbar5.Visible = false;
            labelBar5.Visible = false;
        }
        if (Session["l3txt46"] != null)
        {
            Progressbar6.Visible = true;
            labelBar6.Visible = true;
            Progressbar6.Value = Convert.ToInt32(Session["l3txt46"].ToString());
            Label10.Text = Session["l3txt46"].ToString() + '%';
        }
        else
        {
            Progressbar6.Visible = false;
            labelBar6.Visible = false;
        }
        if (Session["l3txt47"] != null)
        {
            Progressbar7.Visible = true;
            labelBar7.Visible = true;
            Progressbar7.Value = Convert.ToInt32(Session["l3txt47"].ToString());
            Label11.Text = Session["l3txt47"].ToString() + '%';
        }
        else
        {
            Progressbar7.Visible = false;
            labelBar7.Visible = false;
        }
        if (Session["l3txt48"] != null)
        {
            Progressbar8.Visible = true;
            labelBar8.Visible = true;
            Progressbar8.Value = Convert.ToInt32(Session["l3txt48"].ToString());
            Label12.Text = Session["l3txt48"].ToString() + '%';
        }
        else
        {
            Progressbar8.Visible = false;
            labelBar8.Visible = false;
        }
        if (Session["l3txt49"] != null)
        {
            Progressbar9.Visible = true;
            labelBar9.Visible = true;
            Progressbar9.Value = Convert.ToInt32(Session["l3txt49"].ToString());
            Label13.Text = Session["l3txt49"].ToString() + '%';
        }
        else
        {
            Progressbar9.Visible = false;
            labelBar9.Visible = false;
        }
        if (Session["l3txt50"] != null)
        {
            Progressbar10.Visible = true;
            labelBar10.Visible = true;
            Progressbar10.Value = Convert.ToInt32(Session["l3txt50"].ToString());
            Label14.Text = Session["l3txt50"].ToString() + '%';
        }
        else
        {
            Progressbar10.Visible = false;
            labelBar10.Visible = false;
        }

    }
    protected void imgbtny3m6_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["l3txt51"] != null)
        {
            Progressbar1.Visible = true;
            labelBar1.Visible = true;
            Progressbar1.Value = Convert.ToInt32(Session["l3txt51"].ToString());
            Label5.Text = Session["l3txt51"].ToString() + '%';
        }
        else
        {
            Progressbar1.Visible = false;
            labelBar1.Visible = false;
        }
        if (Session["l3txt52"] != null)
        {
            Progressbar2.Visible = true;
            labelBar2.Visible = true;
            Progressbar2.Value = Convert.ToInt32(Session["l3txt52"].ToString());
            Label6.Text = Session["l3txt52"].ToString() + '%';
        }
        else
        {
            Progressbar2.Visible = false;
            labelBar2.Visible = false;
        }
        if (Session["l3txt53"] != null)
        {
            Progressbar3.Visible = true;
            labelBar3.Visible = true;
            Progressbar3.Value = Convert.ToInt32(Session["l3txt53"].ToString());
            Label7.Text = Session["l3txt53"].ToString() + '%';
        }
        else
        {
            Progressbar3.Visible = false;
            labelBar3.Visible = false;
        }
        if (Session["l3txt54"] != null)
        {
            Progressbar4.Visible = true;
            labelBar4.Visible = true;
            Progressbar4.Value = Convert.ToInt32(Session["l3txt54"].ToString());
            Label8.Text = Session["l3txt54"].ToString() + '%';
        }
        else
        {
            Progressbar4.Visible = false;
            labelBar4.Visible = false;
        }
        if (Session["l3txt55"] != null)
        {
            Progressbar5.Visible = true;
            labelBar5.Visible = true;
            Progressbar5.Value = Convert.ToInt32(Session["l3txt55"].ToString());
            Label9.Text = Session["l3txt55"].ToString() + '%';
        }
        else
        {
            Progressbar5.Visible = false;
            labelBar5.Visible = false;
        }
        if (Session["l3txt56"] != null)
        {
            Progressbar6.Visible = true;
            labelBar6.Visible = true;
            Progressbar6.Value = Convert.ToInt32(Session["l3txt56"].ToString());
            Label10.Text = Session["l3txt56"].ToString() + '%';
        }
        else
        {
            Progressbar6.Visible = false;
            labelBar6.Visible = false;
        }
        if (Session["l3txt57"] != null)
        {
            Progressbar7.Visible = true;
            labelBar7.Visible = true;
            Progressbar7.Value = Convert.ToInt32(Session["l3txt57"].ToString());
            Label11.Text = Session["l3txt57"].ToString() + '%';
        }
        else
        {
            Progressbar7.Visible = false;
            labelBar7.Visible = false;
        }
        if (Session["l3txt58"] != null)
        {
            Progressbar8.Visible = true;
            labelBar8.Visible = true;
            Progressbar8.Value = Convert.ToInt32(Session["l3txt58"].ToString());
            Label12.Text = Session["l3txt58"].ToString() + '%';
        }
        else
        {
            Progressbar8.Visible = false;
            labelBar8.Visible = false;
        }
        if (Session["l3txt59"] != null)
        {
            Progressbar9.Visible = true;
            labelBar9.Visible = true;
            Progressbar9.Value = Convert.ToInt32(Session["l3txt59"].ToString());
            Label13.Text = Session["l3txt59"].ToString() + '%';
        }
        else
        {
            Progressbar9.Visible = false;
            labelBar9.Visible = false;
        }
        if (Session["l3txt60"] != null)
        {
            Progressbar10.Visible = true;
            labelBar10.Visible = true;
            Progressbar10.Value = Convert.ToInt32(Session["l3txt60"].ToString());
            Label14.Text = Session["l3txt60"].ToString() + '%';
        }
        else
        {
            Progressbar10.Visible = false;
            labelBar10.Visible = false;
        }
    }
    protected void imgbtny3m7_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["l3txt61"] != null)
        {
            Progressbar1.Visible = true;
            labelBar1.Visible = true;
            Progressbar1.Value = Convert.ToInt32(Session["l3txt61"].ToString());
            Label5.Text = Session["l3txt61"].ToString() + '%';
        }
        else
        {
            Progressbar1.Visible = false;
            labelBar1.Visible = false;
        }
        if (Session["l3txt62"] != null)
        {
            Progressbar2.Visible = true;
            labelBar2.Visible = true;
            Progressbar2.Value = Convert.ToInt32(Session["l3txt62"].ToString());
            Label6.Text = Session["l3txt62"].ToString() + '%';
        }
        else
        {
            Progressbar2.Visible = false;
            labelBar2.Visible = false;
        }
        if (Session["l3txt63"] != null)
        {
            Progressbar3.Visible = true;
            labelBar3.Visible = true;
            Progressbar3.Value = Convert.ToInt32(Session["l3txt63"].ToString());
            Label7.Text = Session["l3txt63"].ToString() + '%';
        }
        else
        {
            Progressbar3.Visible = false;
            labelBar3.Visible = false;
        }
        if (Session["l3txt64"] != null)
        {
            Progressbar4.Visible = true;
            labelBar4.Visible = true;
            Progressbar4.Value = Convert.ToInt32(Session["l3txt64"].ToString());
            Label8.Text = Session["l3txt64"].ToString() + '%';
        }
        else
        {
            Progressbar4.Visible = false;
            labelBar4.Visible = false;
        }
        if (Session["l3txt65"] != null)
        {
            Progressbar5.Visible = true;
            labelBar5.Visible = true;
            Progressbar5.Value = Convert.ToInt32(Session["l3txt65"].ToString());
            Label9.Text = Session["l3txt65"].ToString() + '%';
        }
        else
        {
            Progressbar5.Visible = false;
            labelBar5.Visible = false;
        }
        if (Session["l3txt66"] != null)
        {
            Progressbar6.Visible = true;
            labelBar6.Visible = true;
            Progressbar6.Value = Convert.ToInt32(Session["l3txt66"].ToString());
            Label10.Text = Session["l3txt67"].ToString() + '%';
        }
        else
        {
            Progressbar6.Visible = false;
            labelBar6.Visible = false;
        }
        if (Session["l3txt67"] != null)
        {
            Progressbar7.Visible = true;
            labelBar7.Visible = true;
            Progressbar7.Value = Convert.ToInt32(Session["l3txt67"].ToString());
            Label11.Text = Session["l3txt67"].ToString() + '%';
        }
        else
        {
            Progressbar7.Visible = false;
            labelBar7.Visible = false;
        }
        if (Session["l3txt68"] != null)
        {
            Progressbar8.Visible = true;
            labelBar8.Visible = true;
            Progressbar8.Value = Convert.ToInt32(Session["l3txt68"].ToString());
            Label12.Text = Session["l3txt68"].ToString() + '%';
        }
        else
        {
            Progressbar8.Visible = false;
            labelBar8.Visible = false;
        }
        if (Session["l3txt69"] != null)
        {
            Progressbar9.Visible = true;
            labelBar9.Visible = true;
            Progressbar9.Value = Convert.ToInt32(Session["l3txt69"].ToString());
            Label13.Text = Session["l3txt69"].ToString() + '%';
        }
        else
        {
            Progressbar9.Visible = false;
            labelBar9.Visible = false;
        }
        if (Session["l3txt70"] != null)
        {
            Progressbar10.Visible = true;
            labelBar10.Visible = true;
            Progressbar10.Value = Convert.ToInt32(Session["l3txt70"].ToString());
            Label14.Text = Session["l3txt70"].ToString() + '%';
        }
        else
        {
            Progressbar10.Visible = false;
            labelBar10.Visible = false;
        }

    }
    protected void imgbtny3m8_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["l3txt71"] != null)
        {
            Progressbar1.Visible = true;
            labelBar1.Visible = true;
            Progressbar1.Value = Convert.ToInt32(Session["l3txt71"].ToString());
            Label5.Text = Session["l3txt71"].ToString() + '%';
        }
        else
        {
            Progressbar1.Visible = false;
            labelBar1.Visible = false;
        }
        if (Session["l3txt72"] != null)
        {
            Progressbar2.Visible = true;
            labelBar2.Visible = true;
            Progressbar2.Value = Convert.ToInt32(Session["l3txt72"].ToString());
            Label6.Text = Session["l3txt72"].ToString() + '%';
        }
        else
        {
            Progressbar2.Visible = false;
            labelBar2.Visible = false;
        }
        if (Session["l3txt73"] != null)
        {
            Progressbar3.Visible = true;
            labelBar3.Visible = true;
            Progressbar3.Value = Convert.ToInt32(Session["l3txt73"].ToString());
            Label7.Text = Session["l3txt73"].ToString() + '%';
        }
        else
        {
            Progressbar3.Visible = false;
            labelBar3.Visible = false;
        }
        if (Session["l3txt74"] != null)
        {
            Progressbar4.Visible = true;
            labelBar4.Visible = true;
            Progressbar4.Value = Convert.ToInt32(Session["l3txt74"].ToString());
            Label8.Text = Session["l3txt74"].ToString() + '%';
        }
        else
        {
            Progressbar4.Visible = false;
            labelBar4.Visible = false;
        }
        if (Session["l3txt75"] != null)
        {
            Progressbar5.Visible = true;
            labelBar5.Visible = true;
            Progressbar5.Value = Convert.ToInt32(Session["l3txt75"].ToString());
            Label9.Text = Session["l3txt75"].ToString() + '%';
        }
        else
        {
            Progressbar5.Visible = false;
            labelBar5.Visible = false;
        }
        if (Session["l3txt76"] != null)
        {
            Progressbar6.Visible = true;
            labelBar6.Visible = true;
            Progressbar6.Value = Convert.ToInt32(Session["l3txt76"].ToString());
            Label10.Text = Session["l3txt76"].ToString() + '%';
        }
        else
        {
            Progressbar6.Visible = false;
            labelBar6.Visible = false;
        }
        if (Session["l3txt77"] != null)
        {
            Progressbar7.Visible = true;
            labelBar7.Visible = true;
            Progressbar7.Value = Convert.ToInt32(Session["l3txt77"].ToString());
            Label11.Text = Session["l3txt77"].ToString() + '%';
        }
        else
        {
            Progressbar7.Visible = false;
            labelBar7.Visible = false;
        }
        if (Session["l3txt78"] != null)
        {
            Progressbar8.Visible = true; 
            labelBar8.Visible = true;
            Progressbar8.Value = Convert.ToInt32(Session["l3txt78"].ToString());
            Label12.Text = Session["l3txt78"].ToString() + '%';
        }
        else
        {
            Progressbar8.Visible = false;
            labelBar8.Visible = false;
        }
        if (Session["l3txt79"] != null)
        {
            Progressbar9.Visible = true; 
            labelBar9.Visible = true;
            Progressbar9.Value = Convert.ToInt32(Session["l3txt79"].ToString());
            Label13.Text = Session["l3txt79"].ToString() + '%';
        }
        else
        {
            Progressbar9.Visible = false;
            labelBar9.Visible = false;
        }
        if (Session["l3txt80"] != null)
        {
            Progressbar10.Visible = true;
            labelBar10.Visible = true;
            Progressbar10.Value = Convert.ToInt32(Session["l3txt80"].ToString());
            Label14.Text = Session["l3txt80"].ToString() + '%';
        }
        else
        {
            Progressbar10.Visible = false;
            labelBar10.Visible = false;
        }

    }

    public void declarationdegree()
    {
        if (Session["avglbl1"] != null && Session["avglbl2"] != null && Session["avglbl3"] != null)
        {
            double sum = ((Convert.ToDouble(Session["avglbl2"]) + Convert.ToDouble(Session["avglbl3"]))/2);
            if (sum > 69)
            {
                lbldegree.Text = "First";
                lbldegree.ForeColor = System.Drawing.Color.Blue;
                ImageButton1.Visible = true;
                ImageButton2.Visible = false;
            }
            else if (sum > 59 && sum < 70)
            {
                lbldegree.Text = "Upper Two";
                lbldegree.ForeColor = System.Drawing.Color.LightBlue;
                ImageButton1.Visible = true;
                ImageButton2.Visible = false;
                labelTogetFirst.Text = "To get Fist class degree you need:" + (70 - sum).ToString("N2");
            }
            else if (sum > 49 && sum < 60)
            {
                lbldegree.Text = "Lower Two";
                lbldegree.ForeColor = System.Drawing.Color.Green;
                ImageButton1.Visible = true;
                ImageButton2.Visible = false;
                labelTogetFirst.Text = "To get Fist class degree you need:" + (70 - sum).ToString("N2");
            }
            else if (sum > 39 && sum < 50)
            {
                lbldegree.Text = "Third";
                lbldegree.ForeColor = System.Drawing.Color.LightGreen;
                ImageButton1.Visible = false;
                ImageButton2.Visible = true;
                labelTogetFirst.Text = "To get Fist class degree you need:" + (70 - sum).ToString("N2");
            }
            else if (sum < 40)
            {
                lbldegree.Text = "Fail";
                lbldegree.ForeColor = System.Drawing.Color.Red;
                ImageButton1.Visible = false;
                ImageButton2.Visible = true;
                labelTogetFirst.Text = "To get Fist class degree you need:" + (70 - sum).ToString("N2");
            }

        }    
    }
}


