using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using kafer_house.Models;
using kafer_house.Data;

namespace kafer_house.Controllers
{
    public class ShoppingMallController : Controller
    {
        private readonly KaferDbContext _context;

        public ShoppingMallController(KaferDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> shoppingMalls(){
            var result = await _context.ShoppingMall.ToListAsync();
            return Json(result);
        }

        

        // GET: ShoppingMall
        public async Task<IActionResult> Index()
        {
            return View(await _context.ShoppingMall.ToListAsync());
        }

        // GET: ShoppingMall/Details/5
         public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shoppingmall = await _context.ShoppingMall
                .Include(s => s.branchs)
                .AsNoTracking()
                .SingleOrDefaultAsync(m => m.id == id);

                
            if (shoppingmall == null)
            {
                return NotFound();
            }

            return View(shoppingmall);
        }

        // GET: ShoppingMall/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ShoppingMall/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,name")] ShoppingMall shoppingMall)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shoppingMall);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shoppingMall);
        }

        // GET: ShoppingMall/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shoppingMall = await _context.ShoppingMall.FindAsync(id);
            if (shoppingMall == null)
            {
                return NotFound();
            }
            return View(shoppingMall);
        }

        // POST: ShoppingMall/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,name")] ShoppingMall shoppingMall)
        {
            if (id != shoppingMall.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shoppingMall);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShoppingMallExists(shoppingMall.id))
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
            return View(shoppingMall);
        }

        // GET: ShoppingMall/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shoppingMall = await _context.ShoppingMall
                .FirstOrDefaultAsync(m => m.id == id);

            if (shoppingMall == null)
            {
                return NotFound();
            }

            return View(shoppingMall);
        }

        // POST: ShoppingMall/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shoppingMall = await _context.ShoppingMall.FindAsync(id);
            _context.ShoppingMall.Remove(shoppingMall);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShoppingMallExists(int id)
        {
            return _context.ShoppingMall.Any(e => e.id == id);
        }
    }
}
