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

public partial class Student_Gradeprediction : System.Web.UI.Page
{
    ////////////////////for level4
    double L1cal11, L1cal12, L1cal13, L1cal14, L1cal15, L1cal16, L1cal17, L1cal18, L1cal19, L1cal110;
    double L1cal21, L1cal22, L1cal23, L1cal24, L1cal25, L1cal26, L1cal27, L1cal28, L1cal29, L1cal120;
    double L1cal31, L1cal32, L1cal33, L1cal34, L1cal35, L1cal36, L1cal37, L1cal38, L1cal39, L1cal310;
    double L1cal41, L1cal42, L1cal43, L1cal44, L1cal45, L1cal46, L1cal47, L1cal48, L1cal49, L1cal410;
    double L1cal51, L1cal52, L1cal53, L1cal54, L1cal55, L1cal56, L1cal57, L1cal58, L1cal59, L1cal510;
    double L1cal61, L1cal62, L1cal63, L1cal64, L1cal65, L1cal66, L1cal67, L1cal68, L1cal69, L1cal610;
    double L1cal71, L1cal72, L1cal73, L1cal74, L1cal75, L1cal76, L1cal77, L1cal78, L1cal79, L1cal710;
    double L1cal81, L1cal82, L1cal83, L1cal84, L1cal85, L1cal86, L1cal87, L1cal88, L1cal89, L1cal810;


