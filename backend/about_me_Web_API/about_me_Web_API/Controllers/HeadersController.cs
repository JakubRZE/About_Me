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
    public class HeadersController : ControllerBase
    {
        private readonly IHeaderRepository _headerRepository;

        public HeadersController(IHeaderRepository headerRepository)
        {
            _headerRepository = headerRepository;
        }

        //// GET: api/Headers
        [HttpGet]
        public async Task<ActionResult<HeaderModel>> GetHeaders()
        {
            try
            {
                const int headerId = 1;
                var header = await _headerRepository.GetHeaderByIdAsync(headerId);

                if (header == null)
                {
                    return NotFound();
                }

                return Ok(header);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Database error");
            }
          
        }

        //// GET: api/Headers/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Header>> GetHeader(int id)
        //{
        //    var header = await _headerRepository.Headers.FindAsync(id);

        //    if (header == null)
        //    {
        //        return NotFound();
        //    }

        //    return header;
        //}

        //// PUT: api/Headers/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutHeader(int id, Header header)
        //{
        //    if (id != header.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(header).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!HeaderExists(id))
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

        //// POST: api/Headers
        //[HttpPost]
        //public async Task<ActionResult<Header>> PostHeader(Header header)
        //{
        //    _context.Headers.Add(header);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetHeader", new { id = header.Id }, header);
        //}

        //// DELETE: api/Headers/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Header>> DeleteHeader(int id)
        //{
        //    var header = await _context.Headers.FindAsync(id);
        //    if (header == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Headers.Remove(header);
        //    await _context.SaveChangesAsync();

        //    return header;
        //}

        //private bool HeaderExists(int id)
        //{
        //    return _context.Headers.Any(e => e.Id == id);
        //}
    }
}
