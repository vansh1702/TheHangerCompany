using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TheHangerCompany.Data;
using TheHangerCompany.Models;

namespace TheHangerCompany.Controllers
{
    public class HangersController : Controller
    {
        private readonly TheHangerCompanyContext _context;

        public HangersController(TheHangerCompanyContext context)
        {
            _context = context;
        }

        // GET: Hangers
        // GET: Movies
        public async Task<IActionResult> Index(string hangerType, string searchString)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Hanger
                                            orderby m.Type
                                            select m.Type;

            var movies = from m in _context.Hanger
                         select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Title.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(hangerType))
            {
                movies = movies.Where(x => x.Type == hangerType);
            }

            var movieGenreVM = new HangerTypeViewModel
            {
                Type = new SelectList(await genreQuery.Distinct().ToListAsync()),
                Hangers = await movies.ToListAsync()
            };

            return View(movieGenreVM);
        }

        // GET: Hangers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hanger = await _context.Hanger
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hanger == null)
            {
                return NotFound();
            }

            return View(hanger);
        }

        // GET: Hangers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Hangers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,ReleaseDate,Type,Price,Color,Size,MaxWeightCapacity,Material")] Hanger hanger)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hanger);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hanger);
        }

        // GET: Hangers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hanger = await _context.Hanger.FindAsync(id);
            if (hanger == null)
            {
                return NotFound();
            }
            return View(hanger);
        }

        // POST: Hangers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ReleaseDate,Type,Price,Color,Size,MaxWeightCapacity,Material")] Hanger hanger)
        {
            if (id != hanger.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hanger);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HangerExists(hanger.Id))
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
            return View(hanger);
        }

        // GET: Hangers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hanger = await _context.Hanger
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hanger == null)
            {
                return NotFound();
            }

            return View(hanger);
        }

        // POST: Hangers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hanger = await _context.Hanger.FindAsync(id);
            _context.Hanger.Remove(hanger);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HangerExists(int id)
        {
            return _context.Hanger.Any(e => e.Id == id);
        }
    }
}
