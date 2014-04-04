using HowManyPointsIsThat.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;


namespace HowManyPointsIsThat.Web.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
         public DbSet<FoodItem> FoodItems {get;set;}
         public DbSet<ConsumedFood> ConsumedFoods { get; set; }

         public ApplicationDbContext()
             : base("DefaultConnection")
        {
        }
    }
}