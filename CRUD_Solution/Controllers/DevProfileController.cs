using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_Solution.Controllers
{
    public class DevProfileController : Controller
    {
        // GET: DevProfile
        [HttpGet]
        public ActionResult MyProfile()
        {
            return View();
        }
    }
}