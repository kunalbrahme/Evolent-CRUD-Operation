using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRUD_Api.Controllers;
using CRUD_Api.Models;
using CRUD_Solution.Controllers;
using System.Collections.Generic;

namespace CRUD_API_Test
{
    [TestClass]
    public class UnitTest1
    {
        ContactResponse contactResponseObj = new ContactResponse();
        List<ContactResponse> contactResponsListObj = new List<ContactResponse>();
        AddController addControllerObj = new AddController();
        ContactDeleteController contactDeleteObj = new ContactDeleteController();
        EditController editControllerObj = new EditController();
        GetController getControllerObj = new GetController();
        UpdateController updateControllerObj = new UpdateController();
        [TestMethod]
        //Add contact
        public void AddConatctDetails()
        {
            ContactRequest contactRequestObj = new ContactRequest()
            {
                FirstName = "Ed",
                LastName = "Castle",
                Email = "Ed.Castle@fiserv.com",
                PhoneNumber = "4234567890",
                Status = "1"
            };
            contactResponseObj = new ContactResponse();
            contactResponseObj = addControllerObj.AddContactInformation(contactRequestObj);
            Assert.AreEqual(contactResponseObj.MessageRsp, "OK");
        }
        [TestMethod]
        //Edit contact - get one contact
        public void UpdateConatctDetails()
        {
            contactResponsListObj = new List<ContactResponse>();
            contactResponsListObj = editControllerObj.OneContacts(1053);
            Assert.AreEqual(contactResponsListObj[0].MessageRsp, "OK");
        }
        [TestMethod]
        //Delete contact
        public void DeleteContactDetails()
        {
            contactResponseObj = new ContactResponse();
            contactResponseObj = contactDeleteObj.OneContactDelete(1054);
            Assert.AreEqual(contactResponseObj.MessageRsp, "OK");
        }
        //Get all contact
        [TestMethod]
        //Get All contact
        public void GetAllContactDetails()
        {
            contactResponsListObj = new List<ContactResponse>();
            contactResponsListObj = getControllerObj.GetAllContacts();
            Assert.AreEqual(contactResponsListObj[0].MessageRsp, "OK");
        }
        [TestMethod]
        //Update contact
        public void UpdateContactDetails()
        {
            ContactRequest contactRequestObj = new ContactRequest()
            {
                ID = 1053,
                FirstName = "Edward",
                LastName = "Castle",
                Email = "Ed.Castle@fiserv.com",
                PhoneNumber = "4234567890",
                Status = "1"
            };
            contactResponseObj = new ContactResponse();
            contactResponseObj = updateControllerObj.UpdateOneContactDetails(contactRequestObj);
            Assert.AreEqual(contactResponseObj.MessageRsp, "OK");
        }

    }
}
