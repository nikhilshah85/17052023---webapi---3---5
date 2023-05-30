using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shoppingAPI_Azure.Models.EF;

namespace shoppingAPI_Azure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class mproductsController : ControllerBase
    {
        private readonly ShoppingDbContext _context = new ShoppingDbContext();

        //public mproductsController(ShoppingDbContext context)
        //{
        //    _context = context;
        //}

        // GET: api/mproducts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MProductList>>> GetMProductLists()
        {
          if (_context.MProductLists == null)
          {
              return NotFound();
          }
            return await _context.MProductLists.ToListAsync();
        }

        // GET: api/mproducts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MProductList>> GetMProductList(int id)
        {
          if (_context.MProductLists == null)
          {
              return NotFound();
          }
            var mProductList = await _context.MProductLists.FindAsync(id);

            if (mProductList == null)
            {
                return NotFound();
            }

            return mProductList;
        }

        // PUT: api/mproducts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMProductList(int id, MProductList mProductList)
        {
            if (id != mProductList.PId)
            {
                return BadRequest();
            }

            _context.Entry(mProductList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MProductListExists(id))
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

        // POST: api/mproducts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MProductList>> PostMProductList(MProductList mProductList)
        {
          if (_context.MProductLists == null)
          {
              return Problem("Entity set 'ShoppingDbContext.MProductLists'  is null.");
          }
            _context.MProductLists.Add(mProductList);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MProductListExists(mProductList.PId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMProductList", new { id = mProductList.PId }, mProductList);
        }

        // DELETE: api/mproducts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMProductList(int id)
        {
            if (_context.MProductLists == null)
            {
                return NotFound();
            }
            var mProductList = await _context.MProductLists.FindAsync(id);
            if (mProductList == null)
            {
                return NotFound();
            }

            _context.MProductLists.Remove(mProductList);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MProductListExists(int id)
        {
            return (_context.MProductLists?.Any(e => e.PId == id)).GetValueOrDefault();
        }
    }
}
