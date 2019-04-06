using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using kafer_house.Models;

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

       
    }
}
