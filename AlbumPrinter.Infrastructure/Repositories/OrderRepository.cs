using AlbumPrinter.Core.Interfaces;
using AlbumPrinter.Core.Models;
using AlbumPrinter.Infrastructure.Persistence;
using Effort;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumPrinter.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext Context;

        public OrderRepository(AppDbContext context)
        {
            Context = context;
        }

        public Order GetById(Guid id)
        {
            return Context.Orders.SingleOrDefault(o => o.OrderID == id);
        }

        public Order Add(Order order)
        {
            Order insertedOrder = Context.Orders.Add(order);
            Context.SaveChanges();

            return insertedOrder;
        }
    }
}
