using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using kafer_house.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using kafer_house.Data;

namespace kafer_house.Controllers
{
    public class DashboardController : Controller
    {

        private readonly KaferDbContext _context;

        public DashboardController(KaferDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Report(){
            return View();
        }

        public async Task<IActionResult> ProductLoss(DateTime dateFrom, DateTime dateTo) 
        {
                
                
                var Receive = await  _context.Receive
                                        .Include(x => x.shoppingmall)
                                        .Include(x => x.branch)
                                        .Include(x => x.receiveItem)
                                        .Where(x => x.receiveDate.Date >= dateFrom.Date && x.receiveDate.Date <= dateTo.Date)
                                        .ToListAsync();

                var receiveGroup = from receiveitems in Receive
                                    group receiveitems by new {receiveitems.shoppingmall.name, receiveitems.branch.branchName} into eGroup
                                    orderby eGroup.Key.name, eGroup.Key.branchName
                                    select new ProductLossView
                                    {
                                        ShoppingMall = eGroup.Key.name,
                                        Branch = eGroup.Key.branchName,
                                        receiveItems = eGroup.OrderBy(x => x.receiveId)
                                                    .Select(b => b.receiveItem)
                                                    .SelectMany(item => item)
                                                    .Distinct()
                                                    .ToArray()
                                                    .GroupBy(d => d.productName)
                                                          .Select(d => new ProductLoss{
                                                              productName = d.Key,
                                                              productReceived  = d.Sum(y => y.productQty)
                                                          })
                                    };

                var delivery = await  _context.Delivery
                                        .Include(x => x.shoppingmall)
                                        .Include(x => x.branch)
                                        .Include(x => x.deliveryItem)
                                        .Where(x => x.deliveryDate.Date >= dateFrom.Date && x.deliveryDate.Date <= dateTo.Date)
                                        .ToListAsync();

                 var deliveryGroup = from deliItems in delivery
                                    group deliItems by new {deliItems.shoppingmall.name, deliItems.branch.branchName} into eGroup
                                    orderby eGroup.Key.name, eGroup.Key.branchName
                                    select new ProductLossView
                                    {
                                        ShoppingMall = eGroup.Key.name,
                                        Branch = eGroup.Key.branchName,
                                        deliveryItems = eGroup.OrderBy(x => x.deliveryId)
                                                    .Select(b => b.deliveryItem)
                                                    .SelectMany(item => item)
                                                    .Distinct()
                                                    // .ToArray()
                                                    .GroupBy(d => d.productName)
                                                          .Select(d => new ProductLoss{
                                                              productName = d.Key,
                                                              productSent = d.Sum(y => y.productQty)
                                                          })
                                        
                                    };

                var actual = await  _context.CartActual
                                        .Include(x => x.shoppingmall)
                                        .Include(x => x.branch)
                                        .Include(x => x.cartItems)
                                        .Where(x => x.dateSold.Date >= dateFrom.Date && x.dateSold.Date <= dateTo.Date)
                                        .ToListAsync();

                var actualGroup = from actualitems in actual
                                    group actualitems by new {actualitems.shoppingmall.name, actualitems.branch.branchName} into eGroup
                                    orderby eGroup.Key.name, eGroup.Key.branchName
                                    select new ProductLossView
                                    {
                                        ShoppingMall = eGroup.Key.name,
                                        Branch = eGroup.Key.branchName,
                                        actualItems = eGroup.OrderBy(x => x.cartId)
                                                    .Select(b => b.cartItems)
                                                    .SelectMany(item => item)
                                                    .Distinct()
                                                    .ToArray()
                                                    .GroupBy(d => d.productName)
                                                          .Select(d => new ProductLoss{
                                                              productName = d.Key,
                                                              productActual  = d.Sum(y => y.productQty)
                                                          })
                                    };
                
           
                List<ProductLossView> list1 = new List<ProductLossView>();
                list1.AddRange(deliveryGroup);
                list1.AddRange(receiveGroup);
                list1.AddRange(actualGroup);


                var merged =    list1
                                .GroupBy(x => new {x.ShoppingMall, x.Branch})
                                .Select(g => new {
                                    ShoppingMall = g.Key.ShoppingMall,
                                    Branch       = g.Key.Branch,
                                    AllItems = g.Select(d => d.deliveryItems).Where(e => e != null)
                                                .Concat(g.Select(d => d.receiveItems).Where(e => e != null))
                                                .Concat(g.Select(d => d.actualItems).Where(e => e != null))
                                                .SelectMany(item => item)
                                                .Distinct()
                                                .GroupBy(z => z.productName)
                                                          .Select(h => new ProductLoss{
                                                              productName = h.Key,
                                                              productSent = h.Sum(y => y.productSent),
                                                              productReceived = h.Sum(y => y.productReceived),
                                                              productActual = h.Sum(y => y.productActual),
                                                              productLoss = h.Sum(y => y.productSent) - h.Sum(y => y.productReceived) - h.Sum(y => y.productActual),
                                                          })
                                             
                                });
           
            return Json(merged);
        }

         public async Task<IActionResult> getReceive(DateTime dateFrom, DateTime dateTo) 
        {
            

            var receive = await _context.Receive
                                    .Include(x => x.shoppingmall)
                                    .Include(x => x.branch)
                                    .Include(x => x.receiveItem)
                                    .Where(x => x.receiveDate.Date >= dateFrom.Date && x.receiveDate.Date <= dateTo.Date)
                                    .ToListAsync();

            return Json(receive);
        }
        
        // public IActionResult Data(){


        //     // query that return {{zone:1, count:3}}
        //     var result = _context.SaleOrders
        //                 .GroupBy(x => new {group = x.zone}) // [{group:1}, {group: 2}, {group:3}]
        //                 .Select(group => new{
        //                         zone = group.Key.group,
        //                         count = group.Count()
        //                 })
        //                 .OrderByDescending(o => o.count).ToList();
        //     var labels = result.Select(x => x.zone).ToArray();
        //     var values = result.Select(x => x.count).ToArray();
        //     var max = values[0];
                
        //     List<object> list1 = new List<object>();

        //     list1.Add(labels);
        //     list1.Add(values);
        //     list1.Add(max);
        //     return Json(list1);
        // }

        // public IActionResult MyData(){
        //     var result = _context.ActualSold
        //                 .Include(d => d.shoppingmall)
        //                 .Include(x => x.product)
        //                 .Where(x => x.shoppingmall.name == "the mall")
        //                 .GroupBy(x => new {group = x.product.name})
        //                 .Select(group => new {
        //                     productName = group.Key.group,
        //                     qty = group.Sum(x => x.qty)

        //                 })
        //                 .ToList();
                
        //     var qtys = result.Select(x => x.qty).ToArray();
        //     var productNames = result.Select(x => x.productName).ToArray();

        //     List<object> list1 = new List<object>();
        //     list1.Add(qtys);
        //     list1.Add(productNames);
            


        //     return Json(list1);
        // }


        public async Task<IActionResult> ActualSalesGraphData(DateTime dateFrom, DateTime dateTo, int branchId, int shoppingmallId)
        {
            var CartActual = await _context.CartActual
                                    .Include(x => x.cartItems)
                                    .Where(x =>x.dateSold.Date >= dateFrom.Date && x.dateSold.Date <= dateTo.Date)
                                    .Where(x => x.branchId == branchId && x.shoppingmallID == shoppingmallId)
                                    .Select(x => x.cartItems)
                                    .ToListAsync();
            
            return Json(CartActual);
        }

       
    }


    
}
