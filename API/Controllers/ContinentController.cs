using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/continent")]
    [ApiController]
    public class ContinentController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            HashSet<string> continentes = new HashSet<string>();
            continentes.Add("Europa");
            continentes.Add("America");
            continentes.Add("Asia");
            continentes.Add("Africa");
            continentes.Add("Oceania");

            
            //System.Threading.Thread.Sleep(5000);
            return Ok(continentes);


        }

        
        

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
