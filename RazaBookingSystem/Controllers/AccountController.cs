using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazaBookingSystem.Context;
using RazaBookingSystem.Data;
using RazaBookingSystem.Models;

namespace RazaBookingSystem.Controllers
{
    public class AccountController : Controller
    {
        private readonly HBSystemContext _context;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public AccountController(HBSystemContext context,
            SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        // GET: Account
        public async Task<IActionResult> Index()
        {
            return View(await _context.userDetails.ToListAsync());
        }

        // GET: Account/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userDetail = await _context.userDetails
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (userDetail == null)
            {
                return NotFound();
            }

            return View(userDetail);
        }

        // GET: Account/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Account/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,AttendanceId,FirstName,LastName,UserName,Email,Role,Password")] UserDetail userDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userDetail);
        }

        // GET: Account/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userDetail = await _context.userDetails.FindAsync(id);
            if (userDetail == null)
            {
                return NotFound();
            }
            return View(userDetail);
        }

        // POST: Account/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,AttendanceId,FirstName,LastName,UserName,Email,Role,Password")] UserDetail userDetail)
        {
            if (id != userDetail.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserDetailExists(userDetail.UserId))
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
            return View(userDetail);
        }

        // GET: Account/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userDetail = await _context.userDetails
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (userDetail == null)
            {
                return NotFound();
            }

            return View(userDetail);
        }

        // POST: Account/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userDetail = await _context.userDetails.FindAsync(id);
            if (userDetail != null)
            {
                _context.userDetails.Remove(userDetail);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserDetailExists(int id)
        {
            return _context.userDetails.Any(e => e.UserId == id);
        }

        [HttpPost]
public async Task<IActionResult> Login(LoginViewModel model)
{
    if (ModelState.IsValid)
    {
        var user = await _userManager.FindByEmailAsync(model.Email);

                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, model.Password, isPersistent: false, lockoutOnFailure: false);

                    if (result.Succeeded)
                    {
                        // Login successful
                        return RedirectToAction("Account", "Booking");
                    }
                }

                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
    }

            return (View(model));
}
        [HttpGet]
        public IActionResult Login()
        {


            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Check if the password and confirm password match
                if (model.Password == model.ConfirmPassword)
                {
                    // Here you would typically save the user's information to a database
                    // or perform any other necessary operations

                    // For example:
                    // var user = new User { Name = model.Name, Email = model.Email, Password = model.Password };
                    // var result = userRepository.CreateUser(user);

                    // If the user was successfully created, you could redirect to a success page
                    // or log the user in and redirect to the home page
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    // Add an error to the ModelState if the passwords don't match
                    ModelState.AddModelError("", "The password and confirmation password do not match.");
                }
            }

            // If we got this far, something failed, so re-render the view
            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Booking()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Booking(BookingViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Todo: implement booking logic here
                // For example, save the booking to the database
                // ...

                return RedirectToAction("BookingSuccess");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult BookingSuccess()
        {
            return View(LoginViewModel);
        }

    }
}
