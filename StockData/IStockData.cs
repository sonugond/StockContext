using restapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restapi.StockData
{
    public interface IStockData
    {
        List<Stock> GetStocks();

        Stock GetStock(Guid id);

        void AddStock(Stock stock);

        void DeleteStock(Stock stock);

        Stock EditStock(Stock stock);

    }
}
