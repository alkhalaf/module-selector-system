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

public partial class SuperAdmin_StudentDetails : System.Web.UI.Page
{
    DataSet ds; string Modulename;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            gridVIEWbinding();
            fillmodules();
        }
    }
    public void gridVIEWbinding()
    {
        try
        {

            GridView1.DataSource = Student.studentinformation();
            GridView1.DataBind();
            GridView1.Visible = true;
        }
        catch (Exception ex)
        {

        }

    }


    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {

            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            Student.deletestudentrecord(id);
            GridView1.DataBind();
            gridVIEWbinding();
        }
        catch
        {
            Response.Write("<script>alert('ERROR !!!! DATA NOT DELETED') </script>");
        }
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {

    }
  
    protected void btn_submit_Click(object sender, EventArgs e)
    {
        //This part of the code is used to check if the index in not equal to zero
        //if it is not equal to zero then it will perform the search.
        if (ddlmodule.SelectedIndex != 0)
        {
           Modulename = ddlmodule.SelectedItem.Text;
           string name = txtname.Text.Trim();
           string date = txt_date_of_joining.Text.Trim();
           ds = null;
           ds = Student.SearchStudent(Modulename, name, date);
           if (ds != null && ds.Tables[0].Rows.Count > 0)
           {

               GridView1.DataSource = ds.Tables[0];
               GridView1.DataBind();
           }
           else
           {
               GridView1.EmptyDataText = "Records Does't Exist";
               GridView1.DataSource = ds.Tables[0];
               GridView1.DataBind();
           }
        }
        else
        {
            string name = txtname.Text.Trim();
            string date = txt_date_of_joining.Text.Trim();
            ds = null;
            ds = Student.SearchStudentwithoutmodule(name, date);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {

                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
            }
            else
            {
                GridView1.EmptyDataText = "Records Does't Exist";
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
            }
        }
           
    }

    /*
     * This function is used to get all the courses name and display it in the dropdown box.
     */
    public void fillmodules()
    {
        try
        {
            ddlmodule.DataSource = Module.BindCourses();
            ddlmodule.DataTextField = "CourseName";
            //ddlmodule.DataValueField = "Id";
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
   
    protected void Reset_Click1(object sender, EventArgs e)
    {
        Response.Redirect("StudentDetails.aspx");
    }
    protected void ddlmodule_SelectedIndexChanged(object sender, EventArgs e)
    {
        //string a = ddlmodule.SelectedItem.Text;
    }
}
