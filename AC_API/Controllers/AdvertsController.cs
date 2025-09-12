using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AC_Domain.Models;
using AC_Entities;

namespace AC_API.Controllers
{
    public class AdvertsController : Controller
    {
        private readonly ACDbContext _context;

        public AdvertsController(ACDbContext context)
        {
            _context = context;
        }

        // GET: Adverts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Adverts.ToListAsync());
        }

        // GET: Adverts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var advert = await _context.Adverts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (advert == null)
            {
                return NotFound();
            }

            return View(advert);
        }

        // GET: Adverts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Adverts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,Email,PhoneNumber")] Advert advert)
        {
            if (ModelState.IsValid)
            {
                _context.Add(advert);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(advert);
        }

        // GET: Adverts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var advert = await _context.Adverts.FindAsync(id);
            if (advert == null)
            {
                return NotFound();
            }
            return View(advert);
        }

        // POST: Adverts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,Email,PhoneNumber")] Advert advert)
        {
            if (id != advert.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(advert);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdvertExists(advert.Id))
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
            return View(advert);
        }

        // GET: Adverts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var advert = await _context.Adverts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (advert == null)
            {
                return NotFound();
            }

            return View(advert);
        }

        // POST: Adverts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var advert = await _context.Adverts.FindAsync(id);
            if (advert != null)
            {
                _context.Adverts.Remove(advert);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdvertExists(int id)
        {
            return _context.Adverts.Any(e => e.Id == id);
        }
    }
}
