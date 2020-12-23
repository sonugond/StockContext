using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using restapi.Models;
using restapi.stockContext;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;

namespace restapi.StockData
{
    public class SqlStockData : IStockData
    {
        
        private StockContext _stockContext;

        public SqlStockData(StockContext stockContext)
        {
            _stockContext = stockContext;
        }
        public void AddStock(Stock stock)
        {
            stock.id = Guid.NewGuid();
            _stockContext.Stocks.Add(stock);
            _stockContext.SaveChanges();
            
            //throw new NotImplementedException();
        }

        public void DeleteStock(Stock stock)
        {
            throw new NotImplementedException();
        }

        public Stock EditStock(Stock stock)
        {
            var existingstock = _stockContext.Stocks.find(stock.id);
            if (existingstock != null)
            {
                _stockContext.Stocks.Update(stock.id);
                _stockContext.SaveChanges();
                return stock;
            }
            
            //throw new NotImplementedException();
        }

        public Stock GetStock(Guid id)
        {
            var stock1 = _stockContext.Stocks.Find(id);
            return stock1;
            //throw new NotImplementedException();
        }

        public List<Stock> GetStocks()
        {
            return _stockContext.Stocks.Tolist();
            //throw new NotImplementedException();
        }
    }
}
