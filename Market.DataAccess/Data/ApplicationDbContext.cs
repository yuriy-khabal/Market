using Market.Models;
using Market.Models;
using Microsoft.EntityFrameworkCore;

namespace Market.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {   
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Category>()
                .HasData(
                    new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                    new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                    new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );

            modelBuilder
                .Entity<Product>()
                .HasData(
                    new Product 
                    { 
                        Id = 1,
                        Tittle = "Fortune of Time",
                        Author = "Billy Spark",
                        Description = "Praesant vitae solades libero.",
                        ISBN = "SWD9999001",
                        ListPrice = 99,
                        Price = 90,
                        Price50 = 85,
                        Price100 = 80,
                        CategoryId = 1,
                        ImageUrl = ""
                    },
                    new Product
                    {
                        Id = 2,
                        Tittle = "Dark Skies",
                        Author = "Nancy Hoover",
                        Description = "Praesant vitae solades libero.",
                        ISBN = "SWD9999001",
                        ListPrice = 99,
                        Price = 90,
                        Price50 = 85,
                        Price100 = 80,
                        CategoryId = 2,
                        ImageUrl = ""
                    },
                    new Product
                    {
                        Id = 3,
                        Tittle = "Vanish in the Sunset",
                        Author = "Julian Button",
                        Description = "Praesant vitae solades libero.",
                        ISBN = "SWD9999001",
                        ListPrice = 99, 
                        Price = 90,
                        Price50 = 85,
                        Price100 = 80,
                        CategoryId = 1,
                        ImageUrl = ""
                    },
                    new Product
                    {
                        Id = 4,
                        Tittle = "Cotton Candy",
                        Author = "Abby Muscles",
                        Description = "Praesant vitae solades libero.",
                        ISBN = "SWD9999001",
                        ListPrice = 99,
                        Price = 90,
                        Price50 = 85,
                        Price100 = 80,
                        CategoryId = 3,
                        ImageUrl = ""
                    },
                    new Product
                    {
                        Id = 5,
                        Tittle = "Rock in the Ocean",
                        Author = "Ron Parker",
                        Description = "Praesant vitae solades libero.",
                        ISBN = "SWD9999001",
                        ListPrice = 99,
                        Price = 90,
                        Price50 = 85,
                        Price100 = 80,
                        CategoryId = 2,
                        ImageUrl = ""
                    },
                    new Product
                    {
                        Id = 6,
                        Tittle = "Leaves and Wonders",
                        Author = "Laura Phantom",
                        Description = "Praesant vitae solades libero.",
                        ISBN = "SWD9999001",
                        ListPrice = 99,
                        Price = 90,
                        Price50 = 85,
                        Price100 = 80,
                        CategoryId = 1,
                        ImageUrl = ""
                    }
                );
        }
    }
}
