using Application.Interfaces;
using Application.Dtos;
using MediatR;

namespace Application.CQRS.Webinar.Queries
{
    public record GetWebinarByIdQuery : IRequest<WebinarDto>
    {
        public Guid Id { get; set; }
    }

    public class GetWebinarByIdQuerydHandler : IRequestHandler<GetWebinarByIdQuery, WebinarDto>
    {
        private readonly IWebinarRepository _repository;
        public GetWebinarByIdQuerydHandler(IWebinarRepository repository)
        {
            _repository = repository;
        }

        public async Task<WebinarDto> Handle(GetWebinarByIdQuery request, CancellationToken cancellationToken)
        {
            Domain.Entities.Webinar? webinar = await _repository.GetById(request.Id);
            var dto = new WebinarDto
            {
                Id = webinar.Id,
                Name = webinar.Name,
                ScheduledOn = webinar.ScheduledOn,
                IsActive = webinar.IsActive
            };
            return dto;
        }
    }
}
