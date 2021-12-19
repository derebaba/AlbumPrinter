using AlbumPrinter.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumPrinter.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public AppDbContext(DbConnection connection) : base(connection, false)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Order>().HasMany(o => o.OrderItems);

            //modelBuilder.Entity<OrderItem>().HasKey(oi => new { oi.OrderID, ProductType = (string)oi.ProductType });
        }
    }
}
