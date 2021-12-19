using AlbumPrinter.Core.Interfaces;
using AlbumPrinter.Core.Models;
using AlbumPrinter.Infrastructure.Persistence;
using AlbumPrinter.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlbumPrinter.Test.IntegrationTests
{
    public class OrderRepositoryTests : IClassFixture<DatabaseFixture>
    {
        IOrderRepository OrderRepository;

        public OrderRepositoryTests(DatabaseFixture fixture)
        {
            OrderRepository = new OrderRepository(new AppDbContext(fixture.Db));
        }

        [Fact]
        public void When_OrderItemQuantityIsZero_Expect_DbEntityValidationException()
        {
            Order order = new Order
            {
                OrderID = new Guid(),
                OrderItems = new List<OrderItem>
                {
                    new PhotoBook
                    {
                        Quantity = 0
                    }
                }
            };

            Assert.Throws<DbEntityValidationException>(() => OrderRepository.Add(order));
        }

        [Fact]
        public void When_OrderIsSaved_Expect_OrderItemsHaveOrdersID()
        {
            Order order = new Order
            {
                OrderItems = new List<OrderItem>
                {
                    new PhotoBook
                    {
                        Quantity = 2
                    },
                    new Mug
                    {
                        Quantity = 3
                    },
                    new Calendar
                    {
                        Quantity = 4
                    }
                }
            };

            OrderRepository.Add(order);

            Guid orderID = order.OrderID;
            foreach (OrderItem item in order.OrderItems)
                Assert.Equal(orderID, item.OrderID);
        }
    }
}
