using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Text;
using TrinityTej;

public partial class SuperAdmin_branch_details : System.Web.UI.Page
{
    DataSet ds = null;
    string marks1; string Ass1; int moduleid; string a; string course;
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {

            Fill_Details();
        }
    }
    protected void ddlassesment_SelectedIndexChanged(object sender, EventArgs e)
    {
    }
    protected void btn_submit_Click(object sender, EventArgs e)
    {
       
           
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void ddlassesment_SelectedIndexChanged1(object sender, EventArgs e)
    {
       
    }
    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {
     
    }

    //public void bind_image()
    //{


    //    for (int k = 0; k<=10; k++)
    //    {
    //        //ImageButton image = new System.Web.UI.WebControls.ImageButton();
    //        //image.ID = "op"+k + "";
    //        //image.ImageUrl="~/images/plus.png";
    //        //image.ImageAlign.Equals("left");
    //        //Panel1.Controls.Add(image);
    //        ////Button bb = new Button();
    //        ////bb.ID = "op"+k+"";
    //        ////Pnl.Controls.Add(bb);
    //        //Panel pa = new Panel();
    //        //pa.GroupingText = "Module" + k + "".ToString();
    //        //Panel1.Controls.Add(pa);
    //        ////image.Click += new System.EventHandler(image_Click);
    //    }  
        
     

    //}
    protected void image_Click(object sender, EventArgs e)
    { 
    
    }

   
    public void BindNoofModule(string a)
    {
        try
        {
            DataSet ds = new DataSet();
            //string StudentId = txtstudentreg.Text.Trim();
            //int moduleId = Convert.ToInt32(ddlmodule.SelectedValue);
            string lavel = ddlyear.SelectedItem.Text;
            ds = Module.fillmoduledropdown(course);
            int no = Convert.ToInt32(ds.Tables[0].Rows[0]["NoofModule"]);//(StudentId, moduleId, lavel);
            for (int i = 1; i <= no; i++)
            {
                ddlmodule.Items.Add(i.ToString());
            }
        }
        catch (Exception ex)
        {

        }
        finally
        {
            ConnectionManager.con.Close();
        }
    }
    public void GetIdofModule(string courseId)
    {
        try
        {
            DataSet ds = new DataSet();
            string lavel = ddlyear.SelectedItem.Text;
            ds = Module.getcourseid(courseId);
            if (ds.Tables[0].Rows.Count > 0)
            {
               moduleid =Convert.ToInt32(ds.Tables[0].Rows[0]["Id"].ToString()); 
            }
            else
            {
                
            }


        }
        catch (Exception ex)
        {

        }
        finally
        {
            ConnectionManager.con.Close();
        }
    }

    public void Fill_Details()
    {
        if (Request.QueryString["id"]!=null)
        {

            int Id =Convert .ToInt32(Request.QueryString["id"]);
            ds = Module.editModulemaster(Id);
            if (ds.Tables[0].Rows.Count > 0)
            {
                course = Request.QueryString["Course"];
               
                BindNoofModule(course);
                ddlmodule.SelectedValue = ds.Tables[0].Rows[0]["Module"].ToString();
                txt_Module.Text = ds.Tables[0].Rows[0]["ModuleName"].ToString();
                txtcode.Text = ds.Tables[0].Rows[0]["ModuleCode"].ToString();
                ddlsem.SelectedValue = ds.Tables[0].Rows[0]["ModuleSemId"].ToString();
                ddlyear.SelectedValue = ds.Tables[0].Rows[0]["yearId"].ToString();
                txtfrom.Text = ds.Tables[0].Rows[0]["Lec_From"].ToString();
                txtto.Text = ds.Tables[0].Rows[0]["Lec_To"].ToString();
                txtfrommod.Text = ds.Tables[0].Rows[0]["Tut_From"].ToString();
                txttomod.Text = ds.Tables[0].Rows[0]["Tut_To"].ToString();
                txtdescription.Text = ds.Tables[0].Rows[0]["Description"].ToString();
                ddlassesment.SelectedValue = ds.Tables[0].Rows[0]["NoofAssesment"].ToString();
                lblassesment.Text = ds.Tables[0].Rows[0]["Assesment1"].ToString();
                ass1.Text = ds.Tables[0].Rows[0]["Assesment2"].ToString();
            }
        }
    }


    protected void btnupdate_Click(object sender, EventArgs e)
    {
        int Id = Convert.ToInt32(Request.QueryString["id"]);
        int yearid = Convert.ToInt32(ddlyear.SelectedItem.Value);
        string year = ddlyear.SelectedItem.Text;
        string module = ddlassesment.SelectedItem.Text;
        string MName = txt_Module.Text.Trim();
        string MCode = txtcode.Text;
        string MSem = ddlsem.SelectedItem.Text;
        string Msemid = ddlsem.SelectedItem.Value;
        string Lslotfrom = txtfrom.Text;
        string LslotTo = txtto.Text;
        string tslotfrom = txtfrommod.Text;
        string tslotTo = txttomod.Text;
        string description = txtdescription.Text;
        string Assmarks = ass1.Text;

        try
        {

            if (Module.updatemodulemaster(yearid, year, module, MName, MCode, MSem, Msemid, Lslotfrom, LslotTo, tslotfrom, tslotTo, description, Assmarks,Id) == true)
            {
                lbl_submit.ForeColor = System.Drawing.Color.Green;
                lbl_submit.Text = "Updated Successfully";

            }
            else
            {
                lbl_submit.ForeColor = System.Drawing.Color.Red;
                lbl_submit.Text = "Try again!!!";
            }

        }
        catch (Exception ex)
        {
            lbl_submit.ForeColor = System.Drawing.Color.Red;
            lbl_submit.Text = "Data Not Saved !!! Please Try Again.";
        }
        finally
        {
            ConnectionManager.con.Close();
        }
    }
}
