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
    public class ProdutoAcabadosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProdutoAcabadosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProdutoAcabadoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProdutoAcabado.ToListAsync());
        }

        // GET: ProdutoAcabadoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtoAcabado = await _context.ProdutoAcabado
                .FirstOrDefaultAsync(m => m.ProdutoId == id);
            if (produtoAcabado == null)
            {
                return NotFound();
            }

            return View(produtoAcabado);
        }

        // GET: ProdutoAcabadoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProdutoAcabadoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProdutoId,Entrada,Quantidade,Lote,Saida,CodigoCola,Embalagem,Cliente")] ProdutoAcabado produtoAcabado)
        {
            if (ModelState.IsValid)
            {
                _context.Add(produtoAcabado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(produtoAcabado);
        }

        // GET: ProdutoAcabadoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtoAcabado = await _context.ProdutoAcabado.FindAsync(id);
            if (produtoAcabado == null)
            {
                return NotFound();
            }
            return View(produtoAcabado);
        }

        // POST: ProdutoAcabadoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProdutoId,Entrada,Quantidade,Lote,Saida,CodigoCola,Embalagem,Cliente")] ProdutoAcabado produtoAcabado)
        {
            if (id != produtoAcabado.ProdutoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(produtoAcabado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutoAcabadoExists(produtoAcabado.ProdutoId))
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
            return View(produtoAcabado);
        }

        // GET: ProdutoAcabadoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtoAcabado = await _context.ProdutoAcabado
                .FirstOrDefaultAsync(m => m.ProdutoId == id);
            if (produtoAcabado == null)
            {
                return NotFound();
            }

            return View(produtoAcabado);
        }

        // POST: ProdutoAcabadoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var produtoAcabado = await _context.ProdutoAcabado.FindAsync(id);
            if (produtoAcabado != null)
            {
                _context.ProdutoAcabado.Remove(produtoAcabado);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutoAcabadoExists(int id)
        {
            return _context.ProdutoAcabado.Any(e => e.ProdutoId == id);
        }
    }
}
