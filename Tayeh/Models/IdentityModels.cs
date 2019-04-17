using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;

namespace Tayeh.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string Location { get; set; }
        public byte?[] Image { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TypeOfUser { get; set; }
        public List<LostChildPosts> LostChildPost { get; set; }
        public List<FoundChildPosts> FoundChildPost { get; set; }
        public List<Chatting> Msgs { get; set; }
        public List<Notification> Notif { get; set; }


        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Chatting> Messages { get; set; }
        public DbSet<LostChildPosts> LostChildPosts { get; set; }
        public DbSet<FoundChildPosts> FoundChildPosts { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}