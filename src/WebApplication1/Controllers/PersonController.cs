using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Person Get(int id)
        { 
            return new Person()
            {
                Name = "Test",
                Age = "12"
            };
        }

        // POST api/values
        [HttpPost]
        public Person Post([FromBody] Person person)
        {
            return person;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public Person Put(int id, [FromBody]Person person)
        {
            person.Name = "Updated Name";
            return person;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

/*
Below is a valid json to call this

/*    jQuery.ajax({
            type: "PUT",
            headers: {"Accept" : "#1#*", "Content-Type":"application/json"},
            dataType: "json",
            url: 'http://localhost:5412/api/person/1',
            data: JSON.stringify({Name : "Amila", Age : "12"})
            })*/

*/