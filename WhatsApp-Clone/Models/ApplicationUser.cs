using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhatsApp_Clone.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string  Name { get; set; }
       // public string   { get; set; }
        public string Password { get; set; }
       


    }
    
}
