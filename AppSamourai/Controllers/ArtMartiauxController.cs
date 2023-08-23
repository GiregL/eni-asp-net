using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AppSamourai.Data;
using BO.Model;

namespace TpEni.Controllers
{
    public class ArtMartiauxController : Controller
    {
        private readonly SamouraiDbContext _context;

        public ArtMartiauxController(SamouraiDbContext context)
        {
            _context = context;
        }

        // GET: ArtMartiaux
        public async Task<IActionResult> Index()
        {
              return _context.ArtMartials != null ? 
                          View(await _context.ArtMartials.ToListAsync()) :
                          Problem("Entity set 'SamouraiDbContext.ArtMartiaux'  is null.");
        }

        // GET: ArtMartiaux/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ArtMartials == null)
            {
                return NotFound();
            }

            var artMartial = await _context.ArtMartials
                .FirstOrDefaultAsync(m => m.Id == id);
            if (artMartial == null)
            {
                return NotFound();
            }

            return View(artMartial);
        }

        // GET: ArtMartiaux/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ArtMartiaux/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nom")] ArtMartial artMartial)
        {
            if (ModelState.IsValid)
            {
                _context.Add(artMartial);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(artMartial);
        }

        // GET: ArtMartiaux/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ArtMartials == null)
            {
                return NotFound();
            }

            var artMartial = await _context.ArtMartials.FindAsync(id);
            if (artMartial == null)
            {
                return NotFound();
            }
            return View(artMartial);
        }

        // POST: ArtMartiaux/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nom")] ArtMartial artMartial)
        {
            if (id != artMartial.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(artMartial);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArtMartialExists(artMartial.Id))
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
            return View(artMartial);
        }

        // GET: ArtMartiaux/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ArtMartials == null)
            {
                return NotFound();
            }

            var artMartial = await _context.ArtMartials
                .FirstOrDefaultAsync(m => m.Id == id);
            if (artMartial == null)
            {
                return NotFound();
            }

            return View(artMartial);
        }

        // POST: ArtMartiaux/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ArtMartials == null)
            {
                return Problem("Entity set 'SamouraiDbContext.ArtMartiaux'  is null.");
            }
            var artMartial = await _context.ArtMartials.FindAsync(id);
            if (artMartial != null)
            {
                _context.ArtMartials.Remove(artMartial);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArtMartialExists(int id)
        {
          return (_context.ArtMartials?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
