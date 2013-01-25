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

public partial class SuperAdmin_Assesment : System.Web.UI.Page
{
    decimal dItemC = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Fillassesmentdetail();
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

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

            //Image1.ImageUrl = dss.Tables[0].Rows[0]["Photo"].ToString();
           
            Fillassesmentdetail();

        }
        else
        {
            //lbl_submit.ForeColor = System.Drawing.Color.Green;
            //lbl_submit.Text = "No Record Found";
            //GridView1.Visible = false;
        }
    }


    public void Fillassesmentdetail()
    {
        try
        {
            DataSet ds = new DataSet();
            string StudentId = txtstudentreg.Text.Trim();

            ds = Module.overallresult(StudentId);
            if (ds.Tables[0].Rows.Count > 0)
            {
                GridView1.Visible = true;
                GridView1.DataSource = ds;
                GridView1.DataBind();
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
    int i=0;
    #region(Find Avg Marks)
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
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

            e.Row.Cells[3].Text = "Avg Marks";
            e.Row.Cells[5].Text = Convert.ToString(Math.Round(dItemC / (i),2));

            e.Row.Cells[3].BackColor = System.Drawing.Color.Plum;
            e.Row.Cells[5].BackColor = System.Drawing.Color.Orchid;
        }
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
    }
    #endregion
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
