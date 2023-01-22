using Application.CQRS.Webinar.Commands;
using Application.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebinarController : ApiBaseController
    {
        // GET: api/<WebinarController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<WebinarController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<WebinarController>
        [HttpPost]
        public async Task Post([FromBody] WebinarDto webinar)
        {
            var command = new CreateWebinarCommand
            {
                Name = webinar.Name,
                ScheduledOn = webinar.ScheduledOn
            };
            await Mediator!.Send(command);
        }

        // PUT api/<WebinarController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WebinarController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
