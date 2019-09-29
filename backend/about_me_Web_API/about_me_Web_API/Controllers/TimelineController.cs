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

namespace about_me_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimelineController : ControllerBase
    {
        private readonly AppDbContext _context;

        private readonly ICategoryRepository _categoryRepository;
        private readonly IEventDetailRepository _eventDetailsRepository;
        private readonly IHeaderRepository _headerRepository;


        public TimelineController(AppDbContext context, ICategoryRepository categoryRepository, IEventDetailRepository eventDetailsRepository, IHeaderRepository headerRepository)
        {
            _context = context;
            _categoryRepository = categoryRepository;
            _eventDetailsRepository = eventDetailsRepository;
            _headerRepository = headerRepository;
        }

        // GET: api/Timeline
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventDetail>>> GetEventDetails()
        {
            return await _context.EventDetails.ToListAsync();
        }

        // GET: api/Timeline/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EventDetail>> GetEventDetail(int id)
        {
            var eventDetail = await _context.EventDetails.FindAsync(id);

            if (eventDetail == null)
            {
                return NotFound();
            }

            return eventDetail;
        }

        // PUT: api/Timeline/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEventDetail(int id, EventDetail eventDetail)
        {
            if (id != eventDetail.Id)
            {
                return BadRequest();
            }

            _context.Entry(eventDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventDetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Timeline
        [HttpPost]
        public async Task<ActionResult<EventDetail>> PostEventDetail(EventDetail eventDetail)
        {
            _context.EventDetails.Add(eventDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEventDetail", new { id = eventDetail.Id }, eventDetail);
        }

        // DELETE: api/Timeline/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EventDetail>> DeleteEventDetail(int id)
        {
            var eventDetail = await _context.EventDetails.FindAsync(id);
            if (eventDetail == null)
            {
                return NotFound();
            }

            _context.EventDetails.Remove(eventDetail);
            await _context.SaveChangesAsync();

            return eventDetail;
        }

        private bool EventDetailExists(int id)
        {
            return _context.EventDetails.Any(e => e.Id == id);
        }
    }
}
