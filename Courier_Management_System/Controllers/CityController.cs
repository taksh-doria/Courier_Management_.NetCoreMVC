using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Courier_Management_System.Models;
using DataContext = Courier_Management_System.Models.DataContext;
using Courier_Management_System.Filter;
using Microsoft.AspNetCore.Http;
using Courier_Management_System.Data;

namespace Courier_Management_System.Controllers
{
    public class CityController : Controller
    {
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _accessor;
        public CityController(DataContext context, IHttpContextAccessor accessor)
        {
            _accessor = accessor;
            _context = context;
        }

        // GET: City
        public async Task<IActionResult> Index()
        {
            if(new Utility(_accessor).IsAuthorisedAdmin())
            {
                return View(await _context.City.ToListAsync());
            }
            return Redirect("/Employee/Login");
        }

        // GET: City/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (new Utility(_accessor).IsAuthorisedAdmin())
            {
                if (id == null)
                {
                    return NotFound();
                }

                var city = await _context.City
                    .FirstOrDefaultAsync(m => m.city_name == id);
                if (city == null)
                {
                    return NotFound();
                }

                return View(city);
            }
            return Redirect("/Employee/Login");
        }

        // GET: City/Create
        public IActionResult Create()
        {
            if (new Utility(_accessor).IsAuthorisedAdmin())
            {
                return View();
            }
            return Redirect("/Employee/Login");
        }

        // POST: City/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("city_name,State,city_pincode,branch_address")] City city)
        {
            if (new Utility(_accessor).IsAuthorisedAdmin())
            {
                if (ModelState.IsValid)
                {
                    _context.Add(city);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(city);
            }
            return Redirect("/Employee/Login");
        }

        // GET: City/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city = await _context.City.FindAsync(id);
            if (city == null)
            {
                return NotFound();
            }
            return View(city);
        }

        // POST: City/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("city_name,State,city_pincode,branch_address")] City city)
        {
            if (id != city.city_name)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(city);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CityExists(city.city_name))
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
            return View(city);
        }

        // GET: City/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city = await _context.City
                .FirstOrDefaultAsync(m => m.city_name == id);
            if (city == null)
            {
                return NotFound();
            }

            return View(city);
        }

        // POST: City/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var city = await _context.City.FindAsync(id);
            _context.City.Remove(city);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CityExists(string id)
        {
            return _context.City.Any(e => e.city_name == id);
        }
    }
}
