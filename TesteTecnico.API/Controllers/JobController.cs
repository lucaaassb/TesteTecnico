using Microsoft.AspNetCore.Mvc;
using TesteTecnico.Core.Entities;

namespace TesteTecnico.API.Controllers
{
    [Route("api/jobs")] 
    [ApiController]
    
    public class JobSController : ControllerBase
    {
        // GET api/jobs
        [HttpGet]
        public IActionResult Get(string search = "")
        {
            return Ok();
        }
        
        // GET api/jobs/{id}
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            return Ok();
        }
        
        // POST api/jobs
        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }
        
        // PUT api/jobs/{id}
        [HttpPut]
        public IActionResult Put()
        {
            return Ok();
        }
        
        // DELETE api/jobs/{id}
        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }
    }
}
