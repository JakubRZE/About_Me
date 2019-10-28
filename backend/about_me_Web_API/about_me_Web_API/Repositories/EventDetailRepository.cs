using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using about_me_Web_API.DAL;
using about_me_Web_API.IRepositories;
using about_me_Web_API.Models;
using Microsoft.EntityFrameworkCore;

namespace about_me_Web_API.Repositories
{
    public class EventDetailRepository : IEventDetailRepository
    {
        private readonly AppDbContext _appDbContext;

        public EventDetailRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public async Task<IList<EventDetailsModel>> GetAllEvents(int categoryId)
        {
            var result = await _appDbContext.EventDetails.Where(e => e.CategoryId == categoryId).OrderByDescending(e => e.Date).Select(e => new EventDetailsModel
            {
                Id = e.Id,
                Title = e.Title,
                Description = e.Description,
                Place = e.Place,
                Date = e.Date.ToString("yyyy-MM"),
                AvatarUrl = e.Avatar.ToString(),
                CategoryId = e.CategoryId
            }).ToListAsync();

            return result;
        }

        public async Task<EventDetailsModel> AddEvent(EventDetailsModel eventDetails)
        {
            throw new NotImplementedException();
        }
    }
}
