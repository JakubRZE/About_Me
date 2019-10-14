using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using about_me_Web_API.EntityModels;

namespace about_me_Web_API.ViewModels
{
    public class CategoryVM
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string AvatarUrl { get; set; }

        public virtual ICollection<EventDetail> EventDetail { get; set; }
    }
}
