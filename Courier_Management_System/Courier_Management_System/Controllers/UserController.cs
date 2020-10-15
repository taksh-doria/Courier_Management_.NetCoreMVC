using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Courier_Management_System.Models;
using Microsoft.AspNetCore.Http;

namespace Courier_Management_System.Controllers
{
    public class UserController : Controller
    {
        private readonly UserContext _context;

        public UserController(UserContext context)
        {
            _context = context;
        }

        // GET: User
        public async Task<IActionResult> Index()
        {
            return View(await _context.users.ToListAsync());
        }

        // GET: User/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.users
                .FirstOrDefaultAsync(m => m.id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }
        // GET: User/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: User/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("id,email,password,name,phone_no,city,role")] User user)
        {
            if (id != user.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.id))
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
            return View(user);
        }

        // GET: User/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.users
                .FirstOrDefaultAsync(m => m.id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var user = await _context.users.FindAsync(id);
            _context.users.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(long id)
        {
            return _context.users.Any(e => e.id == id);
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUpAsync(String email,String name,String password,String city,String phone_no,String address)
        {
            User U = new User();
            Console.Write(email + ":" + name + ":" + city + ":" + phone_no);
            Console.WriteLine("inside signup post method");
            U.email = email;
            U.city = city;
            U.name = name;
            U.password = password;
            U.role = "client";
            U.phone_no = phone_no;
            U.address = address;
            if (ModelState.IsValid)
            {
                _context.Add(U);
                _ = await _context.SaveChangesAsync();
                return Redirect("/Home/Index");
            }
            return View(U);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(String email,String password)
        {
            var user = await _context.users
                .FirstOrDefaultAsync(m => m.email == email && m.password==password);
            if(user!=null)
            {
                HttpContext.Session.SetString("logged_in_user",user.email);
                ViewBag.session = HttpContext.Session.GetString("logged_in_user");
                Console.WriteLine("stored variable "+ViewBag.session);
                return Redirect("/Home/Index");
            }
            return View(user);
        }

        
    }
}
