using dalmARTSY_Test.Areas.Identity.Data;
using dalmARTSY_Test.Data;
using dalmARTSY_Test.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace dalmARTSY_Test.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/[controller]/[action]")]
    public class AppUserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;


        public AppUserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        // GET: AppUserController
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.ToListAsync();
            
            return View(users);
        }

        // GET: AppUserController/Details/5
        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            if(string.IsNullOrEmpty(id))
            {
               return RedirectToAction(nameof(Index));

            }

            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return RedirectToAction(nameof(Index));

            }

            return View(user);
        }

        // GET: AppUserController/Create
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.ErrorMessage = TempData["ErrorMessage"] as string ?? string.Empty;
            return View(nameof(Create));
        }

        // POST: AppUserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(User user)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var newUser = new AppUser
                    {
                        UserName = user.UserName,
                        Email = user.Email,
                        FirstName= user.FirstName,
                        LastName= user.LastName
                    };

                    var newAppUser = await _userManager.CreateAsync(newUser, user.Password);

                    if (newAppUser.Succeeded)
                    {
                        return RedirectToAction(nameof(Index));
                    }

                }
                catch(Exception ex)
                {
                    TempData["ErrorMessage"] = ex.Message;
                    return RedirectToAction(nameof(Create));
                }
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: AppUserController/Edit/5
        [HttpGet]
        public async Task <IActionResult> Edit(string id)
        {
            AppUser user = await _userManager.FindByIdAsync(id);

            if (user != null)
            {
                return View(user);
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }
        }

        // POST: AppUserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Edit(string id, string email, string firstName, string lastName, string password)
        {
            AppUser user = await _userManager.FindByIdAsync(id);

            if (user != null)
            {

                if (!String.IsNullOrEmpty(id))
                {
                    user.Id = id;
                }
                else
                {
                    ModelState.AddModelError("", "Please enter your email address");
                }
                if (!String.IsNullOrEmpty(email))
                {
                    user.Email = email;
                }
                else
                {
                    ModelState.AddModelError("", "Please enter your email address");
                }
                if (!String.IsNullOrEmpty(firstName))
                {
                    user.FirstName = firstName;
                }
                else
                {
                    ModelState.AddModelError("", "Please enter your email address");
                }
                if (!String.IsNullOrEmpty(lastName))
                {
                    user.LastName = lastName;
                }
                else
                {
                    ModelState.AddModelError("", "Please enter your email address");
                }
                if (!String.IsNullOrEmpty(password))
                {
                    user.PasswordHash = new PasswordHasher<AppUser>().HashPassword(user,password);
                }
                else
                {
                    ModelState.AddModelError("", "Please enter your email address");
                }

                if (!String.IsNullOrEmpty(email) && !String.IsNullOrEmpty(password) && !String.IsNullOrEmpty(firstName) && !String.IsNullOrEmpty(lastName))
                {
                    var result = await _userManager.UpdateAsync(user);

                    if (result.Succeeded)
                    {
                        return RedirectToAction(nameof(Index));
                    }

                    else
                    {
                        foreach (IdentityError error in result.Errors)
                            ModelState.AddModelError("", error.Description);
                    }
                }
            }
            else
                ModelState.AddModelError("", "No user");

            return View(user);
             
            }



        // GET: AppUserController/Delete/5
        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return RedirectToAction(nameof(Index));
            }

            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return RedirectToAction(nameof(Index));
            }
    
            return View(user);
        }

        // POST: AppUserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteUser(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return RedirectToAction(nameof(Index));
            }

            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return RedirectToAction(nameof(Index));
            }
            
            var result = await _userManager.DeleteAsync(user);

            if(result.Succeeded)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(nameof(Index));

        }


    }

 
}

