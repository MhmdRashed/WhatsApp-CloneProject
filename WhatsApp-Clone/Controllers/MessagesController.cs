using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WhatsApp_Clone.Models;
using WhatsApp_Clone.Data;

namespace WhatsApp_Clone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly WhatsAppDbContext _context;
        
        

        public MessagesController(WhatsAppDbContext context)
        {
            _context = context;
        }
        // GET: api/Messages
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var msg = await _context.Messages.FindAsync(id);
            if (msg == null)
            {
                return NotFound();
            }

            return Ok(msg);
            
        }

        // GET: api/Messages/5
        [HttpGet("Room/{roomName}")]
        public IActionResult GetMsgs(string roomName)
        {
            var room = _context.Rooms.FirstOrDefault(r => r.Name == roomName);
            
            if (room == null)
            {
                return BadRequest();
            }

            var messages = _context.Messages.Where(msg => msg.RoomId == room.Id)
                .Include(msg => msg.UserId)
                .Include(msg => msg.RoomId)
                .ToList();
            return Ok(messages);
        }

        [HttpPost]
        public async Task<ActionResult> Create(MessageModel message)
        {
            var room = _context.Rooms.FirstOrDefault(r =>
                r.Name == message.Room.Name);
            var user = _context.Users.FirstOrDefault(u =>
                u.UserName == User.Identity.Name);

            if (room == null || user == null)
            {
                return BadRequest();
            }

            var msg = new MessageModel()
            {
                Content = message.Content,
                UserId = user.Id,
                RoomId = room.Id
                
            };
            
            _context.Messages.Add(msg);
            _context.SaveChanges();
            return Ok();

        }
    }
}
