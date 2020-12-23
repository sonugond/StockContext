using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using restapi.Models;

namespace restapi.Models
{
    public class Stock
    {
        
        public Guid id { get; set; }

        public string name { get; set; }

        public float price { get; set; }

        public DateTime lastupdated { get; set; }

        internal void Add(Stock stock)
        {
            throw new NotImplementedException();
        }
    }
}
