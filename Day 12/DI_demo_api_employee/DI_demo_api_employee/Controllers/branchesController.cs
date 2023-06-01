﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DI_demo_api_employee.Models.EF;

namespace DI_demo_api_employee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class branchesController : ControllerBase
    {
        private readonly BankingDbContext _context;

        public branchesController(BankingDbContext context)
        {
            _context = context;
        }

        // GET: api/branches
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BranchInfo>>> GetBranchInfos()
        {
          if (_context.BranchInfos == null)
          {
              return NotFound();
          }
            return await _context.BranchInfos.ToListAsync();
        }

        // GET: api/branches/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BranchInfo>> GetBranchInfo(int id)
        {
          if (_context.BranchInfos == null)
          {
              return NotFound();
          }
            var branchInfo = await _context.BranchInfos.FindAsync(id);

            if (branchInfo == null)
            {
                return NotFound();
            }

            return branchInfo;
        }

        // PUT: api/branches/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBranchInfo(int id, BranchInfo branchInfo)
        {
            if (id != branchInfo.BrNo)
            {
                return BadRequest();
            }

            _context.Entry(branchInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BranchInfoExists(id))
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

        // POST: api/branches
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BranchInfo>> PostBranchInfo(BranchInfo branchInfo)
        {
          if (_context.BranchInfos == null)
          {
              return Problem("Entity set 'BankingDbContext.BranchInfos'  is null.");
          }
            _context.BranchInfos.Add(branchInfo);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (BranchInfoExists(branchInfo.BrNo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetBranchInfo", new { id = branchInfo.BrNo }, branchInfo);
        }

        // DELETE: api/branches/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBranchInfo(int id)
        {
            if (_context.BranchInfos == null)
            {
                return NotFound();
            }
            var branchInfo = await _context.BranchInfos.FindAsync(id);
            if (branchInfo == null)
            {
                return NotFound();
            }

            _context.BranchInfos.Remove(branchInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BranchInfoExists(int id)
        {
            return (_context.BranchInfos?.Any(e => e.BrNo == id)).GetValueOrDefault();
        }
    }
}
