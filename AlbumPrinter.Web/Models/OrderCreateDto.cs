using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlbumPrinter.Web.Models
{
    public class OrderCreateDto
    {
        public ICollection<OrderItemCreateDto> OrderItems { get; set; }
    }
}