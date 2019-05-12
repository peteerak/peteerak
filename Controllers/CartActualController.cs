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
        // public async Task<IActionResult> Index()
        // {
        //     return View(await _context.CartActual.ToListAsync());
        // }

        [HttpGet]
        public async Task<IActionResult> Index(string d1, string d2){
           

            //step18: perform a absolute query from carts table
            var set1 = _context.CartActual.Select(x=>x);

            //step19: check to see if both d1 && d2 are not know
            //if that is the case, we impose a filter to the set1 to obtain
            //only data rows with in specified time range
            if(d1 != null && d2 != null){
                DateTime date1 = Convert.ToDateTime(d1);
                DateTime date2 = Convert.ToDateTime(d2);
                set1 = set1.Where(x => x.createdDate >= date1 && x.createdDate <= date2);
            }
            
            //step20: get a query result to display as the table in the index.cshtml
            //note that We use Select() to perform data projection that returns
            //a set of query result for the objects with the structure [Id,date, total]
            //where x represent each data row in carts table
            var result = set1
                            .Select(x => new CartActualView
                            {
                                Id = x.cartId,     //cart Id can be directly ref from x
                                date = x.createdDate, //created date can be directly ref from x
                                //total is calculated from
                                // x->that point to another table name cartitems
                                //check Model>Cart.cs for Navigational property link
                                total = x.cartItems.Sum(p => p.productPrice * p.productQty)
                            });
            
            //step21: we make another query to generate graph data
            //In this step we use Select() to perform data project that returns
            //a set of query result for the objects with the structure [date, total]
           var data= set1
           .Select(x=> new
                {date= x.createdDate.ToShortDateString(), //note time is not included just date
                total = x.cartItems.Sum(r=> r.productPrice*r.productQty)
                })
           //step22: by using the result from the projection operation above
           //we group the data by date 
           //the result of the grouping will look like this
            // [ 
            //     [{date:'04-28-2019',total:40}],
            //     [{date:'04-29-2019', total:50},{date:'04-29-2019',total:60}]
            // ]
           .GroupBy(x=> x.date)

           //step23: based of the grouping result, we then create another projection
           //to get sum of total for each group
           //the result of the groupping will look like this
           // [ 
           //     {date:'04-28-2019',total:40},
           //     {date:'04-29-2019',total:110}
           // ]
           //note that the chain operations of linq end here so we put ';' at the end

           .Select(g=> new {
             date = g.Key,
             total = g.Sum(x=>x.total)
           });

           //step24: using the data resul, we create two arrays
           //x_data is the array with the projection to select only data from the field date
           //y_data is the array with the projection to select only data from the field total
           var x_data = data.Select(x=>x.date).ToArray();
           var y_data = data.Select(x=>x.total).ToArray();
         
           //step25: we can not simply pass the array to the razor view
           //view need to convert our arrays into string below
           //after the conversion with assign the string version of x_data and y_data 
           //to the ViewBag
           //so that we can access that data in the razor view just like below
           //@ViewBag.x_data
           ViewBag.x_data = string.Join(",", x_data);
           ViewBag.y_data = string.Join(",", y_data);
             
            //step26: open Index View (View>Cart>Index.cshtml) and attach result to the Model
           return View("Index",result);

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

        [HttpPost]
        public async Task<IActionResult> addCart(List<Item> items){ 
           
        
            //check to seee if the items size >0
            if(items.Count >0){
                
                //create new cart object
               CartActual cart = new CartActual{
                   createdDate = DateTime.Now
               };

               //add cart into carts context
               _context.CartActual.Add(cart);

               //save change to the new cart
               //note thate when the new cart object is saved
               //the system will automatically assign the primary key(cartId) data for each cart data row
               await _context.SaveChangesAsync(); //save cart first

               //after the operation above, cart.cartId is accessible

               //create a list of cart items
               List<CartItemActual> list1 = new List<CartItemActual>();

               //loop throught each item in the items list
               foreach(Item item in items){
                    //create a new object with the structure based on Model>CartItem.cs 
                    var row = new CartItemActual {
                        productId = item.productId,
                        productQty = item.productQty,
                        productPrice = item.productPrice,
                        cartId     = cart.cartId  //cart Id go here
                    };
                    list1.Add(row);
               }//end loop
               
               //assign caritem list 
               cart.cartItems = list1;
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

        [HttpGet]
        public async Task<IActionResult> Edit(int id){
            var cart = await _context.CartActual
                .Include(x=>x.cartItems) //with out this line, no cart item
                .FirstOrDefaultAsync(x=>x.cartId == id);
            return View("Edit",cart);
            
                 
             
            
        }
        // public async Task<IActionResult> Edit(int? id)
        // {
        //     if (id == null)
        //     {
        //         return NotFound();
        //     }

        //     var cartActual = await _context.CartActual.FindAsync(id);
        //     if (cartActual == null)
        //     {
        //         return NotFound();
        //     }
        //     return View(cartActual);
        // }

        // POST: CartActual/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> Edit(int id, [Bind("cartId,createdDate")] CartActual cartActual)
        // {
        //     if (id != cartActual.cartId)
        //     {
        //         return NotFound();
        //     }

        //     if (ModelState.IsValid)
        //     {
        //         try
        //         {
        //             _context.Update(cartActual);
        //             await _context.SaveChangesAsync();
        //         }
        //         catch (DbUpdateConcurrencyException)
        //         {
        //             if (!CartActualExists(cartActual.cartId))
        //             {
        //                 return NotFound();
        //             }
        //             else
        //             {
        //                 throw;
        //             }
        //         }
        //         return RedirectToAction(nameof(Index));
        //     }
        //     return View(cartActual);
        // }

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
