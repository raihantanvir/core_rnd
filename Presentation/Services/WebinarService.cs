using Application.CQRS.Webinar.Commands;
using Application.CQRS.Webinar.Queries;
using Application.Dtos;
using Application.Interfaces;
using Domain.Entities;
using MediatR;

namespace Presentation.Services
{
    public class WebinarService : IWebinarService
    {
        IMediator? _mediator = null;
        public WebinarService(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<WebinarDto> Create(WebinarDto webinar)
        {
            var command = new CreateWebinarCommand
            {
                Name = webinar.Name,
                ScheduledOn = webinar.ScheduledOn
            };
            webinar = await _mediator!.Send(command);
            return webinar;
        }

        public async Task<WebinarDto> Update(WebinarDto webinar)
        {
            var command = new UpdateWebinarCommand
            {
                Id = webinar.Id,
                Name = webinar.Name,
                ScheduledOn = webinar.ScheduledOn,
                IsActive = webinar.IsActive
            };
            webinar = await _mediator!.Send(command);
            return webinar;
        }

        public async Task<bool> Delete(Guid id)
        {
            var command = new DeleteWeninarCommand
            {
                Id = id
            };
            bool result = await _mediator!.Send(command);
            return result;

        }

        public async Task<WebinarDto> GetById(Guid id)
        {
            var query = new GetWebinarByIdQuery
            {
                Id = id
            };
            return await _mediator!.Send(query);
        }

        public async Task<List<WebinarDto>> List(WebinarDto webinar)
        {
            var query = new ListWebinarQuery
            {
                Name = webinar.Name,
            };
            return await _mediator!.Send(query);
        }
    }
}
