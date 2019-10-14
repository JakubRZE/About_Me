using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using about_me_Web_API.ViewModels;

namespace about_me_Web_API.IRepositories
{
    public interface ICategoryRepository
    {
        Task<IList<CategoryVM>> GetAllCategoriesAsync();
    }
}
