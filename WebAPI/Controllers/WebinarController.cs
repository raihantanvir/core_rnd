using Application.CQRS.Webinar.Commands;
using Application.Dtos;
using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebinarController : ApiBaseController
    {
        private IWebinarService? _webinarService;
        public WebinarController(IWebinarService webinarService)
        {
            _webinarService = webinarService;
        }

        // GET: api/<WebinarController>/?name=xxx
        [HttpGet]
        public async Task<IEnumerable<WebinarDto>> Get([FromQuery] string name)
        {
            var webinar = new WebinarDto { Name = name };
            return await _webinarService!.List(webinar);
        }

        // GET api/<WebinarController>/5
        [HttpGet("{id}")]
        public async Task<WebinarDto> Get(Guid id)
        {
            return await _webinarService!.GetById(id);
        }

        // POST api/<WebinarController>
        [HttpPost]
        public async Task Post([FromBody] WebinarDto webinar)
        {
            await _webinarService!.Create(webinar);
        }

        // PUT api/<WebinarController>
        [HttpPut]
        public async Task Put([FromBody] WebinarDto webinar)
        {
            await _webinarService!.Update(webinar);
        }

        // DELETE api/<WebinarController>/5
        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _webinarService!.Delete(id);
        }
    }
}
