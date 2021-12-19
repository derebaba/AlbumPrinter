using AlbumPrinter.Core.Enums;
using AlbumPrinter.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumPrinter.Core.Models
{
    public class Order
    {
        [Key()]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid OrderID { get; set; }

        [NotMapped]
        public double RequiredBinWidth
        {
            get
            {
                return OrderItems.Sum(oi => oi.RequiredBinWidth);
            }
        }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
