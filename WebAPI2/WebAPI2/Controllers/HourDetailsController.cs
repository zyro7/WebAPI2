using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI2.Models;

namespace WebAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HourDetailsController : ControllerBase
    {
        private readonly HourContext _context;

        public HourDetailsController(HourContext context)
        {
            _context = context;
        }

        // GET: api/HourDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HourDetail>>> GetHourDetails()
        {
            return await _context.HourDetails.ToListAsync();
        }

        // GET: api/HourDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HourDetail>> GetHourDetail(int id)
        {
            var hourDetail = await _context.HourDetails.FindAsync(id);

            if (hourDetail == null)
            {
                return NotFound();
            }

            return hourDetail;
        }

        // PUT: api/HourDetails/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHourDetail(int id, HourDetail hourDetail)
        {
            if (id != hourDetail.HourId)
            {
                return BadRequest();
            }

            _context.Entry(hourDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HourDetailExists(id))
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

        // POST: api/HourDetails
        [HttpPost]
        public async Task<ActionResult<HourDetail>> PostHourDetail(HourDetail hourDetail)
        {
            _context.HourDetails.Add(hourDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHourDetail", new { id = hourDetail.HourId }, hourDetail);
        }

        // DELETE: api/HourDetails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<HourDetail>> DeleteHourDetail(int id)
        {
            var hourDetail = await _context.HourDetails.FindAsync(id);
            if (hourDetail == null)
            {
                return NotFound();
            }

            _context.HourDetails.Remove(hourDetail);
            await _context.SaveChangesAsync();

            return hourDetail;
        }

        private bool HourDetailExists(int id)
        {
            return _context.HourDetails.Any(e => e.HourId == id);
        }
    }
}
