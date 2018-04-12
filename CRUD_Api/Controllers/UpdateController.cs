using CRUD_Api.CommonHelper;
using CRUD_Api.GetInstance;
using CRUD_Api.ImplementationFactory;
using CRUD_Api.Models;
using System;
using System.Web.Http;

namespace CRUD_Api.Controllers
{
    public class UpdateController : ApiController
    {
        public ContactResponse UpdateOneContactDetails(ContactRequest contactRequestObj)
        {
            try
            {
                IContact iAddContactObj = GetImplementationInstace.GetInstanceMode(ApiConstant.REAL);
                return iAddContactObj.UpdateContactDetails(contactRequestObj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
