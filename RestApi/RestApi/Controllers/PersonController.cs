using Microsoft.Ajax.Utilities;
using RestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestApi.Controllers
{
    public class PersonController : ApiController
    {
        private ApplicationContext db = new ApplicationContext();

        // GET: api/Person
        public IEnumerable<Person> Get()
        {
            return db.People.ToList();
        }

        // GET: api/Person/5
        public Person Get(int id)
        {
            return db.People.SingleOrDefault(p => p.Id == id);
        }

        // POST: api/Person
        public void Post([FromBody]Person perosn)
        {
            db.People.Add(perosn);
            db.SaveChanges();
        }

        // PUT: api/Person/5
        public void Put(int id, [FromBody]Person person)
        {
            Person p = db.People.SingleOrDefault(x => x.Id == id);
            p.LastName = person.LastName;
            p.FirstName = person.FirstName;
            p.Age = person.Age;
            p.Profession = person.Profession;
            db.SaveChanges();
        }

        // DELETE: api/Person/5
        public void Delete(int id)
        {
            Person p = db.People.SingleOrDefault(x => x.Id == id);
            if (p != null)
            {
                db.People.Remove(p);
                db.SaveChanges();
            }
        }
    }
}
