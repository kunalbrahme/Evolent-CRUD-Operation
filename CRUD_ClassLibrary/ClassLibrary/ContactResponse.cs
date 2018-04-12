using CRUD_ClassLibrary.Constants;
using CRUD_ClassLibrary.GlobalResource;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRUD_Api.Models
{
    public class ContactResponse
    {
        public string ID { get; set; }
        [Display(Name = Constant.FIRSTNAME, ResourceType = typeof(StringResource))]
        public string FirstName { get; set; }

        [Display(Name = Constant.LASTNAME, ResourceType = typeof(StringResource))]
        public string LastName { get; set; }

        [Display(Name = Constant.EMAIL, ResourceType = typeof(StringResource))]
        public string Email { get; set; }

        [Display(Name = Constant.PHONENUMBER, ResourceType = typeof(StringResource))]
        public string PhoneNumber { get; set; }
        [Display(Name = Constant.STATUS, ResourceType = typeof(StringResource))]
        public string Status { get; set; }
        public string MessageRsp { get; set; }
    }
}