using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ObjectOrientedPrograms
{
    internal class InventoryDataMain
    {
        InventoryDataModel model = new InventoryDataModel();
        List<InventoryDataModel> inventoryDataList = new List<InventoryDataModel> ();

        public void Convert(string filePath)
        {
            using (StreamReader file = new StreamReader(filePath))
            {
                var json = file.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<InventoryDataModel>>(json);

                foreach (var details in items)
                {
                    Console.WriteLine("Name: " + details.Name + " Price: " + details.Price + " Weight: " + details.Weight);
                }
            }
        }
    }
}
