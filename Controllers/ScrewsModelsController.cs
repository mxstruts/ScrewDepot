using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ScrewDepot.Data;
using ScrewDepot.Models;

namespace ScrewDepot.Controllers
{
    public class ScrewsModelsController : Controller
    {
        private readonly ScrewDepotContext _context;

        public ScrewsModelsController(ScrewDepotContext context)
        {
            _context = context;
        }

        // GET: ScrewsModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.ScrewsModel.ToListAsync());
                                            

            
        }

        // GET: ScrewsModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var screwsModel = await _context.ScrewsModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (screwsModel == null)
            {
                return NotFound();
            }

            return View(screwsModel);
        }

        // GET: ScrewsModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ScrewsModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Material,LengthInMillimeters,DiameterInMillimeters,Price,StockQuantity,Manufacturer")] ScrewsModel screwsModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(screwsModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(screwsModel);
        }

        // GET: ScrewsModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var screwsModel = await _context.ScrewsModel.FindAsync(id);
            if (screwsModel == null)
            {
                return NotFound();
            }
            return View(screwsModel);
        }

        // POST: ScrewsModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Material,LengthInMillimeters,DiameterInMillimeters,Price,StockQuantity,Manufacturer")] ScrewsModel screwsModel)
        {
            if (id != screwsModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(screwsModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScrewsModelExists(screwsModel.Id))
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
            return View(screwsModel);
        }

        // GET: ScrewsModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var screwsModel = await _context.ScrewsModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (screwsModel == null)
            {
                return NotFound();
            }

            return View(screwsModel);
        }

        // POST: ScrewsModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var screwsModel = await _context.ScrewsModel.FindAsync(id);
            _context.ScrewsModel.Remove(screwsModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScrewsModelExists(int id)
        {
            return _context.ScrewsModel.Any(e => e.Id == id);
        }
    }
}
