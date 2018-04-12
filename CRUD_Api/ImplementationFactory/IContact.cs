using CRUD_Api.Models;
using System.Collections.Generic;

namespace CRUD_Api.ImplementationFactory
{
   public interface IContact
    {
        //Add Contact Details
        ContactResponse AddContactDetails(ContactRequest contactRequestObj);
        //Get All Contact Details
        List<ContactResponse> GetContactDetails();
        //Get One Contact Details
        List<ContactResponse> GetOneContactDetails(int ID);
        //Update Contact Details
        ContactResponse UpdateContactDetails(ContactRequest contactRequestObj);
        ContactResponse DeleteContactDetails(int ID);
    }
}
