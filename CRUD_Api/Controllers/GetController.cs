using CRUD_Api.CommonHelper;
using CRUD_Api.GetInstance;
using CRUD_Api.ImplementationFactory;
using CRUD_Api.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace CRUD_Api.Controllers
{
    public class GetController : ApiController
    {
        public List<ContactResponse> GetAllContacts()
        {
            try
            {
                IContact iAddContactObj = GetImplementationInstace.GetInstanceMode(ApiConstant.REAL);
                return iAddContactObj.GetContactDetails();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
