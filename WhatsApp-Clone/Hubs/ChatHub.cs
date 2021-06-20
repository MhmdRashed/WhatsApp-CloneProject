using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using WhatsApp_Clone.Data;
using WhatsApp_Clone.Dtos;

using Microsoft.AspNetCore.Identity;
using WhatsApp_Clone.Models;

namespace WhatsApp_Clone.Hubs
{
    [Authorize]
    public class ChatHub : Hub
    {
        private readonly WhatsAppDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public ChatHub(WhatsAppDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public override async Task OnConnectedAsync()
        {


            string name = Context.User.Identity.Name;
            await Groups.AddToGroupAsync(Context.ConnectionId, name);

            ///
            var user = await _userManager.GetUserAsync(Context.User);
            //var id = user.Id;

            //get all user messages 
            var messages = await _context.Messages.Include(m => m.Sender.Id == user.Id || m.RecevierId == user.Id).ToListAsync();

            var allMessages = new List<object>();
            foreach (var message in messages)
			{
                var reciever = await _context.Users.FirstOrDefaultAsync(u => u.Id == message.RecevierId);
                allMessages.Add(new
                {
                    sender = message.Sender.Name, content = message.Content, reciever = reciever.Name
                });
			}


            //get all users
            var users = await _context.Users.Select(user => new { user.Name, user.Id }).ToListAsync();


            var allUsers = new List<object>();
            foreach (var u in users)
            {
                allUsers.Add(new
                {
                    id =u.Id,
                    name = u.Name
                });
            }

            await Clients.Group(user.Id).SendAsync("ReceiveData", allUsers, allMessages);
        }

        public async Task SendMessage(string message, string targetUserId)
        {
            string name = Context.User.Identity.Name;
            await Clients.Group(targetUserId).SendAsync("ReceiveMessage", new{
                sender = name,
                content = message
            });

            var user = await _userManager.GetUserAsync(Context.User);
            //save to database 

            MessageModel msg = new MessageModel();
            msg.Content = message;
            msg.SenderId = user.Id;
            msg.RecevierId = targetUserId;
            _context.Messages.Add(msg);
            _context.SaveChanges();
            
        }

        
    }
}