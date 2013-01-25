using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections;
using System.Configuration;
using TrinityTej;
using System.Data.SqlClient;
using System.Globalization;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Text;
public partial class SuperAdmin_Assesment : System.Web.UI.Page
{

    decimal dItemC = 0; string moduleId;
    StringBuilder str = new StringBuilder();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //BindNoofModule();
            Fillassesmentdetail();
           

        }
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        string course = txtcourse.Text;
        string StudentId = txtstudentreg.Text.Trim();
        string StudentName = txtname.Text.Trim();
        string module = ddlmodule.SelectedItem.Text;
        string lavel = ddlyear.SelectedItem.Text;
        string assesment = ddlassesment.SelectedItem.Text;
        int assesmentId = Convert.ToInt32(ddlassesment.SelectedValue);
        string Marks = txtmarks.Text;
        string maxmarks = txtmaxmarks.Text;
        try
        {
            DataSet dss = new DataSet();
            dss = Module.Assesmentexist(StudentId, assesmentId, module);
            if (dss.Tables[0].Rows.Count > 0)
            {
                lbl_submit.ForeColor = System.Drawing.Color.Red;
                lbl_submit.Text = "Already Exist??";
            }
            else
            {



                if (Module.Assesmentdetail(StudentId, StudentName, course, module, lavel, assesment, assesmentId, Marks, maxmarks) == true)
                {
                    lbl_submit.ForeColor = System.Drawing.Color.Green;
                    lbl_submit.Text = "Data Saved Successfully";
                    Fillassesmentdetail();
                    txtmarks.Text = "";
                }
                else
                {
                    lbl_submit.ForeColor = System.Drawing.Color.Red;
                    lbl_submit.Text = "Data Not Saved !!!"; txtmarks.Text = "";
                }
            }
        }
        catch (Exception ex)
        {
            //    lbl_submit.ForeColor = System.Drawing.Color.Red;
            //    lbl_submit.Text = "Data Not Saved !!! Please Try Again.";
        }
        finally
        {
            ConnectionManager.con.Close();
        }



    }
  
    public void Fillassesmentdetail()
    {
        try
        {
            DataSet ds = new DataSet();
            string StudentId = txtstudentreg.Text.Trim();
            if (ddlmodule.SelectedIndex != 0)
            {
                moduleId = ddlmodule.SelectedItem.Text;
            }
            string lavel = ddlyear.SelectedItem.Text;
            ds = Module.Assesmentdetailretrive(StudentId, moduleId, lavel);
            if (ds.Tables[0].Rows.Count > 0)
            {
                GridView1.Visible = true;
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            else
            {
                GridView1.Visible = false;
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
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
        if (Module.deleteassesment(id) == true)
        {
            Fillassesmentdetail();
        }
        else
        {
            Fillassesmentdetail();
            lbl_submit.Text = "Not Deleted";
        }
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {

    }
    protected void txtstudentreg_TextChanged(object sender, EventArgs e)
    {
        DataSet dss = new DataSet();
        string regno = txtstudentreg.Text.Trim();
        
        dss = Module.Searchstudentinfor(regno);
        if (dss.Tables[0].Rows.Count > 0)
        {
          
            txtname.Text = dss.Tables[0].Rows[0]["Name"].ToString();
            txtcourse.Text = dss.Tables[0].Rows[0]["Course"].ToString();
            BindNoofModule();
            Fillassesmentdetail();

        }
        else
        {
            lbl_submit.ForeColor = System.Drawing.Color.Green;
            lbl_submit.Text = "No Record Found";
            GridView1.Visible = false;
        }
       
    }

    public void clear()
    {
        txtname.Text = ""; ddlmodule.SelectedIndex = 0; ddlyear.SelectedIndex = 0;

    }
    int i = 1;
    #region(Find Avg of Assessment)
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {

        for (int rowIndex = GridView1.Rows.Count - 2; rowIndex >= 0; rowIndex--)
        {
            GridViewRow gvRow = GridView1.Rows[rowIndex];
            GridViewRow gvPreviousRow = GridView1.Rows[rowIndex + 1];
            for (int cellCount = 0; cellCount < gvRow.Cells.Count; cellCount++)
            {

                if (gvRow.Cells[cellCount].Text == "")
                {


                }
                else
                {


                    if (gvRow.Cells[cellCount].Text == gvPreviousRow.Cells[cellCount].Text)
                    {
                        if (gvPreviousRow.Cells[cellCount].RowSpan < 2)
                        {
                            gvRow.Cells[cellCount].RowSpan = 2;
                        }
                        else
                        {
                            gvRow.Cells[cellCount].RowSpan = gvPreviousRow.Cells[cellCount].RowSpan + 1;
                        }
                        gvPreviousRow.Cells[cellCount].Visible = false;
                    }
                }
            }
        } 
        if (e.Row.RowType == DataControlRowType.DataRow)
        {

            i++;
        }
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            dItemC += Convert.ToDecimal(DataBinder.Eval(e.Row.DataItem, "Marks"));

        }

        if (e.Row.RowType == DataControlRowType.Footer)
        {

            e.Row.Cells[2].Text = "Avg Marks";
            e.Row.Cells[4].Text = Convert.ToString(Math.Round(dItemC/(i-1), 2));

            e.Row.Cells[4].BackColor = System.Drawing.Color.White;
            e.Row.Cells[2].BackColor = System.Drawing.Color.White; ;
        }
    }
    #endregion


    protected void ddlyear_SelectedIndexChanged(object sender, EventArgs e)
    {
        Fillassesmentdetail();
        BindNoofModule();
        //ddlmodule.SelectedIndex = 0;
    }


    public void BindNoofModule()
    {
        try
        {
            string a = txtstudentreg.Text;
            int yid = Convert.ToInt32(ddlyear.SelectedValue);
            ddlmodule.DataSource = Module.fillmodule_Namedropdown(a,yid);
            ddlmodule.DataTextField = "ModuleName";
            ddlmodule.DataBind();
            ddlmodule.Items.Insert(0, new ListItem("----Select----", "0"));
           
        }
        catch (Exception ex)
        {

        }
        finally
        {
            ConnectionManager.con.Close();
        }
    }
    protected void ddlmodule_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            ddlassesment.SelectedIndex = 0;
            DataSet ds = new DataSet();
            string StudentId = txtstudentreg.Text.Trim();
            string moduleId =(ddlmodule.SelectedItem.Text);
            string lavel = ddlyear.SelectedItem.Text;
            ds = Module.Assesmentdetailretrive(StudentId, moduleId, lavel);
            if (ds.Tables[0].Rows.Count > 0)
            {
                GridView1.Visible = true;
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            else
            {
                GridView1.Visible = false;
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


    public void maxmarks()
    {
        try
        {
            DataSet ds = new DataSet();
            string year = ddlyear.SelectedItem.Text;
            string module = ddlmodule.SelectedItem.Text;
            string assesment = ddlassesment.SelectedItem.Text;
            ds = Module.maxmarks(year, assesment, module);
            if (ds.Tables[0].Rows.Count > 0)
            {
                txtmaxmarks.Text = ds.Tables[0].Rows[0]["Assesment2"].ToString();
            }
            else
            {
                txtmaxmarks.Text = "";
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
    protected void ddlassesment_SelectedIndexChanged(object sender, EventArgs e)
    {
        maxmarks();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Assesment.aspx");
    }
   
}
 