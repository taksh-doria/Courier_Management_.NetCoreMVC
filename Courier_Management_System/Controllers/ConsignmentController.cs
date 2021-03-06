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
    public class ConsignmentController : Controller
    {
        static int cno = 834482;
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _accessor;

        public ConsignmentController(DataContext context,IHttpContextAccessor accessor)
        {
            _context = context;
            _accessor = accessor;
        }

        // GET: Consignment
        public async Task<IActionResult> Index()
        {
            return View(await _context.Consignment_Details.Where(m=>m.user==_accessor.HttpContext.Session.GetString("logged_in_user")).ToListAsync());
        }

        // GET: Consignment/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            Console.WriteLine("here"+id);
            if(id==null)
            {
                return NotFound();
            }
            var consignment_Details = await _context.Consignment_Details
                .FirstOrDefaultAsync(m => m.ID==id);
            if (consignment_Details == null)
            {
                return NotFound();
            }
            Console.WriteLine("found details"+consignment_Details.destination_city);
            return View(consignment_Details);
        }

        // GET: Consignment/Create
        public async Task<IActionResult> Create()
        {
            Boolean value=new Utility(this._accessor).IsAuthorisedClient();
            Console.WriteLine("here "+value);
            if (value==false)
            {
                return Redirect("/User/Login");
            }
            else
            {
                IEnumerable<Courier_Management_System.Models.City> cites = await _context.City.ToListAsync();
                foreach(var item in cites)
                {
                    Console.WriteLine("city: " + item.city_name);
                }
                return View(await _context.City.ToListAsync());
            }
        }

        // POST: Consignment/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(String consignee_name,String city,String address,int pkg_weight_in_grams,String package_type,String package_content)
        {
            Consignment_Details details = new Consignment_Details();
            details.date = DateTime.Now;
            details.Consignee_name = consignee_name;
            details.destination_city =city;
            details.address = address;
            details.package_type = package_type;
            details.pkg_weight_in_grams = pkg_weight_in_grams;
            cno++;
            details.consignment_no = cno;
            details.user = _accessor.HttpContext.Session.GetString("logged_in_user");
            details.package_content = package_content;
            details.amount = 600.0F;

            Consignment_Status status = new Consignment_Status();
            status.consignment_no = details.consignment_no;
            status.date = details.date;
            status.user = details.user;
            status.consignee_name = details.Consignee_name;
            Console.WriteLine("consignment id: " + details);
            if (ModelState.IsValid)
            {
                _context.Add(details);
                _context.Add(status);
                await _context.SaveChangesAsync();

                return Redirect("/User/Profile");
            }
            else
            {
                return Redirect("/User/Profile");
            }
        }
        // GET: Consignment/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consignment_Details = await _context.Consignment_Details.FindAsync(id);
            if (consignment_Details == null)
            {
                return NotFound();
            }
            return View(consignment_Details);
        }

        // POST: Consignment/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("ID,user,package_type,date,destination_city,Consignee_name,address,pkg_weight_in_grams,amount")] Consignment_Details consignment_Details)
        {
            if (id != consignment_Details.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(consignment_Details);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Consignment_DetailsExists(consignment_Details.ID))
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
            return View(consignment_Details);
        }

        // GET: Consignment/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consignment_Details = await _context.Consignment_Details
                .FirstOrDefaultAsync(m => m.ID == id);
            if (consignment_Details == null)
            {
                return NotFound();
            }

            return View(consignment_Details);
        }

        // POST: Consignment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var consignment_Details = await _context.Consignment_Details.FindAsync(id);
            _context.Consignment_Details.Remove(consignment_Details);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Consignment_DetailsExists(long id)
        {
            return _context.Consignment_Details.Any(e => e.ID == id);
        }

        public async Task<IActionResult> Status()
        {
            if (new Utility(_accessor).IsAuthorisedClient())
            {
                return View(await _context.Consignment_Status.Where(s=>s.user==_accessor.HttpContext.Session.GetString("logged_in_user")).ToListAsync());
            }
            return Redirect("/Employee/Login");
        }

        public IActionResult UpdateStatus()
        {
            if(new Utility(_accessor).IsAuthorisedEmployee())
            {
                return View();
            }
            else
            {
                return Redirect("/Employee/Login");
            }
        }
        [HttpPost]
        public  async Task<IActionResult> UpdateStatus(string no,string status)
        {
            Console.WriteLine(no+"number");
            
            var con_status = await _context.Consignment_Status.FirstOrDefaultAsync(m=>m.consignment_no==long.Parse(no));
            con_status.date = DateTime.Now;
            con_status.status = status;
            var city = _context.Employee.FirstOrDefault(m => m.emp_email == _accessor.HttpContext.Session.GetString("logged_in_user"));
            con_status.current_city = city.emp_city;
             _context.Consignment_Status.Update(con_status);
            await _context.SaveChangesAsync();
            return View();
        }
    }
}
