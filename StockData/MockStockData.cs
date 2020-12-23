using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using restapi.Models;

namespace restapi.StockData
{
    public class MockStockData : IStockData
    {
        private List<Stock> stock = new List<Stock>()
        {
            new Stock()
            {
                id = Guid.NewGuid(), name ="ONGC", price="12.20"
            },

            new Stock()
            {
                id = Guid.NewGuid(), name ="SBI" price="280.00"
            }
        };
        public void AddStock(Stock stock)
        {
            stock.id = Guid.NewGuid();
            stock.Add(stock);
           // return stock;
            throw new NotImplementedException();
        }

        public void DeleteStock(Stock stock)
        {
            throw new NotImplementedException();
        }

        public Stock EditStock(Stock stock)
        {
            var existingstock = GetStock(stock.id);
            existingstock.name = stock.name;
		 existingstock.price = stock.price;
            return stock;
            //throw new NotImplementedException();
        }

        public Stock GetStock(Guid id)
        {
            return stock.SingleOrDefault(x=> x.id == id);
            throw new NotImplementedException();
        }

        public List<Stock> GetStocks()
        {
            return stock;
        }

    }
}
