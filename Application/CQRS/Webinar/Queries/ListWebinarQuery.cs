using Application.Dtos;
using Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Webinar.Queries
{
    public record ListWebinarQuery : IRequest<List<WebinarDto>>
    {
        public string Name { get; set; }
    }

    public class ListWebinarQueryHandler : IRequestHandler<ListWebinarQuery, List<WebinarDto>>
    {
        private readonly IWebinarRepository _repository;
        public ListWebinarQueryHandler(IWebinarRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<WebinarDto>> Handle(ListWebinarQuery request, CancellationToken cancellationToken)
        {
            List<WebinarDto> result = new List<WebinarDto>();
            var webinaer = new Domain.Entities.Webinar
            {
                Name = request.Name
            };

            List<Domain.Entities.Webinar> webinars = await _repository.List(webinaer);
            foreach (var webinar in webinars)
            {
                result.Add(new WebinarDto
                {
                    Id = webinar.Id,
                    Name = webinar.Name,
                    ScheduledOn = webinar.ScheduledOn,
                    IsActive = webinar.IsActive
                });
            }

            return result;
        }
    }
}
