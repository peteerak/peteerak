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
    public class DeliveryController : Controller
    {
        private readonly KaferDbContext _context;

        public DeliveryController(KaferDbContext context)
        {
            _context = context;
        }

        // GET: DeliveryReturn
        public async Task<IActionResult> Index()
        {
            var kaferDbContext = _context.DeliveryReturn
                                    .Include(d => d.product)
                                    .Include(d => d.shoppingmall)
                                    .Where(x => x.status == "delivery");
            return View(await kaferDbContext.ToListAsync());
        }

        //  public async Task<IActionResult> Index()
        // {
        //     //aclhemist first
        //     //create a ProductView class to support
        //     //the following data structure
        //     //and then go to view>produt>Index.cshtml
        //     //do some changes
        //     var result = await _context.DeliveryReturn.Include(d => d.product).Include(d => d.shoppingmall)
        //                 .Select(x=> new DeliReturnView{
        //                      id   = x.id,
        //                      date = x.date.ToShortDateString(),
        //                      qty = x.qty,
        //                      status = x.status,
        //                      lotdate = x.lotdate.ToShortDateString(),
        //                      productName = x.product.name,
        //                      shoppingmallName = x.shoppingmall.name,
        //                 }).ToListAsync();
        //     return View(result);
        // }

        // GET: DeliveryReturn/Details/5
        public async Task<IActionResult> Details(int? id)
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

        // public async Task<IActionResult> Edit(int? id)
        // {
        //      if (id == null)
        //     {
        //         return NotFound();
        //     }
        //     // get the one deliveryreturn record that was clicked
        //     var delivery = await _context.DeliveryReturn
        //             .AsNoTracking()
        //             .FirstOrDefaultAsync(m => m.id == id);
        //     if (delivery == null)
        //     {
        //         return NotFound();
        //     }
            
        //     PopulateDropDownList(delivery.productID);
        //     return View(delivery);
        // }
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
            ViewBag.productName = new SelectList(_context.Product, "id", "name", deliveryReturn.productID);
            ViewBag.shoppingmallName = new SelectList(_context.ShoppingMall, "id", "name", deliveryReturn.shoppingmallID);
            
            return View(deliveryReturn);
        }

        // POST: DeliveryReturn/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        // [HttpPost, ActionName("Edit")]
        // [ValidateAntiForgeryToken]
        //  public async Task<IActionResult> EditPost(int? id)
        // {
        //     if (id == null)
        //     {
        //         return NotFound();
        //     }

        //     var thingsToUpdate = await _context.DeliveryReturn
        //         .FirstOrDefaultAsync(c => c.id == id);

        //     if (await TryUpdateModelAsync<DeliveryReturn>(thingsToUpdate,
        //         "",
        //         c => c.date, c => c.qty, c => c.status, c => c.lotdate, c => c.productID))
        //     {
        //         try
        //         {
        //             await _context.SaveChangesAsync();
        //         }
        //         catch (DbUpdateException /* ex */)
        //         {
        //             //Log the error (uncomment ex variable name and write a log.)
        //             ModelState.AddModelError("", "Unable to save changes. " +
        //                 "Try again, and if the problem persists, " +
        //                 "see your system administrator.");
        //         }
        //         return RedirectToAction(nameof(Index));
        //     }
        //     PopulateDropDownList(thingsToUpdate.productID);
        //     return View(thingsToUpdate);

        // }
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

        private void PopulateDropDownList(object selectedProduct = null)
        {
            var productsQuery = from d in _context.Product
                                   orderby d.name
                                   select d;
            ViewBag.productID = new SelectList(productsQuery.AsNoTracking(), "productID", "name", selectedProduct);

            //  var shoppingMallsQuery = from d in _context.Product
            //                        orderby d.name
            //                        select d;
            // ViewBag.shoppingmallID = new SelectList(shoppingMallsQuery.AsNoTracking(), "shoppingmallID", "name", selectedShoppingMall);
        }

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
