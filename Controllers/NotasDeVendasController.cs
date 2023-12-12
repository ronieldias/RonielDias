#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RonielDias.Models;

namespace RonielDias.Controllers
{
    public class NotasDeVendasController : Controller
    {
        private readonly MyDbContext _context;

        public NotasDeVendasController(MyDbContext context)
        {
            _context = context;
        }

        // GET: NotasDeVendas
        public async Task<IActionResult> Index()
        {
            var myDbContext = _context.NotasVendas.Include(n => n.Cliente).Include(n => n.Pagamento).Include(n => n.Transportadora).Include(n => n.Vendedor);
            return View(await myDbContext.ToListAsync());
        }

        // GET: NotasDeVendas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notaVenda = await _context.NotasVendas
                .Include(n => n.Cliente)
                .Include(n => n.Pagamento)
                .Include(n => n.Transportadora)
                .Include(n => n.Vendedor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (notaVenda == null)
            {
                return NotFound();
            }

            return View(notaVenda);
        }

        // GET: NotasDeVendas/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Id");
            ViewData["PagamentoId"] = new SelectList(_context.Pagamentos, "Id", "Id");
            ViewData["TransportadoraId"] = new SelectList(_context.Transportadoras, "Id", "Id");
            ViewData["VendedorId"] = new SelectList(_context.Vendedores, "Id", "Id");
            return View();
        }

        // POST: NotasDeVendas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Data,Tipo,ClienteId,VendedorId,TransportadoraId,PagamentoId")] NotaVenda notaVenda)
        {
            if (ModelState.IsValid)
            {
                _context.Add(notaVenda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Id", notaVenda.ClienteId);
            ViewData["PagamentoId"] = new SelectList(_context.Pagamentos, "Id", "Id", notaVenda.PagamentoId);
            ViewData["TransportadoraId"] = new SelectList(_context.Transportadoras, "Id", "Id", notaVenda.TransportadoraId);
            ViewData["VendedorId"] = new SelectList(_context.Vendedores, "Id", "Id", notaVenda.VendedorId);
            return View(notaVenda);
        }

        // GET: NotasDeVendas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notaVenda = await _context.NotasVendas.FindAsync(id);
            if (notaVenda == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Id", notaVenda.ClienteId);
            ViewData["PagamentoId"] = new SelectList(_context.Pagamentos, "Id", "Id", notaVenda.PagamentoId);
            ViewData["TransportadoraId"] = new SelectList(_context.Transportadoras, "Id", "Id", notaVenda.TransportadoraId);
            ViewData["VendedorId"] = new SelectList(_context.Vendedores, "Id", "Id", notaVenda.VendedorId);
            return View(notaVenda);
        }

        // POST: NotasDeVendas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Data,Tipo,ClienteId,VendedorId,TransportadoraId,PagamentoId")] NotaVenda notaVenda)
        {
            if (id != notaVenda.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(notaVenda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NotaVendaExists(notaVenda.Id))
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
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Id", notaVenda.ClienteId);
            ViewData["PagamentoId"] = new SelectList(_context.Pagamentos, "Id", "Id", notaVenda.PagamentoId);
            ViewData["TransportadoraId"] = new SelectList(_context.Transportadoras, "Id", "Id", notaVenda.TransportadoraId);
            ViewData["VendedorId"] = new SelectList(_context.Vendedores, "Id", "Id", notaVenda.VendedorId);
            return View(notaVenda);
        }

        // GET: NotasDeVendas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notaVenda = await _context.NotasVendas
                .Include(n => n.Cliente)
                .Include(n => n.Pagamento)
                .Include(n => n.Transportadora)
                .Include(n => n.Vendedor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (notaVenda == null)
            {
                return NotFound();
            }

            return View(notaVenda);
        }

        // POST: NotasDeVendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var notaVenda = await _context.NotasVendas.FindAsync(id);
            _context.NotasVendas.Remove(notaVenda);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NotaVendaExists(int id)
        {
            return _context.NotasVendas.Any(e => e.Id == id);
        }
    }
}
