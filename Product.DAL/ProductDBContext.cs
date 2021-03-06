using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Product.Domain.Models;

namespace Product.DataAccess
{
     public class ProductDBContext : DbContext
     {
        public DbSet<Item> Products { get; set; }
        public DbSet<User> Users { get; set; }

        public ProductDBContext(DbContextOptions<ProductDBContext> option) : base(option)
        {
            Database.EnsureCreated();
        }
     }
}
