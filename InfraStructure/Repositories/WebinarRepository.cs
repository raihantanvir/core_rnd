using Application.Interfaces;
using Domain.Entities;
using InfraStructure.DBContext;
using Microsoft.EntityFrameworkCore;

namespace InfraStructure.Repositories
{
    public class WebinarRepository : IWebinarRepository
    {
        private AppDbContext? _context = null;
        public WebinarRepository(AppDbContext context)
        {
            this._context = context;
        }
        public async Task<Webinar> Create(Webinar webinar)
        {
            _context!.Add(webinar);
            await _context.SaveChangesAsync();
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
