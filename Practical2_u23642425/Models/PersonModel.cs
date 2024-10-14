using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practical2_u23642425.Models
{
    public class PersonModel
    { 
        public int StudentNumber { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }
        public string MyLink { get; set; }
      
    }
}