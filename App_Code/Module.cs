using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using TrinityTej;
/// <summary>
/// Summary description for Module
/// </summary>
public class Module
{
    public Module()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static bool Modulereg(string course, int courseid, int yearid, string year, string module, string MName, string MCode, string MSem, string Msemid, string day_Lecture, string Lslotfrom, string LslotTo, string day_Tutorial, string tslotfrom, string tslotTo, string description, string Noofassesment, string Ass1, string Ass2, string weight, string credits)
    {

        try
        {
            string query02 = "select Course from ModuleMaster where Course='"+ course + "' and Year='" + year + "' and ModuleName='" + MName + "' and Assesment1='" + Ass1 + "'";
            SqlDataReader rd002;
            rd002 = ConnectionManager.ReaderQuery(query02);
            if (rd002.HasRows)
            {
                rd002.Read();
                {
                    return false;
                }
            }
            else
            {
                string querystr1 = "insert into ModuleMaster(Course,Courseid,YearId,Year,Module,ModuleName,ModuleCode,ModuleSem,ModuleSemId,Lecture_day,Lec_From,Lec_To,Tutorial_day,Tut_From,Tut_To,Description,Credits,Noofassesment,Assesment1,Assesment2,Weight) values('" + course + "','" + courseid + "','" + yearid + "','" + year + "','" + module + "','" + MName + "','" + MCode + "','" + MSem + "','" + Msemid + "','" + day_Lecture + "','" + Lslotfrom + "','" + LslotTo + "','" + day_Tutorial + "','" + tslotfrom + "','" + tslotTo + "','" + description + "','" + credits + "','" + Noofassesment + "','" + Ass1 + "','" + Ass2 + "','" + weight + "')";
                ConnectionManager.NonQuery(querystr1);
                return true;
                //string query1 = "insert into TargetDso_Abhay(Amid,Dsoid,Stateid,Cityid,Bankid,Targetamount,Month,Year,Remarks,Date,Month_Name) values(" + area_manager + "," + dso + "," + state + "," + citysno + "," + bankid + ",'" + dso_target_amount + "','" + month + "','" + yearrr + "','" + remark + "','" + datereg + "','"+monthname+"')";
                //ConnectionManager.NonQuery(query1);
                //return true;
            }

            rd002.Close();
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

    public static bool Assesmentdetail(string StudentId,string StudentName,string Course,string module,string lavel,string assesment,int assesmentId,string Marks,string maxmarks)
    {
        try
        {
            string querystr1 = "insert into Assesment(StudentRegno,Name,Course,Module,Year,Assesment,AssesmentId,Marks,Outof) values('" + StudentId + "','" + StudentName + "','" + Course + "','" + module + "','" + lavel + "','" + assesment + "','" + assesmentId + "','" + Marks + "','" + maxmarks + "')";
            ConnectionManager.NonQuery(querystr1);


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
    public static DataSet Assesmentdetailretrive(string StudentId,string moduleId, string lavel)
    {
       
        DataSet ds = new DataSet();
        try
        {
            string query1 = "select * from Assesment where StudentRegno='" + StudentId + "'and Module='" + moduleId + "' and Year='" + lavel + "' ";
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
    public static DataSet maxmarks(string year, string assesment,string module)
    {

        DataSet ds = new DataSet();
        try
        {
            string query1 = "select Assesment2 from ModuleMaster where Year='" + year + "' and Assesment1='" + assesment + "'and ModuleName='" + module + "' ";
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
    public static DataSet fillmoduledetail(int id)
    {

        DataSet ds = new DataSet();
        try
        {
            string query1 = "select Id,Course,Year,ModuleName,ModuleCode,ModuleSem,(Lecture_day+','+Lec_From+'-'+ Lec_To) as Lecture,(Tutorial_day+','+Tut_From+'-'+Tut_To) as Tutorial,Assesment1,Assesment2 from ModuleMaster where Courseid='" + id + "'"; //where StudentRegno='" + StudentId + "'and ModuleId='" + moduleId + "' and Year='" + lavel + "' ";
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
    public static DataSet getcourseid(string course)
    {

        DataSet ds = new DataSet();
        try
        {
            string query1 = "select Id from CourseMaster where CourseName='" + course + "'"; //where StudentRegno='" + StudentId + "'and ModuleId='" + moduleId + "' and Year='" + lavel + "' ";
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
    public static DataSet fillmoduledropdown(string a)
    {

        DataSet ds = new DataSet();
        try
        {
            string query1 = "select NoofModule from CourseMaster where CourseName='" + a + "'"; //where StudentRegno='" + StudentId + "'and ModuleId='" + moduleId + "' and Year='" + lavel + "' ";
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

    public static DataSet fillmodule_Namedropdown(string a,int yid)
    {

        DataSet ds = new DataSet();
        try
        {
            string query1 = "select distinct(ModuleName) from StudentSelected_ModuleMaster where EnrollementNo='" + a + "' and YearId='" + yid + "' and Freeze='y'"; //where StudentRegno='" + StudentId + "'and ModuleId='" + moduleId + "' and Year='" + lavel + "' ";
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
    public static DataSet overallresult(string StudentId)
    {

        DataSet ds = new DataSet();
        try
        {
            string query1 = "select * from Assesment where StudentRegno='" + StudentId + "'";
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
    public static DataSet Moduledetail()
    {
        DataSet ds = new DataSet();
        try
        {
            string query1 = "select distinct(ModuleSem+' '+ModuleCode+' '+ModuleName) as ModuleName,Max(Id) as id from ModuleMaster group by ModuleName,ModuleSem,ModuleCode";
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
    public static DataSet Moduledetailfoecourse(int yearid,int Cid)
    {
        DataSet ds = new DataSet();
        try
        {
            string query1 = "select distinct(ModuleSem+' '+ModuleCode+' '+ModuleName) as ModuleName,Max(Id) as id from ModuleMaster where YearId='" + yearid + "' and Courseid='" + Cid+ "' group by ModuleName,ModuleSem,ModuleCode";
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
    public static DataSet CourseID(string Enrollmentno)
    {
        DataSet ds = new DataSet();
        try
        {
            string query1 = "select Courseid from Logindetails where EnrollementNo='" + Enrollmentno + "'";
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
    public static DataSet Moduledetaildescription(int id)
    {
        DataSet ds = new DataSet();
        try
        {
            string query1 = "select Description from ModuleMaster where Id='" + id + "'";
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

    public static DataSet moduledetailbindgrid(int id)
    {
        DataSet ds = new DataSet();
        try
        {
            string query1 = "select Id,ModuleName,(Lecture_day+','+Lec_From+'-'+Lec_TO)as Lectore,(Tutorial_day+', '+Tut_From+'-'+Tut_TO)as tutorail,ModuleSem from ModuleMaster where Id='" + id + "'";
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

    public static bool deleteModuleDetails(int id)
    {

        try
        {
            string querystrMLUD = "Delete ModuleMaster where Id=" + id + " ";
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
    public static DataSet FillModule()
    {
        DataSet ds = new DataSet();
        try
        {
            string query1 = "select Id,NoofModule from CourseMaster ";
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
    public static DataTable graph(string reg,string lavel)
    {
        DataTable dtt = new DataTable();
        try
        {
            //string query1 = "Select distinct(module),avg (Marks)as Marks from Assesment where StudentRegno='" + reg + "' and Year='" + lavel + "' group by module ";
            string query1 = "Select Assesment,avg (Marks)as Marks from Assesment where StudentRegno='" + reg + "' and Year='"+lavel+"' group by Assesment";
            dtt = ConnectionManager.datatable(query1);
            return dtt;
        }
        catch (Exception ex)
        {
            return dtt;
        }
        finally
        {
            ConnectionManager.con.Close();
        }
    }
    public static DataTable alphabatical(string year, string cource, string Regno)
    {
        DataTable dtt = new DataTable();
        try
        {
            string query1 = "select Module,avg(Marks) as marks,avg(Outof)as Outof from Assesment where year='" + year + "' and Course='" + cource + "' and StudentRegno='" + Regno + "' group by Module order by Module asc";
            dtt = ConnectionManager.datatable(query1);
            return dtt;
        }
        catch (Exception ex)
        {
            return dtt;
        }
        finally
        {
            ConnectionManager.con.Close();
        }
    }
    public static DataTable Piegraph(string year,string cource,string Regno)
    {
        DataTable dtt = new DataTable();
        try
        {
            string query1 = "select Module,avg(Marks) as marks,avg(Outof)as Outof from Assesment where year='" + year + "' and Course='" + cource + "' and StudentRegno='" +Regno+ "' group by Module order by Marks desc";
            dtt = ConnectionManager.datatable(query1);
            return dtt;
        }
        catch (Exception ex)
        {
            return dtt;
        }
        finally
        {
            ConnectionManager.con.Close();
        }
    }

    public static DataTable Piegraphaesc(string year, string Course, string Regno)
    {
        DataTable dtt = new DataTable();
        try
        {
            string query1 = "select Module,avg(Marks) as marks,avg(Outof)as Outof  from Assesment where year='" + year + "' and Course='" + Course + "' and StudentRegno='" + Regno + "' group by Module order by Marks asc";
            //string query1 = "select top(7)* from tb_all_subject_record";

            dtt = ConnectionManager.datatable(query1);
            return dtt;
        }
        catch (Exception ex)
        {
            return dtt;
        }
        finally
        {
            ConnectionManager.con.Close();
        }
    }
    public static DataSet Searchstudentinfor(string regno)
    {
        DataSet dsgrid = new DataSet();
        try
        {
            string query1 = "select Name,Course from LoginDetails where EnrollementNo='" + regno + "'";
            dsgrid = ConnectionManager.data_set(query1);
            return dsgrid;
        }
        catch (Exception ex)
        {
            return dsgrid;
        }
        finally
        {
            ConnectionManager.con.Close();
        }
    }

    public static DataSet Assesmentexist(string StudentId,int assesmentId,string module)
    {
        DataSet dsgrid = new DataSet();
        try
        {
            string query1 = "select Id from Assesment where StudentRegno='" + StudentId + "' and AssesmentId='" + assesmentId + "' and Module='" + module + "'";
            dsgrid = ConnectionManager.data_set(query1);
            return dsgrid;
        }
        catch (Exception ex)
        {
            return dsgrid;
        }
        finally
        {
            ConnectionManager.con.Close();
        }
    }
    public static DataSet Bindcourse()
    {
        DataSet ds = new DataSet();
        try
        {
            string query1 = "select Id,CourseName from CourseMaster where Status='y' order by CourseName asc";
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

    public static DataSet BindcourseStudentsection(string Enroll)
    {
        DataSet ds = new DataSet();
        try
        {
            string query1 = "select Courseid,Course from Logindetails where EnrollementNo='" + Enroll + "'";
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



    public static DataSet Bindregno()
    {
        DataSet ds = new DataSet();
        try
        {
            string query1 = "select Distinct(StudentRegno) from Assesment order by StudentRegno asc";
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

    public static DataSet Bindmoduless()
    {
        DataSet ds = new DataSet();
        try
        {
            string query1 = "select distinct(ModuleName) from ModuleMaster order by ModuleName asc";
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

    public static DataSet BindCourses()
    {
        DataSet ds = new DataSet();
        try
        {
            string query1 = "select distinct(CourseName) from CourseMaster order by CourseName asc";
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
    public static DataSet Bindmodule()
    {
        DataSet ds = new DataSet();
        try
        {
            string query1 = "select distinct(ModuleName) from ModuleMaster  order by ModuleName asc";
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

    public static bool insertcourse(string course, string module)
    {
        try
        {
            string querystr1 = "insert into CourseMaster(CourseName,NoofModule,Status) values('" + course + "','" + module + "','y')";
            ConnectionManager.NonQuery(querystr1);


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
    public static bool deletecourse(int id)
    {
        try
        {
            string querystrMLUD = "Update CourseMaster set Status='n' where Id=" + id + " ";
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
    public static DataSet bindcoursemaster()
    {
        DataSet ds = new DataSet();
        try
        {
            string query1 = "select * from CourseMaster where Status='y' order by CourseName asc";
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

    public static bool deleteModule(int id)
    {
        try
        {
            string querystrMLUD = "Delete ModuleMaster where Id=" + id + " ";
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

    public static bool deleteassesment(int id)
    {
        try
        {
            string querystrMLUD = "Delete Assesment where Id=" + id + " ";
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
    public static bool delete(int id)
    {
        try
        {
            string querystrMLUD = "Delete StudentSelected_ModuleMaster where Id=" + id + " ";
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

    public static DataSet editModulemaster(int id)
    {

        DataSet ds = new DataSet();
        try
        {
            string query1 = "select * from ModuleMaster where Id='" + id + "'"; //where StudentRegno='" + StudentId + "'and ModuleId='" + moduleId + "' and Year='" + lavel + "' ";
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

    public static bool updatemodulemaster(int yearid, string year, string module, string MName, string MCode, string MSem, string Msemid, string Lslotfrom, string LslotTo, string tslotfrom, string tslotTo, string description, string Assmarks,int Id)
    {
        try
        {
            string querystr1 = "update ModuleMaster set YearId='" + yearid + "',Year='" + year + "',Module='" + module + "', ModuleName='" + MName + "', ModuleCode='" + MCode + "', ModuleSem='" + MSem + "',ModuleSemId='" + Msemid + "', Lec_From='" + Lslotfrom + "', Lec_To='" + LslotTo + "',Tut_From='" + tslotfrom + "',Tut_To='" + tslotTo + "', Description='" + description + "', Assesment2='" + Assmarks + "' where Id='" + Id + "' ";
            ConnectionManager.NonQuery(querystr1);


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
    //Check if the module clashes with other modules.
    public static bool checktutorialTiming(string lecture, string tutorial, string EnrollmentNo, int ModuleSemId, string Year)
    {

        DataSet ds = new DataSet();
        try
        {
            string query1 = "select Id from StudentSelected_ModuleMaster where Lecture='" + lecture + "'and Tutorial='" + tutorial + "'and EnrollementNo='" + EnrollmentNo + "'and ModuleSemId='" + ModuleSemId + "'and Year='" + Year + "'"; //where StudentRegno='" + StudentId + "'and ModuleId='" + moduleId + "' and Year='" + lavel + "' ";
            SqlDataReader rd002;
            rd002 = ConnectionManager.ReaderQuery(query1);
            if (rd002.HasRows)
            {
                rd002.Read();
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
            rd002.Close();
        }
        catch (Exception ex)
        {
            return true;
        }
        finally
        {
            ConnectionManager.con.Close();
        }
    }

///count module each sem not more than 8
    public static DataSet cuontnoofmodule(string YearId,string EnrollmentNo)
    {
        DataSet ds = new DataSet();
        try
        {
            string query1 = "select Id from StudentSelected_ModuleMaster where YearId='"+YearId+"'and EnrollementNo='"+EnrollmentNo+ "'and EnrollementNo='" + EnrollmentNo + "'"; //where StudentRegno='" + StudentId + "'and ModuleId='" + moduleId + "' and Year='" + lavel + "' ";
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
}
