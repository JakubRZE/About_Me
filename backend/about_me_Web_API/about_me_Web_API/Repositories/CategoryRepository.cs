using about_me_Web_API.DAL;
using about_me_Web_API.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace about_me_Web_API.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void GetAllCategory()
        {
            throw new NotImplementedException();
        }
    }
}
