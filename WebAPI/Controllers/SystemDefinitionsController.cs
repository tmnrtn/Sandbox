using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DomainObjects;
using EFModel;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SystemDefinitionsController : ControllerBase
    {
        private readonly SystemContext _context;

        public SystemDefinitionsController(SystemContext context)
        {
            _context = context;
        }

        // GET: api/SystemDefinitions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SystemDefinition>>> GetSystemDefinitions()
        {
          if (_context.SystemDefinitions == null)
          {
              return NotFound();
          }
            return await _context.SystemDefinitions.ToListAsync();
        }

        // GET: api/SystemDefinitions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SystemDefinition>> GetSystemDefinition(Guid id)
        {
          if (_context.SystemDefinitions == null)
          {
              return NotFound();
          }
            var systemDefinition = await _context.SystemDefinitions.FindAsync(id);

            if (systemDefinition == null)
            {
                return NotFound();
            }

            return systemDefinition;
        }

        // PUT: api/SystemDefinitions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSystemDefinition(Guid id, SystemDefinition systemDefinition)
        {
            if (id != systemDefinition.Id)
            {
                return BadRequest();
            }

            _context.Entry(systemDefinition).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SystemDefinitionExists(id))
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

        // POST: api/SystemDefinitions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SystemDefinition>> PostSystemDefinition(SystemDefinition systemDefinition)
        {
          if (_context.SystemDefinitions == null)
          {
              return Problem("Entity set 'SystemContext.SystemDefinitions'  is null.");
          }
            _context.SystemDefinitions.Add(systemDefinition);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSystemDefinition), new { id = systemDefinition.Id }, systemDefinition);
        }

        // DELETE: api/SystemDefinitions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSystemDefinition(Guid id)
        {
            if (_context.SystemDefinitions == null)
            {
                return NotFound();
            }
            var systemDefinition = await _context.SystemDefinitions.FindAsync(id);
            if (systemDefinition == null)
            {
                return NotFound();
            }

            _context.SystemDefinitions.Remove(systemDefinition);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SystemDefinitionExists(Guid id)
        {
            return (_context.SystemDefinitions?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
