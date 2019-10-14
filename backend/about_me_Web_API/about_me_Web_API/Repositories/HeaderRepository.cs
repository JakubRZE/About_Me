using about_me_Web_API.DAL;
using about_me_Web_API.IRepositories;
using about_me_Web_API.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace about_me_Web_API.Repositories
{
    public class HeaderRepository : IHeaderRepository
    {
        private readonly AppDbContext _appDbContext;

        public HeaderRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public async Task<HeaderVM> GetHeaderByIdAsync(int id)
        {
            var result = await _appDbContext.Headers.Select(h => new HeaderVM
            {
                Name = h.Name,
                Description = h.Description,
                AvatarUrl = h.Avatar.ToString()
            }).SingleAsync();

            return result;
        }
    }
}
