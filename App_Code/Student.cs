using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Reflection;
using System.Collections;
using System.Globalization;
using TrinityTej;
public class Student
{
    static string autofenid;

    public static bool savedata(string enrollment,string Password,string course,int courseid,string name, string dob, string gender, string fathername, string occupation, string PresentAdd, string Email, Int64 emContact, Int64 Phone)
    {
        try
        {
            DateTime myDateTime1 = DateTime.Now;
            int year = Convert.ToInt32(myDateTime1.Year.ToString());
            int months = Convert.ToInt32(myDateTime1.Month.ToString());
            string days = myDateTime1.Day.ToString();
            //string fulldate = DateTime.Today.ToString("MM/dd/yyyy");
            // DateTime fulldate =Convert.ToDateTime(DateTime.Today.ToString("dd/MM/yyyy"));
            //Convert.ToDateTime(fulldate);
            string fulldate = days + '-' + months + '-' + year;
            string query = "insert into LoginDetails(UserId,Pswd,Courseid,Course,Active,RoleID,EnrollementNo,Name,Dob,Gender,Father,Occupation,Present_Address,Email,Emergency_Contact,Phone,RegDate)values('" + enrollment + "','" + Password + "','" + courseid + "','" + course + "','y','STUDENT','" + enrollment + "','" + name + "','" + dob + "','" + gender + "','" + fathername + "','" + occupation + "','" + PresentAdd + "','" + Email + "'," + emContact + "," + Phone + ",'" + fulldate + "')";
            ConnectionManager.NonQuery(query);

            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
        finally
        {
            if (ConnectionManager.con.State == ConnectionState.Open)
            {
                ConnectionManager.con.Close();
            }
        }
    }

    public static DataSet checkEmail(string emailid)
    {
        DataSet dss = new DataSet();
        try
        {
            string query1 = "select EmailId from LoginDetails where EmailId='" + emailid + "'";
            SqlDataAdapter ad = new SqlDataAdapter(query1, ConnectionManager.con);
            ad.Fill(dss);
            return dss;
        }
        catch
        {
            return dss;
        }
        finally
        {
            ConnectionManager.con.Close();
        }
    }

    public static DataSet UserIDCheck(string useridd)
    {
        DataSet dss = new DataSet();
        try
        {
            string query1 = "select UserId from LoginDetails where UserId='" + useridd + "'";
            SqlDataAdapter ad = new SqlDataAdapter(query1, ConnectionManager.con);
            ad.Fill(dss);
            return dss;
        }
        catch
        {
            return dss;
        }
        finally
        {
            ConnectionManager.con.Close();
        }
    }
    public static DataSet studentinformation()
    {
        DataSet dsbank = new DataSet();
        try
        {
            string query = "select distinct StudentSelected_ModuleMaster.EnrollementNo,LoginDetails.*  from LoginDetails inner join StudentSelected_ModuleMaster On StudentSelected_ModuleMaster.EnrollementNo=LoginDetails.EnrollementNo where LoginDetails.RoleID!='SAM' ";
            dsbank = ConnectionManager.data_set(query);
            return dsbank;
        }
        catch (Exception ex)
        {
            return dsbank;
        }
        finally
        {
            ConnectionManager.con.Close();
        }
    }
    /*
    public static DataSet studentInfoCourse()
    {
        DataSet dsbank = new DataSet();
        try
        {
            string query = "select distinct StudentSelected_ModuleMaster.EnrollementNo,LoginDetails.*  from LoginDetails inner join StudentSelected_ModuleMaster On StudentSelected_ModuleMaster.EnrollementNo=LoginDetails.EnrollementNo where Course='" + ddlmodule + "'";
            dsbank = ConnectionManager.data_set(query);
            return dsbank;
        }
        catch (Exception ex)
        {
            return dsbank;
        }
        finally
        {
            ConnectionManager.con.Close();
        }
    }
     * */
    public static bool Delete_studentrecord(string Id)
    {
        try
        {
            string SQlDelete = "delete from Student_Registration where Id='" + Id + "'";
            ConnectionManager.NonQuery(SQlDelete);
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
        finally
        {
            ConnectionManager.con.Close();
        }

    }
    public static DataSet SearchStudent(string Module,string name,string date)
    {
        DataSet ds = new DataSet();
        try
        {
            string query1 = "select distinct StudentSelected_ModuleMaster.EnrollementNo,LoginDetails.*  from LoginDetails inner join StudentSelected_ModuleMaster On StudentSelected_ModuleMaster.EnrollementNo=LoginDetails.EnrollementNo where  LoginDetails.Name like'%" + name + "' and LoginDetails.RegDate like '%" + date + "' and LoginDetails.RoleID!='SAM'";
            ds = ConnectionManager.data_set(query1);
            return ds;
        }
        catch (Exception ex)
        {
            return ds;
        }
        finally
        {
            ConnectionManager.con.Close();
        }
    }
    public static DataSet SearchStudentwithoutmodule(string name, string date)
    {
        DataSet ds = new DataSet();
        try
        {
            string query1 = "select distinct StudentSelected_ModuleMaster.EnrollementNo,LoginDetails.*  from LoginDetails inner join StudentSelected_ModuleMaster On StudentSelected_ModuleMaster.EnrollementNo=LoginDetails.EnrollementNo where LoginDetails.Name like'%" + name + "' and LoginDetails.RegDate like '%" + date + "' and LoginDetails.RoleID!='SAM'";
            ds = ConnectionManager.data_set(query1);
            return ds;
        }
        catch (Exception ex)
        {
            return ds;
        }
        finally
        {
            ConnectionManager.con.Close();
        }
    }

    public static bool deletestudentrecord(int id)
    {

        try
        {
            string querystrMLUD = "Delete LoginDetails where SNo=" + id + " ";
            ConnectionManager.NonQuery(querystrMLUD);

            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
        finally
        {
            if (ConnectionManager.con.State == ConnectionState.Open)
            {
                ConnectionManager.con.Close();
            }
        }
    }
    public static string autogenEnrollmentno(string SMS, string module)
    {

        try
        {
            int suppinitial;
            string sup = SMS;
            string p = module;
            string a = "W";// getcode(sup, module);
            string query02 = "Select EnrollementNo from LoginDetails Where SNo=(SELECT MAX(SNo)FROM LoginDetails where RoleID!='SAM')";
            SqlDataReader rd002;
            rd002 = ConnectionManager.ReaderQuery(query02);
            if (rd002.HasRows)
            {
                rd002.Read();
                {
                    string s = rd002[0].ToString();
                    String st = s;
                    String[] stArr = st.Split('W');
                    String lastItem = stArr[(stArr.Length - 1)];
                    suppinitial = Convert.ToInt32(lastItem.Substring(0, 1));
                    suppinitial = (Convert.ToInt32(lastItem) + 1);
                    autofenid = (a + suppinitial);
                    return autofenid;
                }
            }
            else
            {
                String s = "0";
                suppinitial = Convert.ToInt32(s.Substring(0, 1));
                suppinitial = suppinitial + 1;
                autofenid = (a + suppinitial);
                return autofenid;

            }

            rd002.Close();
        }
        catch (Exception ex)
        {
            return autofenid;
        }
        finally
        {
            ConnectionManager.con.Close();
        }

    }

    public static string getcode(string sup, string p)
    {

        string supplier = sup;
        string productname = p;
        string code = "";

        string suppinitial = supplier.Substring(0, 1);
        code = code + suppinitial.ToUpper();

        string[] words = productname.Split('W');
        foreach (string word in words)
        {
            Console.WriteLine(word);

            string fstLetter = word.Substring(0, 3);
            fstLetter = fstLetter.ToUpper();
            code = code + "W" + fstLetter;

            //code = code + " " + "/" + lblmaxid.Text;

        }
        code = code + "" + "W";
        return code;
    }
    public static DataSet Modulereg(string ModuleSem,int ModuleSemId,string EnrollmentNo,string yid)
    {
        DataSet ds = new DataSet();
       
        try
        {

            string query02 = "select ModuleSem from StudentSelected_ModuleMaster where ModuleSem='" + ModuleSem + "' and ModuleSemId='" + ModuleSemId + "' and EnrollementNo='" + EnrollmentNo + "' and YearId='" + yid + "'";
             ds = ConnectionManager.data_set(query02);
             return ds;
        }
           
        catch (Exception ex)
        {
            return ds;
        }
        finally
        {
            ConnectionManager.con.Close();
        }

    }

    public static DataSet checkmoduleexist(string ModuleName,string ModuleCode,string EnrollmentNo)
    {
        DataSet ds = new DataSet();

        try
        {

            string query02 = "select ModuleName from StudentSelected_ModuleMaster where ModuleName='" + ModuleName + "' and ModuleCode='" + ModuleCode + "' and EnrollementNo='" + EnrollmentNo + "'";
            ds = ConnectionManager.data_set(query02);
            return ds;
        }

        catch (Exception ex)
        {
            return ds;
        }
        finally
        {
            ConnectionManager.con.Close();
        }

    }
    public static DataSet insertintoStudent_module(int Sno)//////////////////////uioiiouiouioioioiuo///////////////////
    {
        DataSet ds = new DataSet();
        try
        {
            string query1 = "select Course,Courseid,YearId,Year,Module,ModuleName,ModuleCode,ModuleSem,ModuleSemId,(Lecture_day+','+Lec_From+'-'+Lec_TO)as Lectore,(Tutorial_day+', '+Tut_From+'-'+Tut_TO)as tutorail,Credits from ModuleMaster Where Id='" + Sno + "'";
            ds = ConnectionManager.data_set(query1);
            return ds;
        }
        catch (Exception ex)
        {
            return ds;
        }
        finally
        {
            ConnectionManager.con.Close();
        }


    }
    public static bool StudentSelected_ModuleMaster(string EnrollmentNo, string Course, int Courseid, string YearId, string Year, int ModuleId, string ModuleName,string credites, string ModuleCode, string ModuleSem, int ModuleSemId,string lecture, string tutorial)
    {
        try
        {
            string query = "insert into StudentSelected_ModuleMaster(EnrollementNo,Course,Courseid,YearId,Year,Module,ModuleName,Credites,ModuleCode,ModuleSem,ModuleSemId,Lecture,Tutorial)values('" + EnrollmentNo + "','" + Course + "','" + Courseid + "','" + YearId + "','" + Year + "','" + ModuleId + "','" + ModuleName + "','" +credites + "','" + ModuleCode + "','" + ModuleSem + "','" + ModuleSemId + "','" + lecture + "','" + tutorial + "')";
            ConnectionManager.NonQuery(query);
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
        finally
        {
            if (ConnectionManager.con.State == ConnectionState.Open)
            {
                ConnectionManager.con.Close();
            }
        }
    }

    public static DataSet bindgridstudent(string EnrollmentNo,int yid)
    {
        DataSet ds = new DataSet();
        try
        {
            string query= "select * from StudentSelected_ModuleMaster where EnrollementNo='" + EnrollmentNo + "' and YearId='"+yid+"' and freeze='y'";
            ds = ConnectionManager.data_set(query);
            return ds;
        }
        catch (Exception ex)
        {
            return ds;
        }
        finally
        {
            ConnectionManager.con.Close();
        }
    }

    public static DataSet bindgridstudentafterfreezing(string EnrollmentNo, int yid)
    {
        DataSet ds = new DataSet();
        try
        {
            string query1 = "select * from StudentSelected_ModuleMaster where EnrollementNo='" + EnrollmentNo + "' and YearId='" + yid + "'";
            ds = ConnectionManager.data_set(query1);
            return ds;
        }
        catch (Exception ex)
        {
            return ds;
        }
        finally
        {
            ConnectionManager.con.Close();
        }
    }

    public static DataSet Moduleforgradepre(string EnrollmentNo,int yid)
    {
        DataSet ds = new DataSet();
        try
        {
            string query1 = "select distinct(ModuleName COLLATE DATABASE_DEFAULT+',credites-'+Credites COLLATE DATABASE_DEFAULT)as ModuleName from StudentSelected_ModuleMaster where EnrollementNo='" + EnrollmentNo + "' and YearId='" + yid + "'";
            ds = ConnectionManager.data_set(query1);
            return ds;
        }
        catch (Exception ex)
        {
            return ds;
        }
        finally
        {
            ConnectionManager.con.Close();
        }
    }
    /// <summary>
    /// ////////////////////////////////////////////////
    /// </summary>
    /// <param name="Module"></param>
    /// <returns></returns>
    public static DataSet gradeprediction(string Modulename)
    {
        DataSet ds = new DataSet();
        try
        {
            string text = Modulename;
            string[] after = text.Split(',');
            string Module =(after[0]);
            string query1 = "select Assesment1+';'+Weight+';(%)' as Assesment1 ,Weight from ModuleMaster where ModuleName='" + Module + "'";
            ds = ConnectionManager.data_set(query1);
            return ds;
        }
        catch (Exception ex)
        {
            return ds;
        }
        finally
        {
            ConnectionManager.con.Close();
        }
    }

   
    //for Freezing module
    public static bool updateselectmodule(string EnrollmentNo)
    {
        try
        {
            string query = "update StudentSelected_ModuleMaster set freeze='y' where EnrollementNo='" + EnrollmentNo + "'";
            ConnectionManager.NonQuery(query);
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
        finally
        {
            if (ConnectionManager.con.State == ConnectionState.Open)
            {
                ConnectionManager.con.Close();
            }
        }
    }

    public static DataSet selectfreezemodule(string EnrollmentNo)
    {
        DataSet ds = new DataSet();
        try
        {
            string query1 = "selectId from StudentSelected_ModuleMaster where Freeze='y' and EnrollementNo='" + EnrollmentNo + "'";
            ds = ConnectionManager.data_set(query1);
            return ds;
        }
        catch (Exception ex)
        {
            return ds;
        }
        finally
        {
            ConnectionManager.con.Close();
        }
    }
    public static bool ChangePasswordStepCHECK(string oldpass, string userid)
    {
        DataSet ds = new DataSet();
        string oldpassword;
        try
        {
            string query02 = "select Pswd from Logindetails where UserId='" + userid + "'";
            SqlDataAdapter ad = new SqlDataAdapter(query02, ConnectionManager.con);
            ad.Fill(ds);
            SqlCommandBuilder sqlcmd = new SqlCommandBuilder();
            DataRow drrrow = ds.Tables[0].Rows[0];
            oldpassword = drrrow["Pswd"].ToString();
            if (oldpass == oldpassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception ex)
        {
            return false;
        }
        finally
        {
            ConnectionManager.con.Close();
        }
    }
    public static bool ChangePasswordCOMPLETED(string oldpass, string userid, string newpass)
    {
        try
        {
            string query02 = "update LoginDetails set Pswd='" + newpass + "' where UserId='" + userid + "' and Pswd='" + oldpass + "'";
            ConnectionManager.NonQuery(query02);
            return true;

        }
        catch (Exception ex)
        {
            return false;
        }
        finally
        {
            ConnectionManager.con.Close();
        }
    }
    
}

   
