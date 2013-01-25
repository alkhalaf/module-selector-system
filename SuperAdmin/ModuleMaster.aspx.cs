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
    string marks1; string Ass1; int courseid; string a; string weight;
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Request.QueryString["Name"] != null)
            {
                a = Request.QueryString["Name"].ToString();
                lblcourse.Text = a;
                BindNoofModule(a);
                GetIdofModule(lblcourse.Text);
            }
            else
            {
                lblcourse.Text = "Please Select Course";

            }
            r1.Visible = false;
            r2.Visible = false;
            r3.Visible = false;
            r4.Visible = false;
            r5.Visible = false;
            r6.Visible = false;
            r7.Visible = false;
            r8.Visible = false;
            r9.Visible = false;
            r10.Visible = false;
            Fillassesmentdetail();
        }
        
    }
    protected void ddlassesment_SelectedIndexChanged(object sender, EventArgs e)
    {



    }
    #region(Save Data in Databse)
    protected void btn_submit_Click(object sender, EventArgs e)
    {
        int sum = validationonweight();

        if (validationMarks() ==true)
        {
            if (sum == 100)
            {
                string day_Lecture = Lec_ddday.SelectedItem.Text;
                string Lslotfrom = lec_fromtime.SelectedItem.Text;
                string LslotTo = lec_totime.SelectedItem.Text;
                string day_Tutorial = tutday.SelectedItem.Text;
                string tslotfrom = tuttimefrom.SelectedItem.Text; //txtfrommod.Text;
                string tslotTo = tuttimeto.SelectedItem.Text;//txttomod.Text;
                int ass = ddlassesment.SelectedIndex;
                for (int i = 1; i <= ass; i++)
                {
                    GetIdofModule(lblcourse.Text);
                    string course = lblcourse.Text;
                    int courseuid = courseid;
                    int yearid = Convert.ToInt32(ddlyear.SelectedItem.Value);
                    string year = ddlyear.SelectedItem.Text;
                    string module = ddlassesment.SelectedItem.Text;
                    string MName = txt_Module.Text.Trim();
                    string MCode = txtcode.Text;
                    string MSem = ddlsem.SelectedItem.Text;
                    string Msemid = ddlsem.SelectedItem.Value;
                    day_Lecture = Lec_ddday.SelectedItem.Text;
                    Lslotfrom = lec_fromtime.SelectedItem.Text;
                    LslotTo = lec_totime.SelectedItem.Text;
                    day_Tutorial = tutday.SelectedItem.Text;
                    tslotfrom = tuttimefrom.SelectedItem.Text; //txtfrommod.Text;
                    tslotTo = tuttimeto.SelectedItem.Text;//txttomod.Text;
                    string description = txtdescription.Text;
                    string Noofassesment = ddlassesment.SelectedItem.Text;
                    string credits = txtcredits.Text;
                    if (i == 1)
                    {
                        marks1 = ass1.Text;
                        Ass1 = "Assessment-1";
                        weight = txtw1.Text;
                    }
                    if (i == 2)
                    {
                        marks1 = ass2.Text;
                        Ass1 = "Assessment-2";
                        weight = txtw2.Text;
                    }
                    if (i == 3)
                    {
                        marks1 = ass3.Text;
                        Ass1 = "Assessment-3";
                        weight = txtw3.Text;
                    }
                    if (i == 4)
                    {
                        marks1 = ass4.Text;
                        Ass1 = "Assessment-4";
                        weight = txtw4.Text;
                    }
                    if (i == 5)
                    {
                        marks1 = ass5.Text;
                        Ass1 = "Assessment-5";
                        weight = txtw5.Text;
                    }
                    if (i == 6)
                    {
                        marks1 = ass6.Text;
                        Ass1 = "Assessment-6";
                        weight = txtw6.Text;
                    }
                    if (i == 6)
                    {
                        marks1 = ass7.Text;
                        Ass1 = "Assessment-7";
                        weight = txtw7.Text;
                    }
                    if (i == 6)
                    {
                        marks1 = ass8.Text;
                        Ass1 = "Assessment-8";
                        weight = txtw8.Text;
                    }
                    if (i == 6)
                    {
                        marks1 = ass9.Text;
                        Ass1 = "Assessment-9";
                        weight = txtw9.Text;
                    }
                    if (i == 6)
                    {
                        marks1 = ass10.Text;
                        Ass1 = "Assessment-10";
                        weight = txtw10.Text;
                    }
                    try
                    {

                        if (Module.Modulereg(course, courseuid, yearid, year, module, MName, MCode, MSem, Msemid, day_Lecture, Lslotfrom, LslotTo, day_Tutorial, tslotfrom, tslotTo, description, Noofassesment, Ass1, marks1, weight, credits) == true)
                        {
                            lbl_submit.Text = "";
                            lbl_submit1.Text = "";
                            lbl_submit1.ForeColor = System.Drawing.Color.Green;
                            lbl_submit1.Text = "Data Saved Successfully";
                            Fillassesmentdetail();


                        }
                        else
                        {
                            lbl_submit1.Text = "";
                            lbl_submit.Text = "";
                            lbl_submit1.ForeColor = System.Drawing.Color.Red;
                            lbl_submit1.Text = "Exist!!!";

                        }

                    }
                    catch (Exception ex)
                    {
                        lbl_submit1.Text = "";
                        lbl_submit.Text = "";
                        lbl_submit1.ForeColor = System.Drawing.Color.Red;
                        lbl_submit1.Text = "Data Not Saved !!! Please Try Again.";
                    }
                    finally
                    {
                        ConnectionManager.con.Close();
                    }

                }
                clear();
                lbl_submit1.Text = "";
                lbl_submit.Text = "";
                lbl_submit1.ForeColor = System.Drawing.Color.Red;
                lbl_submit1.Text = "Data Saved Successfully";
            }
            else
            {
                lbl_submit1.Text = "";
                lbl_submit.Text = "";
                lbl_submit.ForeColor = System.Drawing.Color.Red;
                lbl_submit.Text = "Sum of all weight(%) must be 100";
            }
        }
        else
        {
            lbl_submit1.Text = "";
            lbl_submit.Text = "";
            lbl_submit.ForeColor = System.Drawing.Color.Red;
            lbl_submit.Text = "Plz Enter Only 100 in MaxMarks";
          
        
        }
    }
    #endregion
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void ddlassesment_SelectedIndexChanged1(object sender, EventArgs e)
    {
        if (ddlassesment.SelectedIndex == 1)
        {
            r1.Visible = true;
            r2.Visible = false;
            r3.Visible = false;
            r4.Visible = false;
            r5.Visible = false;
            r6.Visible = false;
            r7.Visible = false;
            r8.Visible = false;
            r9.Visible = false;
            r10.Visible = false;
        }
        if (ddlassesment.SelectedIndex == 2)
        {
            r2.Visible = true;
            r1.Visible = true;
            r3.Visible = false;
            r4.Visible = false;
            r5.Visible = false;
            r6.Visible = false;
            r7.Visible = false;
            r8.Visible = false;
            r9.Visible = false;
            r10.Visible = false;
           
        }
        if (ddlassesment.SelectedIndex == 3)
        {
            r1.Visible = true;
            r2.Visible = true;
            r3.Visible = true;
            r4.Visible = false;
            r5.Visible = false;
            r6.Visible = false;
            r7.Visible = false;
            r8.Visible = false;
            r9.Visible = false;
            r10.Visible = false;
           
        }
        if (ddlassesment.SelectedIndex == 4)
        {
            r1.Visible = true;
            r2.Visible = true;
            r3.Visible = true;
            r4.Visible = true;
            r5.Visible = false;
            r6.Visible = false;
            r7.Visible = false;
            r8.Visible = false;
            r9.Visible = false;
            r10.Visible = false;
           
        }
        if (ddlassesment.SelectedIndex == 5)
        {
            r1.Visible = true;
            r2.Visible = true;
            r3.Visible = true;
            r4.Visible = true;
            r5.Visible = true;
            r6.Visible = false;
            r7.Visible = false;
            r8.Visible = false;
            r9.Visible = false;
            r10.Visible = false;
            
        }
        if (ddlassesment.SelectedIndex == 6)
        {
            r1.Visible = true;
            r2.Visible = true;
            r3.Visible = true;
            r4.Visible = true;
            r5.Visible = true;
            r6.Visible = true;
            r7.Visible = false;
            r8.Visible = false;
            r9.Visible = false;
            r10.Visible = false;
            
        }

        if (ddlassesment.SelectedIndex == 0)
        {
            r1.Visible = false;
            r2.Visible = false;
            r3.Visible = false;
            r4.Visible = false;
            r5.Visible = false;
            r6.Visible = false;
            r7.Visible = false;
            r8.Visible = false;
            r9.Visible = false;
            r10.Visible = false;
           
        }
        if (ddlassesment.SelectedIndex == 7)
        {
            r1.Visible = true;
            r2.Visible = true;
            r3.Visible = true;
            r4.Visible = true;
            r5.Visible = true;
            r6.Visible = true;
            r7.Visible = true;
            r8.Visible = false;
            r9.Visible = false;
            r10.Visible = false;

        }
        if (ddlassesment.SelectedIndex == 8)
        {
            r1.Visible = true;
            r2.Visible = true;
            r3.Visible = true;
            r4.Visible = true;
            r5.Visible = true;
            r6.Visible = true;
            r7.Visible = true;
            r8.Visible = true;
            r9.Visible = false;
            r10.Visible = false;

        }
        if (ddlassesment.SelectedIndex == 9)
        {
            r1.Visible = true;
            r2.Visible = true;
            r3.Visible = true;
            r4.Visible = true;
            r5.Visible = true;
            r6.Visible = true;
            r7.Visible = true;
            r8.Visible = true;
            r9.Visible = true;
            r10.Visible = false;

        }
        if (ddlassesment.SelectedIndex == 10)
        {
            r1.Visible = true;
            r2.Visible = true;
            r3.Visible = true;
            r4.Visible = true;
            r5.Visible = true;
            r6.Visible = true;
            r7.Visible = true;
            r8.Visible = true;
            r9.Visible = true;
            r10.Visible = true;
        }
        
        
       
    }
    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {
     
    }


    protected void image_Click(object sender, EventArgs e)
    { 
    
    }

    public void Fillassesmentdetail()
    {
        try
        {
            DataSet ds = new DataSet();
           
            string lavel = ddlyear.SelectedItem.Text;
            ds = Module.fillmoduledetail(courseid);//(StudentId, moduleId, lavel);
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
    #region(for gridview rowspan)
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
    }
    #endregion
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
        if (Module.deleteModule(id) == true)
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
         string Idss = Convert.ToString(GridView1.DataKeys[e.NewEditIndex].Value.ToString());
         Response.Redirect("edit_ ModuleMaster.aspx?Id=" + Idss + "&Course=" + lblcourse.Text);
    }
    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {

    }

    public void BindNoofModule(string a)
    {
        try
        {
            DataSet ds = new DataSet();
           
            ds = Module.fillmoduledropdown(a);
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
            ds = Module.getcourseid(lblcourse.Text);
            if (ds.Tables[0].Rows.Count > 0)
            {
               courseid =Convert.ToInt32(ds.Tables[0].Rows[0]["Id"].ToString()); 
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
    public void clear()
    {
        txt_Module.Text = ""; txtcode.Text = ""; ddlsem.SelectedIndex = 0; txtdescription.Text = "";
        ddlassesment.SelectedIndex = 0; ass1.Text = ""; txtw1.Text = ""; ass2.Text = ""; txtw2.Text = "";
        ass3.Text = ""; txtw3.Text = "";
        ass4.Text = ""; txtw4.Text = "";
        ass5.Text = ""; txtw5.Text = "";
        ass6.Text = ""; txtw6.Text = "";
        ass7.Text = ""; txtw7.Text = "";
        ass8.Text = ""; txtw8.Text = "";
        ass9.Text = ""; txtw9.Text = "";
        ass10.Text = ""; txtw10.Text = "";
    }
    int sum;
    public  int validationonweight()
    {
        
        if (ddlassesment.SelectedIndex == 1)
        {
             sum =Convert.ToInt32(txtw1.Text);
            return sum;
        }
        else if (ddlassesment.SelectedIndex == 2)
        {
             sum = Convert.ToInt32(txtw1.Text) + Convert.ToInt32(txtw2.Text);
            return sum;
        }
        else if (ddlassesment.SelectedIndex == 3)
        {
             sum = Convert.ToInt32(txtw1.Text) + Convert.ToInt32(txtw2.Text) + Convert.ToInt32(txtw3.Text);
            return sum;
        }
        else if (ddlassesment.SelectedIndex == 4)
        {
             sum = Convert.ToInt32(txtw1.Text) + Convert.ToInt32(txtw2.Text) + Convert.ToInt32(txtw3.Text) + Convert.ToInt32(txtw4.Text);
            return sum;
        }
        else if (ddlassesment.SelectedIndex == 5)
        {
            sum = Convert.ToInt32(txtw1.Text) + Convert.ToInt32(txtw2.Text) + Convert.ToInt32(txtw3.Text) + Convert.ToInt32(txtw4.Text)+Convert.ToInt32(txtw5.Text);
            return sum;
        }
        else if (ddlassesment.SelectedIndex == 6)
        {
            sum = Convert.ToInt32(txtw1.Text) + Convert.ToInt32(txtw2.Text) + Convert.ToInt32(txtw3.Text) + Convert.ToInt32(txtw4.Text) + Convert.ToInt32(txtw5.Text) + Convert.ToInt32(txtw6.Text);
            return sum;
        }
        else if (ddlassesment.SelectedIndex == 7)
        {
            sum = Convert.ToInt32(txtw1.Text) + Convert.ToInt32(txtw2.Text) + Convert.ToInt32(txtw3.Text) + Convert.ToInt32(txtw4.Text) + Convert.ToInt32(txtw5.Text) + Convert.ToInt32(txtw6.Text) + Convert.ToInt32(txtw7.Text);
            return sum;
        }
        else if (ddlassesment.SelectedIndex == 8)
        {
            sum = Convert.ToInt32(txtw1.Text) + Convert.ToInt32(txtw2.Text) + Convert.ToInt32(txtw3.Text) + Convert.ToInt32(txtw4.Text) + Convert.ToInt32(txtw5.Text) + Convert.ToInt32(txtw6.Text) + Convert.ToInt32(txtw7.Text) + Convert.ToInt32(txtw8.Text);
            return sum;
        }
        else if (ddlassesment.SelectedIndex == 9)
        {
            sum = Convert.ToInt32(txtw1.Text) + Convert.ToInt32(txtw2.Text) + Convert.ToInt32(txtw3.Text) + Convert.ToInt32(txtw4.Text) + Convert.ToInt32(txtw5.Text) + Convert.ToInt32(txtw6.Text) + Convert.ToInt32(txtw7.Text) + Convert.ToInt32(txtw8.Text) + Convert.ToInt32(txtw9.Text);
            return sum;
        }
        else if (ddlassesment.SelectedIndex == 10)
        {
            sum = Convert.ToInt32(txtw1.Text) + Convert.ToInt32(txtw2.Text) + Convert.ToInt32(txtw3.Text) + Convert.ToInt32(txtw4.Text) + Convert.ToInt32(txtw5.Text) + Convert.ToInt32(txtw6.Text) + Convert.ToInt32(txtw7.Text) + Convert.ToInt32(txtw8.Text) + Convert.ToInt32(txtw9.Text) + Convert.ToInt32(txtw10.Text);
            return sum;
        }
        return sum;

    }

    public bool validationMarks()
    {

        if (ddlassesment.SelectedIndex == 1)
        {
            if (ass1.Text == "100")
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        else if (ddlassesment.SelectedIndex == 2)
        {
            if (ass1.Text == "100" && ass2.Text == "100")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (ddlassesment.SelectedIndex == 3)
        {
            if (ass1.Text == "100" && ass2.Text == "100" && ass3.Text == "100")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (ddlassesment.SelectedIndex == 4)
        {
            if (ass1.Text == "100" && ass2.Text == "100" && ass3.Text == "100" && ass4.Text == "100")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (ddlassesment.SelectedIndex == 5)
        {
            if (ass1.Text == "100" && ass2.Text == "100" && ass3.Text == "100" && ass4.Text == "100" && ass5.Text == "100")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (ddlassesment.SelectedIndex == 6)
        {
            if (ass1.Text == "100" && ass2.Text == "100" && ass3.Text == "100" && ass4.Text == "100" && ass5.Text == "100" && ass6.Text == "100")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (ddlassesment.SelectedIndex == 7)
        {
            if (ass1.Text == "100" && ass2.Text == "100" && ass3.Text == "100" && ass4.Text == "100" && ass5.Text == "100" && ass6.Text == "100" && ass7.Text == "100")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (ddlassesment.SelectedIndex == 8)
        {
            if (ass1.Text == "100" && ass2.Text == "100" && ass3.Text == "100" && ass4.Text == "100" && ass5.Text == "100" && ass6.Text == "100" && ass7.Text == "100" && ass8.Text == "100")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (ddlassesment.SelectedIndex == 9)
        {
            if (ass1.Text == "100" && ass2.Text == "100" && ass3.Text == "100" && ass4.Text == "100" && ass5.Text == "100" && ass6.Text == "100" && ass7.Text == "100" && ass8.Text == "100" && ass9.Text == "100")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (ddlassesment.SelectedIndex == 10)
        {
            if (ass1.Text == "100" && ass2.Text == "100" && ass3.Text == "100" && ass4.Text == "100" && ass5.Text == "100" && ass6.Text == "100" && ass7.Text == "100" && ass8.Text == "100" && ass9.Text == "100" && ass10.Text == "100")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        return false;

    }
}
