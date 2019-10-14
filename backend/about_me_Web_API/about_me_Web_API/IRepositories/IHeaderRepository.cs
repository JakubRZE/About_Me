using about_me_Web_API.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace about_me_Web_API.IRepositories
{
    public interface IHeaderRepository
    {
        Task<HeaderVM> GetHeaderByIdAsync(int id);
    }
}
