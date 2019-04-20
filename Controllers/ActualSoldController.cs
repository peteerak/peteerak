using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using kafer_house.Models;

namespace kafer_house.Controllers
{
    public class ActualSoldController : Controller
    {
        private readonly KaferDbContext _context;

        public ActualSoldController(KaferDbContext context)
        {
            _context = context;
        }

        // GET: ActualSold
        public async Task<IActionResult> Index()
        {
            var kaferDbContext = _context.ActualSold.Include(a => a.product).Include(a => a.shoppingmall);
            return View(await kaferDbContext.ToListAsync());
        }

        // GET: ActualSold/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actualSold = await _context.ActualSold
                .Include(a => a.product)
                .Include(a => a.shoppingmall)
                .FirstOrDefaultAsync(m => m.id == id);
            if (actualSold == null)
            {
                return NotFound();
            }

            return View(actualSold);
        }

        // GET: ActualSold/Create
        public IActionResult Create()
        {
            ViewData["productName"] = new SelectList(_context.Product, "id", "name");
            ViewData["shoppingmallName"] = new SelectList(_context.ShoppingMall, "id", "name");
            return View();
        }

        // POST: ActualSold/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,date,qty,price,productID,shoppingmallID")] ActualSold actualSold)
        {
            if (ModelState.IsValid)
            {
                _context.Add(actualSold);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["productName"] = new SelectList(_context.Product, "id", "id", actualSold.productID);
            ViewData["shoppingmallName"] = new SelectList(_context.ShoppingMall, "id", "id", actualSold.shoppingmallID);
            return View(actualSold);
        }

        // GET: ActualSold/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actualSold = await _context.ActualSold.FindAsync(id);
            if (actualSold == null)
            {
                return NotFound();
            }
            ViewData["productName"] = new SelectList(_context.Product, "id", "name", actualSold.productID);
            ViewData["shoppingmallName"] = new SelectList(_context.ShoppingMall, "id", "name", actualSold.shoppingmallID);
            return View(actualSold);
        }

        // POST: ActualSold/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,date,qty,price,productID,shoppingmallID")] ActualSold actualSold)
        {
            if (id != actualSold.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(actualSold);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ActualSoldExists(actualSold.id))
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
            ViewData["productName"] = new SelectList(_context.Product, "id", "name", actualSold.productID);
            ViewData["shoppingmallName"] = new SelectList(_context.ShoppingMall, "id", "name", actualSold.shoppingmallID);
            return View(actualSold);
        }

        // GET: ActualSold/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actualSold = await _context.ActualSold
                .Include(a => a.product)
                .Include(a => a.shoppingmall)
                .FirstOrDefaultAsync(m => m.id == id);
            if (actualSold == null)
            {
                return NotFound();
            }

            return View(actualSold);
        }

        // POST: ActualSold/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actualSold = await _context.ActualSold.FindAsync(id);
            _context.ActualSold.Remove(actualSold);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ActualSoldExists(int id)
        {
            return _context.ActualSold.Any(e => e.id == id);
        }
    }
}
