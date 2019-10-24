using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace about_me_Web_API.ViewModels
{
    public class EventDetailsVM
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Place { get; set; }

        public DateTime Date { get; set; }

        public string AvatarUrl { get; set; }

        public int CategoryId { get; set; }
    }
}
