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
    public class CarPlateController : Controller
    {
        private readonly KaferDbContext _context;

        public CarPlateController(KaferDbContext context)
        {
            _context = context;
        }
        
        public async Task<IActionResult> plates() 
        {
            var result = await _context.CarPlate.ToListAsync();
            return Json(result);
        }

        // GET: CarPlate
        public async Task<IActionResult> Index()
        {
            return View(await _context.CarPlate.ToListAsync());
        }

       

      


        // GET: CarPlate/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carPlate = await _context.CarPlate
                .FirstOrDefaultAsync(m => m.carPlateId == id);
            if (carPlate == null)
            {
                return NotFound();
            }

            return View(carPlate);
        }

        // GET: CarPlate/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CarPlate/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("carPlateId,carPlateNumber")] CarPlate carPlate)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carPlate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carPlate);
        }

        // GET: CarPlate/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carPlate = await _context.CarPlate.FindAsync(id);
            if (carPlate == null)
            {
                return NotFound();
            }
            return View(carPlate);
        }

        // POST: CarPlate/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("carPlateId,carPlateNumber")] CarPlate carPlate)
        {
            if (id != carPlate.carPlateId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carPlate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarPlateExists(carPlate.carPlateId))
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
            return View(carPlate);
        }

        // GET: CarPlate/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carPlate = await _context.CarPlate
                .FirstOrDefaultAsync(m => m.carPlateId == id);
            if (carPlate == null)
            {
                return NotFound();
            }

            return View(carPlate);
        }

        // POST: CarPlate/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carPlate = await _context.CarPlate.FindAsync(id);
            _context.CarPlate.Remove(carPlate);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarPlateExists(int id)
        {
            return _context.CarPlate.Any(e => e.carPlateId == id);
        }
    }
}
