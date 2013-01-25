using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrinityTej;
public partial class userControl_login : System.Web.UI.UserControl
{
    protected void Page_PreRender()
    {

    }
    
    protected void Page_Load(object sender, EventArgs e)
    {
        ddl_usrType.Focus();
        if (!IsPostBack)
        {
            try
            {
                dropdownFILLclass dp = new dropdownFILLclass();
                ddl_usrType.DataSource = dp.data_set_role();
                ddl_usrType.DataTextField = "UserRole";
                ddl_usrType.DataValueField = "SNo";
                ddl_usrType.DataBind();
                

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Database Server Down !!! Please Try after some time or Contact Administrator')</script>");
            }
        }

    }

    /* This function gets activated when the user trys to login
     * This function redirect the user to another page if the user name and the password
     * are correct or incorrect, and upon that the user will be redirected to another page.
     * if they have admin permission they will be redirected to the admin side of the website
     * otherwise they will be redirected to student side. or they will get an error message.
     * This function uses "validateUser" function which is in the login class.
     */
    protected void btn_img_login_Click(object sender, ImageClickEventArgs e)
    {
        lbl_login_error.Text = "";

        try
        {
            string loginid = txt_loginid.Text.Trim();
            string password = txt_pswd.Text.Trim();
            Int32 usertype = Convert.ToInt32(ddl_usrType.SelectedValue);

            switch (usertype)
            {
                case 201:
                    if (login.validateUser(loginid, password, usertype) == "SAM")
                    {                        
                        Session["201"] = "SAM";
                        //ConnectionManager.logdetail(loginid,password);
                        Response.Redirect("~/SuperAdmin/Default.aspx", false);                        
                    }
                    else
                    {
                        lbl_login_error.Text = "Wrong user id or password or your Login has Expired. Contact Admin";
                       // Response.Write("<script>alert('" + logn.validateUser(loginid, password, usertype) + "')</script>");
                    }
                    break;
                case 202:
                    if (login.validateUser(txt_loginid.Text.Trim(), txt_pswd.Text.Trim(), Convert.ToInt32(ddl_usrType.SelectedValue)) == "STUDENT")
                    {
                        Session["202"] = "STUDENT";
                        //ConnectionManager.logdetail(loginid, password);
                        Response.Redirect("~/Student/Default.aspx", false);
                    }
                    else
                    {
                        lbl_login_error.Text = "Wrong user id or password or your Login has Expired. Contact Admin";
                        // Response.Write("<script>alert('" + logn.validateUser(loginid, password, usertype) + "')</script>");
                    }
                    break;
                default:
                    Response.Write("<script>alert('Wrong User Name or Password')</script>");
                   // Response.Write("<script>alert('" + logn.validateUser(loginid, password, usertype) + "')</script>");
                    break;
            }
            Session["loginid"] = loginid;

        }
        catch (Exception ex)
        {
            //Response.Write(ex);
            //Response.Write("<script>alert('" + ex.Message + "')</script>");
            Response.Write("<script>alert('Wrong User Name or Password')</script>");
        }
        //Response.AddHeader("Refresh", "5;URL=card_validity.aspx");
    }
    protected void lkbtn_forget_pass_Click(object sender, EventArgs e)
    {

    }
    //This function is used to change the colour of the Register link on the home page.
    protected void ImgSend_Init(object sender, EventArgs e)
    {
        lnk_register.Attributes.Add("onmouseover", "this.style.color='Red'");
        lnk_register.Attributes.Add("onmouseout", "this.style.color='Green'");
    }
    //This link is used to redirect the user to the student register form.
    protected void lnk_register_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Student_reg_form.aspx");
    }
}
