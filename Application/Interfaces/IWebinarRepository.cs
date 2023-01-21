using Domain.Entities;

namespace Application.Interfaces
{
    public interface IWebinarRepository
    {
        public Task<Webinar> Create(Webinar webinar);
        public Task<Webinar> Update(Webinar webinar);
        public Task<Webinar> GetById(Guid id);
        public Task<List<Webinar>> Search(Guid id);
        public Task<bool> Delete(Guid id);
    }
}
