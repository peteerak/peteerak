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
    public class CartActualController : Controller
    {
        private readonly KaferDbContext _context;

        public CartActualController(KaferDbContext context)
        {
            _context = context;
        }

        // GET: CartActual
        public async Task<IActionResult> Index()
        {
            return View(await _context.CartActual.ToListAsync());
        }

        // GET: CartActual/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartActual = await _context.CartActual
                .FirstOrDefaultAsync(m => m.cartId == id);
            if (cartActual == null)
            {
                return NotFound();
            }

            return View(cartActual);
        }

        // GET: CartActual/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CartActual/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> Create([Bind("cartId,createdDate")] CartActual cartActual)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         _context.Add(cartActual);
        //         await _context.SaveChangesAsync();
        //         return RedirectToAction(nameof(Index));
        //     }
        //     return View(cartActual);
        // }

        // GET: CartActual/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartActual = await _context.CartActual.FindAsync(id);
            if (cartActual == null)
            {
                return NotFound();
            }
            return View(cartActual);
        }

        // POST: CartActual/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("cartId,createdDate")] CartActual cartActual)
        {
            if (id != cartActual.cartId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cartActual);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CartActualExists(cartActual.cartId))
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
            return View(cartActual);
        }

        // GET: CartActual/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartActual = await _context.CartActual
                .FirstOrDefaultAsync(m => m.cartId == id);
            if (cartActual == null)
            {
                return NotFound();
            }

            return View(cartActual);
        }

        // POST: CartActual/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cartActual = await _context.CartActual.FindAsync(id);
            _context.CartActual.Remove(cartActual);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CartActualExists(int id)
        {
            return _context.CartActual.Any(e => e.cartId == id);
        }
    }
}
