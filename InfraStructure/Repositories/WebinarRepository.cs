using Application.Exceptions;
using Application.Interfaces;
using Azure.Core;
using Domain.Entities;
using InfraStructure.DBContext;
using Microsoft.EntityFrameworkCore;
using System.Threading;

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

        public async Task<bool> Delete(Guid id)
        {
            var entity = await _context!.Webinars
            .Where(w => w.Id == id)
            .SingleOrDefaultAsync();

            if (entity == null)
            {
                throw new WebinarNotFoundException(id);
            }
            _context.Webinars.Remove(entity);

            await _context.SaveChangesAsync();
            return true;

        }

        public async Task<Webinar> GetById(Guid id)
        {
            var entity = await _context!.Webinars
            .Where(w => w.Id == id)
            .SingleOrDefaultAsync();

            if (entity == null)
            {
                throw new WebinarNotFoundException(id);
            }

            return entity;
        }

        public async Task<List<Webinar>> List(Webinar webinar)
        {
            List<Webinar> result = new List<Webinar>();
            if (webinar.Name != null)
            {
                result = await _context!.Webinars
                .Where(w => w.Name.ToLower().Contains(webinar.Name.ToLower()))
                .ToListAsync<Webinar>();
            }

            return result;
        }

        public async Task<Webinar> Update(Webinar webinar)
        {
            _context!.Update(webinar);
            await _context.SaveChangesAsync();
            return webinar;
        }
    }
}
