using Application.Dtos;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IWebinarService
    {
        public Task<WebinarDto> Create(WebinarDto webinar);
        public Task<WebinarDto> Update(WebinarDto webinar);
        public Task<bool> Delete(Guid id);
        public Task<WebinarDto> GetById(Guid id);
        public Task<List<WebinarDto>> List(WebinarDto webinar);

    }
}
