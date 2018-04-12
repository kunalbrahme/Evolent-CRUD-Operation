using CRUD_Api.ImplementationFactory;
using System;
using System.Collections.Generic;
using CRUD_Api.Models;
using CRUD_DAL.DataLayer;
using CRUD_ClassLibrary.ClassLibrary;

namespace CRUD_Api.Implementation
{
    public class Implementation : IContact
    {
        private ContactResponse contactResponseObj = null;
        private List<ContactResponse> contactResponseListObj = null;

        public ContactResponse AddContactDetails(ContactRequest contactRequestObj)
        {
            return contactResponseObj = Contact_DAL.AddContactDetails(contactRequestObj);
        }

        public List<ContactResponse> GetContactDetails()
        {
            return contactResponseListObj = Contact_DAL.GetContactDetails();
        }

        public List<ContactResponse> GetOneContactDetails(int ID)
        {
            return contactResponseListObj = Contact_DAL.GetOneContactDetails(ID);
        }

        public ContactResponse UpdateContactDetails(ContactRequest contactRequestObj)
        {
            return contactResponseObj = Contact_DAL.UpdateContactDetails(contactRequestObj);
        }

        public ContactResponse DeleteContactDetails(int ID)
        {
            return Contact_DAL.DeleteContact(ID);
        }
    }
}
