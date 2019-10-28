﻿using about_me_Web_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace about_me_Web_API.IRepositories
{
    public interface IHeaderRepository
    {
        Task<HeaderModel> GetHeaderByIdAsync(int id);
    }
}
