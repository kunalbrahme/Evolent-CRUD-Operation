using CRUD_ClassLibrary.ClassLibrary;
using CRUD_ClassLibrary.Constants;
using CRUD_DAL.DataBaseHelper;
using System;
using System.Collections.Generic;
using System.Data;

namespace CRUD_DAL.DataLayer
{
    public class Status_DAL
    {
        public static List<StatusResponse> GetStatus()
        {
            IDbCommand cmd = null;
            List<StatusResponse> statusResponseListObj = new List<StatusResponse>();
            try
            {
                using (cmd = DBHelper.GetCommandProc(Constant.PROCGETSTATUS))
                {
                    IDataReader reader = cmd.ExecuteReader();
                    StatusResponse statusResponseObj;
                    while (reader.Read())
                    {
                        statusResponseObj = new StatusResponse();
                        statusResponseObj.ID = int.Parse(reader["ID"].ToString());
                        statusResponseObj.Status = reader["STATUS"].ToString();
                        statusResponseListObj.Add(statusResponseObj);
                    }
                    statusResponseListObj.Insert(0,new StatusResponse { Status=string.Empty});
                }
                return statusResponseListObj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
