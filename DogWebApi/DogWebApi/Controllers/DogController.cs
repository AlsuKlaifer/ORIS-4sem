using DogWebApi.Data;
using DogWebApi.Models;
using DogWebApi.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DogWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogController : ControllerBase
    {
        private readonly IEmailService _emailService;
        
        public DogController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        //post mail
        [HttpPost(Name = "EmailService")]
        public IActionResult SendEmailMessage([FromForm] string email, [FromForm] string comment, [FromForm] string? tel)
        {
            _emailService.SendEmailAsync(email, "TEST", $"{comment} телефон: {tel}");
            return Ok();
        }
        
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

        // DELETE api/<DogController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
