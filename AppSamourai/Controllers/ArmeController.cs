using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AppSamourai.Data;
using BO.Model;

namespace TpEni
{
    public class ArmeController : Controller
    {
        private readonly SamouraiDbContext _context;

        public ArmeController(SamouraiDbContext context)
        {
            _context = context;
        }

        // GET: Arme
        public async Task<IActionResult> Index()
        {
              return _context.Armes != null ? 
                          View(await _context.Armes.ToListAsync()) :
                          Problem("Entity set 'SamouraiDbContext.Armes'  is null.");
        }

        // GET: Arme/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Armes == null)
            {
                return NotFound();
            }

            var arme = await _context.Armes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (arme == null)
            {
                return NotFound();
            }

            return View(arme);
        }

        // GET: Arme/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Arme/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nom,Degats")] Arme arme)
        {
            if (ModelState.IsValid)
            {
                _context.Add(arme);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(arme);
        }

        // GET: Arme/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Armes == null)
            {
                return NotFound();
            }

            var arme = await _context.Armes.FindAsync(id);
            if (arme == null)
            {
                return NotFound();
            }
            return View(arme);
        }

        // POST: Arme/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nom,Degats")] Arme arme)
        {
            if (id != arme.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(arme);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArmeExists(arme.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(arme);
        }

        // GET: Arme/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Armes == null)
            {
                return NotFound();
            }

            var arme = await _context.Armes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (arme == null)
            {
                return NotFound();
            }

            return View(arme);
        }

        // POST: Arme/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Armes == null)
            {
                return Problem("Entity set 'SamouraiDbContext.Armes'  is null.");
            }
            var arme = await _context.Armes.FindAsync(id);
            if (arme != null)
            {
                _context.Armes.Remove(arme);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArmeExists(int id)
        {
          return (_context.Armes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
