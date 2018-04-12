using CRUD_Api.CommonHelper;
using CRUD_Api.GetInstance;
using CRUD_Api.ImplementationFactory;
using CRUD_Api.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Routing;

namespace CRUD_Api.Controllers
{
    public class EditController : ApiController
    {
        [Route("api/Edit/OneContacts/{id}")]
        public List<ContactResponse> OneContacts(int id)
        {
            try
            {
                IContact iAddContactObj = GetImplementationInstace.GetInstanceMode(ApiConstant.REAL);
                return iAddContactObj.GetOneContactDetails(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
