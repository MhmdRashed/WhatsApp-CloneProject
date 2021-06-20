using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WhatsApp_Clone.Models
{
    public class MessageModel
    {
        [Key]
        public int Id { get; set; }
        public string Content { set; get; }
        public string SenderId { get; set; }
        public ApplicationUser Sender { get; set; }

        public string RecevierId { get; set; }
       



        /* [ForeignKey("ApplicationUser")]
         public string SenderId { get; set; }
         //[ForeignKey("ApplicationUser")]
         //public string ReceiverId { get; set; }
         public ApplicationUser Sender { get; set; }
         //public ApplicationUser Receiver { get; set; }

         *//*  public int RoomId { get; set; }
           public RoomModel Room { get; set; }*/


    }
}
