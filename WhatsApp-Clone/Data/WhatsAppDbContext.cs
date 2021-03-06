using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhatsApp_Clone.Models;

namespace WhatsApp_Clone.Data
{
    public class WhatsAppDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public WhatsAppDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        
        
        public DbSet<RoomModel> Rooms { get; set; }
        public DbSet<MessageModel> Messages { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          /*  modelBuilder.Entity<MessageModel>()
				.HasOne<ApplicationUser>(m => m.Sender)
				.WithMany(user => user.Messages)
				.HasForeignKey(m => m.SenderId);

			modelBuilder.Entity<MessageModel>()
				.HasOne<ApplicationUser>(m => m.Recevier)
				.WithMany(user => user.Messages)
				.HasForeignKey(m => m.RecevierId);*/

			base.OnModelCreating(modelBuilder);
        }
        
    }
}
