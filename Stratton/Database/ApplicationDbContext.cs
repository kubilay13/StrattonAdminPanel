using Microsoft.EntityFrameworkCore;
using Stratton.Models.AdminModels;
using Stratton.Models.AdminModels.CryptoWalletModels;

namespace Stratton.Database
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<AdminUser> AdminUsers { get; set; }

        public DbSet<ModeratorUser> moderatorUsers { get; set; }

        public DbSet<PremiumUser> premiumUsers { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<AboutUs> Aboutss { get; set; }

        public DbSet<ContactUs> Contacts { get; set; }
        public DbSet<IdentityCategory> IdentityCategories { get; set; }

        public DbSet<WebIdentity> webIdentities { get; set; }

        public DbSet<TronWalletModels> TronWalletModelss { get; set; }
    }
}
