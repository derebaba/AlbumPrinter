using AlbumPrinter.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumPrinter.Core.Models
{
    public class Mug : OrderItem
    {
        public override ProductType ProductType
        {
            get { return ProductType.mug; }
        }

        public override double RequiredBinWidth
        {
            get { return (((Quantity - 1) / 4) + 1) * 94; }
        }
    }
}
