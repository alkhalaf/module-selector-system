using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrinityTej;
public partial class userControl_branch_details : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            fillBranchDetails();
        }
        else
        {
        }
    }
   
    protected void ddl_select_state_SelectedIndexChanged(object sender, EventArgs e)
    {
      
    }
    protected void btn_submit_Click(object sender, EventArgs e)
    {
        string course = txtcourse.Text.Trim();
        string module = ddlmodule.SelectedItem.Text;
        try
        {
            if (Module.insertcourse(course, module) == true)
            {
                lbl_submit.ForeColor = System.Drawing.Color.Green;
                lbl_submit.Text = "Data Saved Successfully";
                clearform();
                fillBranchDetails();
            }
            else
            {
                lbl_submit.ForeColor = System.Drawing.Color.Red;
                lbl_submit.Text = "Data Not Saved !!!";
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

    public void clearform()
    {
        txtcourse.Text = "";
        
    }
    public void fillBranchDetails()
    {
        gridview1.DataSource = Module.bindcoursemaster();
        gridview1.DataBind();
    }
    protected void gridview1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //try
        //{
        //    Session["id"] = gridview1.SelectedRow.Cells[0].Text;
        //    Response.Redirect("edit_branch_details.aspx",false);
        //}
        //catch
        //{
        //    Response.Write("<script>alert('Please Click on Edit to edit values') </script>");
        //}
    }
   
    protected void gridview1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gridview1.PageIndex = e.NewPageIndex;
        fillBranchDetails();
        //gridview1.DataBind();
    }


    protected void gridview1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {

            int i = e.RowIndex;
            string crnum = gridview1.Rows[i].Cells[0].Text;
            int ccrr = Convert.ToInt32(crnum);
            //string id=gridview1.SelectedRow.Cells[0].Text;

            Int32 iddd = Convert.ToInt32(ccrr);
            Module.deletecourse(iddd);
            gridview1.DataBind();
            fillBranchDetails();
        }
        catch
        {
            Response.Write("<script>alert('ERROR !!!! DATA NOT DELETED') </script>");
        }
    }
}
