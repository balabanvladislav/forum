using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using MDF;
using MDF.Domain;


namespace MDF.BLogic
{
    
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}