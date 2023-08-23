using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AppSamourai.Data;
using ArmesWebAPI.DTOs.Samourais;
using BO.Model;

namespace ArmesWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SamouraisController : ControllerBase
    {
        private readonly SamouraiDbContext _context;

        public SamouraisController(SamouraiDbContext context)
        {
            _context = context;
        }

        // GET: api/Samourais
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SamouraisDTO>>> GetSamourais()
        {
            if (_context.Samourais == null)
            {
                return NotFound();
            }

            List<Samourai> samourais = await _context.Samourais.ToListAsync();
            return samourais.ConvertAll(s => s.FromSamourai());
        }

        // GET: api/Samourais/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SamouraisDTO>> GetSamourai(int id)
        {
          if (_context.Samourais == null)
          {
              return NotFound();
          }
            var samourai = await _context.Samourais.FindAsync(id);

            if (samourai == null)
            {
                return NotFound();
            }

            return samourai.FromSamourai();
        }

        // PUT: api/Samourais/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSamourai(int id, SamouraisDTO samourai)
        {
            if (id != samourai.Id)
            {
                return BadRequest();
            }

            _context.Entry(samourai.ToSamourai()).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SamouraiExists(id))
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

        // POST: api/Samourais
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SamouraisDTO>> PostSamourai(SamouraisDTO samourai)
        {
          if (_context.Samourais == null)
          {
              return Problem("Entity set 'SamouraiDbContext.Samourais'  is null.");
          }
            _context.Samourais.Add(samourai.ToSamourai());
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSamourai", new { id = samourai.Id }, samourai);
        }

        // DELETE: api/Samourais/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSamourai(int id)
        {
            if (_context.Samourais == null)
            {
                return NotFound();
            }
            var samourai = await _context.Samourais.FindAsync(id);
            if (samourai == null)
            {
                return NotFound();
            }

            _context.Samourais.Remove(samourai);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SamouraiExists(int id)
        {
            return (_context.Samourais?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
