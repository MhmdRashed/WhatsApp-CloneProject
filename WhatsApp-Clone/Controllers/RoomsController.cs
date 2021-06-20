using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhatsApp_Clone.Data;
using WhatsApp_Clone.Models;
using Microsoft.EntityFrameworkCore;

namespace WhatsApp_Clone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly WhatsAppDbContext _context;
        public RoomsController(WhatsAppDbContext Context)
        {
            _context = Context;

        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RoomModel>>> Get()
        {
            var rooms = await _context.Rooms.ToListAsync();
            return Ok(rooms);
        }
    /*    [HttpGet("{id}")]
        public async Task<ActionResult<RoomModel>> Get(int id)
        {
            var room = await _context.Rooms.FindAsync(id);
            if (room == null)
                return NotFound();

        }*/
/*        [HttpPost]
*/

    } 
}
