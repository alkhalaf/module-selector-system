using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrinityTej;
/// <summary>
/// Summary description for roleMaster
/// </summary>
public class roleMaster
{

    public static bool saveUserRole(string userSNO,string RoleSNO)
    {
        try
        {
            string stringqr = "update MasterLoginUserDetails set MURID=" + RoleSNO + " where LoginId=" + userSNO + "";
           ConnectionManager.NonQuery(stringqr);

           string query2 = "update LoginDetails set MURID="+ RoleSNO +" where SNo="+ userSNO +"";
           ConnectionManager.NonQuery(query2);
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

	public roleMaster()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
