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
/// <summary>
/// Summary description for SuperAdmin
/// </summary>
public class SuperAdmin
{
    public static Int32 RegisterSno()
    {
        Int32 sno = 0;
        string querystr = "";
        querystr = "select max(SNo) from LoginDetails";
        //ConnectionManager.ReaderQuery(querystr);
        SqlDataReader rd;
        rd = ConnectionManager.ReaderQuery(querystr);
        if (rd.HasRows)
        {
            rd.Read();
            if (rd[0] is DBNull)
            {
                sno = 1;
            }
            else
            {
                sno = Convert.ToInt32(rd[0]) + 1;
            }
        }
        else
        {
            sno = 1;
        }
        rd.Close();
        return sno;
    }

 
    public static bool savedata(int LDsno, string user_Id, string email_id, string password,string expirydate, int masterUserRightId, string state, string city, string designation, string fname, string mname, string lname, string empcode, Int64 mobilenumber,string bank,string bankid,string ins_name,string insid, string remark,string pincode, string dateofJoining, string imageurl)
    {
        Int32 loginSno = RegisterSno();
        Int64 pincode_int = Convert.ToInt64(pincode);
        DateTime dtdt = DateTime.Today.Date;
        try
        {
            Int32 mlud_sno = 0;
            string querystr = "select max(SNo) from MasterLoginUserDetails";
            SqlDataReader rd;
            rd = ConnectionManager.ReaderQuery(querystr);
            if (rd.HasRows)
            {
                rd.Read();
                if (rd[0] is DBNull)
                {
                    mlud_sno = 1;
                }
                else
                {
                    mlud_sno = Convert.ToInt32(rd[0]) + 1;
                }
            }
            else
            {
                mlud_sno = 1;
            }
            rd.Close();

            //Int32 citysno = 0;
            //string cityname;
            //string query2 = "select max(CityId) from MasterCity";
            //SqlDataReader rd2;
            //rd2 = ConnectionManager.ReaderQuery(query2);
            //if (rd2.HasRows)
            //{
            //    rd2.Read();
            //    if (rd2[0] is DBNull)
            //    {
            //        citysno = 1;
            //    }
            //    else
            //    {
            //        citysno = Convert.ToInt32(rd2[0]) + 1;
            //    }
            //}
            //else
            //{
            //    citysno = 1;
            //}
            //rd2.Close();


            if (!string.IsNullOrEmpty(expirydate))
            {
                //DateTime dt = DateTime.ParseExact(expirydate,"dd-MM-yyyy",null);
                string datesda;
                DateTime dt;

                //DateTime date = DateTime.ParseExact(this.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                if (CultureInfo.CurrentCulture.Name == "en-GB")
                {
                    dt = DateTime.ParseExact(expirydate, "dd-MM-yyyy", new CultureInfo("en-GB"));
                    //datesda = dt.ToString(CultureInfo.InstalledUICulture.DateTimeFormat.ShortDatePattern);
                    //datesda = dt.ToString();                    
                    //datesda = dt.ToShortDateString();
                    // datesda = "" + datesda + "";
                    datesda = dt.ToShortDateString();
                }
                else
                {
                    dt = DateTime.ParseExact(expirydate, "dd-MM-yyyy", CultureInfo.CreateSpecificCulture("en-US"));
                    //datesda = dt.ToString();                    
                    // datesda = dt.ToShortDateString();
                    //datesda = "" + datesda + "";
                    datesda = dt.ToShortDateString();
                }

                // commented to use latest max login sno..   string querstring = "insert into LoginDetails(SNo,UserId,EmailId,Pswd,QusOne,Ans,ExpDate,Active,Deleted,MLUDID,MURID) values(" + LDsno + ",'" + user_Id + "','" + email_id + "','" + password + "','" + question + "','" + answer + "','" + datesda + "','n','n'," + mlud_sno + "," + masterUserRightId + ")";
                string querstring = "insert into LoginDetails(SNo,UserId,EmailId,Pswd,ExpDate,Active,Deleted,MLUDID,MURID) values(" + loginSno + ",'" + user_Id + "','" + email_id + "','" + password + "','" + datesda + "','n','n'," + mlud_sno + "," + masterUserRightId + ")";
                ConnectionManager.NonQuery(querstring);
            }
            else
            {

                // commented to use latest max login sno..      string querstring = "insert into LoginDetails(SNo,UserId,EmailId,Pswd,QusOne,Ans,ExpDate,Active,Deleted,MLUDID,MURID) values(" + LDsno + ",'" + user_Id + "','" + email_id + "','" + password + "','" + question + "','" + answer + "','" + expirydate + "','n','n'," + mlud_sno + "," + masterUserRightId + ")";
                string querstring = "insert into LoginDetails(SNo,UserId,EmailId,Pswd,QusOne,Ans,Active,Deleted,MLUDID,MURID) values(" + loginSno + ",'" + user_Id + "','" + email_id + "','" + password + "','n','n'," + mlud_sno + "," + masterUserRightId + ")";
                ConnectionManager.NonQuery(querstring);
            }


            //string query3 = "select CityName,CityId from MasterCity where CityName='" + city + "'";
            //SqlDataReader rd3;
            //rd3 = ConnectionManager.ReaderQuery(query3);
            //if (rd3.HasRows)
            //{
            //    rd3.Read();
            //    if (rd3[0] is DBNull)
            //    {
            //        string querystr1 = "insert into MasterCity(CityId,CityName,StateId) values(" + citysno + ",'" + city + "'," + Convert.ToInt32(state) + ")";
            //        ConnectionManager.NonQuery(querystr1);
            //    }
            //    else
            //    {
            //        citysno = Convert.ToInt32(rd3[1]);
            //    }
            //}
            //else
            //{
            //    // commented to use latest max login sno..               string querystr1 = "insert into MasterCity(CityId,CityName,StateId) values(" + citysno + ",'" + city + "'," + Convert.ToInt32(state) + ")";
            //    string querystr1 = "insert into MasterCity(CityId,CityName,StateId) values(" + citysno + ",'" + city + "'," + Convert.ToInt32(state) + ")";
            //    ConnectionManager.NonQuery(querystr1);
            //}
            //rd3.Close();



            string datesdaa = "";
            DateTime datejoin;
            DateTime datereg = DateTime.Today;
            string JoinDate = "";
            string DateREG = datereg.ToShortDateString();
            // string dateregister = dtt.ToString("dd-MM-yyyy");

            //if (CultureInfo.CurrentCulture.Name == "en-GB")
            //{
            //    datereg = DateTime.ParseExact(dateregister, "dd-MM-yyyy", new CultureInfo("en-GB"));
            //    //datesda = dt.ToString(CultureInfo.InstalledUICulture.DateTimeFormat.ShortDatePattern);
            //    //datesdaa = dtt.ToString();
            //    //datesdaa = "" + datesdaa + "";
            //    datesdaa = dtt.ToShortDateString();
            //    // datesdaa = "'" + datesdaa + "'";
            //}
            //else
            //{
            //    dtt = DateTime.ParseExact(dateregister, "dd-MM-yyyy", CultureInfo.CreateSpecificCulture("en-US"));
            //    //datesdaa = dtt.ToString();
            //    //datesdaa = "" + datesdaa + "";
            //    datesdaa = dtt.ToShortDateString();
            //    // datesdaa = "'" + datesdaa + "'";
            //}

            if (!string.IsNullOrEmpty(dateofJoining))
            {

                if (CultureInfo.CurrentCulture.Name == "en-GB")
                {
                    datejoin = DateTime.ParseExact(dateofJoining, "dd-MM-yyyy", new CultureInfo("en-GB"));
                    //datesda = dt.ToString(CultureInfo.InstalledUICulture.DateTimeFormat.ShortDatePattern);

                    //JOINdate = dtt.ToString();
                    //JOINdate = "" + JOINdate + "";

                    JoinDate = datejoin.ToShortDateString();
                    //JOINdate = "'" + JOINdate + "'";
                }
                else
                {
                    datejoin = DateTime.ParseExact(dateofJoining, "dd-MM-yyyy", new CultureInfo("en-US"));
                    //dtt = DateTime.ParseExact(dateofJoining, "dd-MM-yyyy", CultureInfo.CreateSpecificCulture("en-US"));
                    //JOINdate = dtt.ToString();
                    //JOINdate = "" + JOINdate + "";                       
                    // JOINdate = dtt.ToShortDateString();
                    // JOINdate = "'" + JOINdate + "'";
                    JoinDate = datejoin.ToShortDateString();
                }

                string querystrMLUD = "insert into MasterLoginUserDetails(SNo,LoginId,FirstName,MiddleName,LastName,EmpCode,Design,EmailId,MobNumber,OffPhnNumber,Bankid,CompanyName,Insid,State,City,PinCode,DateRegister,DateOfJoin,Photo,MURID,Deleted,Remarks) values(" + mlud_sno + "," + loginSno + ",'" + fname + "','" + mname + "','" + lname + "','" + empcode + "','" + designation + "','" + email_id + "'," + mobilenumber + ",'" + bank + "','" + bankid + "','" + ins_name + "','" + insid + "'," + state + "," + city + "," + pincode_int + ",'" + DateREG + "','" + JoinDate + "','" + imageurl + "'," + masterUserRightId + ",'n','" + remark + "')";
                ConnectionManager.NonQuery(querystrMLUD);
            }
            else
            {
                string querystrMLUD ="insert into MasterLoginUserDetails(SNo,LoginId,FirstName,MiddleName,LastName,EmpCode,Design,EmailId,MobNumber,OffPhnNumber,Bankid,CompanyName,Insid,State,City,PinCode,DateRegister,DateOfJoin,Photo,MURID,Deleted,Remarks) values(" + mlud_sno + "," + loginSno + ",'" + fname + "','" + mname + "','" + lname + "','" + empcode + "','" + designation + "','" + email_id + "'," + mobilenumber + ",'" + bank + "','" + bankid + "','" + ins_name + "','" + insid + "'," + state + "," + city + "," + pincode_int + ",'" + DateREG + "','" + JoinDate + "','" + imageurl + "'," + masterUserRightId + ",'n','" + remark + "')";
                ConnectionManager.NonQuery(querystrMLUD);
            }


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

    public SuperAdmin()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}
