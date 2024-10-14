using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Web.Mvc;
using Practical2_u23642425.Models;

namespace Practical2_u23642425.Controllers
{
    public class PeopleController : Controller
    {
        public static List<PersonModel> friends = new List<PersonModel>
        {

            new PersonModel { StudentNumber = 23642425 ,  FirstName = "JOSEPH" , LastName = "MAROTA" , EmailAddress = "jmarota012@gmail.com" , MyLink = "~/HTML/Joseph.html"},
            new PersonModel { StudentNumber = 23716950,FirstName = "Wandile" , LastName = "Maphanga", EmailAddress = "trevormaphanga13@gmail.com" , MyLink = "~/HTML/Wandile.html"},
            new PersonModel { StudentNumber = 23672057 ,FirstName = "Tshiamo" , LastName = "Faith", EmailAddress = "u23672057@tuks.co.za" , MyLink = "~/HTML/Tshiamo.html"},
            new PersonModel { StudentNumber = 23651394 ,FirstName = "Fairy" , LastName = "Tlou", EmailAddress = "fairytlou04@gmail.com" , MyLink = "~/HTML/Fairy.html"},
            new PersonModel { StudentNumber = 22753436 ,FirstName = "Bokang" , LastName = "Seema",EmailAddress = "Clementseema03@gmail.com" , MyLink = "~/HTML/BeeKay.html"},
        };
        public ActionResult Index()
        {
            var students =  friends.ToList();
            return View(students);
        }

    }
}