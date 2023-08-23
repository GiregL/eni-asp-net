using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AppSamourai.Data;
using BO.Model;

namespace ArmesWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtMartiauxController : ControllerBase
    {
        private readonly SamouraiDbContext _context;

        public ArtMartiauxController(SamouraiDbContext context)
        {
            _context = context;
        }

        // GET: api/ArtMartiaux
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ArtMartial>>> GetArtMartials()
        {
          if (_context.ArtMartials == null)
          {
              return NotFound();
          }
            return await _context.ArtMartials.ToListAsync();
        }

        // GET: api/ArtMartiaux/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ArtMartial>> GetArtMartial(int id)
        {
          if (_context.ArtMartials == null)
          {
              return NotFound();
          }
            var artMartial = await _context.ArtMartials.FindAsync(id);

            if (artMartial == null)
            {
                return NotFound();
            }

            return artMartial;
        }

        // PUT: api/ArtMartiaux/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArtMartial(int id, ArtMartial artMartial)
        {
            if (id != artMartial.Id)
            {
                return BadRequest();
            }

            _context.Entry(artMartial).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArtMartialExists(id))
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

        // POST: api/ArtMartiaux
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ArtMartial>> PostArtMartial(ArtMartial artMartial)
        {
          if (_context.ArtMartials == null)
          {
              return Problem("Entity set 'SamouraiDbContext.ArtMartials'  is null.");
          }
            _context.ArtMartials.Add(artMartial);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArtMartial", new { id = artMartial.Id }, artMartial);
        }

        // DELETE: api/ArtMartiaux/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArtMartial(int id)
        {
            if (_context.ArtMartials == null)
            {
                return NotFound();
            }
            var artMartial = await _context.ArtMartials.FindAsync(id);
            if (artMartial == null)
            {
                return NotFound();
            }

            _context.ArtMartials.Remove(artMartial);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ArtMartialExists(int id)
        {
            return (_context.ArtMartials?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
