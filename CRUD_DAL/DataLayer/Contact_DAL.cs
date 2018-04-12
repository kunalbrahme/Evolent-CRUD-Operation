using CRUD_Api.Models;
using CRUD_ClassLibrary.ClassLibrary;
using CRUD_ClassLibrary.Constants;
using CRUD_DAL.DataBaseHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_DAL.DataLayer
{
    public class Contact_DAL
    {
        private static ContactResponse contactResponseObj = null;
        //Add Contact Details
        public static ContactResponse AddContactDetails(ContactRequest contactRequestObj)
        {
            IDbCommand cmd = null;
            try
            {
                using (cmd = DBHelper.GetCommandProc(Constant.PROCADDCONTACT))
                {
                    DBHelper.AddCmdParameter(cmd, "@FirstName", contactRequestObj.FirstName);
                    DBHelper.AddCmdParameter(cmd, "@LastName", contactRequestObj.LastName);
                    DBHelper.AddCmdParameter(cmd, "@EmailId", contactRequestObj.Email);
                    DBHelper.AddCmdParameter(cmd, "@PhoneNumber", contactRequestObj.PhoneNumber);
                    DBHelper.AddCmdParameter(cmd, "@Status", contactRequestObj.Status);
                    cmd.ExecuteNonQuery();
                }
                contactResponseObj = new ContactResponse
                {
                    MessageRsp = Constant.MESSAGE
                };
            }
            catch (Exception ex)
            {
                contactResponseObj = new ContactResponse
                {
                    MessageRsp = Constant.MESSAGE
                };
                throw ex;
            }
            return contactResponseObj;
        }
        //Show Contact Details
        public static List<ContactResponse> GetContactDetails()
        {
            IDbCommand cmd = null;
            List<ContactResponse> contactRequestListObj = new List<ContactResponse>();
            try
            {
                using (cmd = DBHelper.GetCommandProc(Constant.PROCSHOWCONTACT))
                {
                    IDataReader reader = cmd.ExecuteReader();
                    ContactResponse contactResponseObj;
                    while (reader.Read())
                    {
                        contactResponseObj = new ContactResponse();
                        contactResponseObj.ID = reader["ID"].ToString();
                        contactResponseObj.FirstName = reader["FIRSTNAME"].ToString();
                        contactResponseObj.LastName = reader["LASTNAME"].ToString();
                        contactResponseObj.Email = reader["EMAIL"].ToString();
                        contactResponseObj.PhoneNumber = reader["PHONENUMBER"].ToString();
                        contactResponseObj.Status = reader["STATUS"].ToString();
                        contactResponseObj.MessageRsp = Constant.MESSAGE;
                        contactRequestListObj.Add(contactResponseObj);
                    }
                }
                return contactRequestListObj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Get One Contact Detail
        public static List<ContactResponse> GetOneContactDetails(int ID)
        {
            IDbCommand cmd = null;
            List<ContactResponse> contactRequestListObj = new List<ContactResponse>();
            try
            {
                using (cmd = DBHelper.GetCommandProc(Constant.PROCGETONECONTACT))
                {

                    DBHelper.AddCmdParameter(cmd, "@ID", ID);
                    IDataReader reader = cmd.ExecuteReader();
                    ContactResponse contactResponseObj;
                    while (reader.Read())
                    {
                        contactResponseObj = new ContactResponse();
                        contactResponseObj.ID = reader["ID"].ToString();
                        contactResponseObj.FirstName = reader["FIRSTNAME"].ToString();
                        contactResponseObj.LastName = reader["LASTNAME"].ToString();
                        contactResponseObj.Email = reader["EMAIL"].ToString();
                        contactResponseObj.PhoneNumber = reader["PHONENUMBER"].ToString();
                        contactResponseObj.Status = reader["STATUS"].ToString();
                        contactResponseObj.MessageRsp = Constant.MESSAGE;
                        contactRequestListObj.Add(contactResponseObj);
                    }
                }
                return contactRequestListObj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Update contact details
        public static ContactResponse UpdateContactDetails(ContactRequest contactRequestObj)
        {
            IDbCommand cmd = null;
            int count = 0;
            try
            {
                using (cmd = DBHelper.GetCommandProc(Constant.PROCUPDATECONTACT))
                {
                    DBHelper.AddCmdParameter(cmd, "@FirstName", contactRequestObj.FirstName);
                    DBHelper.AddCmdParameter(cmd, "@LastName", contactRequestObj.LastName);
                    DBHelper.AddCmdParameter(cmd, "@EmailId", contactRequestObj.Email);
                    DBHelper.AddCmdParameter(cmd, "@PhoneNumber", contactRequestObj.PhoneNumber);
                    DBHelper.AddCmdParameter(cmd, "@Status", contactRequestObj.Status);
                    DBHelper.AddCmdParameter(cmd, "@ID", contactRequestObj.ID);
                    count = cmd.ExecuteNonQuery();
                }
                if (count > 0)
                {
                    contactResponseObj = new ContactResponse
                    {
                        MessageRsp = Constant.MESSAGE
                    };
                }
                else
                {
                    contactResponseObj = new ContactResponse
                    {
                        MessageRsp = Constant.FAILURE
                    };
                }
                return contactResponseObj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static ContactResponse DeleteContact(int ID)
        {
            IDbCommand cmd = null;
            try
            {
                using (cmd = DBHelper.GetCommandProc(Constant.PROCDELETECONTACT))
                {

                    DBHelper.AddCmdParameter(cmd, "@ID", ID);
                    cmd.ExecuteNonQuery();
                    ContactResponse contactResponseObj = new ContactResponse
                    {
                        MessageRsp = Constant.MESSAGE
                    };
                    return contactResponseObj;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
