using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Management;
using System.Management.Instrumentation;
using System.IO;
using System.Security;
using System.Security.AccessControl;
using System.Text.RegularExpressions;
using TrinityTej;
using System.Collections;
using System.Configuration;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
public partial class SuperAdmin_sa : System.Web.UI.MasterPage
{
    protected void ImgSend_Init(object sender, EventArgs e)
    {
        lnk_logout.Attributes.Add("onmouseover", "this.style.color='Red'");
        lnk_logout.Attributes.Add("onmouseout", "this.style.color='Black'"); 
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        string ssn = "";
        string loginid = "";
        try
        {
            //countNotification();
            ssn = Session["202"].ToString();
            if (ssn != "STUDENT")
            {
                Response.Redirect("~/Default.aspx");
            }
            loginid = Session["loginid"].ToString();
            if (Session["loginid"] == null)
            {
                Response.Write("<script>alert('Your Session Expired !!! Please Login Again !!! ')</script>");
                Response.AddHeader("REFRESH", "0;URL=../Default.aspx");
            }
            else
            {
                lbluserid.Text = "";
                lbluserid.Text = Session["loginid"].ToString();
            }
        }
        catch
        {
            Response.Redirect("~/Default.aspx");
        }
        finally
        {
            ConnectionManager.con.Close();
        }

    }
    protected void lnk_logout_Click(object sender, EventArgs e)
    {
        //logdetail();
        Session.Clear();
        Session.Abandon();
        Session.RemoveAll();
        Response.Redirect("~/Default.aspx");
    }



    protected void Page_Init(object Sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
        Response.Cache.SetNoStore();
    }
    public void logdetail()
    {
        DateTime dt = DateTime.Now;
        string datereg = string.Format("{0:dd-MM-yyyy}", dt);
        string date = (dt.Day).ToString();
        string monthh = dt.Month.ToString(); ;
        string yearr = dt.Year.ToString(); ;
        string time = dt.TimeOfDay.ToString();

        string querystrlog = "select Max(Sno) from Master_Logdetails where Date='" + date + "'and Month='" + monthh + "'and Year='" + yearr + "' and Userid='" + Session["loginid"].ToString() + "'";
             SqlDataReader rddd;
             rddd = ConnectionManager.ReaderQuery(querystrlog);
             if (rddd.HasRows)
             {
                 rddd.Read();
                 if (rddd[0] is DBNull)
                 {
                 }
                 else
                 {
                     string Sno = rddd[0].ToString();
                     string query1 = "update Master_Logdetails set LogoutTime='" + time + "' where Userid='" + Session["loginid"].ToString() + "' and Date='" + date + "' and Month='" + monthh + "' and Year='" + yearr + "' and Sno='" +Sno+ "'";
                     ConnectionManager.NonQuery(query1);
                 }
             }
    }
    //public void countNotification()
    //{
    //    DateTime dt = DateTime.Today.Date;
    //    string date = String.Format("{0:dd-MM-yyyy}", dt);
    //    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["trinity"].ToString());
    //    SqlCommand cmd = new SqlCommand("select count(Date)from Feedback where Date='" + date + "' and Userid='" + Session["loginid"].ToString() + "' ", cn);
    //    SqlDataAdapter da = new SqlDataAdapter();
    //    da.SelectCommand = cmd;
    //    DataSet ds = new DataSet();
    //    da.Fill(ds, "Price");
    //    if (ds.Tables[0].Rows.Count > 0)
    //    {
    //        LinkButton1.Text = ds.Tables[0].Rows[0][0].ToString();
    //    }
    //    else
    //    {
    //        LinkButton1.Text = "0";
    //    }
    //}
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Feedback.aspx",false);
    }
    //public void FillModule()
    //{
    //    try
    //    {
    //        ddlmodule.DataSource = Module.FillModule();
    //        ddlmodule.DataTextField = "ModuleName";
    //        ddlmodule.DataValueField = "Id";
    //        ddlmodule.DataBind();
    //        ddlmodule.Items.Insert(0, new ListItem("----Select Module----", "0"));

    //    }
    //    catch (Exception ex)
    //    {

    //    }
    //    finally
    //    {
    //        ConnectionManager.con.Close();
    //    }
    //}
}
