using AlbumPrinter.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumPrinter.Test.TestData
{
    public class OrderDataGenerator
    {
        public static IEnumerable<object[]> Get()
        {
            yield return new object[]
            {
                new Order
                {
                    OrderItems = new List<OrderItem>
                    {
                        new Calendar { Quantity = 1 },
                        new Canvas { Quantity = 1 },
                        new Cards { Quantity = 1 },
                        new Mug { Quantity = 1 },
                        new PhotoBook { Quantity = 1 }
                    }
                },
                new Order
                {
                    OrderItems = new List<OrderItem>
                    {
                        new Calendar { Quantity = 2 },
                        new Canvas { Quantity = 2 },
                        new Cards { Quantity = 2 },
                        new Mug { Quantity = 5 },
                        new PhotoBook { Quantity = 2 }
                    }
                },
            };
        }
    }
}
