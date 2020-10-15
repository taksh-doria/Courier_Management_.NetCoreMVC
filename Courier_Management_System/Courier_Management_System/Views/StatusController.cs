using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Courier_Management_System.Models;

namespace Courier_Management_System.Views
{
    public class StatusController : Controller
    {
        private readonly StatusContext _context;

        public StatusController(StatusContext context)
        {
            _context = context;
        }

        // GET: Status
        public async Task<IActionResult> Index()
        {
            return View(await _context.Consignment_Status.ToListAsync());
        }

        // GET: Status/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consignment_Status = await _context.Consignment_Status
                .FirstOrDefaultAsync(m => m.pkg_id == id);
            if (consignment_Status == null)
            {
                return NotFound();
            }

            return View(consignment_Status);
        }

        // GET: Status/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Status/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("pkg_id,user,consignee_name,date,status")] Consignment_Status consignment_Status)
        {
            if (ModelState.IsValid)
            {
                _context.Add(consignment_Status);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(consignment_Status);
        }

        // GET: Status/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consignment_Status = await _context.Consignment_Status.FindAsync(id);
            if (consignment_Status == null)
            {
                return NotFound();
            }
            return View(consignment_Status);
        }

        // POST: Status/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("pkg_id,user,consignee_name,date,status")] Consignment_Status consignment_Status)
        {
            if (id != consignment_Status.pkg_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(consignment_Status);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Consignment_StatusExists(consignment_Status.pkg_id))
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
            return View(consignment_Status);
        }

        // GET: Status/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consignment_Status = await _context.Consignment_Status
                .FirstOrDefaultAsync(m => m.pkg_id == id);
            if (consignment_Status == null)
            {
                return NotFound();
            }

            return View(consignment_Status);
        }

        // POST: Status/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var consignment_Status = await _context.Consignment_Status.FindAsync(id);
            _context.Consignment_Status.Remove(consignment_Status);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Consignment_StatusExists(long id)
        {
            return _context.Consignment_Status.Any(e => e.pkg_id == id);
        }
    }
}
