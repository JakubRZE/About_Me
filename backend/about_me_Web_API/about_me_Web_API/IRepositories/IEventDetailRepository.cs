using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using about_me_Web_API.ViewModels;

namespace about_me_Web_API.IRepositories
{
    public interface IEventDetailRepository
    {
        Task<IList<EventDetailsVM>> GetAllEvents(int categoryId);

        Task<EventDetailsVM> AddEvent(EventDetailsVM eventDetails);
    }
}
