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
    public class DeliveryController : Controller
    {
        private readonly KaferDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);


        public DeliveryController(KaferDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Delivery
        public async Task<IActionResult> Index()
        {
            var kaferDbContext = _context.Delivery.Include(d => d.branch).Include(d => d.shoppingmall).Include(d => d.carPlate);
            return View(await kaferDbContext.ToListAsync());
        }

          [HttpPost]
         public async Task<IActionResult> Index(int? carPlateId, double Price)
        {
            var carPlateNumber = await  _context.CarPlate.Where(x => x.carPlateId == carPlateId).Select(x => x.carPlateNumber).FirstOrDefaultAsync();
            
            var deliveryCarplate = from p in _context.Delivery
                            .Include( x => x.carPlate)
                            .Include(x => x.shoppingmall)
                            .Include(d => d.branch)
                            .Include(d => d.deliveryItem)
                            select p;
            
            if (!String.IsNullOrEmpty(carPlateNumber))
            {
                deliveryCarplate = deliveryCarplate.Where(p => p.carPlate.carPlateNumber.Contains(carPlateNumber));
            }

            return View(await deliveryCarplate.ToListAsync());
        }

        public async Task<IActionResult> getUserRole()
        {
            var user = await GetCurrentUserAsync();
            var role = await _userManager.GetRolesAsync(user);
            return Json(role);
        }

        [HttpPost]
        public async Task<IActionResult> addCart(List<Item> items, int shoppingMallId, int branchId, DateTime productLotDate, int carPlateId){  
           
        
            //check to seee if the items size >0
            if(items.Count >0){
                
                //create new cart object
               Delivery cart = new Delivery{
                   carPlateId =carPlateId,
                   deliveryDate = DateTime.Now,
                   productLotDate = productLotDate,
                   shoppingmallID = shoppingMallId,
                   branchId = branchId,
               };

               //add cart into carts context
               _context.Delivery.Add(cart);

               //save change to the new cart
               //note thate when the new cart object is saved
               //the system will automatically assign the primary key(cartId) data for each cart data row
               await _context.SaveChangesAsync(); //save cart first

               //after the operation above, cart.cartId is accessible

               //create a list of cart items
               List<DeliveryItem> list1 = new List<DeliveryItem>();

               //loop throught each item in the items list
               foreach(Item item in items){
                    //create a new object with the structure based on Model>CartItem.cs 
                    var row = new DeliveryItem {
                        productId   = item.productId,
                        productName = item.productName,
                        productQty  = item.productQty,
                        deliveryId  = cart.deliveryId,  //cart Id go here
                        managerProductQty = item.productQty,
                    };
                    list1.Add(row);
               }//end loop
               
               //assign caritem list 
               cart.deliveryItem = list1;
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


        [HttpPost]
        public async Task<IActionResult> updateCart(List<Item> items, int id){  
             if(items.Count >0){
                
                //  var delivery = _context.Delivery.Include(x => x.deliveryItem).Where(x => x.deliveryId == id).ToListAsync();
                 var delivery = await _context.Delivery.Include(x => x.deliveryItem).Where(x => x.deliveryId == id).FirstOrDefaultAsync();
                
                for (int i = 0; i < delivery.deliveryItem.Count; i++)
                {
                    delivery.deliveryItem[i].managerProductQty = items[i].managerProductQty;
                    delivery.deliveryItem[i].productQty = items[i].productQty;


                }

                await _context.SaveChangesAsync();
                
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

        // GET: Delivery/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var delivery = await _context.Delivery
                .Include(d => d.branch)
                .Include(d => d.shoppingmall)
                .Include(d => d.deliveryItem)
                .FirstOrDefaultAsync(m => m.deliveryId == id);
            if (delivery == null)
            {
                return NotFound();
            }


            return View(delivery);
        }

        [HttpPost]
        public async Task<IActionResult> submitDelivered(int id)
        {
            var delivery = await _context.Delivery.Include(x => x.deliveryItem).Where(x => x.deliveryId == id).FirstOrDefaultAsync();

            var user = await GetCurrentUserAsync();
            var role = await _userManager.GetRolesAsync(user);
            
            if(role[0] == "Staff") {
                delivery.staffName = user.GetFullName;
            }
            await _context.SaveChangesAsync();
            return Json(delivery);
        }

        // GET: Delivery/Create
        public IActionResult Create()
        {
            ViewData["branchId"] = new SelectList(_context.Branch, "id", "name");
            ViewData["shoppingmallID"] = new SelectList(_context.ShoppingMall, "id", "name");
            return View();
        }

        // POST: Delivery/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("deliveryId,deliveryDate,productLotDate,branchId,shoppingmallID")] Delivery delivery)
        {
            if (ModelState.IsValid)
            {
                _context.Add(delivery);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["branchId"] = new SelectList(_context.Branch, "id", "name", delivery.branchId);
            ViewData["shoppingmallID"] = new SelectList(_context.ShoppingMall, "id", "name", delivery.shoppingmallID);
            return View(delivery);
        }

        // GET: Delivery/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var delivery = await _context.Delivery.FindAsync(id);
            if (delivery == null)
            {
                return NotFound();
            }
            ViewData["branchId"] = new SelectList(_context.Branch, "id", "name", delivery.branchId);
            ViewData["shoppingmallID"] = new SelectList(_context.ShoppingMall, "id", "name", delivery.shoppingmallID);
            return View(delivery);
        }

        // POST: Delivery/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("deliveryId,deliveryDate,productLotDate,branchId,shoppingmallID")] Delivery delivery)
        {
            if (id != delivery.deliveryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(delivery);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeliveryExists(delivery.deliveryId))
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
            ViewData["branchId"] = new SelectList(_context.Branch, "id", "name", delivery.branchId);
            ViewData["shoppingmallID"] = new SelectList(_context.ShoppingMall, "id", "name", delivery.shoppingmallID);
            return View(delivery);
        }

        // GET: Delivery/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var delivery = await _context.Delivery
                .Include(d => d.branch)
                .Include(d => d.shoppingmall)
                .FirstOrDefaultAsync(m => m.deliveryId == id);
            if (delivery == null)
            {
                return NotFound();
            }

            return View(delivery);
        }

        // POST: Delivery/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var delivery = await _context.Delivery.FindAsync(id);
            _context.Delivery.Remove(delivery);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeliveryExists(int id)
        {
            return _context.Delivery.Any(e => e.deliveryId == id);
        }
    }
}
