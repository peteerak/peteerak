using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using kafer_house.Models;
using kafer_house.Data;
using Microsoft.AspNetCore.Identity;

namespace kafer_house.Controllers
{
    public class ReceiveController : Controller
    {
        private readonly KaferDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);


        public ReceiveController(KaferDbContext context,UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;

            _context = context;
        }

        // GET: Receive
        public async Task<IActionResult> Index()
        {
            var user = await GetCurrentUserAsync();
            if (user == null){
                return RedirectToAction("Index","Home");
            }
            var kaferDbContext = _context.Receive.Include(r => r.branch).Include(r => r.shoppingmall);
            return View(await kaferDbContext.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> addCart(List<Item> items, int shoppingMallId, int branchId, DateTime productLotDate){  
           
        
            //check to seee if the items size >0
            if(items.Count >0){
                
                //create new cart object
               Receive cart = new Receive{
                   receiveDate          = DateTime.Now,
                   productLotDate       = productLotDate,
                   shoppingmallID       = shoppingMallId,
                   branchId             = branchId,
               };

               //add cart into carts context
               _context.Receive.Add(cart);

               //save change to the new cart
               //note thate when the new cart object is saved
               //the system will automatically assign the primary key(cartId) data for each cart data row
               await _context.SaveChangesAsync(); //save cart first

               //after the operation above, cart.cartId is accessible

               //create a list of cart items
               List<ReceiveItem> list1 = new List<ReceiveItem>();

               //loop throught each item in the items list
               foreach(Item item in items){
                    //create a new object with the structure based on Model>CartItem.cs 
                    var row = new ReceiveItem {
                        productId   = item.productId,
                        productName = item.productName,
                        productQty  = item.productQty,
                        receiveId  = cart.receiveId  //cart Id go here
                    };
                    list1.Add(row);
               }//end loop
               
               //assign caritem list 
               cart.receiveItem = list1;
               await _context.SaveChangesAsync(); //save cart first
                //step33: return Action to be call by client
                return Json(new
                {
                    newUrl = Url.Action("Index")
                }
             );
            }
            else{
                return Content("error data upload fail");
            }
        
        }

        // GET: Receive/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receive = await _context.Receive
                .Include(r => r.branch)
                .Include(r => r.shoppingmall)
                .Include(r => r.receiveItem)
                .FirstOrDefaultAsync(m => m.receiveId == id);
            if (receive == null)
            {
                return NotFound();
            }

            return View(receive);
        }

        // GET: Receive/Create
        public IActionResult Create()
        {
            ViewData["branchId"] = new SelectList(_context.Branch, "id", "name");
            ViewData["shoppingmallID"] = new SelectList(_context.ShoppingMall, "id", "name");
            return View();
        }

        // POST: Receive/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("receiveId,receiveDate,productLotDate,branchId,shoppingmallID")] Receive receive)
        {
            if (ModelState.IsValid)
            {
                _context.Add(receive);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["branchId"] = new SelectList(_context.Branch, "id", "name", receive.branchId);
            ViewData["shoppingmallID"] = new SelectList(_context.ShoppingMall, "id", "name", receive.shoppingmallID);
            return View(receive);
        }

        // GET: Receive/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receive = await _context.Receive.FindAsync(id);
            if (receive == null)
            {
                return NotFound();
            }
            ViewData["branchId"] = new SelectList(_context.Branch, "id", "name", receive.branchId);
            ViewData["shoppingmallID"] = new SelectList(_context.ShoppingMall, "id", "name", receive.shoppingmallID);
            return View(receive);
        }

        // POST: Receive/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("receiveId,receiveDate,productLotDate,branchId,shoppingmallID")] Receive receive)
        {
            if (id != receive.receiveId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(receive);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReceiveExists(receive.receiveId))
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
            ViewData["branchId"] = new SelectList(_context.Branch, "id", "name", receive.branchId);
            ViewData["shoppingmallID"] = new SelectList(_context.ShoppingMall, "id", "name", receive.shoppingmallID);
            return View(receive);
        }

        // GET: Receive/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receive = await _context.Receive
                .Include(r => r.branch)
                .Include(r => r.shoppingmall)
                .FirstOrDefaultAsync(m => m.receiveId == id);
            if (receive == null)
            {
                return NotFound();
            }

            return View(receive);
        }

        // POST: Receive/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var receive = await _context.Receive.FindAsync(id);
            _context.Receive.Remove(receive);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReceiveExists(int id)
        {
            return _context.Receive.Any(e => e.receiveId == id);
        }
    }
}
