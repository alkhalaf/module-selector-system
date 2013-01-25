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

public partial class Student_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["loginid"] != null)
        {
            if (!Page.IsPostBack)
            {
                fillmodule();
               
                selectfreezemodule();
            }
        }
        else
        {
            Response.Redirect("Default.aspx", false);
        }
    }
    #region(Save Student Selected Module In Database and Check Different Condition)
    protected void BtSave_Click(object sender, EventArgs e)
    {
        if (modulebound.SelectedIndex!=-1)
        {
            DataSet ds11 = new DataSet();
            int Sno = Convert.ToInt32(modulebound.SelectedValue.Trim());
            ds11 = Student.insertintoStudent_module(Sno);
            if (ds11.Tables.Count > 0)
            {
                string Course = ds11.Tables[0].Rows[0]["Course"].ToString();
                int Courseid = Convert.ToInt32(ds11.Tables[0].Rows[0]["Courseid"].ToString());
                string YearId = ds11.Tables[0].Rows[0]["YearId"].ToString();
                string Year = ds11.Tables[0].Rows[0]["Year"].ToString();
                int ModuleId = Convert.ToInt32(ds11.Tables[0].Rows[0]["Module"].ToString());
                string ModuleName = ds11.Tables[0].Rows[0]["ModuleName"].ToString();
                string ModuleCode = ds11.Tables[0].Rows[0]["ModuleCode"].ToString();
                string ModuleSem = ds11.Tables[0].Rows[0]["ModuleSem"].ToString();
                int ModuleSemId = Convert.ToInt32(ds11.Tables[0].Rows[0]["ModuleSemId"].ToString());
                string lecture = (ds11.Tables[0].Rows[0]["Lectore"].ToString());
                string tutorial = (ds11.Tables[0].Rows[0]["tutorail"].ToString());
                string EnrollmentNo = Session["loginid"].ToString();
                string credites = (ds11.Tables[0].Rows[0]["Credits"].ToString());
                DataSet ds = new DataSet();
                ds = Module.cuontnoofmodule(YearId, EnrollmentNo);
                if (ds.Tables[0].Rows.Count > 7)
                {
                    lbl_submit.Text = "You Can't select more than 8 module in each level";
                }
                else
                {

                    if (Module.checktutorialTiming(lecture, tutorial, EnrollmentNo, ModuleSemId, Year) == true)
                    {
                        lbl_submit.Text = "Module Timing clashed Choose Another";
                    }
                    else
                    {

                        ds = Student.checkmoduleexist(ModuleName, ModuleCode, EnrollmentNo);
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            lbl_submit.Text = "You can't Choose as it already exist";
                        }
                        else
                        {

                            ds = Student.Modulereg(ModuleSem, ModuleSemId, EnrollmentNo, YearId);
                            if (ds.Tables[0].Rows.Count <= 3)
                            {
                                if (Student.StudentSelected_ModuleMaster(EnrollmentNo, Course, Courseid, YearId, Year, ModuleId, ModuleName,credites,ModuleCode, ModuleSem, ModuleSemId, lecture, tutorial) == true) ;
                                {
                                    selectfreezemodule();
                                    lbl_submit.Text = "Module Added Successfully";
                                }
                            }
                            else
                            {
                                lbl_submit.Text = "You Can't Select More than 4 Module in the Same semester";

                            }
                        }


                    }
                }
            }
        }
        else
        {
            lbl_submit.Text = "Select a Module";
        }

    }
    #endregion
    public void fillmodule()
    {
        int yid = Convert.ToInt32(ddllavel.SelectedItem.Value.ToString());
        string EnrollmentNo = Session["loginid"].ToString();
        DataSet ds = Module.CourseID(EnrollmentNo);
        if (ds.Tables.Count > 0)
        {
            int Cid =Convert.ToInt32(ds.Tables[0].Rows[0]["Courseid"].ToString());
            DataSet ds1 = Module.Moduledetailfoecourse(yid, Cid);
            if (ds1.Tables.Count > 0)
            {
                if (ds1 != null && ds1.Tables[0].Rows.Count > 0)
                {
                    modulebound.DataSource = ds1.Tables[0];
                    modulebound.DataTextField = "ModuleName";
                    modulebound.DataValueField = "Id";
                    modulebound.DataBind();
                }
                else
                {
                    modulebound.DataSource = ds1.Tables[0];
                    modulebound.DataBind();
                }
            }
        }

    }
    protected void modulebound_SelectedIndexChanged(object sender, EventArgs e)
    {
        lbl_submit.Text = "";
        int Sno = Convert.ToInt32(modulebound.SelectedValue.Trim());

        DataSet ds = Module.Moduledetaildescription(Sno);
        if (ds.Tables.Count > 0)
        {

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                txtdescription.Text = Convert.ToString(ds.Tables[0].Rows[0][0]);

            }
            DataSet ds1 = Module.moduledetailbindgrid(Sno);
            GridView1.DataSource = ds1.Tables[0];
            GridView1.DataBind();
        }


    }
    protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id = Convert.ToInt32(GridView2.DataKeys[e.RowIndex].Value.ToString());
        if (Module.delete(id) == true)
        {
            selectfreezemodule();
        }
        else
        {
            selectfreezemodule();
            lbl_submit.Text = "Not Deleted";
        }
    }
    #region(Freez Module)
    protected void btnquit_Click(object sender, EventArgs e)
    {
        string EnrollmentNo = Session["loginid"].ToString();
        if (Student.updateselectmodule(EnrollmentNo) == true)
        {
            foreach (GridViewRow row in GridView2.Rows)
            {

                ImageButton ch = row.FindControl("lnkDeleteQuantity") as ImageButton;
                ch.Visible = false;
            }
        }

    }
    #endregion
    protected void ddllavel_SelectedIndexChanged(object sender, EventArgs e)
    {
        fillmodule();
        selectfreezemodule();
        lbl_submit.Text = "";
    }
    #region(Retrive or Show Selected module Acording to Student Wise)
    public void selectfreezemodule()
    {
        string EnrollmentNo = Session["loginid"].ToString();
        int yid = Convert.ToInt32(ddllavel.SelectedItem.Value.ToString());
        DataSet ds = Student.bindgridstudent(EnrollmentNo, yid);
        if (ds.Tables[0].Rows.Count > 0)
        {
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                GridView2.Visible = true;
                GridView2.DataSource = ds.Tables[0];
                GridView2.DataBind();
                foreach (GridViewRow row in GridView2.Rows)
                {

                    ImageButton ch = row.FindControl("lnkDeleteQuantity") as ImageButton;
                    ch.Visible = false;
                }

            }
            else
            {
               

            }
        }
        else
        {
            DataSet ds1 = Student.bindgridstudentafterfreezing(EnrollmentNo, yid);
            if (ds1.Tables.Count > 0)
            {
                if (ds1 != null && ds1.Tables[0].Rows.Count > 0)
                {

                    GridView2.Visible = true;
                    GridView2.DataSource = ds1.Tables[0];
                    GridView2.DataBind();
                }
                else
                {
                    GridView2.DataSource = ds1.Tables[0];
                    GridView2.DataBind();
                }
            }
           

        }


    }
    #endregion
}