    #region(Same as GradePrediction.aspx)
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!Page.IsPostBack)
        {
            retrivevalue();
            bindgrid();
            hideweight();
            
           
        }

    }
    protected void menuTabss_MenuItemClick(object sender, MenuEventArgs e)
    {
        switch (e.Item.Text)
        {

            case "Level-4":
                MultiView1.ActiveViewIndex = 0;
                Response.Redirect("Gradeprediction.aspx");
                break;

            case "Level-5":
                MultiView1.ActiveViewIndex = 1;
                Response.Redirect("GradepredictionLevel2.aspx");
                break;
            case "Level-6":
                MultiView1.ActiveViewIndex = 2;
                Response.Redirect("GradepredictionLevel3.aspx");
                break;

            case "Summary":
                MultiView1.ActiveViewIndex = 2;
                Response.Redirect("Summery.aspx");
                break;
        }
    }
    public void bindgrid()
    {
        string EnrollmentNo = Session["loginid"].ToString();
        int yid = 3;
        DataSet ds = Student.Moduleforgradepre(EnrollmentNo,yid);
        if (ds.Tables.Count > 0)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (i == 0)
                {
                    lblmod1.Text = ds.Tables[0].Rows[i]["ModuleName"].ToString();
                    DataSet ds1 = Student.gradeprediction(lblmod1.Text);
                    if (ds1.Tables.Count > 0)
                    {
                        for (int i1 = 0; i1 < ds1.Tables[0].Rows.Count; i1++)
                        {
                            if (i1 == 0)
                            {
                                ass1mod1.Text = ds1.Tables[0].Rows[i1]["Assesment1"].ToString();
                               

                            }
                           
                            if (i1 == 1)
                            {
                                ass2mod1.Text = ds1.Tables[0].Rows[i1]["Assesment1"].ToString();
                               

                            }
                            
                            if (i1 == 2)
                            {
                                ass3mod1.Text = ds1.Tables[0].Rows[i1]["Assesment1"].ToString();
                              

                            }
                            
                            if (i1 == 3)
                            {
                                ass4mod1.Text = ds1.Tables[0].Rows[i1]["Assesment1"].ToString();
                               

                            }
                           
                            if (i1 == 4)
                            {
                                ass5mod1.Text = ds1.Tables[0].Rows[i1]["Assesment1"].ToString();
                               

                            }
                           
                            if (i1 == 5)
                            {
                                ass6mod1.Text = ds1.Tables[0].Rows[i1]["Assesment1"].ToString();
                               

                            }
                           
                            if (i1 == 6)
                            {
                                ass7mod1.Text = ds1.Tables[0].Rows[i1]["Assesment1"].ToString();
                                

                            }
                           
                            if (i1 == 7)
                            {
                                ass8mod1.Text = ds1.Tables[0].Rows[i1]["Assesment1"].ToString();
                                

                            }
                           
                            if (i1 == 8)
                            {
                                ass9mod1.Text = ds1.Tables[0].Rows[i1]["Assesment1"].ToString();
                                

                            }
                            
                            if (i1 == 9)
                            {
                                ass10mod1.Text = ds1.Tables[0].Rows[i1]["Assesment1"].ToString();
                               

                            }
                           
                        }

                    }
                }///////////////////////////////////////////////////
                if (i == 1)
                {
                    lblmod2.Text = ds.Tables[0].Rows[i]["ModuleName"].ToString();
                    DataSet ds2 = Student.gradeprediction(lblmod2.Text);
                    if (ds2.Tables.Count > 0)
                    {
                        for (int i2 = 0; i2 < ds2.Tables[0].Rows.Count; i2++)
                        {
                            if (i2 == 0)
                            {
                                ass1mod2.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();
                               

                            }
                           
                            if (i2 == 1)
                            {
                                ass2mod2.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();
                               
                            }
                           
                            if (i2 == 2)
                            {
                                ass3mod2.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();
                               
                               
                            }
                           
                            if (i2 == 3)
                            {
                                ass4mod2.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();
                                 
                            }
                            
                            if (i2 == 4)
                            {
                                ass5mod2.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();
                              
                               
                            }
                           
                            if (i2 == 5)
                            {
                                ass6mod2.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();
                                
                            }
                            
                            if (i2 == 6)
                            {
                                ass7mod2.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();
                               
                            }
                            
                            if (i2 == 7)
                            {
                                ass8mod2.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();
                                
                            }
                            if (i2 == 8)
                            {
                                ass9mod2.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString(); 
                            }
                            
                            if (i2 == 9)
                            {
                                ass10mod2.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();
                            }
                            
                        }
                    }

                }
                if (i == 2)
                {
                    lblmod3.Text = ds.Tables[0].Rows[i]["ModuleName"].ToString();
                    DataSet ds2 = Student.gradeprediction(lblmod3.Text);
                    if (ds2.Tables.Count > 0)
                    {
                        for (int i2 = 0; i2 < ds2.Tables[0].Rows.Count; i2++)
                        {
                            if (i2 == 0)
                            {
                                ass1mod3.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();

                            }
                            if (i2 == 1)
                            {
                                ass2mod3.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();

                            }

                            if (i2 == 2)
                            {
                                ass3mod3.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();


                            }

                            if (i2 == 3)
                            {
                                ass4mod3.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();

                            }

                            if (i2 == 4)
                            {
                                ass5mod3.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();


                            }

                            if (i2 == 5)
                            {
                                ass6mod3.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();

                            }

                            if (i2 == 6)
                            {
                                ass7mod3.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();
                                
                            }

                            if (i2 == 7)
                            {
                                ass8mod3.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();

                            }
                            if (i2 == 8)
                            {
                                ass9mod3.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();
                            }

                            if (i2 == 9)
                            {
                                ass10mod3.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();
                            }

                        }
                    }
                }
                if (i == 3)
                {
                    lblmod4.Text = ds.Tables[0].Rows[i]["ModuleName"].ToString();
                    DataSet ds2 = Student.gradeprediction(lblmod4.Text);
                    if (ds2.Tables.Count > 0)
                    {
                        for (int i2 = 0; i2 < ds2.Tables[0].Rows.Count; i2++)
                        {
                            if (i2 == 0)
                            {
                                ass1mod4.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();

                            }
                            if (i2 == 1)
                            {
                                ass2mod4.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();

                            }

                            if (i2 == 2)
                            {
                                ass3mod4.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();


                            }

                            if (i2 == 3)
                            {
                                ass4mod4.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();

                            }

                            if (i2 == 4)
                            {
                                ass5mod4.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();


                            }

                            if (i2 == 5)
                            {
                                ass6mod4.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();

                            }

                            if (i2 == 6)
                            {
                                ass7mod4.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();

                            }

                            if (i2 == 7)
                            {
                                ass8mod4.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();

                            }
                            if (i2 == 8)
                            {
                                ass9mod4.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();
                            }

                            if (i2 == 9)
                            {
                                ass10mod4.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();
                            }

                        }
                    }
                }
                if (i == 4)
                {
                    lblmod5.Text = ds.Tables[0].Rows[i]["ModuleName"].ToString();
                    DataSet ds2 = Student.gradeprediction(lblmod5.Text);
                    if (ds2.Tables.Count > 0)
                    {
                        for (int i2 = 0; i2 < ds2.Tables[0].Rows.Count; i2++)
                        {
                            if (i2 == 0)
                            {
                                ass1mod5.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();

                            }
                            if (i2 == 1)
                            {
                                ass2mod5.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();

                            }

                            if (i2 == 2)
                            {
                                ass3mod5.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();


                            }

                            if (i2 == 3)
                            {
                                ass4mod5.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();

                            }

                            if (i2 == 4)
                            {
                                ass5mod5.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();


                            }

                            if (i2 == 5)
                            {
                                ass6mod5.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();

                            }

                            if (i2 == 6)
                            {
                                ass7mod5.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();

                            }

                            if (i2 == 7)
                            {
                                ass8mod5.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();

                            }
                            if (i2 == 8)
                            {
                                ass9mod5.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();
                            }

                            if (i2 == 9)
                            {
                                ass10mod5.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();
                            }

                        }
                    }
                }
                if (i == 5)
                {
                    lblmod6.Text = ds.Tables[0].Rows[i]["ModuleName"].ToString();
                    DataSet ds2 = Student.gradeprediction(lblmod6.Text);
                    if (ds2.Tables.Count > 0)
                    {
                        for (int i2 = 0; i2 < ds2.Tables[0].Rows.Count; i2++)
                        {
                            if (i2 == 0)
                            {
                                ass1mod6.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();

                            }
                            if (i2 == 1)
                            {
                                ass2mod6.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();

                            }

                            if (i2 == 2)
                            {
                                ass3mod6.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();


                            }

                            if (i2 == 3)
                            {
                                ass4mod6.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();

                            }

                            if (i2 == 4)
                            {
                                ass5mod6.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();


                            }

                            if (i2 == 5)
                            {
                                ass6mod6.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();

                            }

                            if (i2 == 6)
                            {
                                ass7mod6.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();

                            }

                            if (i2 == 7)
                            {
                                ass8mod6.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();

                            }
                            if (i2 == 8)
                            {
                                ass9mod6.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();
                            }

                            if (i2 == 9)
                            {
                                ass10mod6.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();
                            }

                        }
                    }
                }
                if (i == 6)
                {
                    lblmod7.Text = ds.Tables[0].Rows[i]["ModuleName"].ToString();
                    DataSet ds2 = Student.gradeprediction(lblmod7.Text);
                    for (int i2 = 0; i2 < ds2.Tables[0].Rows.Count; i2++)
                    {
                        if (i2 == 0)
                        {
                            ass1mod7.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();

                        }
                        if (i2 == 1)
                        {
                            ass2mod7.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();

                        }

                        if (i2 == 2)
                        {
                            ass3mod7.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();


                        }

                        if (i2 == 3)
                        {
                            ass4mod7.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();

                        }

                        if (i2 == 4)
                        {
                            ass5mod7.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();


                        }

                        if (i2 == 5)
                        {
                            ass6mod7.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();

                        }

                        if (i2 == 6)
                        {
                            ass7mod7.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();

                        }

                        if (i2 == 7)
                        {
                            ass8mod7.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();

                        }
                        if (i2 == 8)
                        {
                            ass9mod7.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();
                        }

                        if (i2 == 9)
                        {
                            ass10mod7.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();
                        }

                    }
                }
              
                if (i == 7)
                {
                    lblmod8.Text = ds.Tables[0].Rows[i]["ModuleName"].ToString();
                    DataSet ds2 = Student.gradeprediction(lblmod8.Text);
                    for (int i2 = 0; i2 < ds2.Tables[0].Rows.Count; i2++)
                    {
                        if (i2 == 0)
                        {
                            ass1mod8.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();

                        }
                        if (i2 == 1)
                        {
                            ass2mod8.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();

                        }

                        if (i2 == 2)
                        {
                            ass3mod8.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();


                        }

                        if (i2 == 3)
                        {
                            ass4mod8.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();

                        }

                        if (i2 == 4)
                        {
                            ass5mod8.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();


                        }

                        if (i2 == 5)
                        {
                            ass6mod8.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();

                        }

                        if (i2 == 6)
                        {
                            ass7mod8.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();

                        }

                        if (i2 == 7)
                        {
                            ass8mod8.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();

                        }
                        if (i2 == 8)
                        {
                            ass9mod8.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();
                        }

                        if (i2 == 9)
                        {
                            ass10mod8.Text = ds2.Tables[0].Rows[i2]["Assesment1"].ToString();
                        }

                    }
                }
            }

        }
        hidetextbox();
    }
    #region
    public void hidetextbox()
    {
        if (ass1mod1.Text != "")
        {
            txtass1mod1.Visible = true;
        }
        else
        {
            txtass1mod1.Visible = false;
        }
        if (ass2mod1.Text != "")
        {
            txtass2mod1.Visible = true;
        }
        else
        {
            txtass2mod1.Visible = false;
        }
        if (ass3mod1.Text != "")
        {
            txtass3mod1.Visible = true;
        }
        else
        {
            txtass3mod1.Visible = false;
        }
        if (ass4mod1.Text != "")
        {
            txtass4mod1.Visible = true;
        }
        else
        {
            txtass4mod1.Visible = false;
        }
        if (ass5mod1.Text != "")
        {
            txtass5mod1.Visible = true;
        }
        else
        {
            txtass5mod1.Visible = false;
        }
        if (ass6mod1.Text != "")
        {
            txtass6mod1.Visible = true;
        }
        else
        {
            txtass6mod1.Visible = false;
        }
        if (ass7mod1.Text != "")
        {
            txtass7mod1.Visible = true;
        }
        else
        {
            txtass7mod1.Visible = false;
        }
        if (ass8mod1.Text != "")
        {
            txtass8mod1.Visible = true;
        }
        else
        {
            txtass8mod1.Visible = false;
        }
        if (ass9mod1.Text != "")
        {
            txtass9mod1.Visible = true;
        }
        else
        {
            txtass9mod1.Visible = false;
        }
        if (ass10mod1.Text != "")
        {
            txtass10mod1.Visible = true;
        }
        else
        {
            txtass10mod1.Visible =false;
        }
        /////////////
        if (ass1mod2.Text != "")
        {
            txtass1mod2.Visible = true;
        }
        else
        {
            txtass1mod2.Visible = false;
        }
        if (ass2mod2.Text != "")
        {
            txtass2mod2.Visible = true;
        }
        else
        {
            txtass2mod2.Visible = false;
        }
        if (ass3mod2.Text != "")
        {
            txtass3mod2.Visible = true;
        }
        else
        {
            txtass3mod2.Visible = false;
        }
        if (ass4mod2.Text != "")
        {
            txtass4mod2.Visible = true;
        }
        else
        {
            txtass4mod2.Visible = false;
        }
        if (ass5mod2.Text != "")
        {
            txtass5mod2.Visible = true;
        }
        else
        {
            txtass5mod2.Visible = false;
        }
        if (ass6mod2.Text != "")
        {
            txtass6mod2.Visible = true;
        }
        else
        {
            txtass6mod2.Visible = false;
        }
        if (ass7mod2.Text != "")
        {
            txtass7mod2.Visible = true;
        }
        else
        {
            txtass7mod2.Visible = false;
        }
        if (ass8mod2.Text != "")
        {
            txtass8mod2.Visible = true;
        }
        else
        {
            txtass8mod2.Visible = false;
        }
        if (ass9mod2.Text != "")
        {
            txtass9mod2.Visible = true;
        }
        else
        {
            txtass9mod2.Visible = false;
        }
        if (ass10mod2.Text != "")
        {
            txtass10mod2.Visible = true;
        }
        else
        {
            txtass10mod2.Visible = false;
        }
        ////////////333
        if (ass1mod3.Text != "")
        {
            txtass1mod3.Visible = true;
        }
        else
        {
            txtass1mod3.Visible = false;
        }
        if (ass2mod3.Text != "")
        {
            txtass2mod3.Visible = true;
        }
        else
        {
            txtass2mod3.Visible = false;
        }
        if (ass3mod3.Text != "")
        {
            txtass3mod3.Visible = true;
        }
        else
        {
            txtass3mod3.Visible = false;
        }
        if (ass4mod3.Text != "")
        {
            txtass4mod3.Visible = true;
        }
        else
        {
            txtass4mod3.Visible = false;
        }
        if (ass5mod3.Text != "")
        {
            txtass5mod3.Visible = true;
        }
        else
        {
            txtass5mod3.Visible = false;
        }
        if (ass6mod3.Text != "")
        {
            txtass6mod3.Visible = true;
        }
        else
        {
            txtass6mod3.Visible = false;
        }
        if (ass7mod3.Text != "")
        {
            txtass7mod3.Visible = true;
        }
        else
        {
            txtass7mod3.Visible = false;
        }
        if (ass8mod3.Text != "")
        {
            txtass8mod3.Visible = true;
        }
        else
        {
            txtass8mod3.Visible = false;
        }
        if (ass9mod3.Text != "")
        {
            txtass9mod3.Visible = true;
        }
        else
        {
            txtass9mod3.Visible = false;
        }
        if (ass10mod3.Text != "")
        {
            txtass10mod3.Visible = true;
        }
        else
        {
            txtass10mod3.Visible = false;
        }
        ////////////////4444444

        if (ass1mod4.Text != "")
        {
            txtass1mod4.Visible = true;
        }
        else
        {
            txtass1mod4.Visible = false;
        }
        if (ass2mod4.Text != "")
        {
            txtass2mod4.Visible = true;
        }
        else
        {
            txtass2mod4.Visible = false;
        }
        if (ass3mod4.Text != "")
        {
            txtass3mod4.Visible = true;
        }
        else
        {
            txtass3mod4.Visible = false;
        }
        if (ass4mod4.Text != "")
        {
            txtass4mod4.Visible = true;
        }
        else
        {
            txtass4mod4.Visible = false;
        }
        if (ass5mod4.Text != "")
        {
            txtass5mod4.Visible = true;
        }
        else
        {
            txtass5mod4.Visible = false;
        }
        if (ass6mod4.Text != "")
        {
            txtass6mod4.Visible = true;
        }
        else
        {
            txtass6mod4.Visible = false;
        }
        if (ass7mod4.Text != "")
        {
            txtass7mod4.Visible = true;
        }
        else
        {
            txtass7mod4.Visible = false;
        }
        if (ass8mod4.Text != "")
        {
            txtass8mod4.Visible = true;
        }
        else
        {
            txtass8mod4.Visible = false;
        }
        if (ass9mod4.Text != "")
        {
            txtass9mod4.Visible = true;
        }
        else
        {
            txtass9mod4.Visible = false;
        }
        if (ass10mod4.Text != "")
        {
            txtass10mod4.Visible = true;
        }
        else
        {
            txtass10mod4.Visible = false;
        }
        //////////////5////////////////////
        if (ass1mod5.Text != "")
        {
            txtass1mod5.Visible = true;
        }
        else
        {
            txtass1mod5.Visible = false;
        }
        if (ass2mod5.Text != "")
        {
            txtass2mod5.Visible = true;
        }
        else
        {
            txtass2mod5.Visible = false;
        }
        if (ass3mod5.Text != "")
        {
            txtass3mod5.Visible = true;
        }
        else
        {
            txtass3mod5.Visible = false;
        }
        if (ass4mod5.Text != "")
        {
            txtass4mod5.Visible = true;
        }
        else
        {
            txtass4mod5.Visible = false;
        }
        if (ass5mod5.Text != "")
        {
            txtass5mod5.Visible = true;
        }
        else
        {
            txtass5mod5.Visible = false;
        }
        if (ass6mod5.Text != "")
        {
            txtass6mod5.Visible = true;
        }
        else
        {
            txtass6mod5.Visible = false;
        }
        if (ass7mod5.Text != "")
        {
            txtass7mod5.Visible = true;
        }
        else
        {
            txtass7mod5.Visible = false;
        }
        if (ass8mod5.Text != "")
        {
            txtass8mod5.Visible = true;
        }
        else
        {
            txtass8mod5.Visible = false;
        }
        if (ass9mod5.Text != "")
        {
            txtass9mod5.Visible = true;
        }
        else
        {
            txtass9mod5.Visible = false;
        }
        if (ass10mod5.Text != "")
        {
            txtass10mod5.Visible = true;
        }
        else
        {
            txtass10mod5.Visible = false;
        }
        ///////6//
        if (ass1mod6.Text != "")
        {
            txtass1mod6.Visible = true;
        }
        else
        {
            txtass1mod6.Visible = false;
        }
        if (ass2mod6.Text != "")
        {
            txtass2mod6.Visible = true;
        }
        else
        {
            txtass2mod6.Visible = false;
        }
        if (ass3mod6.Text != "")
        {
            txtass3mod6.Visible = true;
        }
        else
        {
            txtass3mod6.Visible = false;
        }
        if (ass4mod6.Text != "")
        {
            txtass4mod6.Visible = true;
        }
        else
        {
            txtass4mod6.Visible = false;
        }
        if (ass5mod6.Text != "")
        {
            txtass5mod6.Visible = true;
        }
        else
        {
            txtass5mod6.Visible = false;
        }
        if (ass6mod6.Text != "")
        {
            txtass6mod6.Visible = true;
        }
        else
        {
            txtass6mod6.Visible = false;
        }
        if (ass7mod6.Text != "")
        {
            txtass7mod6.Visible = true;
        }
        else
        {
            txtass7mod6.Visible = false;
        }
        if (ass8mod6.Text != "")
        {
            txtass8mod6.Visible = true;
        }
        else
        {
            txtass8mod6.Visible = false;
        }
        if (ass9mod6.Text != "")
        {
            txtass9mod6.Visible = true;
        }
        else
        {
            txtass9mod6.Visible = false;
        }
        if (ass10mod6.Text != "")
        {
            txtass10mod6.Visible = true;
        }
        else
        {
            txtass10mod6.Visible = false;
        }
        /////7////
        if (ass1mod7.Text != "")
        {
            txtass1mod7.Visible = true;
        }
        else
        {
            txtass1mod7.Visible = false;
        }
        if (ass2mod7.Text != "")
        {
            txtass2mod7.Visible = true;
        }
        else
        {
            txtass2mod7.Visible = false;
        }
        if (ass3mod7.Text != "")
        {
            txtass3mod7.Visible = true;
        }
        else
        {
            txtass3mod7.Visible = false;
        }
        if (ass4mod7.Text != "")
        {
            txtass4mod7.Visible = true;
        }
        else
        {
            txtass4mod7.Visible = false;
        }
        if (ass5mod7.Text != "")
        {
            txtass5mod7.Visible = true;
        }
        else
        {
            txtass5mod7.Visible = false;
        }
        if (ass6mod7.Text != "")
        {
            txtass6mod7.Visible = true;
        }
        else
        {
            txtass6mod7.Visible = false;
        }
        if (ass7mod7.Text != "")
        {
            txtass7mod7.Visible = true;
        }
        else
        {
            txtass7mod7.Visible = false;
        }
        if (ass8mod7.Text != "")
        {
            txtass8mod7.Visible = true;
        }
        else
        {
            txtass8mod7.Visible = false;
        }
        if (ass9mod7.Text != "")
        {
            txtass9mod7.Visible = true;
        }
        else
        {
            txtass9mod7.Visible = false;
        }
        if (ass10mod7.Text != "")
        {
            txtass10mod7.Visible = true;
        }
        else
        {
            txtass10mod7.Visible = false;
        }
        /////8///
        if (ass1mod8.Text != "")
        {
            txtass1mod8.Visible = true;
        }
        else
        {
            txtass1mod8.Visible = false;
        }
        if (ass2mod8.Text != "")
        {
            txtass2mod8.Visible = true;
        }
        else
        {
            txtass2mod8.Visible = false;
        }
        if (ass3mod8.Text != "")
        {
            txtass3mod8.Visible = true;
        }
        else
        {
            txtass3mod8.Visible = false;
        }
        if (ass4mod8.Text != "")
        {
            txtass4mod8.Visible = true;
        }
        else
        {
            txtass4mod8.Visible = false;
        }
        if (ass5mod8.Text != "")
        {
            txtass5mod8.Visible = true;
        }
        else
        {
            txtass5mod8.Visible = false;
        }
        if (ass6mod8.Text != "")
        {
            txtass6mod8.Visible = true;
        }
        else
        {
            txtass6mod8.Visible = false;
        }
        if (ass7mod8.Text != "")
        {
            txtass7mod8.Visible = true;
        }
        else
        {
            txtass7mod8.Visible = false;
        }
        if (ass8mod8.Text != "")
        {
            txtass8mod8.Visible = true;
        }
        else
        {
            txtass8mod8.Visible = false;
        }
        if (ass9mod8.Text != "")
        {
            txtass9mod8.Visible = true;
        }
        else
        {
            txtass9mod8.Visible = false;
        }
        if (ass10mod8.Text != "")
        {
            txtass10mod8.Visible = true;
        }
        else
        {
            txtass10mod8.Visible = false;
        }
    }
    #endregion
    protected void txtass1mod2_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt18"] = txtass8mod2.Text;

        if (ass1mod2.Text != "")
        {
            string text = ass1mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod2.Text != "")
            {
                L1cal21 = (weight * Convert.ToDouble(txtass1mod2.Text.Trim())) / 100;
            }

        }
        if (ass2mod2.Text != "")
        {
            string text = ass2mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod2.Text != "")
            {
                L1cal22 = (weight * Convert.ToDouble(txtass2mod2.Text)) / 100;
            }

        }
        if (ass3mod2.Text != "")
        {
            string text = ass3mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod2.Text != "")
            {
                L1cal23 = (weight * Convert.ToDouble(txtass3mod2.Text)) / 100;
            }

        }
        if (ass4mod2.Text != "")
        {
            string text = ass4mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod2.Text != "")
            {
                L1cal24 = (weight * Convert.ToDouble(txtass4mod2.Text)) / 100;
            }

        }
        if (ass5mod2.Text != "")
        {
            string text = ass5mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod2.Text != "")
            {
                L1cal25 = (weight * Convert.ToDouble(txtass5mod2.Text)) / 100;
            }

        }
        if (ass6mod2.Text != "")
        {
            string text = ass6mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod2.Text != "")
            {
                L1cal26 = (weight * Convert.ToDouble(txtass6mod2.Text)) / 100;
            }

        }
        if (ass7mod2.Text != "")
        {
            string text = ass7mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod2.Text != "")
            {
                L1cal27 = (weight * Convert.ToDouble(txtass7mod2.Text)) / 100;
            }

        }
        if (ass8mod2.Text != "")
        {
            string text = ass8mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod2.Text != "")
            {
                L1cal28 = (weight * Convert.ToDouble(txtass8mod2.Text)) / 100;
            }

        }
        if (ass9mod2.Text != "")
        {
            string text = ass9mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod2.Text != "")
            {
                L1cal29 = (weight * Convert.ToDouble(txtass9mod2.Text)) / 100;
            }

        }
        if (ass10mod2.Text != "")
        {
            string text = ass10mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod2.Text != "")
            {
                L1cal120 = (weight * Convert.ToDouble(txtass10mod2.Text)) / 100;
            }

        }
        TextBox23.Text = Convert.ToString(L1cal21 + L1cal22 + L1cal23 + L1cal24 + L1cal25 + L1cal26 + L1cal27 + L1cal28 + L1cal29 + L1cal120);
        Session["l3weight2"] = TextBox23.Text;
    }
    protected void txtass2mod2_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt18"] = txtass8mod2.Text;

        if (ass1mod2.Text != "")
        {
            string text = ass1mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod2.Text != "")
            {
                L1cal21 = (weight * Convert.ToDouble(txtass1mod2.Text.Trim())) / 100;
            }

        }
        if (ass2mod2.Text != "")
        {
            string text = ass2mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod2.Text != "")
            {
                L1cal22 = (weight * Convert.ToDouble(txtass2mod2.Text)) / 100;
            }

        }
        if (ass3mod2.Text != "")
        {
            string text = ass3mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod2.Text != "")
            {
                L1cal23 = (weight * Convert.ToDouble(txtass3mod2.Text)) / 100;
            }

        }
        if (ass4mod2.Text != "")
        {
            string text = ass4mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod2.Text != "")
            {
                L1cal24 = (weight * Convert.ToDouble(txtass4mod2.Text)) / 100;
            }

        }
        if (ass5mod2.Text != "")
        {
            string text = ass5mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod2.Text != "")
            {
                L1cal25 = (weight * Convert.ToDouble(txtass5mod2.Text)) / 100;
            }

        }
        if (ass6mod2.Text != "")
        {
            string text = ass6mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod2.Text != "")
            {
                L1cal26 = (weight * Convert.ToDouble(txtass6mod2.Text)) / 100;
            }

        }
        if (ass7mod2.Text != "")
        {
            string text = ass7mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod2.Text != "")
            {
                L1cal27 = (weight * Convert.ToDouble(txtass7mod2.Text)) / 100;
            }

        }
        if (ass8mod2.Text != "")
        {
            string text = ass8mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod2.Text != "")
            {
                L1cal28 = (weight * Convert.ToDouble(txtass8mod2.Text)) / 100;
            }

        }
        if (ass9mod2.Text != "")
        {
            string text = ass9mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod2.Text != "")
            {
                L1cal29 = (weight * Convert.ToDouble(txtass9mod2.Text)) / 100;
            }

        }
        if (ass10mod2.Text != "")
        {
            string text = ass10mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod2.Text != "")
            {
                L1cal120 = (weight * Convert.ToDouble(txtass10mod2.Text)) / 100;
            }

        }
        TextBox23.Text = Convert.ToString(L1cal21 + L1cal22 + L1cal23 + L1cal24 + L1cal25 + L1cal26 + L1cal27 + L1cal28 + L1cal29 + L1cal120);
        Session["l3weight2"] = TextBox23.Text;
    }
    protected void txtass3mod2_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt18"] = txtass8mod2.Text;

        if (ass1mod2.Text != "")
        {
            string text = ass1mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod2.Text != "")
            {
                L1cal21 = (weight * Convert.ToDouble(txtass1mod2.Text.Trim())) / 100;
            }

        }
        if (ass2mod2.Text != "")
        {
            string text = ass2mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod2.Text != "")
            {
                L1cal22 = (weight * Convert.ToDouble(txtass2mod2.Text)) / 100;
            }

        }
        if (ass3mod2.Text != "")
        {
            string text = ass3mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod2.Text != "")
            {
                L1cal23 = (weight * Convert.ToDouble(txtass3mod2.Text)) / 100;
            }

        }
        if (ass4mod2.Text != "")
        {
            string text = ass4mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod2.Text != "")
            {
                L1cal24 = (weight * Convert.ToDouble(txtass4mod2.Text)) / 100;
            }

        }
        if (ass5mod2.Text != "")
        {
            string text = ass5mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod2.Text != "")
            {
                L1cal25 = (weight * Convert.ToDouble(txtass5mod2.Text)) / 100;
            }

        }
        if (ass6mod2.Text != "")
        {
            string text = ass6mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod2.Text != "")
            {
                L1cal26 = (weight * Convert.ToDouble(txtass6mod2.Text)) / 100;
            }

        }
        if (ass7mod2.Text != "")
        {
            string text = ass7mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod2.Text != "")
            {
                L1cal27 = (weight * Convert.ToDouble(txtass7mod2.Text)) / 100;
            }

        }
        if (ass8mod2.Text != "")
        {
            string text = ass8mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod2.Text != "")
            {
                L1cal28 = (weight * Convert.ToDouble(txtass8mod2.Text)) / 100;
            }

        }
        if (ass9mod2.Text != "")
        {
            string text = ass9mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod2.Text != "")
            {
                L1cal29 = (weight * Convert.ToDouble(txtass9mod2.Text)) / 100;
            }

        }
        if (ass10mod2.Text != "")
        {
            string text = ass10mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod2.Text != "")
            {
                L1cal120 = (weight * Convert.ToDouble(txtass10mod2.Text)) / 100;
            }

        }
        TextBox23.Text = Convert.ToString(L1cal21 + L1cal22 + L1cal23 + L1cal24 + L1cal25 + L1cal26 + L1cal27 + L1cal28 + L1cal29 + L1cal120);
        Session["l3weight2"] = TextBox23.Text;
    }
    protected void txtass4mod2_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt18"] = txtass8mod2.Text;

        if (ass1mod2.Text != "")
        {
            string text = ass1mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod2.Text != "")
            {
                L1cal21 = (weight * Convert.ToDouble(txtass1mod2.Text.Trim())) / 100;
            }

        }
        if (ass2mod2.Text != "")
        {
            string text = ass2mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod2.Text != "")
            {
                L1cal22 = (weight * Convert.ToDouble(txtass2mod2.Text)) / 100;
            }

        }
        if (ass3mod2.Text != "")
        {
            string text = ass3mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod2.Text != "")
            {
                L1cal23 = (weight * Convert.ToDouble(txtass3mod2.Text)) / 100;
            }

        }
        if (ass4mod2.Text != "")
        {
            string text = ass4mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod2.Text != "")
            {
                L1cal24 = (weight * Convert.ToDouble(txtass4mod2.Text)) / 100;
            }

        }
        if (ass5mod2.Text != "")
        {
            string text = ass5mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod2.Text != "")
            {
                L1cal25 = (weight * Convert.ToDouble(txtass5mod2.Text)) / 100;
            }

        }
        if (ass6mod2.Text != "")
        {
            string text = ass6mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod2.Text != "")
            {
                L1cal26 = (weight * Convert.ToDouble(txtass6mod2.Text)) / 100;
            }

        }
        if (ass7mod2.Text != "")
        {
            string text = ass7mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod2.Text != "")
            {
                L1cal27 = (weight * Convert.ToDouble(txtass7mod2.Text)) / 100;
            }

        }
        if (ass8mod2.Text != "")
        {
            string text = ass8mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod2.Text != "")
            {
                L1cal28 = (weight * Convert.ToDouble(txtass8mod2.Text)) / 100;
            }

        }
        if (ass9mod2.Text != "")
        {
            string text = ass9mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod2.Text != "")
            {
                L1cal29 = (weight * Convert.ToDouble(txtass9mod2.Text)) / 100;
            }

        }
        if (ass10mod2.Text != "")
        {
            string text = ass10mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod2.Text != "")
            {
                L1cal120 = (weight * Convert.ToDouble(txtass10mod2.Text)) / 100;
            }

        }
        TextBox23.Text = Convert.ToString(L1cal21 + L1cal22 + L1cal23 + L1cal24 + L1cal25 + L1cal26 + L1cal27 + L1cal28 + L1cal29 + L1cal120);
        Session["l3weight2"] = TextBox23.Text;
    }
    protected void txtass5mod2_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt18"] = txtass8mod2.Text;

        if (ass1mod2.Text != "")
        {
            string text = ass1mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod2.Text != "")
            {
                L1cal21 = (weight * Convert.ToDouble(txtass1mod2.Text.Trim())) / 100;
            }

        }
        if (ass2mod2.Text != "")
        {
            string text = ass2mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod2.Text != "")
            {
                L1cal22 = (weight * Convert.ToDouble(txtass2mod2.Text)) / 100;
            }

        }
        if (ass3mod2.Text != "")
        {
            string text = ass3mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod2.Text != "")
            {
                L1cal23 = (weight * Convert.ToDouble(txtass3mod2.Text)) / 100;
            }

        }
        if (ass4mod2.Text != "")
        {
            string text = ass4mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod2.Text != "")
            {
                L1cal24 = (weight * Convert.ToDouble(txtass4mod2.Text)) / 100;
            }

        }
        if (ass5mod2.Text != "")
        {
            string text = ass5mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod2.Text != "")
            {
                L1cal25 = (weight * Convert.ToDouble(txtass5mod2.Text)) / 100;
            }

        }
        if (ass6mod2.Text != "")
        {
            string text = ass6mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod2.Text != "")
            {
                L1cal26 = (weight * Convert.ToDouble(txtass6mod2.Text)) / 100;
            }

        }
        if (ass7mod2.Text != "")
        {
            string text = ass7mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod2.Text != "")
            {
                L1cal27 = (weight * Convert.ToDouble(txtass7mod2.Text)) / 100;
            }

        }
        if (ass8mod2.Text != "")
        {
            string text = ass8mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod2.Text != "")
            {
                L1cal28 = (weight * Convert.ToDouble(txtass8mod2.Text)) / 100;
            }

        }
        if (ass9mod2.Text != "")
        {
            string text = ass9mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod2.Text != "")
            {
                L1cal29 = (weight * Convert.ToDouble(txtass9mod2.Text)) / 100;
            }

        }
        if (ass10mod2.Text != "")
        {
            string text = ass10mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod2.Text != "")
            {
                L1cal120 = (weight * Convert.ToDouble(txtass10mod2.Text)) / 100;
            }

        }
        TextBox23.Text = Convert.ToString(L1cal21 + L1cal22 + L1cal23 + L1cal24 + L1cal25 + L1cal26 + L1cal27 + L1cal28 + L1cal29 + L1cal120);
        Session["l3weight2"] = TextBox23.Text;     
    }
    protected void txtass6mod2_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt18"] = txtass8mod2.Text;

        if (ass1mod2.Text != "")
        {
            string text = ass1mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod2.Text != "")
            {
                L1cal21 = (weight * Convert.ToDouble(txtass1mod2.Text.Trim())) / 100;
            }

        }
        if (ass2mod2.Text != "")
        {
            string text = ass2mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod2.Text != "")
            {
                L1cal22 = (weight * Convert.ToDouble(txtass2mod2.Text)) / 100;
            }

        }
        if (ass3mod2.Text != "")
        {
            string text = ass3mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod2.Text != "")
            {
                L1cal23 = (weight * Convert.ToDouble(txtass3mod2.Text)) / 100;
            }

        }
        if (ass4mod2.Text != "")
        {
            string text = ass4mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod2.Text != "")
            {
                L1cal24 = (weight * Convert.ToDouble(txtass4mod2.Text)) / 100;
            }

        }
        if (ass5mod2.Text != "")
        {
            string text = ass5mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod2.Text != "")
            {
                L1cal25 = (weight * Convert.ToDouble(txtass5mod2.Text)) / 100;
            }

        }
        if (ass6mod2.Text != "")
        {
            string text = ass6mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod2.Text != "")
            {
                L1cal26 = (weight * Convert.ToDouble(txtass6mod2.Text)) / 100;
            }

        }
        if (ass7mod2.Text != "")
        {
            string text = ass7mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod2.Text != "")
            {
                L1cal27 = (weight * Convert.ToDouble(txtass7mod2.Text)) / 100;
            }

        }
        if (ass8mod2.Text != "")
        {
            string text = ass8mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod2.Text != "")
            {
                L1cal28 = (weight * Convert.ToDouble(txtass8mod2.Text)) / 100;
            }

        }
        if (ass9mod2.Text != "")
        {
            string text = ass9mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod2.Text != "")
            {
                L1cal29 = (weight * Convert.ToDouble(txtass9mod2.Text)) / 100;
            }

        }
        if (ass10mod2.Text != "")
        {
            string text = ass10mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod2.Text != "")
            {
                L1cal120 = (weight * Convert.ToDouble(txtass10mod2.Text)) / 100;
            }

        }
        TextBox23.Text = Convert.ToString(L1cal21 + L1cal22 + L1cal23 + L1cal24 + L1cal25 + L1cal26 + L1cal27 + L1cal28 + L1cal29 + L1cal120);
        Session["l3weight2"] = TextBox23.Text;
    }
    protected void txtass7mod2_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt18"] = txtass8mod2.Text;

        if (ass1mod2.Text != "")
        {
            string text = ass1mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod2.Text != "")
            {
                L1cal21 = (weight * Convert.ToDouble(txtass1mod2.Text.Trim())) / 100;
            }

        }
        if (ass2mod2.Text != "")
        {
            string text = ass2mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod2.Text != "")
            {
                L1cal22 = (weight * Convert.ToDouble(txtass2mod2.Text)) / 100;
            }

        }
        if (ass3mod2.Text != "")
        {
            string text = ass3mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod2.Text != "")
            {
                L1cal23 = (weight * Convert.ToDouble(txtass3mod2.Text)) / 100;
            }

        }
        if (ass4mod2.Text != "")
        {
            string text = ass4mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod2.Text != "")
            {
                L1cal24 = (weight * Convert.ToDouble(txtass4mod2.Text)) / 100;
            }

        }
        if (ass5mod2.Text != "")
        {
            string text = ass5mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod2.Text != "")
            {
                L1cal25 = (weight * Convert.ToDouble(txtass5mod2.Text)) / 100;
            }

        }
        if (ass6mod2.Text != "")
        {
            string text = ass6mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod2.Text != "")
            {
                L1cal26 = (weight * Convert.ToDouble(txtass6mod2.Text)) / 100;
            }

        }
        if (ass7mod2.Text != "")
        {
            string text = ass7mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod2.Text != "")
            {
                L1cal27 = (weight * Convert.ToDouble(txtass7mod2.Text)) / 100;
            }

        }
        if (ass8mod2.Text != "")
        {
            string text = ass8mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod2.Text != "")
            {
                L1cal28 = (weight * Convert.ToDouble(txtass8mod2.Text)) / 100;
            }

        }
        if (ass9mod2.Text != "")
        {
            string text = ass9mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod2.Text != "")
            {
                L1cal29 = (weight * Convert.ToDouble(txtass9mod2.Text)) / 100;
            }

        }
        if (ass10mod2.Text != "")
        {
            string text = ass10mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod2.Text != "")
            {
                L1cal120 = (weight * Convert.ToDouble(txtass10mod2.Text)) / 100;
            }

        }
        TextBox23.Text = Convert.ToString(L1cal21 + L1cal22 + L1cal23 + L1cal24 + L1cal25 + L1cal26 + L1cal27 + L1cal28 + L1cal29 + L1cal120);
        Session["l3weight2"] = TextBox23.Text;
    }
    protected void txtass1mod3_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt21"] = txtass1mod3.Text;
        
        if (ass1mod3.Text != "")
        {
            string text = ass1mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod3.Text != "")
            {
                L1cal31 = (weight * Convert.ToDouble(txtass1mod3.Text.Trim())) / 100;
            }

        }
        if (ass2mod3.Text != "")
        {
            string text = ass2mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod3.Text != "")
            {
                L1cal32 = (weight * Convert.ToDouble(txtass2mod3.Text)) / 100;
            }

        }
        if (ass3mod3.Text != "")
        {
            string text = ass3mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod3.Text != "")
            {
                L1cal33 = (weight * Convert.ToDouble(txtass3mod3.Text)) / 100;
            }

        }
        if (ass4mod3.Text != "")
        {
            string text = ass4mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod3.Text != "")
            {
                L1cal34 = (weight * Convert.ToDouble(txtass4mod3.Text)) / 100;
            }

        }
        if (ass5mod3.Text != "")
        {
            string text = ass5mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod3.Text != "")
            {
                L1cal35 = (weight * Convert.ToDouble(txtass5mod3.Text)) / 100;
            }

        }
        if (ass6mod3.Text != "")
        {
            string text = ass6mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod3.Text != "")
            {
                L1cal36 = (weight * Convert.ToDouble(txtass6mod3.Text)) / 100;
            }

        }
        if (ass7mod3.Text != "")
        {
            string text = ass7mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod3.Text != "")
            {
                L1cal37 = (weight * Convert.ToDouble(txtass7mod3.Text)) / 100;
            }

        }
        if (ass8mod3.Text != "")
        {
            string text = ass8mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod3.Text != "")
            {
                L1cal38 = (weight * Convert.ToDouble(txtass8mod3.Text)) / 100;
            }

        }
        if (ass9mod3.Text != "")
        {
            string text = ass9mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod3.Text != "")
            {
                L1cal39 = (weight * Convert.ToDouble(txtass9mod3.Text)) / 100;
            }

        }
        if (ass10mod3.Text != "")
        {
            string text = ass10mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod3.Text != "")
            {
                L1cal310 = (weight * Convert.ToDouble(txtass10mod3.Text)) / 100;
            }

        }
        TextBox34.Text = Convert.ToString(L1cal31 + L1cal32 + L1cal33 + L1cal34 + L1cal35 + L1cal36 + L1cal37 + L1cal38 + L1cal39 + L1cal310);
        Session["l3weight3"] = TextBox34.Text;
    }
    protected void txtass10mod1_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt10"] = txtass10mod1.Text;
        
        if (ass1mod1.Text != "")
        {
            string text = ass1mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod1.Text != "")
            {
                L1cal11 = (weight * Convert.ToDouble(txtass1mod1.Text.Trim())) / 100;
            }

        }
        if (ass2mod1.Text != "")
        {
            string text = ass2mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod1.Text != "")
            {
                L1cal12 = (weight * Convert.ToDouble(txtass2mod1.Text)) / 100;
            }

        }
        if (ass3mod1.Text != "")
        {
            string text = ass3mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod1.Text != "")
            {
                L1cal13 = (weight * Convert.ToDouble(txtass3mod1.Text)) / 100;
            }

        }
        if (ass4mod1.Text != "")
        {
            string text = ass4mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod1.Text != "")
            {
                L1cal14 = (weight * Convert.ToDouble(txtass4mod1.Text)) / 100;
            }

        }
        if (ass5mod1.Text != "")
        {
            string text = ass5mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod1.Text != "")
            {
                L1cal15 = (weight * Convert.ToDouble(txtass5mod1.Text)) / 100;
            }

        }
        if (ass6mod1.Text != "")
        {
            string text = ass6mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod1.Text != "")
            {
                L1cal16 = (weight * Convert.ToDouble(txtass6mod1.Text)) / 100;
            }

        }
        if (ass7mod1.Text != "")
        {
            string text = ass7mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod1.Text != "")
            {
                L1cal17 = (weight * Convert.ToDouble(txtass7mod1.Text)) / 100;
            }

        }
        if (ass8mod1.Text != "")
        {
            string text = ass8mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod1.Text != "")
            {
                L1cal18 = (weight * Convert.ToDouble(txtass8mod1.Text)) / 100;
            }

        }
        if (ass9mod1.Text != "")
        {
            string text = ass9mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod1.Text != "")
            {
                L1cal19 = (weight * Convert.ToDouble(txtass9mod1.Text)) / 100;
            }

        }
        if (ass10mod1.Text != "")
        {
            string text = ass10mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod1.Text != "")
            {
                L1cal110 = (weight * Convert.ToDouble(txtass10mod1.Text)) / 100;
            }

        }
        TextBox12.Text = Convert.ToString(L1cal11 + L1cal12 + L1cal13 + L1cal14 + L1cal15 + L1cal16 + L1cal17 + L1cal18 + L1cal19 + L1cal110);
        Session["l3weight1"] = TextBox12.Text;
    }
    protected void txtass1mod1_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt1"] = txtass1mod1.Text;
       
        if (ass1mod1.Text != "")
        {
            string text = ass1mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod1.Text != "")
            {
                L1cal11 = (weight * Convert.ToDouble(txtass1mod1.Text.Trim())) / 100;
               
            }
          
        }
        if (ass2mod1.Text != "")
        {
            string text = ass2mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod1.Text != "")
            {
                L1cal12 = (weight * Convert.ToDouble(txtass2mod1.Text)) / 100;
            }
          
        }
        if (ass3mod1.Text != "")
        {
            string text = ass3mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod1.Text != "")
            {
                L1cal13 = (weight * Convert.ToDouble(txtass3mod1.Text)) / 100;
            }

        }
        if (ass4mod1.Text != "")
        {
            string text = ass4mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod1.Text != "")
            {
                L1cal14 = (weight * Convert.ToDouble(txtass4mod1.Text)) / 100;
            }

        }
        if (ass5mod1.Text != "")
        {
            string text = ass5mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod1.Text != "")
            {
                L1cal15 = (weight * Convert.ToDouble(txtass5mod1.Text)) / 100;
            }

        }
        if (ass6mod1.Text != "")
        {
            string text = ass6mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod1.Text != "")
            {
                L1cal16 = (weight * Convert.ToDouble(txtass6mod1.Text)) / 100;
            }

        }
        if (ass7mod1.Text != "")
        {
            string text = ass7mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod1.Text != "")
            {
                L1cal17 = (weight * Convert.ToDouble(txtass7mod1.Text)) / 100;
            }

        }
        if (ass8mod1.Text != "")
        {
            string text = ass8mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod1.Text != "")
            {
                L1cal18 = (weight * Convert.ToDouble(txtass8mod1.Text)) / 100;
            }

        }
        if (ass9mod1.Text != "")
        {
            string text = ass9mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod1.Text != "")
            {
                L1cal19 = (weight * Convert.ToDouble(txtass9mod1.Text)) / 100;
            }

        }
        if (ass10mod1.Text != "")
        {
            string text = ass10mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod1.Text != "")
            {
                L1cal110 = (weight * Convert.ToDouble(txtass10mod1.Text)) / 100;
            }

        }
        TextBox12.Text = Convert.ToString(L1cal11 + L1cal12 + L1cal13 + L1cal14 + L1cal15 + L1cal16 + L1cal17 + L1cal18 + L1cal19 + L1cal110);
        Session["l3weight1"] = TextBox12.Text;
    }
    protected void txtass2mod1_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt2"] = txtass2mod1.Text;
        
       
        if (ass1mod1.Text != "")
        {
            string text = ass1mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod1.Text != "")
            {
                L1cal11 = (weight * Convert.ToDouble(txtass1mod1.Text.Trim())) / 100;
            }

        }
        if (ass2mod1.Text != "")
        {
            string text = ass2mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod1.Text != "")
            {
                L1cal12 = (weight * Convert.ToDouble(txtass2mod1.Text)) / 100;
            }

        }
        if (ass3mod1.Text != "")
        {
            string text = ass3mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod1.Text != "")
            {
                L1cal13 = (weight * Convert.ToDouble(txtass3mod1.Text)) / 100;
            }

        }
        if (ass4mod1.Text != "")
        {
            string text = ass4mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod1.Text != "")
            {
                L1cal14 = (weight * Convert.ToDouble(txtass4mod1.Text)) / 100;
            }

        }
        if (ass5mod1.Text != "")
        {
            string text = ass5mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod1.Text != "")
            {
                L1cal15 = (weight * Convert.ToDouble(txtass5mod1.Text)) / 100;
            }

        }
        if (ass6mod1.Text != "")
        {
            string text = ass6mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod1.Text != "")
            {
                L1cal16 = (weight * Convert.ToDouble(txtass6mod1.Text)) / 100;
            }

        }
        if (ass7mod1.Text != "")
        {
            string text = ass7mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod1.Text != "")
            {
                L1cal17 = (weight * Convert.ToDouble(txtass7mod1.Text)) / 100;
            }

        }
        if (ass8mod1.Text != "")
        {
            string text = ass8mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod1.Text != "")
            {
                L1cal18 = (weight * Convert.ToDouble(txtass8mod1.Text)) / 100;
            }

        }
        if (ass9mod1.Text != "")
        {
            string text = ass9mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod1.Text != "")
            {
                L1cal19 = (weight * Convert.ToDouble(txtass9mod1.Text)) / 100;
            }

        }
        if (ass10mod1.Text != "")
        {
            string text = ass10mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod1.Text != "")
            {
                L1cal110 = (weight * Convert.ToDouble(txtass10mod1.Text)) / 100;
            }

        }
        TextBox12.Text = Convert.ToString(L1cal11 + L1cal12 + L1cal13 + L1cal14 + L1cal15 + L1cal16 + L1cal17 + L1cal18 + L1cal19 + L1cal110);
        Session["l3weight1"] = TextBox12.Text;
    }

    protected void txtass3mod1_TextChanged(object sender, EventArgs e)
    {
       
        Session["l3txt3"] = txtass3mod1.Text;
       
        if (ass1mod1.Text != "")
        {
            string text = ass1mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod1.Text != "")
            {
                L1cal11 = (weight * Convert.ToDouble(txtass1mod1.Text.Trim())) / 100;
            }

        }
        if (ass2mod1.Text != "")
        {
            string text = ass2mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod1.Text != "")
            {
                L1cal12 = (weight * Convert.ToDouble(txtass2mod1.Text)) / 100;
            }

        }
        if (ass3mod1.Text != "")
        {
            string text = ass3mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod1.Text != "")
            {
                L1cal13 = (weight * Convert.ToDouble(txtass3mod1.Text)) / 100;
            }

        }
        if (ass4mod1.Text != "")
        {
            string text = ass4mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod1.Text != "")
            {
                L1cal14 = (weight * Convert.ToDouble(txtass4mod1.Text)) / 100;
            }

        }
        if (ass5mod1.Text != "")
        {
            string text = ass5mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod1.Text != "")
            {
                L1cal15 = (weight * Convert.ToDouble(txtass5mod1.Text)) / 100;
            }

        }
        if (ass6mod1.Text != "")
        {
            string text = ass6mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod1.Text != "")
            {
                L1cal16 = (weight * Convert.ToDouble(txtass6mod1.Text)) / 100;
            }

        }
        if (ass7mod1.Text != "")
        {
            string text = ass7mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod1.Text != "")
            {
                L1cal17 = (weight * Convert.ToDouble(txtass7mod1.Text)) / 100;
            }

        }
        if (ass8mod1.Text != "")
        {
            string text = ass8mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod1.Text != "")
            {
                L1cal18 = (weight * Convert.ToDouble(txtass8mod1.Text)) / 100;
            }

        }
        if (ass9mod1.Text != "")
        {
            string text = ass9mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod1.Text != "")
            {
                L1cal19 = (weight * Convert.ToDouble(txtass9mod1.Text)) / 100;
            }

        }
        if (ass10mod1.Text != "")
        {
            string text = ass10mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod1.Text != "")
            {
                L1cal110 = (weight * Convert.ToDouble(txtass10mod1.Text)) / 100;
            }

        }
        TextBox12.Text = Convert.ToString(L1cal11 + L1cal12 + L1cal13 + L1cal14 + L1cal15 + L1cal16 + L1cal17 + L1cal18 + L1cal19 + L1cal110);
        Session["l3weight1"] = TextBox12.Text;
    }
    protected void txtass4mod1_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt4"] = txtass4mod1.Text;
       
        if (ass1mod1.Text != "")
        {
            string text = ass1mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod1.Text != "")
            {
                L1cal11 = (weight * Convert.ToDouble(txtass1mod1.Text.Trim())) / 100;
            }

        }
        if (ass2mod1.Text != "")
        {
            string text = ass2mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod1.Text != "")
            {
                L1cal12 = (weight * Convert.ToDouble(txtass2mod1.Text)) / 100;
            }

        }
        if (ass3mod1.Text != "")
        {
            string text = ass3mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod1.Text != "")
            {
                L1cal13 = (weight * Convert.ToDouble(txtass3mod1.Text)) / 100;
            }

        }
        if (ass4mod1.Text != "")
        {
            string text = ass4mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod1.Text != "")
            {
                L1cal14 = (weight * Convert.ToDouble(txtass4mod1.Text)) / 100;
            }

        }
        if (ass5mod1.Text != "")
        {
            string text = ass5mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod1.Text != "")
            {
                L1cal15 = (weight * Convert.ToDouble(txtass5mod1.Text)) / 100;
            }

        }
        if (ass6mod1.Text != "")
        {
            string text = ass6mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod1.Text != "")
            {
                L1cal16 = (weight * Convert.ToDouble(txtass6mod1.Text)) / 100;
            }

        }
        if (ass7mod1.Text != "")
        {
            string text = ass7mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod1.Text != "")
            {
                L1cal17 = (weight * Convert.ToDouble(txtass7mod1.Text)) / 100;
            }

        }
        if (ass8mod1.Text != "")
        {
            string text = ass8mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod1.Text != "")
            {
                L1cal18 = (weight * Convert.ToDouble(txtass8mod1.Text)) / 100;
            }

        }
        if (ass9mod1.Text != "")
        {
            string text = ass9mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod1.Text != "")
            {
                L1cal19 = (weight * Convert.ToDouble(txtass9mod1.Text)) / 100;
            }

        }
        if (ass10mod1.Text != "")
        {
            string text = ass10mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod1.Text != "")
            {
                L1cal110 = (weight * Convert.ToDouble(txtass10mod1.Text)) / 100;
            }

        }
        TextBox12.Text = Convert.ToString(L1cal11 + L1cal12 + L1cal13 + L1cal14 + L1cal15 + L1cal16 + L1cal17 + L1cal18 + L1cal19 + L1cal110);
        Session["l3weight1"] = TextBox12.Text;
    }
    protected void txtass5mod1_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt5"] = txtass5mod1.Text;
      
        if (ass1mod1.Text != "")
        {
            string text = ass1mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod1.Text != "")
            {
                L1cal11 = (weight * Convert.ToDouble(txtass1mod1.Text.Trim())) / 100;
            }

        }
        if (ass2mod1.Text != "")
        {
            string text = ass2mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod1.Text != "")
            {
                L1cal12 = (weight * Convert.ToDouble(txtass2mod1.Text)) / 100;
            }

        }
        if (ass3mod1.Text != "")
        {
            string text = ass3mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod1.Text != "")
            {
                L1cal13 = (weight * Convert.ToDouble(txtass3mod1.Text)) / 100;
            }

        }
        if (ass4mod1.Text != "")
        {
            string text = ass4mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod1.Text != "")
            {
                L1cal14 = (weight * Convert.ToDouble(txtass4mod1.Text)) / 100;
            }

        }
        if (ass5mod1.Text != "")
        {
            string text = ass5mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod1.Text != "")
            {
                L1cal15 = (weight * Convert.ToDouble(txtass5mod1.Text)) / 100;
            }

        }
        if (ass6mod1.Text != "")
        {
            string text = ass6mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod1.Text != "")
            {
                L1cal16 = (weight * Convert.ToDouble(txtass6mod1.Text)) / 100;
            }

        }
        if (ass7mod1.Text != "")
        {
            string text = ass7mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod1.Text != "")
            {
                L1cal17 = (weight * Convert.ToDouble(txtass7mod1.Text)) / 100;
            }

        }
        if (ass8mod1.Text != "")
        {
            string text = ass8mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod1.Text != "")
            {
                L1cal18 = (weight * Convert.ToDouble(txtass8mod1.Text)) / 100;
            }

        }
        if (ass9mod1.Text != "")
        {
            string text = ass9mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod1.Text != "")
            {
                L1cal19 = (weight * Convert.ToDouble(txtass9mod1.Text)) / 100;
            }

        }
        if (ass10mod1.Text != "")
        {
            string text = ass10mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod1.Text != "")
            {
                L1cal110 = (weight * Convert.ToDouble(txtass10mod1.Text)) / 100;
            }

        }
        TextBox12.Text = Convert.ToString(L1cal11 + L1cal12 + L1cal13 + L1cal14 + L1cal15 + L1cal16 + L1cal17 + L1cal18 + L1cal19 + L1cal110);
        Session["l3weight1"] = TextBox12.Text;
    }
    protected void txtass6mod1_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt6"] = txtass6mod1.Text;
      
        if (ass1mod1.Text != "")
        {
            string text = ass1mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod1.Text != "")
            {
                L1cal11 = (weight * Convert.ToDouble(txtass1mod1.Text.Trim())) / 100;
            }

        }
        if (ass2mod1.Text != "")
        {
            string text = ass2mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod1.Text != "")
            {
                L1cal12 = (weight * Convert.ToDouble(txtass2mod1.Text)) / 100;
            }

        }
        if (ass3mod1.Text != "")
        {
            string text = ass3mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod1.Text != "")
            {
                L1cal13 = (weight * Convert.ToDouble(txtass3mod1.Text)) / 100;
            }

        }
        if (ass4mod1.Text != "")
        {
            string text = ass4mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod1.Text != "")
            {
                L1cal14 = (weight * Convert.ToDouble(txtass4mod1.Text)) / 100;
            }

        }
        if (ass5mod1.Text != "")
        {
            string text = ass5mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod1.Text != "")
            {
                L1cal15 = (weight * Convert.ToDouble(txtass5mod1.Text)) / 100;
            }

        }
        if (ass6mod1.Text != "")
        {
            string text = ass6mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod1.Text != "")
            {
                L1cal16 = (weight * Convert.ToDouble(txtass6mod1.Text)) / 100;
            }

        }
        if (ass7mod1.Text != "")
        {
            string text = ass7mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod1.Text != "")
            {
                L1cal17 = (weight * Convert.ToDouble(txtass7mod1.Text)) / 100;
            }

        }
        if (ass8mod1.Text != "")
        {
            string text = ass8mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod1.Text != "")
            {
                L1cal18 = (weight * Convert.ToDouble(txtass8mod1.Text)) / 100;
            }

        }
        if (ass9mod1.Text != "")
        {
            string text = ass9mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod1.Text != "")
            {
                L1cal19 = (weight * Convert.ToDouble(txtass9mod1.Text)) / 100;
            }

        }
        if (ass10mod1.Text != "")
        {
            string text = ass10mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod1.Text != "")
            {
                L1cal110 = (weight * Convert.ToDouble(txtass10mod1.Text)) / 100;
            }

        }
        TextBox12.Text = Convert.ToString(L1cal11 + L1cal12 + L1cal13 + L1cal14 + L1cal15 + L1cal16 + L1cal17 + L1cal18 + L1cal19 + L1cal110);
        Session["l3weight1"] = TextBox12.Text;
    }
    protected void txtass7mod1_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt7"] = txtass7mod1.Text;
       
        if (ass1mod1.Text != "")
        {
            string text = ass1mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod1.Text != "")
            {
                L1cal11 = (weight * Convert.ToDouble(txtass1mod1.Text.Trim())) / 100;
            }

        }
        if (ass2mod1.Text != "")
        {
            string text = ass2mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod1.Text != "")
            {
                L1cal12 = (weight * Convert.ToDouble(txtass2mod1.Text)) / 100;
            }

        }
        if (ass3mod1.Text != "")
        {
            string text = ass3mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod1.Text != "")
            {
                L1cal13 = (weight * Convert.ToDouble(txtass3mod1.Text)) / 100;
            }

        }
        if (ass4mod1.Text != "")
        {
            string text = ass4mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod1.Text != "")
            {
                L1cal14 = (weight * Convert.ToDouble(txtass4mod1.Text)) / 100;
            }

        }
        if (ass5mod1.Text != "")
        {
            string text = ass5mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod1.Text != "")
            {
                L1cal15 = (weight * Convert.ToDouble(txtass5mod1.Text)) / 100;
            }

        }
        if (ass6mod1.Text != "")
        {
            string text = ass6mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod1.Text != "")
            {
                L1cal16 = (weight * Convert.ToDouble(txtass6mod1.Text)) / 100;
            }

        }
        if (ass7mod1.Text != "")
        {
            string text = ass7mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod1.Text != "")
            {
                L1cal17 = (weight * Convert.ToDouble(txtass7mod1.Text)) / 100;
            }

        }
        if (ass8mod1.Text != "")
        {
            string text = ass8mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod1.Text != "")
            {
                L1cal18 = (weight * Convert.ToDouble(txtass8mod1.Text)) / 100;
            }

        }
        if (ass9mod1.Text != "")
        {
            string text = ass9mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod1.Text != "")
            {
                L1cal19 = (weight * Convert.ToDouble(txtass9mod1.Text)) / 100;
            }

        }
        if (ass10mod1.Text != "")
        {
            string text = ass10mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod1.Text != "")
            {
                L1cal110 = (weight * Convert.ToDouble(txtass10mod1.Text)) / 100;
            }

        }
        TextBox12.Text = Convert.ToString(L1cal11 + L1cal12 + L1cal13 + L1cal14 + L1cal15 + L1cal16 + L1cal17 + L1cal18 + L1cal19 + L1cal110);
        Session["l3weight1"] = TextBox12.Text;
    }
    protected void txtass8mod1_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt8"] = txtass8mod1.Text;
       
        if (ass1mod1.Text != "")
        {
            string text = ass1mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod1.Text != "")
            {
                L1cal11 = (weight * Convert.ToDouble(txtass1mod1.Text.Trim())) / 100;
            }

        }
        if (ass2mod1.Text != "")
        {
            string text = ass2mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod1.Text != "")
            {
                L1cal12 = (weight * Convert.ToDouble(txtass2mod1.Text)) / 100;
            }

        }
        if (ass3mod1.Text != "")
        {
            string text = ass3mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod1.Text != "")
            {
                L1cal13 = (weight * Convert.ToDouble(txtass3mod1.Text)) / 100;
            }

        }
        if (ass4mod1.Text != "")
        {
            string text = ass4mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod1.Text != "")
            {
                L1cal14 = (weight * Convert.ToDouble(txtass4mod1.Text)) / 100;
            }

        }
        if (ass5mod1.Text != "")
        {
            string text = ass5mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod1.Text != "")
            {
                L1cal15 = (weight * Convert.ToDouble(txtass5mod1.Text)) / 100;
            }

        }
        if (ass6mod1.Text != "")
        {
            string text = ass6mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod1.Text != "")
            {
                L1cal16 = (weight * Convert.ToDouble(txtass6mod1.Text)) / 100;
            }

        }
        if (ass7mod1.Text != "")
        {
            string text = ass7mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod1.Text != "")
            {
                L1cal17 = (weight * Convert.ToDouble(txtass7mod1.Text)) / 100;
            }

        }
        if (ass8mod1.Text != "")
        {
            string text = ass8mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod1.Text != "")
            {
                L1cal18 = (weight * Convert.ToDouble(txtass8mod1.Text)) / 100;
            }

        }
        if (ass9mod1.Text != "")
        {
            string text = ass9mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod1.Text != "")
            {
                L1cal19 = (weight * Convert.ToDouble(txtass9mod1.Text)) / 100;
            }

        }
        if (ass10mod1.Text != "")
        {
            string text = ass10mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod1.Text != "")
            {
                L1cal110 = (weight * Convert.ToDouble(txtass10mod1.Text)) / 100;
            }

        }
        TextBox12.Text = Convert.ToString(L1cal11 + L1cal12 + L1cal13 + L1cal14 + L1cal15 + L1cal16 + L1cal17 + L1cal18 + L1cal19 + L1cal110);
        Session["l3weight1"] = TextBox12.Text;
    }
    protected void txtass9mod1_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt9"] = txtass9mod1.Text;
        
        if (ass1mod1.Text != "")
        {
            string text = ass1mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod1.Text != "")
            {
                L1cal11 = (weight * Convert.ToDouble(txtass1mod1.Text.Trim())) / 100;
            }

        }
        if (ass2mod1.Text != "")
        {
            string text = ass2mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod1.Text != "")
            {
                L1cal12 = (weight * Convert.ToDouble(txtass2mod1.Text)) / 100;
            }

        }
        if (ass3mod1.Text != "")
        {
            string text = ass3mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod1.Text != "")
            {
                L1cal13 = (weight * Convert.ToDouble(txtass3mod1.Text)) / 100;
            }

        }
        if (ass4mod1.Text != "")
        {
            string text = ass4mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod1.Text != "")
            {
                L1cal14 = (weight * Convert.ToDouble(txtass4mod1.Text)) / 100;
            }

        }
        if (ass5mod1.Text != "")
        {
            string text = ass5mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod1.Text != "")
            {
                L1cal15 = (weight * Convert.ToDouble(txtass5mod1.Text)) / 100;
            }

        }
        if (ass6mod1.Text != "")
        {
            string text = ass6mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod1.Text != "")
            {
                L1cal16 = (weight * Convert.ToDouble(txtass6mod1.Text)) / 100;
            }

        }
        if (ass7mod1.Text != "")
        {
            string text = ass7mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod1.Text != "")
            {
                L1cal17 = (weight * Convert.ToDouble(txtass7mod1.Text)) / 100;
            }

        }
        if (ass8mod1.Text != "")
        {
            string text = ass8mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod1.Text != "")
            {
                L1cal18 = (weight * Convert.ToDouble(txtass8mod1.Text)) / 100;
            }

        }
        if (ass9mod1.Text != "")
        {
            string text = ass9mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod1.Text != "")
            {
                L1cal19 = (weight * Convert.ToDouble(txtass9mod1.Text)) / 100;
            }

        }
        if (ass10mod1.Text != "")
        {
            string text = ass10mod1.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod1.Text != "")
            {
                L1cal110 = (weight * Convert.ToDouble(txtass10mod1.Text)) / 100;
            }

        }
        TextBox12.Text = Convert.ToString(L1cal11 + L1cal12 + L1cal13 + L1cal14 + L1cal15 + L1cal16 + L1cal17 + L1cal18 + L1cal19 + L1cal110);
        Session["l3weight1"] = TextBox12.Text;
    }
    protected void txtass8mod2_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt18"] = txtass8mod2.Text;

        if (ass1mod2.Text != "")
        {
            string text = ass1mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod2.Text != "")
            {
                L1cal21 = (weight * Convert.ToDouble(txtass1mod2.Text.Trim())) / 100;
            }

        }
        if (ass2mod2.Text != "")
        {
            string text = ass2mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod2.Text != "")
            {
                L1cal22 = (weight * Convert.ToDouble(txtass2mod2.Text)) / 100;
            }

        }
        if (ass3mod2.Text != "")
        {
            string text = ass3mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod2.Text != "")
            {
                L1cal23 = (weight * Convert.ToDouble(txtass3mod2.Text)) / 100;
            }

        }
        if (ass4mod2.Text != "")
        {
            string text = ass4mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod2.Text != "")
            {
                L1cal24 = (weight * Convert.ToDouble(txtass4mod2.Text)) / 100;
            }

        }
        if (ass5mod2.Text != "")
        {
            string text = ass5mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod2.Text != "")
            {
                L1cal25 = (weight * Convert.ToDouble(txtass5mod2.Text)) / 100;
            }

        }
        if (ass6mod2.Text != "")
        {
            string text = ass6mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod2.Text != "")
            {
                L1cal26 = (weight * Convert.ToDouble(txtass6mod2.Text)) / 100;
            }

        }
        if (ass7mod2.Text != "")
        {
            string text = ass7mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod2.Text != "")
            {
                L1cal27 = (weight * Convert.ToDouble(txtass7mod2.Text)) / 100;
            }

        }
        if (ass8mod2.Text != "")
        {
            string text = ass8mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod2.Text != "")
            {
                L1cal28 = (weight * Convert.ToDouble(txtass8mod2.Text)) / 100;
            }

        }
        if (ass9mod2.Text != "")
        {
            string text = ass9mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod2.Text != "")
            {
                L1cal29 = (weight * Convert.ToDouble(txtass9mod2.Text)) / 100;
            }

        }
        if (ass10mod2.Text != "")
        {
            string text = ass10mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod2.Text != "")
            {
                L1cal120 = (weight * Convert.ToDouble(txtass10mod2.Text)) / 100;
            }

        }
        TextBox23.Text = Convert.ToString(L1cal21 + L1cal22 + L1cal23 + L1cal24 + L1cal25 + L1cal26 + L1cal27 + L1cal28 + L1cal29 + L1cal120);
        Session["l3weight2"] = TextBox23.Text;
    }
    protected void txtass9mod2_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt18"] = txtass8mod2.Text;

        if (ass1mod2.Text != "")
        {
            string text = ass1mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod2.Text != "")
            {
                L1cal21 = (weight * Convert.ToDouble(txtass1mod2.Text.Trim())) / 100;
            }

        }
        if (ass2mod2.Text != "")
        {
            string text = ass2mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod2.Text != "")
            {
                L1cal22 = (weight * Convert.ToDouble(txtass2mod2.Text)) / 100;
            }

        }
        if (ass3mod2.Text != "")
        {
            string text = ass3mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod2.Text != "")
            {
                L1cal23 = (weight * Convert.ToDouble(txtass3mod2.Text)) / 100;
            }

        }
        if (ass4mod2.Text != "")
        {
            string text = ass4mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod2.Text != "")
            {
                L1cal24 = (weight * Convert.ToDouble(txtass4mod2.Text)) / 100;
            }

        }
        if (ass5mod2.Text != "")
        {
            string text = ass5mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod2.Text != "")
            {
                L1cal25 = (weight * Convert.ToDouble(txtass5mod2.Text)) / 100;
            }

        }
        if (ass6mod2.Text != "")
        {
            string text = ass6mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod2.Text != "")
            {
                L1cal26 = (weight * Convert.ToDouble(txtass6mod2.Text)) / 100;
            }

        }
        if (ass7mod2.Text != "")
        {
            string text = ass7mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod2.Text != "")
            {
                L1cal27 = (weight * Convert.ToDouble(txtass7mod2.Text)) / 100;
            }

        }
        if (ass8mod2.Text != "")
        {
            string text = ass8mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod2.Text != "")
            {
                L1cal28 = (weight * Convert.ToDouble(txtass8mod2.Text)) / 100;
            }

        }
        if (ass9mod2.Text != "")
        {
            string text = ass9mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod2.Text != "")
            {
                L1cal29 = (weight * Convert.ToDouble(txtass9mod2.Text)) / 100;
            }

        }
        if (ass10mod2.Text != "")
        {
            string text = ass10mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod2.Text != "")
            {
                L1cal120 = (weight * Convert.ToDouble(txtass10mod2.Text)) / 100;
            }

        }
        TextBox23.Text = Convert.ToString(L1cal21 + L1cal22 + L1cal23 + L1cal24 + L1cal25 + L1cal26 + L1cal27 + L1cal28 + L1cal29 + L1cal120);
        Session["l3weight2"] = TextBox23.Text;
    }
    protected void txtass10mod2_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt18"] = txtass8mod2.Text;

        if (ass1mod2.Text != "")
        {
            string text = ass1mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod2.Text != "")
            {
                L1cal21 = (weight * Convert.ToDouble(txtass1mod2.Text.Trim())) / 100;
            }

        }
        if (ass2mod2.Text != "")
        {
            string text = ass2mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod2.Text != "")
            {
                L1cal22 = (weight * Convert.ToDouble(txtass2mod2.Text)) / 100;
            }

        }
        if (ass3mod2.Text != "")
        {
            string text = ass3mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod2.Text != "")
            {
                L1cal23 = (weight * Convert.ToDouble(txtass3mod2.Text)) / 100;
            }

        }
        if (ass4mod2.Text != "")
        {
            string text = ass4mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod2.Text != "")
            {
                L1cal24 = (weight * Convert.ToDouble(txtass4mod2.Text)) / 100;
            }

        }
        if (ass5mod2.Text != "")
        {
            string text = ass5mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod2.Text != "")
            {
                L1cal25 = (weight * Convert.ToDouble(txtass5mod2.Text)) / 100;
            }

        }
        if (ass6mod2.Text != "")
        {
            string text = ass6mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod2.Text != "")
            {
                L1cal26 = (weight * Convert.ToDouble(txtass6mod2.Text)) / 100;
            }

        }
        if (ass7mod2.Text != "")
        {
            string text = ass7mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod2.Text != "")
            {
                L1cal27 = (weight * Convert.ToDouble(txtass7mod2.Text)) / 100;
            }

        }
        if (ass8mod2.Text != "")
        {
            string text = ass8mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod2.Text != "")
            {
                L1cal28 = (weight * Convert.ToDouble(txtass8mod2.Text)) / 100;
            }

        }
        if (ass9mod2.Text != "")
        {
            string text = ass9mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod2.Text != "")
            {
                L1cal29 = (weight * Convert.ToDouble(txtass9mod2.Text)) / 100;
            }

        }
        if (ass10mod2.Text != "")
        {
            string text = ass10mod2.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod2.Text != "")
            {
                L1cal120 = (weight * Convert.ToDouble(txtass10mod2.Text)) / 100;
            }

        }
        TextBox23.Text = Convert.ToString(L1cal21 + L1cal22 + L1cal23 + L1cal24 + L1cal25 + L1cal26 + L1cal27 + L1cal28 + L1cal29 + L1cal120);
        Session["l3weight2"] = TextBox23.Text;
    }
    protected void txtass1mod4_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt31"] = txtass1mod4.Text;
        
        if (ass1mod4.Text != "")
        {
            string text = ass1mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod4.Text != "")
            {
                L1cal41 = (weight * Convert.ToDouble(txtass1mod4.Text.Trim())) / 100;
            }

        }
        if (ass2mod4.Text != "")
        {
            string text = ass2mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod4.Text != "")
            {
                L1cal42 = (weight * Convert.ToDouble(txtass2mod4.Text)) / 100;
            }

        }
        if (ass3mod4.Text != "")
        {
            string text = ass3mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod4.Text != "")
            {
                L1cal43 = (weight * Convert.ToDouble(txtass3mod4.Text)) / 100;
            }

        }
        if (ass4mod4.Text != "")
        {
            string text = ass4mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod4.Text != "")
            {
                L1cal44 = (weight * Convert.ToDouble(txtass4mod4.Text)) / 100;
            }

        }
        if (ass5mod4.Text != "")
        {
            string text = ass5mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod4.Text != "")
            {
                L1cal45 = (weight * Convert.ToDouble(txtass5mod4.Text)) / 100;
            }

        }
        if (ass6mod4.Text != "")
        {
            string text = ass6mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod4.Text != "")
            {
                L1cal46 = (weight * Convert.ToDouble(txtass6mod4.Text)) / 100;
            }

        }
        if (ass7mod4.Text != "")
        {
            string text = ass7mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod4.Text != "")
            {
                L1cal47 = (weight * Convert.ToDouble(txtass7mod4.Text)) / 100;
            }

        }
        if (ass8mod4.Text != "")
        {
            string text = ass8mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod4.Text != "")
            {
                L1cal48 = (weight * Convert.ToDouble(txtass8mod4.Text)) / 100;
            }

        }
        if (ass9mod4.Text != "")
        {
            string text = ass9mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod4.Text != "")
            {
                L1cal49 = (weight * Convert.ToDouble(txtass9mod4.Text)) / 100;
            }

        }
        if (ass10mod4.Text != "")
        {
            string text = ass10mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod4.Text != "")
            {
                L1cal410 = (weight * Convert.ToDouble(txtass10mod4.Text)) / 100;
            }

        }
        TextBox45.Text = Convert.ToString(L1cal41 + L1cal42 + L1cal43 + L1cal44 + L1cal45 + L1cal46 + L1cal47 + L1cal48 + L1cal49 + L1cal410);
        Session["l3weight4"] = TextBox45.Text;
    }
    protected void txtass2mod4_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt32"] = txtass2mod4.Text;
       
        if (ass1mod4.Text != "")
        {
            string text = ass1mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod4.Text != "")
            {
                L1cal41 = (weight * Convert.ToDouble(txtass1mod4.Text.Trim())) / 100;
            }

        }
        if (ass2mod4.Text != "")
        {
            string text = ass2mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod4.Text != "")
            {
                L1cal42 = (weight * Convert.ToDouble(txtass2mod4.Text)) / 100;
            }

        }
        if (ass3mod4.Text != "")
        {
            string text = ass3mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod4.Text != "")
            {
                L1cal43 = (weight * Convert.ToDouble(txtass3mod4.Text)) / 100;
            }

        }
        if (ass4mod4.Text != "")
        {
            string text = ass4mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod4.Text != "")
            {
                L1cal44 = (weight * Convert.ToDouble(txtass4mod4.Text)) / 100;
            }

        }
        if (ass5mod4.Text != "")
        {
            string text = ass5mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod4.Text != "")
            {
                L1cal45 = (weight * Convert.ToDouble(txtass5mod4.Text)) / 100;
            }

        }
        if (ass6mod4.Text != "")
        {
            string text = ass6mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod4.Text != "")
            {
                L1cal46 = (weight * Convert.ToDouble(txtass6mod4.Text)) / 100;
            }

        }
        if (ass7mod4.Text != "")
        {
            string text = ass7mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod4.Text != "")
            {
                L1cal47 = (weight * Convert.ToDouble(txtass7mod4.Text)) / 100;
            }

        }
        if (ass8mod4.Text != "")
        {
            string text = ass8mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod4.Text != "")
            {
                L1cal48 = (weight * Convert.ToDouble(txtass8mod4.Text)) / 100;
            }

        }
        if (ass9mod4.Text != "")
        {
            string text = ass9mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod4.Text != "")
            {
                L1cal49 = (weight * Convert.ToDouble(txtass9mod4.Text)) / 100;
            }

        }
        if (ass10mod4.Text != "")
        {
            string text = ass10mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod4.Text != "")
            {
                L1cal410 = (weight * Convert.ToDouble(txtass10mod4.Text)) / 100;
            }

        }
        TextBox45.Text = Convert.ToString(L1cal41 + L1cal42 + L1cal43 + L1cal44 + L1cal45 + L1cal46 + L1cal47 + L1cal48 + L1cal49 + L1cal410);
        Session["l3weight4"] = TextBox45.Text;
    }
    protected void txtass3mod4_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt33"] = txtass3mod4.Text;
       
        if (ass1mod4.Text != "")
        {
            string text = ass1mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod4.Text != "")
            {
                L1cal41 = (weight * Convert.ToDouble(txtass1mod4.Text.Trim())) / 100;
            }

        }
        if (ass2mod4.Text != "")
        {
            string text = ass2mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod4.Text != "")
            {
                L1cal42 = (weight * Convert.ToDouble(txtass2mod4.Text)) / 100;
            }

        }
        if (ass3mod4.Text != "")
        {
            string text = ass3mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod4.Text != "")
            {
                L1cal43 = (weight * Convert.ToDouble(txtass3mod4.Text)) / 100;
            }

        }
        if (ass4mod4.Text != "")
        {
            string text = ass4mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod4.Text != "")
            {
                L1cal44 = (weight * Convert.ToDouble(txtass4mod4.Text)) / 100;
            }

        }
        if (ass5mod4.Text != "")
        {
            string text = ass5mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod4.Text != "")
            {
                L1cal45 = (weight * Convert.ToDouble(txtass5mod4.Text)) / 100;
            }

        }
        if (ass6mod4.Text != "")
        {
            string text = ass6mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod4.Text != "")
            {
                L1cal46 = (weight * Convert.ToDouble(txtass6mod4.Text)) / 100;
            }

        }
        if (ass7mod4.Text != "")
        {
            string text = ass7mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod4.Text != "")
            {
                L1cal47 = (weight * Convert.ToDouble(txtass7mod4.Text)) / 100;
            }

        }
        if (ass8mod4.Text != "")
        {
            string text = ass8mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod4.Text != "")
            {
                L1cal48 = (weight * Convert.ToDouble(txtass8mod4.Text)) / 100;
            }

        }
        if (ass9mod4.Text != "")
        {
            string text = ass9mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod4.Text != "")
            {
                L1cal49 = (weight * Convert.ToDouble(txtass9mod4.Text)) / 100;
            }

        }
        if (ass10mod4.Text != "")
        {
            string text = ass10mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod4.Text != "")
            {
                L1cal410 = (weight * Convert.ToDouble(txtass10mod4.Text)) / 100;
            }

        }
        TextBox45.Text = Convert.ToString(L1cal41 + L1cal42 + L1cal43 + L1cal44 + L1cal45 + L1cal46 + L1cal47 + L1cal48 + L1cal49 + L1cal410);
        Session["l3weight4"] = TextBox45.Text;
    }
    protected void txtass4mod4_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt34"] = txtass4mod4.Text;
       
        if (ass1mod4.Text != "")
        {
            string text = ass1mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod4.Text != "")
            {
                L1cal41 = (weight * Convert.ToDouble(txtass1mod4.Text.Trim())) / 100;
            }

        }
        if (ass2mod4.Text != "")
        {
            string text = ass2mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod4.Text != "")
            {
                L1cal42 = (weight * Convert.ToDouble(txtass2mod4.Text)) / 100;
            }

        }
        if (ass3mod4.Text != "")
        {
            string text = ass3mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod4.Text != "")
            {
                L1cal43 = (weight * Convert.ToDouble(txtass3mod4.Text)) / 100;
            }

        }
        if (ass4mod4.Text != "")
        {
            string text = ass4mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod4.Text != "")
            {
                L1cal44 = (weight * Convert.ToDouble(txtass4mod4.Text)) / 100;
            }

        }
        if (ass5mod4.Text != "")
        {
            string text = ass5mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod4.Text != "")
            {
                L1cal45 = (weight * Convert.ToDouble(txtass5mod4.Text)) / 100;
            }

        }
        if (ass6mod4.Text != "")
        {
            string text = ass6mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod4.Text != "")
            {
                L1cal46 = (weight * Convert.ToDouble(txtass6mod4.Text)) / 100;
            }

        }
        if (ass7mod4.Text != "")
        {
            string text = ass7mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod4.Text != "")
            {
                L1cal47 = (weight * Convert.ToDouble(txtass7mod4.Text)) / 100;
            }

        }
        if (ass8mod4.Text != "")
        {
            string text = ass8mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod4.Text != "")
            {
                L1cal48 = (weight * Convert.ToDouble(txtass8mod4.Text)) / 100;
            }

        }
        if (ass9mod4.Text != "")
        {
            string text = ass9mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod4.Text != "")
            {
                L1cal49 = (weight * Convert.ToDouble(txtass9mod4.Text)) / 100;
            }

        }
        if (ass10mod4.Text != "")
        {
            string text = ass10mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod4.Text != "")
            {
                L1cal410 = (weight * Convert.ToDouble(txtass10mod4.Text)) / 100;
            }

        }
        TextBox45.Text = Convert.ToString(L1cal41 + L1cal42 + L1cal43 + L1cal44 + L1cal45 + L1cal46 + L1cal47 + L1cal48 + L1cal49 + L1cal410);
        Session["l3weight4"] = TextBox45.Text;
    }
    protected void txtass5mod4_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt35"] = txtass5mod4.Text;
      
        if (ass1mod4.Text != "")
        {
            string text = ass1mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod4.Text != "")
            {
                L1cal41 = (weight * Convert.ToDouble(txtass1mod4.Text.Trim())) / 100;
            }

        }
        if (ass2mod4.Text != "")
        {
            string text = ass2mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod4.Text != "")
            {
                L1cal42 = (weight * Convert.ToDouble(txtass2mod4.Text)) / 100;
            }

        }
        if (ass3mod4.Text != "")
        {
            string text = ass3mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod4.Text != "")
            {
                L1cal43 = (weight * Convert.ToDouble(txtass3mod4.Text)) / 100;
            }

        }
        if (ass4mod4.Text != "")
        {
            string text = ass4mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod4.Text != "")
            {
                L1cal44 = (weight * Convert.ToDouble(txtass4mod4.Text)) / 100;
            }

        }
        if (ass5mod4.Text != "")
        {
            string text = ass5mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod4.Text != "")
            {
                L1cal45 = (weight * Convert.ToDouble(txtass5mod4.Text)) / 100;
            }

        }
        if (ass6mod4.Text != "")
        {
            string text = ass6mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod4.Text != "")
            {
                L1cal46 = (weight * Convert.ToDouble(txtass6mod4.Text)) / 100;
            }

        }
        if (ass7mod4.Text != "")
        {
            string text = ass7mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod4.Text != "")
            {
                L1cal47 = (weight * Convert.ToDouble(txtass7mod4.Text)) / 100;
            }

        }
        if (ass8mod4.Text != "")
        {
            string text = ass8mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod4.Text != "")
            {
                L1cal48 = (weight * Convert.ToDouble(txtass8mod4.Text)) / 100;
            }

        }
        if (ass9mod4.Text != "")
        {
            string text = ass9mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod4.Text != "")
            {
                L1cal49 = (weight * Convert.ToDouble(txtass9mod4.Text)) / 100;
            }

        }
        if (ass10mod4.Text != "")
        {
            string text = ass10mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod4.Text != "")
            {
                L1cal410 = (weight * Convert.ToDouble(txtass10mod4.Text)) / 100;
            }

        }
        TextBox45.Text = Convert.ToString(L1cal41 + L1cal42 + L1cal43 + L1cal44 + L1cal45 + L1cal46 + L1cal47 + L1cal48 + L1cal49 + L1cal410);
        Session["l3weight4"] = TextBox45.Text;
    }
    protected void txtass6mod4_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt36"] = txtass6mod4.Text;
      
        if (ass1mod4.Text != "")
        {
            string text = ass1mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod4.Text != "")
            {
                L1cal41 = (weight * Convert.ToDouble(txtass1mod4.Text.Trim())) / 100;
            }

        }
        if (ass2mod4.Text != "")
        {
            string text = ass2mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod4.Text != "")
            {
                L1cal42 = (weight * Convert.ToDouble(txtass2mod4.Text)) / 100;
            }

        }
        if (ass3mod4.Text != "")
        {
            string text = ass3mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod4.Text != "")
            {
                L1cal43 = (weight * Convert.ToDouble(txtass3mod4.Text)) / 100;
            }

        }
        if (ass4mod4.Text != "")
        {
            string text = ass4mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod4.Text != "")
            {
                L1cal44 = (weight * Convert.ToDouble(txtass4mod4.Text)) / 100;
            }

        }
        if (ass5mod4.Text != "")
        {
            string text = ass5mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod4.Text != "")
            {
                L1cal45 = (weight * Convert.ToDouble(txtass5mod4.Text)) / 100;
            }

        }
        if (ass6mod4.Text != "")
        {
            string text = ass6mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod4.Text != "")
            {
                L1cal46 = (weight * Convert.ToDouble(txtass6mod4.Text)) / 100;
            }

        }
        if (ass7mod4.Text != "")
        {
            string text = ass7mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod4.Text != "")
            {
                L1cal47 = (weight * Convert.ToDouble(txtass7mod4.Text)) / 100;
            }

        }
        if (ass8mod4.Text != "")
        {
            string text = ass8mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod4.Text != "")
            {
                L1cal48 = (weight * Convert.ToDouble(txtass8mod4.Text)) / 100;
            }

        }
        if (ass9mod4.Text != "")
        {
            string text = ass9mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod4.Text != "")
            {
                L1cal49 = (weight * Convert.ToDouble(txtass9mod4.Text)) / 100;
            }

        }
        if (ass10mod4.Text != "")
        {
            string text = ass10mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod4.Text != "")
            {
                L1cal410 = (weight * Convert.ToDouble(txtass10mod4.Text)) / 100;
            }

        }
        TextBox45.Text = Convert.ToString(L1cal41 + L1cal42 + L1cal43 + L1cal44 + L1cal45 + L1cal46 + L1cal47 + L1cal48 + L1cal49 + L1cal410);
        Session["l3weight4"] = TextBox45.Text;
    }
    protected void txtass7mod4_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt37"] = txtass7mod4.Text;
      
        if (ass1mod4.Text != "")
        {
            string text = ass1mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod4.Text != "")
            {
                L1cal41 = (weight * Convert.ToDouble(txtass1mod4.Text.Trim())) / 100;
            }

        }
        if (ass2mod4.Text != "")
        {
            string text = ass2mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod4.Text != "")
            {
                L1cal42 = (weight * Convert.ToDouble(txtass2mod4.Text)) / 100;
            }

        }
        if (ass3mod4.Text != "")
        {
            string text = ass3mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod4.Text != "")
            {
                L1cal43 = (weight * Convert.ToDouble(txtass3mod4.Text)) / 100;
            }

        }
        if (ass4mod4.Text != "")
        {
            string text = ass4mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod4.Text != "")
            {
                L1cal44 = (weight * Convert.ToDouble(txtass4mod4.Text)) / 100;
            }

        }
        if (ass5mod4.Text != "")
        {
            string text = ass5mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod4.Text != "")
            {
                L1cal45 = (weight * Convert.ToDouble(txtass5mod4.Text)) / 100;
            }

        }
        if (ass6mod4.Text != "")
        {
            string text = ass6mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod4.Text != "")
            {
                L1cal46 = (weight * Convert.ToDouble(txtass6mod4.Text)) / 100;
            }

        }
        if (ass7mod4.Text != "")
        {
            string text = ass7mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod4.Text != "")
            {
                L1cal47 = (weight * Convert.ToDouble(txtass7mod4.Text)) / 100;
            }

        }
        if (ass8mod4.Text != "")
        {
            string text = ass8mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod4.Text != "")
            {
                L1cal48 = (weight * Convert.ToDouble(txtass8mod4.Text)) / 100;
            }

        }
        if (ass9mod4.Text != "")
        {
            string text = ass9mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod4.Text != "")
            {
                L1cal49 = (weight * Convert.ToDouble(txtass9mod4.Text)) / 100;
            }

        }
        if (ass10mod4.Text != "")
        {
            string text = ass10mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod4.Text != "")
            {
                L1cal410 = (weight * Convert.ToDouble(txtass10mod4.Text)) / 100;
            }

        }
        TextBox45.Text = Convert.ToString(L1cal41 + L1cal42 + L1cal43 + L1cal44 + L1cal45 + L1cal46 + L1cal47 + L1cal48 + L1cal49 + L1cal410);
        Session["l3weight4"] = TextBox45.Text;
    }
    protected void txtass8mod4_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt38"] = txtass8mod4.Text;
       
        if (ass1mod4.Text != "")
        {
            string text = ass1mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod4.Text != "")
            {
                L1cal41 = (weight * Convert.ToDouble(txtass1mod4.Text.Trim())) / 100;
            }

        }
        if (ass2mod4.Text != "")
        {
            string text = ass2mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod4.Text != "")
            {
                L1cal42 = (weight * Convert.ToDouble(txtass2mod4.Text)) / 100;
            }

        }
        if (ass3mod4.Text != "")
        {
            string text = ass3mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod4.Text != "")
            {
                L1cal43 = (weight * Convert.ToDouble(txtass3mod4.Text)) / 100;
            }

        }
        if (ass4mod4.Text != "")
        {
            string text = ass4mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod4.Text != "")
            {
                L1cal44 = (weight * Convert.ToDouble(txtass4mod4.Text)) / 100;
            }

        }
        if (ass5mod4.Text != "")
        {
            string text = ass5mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod4.Text != "")
            {
                L1cal45 = (weight * Convert.ToDouble(txtass5mod4.Text)) / 100;
            }

        }
        if (ass6mod4.Text != "")
        {
            string text = ass6mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod4.Text != "")
            {
                L1cal46 = (weight * Convert.ToDouble(txtass6mod4.Text)) / 100;
            }

        }
        if (ass7mod4.Text != "")
        {
            string text = ass7mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod4.Text != "")
            {
                L1cal47 = (weight * Convert.ToDouble(txtass7mod4.Text)) / 100;
            }

        }
        if (ass8mod4.Text != "")
        {
            string text = ass8mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod4.Text != "")
            {
                L1cal48 = (weight * Convert.ToDouble(txtass8mod4.Text)) / 100;
            }

        }
        if (ass9mod4.Text != "")
        {
            string text = ass9mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod4.Text != "")
            {
                L1cal49 = (weight * Convert.ToDouble(txtass9mod4.Text)) / 100;
            }

        }
        if (ass10mod4.Text != "")
        {
            string text = ass10mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod4.Text != "")
            {
                L1cal410 = (weight * Convert.ToDouble(txtass10mod4.Text)) / 100;
            }

        }
        TextBox45.Text = Convert.ToString(L1cal41 + L1cal42 + L1cal43 + L1cal44 + L1cal45 + L1cal46 + L1cal47 + L1cal48 + L1cal49 + L1cal410);
        Session["l3weight4"] = TextBox45.Text;
    }
    protected void txtass9mod4_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt39"] = txtass9mod4.Text;
        
        if (ass1mod4.Text != "")
        {
            string text = ass1mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod4.Text != "")
            {
                L1cal41 = (weight * Convert.ToDouble(txtass1mod4.Text.Trim())) / 100;
            }

        }
        if (ass2mod4.Text != "")
        {
            string text = ass2mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod4.Text != "")
            {
                L1cal42 = (weight * Convert.ToDouble(txtass2mod4.Text)) / 100;
            }

        }
        if (ass3mod4.Text != "")
        {
            string text = ass3mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod4.Text != "")
            {
                L1cal43 = (weight * Convert.ToDouble(txtass3mod4.Text)) / 100;
            }

        }
        if (ass4mod4.Text != "")
        {
            string text = ass4mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod4.Text != "")
            {
                L1cal44 = (weight * Convert.ToDouble(txtass4mod4.Text)) / 100;
            }

        }
        if (ass5mod4.Text != "")
        {
            string text = ass5mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod4.Text != "")
            {
                L1cal45 = (weight * Convert.ToDouble(txtass5mod4.Text)) / 100;
            }

        }
        if (ass6mod4.Text != "")
        {
            string text = ass6mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod4.Text != "")
            {
                L1cal46 = (weight * Convert.ToDouble(txtass6mod4.Text)) / 100;
            }

        }
        if (ass7mod4.Text != "")
        {
            string text = ass7mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod4.Text != "")
            {
                L1cal47 = (weight * Convert.ToDouble(txtass7mod4.Text)) / 100;
            }

        }
        if (ass8mod4.Text != "")
        {
            string text = ass8mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod4.Text != "")
            {
                L1cal48 = (weight * Convert.ToDouble(txtass8mod4.Text)) / 100;
            }

        }
        if (ass9mod4.Text != "")
        {
            string text = ass9mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod4.Text != "")
            {
                L1cal49 = (weight * Convert.ToDouble(txtass9mod4.Text)) / 100;
            }

        }
        if (ass10mod4.Text != "")
        {
            string text = ass10mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod4.Text != "")
            {
                L1cal410 = (weight * Convert.ToDouble(txtass10mod4.Text)) / 100;
            }

        }
        TextBox45.Text = Convert.ToString(L1cal41 + L1cal42 + L1cal43 + L1cal44 + L1cal45 + L1cal46 + L1cal47 + L1cal48 + L1cal49 + L1cal410);
        Session["l3weight4"] = TextBox45.Text;
    }
    protected void txtass10mod4_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt40"] = txtass10mod4.Text;
        
        if (ass1mod4.Text != "")
        {
            string text = ass1mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod4.Text != "")
            {
                L1cal41 = (weight * Convert.ToDouble(txtass1mod4.Text.Trim())) / 100;
            }

        }
        if (ass2mod4.Text != "")
        {
            string text = ass2mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod4.Text != "")
            {
                L1cal42 = (weight * Convert.ToDouble(txtass2mod4.Text)) / 100;
            }

        }
        if (ass3mod4.Text != "")
        {
            string text = ass3mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod4.Text != "")
            {
                L1cal43 = (weight * Convert.ToDouble(txtass3mod4.Text)) / 100;
            }

        }
        if (ass4mod4.Text != "")
        {
            string text = ass4mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod4.Text != "")
            {
                L1cal44 = (weight * Convert.ToDouble(txtass4mod4.Text)) / 100;
            }

        }
        if (ass5mod4.Text != "")
        {
            string text = ass5mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod4.Text != "")
            {
                L1cal45 = (weight * Convert.ToDouble(txtass5mod4.Text)) / 100;
            }

        }
        if (ass6mod4.Text != "")
        {
            string text = ass6mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod4.Text != "")
            {
                L1cal46 = (weight * Convert.ToDouble(txtass6mod4.Text)) / 100;
            }

        }
        if (ass7mod4.Text != "")
        {
            string text = ass7mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod4.Text != "")
            {
                L1cal47 = (weight * Convert.ToDouble(txtass7mod4.Text)) / 100;
            }

        }
        if (ass8mod4.Text != "")
        {
            string text = ass8mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod4.Text != "")
            {
                L1cal48 = (weight * Convert.ToDouble(txtass8mod4.Text)) / 100;
            }

        }
        if (ass9mod4.Text != "")
        {
            string text = ass9mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod4.Text != "")
            {
                L1cal49 = (weight * Convert.ToDouble(txtass9mod4.Text)) / 100;
            }

        }
        if (ass10mod4.Text != "")
        {
            string text = ass10mod4.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod4.Text != "")
            {
                L1cal410 = (weight * Convert.ToDouble(txtass10mod4.Text)) / 100;
            }

        }
        TextBox45.Text = Convert.ToString(L1cal41 + L1cal42 + L1cal43 + L1cal44 + L1cal45 + L1cal46 + L1cal47 + L1cal48 + L1cal49 + L1cal410);
        Session["l3weight4"] = TextBox45.Text;
    }
    protected void txtass2mod3_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt22"] = txtass2mod3.Text;
       
        if (ass1mod3.Text != "")
        {
            string text = ass1mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod3.Text != "")
            {
                L1cal31 = (weight * Convert.ToDouble(txtass1mod3.Text.Trim())) / 100;
            }

        }
        if (ass2mod3.Text != "")
        {
            string text = ass2mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod3.Text != "")
            {
                L1cal32 = (weight * Convert.ToDouble(txtass2mod3.Text)) / 100;
            }

        }
        if (ass3mod3.Text != "")
        {
            string text = ass3mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod3.Text != "")
            {
                L1cal33 = (weight * Convert.ToDouble(txtass3mod3.Text)) / 100;
            }

        }
        if (ass4mod3.Text != "")
        {
            string text = ass4mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod3.Text != "")
            {
                L1cal34 = (weight * Convert.ToDouble(txtass4mod3.Text)) / 100;
            }

        }
        if (ass5mod3.Text != "")
        {
            string text = ass5mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod3.Text != "")
            {
                L1cal35 = (weight * Convert.ToDouble(txtass5mod3.Text)) / 100;
            }

        }
        if (ass6mod3.Text != "")
        {
            string text = ass6mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod3.Text != "")
            {
                L1cal36 = (weight * Convert.ToDouble(txtass6mod3.Text)) / 100;
            }

        }
        if (ass7mod3.Text != "")
        {
            string text = ass7mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod3.Text != "")
            {
                L1cal37 = (weight * Convert.ToDouble(txtass7mod3.Text)) / 100;
            }

        }
        if (ass8mod3.Text != "")
        {
            string text = ass8mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod3.Text != "")
            {
                L1cal38 = (weight * Convert.ToDouble(txtass8mod3.Text)) / 100;
            }

        }
        if (ass9mod3.Text != "")
        {
            string text = ass9mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod3.Text != "")
            {
                L1cal39 = (weight * Convert.ToDouble(txtass9mod3.Text)) / 100;
            }

        }
        if (ass10mod3.Text != "")
        {
            string text = ass10mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod3.Text != "")
            {
                L1cal310 = (weight * Convert.ToDouble(txtass10mod3.Text)) / 100;
            }

        }
        TextBox34.Text = Convert.ToString(L1cal31 + L1cal32 + L1cal33 + L1cal34 + L1cal35 + L1cal36 + L1cal37 + L1cal38 + L1cal39 + L1cal310);
        Session["l3weight3"] = TextBox34.Text;
    }
    protected void txtass3mod3_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt23"] = txtass2mod3.Text;
        
        if (ass1mod3.Text != "")
        {
            string text = ass1mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod3.Text != "")
            {
                L1cal31 = (weight * Convert.ToDouble(txtass1mod3.Text.Trim())) / 100;
            }

        }
        if (ass2mod3.Text != "")
        {
            string text = ass2mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod3.Text != "")
            {
                L1cal32 = (weight * Convert.ToDouble(txtass2mod3.Text)) / 100;
            }

        }
        if (ass3mod3.Text != "")
        {
            string text = ass3mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod3.Text != "")
            {
                L1cal33 = (weight * Convert.ToDouble(txtass3mod3.Text)) / 100;
            }

        }
        if (ass4mod3.Text != "")
        {
            string text = ass4mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod3.Text != "")
            {
                L1cal34 = (weight * Convert.ToDouble(txtass4mod3.Text)) / 100;
            }

        }
        if (ass5mod3.Text != "")
        {
            string text = ass5mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod3.Text != "")
            {
                L1cal35 = (weight * Convert.ToDouble(txtass5mod3.Text)) / 100;
            }

        }
        if (ass6mod3.Text != "")
        {
            string text = ass6mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod3.Text != "")
            {
                L1cal36 = (weight * Convert.ToDouble(txtass6mod3.Text)) / 100;
            }

        }
        if (ass7mod3.Text != "")
        {
            string text = ass7mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod3.Text != "")
            {
                L1cal37 = (weight * Convert.ToDouble(txtass7mod3.Text)) / 100;
            }

        }
        if (ass8mod3.Text != "")
        {
            string text = ass8mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod3.Text != "")
            {
                L1cal38 = (weight * Convert.ToDouble(txtass8mod3.Text)) / 100;
            }

        }
        if (ass9mod3.Text != "")
        {
            string text = ass9mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod3.Text != "")
            {
                L1cal39 = (weight * Convert.ToDouble(txtass9mod3.Text)) / 100;
            }

        }
        if (ass10mod3.Text != "")
        {
            string text = ass10mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod3.Text != "")
            {
                L1cal310 = (weight * Convert.ToDouble(txtass10mod3.Text)) / 100;
            }

        }
        TextBox34.Text = Convert.ToString(L1cal31 + L1cal32 + L1cal33 + L1cal34 + L1cal35 + L1cal36 + L1cal37 + L1cal38 + L1cal39 + L1cal310);
        Session["l3weight3"] = TextBox34.Text;
    }
    protected void txtass4mod3_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt24"] = txtass4mod3.Text;
       
        if (ass1mod3.Text != "")
        {
            string text = ass1mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod3.Text != "")
            {
                L1cal31 = (weight * Convert.ToDouble(txtass1mod3.Text.Trim())) / 100;
            }

        }
        if (ass2mod3.Text != "")
        {
            string text = ass2mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod3.Text != "")
            {
                L1cal32 = (weight * Convert.ToDouble(txtass2mod3.Text)) / 100;
            }

        }
        if (ass3mod3.Text != "")
        {
            string text = ass3mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod3.Text != "")
            {
                L1cal33 = (weight * Convert.ToDouble(txtass3mod3.Text)) / 100;
            }

        }
        if (ass4mod3.Text != "")
        {
            string text = ass4mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod3.Text != "")
            {
                L1cal34 = (weight * Convert.ToDouble(txtass4mod3.Text)) / 100;
            }

        }
        if (ass5mod3.Text != "")
        {
            string text = ass5mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod3.Text != "")
            {
                L1cal35 = (weight * Convert.ToDouble(txtass5mod3.Text)) / 100;
            }

        }
        if (ass6mod3.Text != "")
        {
            string text = ass6mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod3.Text != "")
            {
                L1cal36 = (weight * Convert.ToDouble(txtass6mod3.Text)) / 100;
            }

        }
        if (ass7mod3.Text != "")
        {
            string text = ass7mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod3.Text != "")
            {
                L1cal37 = (weight * Convert.ToDouble(txtass7mod3.Text)) / 100;
            }

        }
        if (ass8mod3.Text != "")
        {
            string text = ass8mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod3.Text != "")
            {
                L1cal38 = (weight * Convert.ToDouble(txtass8mod3.Text)) / 100;
            }

        }
        if (ass9mod3.Text != "")
        {
            string text = ass9mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod3.Text != "")
            {
                L1cal39 = (weight * Convert.ToDouble(txtass9mod3.Text)) / 100;
            }

        }
        if (ass10mod3.Text != "")
        {
            string text = ass10mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod3.Text != "")
            {
                L1cal310 = (weight * Convert.ToDouble(txtass10mod3.Text)) / 100;
            }

        }
        TextBox34.Text = Convert.ToString(L1cal31 + L1cal32 + L1cal33 + L1cal34 + L1cal35 + L1cal36 + L1cal37 + L1cal38 + L1cal39 + L1cal310);
        Session["l3weight3"] = TextBox34.Text;
    }
    protected void txtass5mod3_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt25"] = txtass5mod3.Text;
       
        if (ass1mod3.Text != "")
        {
            string text = ass1mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod3.Text != "")
            {
                L1cal31 = (weight * Convert.ToDouble(txtass1mod3.Text.Trim())) / 100;
            }

        }
        if (ass2mod3.Text != "")
        {
            string text = ass2mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod3.Text != "")
            {
                L1cal32 = (weight * Convert.ToDouble(txtass2mod3.Text)) / 100;
            }

        }
        if (ass3mod3.Text != "")
        {
            string text = ass3mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod3.Text != "")
            {
                L1cal33 = (weight * Convert.ToDouble(txtass3mod3.Text)) / 100;
            }

        }
        if (ass4mod3.Text != "")
        {
            string text = ass4mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod3.Text != "")
            {
                L1cal34 = (weight * Convert.ToDouble(txtass4mod3.Text)) / 100;
            }

        }
        if (ass5mod3.Text != "")
        {
            string text = ass5mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod3.Text != "")
            {
                L1cal35 = (weight * Convert.ToDouble(txtass5mod3.Text)) / 100;
            }

        }
        if (ass6mod3.Text != "")
        {
            string text = ass6mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod3.Text != "")
            {
                L1cal36 = (weight * Convert.ToDouble(txtass6mod3.Text)) / 100;
            }

        }
        if (ass7mod3.Text != "")
        {
            string text = ass7mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod3.Text != "")
            {
                L1cal37 = (weight * Convert.ToDouble(txtass7mod3.Text)) / 100;
            }

        }
        if (ass8mod3.Text != "")
        {
            string text = ass8mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod3.Text != "")
            {
                L1cal38 = (weight * Convert.ToDouble(txtass8mod3.Text)) / 100;
            }

        }
        if (ass9mod3.Text != "")
        {
            string text = ass9mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod3.Text != "")
            {
                L1cal39 = (weight * Convert.ToDouble(txtass9mod3.Text)) / 100;
            }

        }
        if (ass10mod3.Text != "")
        {
            string text = ass10mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod3.Text != "")
            {
                L1cal310 = (weight * Convert.ToDouble(txtass10mod3.Text)) / 100;
            }

        }
        TextBox34.Text = Convert.ToString(L1cal31 + L1cal32 + L1cal33 + L1cal34 + L1cal35 + L1cal36 + L1cal37 + L1cal38 + L1cal39 + L1cal310);
        Session["l3weight3"] = TextBox34.Text;
    }
    protected void txtass6mod3_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt26"] = txtass6mod3.Text;
      
        if (ass1mod3.Text != "")
        {
            string text = ass1mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod3.Text != "")
            {
                L1cal31 = (weight * Convert.ToDouble(txtass1mod3.Text.Trim())) / 100;
            }

        }
        if (ass2mod3.Text != "")
        {
            string text = ass2mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod3.Text != "")
            {
                L1cal32 = (weight * Convert.ToDouble(txtass2mod3.Text)) / 100;
            }

        }
        if (ass3mod3.Text != "")
        {
            string text = ass3mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod3.Text != "")
            {
                L1cal33 = (weight * Convert.ToDouble(txtass3mod3.Text)) / 100;
            }

        }
        if (ass4mod3.Text != "")
        {
            string text = ass4mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod3.Text != "")
            {
                L1cal34 = (weight * Convert.ToDouble(txtass4mod3.Text)) / 100;
            }

        }
        if (ass5mod3.Text != "")
        {
            string text = ass5mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod3.Text != "")
            {
                L1cal35 = (weight * Convert.ToDouble(txtass5mod3.Text)) / 100;
            }

        }
        if (ass6mod3.Text != "")
        {
            string text = ass6mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod3.Text != "")
            {
                L1cal36 = (weight * Convert.ToDouble(txtass6mod3.Text)) / 100;
            }

        }
        if (ass7mod3.Text != "")
        {
            string text = ass7mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod3.Text != "")
            {
                L1cal37 = (weight * Convert.ToDouble(txtass7mod3.Text)) / 100;
            }

        }
        if (ass8mod3.Text != "")
        {
            string text = ass8mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod3.Text != "")
            {
                L1cal38 = (weight * Convert.ToDouble(txtass8mod3.Text)) / 100;
            }

        }
        if (ass9mod3.Text != "")
        {
            string text = ass9mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod3.Text != "")
            {
                L1cal39 = (weight * Convert.ToDouble(txtass9mod3.Text)) / 100;
            }

        }
        if (ass10mod3.Text != "")
        {
            string text = ass10mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod3.Text != "")
            {
                L1cal310 = (weight * Convert.ToDouble(txtass10mod3.Text)) / 100;
            }

        }
        TextBox34.Text = Convert.ToString(L1cal31 + L1cal32 + L1cal33 + L1cal34 + L1cal35 + L1cal36 + L1cal37 + L1cal38 + L1cal39 + L1cal310);
        Session["l3weight3"] = TextBox34.Text;
    }
    protected void txtass7mod3_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt27"] = txtass7mod3.Text;
       
        if (ass1mod3.Text != "")
        {
            string text = ass1mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod3.Text != "")
            {
                L1cal31 = (weight * Convert.ToDouble(txtass1mod3.Text.Trim())) / 100;
            }

        }
        if (ass2mod3.Text != "")
        {
            string text = ass2mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod3.Text != "")
            {
                L1cal32 = (weight * Convert.ToDouble(txtass2mod3.Text)) / 100;
            }

        }
        if (ass3mod3.Text != "")
        {
            string text = ass3mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod3.Text != "")
            {
                L1cal33 = (weight * Convert.ToDouble(txtass3mod3.Text)) / 100;
            }

        }
        if (ass4mod3.Text != "")
        {
            string text = ass4mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod3.Text != "")
            {
                L1cal34 = (weight * Convert.ToDouble(txtass4mod3.Text)) / 100;
            }

        }
        if (ass5mod3.Text != "")
        {
            string text = ass5mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod3.Text != "")
            {
                L1cal35 = (weight * Convert.ToDouble(txtass5mod3.Text)) / 100;
            }

        }
        if (ass6mod3.Text != "")
        {
            string text = ass6mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod3.Text != "")
            {
                L1cal36 = (weight * Convert.ToDouble(txtass6mod3.Text)) / 100;
            }

        }
        if (ass7mod3.Text != "")
        {
            string text = ass7mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod3.Text != "")
            {
                L1cal37 = (weight * Convert.ToDouble(txtass7mod3.Text)) / 100;
            }

        }
        if (ass8mod3.Text != "")
        {
            string text = ass8mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod3.Text != "")
            {
                L1cal38 = (weight * Convert.ToDouble(txtass8mod3.Text)) / 100;
            }

        }
        if (ass9mod3.Text != "")
        {
            string text = ass9mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod3.Text != "")
            {
                L1cal39 = (weight * Convert.ToDouble(txtass9mod3.Text)) / 100;
            }

        }
        if (ass10mod3.Text != "")
        {
            string text = ass10mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod3.Text != "")
            {
                L1cal310 = (weight * Convert.ToDouble(txtass10mod3.Text)) / 100;
            }

        }
        TextBox34.Text = Convert.ToString(L1cal31 + L1cal32 + L1cal33 + L1cal34 + L1cal35 + L1cal36 + L1cal37 + L1cal38 + L1cal39 + L1cal310);
        Session["l3weight3"] = TextBox34.Text;
    }
    protected void txtass8mod3_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt28"] = txtass8mod3.Text;
       
        if (ass1mod3.Text != "")
        {
            string text = ass1mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod3.Text != "")
            {
                L1cal31 = (weight * Convert.ToDouble(txtass1mod3.Text.Trim())) / 100;
            }

        }
        if (ass2mod3.Text != "")
        {
            string text = ass2mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod3.Text != "")
            {
                L1cal32 = (weight * Convert.ToDouble(txtass2mod3.Text)) / 100;
            }

        }
        if (ass3mod3.Text != "")
        {
            string text = ass3mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod3.Text != "")
            {
                L1cal33 = (weight * Convert.ToDouble(txtass3mod3.Text)) / 100;
            }

        }
        if (ass4mod3.Text != "")
        {
            string text = ass4mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod3.Text != "")
            {
                L1cal34 = (weight * Convert.ToDouble(txtass4mod3.Text)) / 100;
            }

        }
        if (ass5mod3.Text != "")
        {
            string text = ass5mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod3.Text != "")
            {
                L1cal35 = (weight * Convert.ToDouble(txtass5mod3.Text)) / 100;
            }

        }
        if (ass6mod3.Text != "")
        {
            string text = ass6mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod3.Text != "")
            {
                L1cal36 = (weight * Convert.ToDouble(txtass6mod3.Text)) / 100;
            }

        }
        if (ass7mod3.Text != "")
        {
            string text = ass7mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod3.Text != "")
            {
                L1cal37 = (weight * Convert.ToDouble(txtass7mod3.Text)) / 100;
            }

        }
        if (ass8mod3.Text != "")
        {
            string text = ass8mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod3.Text != "")
            {
                L1cal38 = (weight * Convert.ToDouble(txtass8mod3.Text)) / 100;
            }

        }
        if (ass9mod3.Text != "")
        {
            string text = ass9mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod3.Text != "")
            {
                L1cal39 = (weight * Convert.ToDouble(txtass9mod3.Text)) / 100;
            }

        }
        if (ass10mod3.Text != "")
        {
            string text = ass10mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod3.Text != "")
            {
                L1cal310 = (weight * Convert.ToDouble(txtass10mod3.Text)) / 100;
            }

        }
        TextBox34.Text = Convert.ToString(L1cal31 + L1cal32 + L1cal33 + L1cal34 + L1cal35 + L1cal36 + L1cal37 + L1cal38 + L1cal39 + L1cal310);
        Session["l3weight3"] = TextBox34.Text;
    }
    protected void txtass9mod3_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt29"] = txtass9mod3.Text;
        
        if (ass1mod3.Text != "")
        {
            string text = ass1mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod3.Text != "")
            {
                L1cal31 = (weight * Convert.ToDouble(txtass1mod3.Text.Trim())) / 100;
            }

        }
        if (ass2mod3.Text != "")
        {
            string text = ass2mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod3.Text != "")
            {
                L1cal32 = (weight * Convert.ToDouble(txtass2mod3.Text)) / 100;
            }

        }
        if (ass3mod3.Text != "")
        {
            string text = ass3mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod3.Text != "")
            {
                L1cal33 = (weight * Convert.ToDouble(txtass3mod3.Text)) / 100;
            }

        }
        if (ass4mod3.Text != "")
        {
            string text = ass4mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod3.Text != "")
            {
                L1cal34 = (weight * Convert.ToDouble(txtass4mod3.Text)) / 100;
            }

        }
        if (ass5mod3.Text != "")
        {
            string text = ass5mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod3.Text != "")
            {
                L1cal35 = (weight * Convert.ToDouble(txtass5mod3.Text)) / 100;
            }

        }
        if (ass6mod3.Text != "")
        {
            string text = ass6mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod3.Text != "")
            {
                L1cal36 = (weight * Convert.ToDouble(txtass6mod3.Text)) / 100;
            }

        }
        if (ass7mod3.Text != "")
        {
            string text = ass7mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod3.Text != "")
            {
                L1cal37 = (weight * Convert.ToDouble(txtass7mod3.Text)) / 100;
            }

        }
        if (ass8mod3.Text != "")
        {
            string text = ass8mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod3.Text != "")
            {
                L1cal38 = (weight * Convert.ToDouble(txtass8mod3.Text)) / 100;
            }

        }
        if (ass9mod3.Text != "")
        {
            string text = ass9mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod3.Text != "")
            {
                L1cal39 = (weight * Convert.ToDouble(txtass9mod3.Text)) / 100;
            }

        }
        if (ass10mod3.Text != "")
        {
            string text = ass10mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod3.Text != "")
            {
                L1cal310 = (weight * Convert.ToDouble(txtass10mod3.Text)) / 100;
            }

        }
        TextBox34.Text = Convert.ToString(L1cal31 + L1cal32 + L1cal33 + L1cal34 + L1cal35 + L1cal36 + L1cal37 + L1cal38 + L1cal39 + L1cal310);
        Session["l3weight3"] = TextBox34.Text;
    }
    protected void txtass10mod3_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt30"] = txtass10mod3.Text;
        
        if (ass1mod3.Text != "")
        {
            string text = ass1mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod3.Text != "")
            {
                L1cal31 = (weight * Convert.ToDouble(txtass1mod3.Text.Trim())) / 100;
            }

        }
        if (ass2mod3.Text != "")
        {
            string text = ass2mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod3.Text != "")
            {
                L1cal32 = (weight * Convert.ToDouble(txtass2mod3.Text)) / 100;
            }

        }
        if (ass3mod3.Text != "")
        {
            string text = ass3mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod3.Text != "")
            {
                L1cal33 = (weight * Convert.ToDouble(txtass3mod3.Text)) / 100;
            }

        }
        if (ass4mod3.Text != "")
        {
            string text = ass4mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod3.Text != "")
            {
                L1cal34 = (weight * Convert.ToDouble(txtass4mod3.Text)) / 100;
            }

        }
        if (ass5mod3.Text != "")
        {
            string text = ass5mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod3.Text != "")
            {
                L1cal35 = (weight * Convert.ToDouble(txtass5mod3.Text)) / 100;
            }

        }
        if (ass6mod3.Text != "")
        {
            string text = ass6mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod3.Text != "")
            {
                L1cal36 = (weight * Convert.ToDouble(txtass6mod3.Text)) / 100;
            }

        }
        if (ass7mod3.Text != "")
        {
            string text = ass7mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod3.Text != "")
            {
                L1cal37 = (weight * Convert.ToDouble(txtass7mod3.Text)) / 100;
            }

        }
        if (ass8mod3.Text != "")
        {
            string text = ass8mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod3.Text != "")
            {
                L1cal38 = (weight * Convert.ToDouble(txtass8mod3.Text)) / 100;
            }

        }
        if (ass9mod3.Text != "")
        {
            string text = ass9mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod3.Text != "")
            {
                L1cal39 = (weight * Convert.ToDouble(txtass9mod3.Text)) / 100;
            }

        }
        if (ass10mod3.Text != "")
        {
            string text = ass10mod3.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod3.Text != "")
            {
                L1cal310 = (weight * Convert.ToDouble(txtass10mod3.Text)) / 100;
            }

        }
        TextBox34.Text = Convert.ToString(L1cal31 + L1cal32 + L1cal33 + L1cal34 + L1cal35 + L1cal36 + L1cal37 + L1cal38 + L1cal39 + L1cal310);
        Session["l3weight3"] = TextBox34.Text;
    }
    protected void txtass1mod5_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt41"] = txtass1mod5.Text;
        
        if (ass1mod5.Text != "")
        {
            string text = ass1mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod5.Text != "")
            {
                L1cal51 = (weight * Convert.ToDouble(txtass1mod5.Text.Trim())) / 100;
            }

        }
        if (ass2mod5.Text != "")
        {
            string text = ass2mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod5.Text != "")
            {
                L1cal52 = (weight * Convert.ToDouble(txtass2mod5.Text)) / 100;
            }

        }
        if (ass3mod5.Text != "")
        {
            string text = ass3mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod5.Text != "")
            {
                L1cal53 = (weight * Convert.ToDouble(txtass3mod5.Text)) / 100;
            }

        }
        if (ass4mod5.Text != "")
        {
            string text = ass4mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod5.Text != "")
            {
                L1cal54 = (weight * Convert.ToDouble(txtass4mod5.Text)) / 100;
            }

        }
        if (ass5mod5.Text != "")
        {
            string text = ass5mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod5.Text != "")
            {
                L1cal55 = (weight * Convert.ToDouble(txtass5mod5.Text)) / 100;
            }

        }
        if (ass6mod5.Text != "")
        {
            string text = ass6mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod5.Text != "")
            {
                L1cal56 = (weight * Convert.ToDouble(txtass6mod5.Text)) / 100;
            }

        }
        if (ass7mod5.Text != "")
        {
            string text = ass7mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod5.Text != "")
            {
                L1cal57 = (weight * Convert.ToDouble(txtass7mod5.Text)) / 100;
            }

        }
        if (ass8mod5.Text != "")
        {
            string text = ass8mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod5.Text != "")
            {
                L1cal58 = (weight * Convert.ToDouble(txtass8mod5.Text)) / 100;
            }

        }
        if (ass9mod5.Text != "")
        {
            string text = ass9mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod5.Text != "")
            {
                L1cal59 = (weight * Convert.ToDouble(txtass9mod5.Text)) / 100;
            }

        }
        if (ass10mod5.Text != "")
        {
            string text = ass10mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod5.Text != "")
            {
                L1cal510 = (weight * Convert.ToDouble(txtass10mod5.Text)) / 100;
            }

        }
        TextBox56.Text = Convert.ToString(L1cal51 + L1cal52 + L1cal53 + L1cal54 + L1cal55 + L1cal56 + L1cal57 + L1cal58 + L1cal59 + L1cal510);
        Session["l3weight5"] = TextBox56.Text;
    }
    protected void txtass2mod5_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt41"] = txtass1mod5.Text;

        if (ass1mod5.Text != "")
        {
            string text = ass1mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod5.Text != "")
            {
                L1cal51 = (weight * Convert.ToDouble(txtass1mod5.Text.Trim())) / 100;
            }

        }
        if (ass2mod5.Text != "")
        {
            string text = ass2mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod5.Text != "")
            {
                L1cal52 = (weight * Convert.ToDouble(txtass2mod5.Text)) / 100;
            }

        }
        if (ass3mod5.Text != "")
        {
            string text = ass3mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod5.Text != "")
            {
                L1cal53 = (weight * Convert.ToDouble(txtass3mod5.Text)) / 100;
            }

        }
        if (ass4mod5.Text != "")
        {
            string text = ass4mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod5.Text != "")
            {
                L1cal54 = (weight * Convert.ToDouble(txtass4mod5.Text)) / 100;
            }

        }
        if (ass5mod5.Text != "")
        {
            string text = ass5mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod5.Text != "")
            {
                L1cal55 = (weight * Convert.ToDouble(txtass5mod5.Text)) / 100;
            }

        }
        if (ass6mod5.Text != "")
        {
            string text = ass6mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod5.Text != "")
            {
                L1cal56 = (weight * Convert.ToDouble(txtass6mod5.Text)) / 100;
            }

        }
        if (ass7mod5.Text != "")
        {
            string text = ass7mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod5.Text != "")
            {
                L1cal57 = (weight * Convert.ToDouble(txtass7mod5.Text)) / 100;
            }

        }
        if (ass8mod5.Text != "")
        {
            string text = ass8mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod5.Text != "")
            {
                L1cal58 = (weight * Convert.ToDouble(txtass8mod5.Text)) / 100;
            }

        }
        if (ass9mod5.Text != "")
        {
            string text = ass9mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod5.Text != "")
            {
                L1cal59 = (weight * Convert.ToDouble(txtass9mod5.Text)) / 100;
            }

        }
        if (ass10mod5.Text != "")
        {
            string text = ass10mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod5.Text != "")
            {
                L1cal510 = (weight * Convert.ToDouble(txtass10mod5.Text)) / 100;
            }

        }
        TextBox56.Text = Convert.ToString(L1cal51 + L1cal52 + L1cal53 + L1cal54 + L1cal55 + L1cal56 + L1cal57 + L1cal58 + L1cal59 + L1cal510);
        Session["l3weight5"] = TextBox56.Text;
    }
    protected void txtass3mod5_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt41"] = txtass1mod5.Text;

        if (ass1mod5.Text != "")
        {
            string text = ass1mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod5.Text != "")
            {
                L1cal51 = (weight * Convert.ToDouble(txtass1mod5.Text.Trim())) / 100;
            }

        }
        if (ass2mod5.Text != "")
        {
            string text = ass2mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod5.Text != "")
            {
                L1cal52 = (weight * Convert.ToDouble(txtass2mod5.Text)) / 100;
            }

        }
        if (ass3mod5.Text != "")
        {
            string text = ass3mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod5.Text != "")
            {
                L1cal53 = (weight * Convert.ToDouble(txtass3mod5.Text)) / 100;
            }

        }
        if (ass4mod5.Text != "")
        {
            string text = ass4mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod5.Text != "")
            {
                L1cal54 = (weight * Convert.ToDouble(txtass4mod5.Text)) / 100;
            }

        }
        if (ass5mod5.Text != "")
        {
            string text = ass5mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod5.Text != "")
            {
                L1cal55 = (weight * Convert.ToDouble(txtass5mod5.Text)) / 100;
            }

        }
        if (ass6mod5.Text != "")
        {
            string text = ass6mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod5.Text != "")
            {
                L1cal56 = (weight * Convert.ToDouble(txtass6mod5.Text)) / 100;
            }

        }
        if (ass7mod5.Text != "")
        {
            string text = ass7mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod5.Text != "")
            {
                L1cal57 = (weight * Convert.ToDouble(txtass7mod5.Text)) / 100;
            }

        }
        if (ass8mod5.Text != "")
        {
            string text = ass8mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod5.Text != "")
            {
                L1cal58 = (weight * Convert.ToDouble(txtass8mod5.Text)) / 100;
            }

        }
        if (ass9mod5.Text != "")
        {
            string text = ass9mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod5.Text != "")
            {
                L1cal59 = (weight * Convert.ToDouble(txtass9mod5.Text)) / 100;
            }

        }
        if (ass10mod5.Text != "")
        {
            string text = ass10mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod5.Text != "")
            {
                L1cal510 = (weight * Convert.ToDouble(txtass10mod5.Text)) / 100;
            }

        }
        TextBox56.Text = Convert.ToString(L1cal51 + L1cal52 + L1cal53 + L1cal54 + L1cal55 + L1cal56 + L1cal57 + L1cal58 + L1cal59 + L1cal510);
        Session["l3weight5"] = TextBox56.Text;
    }
    protected void txtass4mod5_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt41"] = txtass1mod5.Text;

        if (ass1mod5.Text != "")
        {
            string text = ass1mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod5.Text != "")
            {
                L1cal51 = (weight * Convert.ToDouble(txtass1mod5.Text.Trim())) / 100;
            }

        }
        if (ass2mod5.Text != "")
        {
            string text = ass2mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod5.Text != "")
            {
                L1cal52 = (weight * Convert.ToDouble(txtass2mod5.Text)) / 100;
            }

        }
        if (ass3mod5.Text != "")
        {
            string text = ass3mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod5.Text != "")
            {
                L1cal53 = (weight * Convert.ToDouble(txtass3mod5.Text)) / 100;
            }

        }
        if (ass4mod5.Text != "")
        {
            string text = ass4mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod5.Text != "")
            {
                L1cal54 = (weight * Convert.ToDouble(txtass4mod5.Text)) / 100;
            }

        }
        if (ass5mod5.Text != "")
        {
            string text = ass5mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod5.Text != "")
            {
                L1cal55 = (weight * Convert.ToDouble(txtass5mod5.Text)) / 100;
            }

        }
        if (ass6mod5.Text != "")
        {
            string text = ass6mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod5.Text != "")
            {
                L1cal56 = (weight * Convert.ToDouble(txtass6mod5.Text)) / 100;
            }

        }
        if (ass7mod5.Text != "")
        {
            string text = ass7mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod5.Text != "")
            {
                L1cal57 = (weight * Convert.ToDouble(txtass7mod5.Text)) / 100;
            }

        }
        if (ass8mod5.Text != "")
        {
            string text = ass8mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod5.Text != "")
            {
                L1cal58 = (weight * Convert.ToDouble(txtass8mod5.Text)) / 100;
            }

        }
        if (ass9mod5.Text != "")
        {
            string text = ass9mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod5.Text != "")
            {
                L1cal59 = (weight * Convert.ToDouble(txtass9mod5.Text)) / 100;
            }

        }
        if (ass10mod5.Text != "")
        {
            string text = ass10mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod5.Text != "")
            {
                L1cal510 = (weight * Convert.ToDouble(txtass10mod5.Text)) / 100;
            }

        }
        TextBox56.Text = Convert.ToString(L1cal51 + L1cal52 + L1cal53 + L1cal54 + L1cal55 + L1cal56 + L1cal57 + L1cal58 + L1cal59 + L1cal510);
        Session["l3weight5"] = TextBox56.Text;
    }
    protected void txtass5mod5_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt41"] = txtass1mod5.Text;

        if (ass1mod5.Text != "")
        {
            string text = ass1mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod5.Text != "")
            {
                L1cal51 = (weight * Convert.ToDouble(txtass1mod5.Text.Trim())) / 100;
            }

        }
        if (ass2mod5.Text != "")
        {
            string text = ass2mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod5.Text != "")
            {
                L1cal52 = (weight * Convert.ToDouble(txtass2mod5.Text)) / 100;
            }

        }
        if (ass3mod5.Text != "")
        {
            string text = ass3mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod5.Text != "")
            {
                L1cal53 = (weight * Convert.ToDouble(txtass3mod5.Text)) / 100;
            }

        }
        if (ass4mod5.Text != "")
        {
            string text = ass4mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod5.Text != "")
            {
                L1cal54 = (weight * Convert.ToDouble(txtass4mod5.Text)) / 100;
            }

        }
        if (ass5mod5.Text != "")
        {
            string text = ass5mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod5.Text != "")
            {
                L1cal55 = (weight * Convert.ToDouble(txtass5mod5.Text)) / 100;
            }

        }
        if (ass6mod5.Text != "")
        {
            string text = ass6mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod5.Text != "")
            {
                L1cal56 = (weight * Convert.ToDouble(txtass6mod5.Text)) / 100;
            }

        }
        if (ass7mod5.Text != "")
        {
            string text = ass7mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod5.Text != "")
            {
                L1cal57 = (weight * Convert.ToDouble(txtass7mod5.Text)) / 100;
            }

        }
        if (ass8mod5.Text != "")
        {
            string text = ass8mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod5.Text != "")
            {
                L1cal58 = (weight * Convert.ToDouble(txtass8mod5.Text)) / 100;
            }

        }
        if (ass9mod5.Text != "")
        {
            string text = ass9mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod5.Text != "")
            {
                L1cal59 = (weight * Convert.ToDouble(txtass9mod5.Text)) / 100;
            }

        }
        if (ass10mod5.Text != "")
        {
            string text = ass10mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod5.Text != "")
            {
                L1cal510 = (weight * Convert.ToDouble(txtass10mod5.Text)) / 100;
            }

        }
        TextBox56.Text = Convert.ToString(L1cal51 + L1cal52 + L1cal53 + L1cal54 + L1cal55 + L1cal56 + L1cal57 + L1cal58 + L1cal59 + L1cal510);
        Session["l3weight5"] = TextBox56.Text;
    }
    protected void txtass6mod5_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt41"] = txtass1mod5.Text;

        if (ass1mod5.Text != "")
        {
            string text = ass1mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod5.Text != "")
            {
                L1cal51 = (weight * Convert.ToDouble(txtass1mod5.Text.Trim())) / 100;
            }

        }
        if (ass2mod5.Text != "")
        {
            string text = ass2mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod5.Text != "")
            {
                L1cal52 = (weight * Convert.ToDouble(txtass2mod5.Text)) / 100;
            }

        }
        if (ass3mod5.Text != "")
        {
            string text = ass3mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod5.Text != "")
            {
                L1cal53 = (weight * Convert.ToDouble(txtass3mod5.Text)) / 100;
            }

        }
        if (ass4mod5.Text != "")
        {
            string text = ass4mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod5.Text != "")
            {
                L1cal54 = (weight * Convert.ToDouble(txtass4mod5.Text)) / 100;
            }

        }
        if (ass5mod5.Text != "")
        {
            string text = ass5mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod5.Text != "")
            {
                L1cal55 = (weight * Convert.ToDouble(txtass5mod5.Text)) / 100;
            }

        }
        if (ass6mod5.Text != "")
        {
            string text = ass6mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod5.Text != "")
            {
                L1cal56 = (weight * Convert.ToDouble(txtass6mod5.Text)) / 100;
            }

        }
        if (ass7mod5.Text != "")
        {
            string text = ass7mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod5.Text != "")
            {
                L1cal57 = (weight * Convert.ToDouble(txtass7mod5.Text)) / 100;
            }

        }
        if (ass8mod5.Text != "")
        {
            string text = ass8mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod5.Text != "")
            {
                L1cal58 = (weight * Convert.ToDouble(txtass8mod5.Text)) / 100;
            }

        }
        if (ass9mod5.Text != "")
        {
            string text = ass9mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod5.Text != "")
            {
                L1cal59 = (weight * Convert.ToDouble(txtass9mod5.Text)) / 100;
            }

        }
        if (ass10mod5.Text != "")
        {
            string text = ass10mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod5.Text != "")
            {
                L1cal510 = (weight * Convert.ToDouble(txtass10mod5.Text)) / 100;
            }

        }
        TextBox56.Text = Convert.ToString(L1cal51 + L1cal52 + L1cal53 + L1cal54 + L1cal55 + L1cal56 + L1cal57 + L1cal58 + L1cal59 + L1cal510);
        Session["l3weight5"] = TextBox56.Text;
    }
    protected void txtass7mod5_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt41"] = txtass1mod5.Text;

        if (ass1mod5.Text != "")
        {
            string text = ass1mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod5.Text != "")
            {
                L1cal51 = (weight * Convert.ToDouble(txtass1mod5.Text.Trim())) / 100;
            }

        }
        if (ass2mod5.Text != "")
        {
            string text = ass2mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod5.Text != "")
            {
                L1cal52 = (weight * Convert.ToDouble(txtass2mod5.Text)) / 100;
            }

        }
        if (ass3mod5.Text != "")
        {
            string text = ass3mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod5.Text != "")
            {
                L1cal53 = (weight * Convert.ToDouble(txtass3mod5.Text)) / 100;
            }

        }
        if (ass4mod5.Text != "")
        {
            string text = ass4mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod5.Text != "")
            {
                L1cal54 = (weight * Convert.ToDouble(txtass4mod5.Text)) / 100;
            }

        }
        if (ass5mod5.Text != "")
        {
            string text = ass5mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod5.Text != "")
            {
                L1cal55 = (weight * Convert.ToDouble(txtass5mod5.Text)) / 100;
            }

        }
        if (ass6mod5.Text != "")
        {
            string text = ass6mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod5.Text != "")
            {
                L1cal56 = (weight * Convert.ToDouble(txtass6mod5.Text)) / 100;
            }

        }
        if (ass7mod5.Text != "")
        {
            string text = ass7mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod5.Text != "")
            {
                L1cal57 = (weight * Convert.ToDouble(txtass7mod5.Text)) / 100;
            }

        }
        if (ass8mod5.Text != "")
        {
            string text = ass8mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod5.Text != "")
            {
                L1cal58 = (weight * Convert.ToDouble(txtass8mod5.Text)) / 100;
            }

        }
        if (ass9mod5.Text != "")
        {
            string text = ass9mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod5.Text != "")
            {
                L1cal59 = (weight * Convert.ToDouble(txtass9mod5.Text)) / 100;
            }

        }
        if (ass10mod5.Text != "")
        {
            string text = ass10mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod5.Text != "")
            {
                L1cal510 = (weight * Convert.ToDouble(txtass10mod5.Text)) / 100;
            }

        }
        TextBox56.Text = Convert.ToString(L1cal51 + L1cal52 + L1cal53 + L1cal54 + L1cal55 + L1cal56 + L1cal57 + L1cal58 + L1cal59 + L1cal510);
        Session["l3weight5"] = TextBox56.Text;
    }
    protected void txtass8mod5_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt41"] = txtass1mod5.Text;

        if (ass1mod5.Text != "")
        {
            string text = ass1mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod5.Text != "")
            {
                L1cal51 = (weight * Convert.ToDouble(txtass1mod5.Text.Trim())) / 100;
            }

        }
        if (ass2mod5.Text != "")
        {
            string text = ass2mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod5.Text != "")
            {
                L1cal52 = (weight * Convert.ToDouble(txtass2mod5.Text)) / 100;
            }

        }
        if (ass3mod5.Text != "")
        {
            string text = ass3mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod5.Text != "")
            {
                L1cal53 = (weight * Convert.ToDouble(txtass3mod5.Text)) / 100;
            }

        }
        if (ass4mod5.Text != "")
        {
            string text = ass4mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod5.Text != "")
            {
                L1cal54 = (weight * Convert.ToDouble(txtass4mod5.Text)) / 100;
            }

        }
        if (ass5mod5.Text != "")
        {
            string text = ass5mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod5.Text != "")
            {
                L1cal55 = (weight * Convert.ToDouble(txtass5mod5.Text)) / 100;
            }

        }
        if (ass6mod5.Text != "")
        {
            string text = ass6mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod5.Text != "")
            {
                L1cal56 = (weight * Convert.ToDouble(txtass6mod5.Text)) / 100;
            }

        }
        if (ass7mod5.Text != "")
        {
            string text = ass7mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod5.Text != "")
            {
                L1cal57 = (weight * Convert.ToDouble(txtass7mod5.Text)) / 100;
            }

        }
        if (ass8mod5.Text != "")
        {
            string text = ass8mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod5.Text != "")
            {
                L1cal58 = (weight * Convert.ToDouble(txtass8mod5.Text)) / 100;
            }

        }
        if (ass9mod5.Text != "")
        {
            string text = ass9mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod5.Text != "")
            {
                L1cal59 = (weight * Convert.ToDouble(txtass9mod5.Text)) / 100;
            }

        }
        if (ass10mod5.Text != "")
        {
            string text = ass10mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod5.Text != "")
            {
                L1cal510 = (weight * Convert.ToDouble(txtass10mod5.Text)) / 100;
            }

        }
        TextBox56.Text = Convert.ToString(L1cal51 + L1cal52 + L1cal53 + L1cal54 + L1cal55 + L1cal56 + L1cal57 + L1cal58 + L1cal59 + L1cal510);
        Session["l3weight5"] = TextBox56.Text;
    }
    protected void txtass9mod5_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt41"] = txtass1mod5.Text;

        if (ass1mod5.Text != "")
        {
            string text = ass1mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod5.Text != "")
            {
                L1cal51 = (weight * Convert.ToDouble(txtass1mod5.Text.Trim())) / 100;
            }

        }
        if (ass2mod5.Text != "")
        {
            string text = ass2mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod5.Text != "")
            {
                L1cal52 = (weight * Convert.ToDouble(txtass2mod5.Text)) / 100;
            }

        }
        if (ass3mod5.Text != "")
        {
            string text = ass3mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod5.Text != "")
            {
                L1cal53 = (weight * Convert.ToDouble(txtass3mod5.Text)) / 100;
            }

        }
        if (ass4mod5.Text != "")
        {
            string text = ass4mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod5.Text != "")
            {
                L1cal54 = (weight * Convert.ToDouble(txtass4mod5.Text)) / 100;
            }

        }
        if (ass5mod5.Text != "")
        {
            string text = ass5mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod5.Text != "")
            {
                L1cal55 = (weight * Convert.ToDouble(txtass5mod5.Text)) / 100;
            }

        }
        if (ass6mod5.Text != "")
        {
            string text = ass6mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod5.Text != "")
            {
                L1cal56 = (weight * Convert.ToDouble(txtass6mod5.Text)) / 100;
            }

        }
        if (ass7mod5.Text != "")
        {
            string text = ass7mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod5.Text != "")
            {
                L1cal57 = (weight * Convert.ToDouble(txtass7mod5.Text)) / 100;
            }

        }
        if (ass8mod5.Text != "")
        {
            string text = ass8mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod5.Text != "")
            {
                L1cal58 = (weight * Convert.ToDouble(txtass8mod5.Text)) / 100;
            }

        }
        if (ass9mod5.Text != "")
        {
            string text = ass9mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod5.Text != "")
            {
                L1cal59 = (weight * Convert.ToDouble(txtass9mod5.Text)) / 100;
            }

        }
        if (ass10mod5.Text != "")
        {
            string text = ass10mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod5.Text != "")
            {
                L1cal510 = (weight * Convert.ToDouble(txtass10mod5.Text)) / 100;
            }

        }
        TextBox56.Text = Convert.ToString(L1cal51 + L1cal52 + L1cal53 + L1cal54 + L1cal55 + L1cal56 + L1cal57 + L1cal58 + L1cal59 + L1cal510);
        Session["l3weight5"] = TextBox56.Text;
    }
    protected void txtass10mod5_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt41"] = txtass1mod5.Text;

        if (ass1mod5.Text != "")
        {
            string text = ass1mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod5.Text != "")
            {
                L1cal51 = (weight * Convert.ToDouble(txtass1mod5.Text.Trim())) / 100;
            }

        }
        if (ass2mod5.Text != "")
        {
            string text = ass2mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod5.Text != "")
            {
                L1cal52 = (weight * Convert.ToDouble(txtass2mod5.Text)) / 100;
            }

        }
        if (ass3mod5.Text != "")
        {
            string text = ass3mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod5.Text != "")
            {
                L1cal53 = (weight * Convert.ToDouble(txtass3mod5.Text)) / 100;
            }

        }
        if (ass4mod5.Text != "")
        {
            string text = ass4mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod5.Text != "")
            {
                L1cal54 = (weight * Convert.ToDouble(txtass4mod5.Text)) / 100;
            }

        }
        if (ass5mod5.Text != "")
        {
            string text = ass5mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod5.Text != "")
            {
                L1cal55 = (weight * Convert.ToDouble(txtass5mod5.Text)) / 100;
            }

        }
        if (ass6mod5.Text != "")
        {
            string text = ass6mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod5.Text != "")
            {
                L1cal56 = (weight * Convert.ToDouble(txtass6mod5.Text)) / 100;
            }

        }
        if (ass7mod5.Text != "")
        {
            string text = ass7mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod5.Text != "")
            {
                L1cal57 = (weight * Convert.ToDouble(txtass7mod5.Text)) / 100;
            }

        }
        if (ass8mod5.Text != "")
        {
            string text = ass8mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod5.Text != "")
            {
                L1cal58 = (weight * Convert.ToDouble(txtass8mod5.Text)) / 100;
            }

        }
        if (ass9mod5.Text != "")
        {
            string text = ass9mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod5.Text != "")
            {
                L1cal59 = (weight * Convert.ToDouble(txtass9mod5.Text)) / 100;
            }

        }
        if (ass10mod5.Text != "")
        {
            string text = ass10mod5.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod5.Text != "")
            {
                L1cal510 = (weight * Convert.ToDouble(txtass10mod5.Text)) / 100;
            }

        }
        TextBox56.Text = Convert.ToString(L1cal51 + L1cal52 + L1cal53 + L1cal54 + L1cal55 + L1cal56 + L1cal57 + L1cal58 + L1cal59 + L1cal510);
        Session["l3weight5"] = TextBox56.Text;
    }
    protected void txtass1mod6_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt51"] = txtass1mod6.Text;
       
        if (ass1mod6.Text != "")
        {
            string text = ass1mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod6.Text != "")
            {
                L1cal61 = (weight * Convert.ToDouble(txtass1mod6.Text.Trim())) / 100;
            }

        }
        if (ass2mod6.Text != "")
        {
            string text = ass2mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod6.Text != "")
            {
                L1cal62 = (weight * Convert.ToDouble(txtass2mod6.Text)) / 100;
            }

        }
        if (ass3mod6.Text != "")
        {
            string text = ass3mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod6.Text != "")
            {
                L1cal63 = (weight * Convert.ToDouble(txtass3mod6.Text)) / 100;
            }

        }
        if (ass4mod6.Text != "")
        {
            string text = ass4mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod6.Text != "")
            {
                L1cal64 = (weight * Convert.ToDouble(txtass4mod6.Text)) / 100;
            }

        }
        if (ass5mod6.Text != "")
        {
            string text = ass5mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod6.Text != "")
            {
                L1cal65 = (weight * Convert.ToDouble(txtass5mod6.Text)) / 100;
            }

        }
        if (ass6mod6.Text != "")
        {
            string text = ass6mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod6.Text != "")
            {
                L1cal66 = (weight * Convert.ToDouble(txtass6mod6.Text)) / 100;
            }

        }
        if (ass7mod6.Text != "")
        {
            string text = ass7mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod6.Text != "")
            {
                L1cal67 = (weight * Convert.ToDouble(txtass7mod6.Text)) / 100;
            }

        }
        if (ass8mod6.Text != "")
        {
            string text = ass8mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod6.Text != "")
            {
                L1cal68 = (weight * Convert.ToDouble(txtass8mod6.Text)) / 100;
            }

        }
        if (ass9mod6.Text != "")
        {
            string text = ass9mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod6.Text != "")
            {
                L1cal69 = (weight * Convert.ToDouble(txtass9mod6.Text)) / 100;
            }

        }
        if (ass10mod6.Text != "")
        {
            string text = ass10mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod6.Text != "")
            {
                L1cal610 = (weight * Convert.ToDouble(txtass10mod6.Text)) / 100;
            }

        }
        TextBox67.Text = Convert.ToString(L1cal61 + L1cal62 + L1cal63 + L1cal64 + L1cal65 + L1cal66 + L1cal67 + L1cal68 + L1cal69 + L1cal610);
        Session["l3weight6"] = TextBox67.Text;
    }
    protected void txtass2mod6_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt52"] = txtass2mod6.Text;
       
        if (ass1mod6.Text != "")
        {
            string text = ass1mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod6.Text != "")
            {
                L1cal61 = (weight * Convert.ToDouble(txtass1mod6.Text.Trim())) / 100;
            }

        }
        if (ass2mod6.Text != "")
        {
            string text = ass2mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod6.Text != "")
            {
                L1cal62 = (weight * Convert.ToDouble(txtass2mod6.Text)) / 100;
            }

        }
        if (ass3mod6.Text != "")
        {
            string text = ass3mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod6.Text != "")
            {
                L1cal63 = (weight * Convert.ToDouble(txtass3mod6.Text)) / 100;
            }

        }
        if (ass4mod6.Text != "")
        {
            string text = ass4mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod6.Text != "")
            {
                L1cal64 = (weight * Convert.ToDouble(txtass4mod6.Text)) / 100;
            }

        }
        if (ass5mod6.Text != "")
        {
            string text = ass5mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod6.Text != "")
            {
                L1cal65 = (weight * Convert.ToDouble(txtass5mod6.Text)) / 100;
            }

        }
        if (ass6mod6.Text != "")
        {
            string text = ass6mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod6.Text != "")
            {
                L1cal66 = (weight * Convert.ToDouble(txtass6mod6.Text)) / 100;
            }

        }
        if (ass7mod6.Text != "")
        {
            string text = ass7mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod6.Text != "")
            {
                L1cal67 = (weight * Convert.ToDouble(txtass7mod6.Text)) / 100;
            }

        }
        if (ass8mod6.Text != "")
        {
            string text = ass8mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod6.Text != "")
            {
                L1cal68 = (weight * Convert.ToDouble(txtass8mod6.Text)) / 100;
            }

        }
        if (ass9mod6.Text != "")
        {
            string text = ass9mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod6.Text != "")
            {
                L1cal69 = (weight * Convert.ToDouble(txtass9mod6.Text)) / 100;
            }

        }
        if (ass10mod6.Text != "")
        {
            string text = ass10mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod6.Text != "")
            {
                L1cal610 = (weight * Convert.ToDouble(txtass10mod6.Text)) / 100;
            }

        }
        TextBox67.Text = Convert.ToString(L1cal61 + L1cal62 + L1cal63 + L1cal64 + L1cal65 + L1cal66 + L1cal67 + L1cal68 + L1cal69 + L1cal610);
        Session["l3weight6"] = TextBox67.Text;
    }
    protected void txtass3mod6_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt53"] = txtass3mod6.Text;
       
        if (ass1mod6.Text != "")
        {
            string text = ass1mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod6.Text != "")
            {
                L1cal61 = (weight * Convert.ToDouble(txtass1mod6.Text.Trim())) / 100;
            }

        }
        if (ass2mod6.Text != "")
        {
            string text = ass2mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod6.Text != "")
            {
                L1cal62 = (weight * Convert.ToDouble(txtass2mod6.Text)) / 100;
            }

        }
        if (ass3mod6.Text != "")
        {
            string text = ass3mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod6.Text != "")
            {
                L1cal63 = (weight * Convert.ToDouble(txtass3mod6.Text)) / 100;
            }

        }
        if (ass4mod6.Text != "")
        {
            string text = ass4mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod6.Text != "")
            {
                L1cal64 = (weight * Convert.ToDouble(txtass4mod6.Text)) / 100;
            }

        }
        if (ass5mod6.Text != "")
        {
            string text = ass5mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod6.Text != "")
            {
                L1cal65 = (weight * Convert.ToDouble(txtass5mod6.Text)) / 100;
            }

        }
        if (ass6mod6.Text != "")
        {
            string text = ass6mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod6.Text != "")
            {
                L1cal66 = (weight * Convert.ToDouble(txtass6mod6.Text)) / 100;
            }

        }
        if (ass7mod6.Text != "")
        {
            string text = ass7mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod6.Text != "")
            {
                L1cal67 = (weight * Convert.ToDouble(txtass7mod6.Text)) / 100;
            }

        }
        if (ass8mod6.Text != "")
        {
            string text = ass8mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod6.Text != "")
            {
                L1cal68 = (weight * Convert.ToDouble(txtass8mod6.Text)) / 100;
            }

        }
        if (ass9mod6.Text != "")
        {
            string text = ass9mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod6.Text != "")
            {
                L1cal69 = (weight * Convert.ToDouble(txtass9mod6.Text)) / 100;
            }

        }
        if (ass10mod6.Text != "")
        {
            string text = ass10mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod6.Text != "")
            {
                L1cal610 = (weight * Convert.ToDouble(txtass10mod6.Text)) / 100;
            }

        }
        TextBox67.Text = Convert.ToString(L1cal61 + L1cal62 + L1cal63 + L1cal64 + L1cal65 + L1cal66 + L1cal67 + L1cal68 + L1cal69 + L1cal610);
        Session["l3weight6"] = TextBox67.Text;
    }
    protected void txtass4mod6_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt54"] = txtass4mod6.Text;
       
        if (ass1mod6.Text != "")
        {
            string text = ass1mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod6.Text != "")
            {
                L1cal61 = (weight * Convert.ToDouble(txtass1mod6.Text.Trim())) / 100;
            }

        }
        if (ass2mod6.Text != "")
        {
            string text = ass2mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod6.Text != "")
            {
                L1cal62 = (weight * Convert.ToDouble(txtass2mod6.Text)) / 100;
            }

        }
        if (ass3mod6.Text != "")
        {
            string text = ass3mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod6.Text != "")
            {
                L1cal63 = (weight * Convert.ToDouble(txtass3mod6.Text)) / 100;
            }

        }
        if (ass4mod6.Text != "")
        {
            string text = ass4mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod6.Text != "")
            {
                L1cal64 = (weight * Convert.ToDouble(txtass4mod6.Text)) / 100;
            }

        }
        if (ass5mod6.Text != "")
        {
            string text = ass5mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod6.Text != "")
            {
                L1cal65 = (weight * Convert.ToDouble(txtass5mod6.Text)) / 100;
            }

        }
        if (ass6mod6.Text != "")
        {
            string text = ass6mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod6.Text != "")
            {
                L1cal66 = (weight * Convert.ToDouble(txtass6mod6.Text)) / 100;
            }

        }
        if (ass7mod6.Text != "")
        {
            string text = ass7mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod6.Text != "")
            {
                L1cal67 = (weight * Convert.ToDouble(txtass7mod6.Text)) / 100;
            }

        }
        if (ass8mod6.Text != "")
        {
            string text = ass8mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod6.Text != "")
            {
                L1cal68 = (weight * Convert.ToDouble(txtass8mod6.Text)) / 100;
            }

        }
        if (ass9mod6.Text != "")
        {
            string text = ass9mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod6.Text != "")
            {
                L1cal69 = (weight * Convert.ToDouble(txtass9mod6.Text)) / 100;
            }

        }
        if (ass10mod6.Text != "")
        {
            string text = ass10mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod6.Text != "")
            {
                L1cal610 = (weight * Convert.ToDouble(txtass10mod6.Text)) / 100;
            }

        }
        TextBox67.Text = Convert.ToString(L1cal61 + L1cal62 + L1cal63 + L1cal64 + L1cal65 + L1cal66 + L1cal67 + L1cal68 + L1cal69 + L1cal610);
        Session["l3weight6"] = TextBox67.Text;
    }
    protected void txtass5mod6_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt55"] = txtass5mod6.Text;
      
        if (ass1mod6.Text != "")
        {
            string text = ass1mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod6.Text != "")
            {
                L1cal61 = (weight * Convert.ToDouble(txtass1mod6.Text.Trim())) / 100;
            }

        }
        if (ass2mod6.Text != "")
        {
            string text = ass2mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod6.Text != "")
            {
                L1cal62 = (weight * Convert.ToDouble(txtass2mod6.Text)) / 100;
            }

        }
        if (ass3mod6.Text != "")
        {
            string text = ass3mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod6.Text != "")
            {
                L1cal63 = (weight * Convert.ToDouble(txtass3mod6.Text)) / 100;
            }

        }
        if (ass4mod6.Text != "")
        {
            string text = ass4mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod6.Text != "")
            {
                L1cal64 = (weight * Convert.ToDouble(txtass4mod6.Text)) / 100;
            }

        }
        if (ass5mod6.Text != "")
        {
            string text = ass5mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod6.Text != "")
            {
                L1cal65 = (weight * Convert.ToDouble(txtass5mod6.Text)) / 100;
            }

        }
        if (ass6mod6.Text != "")
        {
            string text = ass6mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod6.Text != "")
            {
                L1cal66 = (weight * Convert.ToDouble(txtass6mod6.Text)) / 100;
            }

        }
        if (ass7mod6.Text != "")
        {
            string text = ass7mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod6.Text != "")
            {
                L1cal67 = (weight * Convert.ToDouble(txtass7mod6.Text)) / 100;
            }

        }
        if (ass8mod6.Text != "")
        {
            string text = ass8mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod6.Text != "")
            {
                L1cal68 = (weight * Convert.ToDouble(txtass8mod6.Text)) / 100;
            }

        }
        if (ass9mod6.Text != "")
        {
            string text = ass9mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod6.Text != "")
            {
                L1cal69 = (weight * Convert.ToDouble(txtass9mod6.Text)) / 100;
            }

        }
        if (ass10mod6.Text != "")
        {
            string text = ass10mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod6.Text != "")
            {
                L1cal610 = (weight * Convert.ToDouble(txtass10mod6.Text)) / 100;
            }

        }
        TextBox67.Text = Convert.ToString(L1cal61 + L1cal62 + L1cal63 + L1cal64 + L1cal65 + L1cal66 + L1cal67 + L1cal68 + L1cal69 + L1cal610);
        Session["l3weight6"] = TextBox67.Text;
    }
    protected void txtass6mod6_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt56"] = txtass6mod6.Text;
       
        if (ass1mod6.Text != "")
        {
            string text = ass1mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod6.Text != "")
            {
                L1cal61 = (weight * Convert.ToDouble(txtass1mod6.Text.Trim())) / 100;
            }

        }
        if (ass2mod6.Text != "")
        {
            string text = ass2mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod6.Text != "")
            {
                L1cal62 = (weight * Convert.ToDouble(txtass2mod6.Text)) / 100;
            }

        }
        if (ass3mod6.Text != "")
        {
            string text = ass3mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod6.Text != "")
            {
                L1cal63 = (weight * Convert.ToDouble(txtass3mod6.Text)) / 100;
            }

        }
        if (ass4mod6.Text != "")
        {
            string text = ass4mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod6.Text != "")
            {
                L1cal64 = (weight * Convert.ToDouble(txtass4mod6.Text)) / 100;
            }

        }
        if (ass5mod6.Text != "")
        {
            string text = ass5mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod6.Text != "")
            {
                L1cal65 = (weight * Convert.ToDouble(txtass5mod6.Text)) / 100;
            }

        }
        if (ass6mod6.Text != "")
        {
            string text = ass6mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod6.Text != "")
            {
                L1cal66 = (weight * Convert.ToDouble(txtass6mod6.Text)) / 100;
            }

        }
        if (ass7mod6.Text != "")
        {
            string text = ass7mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod6.Text != "")
            {
                L1cal67 = (weight * Convert.ToDouble(txtass7mod6.Text)) / 100;
            }

        }
        if (ass8mod6.Text != "")
        {
            string text = ass8mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod6.Text != "")
            {
                L1cal68 = (weight * Convert.ToDouble(txtass8mod6.Text)) / 100;
            }

        }
        if (ass9mod6.Text != "")
        {
            string text = ass9mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod6.Text != "")
            {
                L1cal69 = (weight * Convert.ToDouble(txtass9mod6.Text)) / 100;
            }

        }
        if (ass10mod6.Text != "")
        {
            string text = ass10mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod6.Text != "")
            {
                L1cal610 = (weight * Convert.ToDouble(txtass10mod6.Text)) / 100;
            }

        }
        TextBox67.Text = Convert.ToString(L1cal61 + L1cal62 + L1cal63 + L1cal64 + L1cal65 + L1cal66 + L1cal67 + L1cal68 + L1cal69 + L1cal610);
        Session["l3weight6"] = TextBox67.Text;
    }
    protected void txtass7mod6_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt57"] = txtass7mod6.Text;
       
        if (ass1mod6.Text != "")
        {
            string text = ass1mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod6.Text != "")
            {
                L1cal61 = (weight * Convert.ToDouble(txtass1mod6.Text.Trim())) / 100;
            }

        }
        if (ass2mod6.Text != "")
        {
            string text = ass2mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod6.Text != "")
            {
                L1cal62 = (weight * Convert.ToDouble(txtass2mod6.Text)) / 100;
            }

        }
        if (ass3mod6.Text != "")
        {
            string text = ass3mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod6.Text != "")
            {
                L1cal63 = (weight * Convert.ToDouble(txtass3mod6.Text)) / 100;
            }

        }
        if (ass4mod6.Text != "")
        {
            string text = ass4mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod6.Text != "")
            {
                L1cal64 = (weight * Convert.ToDouble(txtass4mod6.Text)) / 100;
            }

        }
        if (ass5mod6.Text != "")
        {
            string text = ass5mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod6.Text != "")
            {
                L1cal65 = (weight * Convert.ToDouble(txtass5mod6.Text)) / 100;
            }

        }
        if (ass6mod6.Text != "")
        {
            string text = ass6mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod6.Text != "")
            {
                L1cal66 = (weight * Convert.ToDouble(txtass6mod6.Text)) / 100;
            }

        }
        if (ass7mod6.Text != "")
        {
            string text = ass7mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod6.Text != "")
            {
                L1cal67 = (weight * Convert.ToDouble(txtass7mod6.Text)) / 100;
            }

        }
        if (ass8mod6.Text != "")
        {
            string text = ass8mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod6.Text != "")
            {
                L1cal68 = (weight * Convert.ToDouble(txtass8mod6.Text)) / 100;
            }

        }
        if (ass9mod6.Text != "")
        {
            string text = ass9mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod6.Text != "")
            {
                L1cal69 = (weight * Convert.ToDouble(txtass9mod6.Text)) / 100;
            }

        }
        if (ass10mod6.Text != "")
        {
            string text = ass10mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod6.Text != "")
            {
                L1cal610 = (weight * Convert.ToDouble(txtass10mod6.Text)) / 100;
            }

        }
        TextBox67.Text = Convert.ToString(L1cal61 + L1cal62 + L1cal63 + L1cal64 + L1cal65 + L1cal66 + L1cal67 + L1cal68 + L1cal69 + L1cal610);
        Session["l3weight6"] = TextBox67.Text;
    }
    protected void txtass8mod6_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt58"] = txtass8mod6.Text;
      
        if (ass1mod6.Text != "")
        {
            string text = ass1mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod6.Text != "")
            {
                L1cal61 = (weight * Convert.ToDouble(txtass1mod6.Text.Trim())) / 100;
            }

        }
        if (ass2mod6.Text != "")
        {
            string text = ass2mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod6.Text != "")
            {
                L1cal62 = (weight * Convert.ToDouble(txtass2mod6.Text)) / 100;
            }

        }
        if (ass3mod6.Text != "")
        {
            string text = ass3mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod6.Text != "")
            {
                L1cal63 = (weight * Convert.ToDouble(txtass3mod6.Text)) / 100;
            }

        }
        if (ass4mod6.Text != "")
        {
            string text = ass4mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod6.Text != "")
            {
                L1cal64 = (weight * Convert.ToDouble(txtass4mod6.Text)) / 100;
            }

        }
        if (ass5mod6.Text != "")
        {
            string text = ass5mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod6.Text != "")
            {
                L1cal65 = (weight * Convert.ToDouble(txtass5mod6.Text)) / 100;
            }

        }
        if (ass6mod6.Text != "")
        {
            string text = ass6mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod6.Text != "")
            {
                L1cal66 = (weight * Convert.ToDouble(txtass6mod6.Text)) / 100;
            }

        }
        if (ass7mod6.Text != "")
        {
            string text = ass7mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod6.Text != "")
            {
                L1cal67 = (weight * Convert.ToDouble(txtass7mod6.Text)) / 100;
            }

        }
        if (ass8mod6.Text != "")
        {
            string text = ass8mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod6.Text != "")
            {
                L1cal68 = (weight * Convert.ToDouble(txtass8mod6.Text)) / 100;
            }

        }
        if (ass9mod6.Text != "")
        {
            string text = ass9mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod6.Text != "")
            {
                L1cal69 = (weight * Convert.ToDouble(txtass9mod6.Text)) / 100;
            }

        }
        if (ass10mod6.Text != "")
        {
            string text = ass10mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod6.Text != "")
            {
                L1cal610 = (weight * Convert.ToDouble(txtass10mod6.Text)) / 100;
            }

        }
        TextBox67.Text = Convert.ToString(L1cal61 + L1cal62 + L1cal63 + L1cal64 + L1cal65 + L1cal66 + L1cal67 + L1cal68 + L1cal69 + L1cal610);
        Session["l3weight6"] = TextBox67.Text;
    }
    protected void txtass9mod6_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt59"] = txtass9mod6.Text;
        
        if (ass1mod6.Text != "")
        {
            string text = ass1mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod6.Text != "")
            {
                L1cal61 = (weight * Convert.ToDouble(txtass1mod6.Text.Trim())) / 100;
            }

        }
        if (ass2mod6.Text != "")
        {
            string text = ass2mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod6.Text != "")
            {
                L1cal62 = (weight * Convert.ToDouble(txtass2mod6.Text)) / 100;
            }

        }
        if (ass3mod6.Text != "")
        {
            string text = ass3mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod6.Text != "")
            {
                L1cal63 = (weight * Convert.ToDouble(txtass3mod6.Text)) / 100;
            }

        }
        if (ass4mod6.Text != "")
        {
            string text = ass4mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod6.Text != "")
            {
                L1cal64 = (weight * Convert.ToDouble(txtass4mod6.Text)) / 100;
            }

        }
        if (ass5mod6.Text != "")
        {
            string text = ass5mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod6.Text != "")
            {
                L1cal65 = (weight * Convert.ToDouble(txtass5mod6.Text)) / 100;
            }

        }
        if (ass6mod6.Text != "")
        {
            string text = ass6mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod6.Text != "")
            {
                L1cal66 = (weight * Convert.ToDouble(txtass6mod6.Text)) / 100;
            }

        }
        if (ass7mod6.Text != "")
        {
            string text = ass7mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod6.Text != "")
            {
                L1cal67 = (weight * Convert.ToDouble(txtass7mod6.Text)) / 100;
            }

        }
        if (ass8mod6.Text != "")
        {
            string text = ass8mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod6.Text != "")
            {
                L1cal68 = (weight * Convert.ToDouble(txtass8mod6.Text)) / 100;
            }

        }
        if (ass9mod6.Text != "")
        {
            string text = ass9mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod6.Text != "")
            {
                L1cal69 = (weight * Convert.ToDouble(txtass9mod6.Text)) / 100;
            }

        }
        if (ass10mod6.Text != "")
        {
            string text = ass10mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod6.Text != "")
            {
                L1cal610 = (weight * Convert.ToDouble(txtass10mod6.Text)) / 100;
            }

        }
        TextBox67.Text = Convert.ToString(L1cal61 + L1cal62 + L1cal63 + L1cal64 + L1cal65 + L1cal66 + L1cal67 + L1cal68 + L1cal69 + L1cal610);
        Session["l3weight6"] = TextBox67.Text;
    }
    protected void txtass10mod6_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt60"] = txtass10mod6.Text;
       
        if (ass1mod6.Text != "")
        {
            string text = ass1mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod6.Text != "")
            {
                L1cal61 = (weight * Convert.ToDouble(txtass1mod6.Text.Trim())) / 100;
            }

        }
        if (ass2mod6.Text != "")
        {
            string text = ass2mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod6.Text != "")
            {
                L1cal62 = (weight * Convert.ToDouble(txtass2mod6.Text)) / 100;
            }

        }
        if (ass3mod6.Text != "")
        {
            string text = ass3mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod6.Text != "")
            {
                L1cal63 = (weight * Convert.ToDouble(txtass3mod6.Text)) / 100;
            }

        }
        if (ass4mod6.Text != "")
        {
            string text = ass4mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod6.Text != "")
            {
                L1cal64 = (weight * Convert.ToDouble(txtass4mod6.Text)) / 100;
            }

        }
        if (ass5mod6.Text != "")
        {
            string text = ass5mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod6.Text != "")
            {
                L1cal65 = (weight * Convert.ToDouble(txtass5mod6.Text)) / 100;
            }

        }
        if (ass6mod6.Text != "")
        {
            string text = ass6mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod6.Text != "")
            {
                L1cal66 = (weight * Convert.ToDouble(txtass6mod6.Text)) / 100;
            }

        }
        if (ass7mod6.Text != "")
        {
            string text = ass7mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod6.Text != "")
            {
                L1cal67 = (weight * Convert.ToDouble(txtass7mod6.Text)) / 100;
            }

        }
        if (ass8mod6.Text != "")
        {
            string text = ass8mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod6.Text != "")
            {
                L1cal68 = (weight * Convert.ToDouble(txtass8mod6.Text)) / 100;
            }

        }
        if (ass9mod6.Text != "")
        {
            string text = ass9mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod6.Text != "")
            {
                L1cal69 = (weight * Convert.ToDouble(txtass9mod6.Text)) / 100;
            }

        }
        if (ass10mod6.Text != "")
        {
            string text = ass10mod6.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod6.Text != "")
            {
                L1cal610 = (weight * Convert.ToDouble(txtass10mod6.Text)) / 100;
            }

        }
        TextBox67.Text = Convert.ToString(L1cal61 + L1cal62 + L1cal63 + L1cal64 + L1cal65 + L1cal66 + L1cal67 + L1cal68 + L1cal69 + L1cal610);
        Session["l3weight6"] = TextBox67.Text;
    }
    protected void txtass1mod7_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt61"] = txtass1mod7.Text;
       
        if (ass1mod7.Text != "")
        {
            string text = ass1mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod7.Text != "")
            {
                L1cal71 = (weight * Convert.ToDouble(txtass1mod7.Text.Trim())) / 100;
            }

        }
        if (ass2mod7.Text != "")
        {
            string text = ass2mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod7.Text != "")
            {
                L1cal72 = (weight * Convert.ToDouble(txtass2mod7.Text)) / 100;
            }

        }
        if (ass3mod7.Text != "")
        {
            string text = ass3mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod7.Text != "")
            {
                L1cal73 = (weight * Convert.ToDouble(txtass3mod7.Text)) / 100;
            }

        }
        if (ass4mod7.Text != "")
        {
            string text = ass4mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod7.Text != "")
            {
                L1cal74 = (weight * Convert.ToDouble(txtass4mod7.Text)) / 100;
            }

        }
        if (ass5mod7.Text != "")
        {
            string text = ass5mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod7.Text != "")
            {
                L1cal75 = (weight * Convert.ToDouble(txtass5mod7.Text)) / 100;
            }

        }
        if (ass6mod7.Text != "")
        {
            string text = ass6mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod7.Text != "")
            {
                L1cal76 = (weight * Convert.ToDouble(txtass6mod7.Text)) / 100;
            }

        }
        if (ass7mod7.Text != "")
        {
            string text = ass7mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod7.Text != "")
            {
                L1cal77 = (weight * Convert.ToDouble(txtass7mod7.Text)) / 100;
            }

        }
        if (ass8mod7.Text != "")
        {
            string text = ass8mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod7.Text != "")
            {
                L1cal78 = (weight * Convert.ToDouble(txtass8mod7.Text)) / 100;
            }

        }
        if (ass9mod7.Text != "")
        {
            string text = ass9mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod7.Text != "")
            {
                L1cal79 = (weight * Convert.ToDouble(txtass9mod7.Text)) / 100;
            }

        }
        if (ass10mod7.Text != "")
        {
            string text = ass10mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod7.Text != "")
            {
                L1cal710 = (weight * Convert.ToDouble(txtass10mod7.Text)) / 100;
            }

        }
        TextBox78.Text = Convert.ToString(L1cal71 + L1cal72 + L1cal73 + L1cal74 + L1cal75 + L1cal76 + L1cal77 + L1cal78 + L1cal79 + L1cal710);
        Session["l3weight7"] = TextBox78.Text;
    }
    protected void txtass2mod7_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt62"] = txtass2mod7.Text;
        
        if (ass1mod7.Text != "")
        {
            string text = ass1mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod7.Text != "")
            {
                L1cal71 = (weight * Convert.ToDouble(txtass1mod7.Text.Trim())) / 100;
            }

        }
        if (ass2mod7.Text != "")
        {
            string text = ass2mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod7.Text != "")
            {
                L1cal72 = (weight * Convert.ToDouble(txtass2mod7.Text)) / 100;
            }

        }
        if (ass3mod7.Text != "")
        {
            string text = ass3mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod7.Text != "")
            {
                L1cal73 = (weight * Convert.ToDouble(txtass3mod7.Text)) / 100;
            }

        }
        if (ass4mod7.Text != "")
        {
            string text = ass4mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod7.Text != "")
            {
                L1cal74 = (weight * Convert.ToDouble(txtass4mod7.Text)) / 100;
            }

        }
        if (ass5mod7.Text != "")
        {
            string text = ass5mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod7.Text != "")
            {
                L1cal75 = (weight * Convert.ToDouble(txtass5mod7.Text)) / 100;
            }

        }
        if (ass6mod7.Text != "")
        {
            string text = ass6mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod7.Text != "")
            {
                L1cal76 = (weight * Convert.ToDouble(txtass6mod7.Text)) / 100;
            }

        }
        if (ass7mod7.Text != "")
        {
            string text = ass7mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod7.Text != "")
            {
                L1cal77 = (weight * Convert.ToDouble(txtass7mod7.Text)) / 100;
            }

        }
        if (ass8mod7.Text != "")
        {
            string text = ass8mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod7.Text != "")
            {
                L1cal78 = (weight * Convert.ToDouble(txtass8mod7.Text)) / 100;
            }

        }
        if (ass9mod7.Text != "")
        {
            string text = ass9mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod7.Text != "")
            {
                L1cal79 = (weight * Convert.ToDouble(txtass9mod7.Text)) / 100;
            }

        }
        if (ass10mod7.Text != "")
        {
            string text = ass10mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod7.Text != "")
            {
                L1cal710 = (weight * Convert.ToDouble(txtass10mod7.Text)) / 100;
            }

        }
        TextBox78.Text = Convert.ToString(L1cal71 + L1cal72 + L1cal73 + L1cal74 + L1cal75 + L1cal76 + L1cal77 + L1cal78 + L1cal79 + L1cal710);
        Session["l3weight7"] = TextBox78.Text;

    }
    protected void txtass3mod7_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt63"] = txtass3mod7.Text;
       
        if (ass1mod7.Text != "")
        {
            string text = ass1mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod7.Text != "")
            {
                L1cal71 = (weight * Convert.ToDouble(txtass1mod7.Text.Trim())) / 100;
            }

        }
        if (ass2mod7.Text != "")
        {
            string text = ass2mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod7.Text != "")
            {
                L1cal72 = (weight * Convert.ToDouble(txtass2mod7.Text)) / 100;
            }

        }
        if (ass3mod7.Text != "")
        {
            string text = ass3mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod7.Text != "")
            {
                L1cal73 = (weight * Convert.ToDouble(txtass3mod7.Text)) / 100;
            }

        }
        if (ass4mod7.Text != "")
        {
            string text = ass4mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod7.Text != "")
            {
                L1cal74 = (weight * Convert.ToDouble(txtass4mod7.Text)) / 100;
            }

        }
        if (ass5mod7.Text != "")
        {
            string text = ass5mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod7.Text != "")
            {
                L1cal75 = (weight * Convert.ToDouble(txtass5mod7.Text)) / 100;
            }

        }
        if (ass6mod7.Text != "")
        {
            string text = ass6mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod7.Text != "")
            {
                L1cal76 = (weight * Convert.ToDouble(txtass6mod7.Text)) / 100;
            }

        }
        if (ass7mod7.Text != "")
        {
            string text = ass7mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod7.Text != "")
            {
                L1cal77 = (weight * Convert.ToDouble(txtass7mod7.Text)) / 100;
            }

        }
        if (ass8mod7.Text != "")
        {
            string text = ass8mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod7.Text != "")
            {
                L1cal78 = (weight * Convert.ToDouble(txtass8mod7.Text)) / 100;
            }

        }
        if (ass9mod7.Text != "")
        {
            string text = ass9mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod7.Text != "")
            {
                L1cal79 = (weight * Convert.ToDouble(txtass9mod7.Text)) / 100;
            }

        }
        if (ass10mod7.Text != "")
        {
            string text = ass10mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod7.Text != "")
            {
                L1cal710 = (weight * Convert.ToDouble(txtass10mod7.Text)) / 100;
            }

        }
        TextBox78.Text = Convert.ToString(L1cal71 + L1cal72 + L1cal73 + L1cal74 + L1cal75 + L1cal76 + L1cal77 + L1cal78 + L1cal79 + L1cal710);
        Session["l3weight7"] = TextBox78.Text;

    }
    protected void txtass4mod7_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt64"] = txtass4mod7.Text;
       
        if (ass1mod7.Text != "")
        {
            string text = ass1mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod7.Text != "")
            {
                L1cal71 = (weight * Convert.ToDouble(txtass1mod7.Text.Trim())) / 100;
            }

        }
        if (ass2mod7.Text != "")
        {
            string text = ass2mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod7.Text != "")
            {
                L1cal72 = (weight * Convert.ToDouble(txtass2mod7.Text)) / 100;
            }

        }
        if (ass3mod7.Text != "")
        {
            string text = ass3mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod7.Text != "")
            {
                L1cal73 = (weight * Convert.ToDouble(txtass3mod7.Text)) / 100;
            }

        }
        if (ass4mod7.Text != "")
        {
            string text = ass4mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod7.Text != "")
            {
                L1cal74 = (weight * Convert.ToDouble(txtass4mod7.Text)) / 100;
            }

        }
        if (ass5mod7.Text != "")
        {
            string text = ass5mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod7.Text != "")
            {
                L1cal75 = (weight * Convert.ToDouble(txtass5mod7.Text)) / 100;
            }

        }
        if (ass6mod7.Text != "")
        {
            string text = ass6mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod7.Text != "")
            {
                L1cal76 = (weight * Convert.ToDouble(txtass6mod7.Text)) / 100;
            }

        }
        if (ass7mod7.Text != "")
        {
            string text = ass7mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod7.Text != "")
            {
                L1cal77 = (weight * Convert.ToDouble(txtass7mod7.Text)) / 100;
            }

        }
        if (ass8mod7.Text != "")
        {
            string text = ass8mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod7.Text != "")
            {
                L1cal78 = (weight * Convert.ToDouble(txtass8mod7.Text)) / 100;
            }

        }
        if (ass9mod7.Text != "")
        {
            string text = ass9mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod7.Text != "")
            {
                L1cal79 = (weight * Convert.ToDouble(txtass9mod7.Text)) / 100;
            }

        }
        if (ass10mod7.Text != "")
        {
            string text = ass10mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod7.Text != "")
            {
                L1cal710 = (weight * Convert.ToDouble(txtass10mod7.Text)) / 100;
            }

        }
        TextBox78.Text = Convert.ToString(L1cal71 + L1cal72 + L1cal73 + L1cal74 + L1cal75 + L1cal76 + L1cal77 + L1cal78 + L1cal79 + L1cal710);
        Session["l3weight7"] = TextBox78.Text;

    }
    protected void txtass5mod7_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt65"] = txtass5mod7.Text;
       
        if (ass1mod7.Text != "")
        {
            string text = ass1mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod7.Text != "")
            {
                L1cal71 = (weight * Convert.ToDouble(txtass1mod7.Text.Trim())) / 100;
            }

        }
        if (ass2mod7.Text != "")
        {
            string text = ass2mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod7.Text != "")
            {
                L1cal72 = (weight * Convert.ToDouble(txtass2mod7.Text)) / 100;
            }

        }
        if (ass3mod7.Text != "")
        {
            string text = ass3mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod7.Text != "")
            {
                L1cal73 = (weight * Convert.ToDouble(txtass3mod7.Text)) / 100;
            }

        }
        if (ass4mod7.Text != "")
        {
            string text = ass4mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod7.Text != "")
            {
                L1cal74 = (weight * Convert.ToDouble(txtass4mod7.Text)) / 100;
            }

        }
        if (ass5mod7.Text != "")
        {
            string text = ass5mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod7.Text != "")
            {
                L1cal75 = (weight * Convert.ToDouble(txtass5mod7.Text)) / 100;
            }

        }
        if (ass6mod7.Text != "")
        {
            string text = ass6mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod7.Text != "")
            {
                L1cal76 = (weight * Convert.ToDouble(txtass6mod7.Text)) / 100;
            }

        }
        if (ass7mod7.Text != "")
        {
            string text = ass7mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod7.Text != "")
            {
                L1cal77 = (weight * Convert.ToDouble(txtass7mod7.Text)) / 100;
            }

        }
        if (ass8mod7.Text != "")
        {
            string text = ass8mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod7.Text != "")
            {
                L1cal78 = (weight * Convert.ToDouble(txtass8mod7.Text)) / 100;
            }

        }
        if (ass9mod7.Text != "")
        {
            string text = ass9mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod7.Text != "")
            {
                L1cal79 = (weight * Convert.ToDouble(txtass9mod7.Text)) / 100;
            }

        }
        if (ass10mod7.Text != "")
        {
            string text = ass10mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod7.Text != "")
            {
                L1cal710 = (weight * Convert.ToDouble(txtass10mod7.Text)) / 100;
            }

        }
        TextBox78.Text = Convert.ToString(L1cal71 + L1cal72 + L1cal73 + L1cal74 + L1cal75 + L1cal76 + L1cal77 + L1cal78 + L1cal79 + L1cal710);
        Session["l3weight7"] = TextBox78.Text;

    }
    protected void txtass6mod7_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt66"] = txtass6mod7.Text;
      
        if (ass1mod7.Text != "")
        {
            string text = ass1mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod7.Text != "")
            {
                L1cal71 = (weight * Convert.ToDouble(txtass1mod7.Text.Trim())) / 100;
            }

        }
        if (ass2mod7.Text != "")
        {
            string text = ass2mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod7.Text != "")
            {
                L1cal72 = (weight * Convert.ToDouble(txtass2mod7.Text)) / 100;
            }

        }
        if (ass3mod7.Text != "")
        {
            string text = ass3mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod7.Text != "")
            {
                L1cal73 = (weight * Convert.ToDouble(txtass3mod7.Text)) / 100;
            }

        }
        if (ass4mod7.Text != "")
        {
            string text = ass4mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod7.Text != "")
            {
                L1cal74 = (weight * Convert.ToDouble(txtass4mod7.Text)) / 100;
            }

        }
        if (ass5mod7.Text != "")
        {
            string text = ass5mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod7.Text != "")
            {
                L1cal75 = (weight * Convert.ToDouble(txtass5mod7.Text)) / 100;
            }

        }
        if (ass6mod7.Text != "")
        {
            string text = ass6mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod7.Text != "")
            {
                L1cal76 = (weight * Convert.ToDouble(txtass6mod7.Text)) / 100;
            }

        }
        if (ass7mod7.Text != "")
        {
            string text = ass7mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod7.Text != "")
            {
                L1cal77 = (weight * Convert.ToDouble(txtass7mod7.Text)) / 100;
            }

        }
        if (ass8mod7.Text != "")
        {
            string text = ass8mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod7.Text != "")
            {
                L1cal78 = (weight * Convert.ToDouble(txtass8mod7.Text)) / 100;
            }

        }
        if (ass9mod7.Text != "")
        {
            string text = ass9mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod7.Text != "")
            {
                L1cal79 = (weight * Convert.ToDouble(txtass9mod7.Text)) / 100;
            }

        }
        if (ass10mod7.Text != "")
        {
            string text = ass10mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod7.Text != "")
            {
                L1cal710 = (weight * Convert.ToDouble(txtass10mod7.Text)) / 100;
            }

        }
        TextBox78.Text = Convert.ToString(L1cal71 + L1cal72 + L1cal73 + L1cal74 + L1cal75 + L1cal76 + L1cal77 + L1cal78 + L1cal79 + L1cal710);
        Session["l3weight7"] = TextBox78.Text;

    }
    protected void txtass7mod7_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt67"] = txtass7mod7.Text;
      
        if (ass1mod7.Text != "")
        {
            string text = ass1mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod7.Text != "")
            {
                L1cal71 = (weight * Convert.ToDouble(txtass1mod7.Text.Trim())) / 100;
            }

        }
        if (ass2mod7.Text != "")
        {
            string text = ass2mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod7.Text != "")
            {
                L1cal72 = (weight * Convert.ToDouble(txtass2mod7.Text)) / 100;
            }

        }
        if (ass3mod7.Text != "")
        {
            string text = ass3mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod7.Text != "")
            {
                L1cal73 = (weight * Convert.ToDouble(txtass3mod7.Text)) / 100;
            }

        }
        if (ass4mod7.Text != "")
        {
            string text = ass4mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod7.Text != "")
            {
                L1cal74 = (weight * Convert.ToDouble(txtass4mod7.Text)) / 100;
            }

        }
        if (ass5mod7.Text != "")
        {
            string text = ass5mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod7.Text != "")
            {
                L1cal75 = (weight * Convert.ToDouble(txtass5mod7.Text)) / 100;
            }

        }
        if (ass6mod7.Text != "")
        {
            string text = ass6mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod7.Text != "")
            {
                L1cal76 = (weight * Convert.ToDouble(txtass6mod7.Text)) / 100;
            }

        }
        if (ass7mod7.Text != "")
        {
            string text = ass7mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod7.Text != "")
            {
                L1cal77 = (weight * Convert.ToDouble(txtass7mod7.Text)) / 100;
            }

        }
        if (ass8mod7.Text != "")
        {
            string text = ass8mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod7.Text != "")
            {
                L1cal78 = (weight * Convert.ToDouble(txtass8mod7.Text)) / 100;
            }

        }
        if (ass9mod7.Text != "")
        {
            string text = ass9mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod7.Text != "")
            {
                L1cal79 = (weight * Convert.ToDouble(txtass9mod7.Text)) / 100;
            }

        }
        if (ass10mod7.Text != "")
        {
            string text = ass10mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod7.Text != "")
            {
                L1cal710 = (weight * Convert.ToDouble(txtass10mod7.Text)) / 100;
            }

        }
        TextBox78.Text = Convert.ToString(L1cal71 + L1cal72 + L1cal73 + L1cal74 + L1cal75 + L1cal76 + L1cal77 + L1cal78 + L1cal79 + L1cal710);
        Session["l3weight7"] = TextBox78.Text;

    }
    protected void txtass8mod7_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt68"] = txtass8mod7.Text;
       
        if (ass1mod7.Text != "")
        {
            string text = ass1mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod7.Text != "")
            {
                L1cal71 = (weight * Convert.ToDouble(txtass1mod7.Text.Trim())) / 100;
            }

        }
        if (ass2mod7.Text != "")
        {
            string text = ass2mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod7.Text != "")
            {
                L1cal72 = (weight * Convert.ToDouble(txtass2mod7.Text)) / 100;
            }

        }
        if (ass3mod7.Text != "")
        {
            string text = ass3mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod7.Text != "")
            {
                L1cal73 = (weight * Convert.ToDouble(txtass3mod7.Text)) / 100;
            }

        }
        if (ass4mod7.Text != "")
        {
            string text = ass4mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod7.Text != "")
            {
                L1cal74 = (weight * Convert.ToDouble(txtass4mod7.Text)) / 100;
            }

        }
        if (ass5mod7.Text != "")
        {
            string text = ass5mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod7.Text != "")
            {
                L1cal75 = (weight * Convert.ToDouble(txtass5mod7.Text)) / 100;
            }

        }
        if (ass6mod7.Text != "")
        {
            string text = ass6mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod7.Text != "")
            {
                L1cal76 = (weight * Convert.ToDouble(txtass6mod7.Text)) / 100;
            }

        }
        if (ass7mod7.Text != "")
        {
            string text = ass7mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod7.Text != "")
            {
                L1cal77 = (weight * Convert.ToDouble(txtass7mod7.Text)) / 100;
            }

        }
        if (ass8mod7.Text != "")
        {
            string text = ass8mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod7.Text != "")
            {
                L1cal78 = (weight * Convert.ToDouble(txtass8mod7.Text)) / 100;
            }

        }
        if (ass9mod7.Text != "")
        {
            string text = ass9mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod7.Text != "")
            {
                L1cal79 = (weight * Convert.ToDouble(txtass9mod7.Text)) / 100;
            }

        }
        if (ass10mod7.Text != "")
        {
            string text = ass10mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod7.Text != "")
            {
                L1cal710 = (weight * Convert.ToDouble(txtass10mod7.Text)) / 100;
            }

        }
        TextBox78.Text = Convert.ToString(L1cal71 + L1cal72 + L1cal73 + L1cal74 + L1cal75 + L1cal76 + L1cal77 + L1cal78 + L1cal79 + L1cal710);
        Session["l3weight7"] = TextBox78.Text;

    }
    protected void txtass9mod7_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt69"] = txtass9mod7.Text;
       
        if (ass1mod7.Text != "")
        {
            string text = ass1mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod7.Text != "")
            {
                L1cal71 = (weight * Convert.ToDouble(txtass1mod7.Text.Trim())) / 100;
            }

        }
        if (ass2mod7.Text != "")
        {
            string text = ass2mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod7.Text != "")
            {
                L1cal72 = (weight * Convert.ToDouble(txtass2mod7.Text)) / 100;
            }

        }
        if (ass3mod7.Text != "")
        {
            string text = ass3mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod7.Text != "")
            {
                L1cal73 = (weight * Convert.ToDouble(txtass3mod7.Text)) / 100;
            }

        }
        if (ass4mod7.Text != "")
        {
            string text = ass4mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod7.Text != "")
            {
                L1cal74 = (weight * Convert.ToDouble(txtass4mod7.Text)) / 100;
            }

        }
        if (ass5mod7.Text != "")
        {
            string text = ass5mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod7.Text != "")
            {
                L1cal75 = (weight * Convert.ToDouble(txtass5mod7.Text)) / 100;
            }

        }
        if (ass6mod7.Text != "")
        {
            string text = ass6mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod7.Text != "")
            {
                L1cal76 = (weight * Convert.ToDouble(txtass6mod7.Text)) / 100;
            }

        }
        if (ass7mod7.Text != "")
        {
            string text = ass7mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod7.Text != "")
            {
                L1cal77 = (weight * Convert.ToDouble(txtass7mod7.Text)) / 100;
            }

        }
        if (ass8mod7.Text != "")
        {
            string text = ass8mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod7.Text != "")
            {
                L1cal78 = (weight * Convert.ToDouble(txtass8mod7.Text)) / 100;
            }

        }
        if (ass9mod7.Text != "")
        {
            string text = ass9mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod7.Text != "")
            {
                L1cal79 = (weight * Convert.ToDouble(txtass9mod7.Text)) / 100;
            }

        }
        if (ass10mod7.Text != "")
        {
            string text = ass10mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod7.Text != "")
            {
                L1cal710 = (weight * Convert.ToDouble(txtass10mod7.Text)) / 100;
            }

        }
        TextBox78.Text = Convert.ToString(L1cal71 + L1cal72 + L1cal73 + L1cal74 + L1cal75 + L1cal76 + L1cal77 + L1cal78 + L1cal79 + L1cal710);
        Session["l3weight7"] = TextBox78.Text;

    }
    protected void txtass10mod7_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt70"] = txtass10mod7.Text;
       
        if (ass1mod7.Text != "")
        {
            string text = ass1mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod7.Text != "")
            {
                L1cal71 = (weight * Convert.ToDouble(txtass1mod7.Text.Trim())) / 100;
            }

        }
        if (ass2mod7.Text != "")
        {
            string text = ass2mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod7.Text != "")
            {
                L1cal72 = (weight * Convert.ToDouble(txtass2mod7.Text)) / 100;
            }

        }
        if (ass3mod7.Text != "")
        {
            string text = ass3mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod7.Text != "")
            {
                L1cal73 = (weight * Convert.ToDouble(txtass3mod7.Text)) / 100;
            }

        }
        if (ass4mod7.Text != "")
        {
            string text = ass4mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod7.Text != "")
            {
                L1cal74 = (weight * Convert.ToDouble(txtass4mod7.Text)) / 100;
            }

        }
        if (ass5mod7.Text != "")
        {
            string text = ass5mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod7.Text != "")
            {
                L1cal75 = (weight * Convert.ToDouble(txtass5mod7.Text)) / 100;
            }

        }
        if (ass6mod7.Text != "")
        {
            string text = ass6mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod7.Text != "")
            {
                L1cal76 = (weight * Convert.ToDouble(txtass6mod7.Text)) / 100;
            }

        }
        if (ass7mod7.Text != "")
        {
            string text = ass7mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod7.Text != "")
            {
                L1cal77 = (weight * Convert.ToDouble(txtass7mod7.Text)) / 100;
            }

        }
        if (ass8mod7.Text != "")
        {
            string text = ass8mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod7.Text != "")
            {
                L1cal78 = (weight * Convert.ToDouble(txtass8mod7.Text)) / 100;
            }

        }
        if (ass9mod7.Text != "")
        {
            string text = ass9mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod7.Text != "")
            {
                L1cal79 = (weight * Convert.ToDouble(txtass9mod7.Text)) / 100;
            }

        }
        if (ass10mod7.Text != "")
        {
            string text = ass10mod7.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod7.Text != "")
            {
                L1cal710 = (weight * Convert.ToDouble(txtass10mod7.Text)) / 100;
            }

        }
        TextBox78.Text = Convert.ToString(L1cal71 + L1cal72 + L1cal73 + L1cal74 + L1cal75 + L1cal76 + L1cal77 + L1cal78 + L1cal79 + L1cal710);
        Session["l3weight7"] = TextBox78.Text;

    }
    protected void TextBox78_TextChanged(object sender, EventArgs e)
    {

    }
    protected void txtass1mod8_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt71"] = txtass1mod8.Text;
       
        if (ass1mod8.Text != "")
        {
            string text = ass1mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod8.Text != "")
            {
                L1cal81 = (weight * Convert.ToDouble(txtass1mod8.Text.Trim())) / 100;
            }

        }
        if (ass2mod8.Text != "")
        {
            string text = ass2mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod8.Text != "")
            {
                L1cal82 = (weight * Convert.ToDouble(txtass2mod8.Text)) / 100;
            }

        }
        if (ass3mod8.Text != "")
        {
            string text = ass3mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod8.Text != "")
            {
                L1cal83 = (weight * Convert.ToDouble(txtass3mod8.Text)) / 100;
            }

        }
        if (ass4mod8.Text != "")
        {
            string text = ass4mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod8.Text != "")
            {
                L1cal84 = (weight * Convert.ToDouble(txtass4mod8.Text)) / 100;
            }

        }
        if (ass5mod8.Text != "")
        {
            string text = ass5mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod8.Text != "")
            {
                L1cal85 = (weight * Convert.ToDouble(txtass5mod8.Text)) / 100;
            }

        }
        if (ass6mod8.Text != "")
        {
            string text = ass6mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod8.Text != "")
            {
                L1cal86 = (weight * Convert.ToDouble(txtass6mod8.Text)) / 100;
            }

        }
        if (ass7mod8.Text != "")
        {
            string text = ass7mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod8.Text != "")
            {
                L1cal87 = (weight * Convert.ToDouble(txtass7mod8.Text)) / 100;
            }

        }
        if (ass8mod8.Text != "")
        {
            string text = ass8mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod8.Text != "")
            {
                L1cal88 = (weight * Convert.ToDouble(txtass8mod8.Text)) / 100;
            }

        }
        if (ass9mod8.Text != "")
        {
            string text = ass9mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod8.Text != "")
            {
                L1cal89 = (weight * Convert.ToDouble(txtass9mod8.Text)) / 100;
            }

        }
        if (ass10mod8.Text != "")
        {
            string text = ass10mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod8.Text != "")
            {
                L1cal810 = (weight * Convert.ToDouble(txtass10mod8.Text)) / 100;
            }

        }
        TextBox89.Text = Convert.ToString(L1cal81 + L1cal82 + L1cal83 + L1cal84 + L1cal85 + L1cal86 + L1cal87 + L1cal88 + L1cal89 + L1cal810);
        Session["l3weight8"] = TextBox89.Text;
    }
    protected void txtass2mod8_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt71"] = txtass1mod8.Text;

        if (ass1mod8.Text != "")
        {
            string text = ass1mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod8.Text != "")
            {
                L1cal81 = (weight * Convert.ToDouble(txtass1mod8.Text.Trim())) / 100;
            }

        }
        if (ass2mod8.Text != "")
        {
            string text = ass2mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod8.Text != "")
            {
                L1cal82 = (weight * Convert.ToDouble(txtass2mod8.Text)) / 100;
            }

        }
        if (ass3mod8.Text != "")
        {
            string text = ass3mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod8.Text != "")
            {
                L1cal83 = (weight * Convert.ToDouble(txtass3mod8.Text)) / 100;
            }

        }
        if (ass4mod8.Text != "")
        {
            string text = ass4mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod8.Text != "")
            {
                L1cal84 = (weight * Convert.ToDouble(txtass4mod8.Text)) / 100;
            }

        }
        if (ass5mod8.Text != "")
        {
            string text = ass5mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod8.Text != "")
            {
                L1cal85 = (weight * Convert.ToDouble(txtass5mod8.Text)) / 100;
            }

        }
        if (ass6mod8.Text != "")
        {
            string text = ass6mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod8.Text != "")
            {
                L1cal86 = (weight * Convert.ToDouble(txtass6mod8.Text)) / 100;
            }

        }
        if (ass7mod8.Text != "")
        {
            string text = ass7mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod8.Text != "")
            {
                L1cal87 = (weight * Convert.ToDouble(txtass7mod8.Text)) / 100;
            }

        }
        if (ass8mod8.Text != "")
        {
            string text = ass8mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod8.Text != "")
            {
                L1cal88 = (weight * Convert.ToDouble(txtass8mod8.Text)) / 100;
            }

        }
        if (ass9mod8.Text != "")
        {
            string text = ass9mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod8.Text != "")
            {
                L1cal89 = (weight * Convert.ToDouble(txtass9mod8.Text)) / 100;
            }

        }
        if (ass10mod8.Text != "")
        {
            string text = ass10mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod8.Text != "")
            {
                L1cal810 = (weight * Convert.ToDouble(txtass10mod8.Text)) / 100;
            }

        }
        TextBox89.Text = Convert.ToString(L1cal81 + L1cal82 + L1cal83 + L1cal84 + L1cal85 + L1cal86 + L1cal87 + L1cal88 + L1cal89 + L1cal810);
        Session["l3weight8"] = TextBox89.Text;
    }
    protected void txtass3mod8_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt71"] = txtass1mod8.Text;

        if (ass1mod8.Text != "")
        {
            string text = ass1mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod8.Text != "")
            {
                L1cal81 = (weight * Convert.ToDouble(txtass1mod8.Text.Trim())) / 100;
            }

        }
        if (ass2mod8.Text != "")
        {
            string text = ass2mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod8.Text != "")
            {
                L1cal82 = (weight * Convert.ToDouble(txtass2mod8.Text)) / 100;
            }

        }
        if (ass3mod8.Text != "")
        {
            string text = ass3mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod8.Text != "")
            {
                L1cal83 = (weight * Convert.ToDouble(txtass3mod8.Text)) / 100;
            }

        }
        if (ass4mod8.Text != "")
        {
            string text = ass4mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod8.Text != "")
            {
                L1cal84 = (weight * Convert.ToDouble(txtass4mod8.Text)) / 100;
            }

        }
        if (ass5mod8.Text != "")
        {
            string text = ass5mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod8.Text != "")
            {
                L1cal85 = (weight * Convert.ToDouble(txtass5mod8.Text)) / 100;
            }

        }
        if (ass6mod8.Text != "")
        {
            string text = ass6mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod8.Text != "")
            {
                L1cal86 = (weight * Convert.ToDouble(txtass6mod8.Text)) / 100;
            }

        }
        if (ass7mod8.Text != "")
        {
            string text = ass7mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod8.Text != "")
            {
                L1cal87 = (weight * Convert.ToDouble(txtass7mod8.Text)) / 100;
            }

        }
        if (ass8mod8.Text != "")
        {
            string text = ass8mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod8.Text != "")
            {
                L1cal88 = (weight * Convert.ToDouble(txtass8mod8.Text)) / 100;
            }

        }
        if (ass9mod8.Text != "")
        {
            string text = ass9mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod8.Text != "")
            {
                L1cal89 = (weight * Convert.ToDouble(txtass9mod8.Text)) / 100;
            }

        }
        if (ass10mod8.Text != "")
        {
            string text = ass10mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod8.Text != "")
            {
                L1cal810 = (weight * Convert.ToDouble(txtass10mod8.Text)) / 100;
            }

        }
        TextBox89.Text = Convert.ToString(L1cal81 + L1cal82 + L1cal83 + L1cal84 + L1cal85 + L1cal86 + L1cal87 + L1cal88 + L1cal89 + L1cal810);
        Session["l3weight8"] = TextBox89.Text;
    }
    protected void txtass4mod8_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt71"] = txtass1mod8.Text;

        if (ass1mod8.Text != "")
        {
            string text = ass1mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod8.Text != "")
            {
                L1cal81 = (weight * Convert.ToDouble(txtass1mod8.Text.Trim())) / 100;
            }

        }
        if (ass2mod8.Text != "")
        {
            string text = ass2mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod8.Text != "")
            {
                L1cal82 = (weight * Convert.ToDouble(txtass2mod8.Text)) / 100;
            }

        }
        if (ass3mod8.Text != "")
        {
            string text = ass3mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod8.Text != "")
            {
                L1cal83 = (weight * Convert.ToDouble(txtass3mod8.Text)) / 100;
            }

        }
        if (ass4mod8.Text != "")
        {
            string text = ass4mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod8.Text != "")
            {
                L1cal84 = (weight * Convert.ToDouble(txtass4mod8.Text)) / 100;
            }

        }
        if (ass5mod8.Text != "")
        {
            string text = ass5mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod8.Text != "")
            {
                L1cal85 = (weight * Convert.ToDouble(txtass5mod8.Text)) / 100;
            }

        }
        if (ass6mod8.Text != "")
        {
            string text = ass6mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod8.Text != "")
            {
                L1cal86 = (weight * Convert.ToDouble(txtass6mod8.Text)) / 100;
            }

        }
        if (ass7mod8.Text != "")
        {
            string text = ass7mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod8.Text != "")
            {
                L1cal87 = (weight * Convert.ToDouble(txtass7mod8.Text)) / 100;
            }

        }
        if (ass8mod8.Text != "")
        {
            string text = ass8mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod8.Text != "")
            {
                L1cal88 = (weight * Convert.ToDouble(txtass8mod8.Text)) / 100;
            }

        }
        if (ass9mod8.Text != "")
        {
            string text = ass9mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod8.Text != "")
            {
                L1cal89 = (weight * Convert.ToDouble(txtass9mod8.Text)) / 100;
            }

        }
        if (ass10mod8.Text != "")
        {
            string text = ass10mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod8.Text != "")
            {
                L1cal810 = (weight * Convert.ToDouble(txtass10mod8.Text)) / 100;
            }

        }
        TextBox89.Text = Convert.ToString(L1cal81 + L1cal82 + L1cal83 + L1cal84 + L1cal85 + L1cal86 + L1cal87 + L1cal88 + L1cal89 + L1cal810);
        Session["l3weight8"] = TextBox89.Text;
    }
    protected void txtass5mod8_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt71"] = txtass1mod8.Text;

        if (ass1mod8.Text != "")
        {
            string text = ass1mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod8.Text != "")
            {
                L1cal81 = (weight * Convert.ToDouble(txtass1mod8.Text.Trim())) / 100;
            }

        }
        if (ass2mod8.Text != "")
        {
            string text = ass2mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod8.Text != "")
            {
                L1cal82 = (weight * Convert.ToDouble(txtass2mod8.Text)) / 100;
            }

        }
        if (ass3mod8.Text != "")
        {
            string text = ass3mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod8.Text != "")
            {
                L1cal83 = (weight * Convert.ToDouble(txtass3mod8.Text)) / 100;
            }

        }
        if (ass4mod8.Text != "")
        {
            string text = ass4mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod8.Text != "")
            {
                L1cal84 = (weight * Convert.ToDouble(txtass4mod8.Text)) / 100;
            }

        }
        if (ass5mod8.Text != "")
        {
            string text = ass5mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod8.Text != "")
            {
                L1cal85 = (weight * Convert.ToDouble(txtass5mod8.Text)) / 100;
            }

        }
        if (ass6mod8.Text != "")
        {
            string text = ass6mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod8.Text != "")
            {
                L1cal86 = (weight * Convert.ToDouble(txtass6mod8.Text)) / 100;
            }

        }
        if (ass7mod8.Text != "")
        {
            string text = ass7mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod8.Text != "")
            {
                L1cal87 = (weight * Convert.ToDouble(txtass7mod8.Text)) / 100;
            }

        }
        if (ass8mod8.Text != "")
        {
            string text = ass8mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod8.Text != "")
            {
                L1cal88 = (weight * Convert.ToDouble(txtass8mod8.Text)) / 100;
            }

        }
        if (ass9mod8.Text != "")
        {
            string text = ass9mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod8.Text != "")
            {
                L1cal89 = (weight * Convert.ToDouble(txtass9mod8.Text)) / 100;
            }

        }
        if (ass10mod8.Text != "")
        {
            string text = ass10mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod8.Text != "")
            {
                L1cal810 = (weight * Convert.ToDouble(txtass10mod8.Text)) / 100;
            }

        }
        TextBox89.Text = Convert.ToString(L1cal81 + L1cal82 + L1cal83 + L1cal84 + L1cal85 + L1cal86 + L1cal87 + L1cal88 + L1cal89 + L1cal810);
        Session["l3weight8"] = TextBox89.Text;
    }
    protected void txtass6mod8_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt71"] = txtass1mod8.Text;

        if (ass1mod8.Text != "")
        {
            string text = ass1mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod8.Text != "")
            {
                L1cal81 = (weight * Convert.ToDouble(txtass1mod8.Text.Trim())) / 100;
            }

        }
        if (ass2mod8.Text != "")
        {
            string text = ass2mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod8.Text != "")
            {
                L1cal82 = (weight * Convert.ToDouble(txtass2mod8.Text)) / 100;
            }

        }
        if (ass3mod8.Text != "")
        {
            string text = ass3mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod8.Text != "")
            {
                L1cal83 = (weight * Convert.ToDouble(txtass3mod8.Text)) / 100;
            }

        }
        if (ass4mod8.Text != "")
        {
            string text = ass4mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod8.Text != "")
            {
                L1cal84 = (weight * Convert.ToDouble(txtass4mod8.Text)) / 100;
            }

        }
        if (ass5mod8.Text != "")
        {
            string text = ass5mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod8.Text != "")
            {
                L1cal85 = (weight * Convert.ToDouble(txtass5mod8.Text)) / 100;
            }

        }
        if (ass6mod8.Text != "")
        {
            string text = ass6mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod8.Text != "")
            {
                L1cal86 = (weight * Convert.ToDouble(txtass6mod8.Text)) / 100;
            }

        }
        if (ass7mod8.Text != "")
        {
            string text = ass7mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod8.Text != "")
            {
                L1cal87 = (weight * Convert.ToDouble(txtass7mod8.Text)) / 100;
            }

        }
        if (ass8mod8.Text != "")
        {
            string text = ass8mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod8.Text != "")
            {
                L1cal88 = (weight * Convert.ToDouble(txtass8mod8.Text)) / 100;
            }

        }
        if (ass9mod8.Text != "")
        {
            string text = ass9mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod8.Text != "")
            {
                L1cal89 = (weight * Convert.ToDouble(txtass9mod8.Text)) / 100;
            }

        }
        if (ass10mod8.Text != "")
        {
            string text = ass10mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod8.Text != "")
            {
                L1cal810 = (weight * Convert.ToDouble(txtass10mod8.Text)) / 100;
            }

        }
        TextBox89.Text = Convert.ToString(L1cal81 + L1cal82 + L1cal83 + L1cal84 + L1cal85 + L1cal86 + L1cal87 + L1cal88 + L1cal89 + L1cal810);
        Session["l3weight8"] = TextBox89.Text;
    }
    protected void txtass7mod8_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt71"] = txtass1mod8.Text;

        if (ass1mod8.Text != "")
        {
            string text = ass1mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod8.Text != "")
            {
                L1cal81 = (weight * Convert.ToDouble(txtass1mod8.Text.Trim())) / 100;
            }

        }
        if (ass2mod8.Text != "")
        {
            string text = ass2mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod8.Text != "")
            {
                L1cal82 = (weight * Convert.ToDouble(txtass2mod8.Text)) / 100;
            }

        }
        if (ass3mod8.Text != "")
        {
            string text = ass3mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod8.Text != "")
            {
                L1cal83 = (weight * Convert.ToDouble(txtass3mod8.Text)) / 100;
            }

        }
        if (ass4mod8.Text != "")
        {
            string text = ass4mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod8.Text != "")
            {
                L1cal84 = (weight * Convert.ToDouble(txtass4mod8.Text)) / 100;
            }

        }
        if (ass5mod8.Text != "")
        {
            string text = ass5mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod8.Text != "")
            {
                L1cal85 = (weight * Convert.ToDouble(txtass5mod8.Text)) / 100;
            }

        }
        if (ass6mod8.Text != "")
        {
            string text = ass6mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod8.Text != "")
            {
                L1cal86 = (weight * Convert.ToDouble(txtass6mod8.Text)) / 100;
            }

        }
        if (ass7mod8.Text != "")
        {
            string text = ass7mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod8.Text != "")
            {
                L1cal87 = (weight * Convert.ToDouble(txtass7mod8.Text)) / 100;
            }

        }
        if (ass8mod8.Text != "")
        {
            string text = ass8mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod8.Text != "")
            {
                L1cal88 = (weight * Convert.ToDouble(txtass8mod8.Text)) / 100;
            }

        }
        if (ass9mod8.Text != "")
        {
            string text = ass9mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod8.Text != "")
            {
                L1cal89 = (weight * Convert.ToDouble(txtass9mod8.Text)) / 100;
            }

        }
        if (ass10mod8.Text != "")
        {
            string text = ass10mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod8.Text != "")
            {
                L1cal810 = (weight * Convert.ToDouble(txtass10mod8.Text)) / 100;
            }

        }
        TextBox89.Text = Convert.ToString(L1cal81 + L1cal82 + L1cal83 + L1cal84 + L1cal85 + L1cal86 + L1cal87 + L1cal88 + L1cal89 + L1cal810);
        Session["l3weight8"] = TextBox89.Text;
    }
    protected void txtass8mod8_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt71"] = txtass1mod8.Text;

        if (ass1mod8.Text != "")
        {
            string text = ass1mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod8.Text != "")
            {
                L1cal81 = (weight * Convert.ToDouble(txtass1mod8.Text.Trim())) / 100;
            }

        }
        if (ass2mod8.Text != "")
        {
            string text = ass2mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod8.Text != "")
            {
                L1cal82 = (weight * Convert.ToDouble(txtass2mod8.Text)) / 100;
            }

        }
        if (ass3mod8.Text != "")
        {
            string text = ass3mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod8.Text != "")
            {
                L1cal83 = (weight * Convert.ToDouble(txtass3mod8.Text)) / 100;
            }

        }
        if (ass4mod8.Text != "")
        {
            string text = ass4mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod8.Text != "")
            {
                L1cal84 = (weight * Convert.ToDouble(txtass4mod8.Text)) / 100;
            }

        }
        if (ass5mod8.Text != "")
        {
            string text = ass5mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod8.Text != "")
            {
                L1cal85 = (weight * Convert.ToDouble(txtass5mod8.Text)) / 100;
            }

        }
        if (ass6mod8.Text != "")
        {
            string text = ass6mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod8.Text != "")
            {
                L1cal86 = (weight * Convert.ToDouble(txtass6mod8.Text)) / 100;
            }

        }
        if (ass7mod8.Text != "")
        {
            string text = ass7mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod8.Text != "")
            {
                L1cal87 = (weight * Convert.ToDouble(txtass7mod8.Text)) / 100;
            }

        }
        if (ass8mod8.Text != "")
        {
            string text = ass8mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod8.Text != "")
            {
                L1cal88 = (weight * Convert.ToDouble(txtass8mod8.Text)) / 100;
            }

        }
        if (ass9mod8.Text != "")
        {
            string text = ass9mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod8.Text != "")
            {
                L1cal89 = (weight * Convert.ToDouble(txtass9mod8.Text)) / 100;
            }

        }
        if (ass10mod8.Text != "")
        {
            string text = ass10mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod8.Text != "")
            {
                L1cal810 = (weight * Convert.ToDouble(txtass10mod8.Text)) / 100;
            }

        }
        TextBox89.Text = Convert.ToString(L1cal81 + L1cal82 + L1cal83 + L1cal84 + L1cal85 + L1cal86 + L1cal87 + L1cal88 + L1cal89 + L1cal810);
        Session["l3weight8"] = TextBox89.Text;
    }
    protected void txtass9mod8_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt71"] = txtass1mod8.Text;

        if (ass1mod8.Text != "")
        {
            string text = ass1mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod8.Text != "")
            {
                L1cal81 = (weight * Convert.ToDouble(txtass1mod8.Text.Trim())) / 100;
            }

        }
        if (ass2mod8.Text != "")
        {
            string text = ass2mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod8.Text != "")
            {
                L1cal82 = (weight * Convert.ToDouble(txtass2mod8.Text)) / 100;
            }

        }
        if (ass3mod8.Text != "")
        {
            string text = ass3mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod8.Text != "")
            {
                L1cal83 = (weight * Convert.ToDouble(txtass3mod8.Text)) / 100;
            }

        }
        if (ass4mod8.Text != "")
        {
            string text = ass4mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod8.Text != "")
            {
                L1cal84 = (weight * Convert.ToDouble(txtass4mod8.Text)) / 100;
            }

        }
        if (ass5mod8.Text != "")
        {
            string text = ass5mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod8.Text != "")
            {
                L1cal85 = (weight * Convert.ToDouble(txtass5mod8.Text)) / 100;
            }

        }
        if (ass6mod8.Text != "")
        {
            string text = ass6mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod8.Text != "")
            {
                L1cal86 = (weight * Convert.ToDouble(txtass6mod8.Text)) / 100;
            }

        }
        if (ass7mod8.Text != "")
        {
            string text = ass7mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod8.Text != "")
            {
                L1cal87 = (weight * Convert.ToDouble(txtass7mod8.Text)) / 100;
            }

        }
        if (ass8mod8.Text != "")
        {
            string text = ass8mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod8.Text != "")
            {
                L1cal88 = (weight * Convert.ToDouble(txtass8mod8.Text)) / 100;
            }

        }
        if (ass9mod8.Text != "")
        {
            string text = ass9mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod8.Text != "")
            {
                L1cal89 = (weight * Convert.ToDouble(txtass9mod8.Text)) / 100;
            }

        }
        if (ass10mod8.Text != "")
        {
            string text = ass10mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod8.Text != "")
            {
                L1cal810 = (weight * Convert.ToDouble(txtass10mod8.Text)) / 100;
            }

        }
        TextBox89.Text = Convert.ToString(L1cal81 + L1cal82 + L1cal83 + L1cal84 + L1cal85 + L1cal86 + L1cal87 + L1cal88 + L1cal89 + L1cal810);
        Session["l3weight8"] = TextBox89.Text;
    }
    protected void txtass10mod8_TextChanged(object sender, EventArgs e)
    {
        Session["l3txt71"] = txtass1mod8.Text;

        if (ass1mod8.Text != "")
        {
            string text = ass1mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass1mod8.Text != "")
            {
                L1cal81 = (weight * Convert.ToDouble(txtass1mod8.Text.Trim())) / 100;
            }

        }
        if (ass2mod8.Text != "")
        {
            string text = ass2mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass2mod8.Text != "")
            {
                L1cal82 = (weight * Convert.ToDouble(txtass2mod8.Text)) / 100;
            }

        }
        if (ass3mod8.Text != "")
        {
            string text = ass3mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass3mod8.Text != "")
            {
                L1cal83 = (weight * Convert.ToDouble(txtass3mod8.Text)) / 100;
            }

        }
        if (ass4mod8.Text != "")
        {
            string text = ass4mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass4mod8.Text != "")
            {
                L1cal84 = (weight * Convert.ToDouble(txtass4mod8.Text)) / 100;
            }

        }
        if (ass5mod8.Text != "")
        {
            string text = ass5mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass5mod8.Text != "")
            {
                L1cal85 = (weight * Convert.ToDouble(txtass5mod8.Text)) / 100;
            }

        }
        if (ass6mod8.Text != "")
        {
            string text = ass6mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass6mod8.Text != "")
            {
                L1cal86 = (weight * Convert.ToDouble(txtass6mod8.Text)) / 100;
            }

        }
        if (ass7mod8.Text != "")
        {
            string text = ass7mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass7mod8.Text != "")
            {
                L1cal87 = (weight * Convert.ToDouble(txtass7mod8.Text)) / 100;
            }

        }
        if (ass8mod8.Text != "")
        {
            string text = ass8mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass8mod8.Text != "")
            {
                L1cal88 = (weight * Convert.ToDouble(txtass8mod8.Text)) / 100;
            }

        }
        if (ass9mod8.Text != "")
        {
            string text = ass9mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass9mod8.Text != "")
            {
                L1cal89 = (weight * Convert.ToDouble(txtass9mod8.Text)) / 100;
            }

        }
        if (ass10mod8.Text != "")
        {
            string text = ass10mod8.Text;
            string[] after = text.Split(';');
            int weight = Convert.ToInt32(after[1]);
            if (txtass10mod8.Text != "")
            {
                L1cal810 = (weight * Convert.ToDouble(txtass10mod8.Text)) / 100;
            }

        }
        TextBox89.Text = Convert.ToString(L1cal81 + L1cal82 + L1cal83 + L1cal84 + L1cal85 + L1cal86 + L1cal87 + L1cal88 + L1cal89 + L1cal810);
        Session["l3weight8"] = TextBox89.Text;
    }
    public void hideweight()
    {
        if (lblmod1.Text == "")
        {
            TextBox12.Visible = false;
            Label12.Visible = false;
        }
        if (lblmod2.Text == "")
        {
            TextBox23.Visible = false;
            Label105.Visible = false;
        }
        if (lblmod3.Text == "")
        {
            TextBox34.Visible = false;
            Label106.Visible = false;
        }
        if (lblmod4.Text == "")
        {
            TextBox45.Visible = false;
            Label107.Visible = false;

        }
        if (lblmod5.Text == "")
        {
            TextBox56.Visible = false;
            Label108.Visible = false;
        }
        if (lblmod6.Text == "")
        {
            TextBox67.Visible = false;
            Label109.Visible = false;
        }
        if (lblmod7.Text == "")
        {
            TextBox78.Visible = false;
            Label110.Visible = false;
        }
        if (lblmod8.Text == "")
        {
            TextBox89.Visible = false;
            Label103.Visible = false;
        }
    
    }

    public void retrivevalue()
    {
        if (Session["l3txt1"] != null)
        {
            txtass1mod1.Text = Session["l3txt1"].ToString();
        }
        if (Session["l3txt2"] != null)
        {
            txtass2mod1.Text = Session["l3txt2"].ToString();
        }
        if (Session["l3txt3"] != null)
        {
            txtass3mod1.Text = Session["l3txt3"].ToString();
        }
        if (Session["l3txt4"] != null)
        {
            txtass4mod1.Text = Session["l3txt4"].ToString();
        }
        if (Session["l3txt5"] != null)
        {
            txtass5mod1.Text = Session["l3txt5"].ToString();
        }
        if (Session["l3txt6"] != null)
        {
            txtass6mod1.Text = Session["l3txt6"].ToString();
        }
        if (Session["l3txt7"] != null)
        {
            txtass7mod1.Text = Session["l3txt7"].ToString();
        }
        if (Session["l3txt8"] != null)
        {
            txtass8mod1.Text = Session["l3txt8"].ToString();
        }
        if (Session["l3txt9"] != null)
        {
            txtass9mod1.Text = Session["l3txt9"].ToString();
        }
        if (Session["l3txt10"] != null)
        {
            txtass10mod1.Text = Session["l3txt10"].ToString();
        }
        if (Session["l3txt11"] != null)
        {
            txtass1mod2.Text = Session["l3txt11"].ToString();
        }
        if (Session["l3txt12"] != null)
        {
            txtass2mod2.Text = Session["l3txt12"].ToString();
        }
        if (Session["l3txt13"] != null)
        {
            txtass3mod2.Text = Session["l3txt13"].ToString();
        }
        if (Session["l3txt14"] != null)
        {
            txtass4mod2.Text = Session["l3txt14"].ToString();
        }
        if (Session["l3txt15"] != null)
        {
            txtass5mod2.Text = Session["l3txt15"].ToString();
        }
        if (Session["l3txt16"] != null)
        {
            txtass6mod2.Text = Session["l3txt16"].ToString();
        }
        if (Session["l3txt17"] != null)
        {
            txtass7mod2.Text = Session["l3txt17"].ToString();
        }
        if (Session["l3txt18"] != null)
        {
            txtass8mod2.Text = Session["l3txt18"].ToString();
        }
        
        if (Session["l3txt19"] != null)
        {
            txtass9mod2.Text = Session["l3txt19"].ToString();
        }
        if (Session["l3txt20"] != null)
        {
            txtass10mod2.Text = Session["l3txt20"].ToString();
        }
        if (Session["l3txt21"] != null)
        {
            txtass1mod3.Text = Session["l3txt21"].ToString();
        }
        if (Session["l3txt22"] != null)
        {
            txtass2mod3.Text = Session["l3txt22"].ToString();
        }
        if (Session["l3txt23"] != null)
        {
            txtass3mod3.Text = Session["l3txt23"].ToString();
        }
        if (Session["l3txt24"] != null)
        {
            txtass4mod3.Text = Session["l3txt24"].ToString();
        }
        if (Session["l3txt25"] != null)
        {
            txtass5mod3.Text = Session["l3txt25"].ToString();
        }
        if (Session["l3txt26"] != null)
        {
            txtass6mod3.Text = Session["l3txt26"].ToString();
        }
        if (Session["l3txt27"] != null)
        {
            txtass7mod3.Text = Session["l3txt27"].ToString();
        }
        if (Session["l3txt28"] != null)
        {
            txtass8mod3.Text = Session["l3txt28"].ToString();
        }
        if (Session["l3txt29"] != null)
        {
            txtass9mod3.Text = Session["l3txt29"].ToString();
        }
        if (Session["l3txt30"] != null)
        {
            txtass10mod3.Text = Session["l3txt30"].ToString();
        }
        if (Session["l3txt31"] != null)
        {
            txtass1mod4.Text = Session["l3txt31"].ToString();
        }
        if (Session["l3txt32"] != null)
        {
            txtass2mod4.Text = Session["l3txt32"].ToString();
        }
        if (Session["l3txt33"] != null)
        {
            txtass3mod4.Text = Session["l3txt33"].ToString();
        }
        if (Session["l3txt34"] != null)
        {
            txtass4mod4.Text = Session["l3txt34"].ToString();
        }
        if (Session["l3txt35"] != null)
        {
            txtass5mod4.Text = Session["l3txt35"].ToString();
        }
        if (Session["l3txt36"] != null)
        {
            txtass6mod4.Text = Session["l3txt36"].ToString();
        }
        if (Session["l3txt37"] != null)
        {
            txtass7mod4.Text = Session["l3txt37"].ToString();
        }
        if (Session["l3txt38"] != null)
        {
            txtass8mod4.Text = Session["l3txt38"].ToString();
        }
        if (Session["l3txt39"] != null)
        {
            txtass9mod4.Text = Session["l3txt39"].ToString();
        }
        if (Session["l3txt40"] != null)
        {
            txtass10mod4.Text = Session["l3txt40"].ToString();
        }
        if (Session["l3txt41"] != null)
        {
            txtass1mod5.Text = Session["l3txt41"].ToString();
        }
        if (Session["l3txt42"] != null)
        {
            txtass2mod5.Text = Session["l3txt42"].ToString();
        }
        if (Session["l3txt43"] != null)
        {
            txtass3mod5.Text = Session["l3txt43"].ToString();
        }
        if (Session["l3txt44"] != null)
        {
            txtass4mod5.Text = Session["l3txt44"].ToString();
        }
        if (Session["l3txt45"] != null)
        {
            txtass5mod5.Text = Session["l3txt45"].ToString();
        }
        if (Session["l3txt46"] != null)
        {
            txtass6mod5.Text = Session["l3txt46"].ToString();
        }
        if (Session["l3txt47"] != null)
        {
            txtass7mod5.Text = Session["l3txt47"].ToString();
        }
        if (Session["l3txt48"] != null)
        {
            txtass8mod5.Text = Session["l3txt48"].ToString();
        }
        if (Session["l3txt49"] != null)
        {
            txtass9mod5.Text = Session["l3txt49"].ToString();
        }
        if (Session["l3txt50"] != null)
        {
            txtass10mod5.Text = Session["l3txt50"].ToString();
        }
        if (Session["l3txt51"] != null)
        {
            txtass1mod6.Text = Session["l3txt51"].ToString();
        }
        if (Session["l3txt52"] != null)
        {
            txtass2mod6.Text = Session["l3txt52"].ToString();
        }
        if (Session["l3txt53"] != null)
        {
            txtass3mod6.Text = Session["l3txt53"].ToString();
        }
        if (Session["l3txt54"] != null)
        {
            txtass4mod6.Text = Session["l3txt54"].ToString();
        }
        if (Session["l3txt55"] != null)
        {
            txtass5mod6.Text = Session["l3txt55"].ToString();
        }
        if (Session["l3txt56"] != null)
        {
            txtass6mod6.Text = Session["l3txt56"].ToString();
        }
        if (Session["l3txt57"] != null)
        {
            txtass7mod6.Text = Session["l3txt57"].ToString();
        }
        if (Session["l3txt58"] != null)
        {
            txtass8mod6.Text = Session["l3txt58"].ToString();
        }
        if (Session["l3txt59"] != null)
        {
            txtass9mod6.Text = Session["l3txt59"].ToString();
        }
        if (Session["l3txt60"] != null)
        {
            txtass10mod6.Text = Session["l3txt60"].ToString();
        }
        if (Session["l3txt61"] != null)
        {
            txtass1mod7.Text = Session["l3txt61"].ToString();
        }
        if (Session["l3txt62"] != null)
        {
            txtass2mod7.Text = Session["l3txt62"].ToString();
        }
        if (Session["l3txt63"] != null)
        {
            txtass3mod7.Text = Session["l3txt63"].ToString();
        }
        if (Session["l3txt64"] != null)
        {
            txtass4mod7.Text = Session["l3txt64"].ToString();
        }
        if (Session["l3txt65"] != null)
        {
            txtass5mod7.Text = Session["l3txt65"].ToString();
        }
        if (Session["l3txt66"] != null)
        {
            txtass6mod7.Text = Session["l3txt66"].ToString();
        }
        if (Session["l3txt67"] != null)
        {
            txtass7mod7.Text = Session["l3txt67"].ToString();
        }
        if (Session["l3txt68"] != null)
        {
            txtass8mod7.Text = Session["l3txt68"].ToString();
        }
        if (Session["l3txt69"] != null)
        {
            txtass9mod7.Text = Session["l3txt69"].ToString();
        }
        if (Session["l3txt70"] != null)
        {
            txtass10mod7.Text = Session["l3txt70"].ToString();
        }
        if (Session["l3txt71"] != null)
        {
            txtass1mod8.Text = Session["l3txt71"].ToString();
        }
        if (Session["l3txt72"] != null)
        {
            txtass2mod8.Text = Session["l3txt72"].ToString();
        }
        if (Session["l3txt73"] != null)
        {
            txtass3mod8.Text = Session["l3txt73"].ToString();
        }
        if (Session["l3txt74"] != null)
        {
            txtass4mod8.Text = Session["l3txt74"].ToString();
        }
        if (Session["l3txt75"] != null)
        {
            txtass5mod8.Text = Session["l3txt75"].ToString();
        }
        if (Session["l3txt76"] != null)
        {
            txtass6mod8.Text = Session["l3txt76"].ToString();
        }
        if (Session["l3txt77"] != null)
        {
            txtass7mod8.Text = Session["l3txt77"].ToString();
        }
        if (Session["l3txt78"] != null)
        {
            txtass8mod8.Text = Session["l3txt78"].ToString();
        }
        if (Session["l3txt79"] != null)
        {
            txtass9mod8.Text = Session["l3txt79"].ToString();
        }
        if (Session["l3txt80"] != null)
        {
            txtass10mod8.Text = Session["l3txt80"].ToString();
        }////////
        if (Session["l3weight1"] != null)
        {
            TextBox12.Text=Session["l3weight1"].ToString();
        }
        if (Session["l3weight2"] != null)
        {
            TextBox23.Text=Session["l3weight2"].ToString();
        }
        if (Session["l3weight3"] != null)
        {
            TextBox34.Text=Session["l3weight3"].ToString();
        }

        if (Session["l3weight4"] != null)
        {
            TextBox45.Text=Session["l3weight4"].ToString();
        }
        if (Session["l3weight5"] != null)
        {
            TextBox56.Text=Session["l3weight5"].ToString();
        }
        if (Session["l3weight6"] != null)
        {
            TextBox67.Text=Session["l3weight6"].ToString();
        }
        if (Session["l3weight7"] != null)
        {
           TextBox78.Text=Session["l3weight7"].ToString();
        }
        if (Session["l3weight8"] != null)
        {
            TextBox89.Text = Session["l3weight8"].ToString();
        }
        if (Session["avglbl3"] != null)
        {
            txtavg1styear.Text = Session["avglbl3"].ToString();
        } 
    }

    protected void TextBox45_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox12.Text != "")
        {
            txtavg1styear.Text = TextBox12.Text;
            Session["avglbl3"] = txtavg1styear.Text;
        }
        if (TextBox12.Text != "" && TextBox23.Text != "")
        {
            txtavg1styear.Text = ((Convert.ToDouble(TextBox12.Text) + Convert.ToDouble(TextBox23.Text)) / 2).ToString();
            Session["avglbl3"] = txtavg1styear.Text;
        }
        if (TextBox12.Text != "" && TextBox23.Text != "" && TextBox34.Text != "")
        {
            txtavg1styear.Text = ((Convert.ToDouble(TextBox12.Text) + Convert.ToDouble(TextBox23.Text) + Convert.ToDouble(TextBox34.Text)) / 3).ToString();
            Session["avglbl3"] = txtavg1styear.Text;
        }
        if (TextBox12.Text != "" && TextBox23.Text != "" && TextBox34.Text != "" && TextBox45.Text != "")
        {
            txtavg1styear.Text = ((Convert.ToDouble(TextBox12.Text) + Convert.ToDouble(TextBox23.Text) + Convert.ToDouble(TextBox34.Text) + Convert.ToDouble(TextBox45.Text)) / 4).ToString();
            Session["avglbl3"] = txtavg1styear.Text;
        }
        if (TextBox12.Text != "" && TextBox23.Text != "" && TextBox34.Text != "" && TextBox45.Text != "" && TextBox56.Text != "")
        {
            txtavg1styear.Text = ((Convert.ToDouble(TextBox12.Text) + Convert.ToDouble(TextBox23.Text) + Convert.ToDouble(TextBox34.Text) + Convert.ToDouble(TextBox45.Text) + Convert.ToDouble(TextBox56.Text)) / 5).ToString();
            Session["avglbl3"] = txtavg1styear.Text;
        }
        if (TextBox12.Text != "" && TextBox23.Text != "" && TextBox34.Text != "" && TextBox45.Text != "" && TextBox56.Text != "" && TextBox67.Text != "")
        {
            txtavg1styear.Text = ((Convert.ToDouble(TextBox12.Text) + Convert.ToDouble(TextBox23.Text) + Convert.ToDouble(TextBox34.Text) + Convert.ToDouble(TextBox45.Text) + Convert.ToDouble(TextBox56.Text) + Convert.ToDouble(TextBox67.Text)) / 6).ToString();
            Session["avglbl3"] = txtavg1styear.Text;
        }
        if (TextBox12.Text != "" && TextBox23.Text != "" && TextBox34.Text != "" && TextBox45.Text != "" && TextBox56.Text != "" && TextBox67.Text != "" && TextBox78.Text != "")
        {
            txtavg1styear.Text = ((Convert.ToDouble(TextBox12.Text) + Convert.ToDouble(TextBox23.Text) + Convert.ToDouble(TextBox34.Text) + Convert.ToDouble(TextBox45.Text) + Convert.ToDouble(TextBox56.Text) + Convert.ToDouble(TextBox67.Text) + Convert.ToDouble(TextBox78.Text)) / 7).ToString();
            Session["avglbl3"] = txtavg1styear.Text;
        }
        if (TextBox12.Text != "" && TextBox23.Text != "" && TextBox34.Text != "" && TextBox45.Text != "" && TextBox56.Text != "" && TextBox67.Text != "" && TextBox78.Text != "" && TextBox89.Text != "")
        {
            txtavg1styear.Text = ((Convert.ToDouble(TextBox12.Text) + Convert.ToDouble(TextBox23.Text) + Convert.ToDouble(TextBox34.Text) + Convert.ToDouble(TextBox45.Text) + Convert.ToDouble(TextBox56.Text) + Convert.ToDouble(TextBox67.Text) + Convert.ToDouble(TextBox78.Text) + Convert.ToDouble(TextBox89.Text)) / 8).ToString();
            Session["avglbl3"] = txtavg1styear.Text;
        }
    }
    protected void btnnext_Click(object sender, EventArgs e)
    {
        if (txtavg1styear.Text != "")
        {
            Response.Redirect("Summery.aspx", false);
        }
        else
        {
            lblmsg.ForeColor = System.Drawing.Color.Green;
            lblmsg.Text = "Plz Click On Calculate";
        }
    }
    #endregion
}

