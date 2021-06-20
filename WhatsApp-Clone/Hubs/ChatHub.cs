using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using WhatsApp_Clone.Data;
using WhatsApp_Clone.Dtos;

namespace WhatsApp_Clone.Hubs
{
    [Authorize]
    public class ChatHub : Hub
    {
        private readonly WhatsAppDbContext _context;
        public ChatHub(WhatsAppDbContext context)
        {
            _context = context;
        }

        public async Task SendMessage(string target, string user, string message)
        {
            var roomName = _context.Rooms
                .Include(a => a.User1)
                .Include(a => a.User2)
                .Where(a => a.User1.Name == user || a.User2.Name == user).ToString();
            
            await Clients.Group(roomName).SendAsync("ReceiveMessage", new
            {
                message = message,
                roomName = roomName
            });
        }
    }
}