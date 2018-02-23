using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularAssignment.Models
{
    public class Person
    {
        public int ID { get; set; }
        public int PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string Picture { get; set; }
    }
}