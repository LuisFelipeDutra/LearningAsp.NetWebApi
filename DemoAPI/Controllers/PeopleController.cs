using DemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoAPI.Controllers
{
    public class PeopleController : ApiController
    {
        List<Person> person = new List<Person>();

        public PeopleController()
        {
            person.Add(new Person { Id = 1, FirstName = "Thommas", LastName = "Shelby" });
            person.Add(new Person { Id = 2, FirstName = "Billy", LastName = "Kimba" });
            person.Add(new Person { Id = 3, FirstName = "John", LastName = "Shelby" });
        }
        // GET: api/People
        public List<Person> Get()
        {
            return person;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return person.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/People/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
