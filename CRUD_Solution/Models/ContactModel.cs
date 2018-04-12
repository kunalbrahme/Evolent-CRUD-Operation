using CRUD_ClassLibrary.GlobalResource;
using CRUD_Solution.CommonHelper;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Web.Mvc;

namespace CRUD_Solution.Models
{
    public class ContactModel
    {
        public int ID { get; set; }
        [Required(ErrorMessageResourceName = WebConstant.ERROR_FIRSTNAME, ErrorMessageResourceType = typeof(MessageResource))]
        [Display(Name = WebConstant.FIRSTNAME, ResourceType = typeof(StringResource))]
        public string FirstName { get; set; }
        [Required(ErrorMessageResourceName = WebConstant.ERROR_LASTNAME, ErrorMessageResourceType = typeof(MessageResource))]
        [Display(Name = WebConstant.LASTNAME, ResourceType = typeof(StringResource))]
        public string LastName { get; set; }
        [Required(ErrorMessageResourceName = WebConstant.ERROR_EMAIL, ErrorMessageResourceType = typeof(MessageResource))]
        [RegularExpression(WebConstant.REGEX_EMAIL,ErrorMessage = WebConstant.REGEX_EMAIL_MSG)]
        [Display(Name = WebConstant.EMAIL, ResourceType = typeof(StringResource))]
        public string Email { get; set; }
        [Required(ErrorMessageResourceName = WebConstant.ERROR_PHONENUMBER, ErrorMessageResourceType = typeof(MessageResource))]
        [RegularExpression(WebConstant.REGEX_PHONENUMBER, ErrorMessage =WebConstant.REGEX_PHONENUMBER_MSG)]
        [Display(Name = WebConstant.PHONENUMBER, ResourceType = typeof(StringResource))]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessageResourceName = WebConstant.ERROR_STATUS, ErrorMessageResourceType = typeof(MessageResource))]
        [Display(Name = WebConstant.STATUS, ResourceType = typeof(StringResource))]
        public string Status { get; set; }
    }
}