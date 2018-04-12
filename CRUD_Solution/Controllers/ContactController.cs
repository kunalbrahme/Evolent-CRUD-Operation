using CRUD_Api.Models;
using CRUD_ClassLibrary.ClassLibrary;
using CRUD_ClassLibrary.ExceptionLogger;
using CRUD_DAL.DataLayer;
using CRUD_Solution.CommonHelper;
using CRUD_Solution.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CRUD_Solution.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public ActionResult Add()
        {
            try
            {
                BindDropDown();
                return View();
            }
            catch (Exception ex)
            {
                Logger.ExpectionLogger(ex, "Add Get");
                return RedirectToAction("Error", "Error");
            }
        }
        [HttpPost]
        public async Task<ActionResult> Add(ContactModel contactModelObj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ContactRequest contactRequestObj = new ContactRequest
                    {
                        FirstName = contactModelObj.FirstName,
                        LastName = contactModelObj.LastName,
                        Email = contactModelObj.Email,
                        PhoneNumber = contactModelObj.PhoneNumber,
                        Status = contactModelObj.Status,
                        ID = 1
                    };
                    await HelperClass.PushContactDetails(contactRequestObj);
                }
                else
                {
                    return RedirectToAction("Error", "Error");
                }
                return RedirectToAction("GetContacts");
            }
            catch (Exception ex)
            {
                Logger.ExpectionLogger(ex, "Add Post");
                return RedirectToAction("Error", "Error");
            }
        }
        [HttpGet]
        public async Task<ActionResult> GetContacts()
        {
            try
            {
                IList<ContactResponse> contactResponseListObj = null;
                contactResponseListObj = await HelperClass.GetContactDetails();
                return View(contactResponseListObj);
            }
            catch (Exception ex)
            {
                Logger.ExpectionLogger(ex, "GetContacts");
                return RedirectToAction("Error", "Error");
            }
        }
        [HttpGet]
        public async Task<ActionResult> EditContact(int ID)
        {
            try
            {
                BindDropDown();
                List<ContactResponse> contactResponseListObj = new List<ContactResponse>();
                contactResponseListObj = await HelperClass.GetOneContactDetails(ID);
                ContactModel contactModelObj = new ContactModel
                {
                    FirstName = contactResponseListObj[0].FirstName,
                    LastName = contactResponseListObj[0].LastName,
                    Email = contactResponseListObj[0].Email,
                    PhoneNumber = contactResponseListObj[0].PhoneNumber,
                    Status = contactResponseListObj[0].Status,
                    ID = int.Parse(contactResponseListObj[0].ID)
                };
                return View("UpdateContact", contactModelObj);
            }
            catch (Exception ex)
            {
                Logger.ExpectionLogger(ex, "EditContact Get");
                return RedirectToAction("Error", "Error");
            }
        }
        [HttpPost]
        public async Task<ActionResult> EditContact(ContactModel contactModelObj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ContactRequest contactRequestObj = new ContactRequest
                    {
                        ID = contactModelObj.ID,
                        FirstName = contactModelObj.FirstName,
                        LastName = contactModelObj.LastName,
                        Email = contactModelObj.Email,
                        PhoneNumber = contactModelObj.PhoneNumber,
                        Status = contactModelObj.Status
                    };
                    await HelperClass.UpdateOneContactDetails(contactRequestObj);
                }
                else
                {
                    return RedirectToAction("Error", "Error");
                }
                return RedirectToAction("GetContacts");
            }
            catch (Exception ex)
            {
                Logger.ExpectionLogger(ex, "EditContact Post");
                return RedirectToAction("Error", "Error");
            }
        }
        [HttpGet]
        public async Task<ActionResult> DeletContacts(int ID)
        {
            try
            {
                await HelperClass.DeleteContact(ID);
                return RedirectToAction("GetContacts");
            }
            catch (Exception ex)
            {
                Logger.ExpectionLogger(ex, "DeletContacts");
                return RedirectToAction("Error", "Error");
            }
        }
        [NonAction]
        public void BindDropDown()
        {
            try
            {
                List<StatusResponse> statusResponseListObj = new List<StatusResponse>();
                statusResponseListObj = Status_DAL.GetStatus();
                ViewBag.StatusList = new SelectList(statusResponseListObj, "ID", "STATUS");
            }
            catch (Exception ex)
            {
                Logger.ExpectionLogger(ex, "DeletContacts");
            }
        }
    }
}