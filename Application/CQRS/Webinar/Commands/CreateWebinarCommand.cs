using Application.Interfaces;
using Application.Dtos;
using MediatR;


namespace Application.CQRS.Webinar.Commands
{
    public record CreateWebinarCommand : IRequest<WebinarDto>
    {
        public string? Name { get; set; }
        public DateTime ScheduledOn { get; set; }
    }

    public class CreateWebinarCommandHandler : IRequestHandler<CreateWebinarCommand, WebinarDto>
    {
        private readonly IWebinarRepository _repository;
        public CreateWebinarCommandHandler(IWebinarRepository repository)
        {
            this._repository = repository;
        }
        public async Task<WebinarDto> Handle(CreateWebinarCommand request, CancellationToken cancellationToken)
        {
            var entity = new Domain.Entities.Webinar
            {
                Name = request.Name,
                ScheduledOn = request.ScheduledOn
            };

            entity = await _repository.Create(entity);

            return new WebinarDto();
        }
    }
}
