using AlbumPrinter.Core.Models;
using AlbumPrinter.Test.TestData;
using System;
using System.Collections.Generic;
using Xunit;

namespace AlbumPrinter.Test.UnitTests
{
    public class OrderTests
    {
        [Fact]
        public void When_MugCountIsBetween1and4_Expect_RequiredBinWidthIsSame()
        {
            Mug mug = new Mug
            {
                Quantity = 1
            };

            Order order = new Order
            {
                OrderItems = new List<OrderItem>
                {
                    mug
                }
            };

            double requiredBinWidth = order.RequiredBinWidth;

            mug.Quantity++;
            Assert.Equal(requiredBinWidth, order.RequiredBinWidth);

            mug.Quantity++;
            Assert.Equal(requiredBinWidth, order.RequiredBinWidth);

            mug.Quantity++;
            Assert.Equal(requiredBinWidth, order.RequiredBinWidth);
        }

        [Fact]
        public void When_MugCountIsIncreasedFrom4To5_Expect_RequiredBinWidthIncreases()
        {
            const double mugWidth = 94;

            Mug mug = new Mug
            {
                Quantity = 4
            };

            Order order = new Order
            {
                OrderItems = new List<OrderItem>
                {
                    mug
                }
            };

            double requiredBinWidth = order.RequiredBinWidth;

            mug.Quantity++;
            Assert.Equal(requiredBinWidth + mugWidth, order.RequiredBinWidth);
        }

        [Theory]
        [MemberData(nameof(OrderDataGenerator.Get), MemberType = typeof(OrderDataGenerator))]
        public void When_MultipleItemsAreOrdered_Expect_ReturnsCorrectRequiredBinWidth(Order o1, Order o2)
        {
            Assert.Equal(143.7, o1.RequiredBinWidth);
            Assert.Equal(287.4, o2.RequiredBinWidth);
        }
    }
}
