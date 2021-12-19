using AlbumPrinter.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumPrinter.Core.Interfaces
{
    public interface IOrderRepository
    {
        Order GetById(Guid id);

        Order Add(Order order);
    }
}
