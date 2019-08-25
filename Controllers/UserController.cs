

using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using kafer_house.Data;
using kafer_house.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace kafer_house.Controllers
{
    
    public class UserController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly KaferDbContext _context;
        public UserController(
            KaferDbContext context, 
            UserManager<ApplicationUser> userManager, 
            SignInManager<ApplicationUser> signInManager
            )
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _userManager.Users;
            return View(await applicationDbContext.ToListAsync());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(string GetFullName, string Email, string Phone)
        {
            var users = from u in _userManager.Users
                                    select u;
            
            if (!String.IsNullOrEmpty(GetFullName))
            {
                users = users.Where(u => u.GetFullName.Contains(GetFullName));
            }

            return View(await users.ToListAsync());
        }

         public IActionResult Create()
        {
            ViewData["RoleId"] = new SelectList(_context.Roles, "Name", "Name");
            return View();
        }

         [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                using (var transaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        var user = new ApplicationUser 
                        { 
                            UserName = model.Username, 
                            FirstName = model.FirstName,
                            LastName = model.LastName,
                            EmailConfirmed = true
                        };
                        
                        var result = await _userManager.CreateAsync(user, model.Password);

                        // add role from role id
                        await _userManager.AddToRoleAsync(user, model.RoleId);

                        var data = await _userManager.Users
                                            .Where(x => x.UserName == user.UserName).FirstAsync();

                        if(model.RoleId == "Staff")
                        {
                            var createStaff = new Staff
                            {
                                FirstName = data.FirstName,
                                LastName = data.LastName,
                                ApplicationUserId = data.Id
                            };

                            _context.Add(createStaff);
                            await _context.SaveChangesAsync();
                        }
                        else
                        {
                            var createManager = new Manager
                            {
                                FirstName = data.FirstName,
                                LastName = data.LastName,
                                ApplicationUserId = data.Id
                            };

                            _context.Add(createManager);
                            await _context.SaveChangesAsync();
                        }
                        
                        transaction.Commit();
                        // Success("Create Successfully!", true);
                        return RedirectToAction(nameof(UserController.Index));
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        // Danger("Create Not Complete!", true);
                        return View(model);
                    }


                }
            }
            // Danger("Model not match!", true);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

// GET: Product/Delete/5
        public IActionResult Delete(int? id)
        {
         
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int Id)
        {
            var user = await _context.Users.FindAsync(Id);

            await _userManager.DeleteAsync(user);
            return RedirectToAction(nameof(Index));
        }
    

        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
