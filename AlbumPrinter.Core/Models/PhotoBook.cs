using AlbumPrinter.Core.Enums;
using AlbumPrinter.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumPrinter.Core.Models
{
    public class PhotoBook : OrderItem
    {
        public override ProductType ProductType
        {
            get { return ProductType.photoBook; }
        }

        public override double RequiredBinWidth
        {
            get { return Quantity * 19; }
        }
    }
}
