using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AppSamourai.Data;
using ArmesWebAPI.DTOs.Armes;
using BO.Model;

namespace ArmesWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArmesController : ControllerBase
    {
        private readonly SamouraiDbContext _context;

        public ArmesController(SamouraiDbContext context)
        {
            _context = context;
        }

        // GET: api/Armes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ArmesDTO>>> GetArmes()
        {
            if (_context.Armes == null)
            {
              return NotFound();
            }

            List<Arme> armes = await _context.Armes.ToListAsync();
            return armes.ConvertAll(arme => arme.ConvertToArmesDTO());
        }

        // GET: api/Armes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ArmesDTO>> GetArme(int id)
        {
          if (_context.Armes == null)
          {
              return NotFound();
          }
            var arme = await _context.Armes.FindAsync(id);

            if (arme == null)
            {
                return NotFound();
            }

            return arme.ConvertToArmesDTO();
        }

        // PUT: api/Armes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArme(int id, ArmesDTO arme)
        {
            if (id != arme.Id)
            {
                return BadRequest();
            }

            _context.Entry(arme.FromArmesDTO()).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArmeExists(id))
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

        // POST: api/Armes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ArmesDTO>> PostArme(ArmesDTO arme)
        {
            if (_context.Armes == null)
            {
              return Problem("Entity set 'SamouraiDbContext.Armes'  is null.");
            }
            
            _context.Armes.Add(arme.FromArmesDTO());
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArme", new { id = arme.Id }, arme);
        }

        // DELETE: api/Armes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArme(int id)
        {
            if (_context.Armes == null)
            {
                return NotFound();
            }
            var arme = await _context.Armes.FindAsync(id);
            if (arme == null)
            {
                return NotFound();
            }

            _context.Armes.Remove(arme);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ArmeExists(int id)
        {
            return (_context.Armes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
