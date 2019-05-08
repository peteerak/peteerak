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
    public class DeliveryReturnController : Controller
    {
        private readonly KaferDbContext _context;

        public DeliveryReturnController(KaferDbContext context)
        {
            _context = context;
        }

        // GET: DeliveryReturn
        public async Task<IActionResult> Index()
        {
            var kaferDbContext = _context.DeliveryReturn.Include(d => d.product).Include(d => d.shoppingmall);
            return View(await kaferDbContext.ToListAsync());
        }
        public async Task<IActionResult> DeliveryIndex()
        {
            var kaferDbContext = _context.DeliveryReturn.Include(d => d.product).Include(d => d.shoppingmall);
            return View("~/Views/Delivery/index.cshtml", await kaferDbContext.ToListAsync());
        }

        public async Task<IActionResult> ReturnIndex()
        {
            var kaferDbContext = _context.DeliveryReturn.Include(d => d.product).Include(d => d.shoppingmall);
            return View("~/Views/Return/index.cshtml", await kaferDbContext.ToListAsync());
        }
       

        // GET: DeliveryReturn/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deliveryReturn = await _context.DeliveryReturn
                .Include(d => d.product.name)
                .Include(d => d.shoppingmall)
                .FirstOrDefaultAsync(m => m.id == id);
            if (deliveryReturn == null)
            {
                return NotFound();
            }

            return View(deliveryReturn);
        }

        // GET: DeliveryReturn/Create
        public IActionResult Create()
        {
            ViewData["productName"] = new SelectList(_context.Product, "id", "name");
            ViewData["shoppingmallName"] = new SelectList(_context.ShoppingMall, "id", "name");
            return View();
        }

        // POST: DeliveryReturn/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,date,qty,status,lotdate,productID,shoppingmallID")] DeliveryReturn deliveryReturn)
        {
            if (ModelState.IsValid)
            {
                _context.Add(deliveryReturn);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["productID"] = new SelectList(_context.Product, "id", "productID", deliveryReturn.productID);
            ViewData["shoppingmallID"] = new SelectList(_context.ShoppingMall, "id", "shoppingmallID", deliveryReturn.shoppingmallID);
            return View(deliveryReturn);
        }

        // GET: DeliveryReturn/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deliveryReturn = await _context.DeliveryReturn.FindAsync(id);
            if (deliveryReturn == null)
            {
                return NotFound();
            }
            ViewData["productName"] = new SelectList(_context.Product, "id", "name", deliveryReturn.productID);
            ViewData["shoppingmallName"] = new SelectList(_context.ShoppingMall, "id", "name", deliveryReturn.shoppingmallID);
            return View(deliveryReturn);
        }

        // POST: DeliveryReturn/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,date,qty,status,lotdate,productID,shoppingmallID")] DeliveryReturn deliveryReturn)
        {
            if (id != deliveryReturn.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(deliveryReturn);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeliveryReturnExists(deliveryReturn.id))
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
            ViewData["productID"] = new SelectList(_context.Product, "id", "id", deliveryReturn.productID);
            ViewData["shoppingmallID"] = new SelectList(_context.ShoppingMall, "id", "id", deliveryReturn.shoppingmallID);
            return View(deliveryReturn);
        }

        // GET: DeliveryReturn/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deliveryReturn = await _context.DeliveryReturn
                .Include(d => d.product)
                .Include(d => d.shoppingmall)
                .FirstOrDefaultAsync(m => m.id == id);
            if (deliveryReturn == null)
            {
                return NotFound();
            }

            return View(deliveryReturn);
        }

        // POST: DeliveryReturn/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var deliveryReturn = await _context.DeliveryReturn.FindAsync(id);
            _context.DeliveryReturn.Remove(deliveryReturn);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeliveryReturnExists(int id)
        {
            return _context.DeliveryReturn.Any(e => e.id == id);
        }
    }
}
