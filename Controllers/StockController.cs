using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using restapi.Models;
using restapi.StockData;

namespace restapi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class StockController : Controller
    {
        private IStockData _stockData;
        public StockController(IStockData stockData)
        {
            _stockData = stockData;
        }

        [HttpGet]
        [Route("api/[controller]")]

        public IActionResult GetStocks()
        {
            return Ok(_stockData.GetStocks());
        }

        [HttpGet]
        [Route("api/[controller]")]

        public IActionResult GetStocks(Guid id)
        {
            var stock = _stockData.GetStock(id);
            if (stock != null)
            {
                return Ok(stock);
            }

            return NotFound("Stock Not found");
        }


        [HttpPost]
        [Route("api/[controller]")]

        public IActionResult GetStocks(Stock stock)
        {
            _stockData.AddStock(stock);
            return Created(HttpContext.Request.Scheme + stock.id, stock);
        }

        [HttpPatch]
        [Route("api/[controller]")]

        public IActionResult EditStock(Guid id, Stock stock)
        {
            var existingstock = _stockData.GetStock(id);
            if (existingstock != null)
            {
                stock.id = existingstock.id;
                _stockData.EditStock(stock);
            }
                return Ok(stock);
            
        }

        //[HttpGet]
        //public IEnumerable<IStockData> GetStocks(Guid id)
        //{
        //    return GetStocks();
        //}
    }
}