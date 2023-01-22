using Application.Dtos;
using Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Webinar.Commands
{
    public record UpdateWebinarCommand : IRequest<WebinarDto>
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public DateTime ScheduledOn { get; set; }
        public bool IsActive { get; set; }
    }

    public class UpdateWebinarCommandHandler : IRequestHandler<UpdateWebinarCommand, WebinarDto>
    {
        private readonly IWebinarRepository _repository;
        public UpdateWebinarCommandHandler(IWebinarRepository repository)
        {
            _repository = repository;
        }
        public async Task<WebinarDto> Handle(UpdateWebinarCommand request, CancellationToken cancellationToken)
        {
            var entity = new Domain.Entities.Webinar
            {
                Id = request.Id,
                Name = request.Name,
                ScheduledOn = request.ScheduledOn,
                IsActive = request.IsActive,
            };

            entity = await _repository.Update(entity);

            return new WebinarDto();
        }
    }
}
