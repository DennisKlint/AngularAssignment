using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AngularAssignment.Models;

namespace AngularAssignment.API
{
    public class PeopleController : ApiController
    {
        AngularAssignmentDbManager _ctx = null;

        public PeopleController()
        {
            _ctx = new AngularAssignmentDbManager();
        }
        public List<Person> GetPeople()
        {
            List<Person> people = null;
            try
            {
                people = _ctx.People.ToList();
            }
            catch
            {
                people = null;
            }
            return people;
        }
    }
}
