using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Train10.Controllers
{
    /// <summary>
    /// Controlador de ejemplo
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        // GET: api/Example
        /// <summary>
        /// Test 5
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Example/5
        /// <summary>
        /// Regresa el ejemplo por id
        /// </summary>
        /// <param name="id">Id del ejemplo</param>
        /// <returns>El ejemplo solicitado</returns>
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Example
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Example/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
