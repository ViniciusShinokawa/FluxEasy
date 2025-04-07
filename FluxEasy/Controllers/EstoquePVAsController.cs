using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FluxEasy.Data;
using FluxEasy.Entities;

namespace FluxEasy.Controllers
{
    public class EstoquePVAsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EstoquePVAsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: EstoquePVAs
        public async Task<IActionResult> Index()
        {
            return View(await _context.EstoquePVA.ToListAsync());
        }

        // GET: EstoquePVAs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estoquePVA = await _context.EstoquePVA
                .FirstOrDefaultAsync(m => m.Id == id);
            if (estoquePVA == null)
            {
                return NotFound();
            }

            return View(estoquePVA);
        }

        // GET: EstoquePVAs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EstoquePVAs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdProduto,Entrada,Produtos,Local,Lote,Frascos,Galoes,Bc10,Bc50")] EstoquePVA estoquePVA)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estoquePVA);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estoquePVA);
        }

        // GET: EstoquePVAs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estoquePVA = await _context.EstoquePVA.FindAsync(id);
            if (estoquePVA == null)
            {
                return NotFound();
            }
            return View(estoquePVA);
        }

        // POST: EstoquePVAs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdProduto,Entrada,Produtos,Local,Lote,Frascos,Galoes,Bc10,Bc50")] EstoquePVA estoquePVA)
        {
            if (id != estoquePVA.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estoquePVA);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstoquePVAExists(estoquePVA.Id))
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
            return View(estoquePVA);
        }

        // GET: EstoquePVAs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estoquePVA = await _context.EstoquePVA
                .FirstOrDefaultAsync(m => m.Id == id);
            if (estoquePVA == null)
            {
                return NotFound();
            }

            return View(estoquePVA);
        }

        // POST: EstoquePVAs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var estoquePVA = await _context.EstoquePVA.FindAsync(id);
            if (estoquePVA != null)
            {
                _context.EstoquePVA.Remove(estoquePVA);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstoquePVAExists(int id)
        {
            return _context.EstoquePVA.Any(e => e.Id == id);
        }
    }
}
