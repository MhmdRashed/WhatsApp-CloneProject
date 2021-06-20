using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WhatsApp_Clone.Models
{
    public class MessageModel
    {
        public int Id { get; set; }
        public string Content { set; get; }

        public string UserId { get; set; }
        
        public ApplicationUser User { get; set; }
        public int RoomId { get; set; }
        public RoomModel Room { get; set; }
        
        
    }
}
