using AlbumPrinter.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumPrinter.Core.Models
{
    public class Cards : OrderItem
    {
        public override ProductType ProductType
        {
            get { return ProductType.cards; }
        }

        public override double RequiredBinWidth
        {
            get { return Quantity * 4.7; }
        }
    }
}
