using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
/// <summary>
/// Summary description for ConnectionManager
/// </summary>
namespace TrinityTej
{
    public class ConnectionManager
    {
     //Creating connection to the database  
        public static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["trinity"].ConnectionString);
        public static SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["trinity"].ConnectionString);
        public ConnectionManager()
        {


        }
        //This command is used to trigger the validateUser function in the login class.
        public static SqlCommand sql_command(string storedproc)
        {

            SqlCommand cmd = new SqlCommand(storedproc, con);
            return cmd;
        }

        public static void NonQuery(string queryString)
        {
          
            if (ConnectionManager.con.State == ConnectionState.Open)
            {
                ConnectionManager.con.Close();
            }
            try
            {
                SqlCommand command = new SqlCommand(queryString, con);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
              
            }
            finally
            {
                ConnectionManager.con.Close();
               
            }

        }
        //This code is used to read the query, what it does is it gets the query from the code, and establish a connection
        //with the database, and it checks if the connected state is open it close it.
        public static SqlDataReader ReaderQuery(string querystr)
        {
            if (ConnectionManager.con.State == ConnectionState.Open)
            {
                ConnectionManager.con.Close();
            }

            if (ConnectionManager.con1.State == ConnectionState.Open)
            {
                ConnectionManager.con1.Close();
            }
           //This is a try catch statment it create SQLDataReader variable (rd), and create new command SQL, then it assign the command
            //text to the query string, then open con1 (connection 1) to the databse, ahd it assign the command to the connection,
            //to start excuting the query from the databse, and it will return the values to the variable rd.
            //otherwise it will through exception.
                try
                {
                    SqlDataReader rd;
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = querystr;
                    con1.Open();
                    cmd.Connection = con1;
                    rd = cmd.ExecuteReader();
                    return rd;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {

                }
            
        }
        //Creating a dataset, with a string peramiter squery, used to display the name of courses.
        //This is also used to read the name of the module data form the database.
        public static DataSet data_set(string squery)
        {
            DataSet dsss = new DataSet();
            try
            {
                SqlDataAdapter add = new SqlDataAdapter(squery, con);
                add.Fill(dsss);
                return dsss;
            }
            catch (Exception ex)
            {
                return dsss;
            }
        }
        //This is used to display the the student chart information
        //for example displaying the result in the chart, module name etc..

        public static DataTable datatable(string squery)
        {
            DataTable dtt = new DataTable();
            try
            {
                SqlDataAdapter add = new SqlDataAdapter(squery, con);
                add.Fill(dtt);
                return dtt;
            }
            catch (Exception ex)
            {
                return dtt;
            }
        }
    }

        public class login
        {
           /* This function is used to validate if the user has entered a correct details or not
            * and if they are admin or student.
            */
            public static string validateUser(string userid, string password, Int32 user_type)
            {
                SqlDataAdapter add;
                DataSet ds;

                string u_id, u_pass;
                string wrong = "";
                //Int32 userrights;
                try
                {
                   
                    SqlCommand cmd = ConnectionManager.sql_command("logincheck");           
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter sqlpmm = new SqlParameter();
                    sqlpmm = new SqlParameter();
                    sqlpmm.ParameterName = "@user_type";
                    sqlpmm.DbType = DbType.Int32;
                    sqlpmm.Value = user_type;
                    cmd.Parameters.Add(sqlpmm);

                    sqlpmm = new SqlParameter();
                    sqlpmm.ParameterName = "@user_id";
                    sqlpmm.DbType = DbType.String;
                    sqlpmm.Value = userid;
                    cmd.Parameters.Add(sqlpmm);

                    sqlpmm = new SqlParameter();
                    sqlpmm.ParameterName = "@user_pass";
                    sqlpmm.DbType = DbType.String;
                    sqlpmm.Value = password;

                    cmd.Parameters.Add(sqlpmm);

                    SqlCommandBuilder sqlcmdbuild = new SqlCommandBuilder();
                    sqlcmdbuild = new SqlCommandBuilder();
                    add = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    add.Fill(ds);
                    DataRow logincheckck = ds.Tables[0].Rows[0];
                    u_id = logincheckck["UserId"].ToString();
                    u_pass = logincheckck["Pswd"].ToString();
                    //userrights = Convert.ToInt32(logincheckck["MURID"]);
                    string userrole = logincheckck["RoleID"].ToString();
                    string expdate = logincheckck["ExpDate"].ToString();
                    DateTime expdt2 = new DateTime();
                    DateTime? expdt1 = null;

                    DateTime dt = DateTime.Today.Date;
                    if (expdate != "")
                    {
                        expdt1 = DateTime.ParseExact(expdate, "dd/MM/yyyy", null);
                        if (expdt1 > dt)
                        {
                            if (u_id == userid && u_pass == password)
                            {
                                return userrole;
                                
                            }
                            else
                            {
                                return wrong;
                            }
                        }
                        else
                        {
                            return wrong;
                        }
                    }
                    else
                    {
                        if (u_id == userid && u_pass == password )
                        {
                            return userrole;
                            
                           
                        }
                        else
                        {
                            return wrong;
                        }
                    }

                   
                }
                catch (Exception ex)
                {
                    string a = ex.Message;

                    return a;

                    
                }
                finally
                {
                    ConnectionManager.con.Close();
                }

            }

            public login()
            {
                //
                // TODO: Add constructor logic here
                //
            }
        }
    }

    
