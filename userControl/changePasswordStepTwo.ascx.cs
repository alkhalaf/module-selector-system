using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class userControl_changePasswordStepTwo : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void btn_change_pass_Click(object sender, EventArgs e)
    {
        string oldpass = txt_current_password.Text.Trim();
        string new_verify_pass = txt_verify_password.Text.Trim();
        if (Session["loginid"] != null)
        {
            string logid = Session["loginid"].ToString();

            #region(Check Password from database end if exist than Change)
            if (Student.ChangePasswordStepCHECK(oldpass, logid) == true)
            {
                if (Student.ChangePasswordCOMPLETED(oldpass, logid, new_verify_pass) == true)
                {
                    lbl_submit.ForeColor = System.Drawing.Color.Green;
                    lbl_submit.Text = "Password Changed Successfully";
                }
                else
                {
                    lbl_submit.ForeColor = System.Drawing.Color.Red;
                    lbl_submit.Text = "Wrong Current Password";
                }
            }
            else
            {
                lbl_submit.ForeColor = System.Drawing.Color.Red;
                lbl_submit.Text = "Wrong Current Password, Please type Correct Password !!!";
            }
            #endregion
        }
        else
        {
            lbl_submit.Text = "Please Login Again or Contact Administrator";
        }        
    }
}
