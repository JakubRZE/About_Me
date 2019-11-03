using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using about_me_Web_API.Models;

namespace about_me_Web_API.IRepositories
{
    public interface IEventDetailRepository
    {
        Task<IList<EventDetailsModel>> GetAllEvents(int categoryId);

        //Task<EventDetailsModel> AddEvent(EventDetailsModel eventDetails);
    }
}
