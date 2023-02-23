using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialProcessing
{
    public class StockFetch
    {
        public void ShowAllStock(string filepath)
        {
            try
            {
                if (File.Exists(filepath))
                {
                    string allStockData = File.ReadAllText(filepath);
                    List<CompanyShares> stockJsonData = JsonConvert.DeserializeObject<List<CompanyShares>>(allStockData);
                    Console.WriteLine("StockName\tNumberofStock\tStockPrice\tStocksValue");
                    foreach (var stock in stockJsonData)
                    {
                        Console.WriteLine(stock.StockName + "\t" + stock.Shares + "\t\t" + stock.SharePrice + "\t\t" + (stock.Shares * stock.SharePrice));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
