using CRUD_Api.ImplementationFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CRUD_Api.Models;
using CRUD_ClassLibrary.ClassLibrary;

namespace CRUD_Api.Implementation
{
    public class TestImplementation : IContact
    {
        public ContactResponse AddContactDetails(ContactRequest contactRequestObj)
        {
            throw new NotImplementedException();
        }

        public List<ContactResponse> GetContactDetails()
        {
            throw new NotImplementedException();
        }

        public List<ContactResponse> GetOneContactDetails(int ID)
        {
            throw new NotImplementedException();
        }

        public ContactResponse UpdateContactDetails(ContactRequest contactRequestObj)
        {
            throw new NotImplementedException();
        }
        public ContactResponse DeleteContactDetails(int ID)
        {
            throw new NotImplementedException();
        }
    }
}