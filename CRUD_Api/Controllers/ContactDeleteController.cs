using CRUD_Api.CommonHelper;
using CRUD_Api.GetInstance;
using CRUD_Api.ImplementationFactory;
using CRUD_Api.Models;
using System;
using System.Web.Http;

namespace CRUD_Api.Controllers
{
    public class ContactDeleteController : ApiController
    {
        [Route("api/ContactDelete/OneContactDelete/{id}")]
        public ContactResponse OneContactDelete(int ID)
        {
            try
            {
                IContact iAddContactObj = GetImplementationInstace.GetInstanceMode(ApiConstant.REAL);
                return iAddContactObj.DeleteContactDetails(ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
