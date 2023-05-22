using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shoppingAPI.Models.EF;

namespace shoppingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class customersController : ControllerBase
    {
        private readonly ShoppingDbapiContext _context = new ShoppingDbapiContext();

        //public customersController(ShoppingDbapiContext context)
        //{
        //    _context = context;
        //}

        // GET: api/customers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomersList>>> GetCustomersLists()
        {
          if (_context.CustomersLists == null)
          {
              return NotFound();
          }
            return await _context.CustomersLists.ToListAsync();
        }

        // GET: api/customers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomersList>> GetCustomersList(int id)
        {
          if (_context.CustomersLists == null)
          {
              return NotFound();
          }
            var customersList = await _context.CustomersLists.FindAsync(id);

            if (customersList == null)
            {
                return NotFound();
            }

            return customersList;
        }

        // PUT: api/customers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomersList(int id, CustomersList customersList)
        {
            if (id != customersList.CId)
            {
                return BadRequest();
            }

            _context.Entry(customersList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomersListExists(id))
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

        // POST: api/customers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CustomersList>> PostCustomersList(CustomersList customersList)
        {
          if (_context.CustomersLists == null)
          {
              return Problem("Entity set 'ShoppingDbapiContext.CustomersLists'  is null.");
          }
            _context.CustomersLists.Add(customersList);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CustomersListExists(customersList.CId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCustomersList", new { id = customersList.CId }, customersList);
        }

        // DELETE: api/customers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomersList(int id)
        {
            if (_context.CustomersLists == null)
            {
                return NotFound();
            }
            var customersList = await _context.CustomersLists.FindAsync(id);
            if (customersList == null)
            {
                return NotFound();
            }

            _context.CustomersLists.Remove(customersList);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CustomersListExists(int id)
        {
            return (_context.CustomersLists?.Any(e => e.CId == id)).GetValueOrDefault();
        }
    }
}
