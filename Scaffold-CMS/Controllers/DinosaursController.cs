using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Scaffold_CMS.Data;
using Scaffold_CMS.Models;

namespace Scaffold_CMS.Controllers
{
    public class DinosaursController : Controller
    {
        private readonly DinoDbContext _context;

        public DinosaursController(DinoDbContext context)
        {
            _context = context;
        }

        // GET: Dinosaurs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Dinosaur.ToListAsync());
        }

        // GET: Dinosaurs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dinosaur = await _context.Dinosaur
                .FirstOrDefaultAsync(m => m.ID == id);
            if (dinosaur == null)
            {
                return NotFound();
            }

            return View(dinosaur);
        }

        // GET: Dinosaurs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dinosaurs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Diet,DinoProfile,PackLimits")] Dinosaur dinosaur)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dinosaur);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dinosaur);
        }

        // GET: Dinosaurs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dinosaur = await _context.Dinosaur.FindAsync(id);
            if (dinosaur == null)
            {
                return NotFound();
            }
            return View(dinosaur);
        }

        // POST: Dinosaurs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Diet,DinoProfile,PackLimits")] Dinosaur dinosaur)
        {
            if (id != dinosaur.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dinosaur);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DinosaurExists(dinosaur.ID))
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
            return View(dinosaur);
        }

        // GET: Dinosaurs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dinosaur = await _context.Dinosaur
                .FirstOrDefaultAsync(m => m.ID == id);
            if (dinosaur == null)
            {
                return NotFound();
            }

            return View(dinosaur);
        }

        // POST: Dinosaurs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dinosaur = await _context.Dinosaur.FindAsync(id);
            _context.Dinosaur.Remove(dinosaur);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DinosaurExists(int id)
        {
            return _context.Dinosaur.Any(e => e.ID == id);
        }
    }
}
