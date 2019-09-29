using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using about_me_Web_API.DAL;
using about_me_Web_API.IRepositories;

namespace about_me_Web_API.Repositories
{
    public class EventDetailRepository : IEventDetailRepository
    {
        private readonly AppDbContext _appDbContext;

        public EventDetailRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


    }
}
