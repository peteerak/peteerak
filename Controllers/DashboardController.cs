using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using kafer_house.Models;
using Microsoft.EntityFrameworkCore;

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
        
        public IActionResult Data(){


            // query that return {{zone:1, count:3}}
            var result = _context.SaleOrders
                        .GroupBy(x => new {group = x.zone}) // [{group:1}, {group: 2}, {group:3}]
                        .Select(group => new{
                                zone = group.Key.group,
                                count = group.Count()
                        })
                        .OrderByDescending(o => o.count).ToList();
            var labels = result.Select(x => x.zone).ToArray();
            var values = result.Select(x => x.count).ToArray();
            var max = values[0];
                
            List<object> list1 = new List<object>();

            list1.Add(labels);
            list1.Add(values);
            list1.Add(max);
            return Json(list1);
        }

        public IActionResult MyData(){
            var result = _context.ActualSold
                        .Include(d => d.shoppingmall)
                        .Include(x => x.product)
                        .Where(x => x.shoppingmall.name == "the mall")
                        .Select(x => new {
                            qty = x.qty,
                            productName = x.product.name,

                        })
                        .ToList();
            var qtys = result.Select(x => x.qty).ToArray();
            var productNames = result.Select(x => x.productName).ToArray();

            List<object> list1 = new List<object>();
            list1.Add(qtys);
            list1.Add(productNames);


            return Json(list1);
        }

       
    }
}
