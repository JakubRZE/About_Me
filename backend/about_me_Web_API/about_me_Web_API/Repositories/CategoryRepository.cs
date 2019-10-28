using about_me_Web_API.DAL;
using about_me_Web_API.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using about_me_Web_API.Models;
using Microsoft.EntityFrameworkCore;

namespace about_me_Web_API.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IList<CategoryModel>> GetAllCategoriesAsync()
        {
            var result = await _appDbContext.Categories.Select(c => new CategoryModel
            {
                Id = c.Id,
                Title = c.Title,
                Description = c.Description,
                AvatarUrl = c.Avatar.ToString()
            }).OrderByDescending(c => c.Title).ToListAsync();

            return result;
        }
    }
}
