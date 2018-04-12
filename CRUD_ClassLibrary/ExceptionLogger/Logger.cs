using System;
using System.Configuration;
using System.IO;

namespace CRUD_ClassLibrary.ExceptionLogger
{
    public class Logger
    {
        public static void ExpectionLogger(Exception ex,string functionName)
        {
            using (StreamWriter writer = new StreamWriter(ConfigurationManager.AppSettings["LoggerPath"].ToString(), true))
            {
                writer.WriteLine("Function Name : "+ functionName +" Message : " + ex.Message + "<br/>" + Environment.NewLine + "StackTrace :" + ex.StackTrace +
                   "" + Environment.NewLine + "Date :" + DateTime.Now.ToString());
                writer.WriteLine(Environment.NewLine + "-----------------------------------------------------------------------------" + Environment.NewLine);
            }
        }
    }
}
