using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppAPIKennzeichen.Data;
using WebAppAPIKennzeichen.Models;

namespace WebAppAPIKennzeichen
{
    [Route("api/[controller]")]
    [ApiController]
    public class KennzeichenInfosController : ControllerBase
    {
        private readonly WebAppAPIKennzeichenContext _context;

        public KennzeichenInfosController(WebAppAPIKennzeichenContext context)
        {
            _context = context;
        }

        // GET: api/KennzeichenInfos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<KennzeichenInfo>>> GetKennzeichenInfo()
        {
            return await _context.KennzeichenInfo.ToListAsync();
        }

        // GET: api/KennzeichenInfos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<KennzeichenInfo>> GetKennzeichenInfo(int id)
        {
            var kennzeichenInfo = await _context.KennzeichenInfo.FindAsync(id);

            if (kennzeichenInfo == null)
            {
                return NotFound();
            }

            return kennzeichenInfo;
        }

        // PUT: api/KennzeichenInfos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKennzeichenInfo(int id, KennzeichenInfo kennzeichenInfo)
        {
            if (id != kennzeichenInfo.Id)
            {
                return BadRequest();
            }

            _context.Entry(kennzeichenInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KennzeichenInfoExists(id))
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

        // POST: api/KennzeichenInfos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<KennzeichenInfo>> PostKennzeichenInfo(KennzeichenInfo kennzeichenInfo)
        {
            _context.KennzeichenInfo.Add(kennzeichenInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKennzeichenInfo", new { id = kennzeichenInfo.Id }, kennzeichenInfo);
        }

        // DELETE: api/KennzeichenInfos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKennzeichenInfo(int id)
        {
            var kennzeichenInfo = await _context.KennzeichenInfo.FindAsync(id);
            if (kennzeichenInfo == null)
            {
                return NotFound();
            }

            _context.KennzeichenInfo.Remove(kennzeichenInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool KennzeichenInfoExists(int id)
        {
            return _context.KennzeichenInfo.Any(e => e.Id == id);
        }
    }
}
