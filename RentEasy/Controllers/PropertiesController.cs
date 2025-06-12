using Microsoft.AspNetCore.Mvc;
using RentEasy.Data;
using RentEasy.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RentEasy.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PropertiesApiController : ControllerBase
    {
        private readonly RentEasyDbContext _context;

        public PropertiesApiController(RentEasyDbContext context)
        {
            _context = context;
        }

        // GET: api/propertiesapi
        [HttpGet]
        public async Task<IEnumerable<Property>> GetProperties()
        {
            return await _context.Properties.ToListAsync();
        }

        // GET: api/propertiesapi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Property>> GetProperty(int id)
        {
            var property = await _context.Properties.FindAsync(id);
            if (property == null)
                return NotFound();
            return property;
        }

        // POST: api/propertiesapi
        [HttpPost]
        public async Task<ActionResult<Property>> CreateProperty(Property property)
        {
            _context.Properties.Add(property);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProperty), new { id = property.Id }, property);
        }

        // PUT: api/propertiesapi/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProperty(int id, Property property)
        {
            if (id != property.Id)
                return BadRequest();

            _context.Entry(property).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Properties.Any(e => e.Id == id))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProperty(int id)
        {
            var property = await _context.Properties.FindAsync(id);
            if (property == null)
                return NotFound();

            _context.Properties.Remove(property);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}



