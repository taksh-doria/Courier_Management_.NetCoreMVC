using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Courier_Management_System.Models;
using Microsoft.AspNetCore.Http;
using Courier_Management_System.Data;
using DataContext = Courier_Management_System.Models.DataContext;

namespace Courier_Management_System.Controllers
{
    public class UserController : Controller
    {
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _accessor;
        public UserController(DataContext context, IHttpContextAccessor accessor)
        {
            _context = context;
            _accessor = accessor;
        }
        public async Task<IActionResult> SignUp()
        {
            
            return View(await _context.City.ToListAsync());
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
                HttpContext.Session.SetString("user_role", user.role);
                ViewBag.session = HttpContext.Session.GetString("logged_in_user");
                Console.WriteLine("stored variable "+ViewBag.session);
                return Redirect("/User/Profile/");
            }
            return View(user);
        }



        public async Task<IActionResult> Profile()
        {
            if(new Utility(this._accessor).IsAuthorisedClient()==true)
            {
               var user = await _context.users
                    .FirstOrDefaultAsync(m => m.email == HttpContext.Session.GetString("logged_in_user"));
                    Console.WriteLine(user.name);
                return View(user);
            }
            else
            {
                return Redirect("/User/Signup");
            }
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return Redirect("/Home/Index");
        }
        
    }
}
