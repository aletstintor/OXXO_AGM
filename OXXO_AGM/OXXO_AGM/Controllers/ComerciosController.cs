using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OXXO_AGM.Models;

namespace OXXO_AGM.Controllers
{
    public class ComerciosController : Controller
    {
        private readonly AGM_NUEVAContext _context;

        public ComerciosController(AGM_NUEVAContext context)
        {
            _context = context;
        }

        // GET: Comercios
        public async Task<IActionResult> Index()
        {
            var aGM_NUEVAContext = _context.Comercios.Include(c => c.IdBancoNavigation).Include(c => c.IdClusterNavigation).Include(c => c.IdCompaniaNavigation).Include(c => c.IdEstatusNavigation).Include(c => c.IdGiroComercioNavigation).Include(c => c.IdTipoDepositoNavigation);
            return View(await aGM_NUEVAContext.ToListAsync());
        }

        // GET: Comercios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Comercios == null)
            {
                return NotFound();
            }

            var comercio = await _context.Comercios
                .Include(c => c.IdBancoNavigation)
                .Include(c => c.IdClusterNavigation)
                .Include(c => c.IdCompaniaNavigation)
                .Include(c => c.IdEstatusNavigation)
                .Include(c => c.IdGiroComercioNavigation)
                .Include(c => c.IdTipoDepositoNavigation)
                .FirstOrDefaultAsync(m => m.IdComercio == id);
            if (comercio == null)
            {
                return NotFound();
            }

            return View(comercio);
        }

        // GET: Comercios/Create
        public IActionResult Create()
        {
            ViewData["IdBanco"] = new SelectList(_context.Bancos, "IdBanco", "IdBanco");
            ViewData["IdCluster"] = new SelectList(_context.Clusters, "IdCluster", "IdCluster");
            ViewData["IdCompania"] = new SelectList(_context.Companias, "IdCompania", "IdCompania");
            ViewData["IdEstatus"] = new SelectList(_context.Estatus, "IdEstatus", "IdEstatus");
            ViewData["IdGiroComercio"] = new SelectList(_context.GiroComercios, "IdGiroComercio", "IdGiroComercio");
            ViewData["IdTipoDeposito"] = new SelectList(_context.TipoDepositos, "IdTipoDeposito", "IdTipoDeposito");
            return View();
        }

        // POST: Comercios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdComercio,IdEmisor,Rfc,NombreCompleto,Telefono,Correo,Direccion,CuentaDeposito,IdBanco,RazonSocial,NombreComercial,IdGiroComercio,Portal,PersonaMoral,PersonaFisica,IdEstatus,IdCompania,IdTipoDeposito,IdCluster,EmailConfirmado,IdMerchant,Activo,UsuarioFai,Fai,UsuarioFum,Fum")] Comercio comercio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(comercio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdBanco"] = new SelectList(_context.Bancos, "IdBanco", "IdBanco", comercio.IdBanco);
            ViewData["IdCluster"] = new SelectList(_context.Clusters, "IdCluster", "IdCluster", comercio.IdCluster);
            ViewData["IdCompania"] = new SelectList(_context.Companias, "IdCompania", "IdCompania", comercio.IdCompania);
            ViewData["IdEstatus"] = new SelectList(_context.Estatus, "IdEstatus", "IdEstatus", comercio.IdEstatus);
            ViewData["IdGiroComercio"] = new SelectList(_context.GiroComercios, "IdGiroComercio", "IdGiroComercio", comercio.IdGiroComercio);
            ViewData["IdTipoDeposito"] = new SelectList(_context.TipoDepositos, "IdTipoDeposito", "IdTipoDeposito", comercio.IdTipoDeposito);
            return View(comercio);
        }

        // GET: Comercios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Comercios == null)
            {
                return NotFound();
            }

            var comercio = await _context.Comercios.FindAsync(id);
            if (comercio == null)
            {
                return NotFound();
            }
            ViewData["IdBanco"] = new SelectList(_context.Bancos, "IdBanco", "IdBanco", comercio.IdBanco);
            ViewData["IdCluster"] = new SelectList(_context.Clusters, "IdCluster", "IdCluster", comercio.IdCluster);
            ViewData["IdCompania"] = new SelectList(_context.Companias, "IdCompania", "IdCompania", comercio.IdCompania);
            ViewData["IdEstatus"] = new SelectList(_context.Estatus, "IdEstatus", "IdEstatus", comercio.IdEstatus);
            ViewData["IdGiroComercio"] = new SelectList(_context.GiroComercios, "IdGiroComercio", "IdGiroComercio", comercio.IdGiroComercio);
            ViewData["IdTipoDeposito"] = new SelectList(_context.TipoDepositos, "IdTipoDeposito", "IdTipoDeposito", comercio.IdTipoDeposito);
            return View(comercio);
        }

        // POST: Comercios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdComercio,IdEmisor,Rfc,NombreCompleto,Telefono,Correo,Direccion,CuentaDeposito,IdBanco,RazonSocial,NombreComercial,IdGiroComercio,Portal,PersonaMoral,PersonaFisica,IdEstatus,IdCompania,IdTipoDeposito,IdCluster,EmailConfirmado,IdMerchant,Activo,UsuarioFai,Fai,UsuarioFum,Fum")] Comercio comercio)
        {
            if (id != comercio.IdComercio)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comercio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComercioExists(comercio.IdComercio))
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
            ViewData["IdBanco"] = new SelectList(_context.Bancos, "IdBanco", "IdBanco", comercio.IdBanco);
            ViewData["IdCluster"] = new SelectList(_context.Clusters, "IdCluster", "IdCluster", comercio.IdCluster);
            ViewData["IdCompania"] = new SelectList(_context.Companias, "IdCompania", "IdCompania", comercio.IdCompania);
            ViewData["IdEstatus"] = new SelectList(_context.Estatus, "IdEstatus", "IdEstatus", comercio.IdEstatus);
            ViewData["IdGiroComercio"] = new SelectList(_context.GiroComercios, "IdGiroComercio", "IdGiroComercio", comercio.IdGiroComercio);
            ViewData["IdTipoDeposito"] = new SelectList(_context.TipoDepositos, "IdTipoDeposito", "IdTipoDeposito", comercio.IdTipoDeposito);
            return View(comercio);
        }

        // GET: Comercios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Comercios == null)
            {
                return NotFound();
            }

            var comercio = await _context.Comercios
                .Include(c => c.IdBancoNavigation)
                .Include(c => c.IdClusterNavigation)
                .Include(c => c.IdCompaniaNavigation)
                .Include(c => c.IdEstatusNavigation)
                .Include(c => c.IdGiroComercioNavigation)
                .Include(c => c.IdTipoDepositoNavigation)
                .FirstOrDefaultAsync(m => m.IdComercio == id);
            if (comercio == null)
            {
                return NotFound();
            }

            return View(comercio);
        }

        // POST: Comercios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Comercios == null)
            {
                return Problem("Entity set 'AGM_NUEVAContext.Comercios'  is null.");
            }
            var comercio = await _context.Comercios.FindAsync(id);
            if (comercio != null)
            {
                _context.Comercios.Remove(comercio);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ComercioExists(int id)
        {
          return (_context.Comercios?.Any(e => e.IdComercio == id)).GetValueOrDefault();
        }
    }
}
