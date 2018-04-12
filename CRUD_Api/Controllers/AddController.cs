using CRUD_Api.CommonHelper;
using CRUD_Api.GetInstance;
using CRUD_Api.ImplementationFactory;
using CRUD_Api.Models;
using System.Web.Http;

namespace CRUD_Api.Controllers
{
    public class AddController : ApiController
    {
        public ContactResponse AddContactInformation(ContactRequest contactRequestObj)
        {
            IContact iAddContactObj = GetImplementationInstace.GetInstanceMode(ApiConstant.REAL);
            return iAddContactObj.AddContactDetails(contactRequestObj);
        }
    }
}
