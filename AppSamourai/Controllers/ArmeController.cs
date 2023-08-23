using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BO.Model;
using TpEni.Repositories;

namespace TpEni
{
    public class ArmeController : Controller
    {
        private readonly ArmeRepository _armeRepository;

        public ArmeController(ArmeRepository armeRepository)
        {
            _armeRepository = armeRepository;
        }

        // GET: Arme
        public async Task<IActionResult> Index()
        {
            return View(_armeRepository.GetAll().ToList());
        }

        // GET: Arme/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var arme = _armeRepository.GetAll()
                .FirstOrDefault(m => m.Id == id);
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
                _armeRepository.Add(arme);
                _armeRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(arme);
        }

        // GET: Arme/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var arme = _armeRepository.GetById(id.Value);
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
                    _armeRepository.Update(arme);
                    _armeRepository.Save();
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
            if (id == null)
            {
                return NotFound();
            }

            var arme = _armeRepository
                .GetAll()
                .FirstOrDefault(m => m.Id == id);
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
            var arme = _armeRepository.GetById(id);
            if (arme != null)
            {
                _armeRepository.Delete(arme);
            }
            
            _armeRepository.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool ArmeExists(int id)
        {
          return _armeRepository.GetWhere(e => e.Id == id).Count() != 0;
        }
    }
}
