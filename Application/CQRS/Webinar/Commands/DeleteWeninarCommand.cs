using Application.Interfaces;
using Application.Dtos;
using MediatR;

namespace Application.CQRS.Webinar.Commands
{
    public record DeleteWeninarCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
    }

    public class DeleteWeninarCommandHandler : IRequestHandler<DeleteWeninarCommand, bool>
    {
        private readonly IWebinarRepository _repository;
        public DeleteWeninarCommandHandler(IWebinarRepository repository)
        {
            _repository = repository;
        }
       
        public async Task<bool> Handle(DeleteWeninarCommand request, CancellationToken cancellationToken)
        {
            return await _repository.Delete(request.Id);
        }
    }
}
