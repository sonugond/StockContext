using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restapi.stockContext
{
    public class StockContext:DbContext
    {
        public StockContext(DbContextOptions<StockContext> options) : base(options)
        {

        }
        public Dbset<stock> stock { get; set; }
        public object Stocks { get; internal set; }
    }
   
}
