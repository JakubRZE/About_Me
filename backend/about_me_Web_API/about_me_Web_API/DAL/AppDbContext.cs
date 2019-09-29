using about_me_Web_API.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace about_me_Web_API.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<EventDetail> EventDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        //public DbSet<File> Files { get; set; }
        public DbSet<Header> Headers { get; set; }
    }
}
