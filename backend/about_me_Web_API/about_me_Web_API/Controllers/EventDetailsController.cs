using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using about_me_Web_API.DAL;
using about_me_Web_API.EntityModels;
using about_me_Web_API.IRepositories;
using about_me_Web_API.Models;

namespace about_me_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventDetailsController : ControllerBase
    {
        private readonly IEventDetailRepository _eventDetailRepository;

        public EventDetailsController(IEventDetailRepository eventDetailRepository)
        {
            _eventDetailRepository = eventDetailRepository;
        }

        //// GET: api/EventDetails
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<EventDetail>>> GetEventDetails()
        //{
        //    return await _context.EventDetails.ToListAsync();
        //}

        // GET: api/EventDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IList<EventDetailsModel>>> GetEventDetail(int id)
        {
            try
            {
                var events = await _eventDetailRepository.GetAllEvents(id);

                if (events == null)
                {
                    return NotFound();
                }

                return Ok(events);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database error");
            }
          
        }

        //// PUT: api/EventDetails/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutEventDetail(int id, EventDetail eventDetail)
        //{
        //    if (id != eventDetail.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(eventDetail).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!EventDetailExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/EventDetails
        [HttpPost]
        public async Task<ActionResult<EventDetailsModel>> PostEventDetail(EventDetailsModel eventDetails)
        {
           var eventDetail = await _eventDetailRepository.AddEvent(eventDetails);

           return eventDetail;
           //return CreatedAtAction("GetEventDetail", new { id = eventDetail.Id }, eventDetail);
        }

        //// DELETE: api/EventDetails/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<EventDetail>> DeleteEventDetail(int id)
        //{
        //    var eventDetail = await _context.EventDetails.FindAsync(id);
        //    if (eventDetail == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.EventDetails.Remove(eventDetail);
        //    await _context.SaveChangesAsync();

        //    return eventDetail;
        //}

        //private bool EventDetailExists(int id)
        //{
        //    return _context.EventDetails.Any(e => e.Id == id);
        //}
    }
}
