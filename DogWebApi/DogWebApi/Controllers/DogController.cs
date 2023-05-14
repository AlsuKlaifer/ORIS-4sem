using DogWebApi.Data;
using DogWebApi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DogWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogController : ControllerBase
    {
        // GET: api/<DogController>
        [HttpGet]
        public IEnumerable<DogInfo> Get()
        {
            var list = DataSeeds.list.Select(i => new DogInfo()
            {
                Id = i.Id,
                Name = i.Name,
                ImgUrl = i.ImgUrl,
                Family = i.Family?.Name ?? "null"
            });
            return list;
        }

        // GET api/<DogController>/5
        [HttpGet("{id}")]
        public Dog Get(Guid id)
        {
            return DataSeeds.list.FirstOrDefault(d => d.Id == id);
        }

        // POST api/<DogController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DogController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DogController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
