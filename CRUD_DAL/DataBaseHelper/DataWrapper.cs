using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_DAL.DataBaseHelper
{
    public class DataWrapper
    {
        protected static IDbConnection dbcConnection = null;
        public static IDbConnection GetConnection()
        {
            try
            {
                dbcConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnnectionString"].ConnectionString);
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dbcConnection;
        }
    }
}
