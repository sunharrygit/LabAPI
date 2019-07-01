using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LabAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LabsController: ControllerBase
    {
        // GET api/Labs
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Hello", "Super JYY" };
        }

        // GET api/Labs/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "It is my controller";
        }

        // GET api/Labs/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(string value)
        {
            string s = value.ToString();
            return "Hello "+s+", welcome to Harry's Lab!";
        }

        // POST api/Labs
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/Labs/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Labs/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}