using Microsoft.EntityFrameworkCore;
using kafer_house.Models;
public class KaferDbContext: DbContext
{
   public KaferDbContext(DbContextOptions<KaferDbContext> option):base(option){

  }
   public DbSet<ShoppingMall> ShoppingMall { get; set; } //this is use to create an reference with table = "Products"
   public DbSet<Branch> Branch { get; set; }

   public DbSet<Product> Product { get; set; }

   public DbSet<DeliveryReturn> DeliveryReturn { get; set; }
   public DbSet<SaleOrder> SaleOrders { get; set; }
   public DbSet<ActualSold> ActualSold { get; set; }

   public DbSet<CartActual> CartActual {get;set;}
   public DbSet<CartItemActual> CartItemActual {get;set;}



}