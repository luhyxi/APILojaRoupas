using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LojaRoupas.Infra;
using LojaRoupas.Models.Trade;
using LojaRoupas.Models;

namespace LojaRoupas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransacaoRoupasController : ControllerBase
    {
        private readonly LojaContext _context;
        private readonly VendedorsController _vendedorsController;
        private readonly ClientesController _clientesController;
        private readonly RoupaPecasController _roupaController;

        public TransacaoRoupasController(LojaContext context, VendedorsController vendedorsController, ClientesController clientesController,
            RoupaPecasController roupaController)
        {
            _context = context;
            _roupaController = roupaController;
            _vendedorsController = vendedorsController;
            _clientesController = clientesController;
        }

        // GET: api/TransacaoRoupas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VendaRoupa>>> GetTransacoes()
        {
            return await _context.Vendas.ToListAsync();
        }

        // GET: api/TransacaoRoupas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VendaRoupa>> GetTransacaoRoupa(int id)
        {
            var transacaoRoupa = await _context.Vendas.FindAsync(id);

            if (transacaoRoupa == null)
            {
                return NotFound();
            }

            return transacaoRoupa;
        }

        // PUT: api/TransacaoRoupas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTransacaoRoupa(int id, VendaRoupa transacaoRoupa)
        {
            if (id != transacaoRoupa.TransacaoId)
            {
                return BadRequest();
            }

            _context.Entry(transacaoRoupa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransacaoRoupaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TransacaoRoupas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<VendaRoupa>> PostTransacaoRoupa
            ([FromQuery] int ClienteId, [FromQuery] int VendedorId, [FromQuery] List<int> RoupasIds)
        {
            var clienteResult = await _clientesController.GetCliente(ClienteId);
            var cliente = clienteResult.Value;
            var vendedorResult = await _vendedorsController.GetVendedor(VendedorId);
            var vendedor = vendedorResult.Value;


            List<ActionResult<Roupa>> roupasResult = new List<ActionResult<Roupa>>();
            List<Roupa> roupas = new List<Roupa>();
            foreach (int id in RoupasIds)
            {
                var roupaPeca = await _roupaController.GetRoupaPeca(id);
                roupas.Add(roupaPeca.Value);
            }

            var transacaoRoupa = new VendaRoupa(vendedor, cliente, roupas);

            _context.Vendas.Add(transacaoRoupa);
            await _context.SaveChangesAsync();

            // Return a response (customize this part as needed)
            return CreatedAtAction("GetTransacaoRoupa", new { id = transacaoRoupa.TransacaoId }, transacaoRoupa);
        }





        // DELETE: api/TransacaoRoupas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTransacaoRoupa(int id)
        {
            var transacaoRoupa = await _context.Vendas.FindAsync(id);
            if (transacaoRoupa == null)
            {
                return NotFound();
            }

            _context.Vendas.Remove(transacaoRoupa);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TransacaoRoupaExists(int id)
        {
            return _context.Vendas.Any(e => e.TransacaoId == id);
        }
    }
}
