using System;
using System.Linq;
using System.Threading.Tasks;
using Courier_Management_System.Data;
using Courier_Management_System.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataContext = Courier_Management_System.Models.DataContext;

namespace Courier_Management_System.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _accessor;
        public EmployeeController(DataContext context,IHttpContextAccessor acc)
        {
            _context = context;
            _accessor = acc;
        }

        // GET: Employee
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(String email, String password)
        {
            Console.WriteLine("here");
            var user = await _context.Employee.FirstOrDefaultAsync(m => m.emp_email == email && m.emp_password == password);
            Console.WriteLine(user);
            if (user != null)
            {
                Console.WriteLine("user authenticated");
                HttpContext.Session.SetString("logged_in_user", user.emp_email);
                HttpContext.Session.SetString("user_role",user.emp_role);
                ViewBag.session = HttpContext.Session.GetString("logged_in_user");
                Console.WriteLine("stored variable " + ViewBag.session);
                return Redirect("/Employee");
            }
            Console.WriteLine("no users found");
            return View(user);
        }



        public async Task<IActionResult> Index()
        {
            if(new Utility(this._accessor).IsAuthorisedEmployee()==true||new Utility(this._accessor).IsAuthorisedAdmin()==true)
            {
                var user = await _context.Employee
                    .FirstOrDefaultAsync(m => m.emp_email == HttpContext.Session.GetString("logged_in_user"));
                return View(user);
            }
            return Redirect("/Employee/Login");
        }

        // GET: Employee/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (new Utility(_accessor).IsAuthorisedAdmin())
            {
                if (id == null)
                {
                    return NotFound();
                }

                var employee = await _context.Employee
                    .FirstOrDefaultAsync(m => m.emp_id == id);
                if (employee == null)
                {
                    return NotFound();
                }

                return View(employee);
            }
            return Redirect("/Employee/login");
        }

        // GET: Employee/Create
        public IActionResult Create()
        {
            if (new Utility(_accessor).IsAuthorisedAdmin())
            {
                return View();
            }
            return Redirect("/Employee/login");
        }

        // POST: Employee/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("emp_id,emp_name,emp_role,emp_address,emp_city,emp_email,emp_password")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employee/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (new Utility(_accessor).IsAuthorisedAdmin())
            {
                if (id == null)
                {
                    return NotFound();
                }

                var employee = await _context.Employee.FindAsync(id);
                if (employee == null)
                {
                    return NotFound();
                }
                return View(employee);
            }
            return Redirect("/Employee/login");
        }

        // POST: Employee/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("emp_id,emp_name,emp_role,emp_address,emp_city,emp_email,emp_password")] Employee employee)
        {
            if (id != employee.emp_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.emp_id))
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
            return View(employee);
        }

        // GET: Employee/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (new Utility(_accessor).IsAuthorisedAdmin())
            {
                if (id == null)
                {
                    return NotFound();
                }

                var employee = await _context.Employee
                    .FirstOrDefaultAsync(m => m.emp_id == id);
                if (employee == null)
                {
                    return NotFound();
                }

                return View(employee);
            }
            return Redirect("/Employee/login");

        }

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employee.FindAsync(id);
            _context.Employee.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Elist()
        {
            if (new Utility(_accessor).IsAuthorisedAdmin())
            {
                return View(await _context.Employee.ToListAsync());
            }
            return Redirect("/Employee/Login");
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employee.Any(e => e.emp_id == id);
        }
    }
}
