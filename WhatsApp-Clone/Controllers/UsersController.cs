using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WhatsApp_Clone.Data;

namespace WhatsApp_Clone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly WhatsAppDbContext _context;
        
        

        public UsersController(WhatsAppDbContext context)
        {
            _context = context;
        }
        // GET: api/Users
        [HttpGet("{id}")]
        public async Task<ActionResult> Get()
        {
            var users = await _context.Users.ToListAsync();
            

            return Ok(users);
            
        }

        

        // POST: api/Users
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Users/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
