using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical2.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public static string RedirectController = "";
        public static string RedirectAction = "";
        public ActionResult Error(string error,string controller ,string action)
        {
            ViewBag.Error = error;
            RedirectController = controller;
            RedirectAction = action;    
            return View();
        }
        public ActionResult RedirectTo()
        {
            return RedirectToAction(RedirectAction,RedirectController);
        }

    }
}