using FoodDeliveryApp_API.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliveryApp_API.Data
{
    public class FoodAppDBContext : DbContext
    {
        public FoodAppDBContext() { }
        public FoodAppDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<DeliveryPartner> DeliveryPartners { get; set; }
        public DbSet<UserRole> Roles { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Cuisine> Cuisines { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserRole>()
                .HasData(new UserRole { RoleId = 1, Role = Role.ADMIN }, new UserRole { RoleId = 2, Role = Role.CUSTOMER }, new UserRole { RoleId = 3, Role = Role.DELIVERY_PARTNER });
            modelBuilder.Entity<Cuisine>().HasData(
                new Cuisine { CuisineId = 1, CuisineType = CuisineType.INDIAN },
                new Cuisine { CuisineId = 2, CuisineType = CuisineType.ITALIAN },
                new Cuisine { CuisineId = 3, CuisineType = CuisineType.CHINESE },
                new Cuisine { CuisineId = 4, CuisineType = CuisineType.JAPANESE },
                new Cuisine { CuisineId = 5, CuisineType = CuisineType.MEXICAN },
                new Cuisine { CuisineId = 6, CuisineType = CuisineType.SPANISH },
                new Cuisine { CuisineId = 7, CuisineType = CuisineType.GUJARATI },
                new Cuisine { CuisineId = 8, CuisineType = CuisineType.SOUTHINDIAN },
                new Cuisine { CuisineId = 9, CuisineType = CuisineType.PUNJABI },
                new Cuisine { CuisineId = 10, CuisineType = CuisineType.GUJARATI },
                new Cuisine { CuisineId = 11, CuisineType = CuisineType.RAJASTHANI },
                new Cuisine { CuisineId = 12, CuisineType = CuisineType.BENGALI },
                new Cuisine { CuisineId = 13, CuisineType = CuisineType.MAHARASHTRIAN }
            );

        }
    }
}
