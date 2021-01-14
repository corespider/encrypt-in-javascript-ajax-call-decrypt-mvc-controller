using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Encrypt_Razor_Decrypt_Controller.Models;
namespace Encrypt_Razor_Decrypt_Controller.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetData(string enc)
        {
            var DecryptVal = Utility.DecryptStringAES(enc);
           
            return Json(DecryptVal, JsonRequestBehavior.AllowGet);
        }
    }
}