using Application.Interfaces;
using Domain.Entities;
using InfraStructure.DBContext;

namespace InfraStructure.Repositories
{
    public class WebinarRepository : IWebinarRepository
    {
        private AppDbContext? _appDbContext = null;
        public WebinarRepository()
        {
            _appDbContext = new DbContextFactory().CreateDbContext(Array.Empty<string>());
        }
        public async Task<Webinar> Create(Webinar webinar)
        {
            _appDbContext.Add<Webinar>(webinar);
            await _appDbContext.SaveChangesAsync();
            return webinar;
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Webinar> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Webinar>> Search(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Webinar> Update(Webinar webinar)
        {
            throw new NotImplementedException();
        }
    }
}
