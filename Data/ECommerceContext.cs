using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Project.Models;
using System.Drawing;

namespace Final_Project.Data
{
    public class ECommerceContext:DbContext
    {
        public DbSet<Users> Users { get; set; } = null;
        public DbSet<Products> Products { get; set; } = null;
        public DbSet<Cart> Carts { get; set; } = null;
        public DbSet<Order> Orders { get; set; } = null;
        public DbSet<OrderProduct> OrderProducts { get; set; } = null;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = Nardos - Zerihun; Initial Catalog = dbEcommerce; Integrated Security = True; Trust Server Certificate = True");
        }
    }
}
