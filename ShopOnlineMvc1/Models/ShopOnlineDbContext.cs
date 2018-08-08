using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using ModelShopOnline.Model;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ShopOnlineMvc1.Models
{

    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            
            return userIdentity;
        }
    }
        public class ShopOnlineDbContext : IdentityDbContext<ApplicationUser>
    {
        public ShopOnlineDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<BuyFactor> BuyFactor { get; set; }
        public virtual DbSet<BuyProduct> BuyProduct { get; set; }
        public virtual DbSet<CommentUser> CommentUser { get; set; }
        public virtual DbSet<DetailProductCarpet> DetailProductCarpet { get; set; }
        public virtual DbSet<DetailProductPainting> DetailProductPainting { get; set; }
        public virtual DbSet<AddressUser> AddressUser { get; set; }

        public static ShopOnlineDbContext Create()
        {
            return new ShopOnlineDbContext();
        }
    }
}