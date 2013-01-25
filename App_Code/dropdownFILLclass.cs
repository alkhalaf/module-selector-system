using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Reflection;
using System.Collections;
using TrinityTej;
/// <summary>
/// Summary description for dropdownFILLclass
/// </summary>
public class dropdownFILLclass
{
    SqlCommand cmd;
    SqlDataAdapter ad;
    SqlDataReader rd;
    SqlConnection con;
    SqlParameter sqlpmm;
    DataSet ds;
    public  DataSet data_set_role()
    {
        ds = new DataSet();
        try
        {
            con = new SqlConnection();
            con = ConnectionManager.con;
            cmd = new SqlCommand("fetchrole", con);
            cmd.CommandType = CommandType.StoredProcedure;

            ad = new SqlDataAdapter(cmd);
            ad.Fill(ds);         
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

    public DataSet data_set_role_for_admin()
    {
        ds = new DataSet();
        try
        {
            con = new SqlConnection();
            con = ConnectionManager.con;
            cmd = new SqlCommand("fetchroleFORadmin", con);
            cmd.CommandType = CommandType.StoredProcedure;

            ad = new SqlDataAdapter(cmd);
            ad.Fill(ds);
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
    public DataSet data_set_role_for_super()
    {
        ds = new DataSet();
        try
        {
            con = new SqlConnection();
            con = ConnectionManager.con;
            cmd = new SqlCommand("fetchrolesuperadmin", con);
            cmd.CommandType = CommandType.StoredProcedure;

            ad = new SqlDataAdapter(cmd);
            ad.Fill(ds);
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

    public DataSet Role_user_name_fetch()
    {
        ds = new DataSet();
        try
        {
            con = new SqlConnection();
            con = ConnectionManager.con;
            cmd = new SqlCommand("role_userNameforRoleMaster", con);
            cmd.CommandType = CommandType.StoredProcedure;

            ad = new SqlDataAdapter(cmd);
            ad.Fill(ds);
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

    public DataSet date_set_STATE()
    {
        ds = new DataSet();
        try
        {
            con = ConnectionManager.con;
            cmd = new SqlCommand("fetchstate", con);
            cmd.CommandType=CommandType.StoredProcedure;

            ad=new SqlDataAdapter(cmd);
            ad.Fill(ds);
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



	public dropdownFILLclass()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
