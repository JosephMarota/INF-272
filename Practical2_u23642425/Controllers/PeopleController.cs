using Practical2_u23642425.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;


namespace Practical2_u23642425.Controllers
{
    public class PeopleController : Controller
    {

        public static List<PersonModel> people = new List<PersonModel>
        {
            new PersonModel { StudentNumber = 1234567, FirstName = "Jarred", LastName = "Maheebeer", EmailAddress = "Jarred@gmail.com" , MyLink = "~/HTML/Person01.html"},
            new PersonModel { StudentNumber = 1234567, FirstName = "Jean", LastName = "vd Merwe", EmailAddress = "Jean@gmail.com" , MyLink = "~/HTML/Person02.html"},
            new PersonModel { StudentNumber = 1234567, FirstName = "Refilwe", LastName = "vd Merwe", EmailAddress = "Refilwe@gmail.com" , MyLink = "~/HTML/Person03.html"},
            new PersonModel { StudentNumber = 1234567, FirstName = "Tshiamo", LastName = "vd Merwe", EmailAddress = "Tshiamo@gmail.com" , MyLink = "~/HTML/Person04.html"},
            new PersonModel { StudentNumber = 1234567 ,FirstName = "Calvin" , LastName = "M",EmailAddress = "Calvin@gmail.com" , MyLink = "~/HTML/Person05.html"},
        };  // Instatiating - Initializing
        public ActionResult Index()
        {
            var data = people.ToList();
            return View(data);
        }





    }
}