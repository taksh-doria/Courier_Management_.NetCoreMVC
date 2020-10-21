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

namespace Courier_Management_System.Controllers
{
    public class ConsignmentController : Controller
    {
        private readonly DetailsContext _context;
        private readonly IHttpContextAccessor _accessor;

        public ConsignmentController(DetailsContext context,IHttpContextAccessor accessor)
        {
            _context = context;
            _accessor = accessor;
        }

        // GET: Consignment
        public async Task<IActionResult> Index()
        {
            return View(await _context.Consignment_Details.ToListAsync());
        }

        // GET: Consignment/Details/5
        public async Task<IActionResult> Details(long? id)
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

        // GET: Consignment/Create
        public IActionResult Create()
        {
            Boolean value=new Utility(this._accessor).IsAuthorisedClient();
            Console.WriteLine("here "+value);
            if (value==false)
            {
                return Redirect("/User/Login");
            }
            else
            {
                return View();
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
            details.user = _accessor.HttpContext.Session.GetString("logged_in_user");
            details.package_content = package_content;
            details.amount = 600.0F;
            if (ModelState.IsValid)
            {
                _context.Add(details);
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
    }
}
