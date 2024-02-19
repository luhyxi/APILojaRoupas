﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LojaRoupas.Infra;
using LojaRoupas.Models;

namespace LojaRoupas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoupaPecasController : ControllerBase
    {
        private readonly LojaContext _context;

        public RoupaPecasController(LojaContext context)
        {
            _context = context;
        }

        // GET: api/RoupaPecas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RoupaPeca>>> GetRoupas()
        {
            return await _context.Roupas.ToListAsync();
        }

        // GET: api/RoupaPecas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RoupaPeca>> GetRoupaPeca(int id)
        {
            var roupaPeca = await _context.Roupas.FindAsync(id);

            if (roupaPeca == null)
            {
                return NotFound();
            }

            return roupaPeca;
        }

        // PUT: api/RoupaPecas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoupaPeca(int id, RoupaPeca roupaPeca)
        {
            if (id != roupaPeca.RoupaId)
            {
                return BadRequest();
            }

            _context.Entry(roupaPeca).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoupaPecaExists(id))
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

        // POST: api/RoupaPecas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RoupaPeca>> PostRoupaPeca(RoupaPeca roupaPeca)
        {
            _context.Roupas.Add(roupaPeca);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRoupaPeca", new { id = roupaPeca.RoupaId }, roupaPeca);
        }

        // DELETE: api/RoupaPecas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoupaPeca(int id)
        {
            var roupaPeca = await _context.Roupas.FindAsync(id);
            if (roupaPeca == null)
            {
                return NotFound();
            }

            _context.Roupas.Remove(roupaPeca);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RoupaPecaExists(int id)
        {
            return _context.Roupas.Any(e => e.RoupaId == id);
        }
    }
}
