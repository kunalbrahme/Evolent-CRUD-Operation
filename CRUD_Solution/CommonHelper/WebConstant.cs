using CRUD_ClassLibrary.Constants;

namespace CRUD_Solution.CommonHelper
{
    public class WebConstant : Constant
    {
        public const string ERROR_FIRSTNAME = "Error_FirstName";
        public const string ERROR_LASTNAME = "Error_LastName";
        public const string ERROR_EMAIL = "Error_Email";
        public const string REGEX_EMAIL = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        public const string REGEX_EMAIL_MSG = "Email invalid";
        public const string ERROR_PHONENUMBER = "Error_Phone";
        public const string REGEX_PHONENUMBER = @"^\d{10}$";
        public const string REGEX_PHONENUMBER_MSG = "Phone Number invalid";
        public const string ERROR_STATUS = "Error_Status";
        public const string APIINSERT = "api/Add/AddContactInformation";
        public const string APIGETCONTACTS = "api/Get/GetAllContacts";
        public const string APIGETONECONTACT = "api/Edit/OneContacts";
        public const string APIUPDATECONTACTS = "api/Update/UpdateOneContactDetails";
        public const string APIDELETECONTACTS = "api/ContactDelete/OneContactDelete";
    }
}