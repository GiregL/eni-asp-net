using System.Collections;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppSamourai.Data;
using BO.Model;
using TpEni.Models;
using X.PagedList;
using TpEni.Repositories;

namespace TpEni.Controllers
{
    public class SamouraiController : Controller
    {
        private readonly SamouraiDbContext _context;
        private readonly SamouraiRepository _samouraiRepository;
        private readonly ArtMartialRepository _artMartialRepository;

        private const int TAILLE_PAGE = 7;

        public SamouraiController(
            SamouraiDbContext context,
            SamouraiRepository samouraiRepository,
            ArtMartialRepository artMartialRepository)
        {
            _context = context;
            _samouraiRepository = samouraiRepository;
            _artMartialRepository = artMartialRepository;
        }

        /// <summary>
        /// Affichage des samourais et filtres de recherche.
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index(string? sortOrder, string? currentFilter, string? searchString, int? page)
        {
            if (page == null || page < 1) page = 1;
            if (searchString == null) searchString = "";
            if (sortOrder == null) sortOrder = "";
            if (currentFilter == null) currentFilter = "";
            
            
            ViewBag.SortOrder = String.IsNullOrEmpty(sortOrder) ? "asc" : sortOrder;
            ViewBag.SortFilter = String.IsNullOrEmpty(currentFilter) ? "" : currentFilter;
            ViewBag.NameSearch = String.IsNullOrEmpty(searchString) ? "" : searchString;

            var query = _samouraiRepository.GetAll()
                .Where(samourai => samourai.Nom.ToLower().StartsWith(searchString.ToLower()));

            if (currentFilter == "nom")
            {
                if (sortOrder == "asc") query = query.OrderBy(samourai => samourai.Nom);
                else query = query.OrderByDescending(samourai => samourai.Nom);
            } else if (currentFilter == "force")
            {
                if (sortOrder == "asc") query = query.OrderBy(samourai => samourai.Force);
                else query = query.OrderByDescending(samourai => samourai.Force);
            }
            
            return View(query.ToPagedList(page.Value, TAILLE_PAGE));
        }

        // GET: Samourai/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Samourais == null)
            {
                return NotFound();
            }

            var samourai = await _context.Samourais
                .Include(samourai => samourai.Arme)
                .Include(samourai => samourai.Techniques)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (samourai == null)
            {
                return NotFound();
            }

            return View(samourai);
        }

        // GET: Samourai/Create
        public IActionResult Create()
        {
            List<SelectListItem> armes = _context.Armes
                .Where(arme => arme.IdUtilisateur == null)
                .Select(arme => new SelectListItem()
                {
                    Text = arme.Nom,
                    Value = "" + arme.Id,
                    Selected = false
                })
                .ToList();
            armes.Insert(0, new SelectListItem()
            {
                Text = "-- Sélectionnez une valeur --",
                Value = ""
            });
            ViewBag.ArmesDisponibles = armes;

            List<SelectListItem> artsMartiaux = _artMartialRepository.GetAll()
                .Select(am => new SelectListItem()
                {
                    Text = am.Nom,
                    Value = "" + am.Id,
                    Selected = false
                })
                .ToList();
            artsMartiaux.Insert(0, new SelectListItem()
            {
                Text = "-- Sélectionnez une valeur --",
                Value = ""
            });

            ViewBag.ArtsMartiaux = artsMartiaux;
            
            return View();
        }

        // POST: Samourai/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nom,Force,IdArme, IdsArtsMartiauxChoisis")] CreateSamouraiModelView samourai)
        {
            if (ModelState.IsValid)
            {

                IEnumerable<ArtMartial> artsMartiaux =_artMartialRepository
                    .GetAll()
                    .Where(am => samourai.IdsArtsMartiauxChoisis.Contains(am.Id));

                Samourai result = new Samourai()
                {
                    Id = samourai.Id,
                    Force = samourai.Force,
                    Nom = samourai.Nom,
                    IdArme = samourai.IdArme,
                };
                
                if (samourai.IdArme != null)
                {
                    Arme? arme = await _context.Armes.SingleOrDefaultAsync(arme => arme.Id == samourai.IdArme);
                    if (arme == null)
                    {
                        return NotFound();
                    }
                    result.Arme = arme;
                }

                _samouraiRepository.Add(result);
                _artMartialRepository.AddManyToSamourai(result, artsMartiaux);
                
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(samourai);
        }

        // GET: Samourai/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Samourais == null)
            {
                return NotFound();
            }

            Samourai? samourai = await _context.Samourais
                .Include(samourai => samourai.Arme)
                .SingleOrDefaultAsync(samourai => samourai.Id == id);
            if (samourai == null)
            {
                return NotFound();
            }

            List<SelectListItem> armesDispo = await _context.Armes
                .Where(arme => arme.IdUtilisateur == null || arme.IdUtilisateur == id)
                .Select(arme => new SelectListItem()
                {
                    Text = arme.Nom,
                    Value = "" + arme.Id,
                    Selected = arme.IdUtilisateur == id
                })
                .ToListAsync();

            armesDispo.Insert(0, new SelectListItem()
            {
                Text = "-- Sélectionnez une valeur --",
                Value = ""
            });
            
            ViewBag.ArmesDisponibles = armesDispo;
                
            return View(samourai);
        }

        // POST: Samourai/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nom,Force,IdArme")] Samourai samourai)
        {
            if (id != samourai.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (samourai.IdArme != null)
                    {
                        Arme? arme = await _context.Armes.SingleOrDefaultAsync(arme => samourai.IdArme == arme.Id);
                        if (arme == null)
                        {
                            return NotFound();
                        }
                        samourai.Arme = arme;
                    }
                    
                    _context.Update(samourai);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SamouraiExists(samourai.Id))
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
            return View(samourai);
        }

        // GET: Samourai/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Samourais == null)
            {
                return NotFound();
            }

            var samourai = await _context.Samourais
                .Include(samourai => samourai.Arme)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (samourai == null)
            {
                return NotFound();
            }

            return View(samourai);
        }

        // POST: Samourai/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Samourais == null)
            {
                return Problem("Entity set 'SamouraiDbContext.Samourai'  is null.");
            }
            var samourai = await _context.Samourais.FindAsync(id);
            if (samourai != null)
            {
                _context.Samourais.Remove(samourai);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SamouraiExists(int id)
        {
          return (_context.Samourais?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
