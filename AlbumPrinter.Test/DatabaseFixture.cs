using Effort;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumPrinter.Test
{
    public class DatabaseFixture : IDisposable
    {
        public DatabaseFixture()
        {
            Db = DbConnectionFactory.CreatePersistent("1");
        }

        public void Dispose()
        {
        }

        public DbConnection Db { get; private set; }
    }
}
