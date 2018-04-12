using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_DAL.DataBaseHelper
{
    public class DBHelper
    {
        public static void AddCmdParameter(IDbCommand dbCmd, string name, object value)
        {
            ((SqlCommand)dbCmd).Parameters.AddWithValue(name, value);
        }
        public static IDbCommand GetCommandProc(string procName)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn =null;
            try
            {
                conn = new SqlConnection(DataWrapper.GetConnection().ConnectionString);
                cmd.CommandText = procName;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                conn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return cmd;
        }
    }
}
