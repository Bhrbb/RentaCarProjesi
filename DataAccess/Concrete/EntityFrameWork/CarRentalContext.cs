using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class CarRentalContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-P1SH4NN\SQL; Database = RentaCar_db; Trusted_Connection=true", builder =>
             {
                 builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
             });
            base.OnConfiguring(optionsBuilder);
        }
       /// protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       // {
       //     optionsBuilder.UseSqlServer("your_connection_string", builder =>
       //     {
       //         builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
       //     });
       //     base.OnConfiguring(optionsBuilder);
       // }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }
    }
}
