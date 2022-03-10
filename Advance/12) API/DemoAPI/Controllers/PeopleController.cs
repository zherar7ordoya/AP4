using DemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoAPI.Controllers
{
    /// <summary>
    /// This is where I give you information about my peeps!
    /// </summary>
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();

        /// <summary>
        /// Hey... I'm a constructor.
        /// </summary>
        public PeopleController()
        {
            people.Add(new Person { Firstname = "Tim", Lastname = "Corey", Id = 1 });
            people.Add(new Person { Firstname = "Sue", Lastname = "Storm", Id = 2 });
            people.Add(new Person { Firstname = "Bilbo", Lastname = "Baggins", Id = 3 });
        }

        /// <summary>
        /// Gets a list of the first names of all users.
        /// </summary>
        /// <returns></returns>
        [Route("api/People/GetFirstNames")]
        [HttpGet]
        public List<string> GetFirstNames()
        {
            List<string> output = (from item in people
                                   select item.Firstname).ToList();
            return output;
        }

        // GET: api/People
        /// <summary>
        /// Gets a list of all users.
        /// </summary>
        /// <returns>A list of all users.</returns>
        public List<Person> Get()
        {
            return people;
        }


        // GET: api/People/5
        /// <summary>
        /// Get a person by the Id.
        /// </summary>
        /// <param name="id">The Id of the person.</param>
        /// <returns>The person of the Id.</returns>
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person value)
        {
            people.Add(value);
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
