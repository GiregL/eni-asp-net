using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppSamourai.Data;
using BO.Model;
using TpEni.Extensions;
using TpEni.Models;

namespace TpEni.Controllers
{
    public class SamouraiController : Controller
    {
        private readonly SamouraiDbContext _context;

        public SamouraiController(SamouraiDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Affichage des samourais et filtres de recherche.
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index(
            [Bind("NomSamourai", 
                "Page", 
                "NbElemParPage", 
                "SensTriSamourais", 
                "ChampTri",
                "ResetCriteres")] 
            CriteresRechercheSamourai criteresSaisis
            )
        {
            /*
             * Mise à jour des critères en cache
             */
            CriteresRechercheSamourai criteresEnCache;
            
            if (TempData.Get<CriteresRechercheSamourai>("criteres") == null)
            {
                criteresEnCache = new CriteresRechercheSamourai()
                {
                    ResetCriteres = false,
                    Page = 1,
                    NbElemParPage = 7,
                    NomSamourai = null,
                    ChampTri = ChampTriSamourai.NOM,
                    SensTriSamourais = SensTri.DESCENDANT,
                };
                TempData.Put("criteres", criteresEnCache);
            }
            else
            {
                criteresEnCache = TempData.Get<CriteresRechercheSamourai>("criteres")!;
            }
            
            // Recherche en cours par l'utilisateur, mise a jour des critères.
            if (criteresSaisis.Page != null) criteresEnCache.Page = criteresSaisis.Page;
            if (criteresSaisis.NbElemParPage != null) criteresEnCache.NbElemParPage = criteresSaisis.NbElemParPage;
            if (criteresSaisis.NomSamourai != null)
            {
                criteresEnCache.NomSamourai = criteresSaisis.NomSamourai;
                criteresEnCache.Page = 1;
            }
            if (criteresSaisis.ChampTri != null) criteresEnCache.ChampTri = criteresSaisis.ChampTri;
            if (criteresSaisis.SensTriSamourais != null) criteresEnCache.SensTriSamourais = criteresSaisis.SensTriSamourais;
            // Reset des critères
            if (criteresSaisis.ResetCriteres != null && criteresSaisis.ResetCriteres.Value)
            {
                criteresEnCache = new CriteresRechercheSamourai()
                {
                    ResetCriteres = false,
                    Page = 1,
                    NbElemParPage = 7,
                    NomSamourai = null,
                    ChampTri = ChampTriSamourai.NOM,
                    SensTriSamourais = SensTri.DESCENDANT,
                };
            }
            
            // Validation de la pagination
            if (criteresEnCache.Page <= 0) criteresEnCache.Page = 1;
            if (criteresEnCache.NbElemParPage < 1)
                criteresEnCache.NbElemParPage = CriteresRechercheSamourai.NB_ELEM_PAR_PAGE_DEFAUT;
            
            // Sauvegarde du cache
            TempData.Put("criteres", criteresEnCache);
            
            /*
             * Création de la requête de recherche
             */
            IQueryable<Samourai> querySamourais = _context.Samourais.AsQueryable();

            // Recherche par nom.
            if (!string.IsNullOrEmpty(criteresEnCache.NomSamourai))
            {
                querySamourais = querySamourais.Where(samourai =>
                    samourai.Nom.ToLower().StartsWith(criteresEnCache.NomSamourai.ToLower()));
            }

            // Applique l'order by en fonction du sens de tri
            if (criteresEnCache.SensTriSamourais == SensTri.ASCENDANT)
            {
                if (criteresEnCache.ChampTri == ChampTriSamourai.NOM)
                {
                    querySamourais = querySamourais.OrderBy(s => s.Nom);
                }
                else if (criteresEnCache.ChampTri == ChampTriSamourai.FORCE)
                {
                    querySamourais = querySamourais.OrderBy(s => s.Force);
                }
            }
            else if (criteresEnCache.SensTriSamourais == SensTri.DESCENDANT)
            {
                if (criteresEnCache.ChampTri == ChampTriSamourai.NOM)
                {
                    querySamourais = querySamourais.OrderByDescending(s => s.Nom);
                }
                else if (criteresEnCache.ChampTri == ChampTriSamourai.FORCE)
                {
                    querySamourais = querySamourais.OrderByDescending(s => s.Force);
                }
            }
            
            /*
             * Résultat de la recherche et retour utilisateur
             */
            List<Samourai> samourais = await querySamourais
                .Skip(((criteresEnCache.Page ?? 0) - 1) * (criteresEnCache.NbElemParPage ?? 0))
                .Take(7)
                .ToListAsync();
            
            // Pagination
            int nombreResultatsSansPages = await querySamourais.CountAsync();
            ViewBag.NombreResultatsSansPage = nombreResultatsSansPages;
            int nbPages = nombreResultatsSansPages / (criteresEnCache.NbElemParPage ?? 1);

            if (criteresEnCache.Page > nbPages)
                criteresEnCache.Page = nbPages;

            // Résultat rendu
            ResultatRechercheSamouraiModelView resultatRecherche = new ResultatRechercheSamouraiModelView()
            {
                ResetCriteres = false,
                Page = criteresEnCache.Page,
                NbElemParPage = criteresEnCache.NbElemParPage,
                ChampTri = criteresEnCache.ChampTri,
                SensTriSamourais = criteresEnCache.SensTriSamourais,
                NomSamourai = criteresEnCache.NomSamourai,
                ResultatRecherche = samourais
            };
            
            
            return samourais != null ? 
                        View(resultatRecherche) :
                        Problem("Entity set 'SamouraiDbContext.Samourai'  is null.");
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
            
            return View();
        }

        // POST: Samourai/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nom,Force,IdArme")] Samourai samourai)
        {
            if (ModelState.IsValid)
            {
                if (samourai.IdArme != null)
                {
                    Arme? arme = await _context.Armes.SingleOrDefaultAsync(arme => arme.Id == samourai.IdArme);
                    if (arme == null)
                    {
                        return NotFound();
                    }
                    samourai.Arme = arme;
                }
                
                _context.Add(samourai);
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
