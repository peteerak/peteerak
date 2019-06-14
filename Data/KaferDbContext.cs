using Microsoft.EntityFrameworkCore;
using kafer_house.Models;
public class KaferDbContext: DbContext
{
   public KaferDbContext(DbContextOptions<KaferDbContext> option):base(option){

  }
   public DbSet<ShoppingMall> ShoppingMall { get; set; } //this is use to create an reference with table = "Products"
   public DbSet<Branch> Branch { get; set; }

   public DbSet<Product> Product { get; set; }

   public DbSet<CartActual> CartActual { get; set; }
   public DbSet<CartItemActual> CartItemActual { get; set; }

   public DbSet<Delivery> Delivery { get; set; }
   public DbSet<DeliveryItem> DeliberyItem { get; set; }

   public DbSet<Return> Return { get; set; }
   public DbSet<ReturnItem> ReturnItem { get; set; }

   // dotnet aspnet-codegenerator controller -name ReturnController -actions -m Return -dc KaferDbContext -outDir Controllers


}