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
using System.Text;

public partial class SuperAdmin_Barchart : System.Web.UI.Page
{
    StringBuilder str = new StringBuilder();
    protected void Page_Load(object sender, EventArgs e)
    {
        txtenroll.Text=Session["loginid"].ToString();
        if (!Page.IsPostBack)
        {
            fillcourse();
            
        }
    }
    #region(Function To Generate Bar Chart descinding Order)
    private void chart_bind()
    {
      
           //string cid = (ddlcourse.SelectedItem.Text);
           string year = ddlyear.SelectedItem.Text;
           string cource = ddlcourse.SelectedItem.Text;
           string Regno = txtenroll.Text;
           DataTable dt = new DataTable();
           dt = Module.Piegraphaesc(year, cource, Regno);
           if (dt.Rows.Count > 0)
           {
               str.Append(@"<script type=text/javascript>
           function drawVisualization() {
           // Some raw data (not necessarily accurate)
           var data = google.visualization.arrayToDataTable([
           ['Name', 'marks'],");
               // here i am declairing the variable i in int32 for the looping statement
               Int32 i;
               // loop start from 0 and its end depend on the value inside dt.Rows.Count - 1
               for (i = 0; i <= dt.Rows.Count - 1; i++)
               {
                   // here i am fill the string builder with the value from the database
                   str.Append("['" + (dt.Rows[i]["Module"].ToString()) + "'," + dt.Rows[i]["marks"].ToString() + "],");
               }
               // other all string is fill according to the javascript code
               str.Append("  ]);");
               str.Append("  var comboChart = new google.visualization.ComboChart(document.getElementById('chart_div'));");
               str.Append(" comboChart.draw(data, {");
               str.Append(" title : 'Students Assesment',");
               str.Append("vAxis: {title:" + "*Marks*" + "},");
               str.Append(" hAxis: {title:" + "*Module*" + " },");
               str.Append("seriesType:" + "*bars*" + " ,");
               // in the below line i need " in place of *
               // stringbuilder can't return us " so at the last line i am
               // replacing * with the " using Replace('*', '"'); function
               // and other code is same like the google code
               str.Append("series: {" + dt.Rows.Count + ": {type: " + "*line*" + "}}");
               str.Append("}); }");
               str.Append("google.setOnLoadCallback(drawVisualization);");
               str.Append("</script>");
               // here am using literal conrol to display the complete graph
               lt.Text = str.ToString().TrimEnd(',').Replace('*', '"');
           }
           else
           {
               lt.Text = "";
           }

    }
    #endregion
    #region(Bar Chart Ascending order)
    private void chart_bindpieaesc()
    {
        //string cid = (ddlcourse.SelectedItem.Text);
        string year = ddlyear.SelectedItem.Text;
        string cource = ddlcourse.SelectedItem.Text;
        string Regno = txtenroll.Text;
        DataTable dt = new DataTable();
        dt = Module.Piegraph(year,cource,Regno);
        if (dt.Rows.Count > 0)
        {
            str.Append(@"<script type=text/javascript>
           function drawVisualization() {
           // Some raw data (not necessarily accurate)
           var data = google.visualization.arrayToDataTable([
           ['Name', 'marks'],");
            // here i am declairing the variable i in int32 for the looping statement
            Int32 i;
            // loop start from 0 and its end depend on the value inside dt.Rows.Count - 1
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                // here i am fill the string builder with the value from the database
                str.Append("['" + (dt.Rows[i]["Module"].ToString()) + "'," + dt.Rows[i]["marks"].ToString() + "],");
            }
            // other all string is fill according to the javascript code
            str.Append("  ]);");
            str.Append("  var comboChart = new google.visualization.ComboChart(document.getElementById('chart_div'));");
            str.Append(" comboChart.draw(data, {");
            str.Append(" title : 'Students Assesment',");
            str.Append("vAxis: {title:" + "*Marks*" + "},");
            str.Append(" hAxis: {title:" + "*Module*" + " },");
            str.Append("seriesType:" + "*bars*" + " ,");
            // in the below line i need " in place of *
            // stringbuilder can't return us " so at the last line i am
            // replacing * with the " using Replace('*', '"'); function
            // and other code is same like the google code
            str.Append("series: {" + dt.Rows.Count + ": {type: " + "*line*" + "}}");
            str.Append("}); }");
            str.Append("google.setOnLoadCallback(drawVisualization);");
            str.Append("</script>");
            // here am using literal conrol to display the complete graph
            lt.Text = str.ToString().TrimEnd(',').Replace('*', '"');
        }
        else
        {
            lt.Text = "";
        }

    }
    #endregion
    protected void btn_submit_Click(object sender, EventArgs e)
    {

    }
    protected void ddlcourse_SelectedIndexChanged(object sender, EventArgs e)
    {
        fillmodule(); 
      
    }
    public void fillmodule()
    {
        try
        {
            //int cid = Convert.ToInt32(ddlcourse.SelectedItem.Value);
            ddlcourse.DataSource = Module.Bindmodule();
            ddlcourse.DataTextField = "ModuleName";
            ddlcourse.DataBind();
            ddlcourse.Items.Insert(0, new ListItem("----Select----", "0"));
        }
        catch (Exception ex)
        {

        }
        finally
        {
            ConnectionManager.con.Close();
        }

    }
    protected void ddlyear_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddorder.SelectedIndex = 0; lt.Text = "";
    }
    protected void ddlmodule_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddorder.SelectedIndex = 0; lt.Text = "";
    }
    protected void ddlass_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddorder.SelectedIndex = 0; lt.Text = "";
    }
    protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddorder.SelectedIndex != 0)
        {
            if (ddorder.SelectedIndex == 2)
            {
                chart_bind();
            }
            if (ddorder.SelectedIndex == 3)
            {
                chart_bindpieaesc();
            }
            if (ddorder.SelectedIndex == 1)
            {
                chart_bindalphabatical();
            }
        }
        else
        {
            lt.Text = "";
        }
    }

    public void fillcourse()
    {

        try
        {

            string enrollment = Session["loginid"].ToString();
            ddlcourse.DataSource = Module.BindcourseStudentsection(enrollment);
            ddlcourse.DataTextField = "Course";
            ddlcourse.DataValueField = "Courseid";
            ddlcourse.DataBind();
            //ddlcourse.Items.Insert(0, new ListItem("----Select----", "0"));

        }
        catch (Exception ex)
        {

        }
        finally
        {
            ConnectionManager.con.Close();
        }
    }

    #region( barchart alphabetical order)
    private void chart_bindalphabatical()
    {
        string year = ddlyear.SelectedItem.Text;
        string cource = ddlcourse.SelectedItem.Text;
        string Regno = txtenroll.Text;
        DataTable dt = new DataTable();
        dt = Module.alphabatical(year, cource, Regno);
        if (dt.Rows.Count > 0)
        {
            str.Append(@"<script type=text/javascript>
           function drawVisualization() {
           // Some raw data (not necessarily accurate)
           var data = google.visualization.arrayToDataTable([
           ['Name', 'marks'],");
            // here i am declairing the variable i in int32 for the looping statement
            Int32 i;
            // loop start from 0 and its end depend on the value inside dt.Rows.Count - 1
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                // here i am fill the string builder with the value from the database
                str.Append("['" + (dt.Rows[i]["Module"].ToString()) + "'," + dt.Rows[i]["marks"].ToString() + "],");
            }
            // other all string is fill according to the javascript code
            str.Append("  ]);");
            str.Append("  var comboChart = new google.visualization.ComboChart(document.getElementById('chart_div'));");
            str.Append(" comboChart.draw(data, {");
            str.Append(" title : 'Students Assesment',");
            str.Append("vAxis: {title:" + "*Marks*" + "},");
            str.Append(" hAxis: {title:" + "*Module*" + " },");
            str.Append("seriesType:" + "*bars*" + " ,");
            // in the below line i need " in place of *
            // stringbuilder can't return us " so at the last line i am
            // replacing * with the " using Replace('*', '"'); function
            // and other code is same like the google code
            str.Append("series: {" + dt.Rows.Count + ": {type: " + "*line*" + "}}");
            str.Append("}); }");
            str.Append("google.setOnLoadCallback(drawVisualization);");
            str.Append("</script>");
            // here am using literal conrol to display the complete graph
            lt.Text = str.ToString().TrimEnd(',').Replace('*', '"');
        }
        else
        {
            lt.Text = "";
        }
    }
    #endregion

}
