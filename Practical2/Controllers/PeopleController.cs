using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practical2.Models;

namespace Practical2.Controllers
{
    public class PeopleController : Controller
    {
        // Static list of PersonModel objects representing friends
        public static List<PersonModel> friends = new List<PersonModel>();
      

        // Action method to display the list of friends
        public ActionResult Index()
        {
            var data = friends.ToList();
            return View(data);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add (PersonModel person)
        {
            friends.Add(person);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int StudentNumber)
        {
            PersonModel person;
            try
            {
                person = friends.Where(x => x.StudentNumber == StudentNumber).FirstOrDefault();
                friends.Remove(person);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Error", "Error", new { error = ex.Message, controller = "People",action = "Index" });
            }
            return RedirectToAction("Index");
        }

    }
}
