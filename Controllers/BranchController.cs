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
    public class BranchController : Controller
    {
        private readonly KaferDbContext _context;

        public BranchController(KaferDbContext context)
        {
            _context = context;
        }

        // GET: Branch
        public async Task<IActionResult> Index()
        {
            var kaferDbContext = _context.Branch.Include(b => b.shoppingmall);
            return View(await kaferDbContext.ToListAsync());
        }

        // GET: Branch/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var branch = await _context.Branch
                .Include(b => b.shoppingmall)
                .FirstOrDefaultAsync(m => m.branchId == id);
            if (branch == null)
            {
                return NotFound();
            }

            return View(branch);
        }

        // GET: Branch/Create
        public IActionResult Create()
        {
            ViewData["shoppingmallID"] = new SelectList(_context.ShoppingMall, "id", "name");
            return View();
        }

        // POST: Branch/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("branchId,branchName,shoppingmallID")] Branch branch)
        {
            if (ModelState.IsValid)
            {
                _context.Add(branch);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["shoppingmallID"] = new SelectList(_context.ShoppingMall, "id", "name", branch.shoppingmallID);
            return View(branch);
        }

        // GET: Branch/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var branch = await _context.Branch.FindAsync(id);
            if (branch == null)
            {
                return NotFound();
            }
            ViewData["shoppingmallID"] = new SelectList(_context.ShoppingMall, "id", "name", branch.shoppingmallID);
            return View(branch);
        }

        // POST: Branch/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("branchId,branchName,shoppingmallID")] Branch branch)
        {
            if (id != branch.branchId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(branch);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BranchExists(branch.branchId))
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
            ViewData["shoppingmallID"] = new SelectList(_context.ShoppingMall, "id", "name", branch.shoppingmallID);
            return View(branch);
        }

        [HttpGet]
        public async Task<IActionResult> branchs(int? items){
            var result = await _context.Branch
                                    .Where(x => x.shoppingmallID == items)
                                    .ToListAsync();

            return Json(result);
        }

        // GET: Branch/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var branch = await _context.Branch
                .Include(b => b.shoppingmall)
                .FirstOrDefaultAsync(m => m.branchId == id);
            if (branch == null)
            {
                return NotFound();
            }

            return View(branch);
        }

        // POST: Branch/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var branch = await _context.Branch.FindAsync(id);
            _context.Branch.Remove(branch);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BranchExists(int id)
        {
            return _context.Branch.Any(e => e.branchId == id);
        }
    }
}
