using Microsoft.EntityFrameworkCore;
using kafer_house.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace kafer_house.Data
{
   public class KaferDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
   {
      public KaferDbContext(DbContextOptions<KaferDbContext> options)
         :base(options)
      {
         
      }
      public DbSet<ShoppingMall> ShoppingMall { get; set; } //this is use to create an reference with table = "Products"
      public DbSet<Branch> Branch { get; set; }

      public DbSet<Product> Product { get; set; }

      public DbSet<CartActual> CartActual { get; set; }
      public DbSet<CartItemActual> CartItemActual { get; set; }

      public DbSet<Delivery> Delivery { get; set; }
      public DbSet<DeliveryItem> DeliberyItem { get; set; }

      public DbSet<Receive> Receive { get; set; }
      public DbSet<ReceiveItem> ReceiveItem { get; set; }

      public DbSet<Manager> Manager { get; set; }
      public DbSet<Staff> Staff { get; set; }
      public DbSet<CarPlate> CarPlate { get; set; }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Config One to One Relationship
            modelBuilder.Entity<Staff>()
                .HasOne<ApplicationUser>(ad => ad.ApplicationUser)
                .WithOne(s => s.Staff)
                .HasForeignKey<Staff>(ad => ad.ApplicationUserId);
            
            modelBuilder.Entity<Manager>()
                .HasOne<ApplicationUser>(ad => ad.ApplicationUser)
                .WithOne(s => s.Manager)
                .HasForeignKey<Manager>(ad => ad.ApplicationUserId);




                
        }

   }
}