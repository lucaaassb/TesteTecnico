using Microsoft.AspNetCore.Mvc;
using TesteTecnico.Application.Models;
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
        public IActionResult Post(CreateJobInputModel model)
        {
            return CreatedAtAction(nameof(GetById), new { id = 1 }, model);
        }
        
        // PUT api/jobs/{id}
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, UpdateJobInputModel model)
        {
            return NoContent();
        }
        
        // DELETE api/jobs/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            return NoContent();
        }
    }
}
