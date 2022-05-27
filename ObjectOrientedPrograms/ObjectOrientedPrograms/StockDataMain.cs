using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms
{
    internal class StockDataMain
    {
        StockModel model = new StockModel();
        List<StockModel> stocksList = new List<StockModel>();
        public void GettingStock(string jFilePath)
        {
            using (StreamReader file = new StreamReader(jFilePath))
            {
                var main = file.ReadToEnd();
                var stock = JsonConvert.DeserializeObject<List<StockModel>>(main);
                double Total = 0;
                foreach (var data in stock)
                {
                    double Value = data.NoOfShares * data.SharePrice;
                    Total += Value;
                    Console.WriteLine("StockName: " + data.StockName + " Number Of Shares: " + data.NoOfShares + " SharePrice: " + data.SharePrice + " Value of the Stock: " + Value);
                }
                Console.WriteLine("Total Value of Stocks are " + Total);
            }
        }
    }
}
