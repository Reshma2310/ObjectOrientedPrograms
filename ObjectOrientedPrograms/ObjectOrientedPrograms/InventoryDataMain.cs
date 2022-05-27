using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms
{
    internal class InventoryDataMain
    {        
        public void MethodToConvert(string filePath)
        {
            InventoryDataModel model = new InventoryDataModel();
            List<InventoryModel> Rice;
            List<InventoryModel> Wheat;
            List<InventoryModel> Pulses;
            using (StreamReader file = new StreamReader(filePath))
            {                
                var json = file.ReadToEnd();
                InventoryDataModel item = JsonConvert.DeserializeObject<InventoryDataModel>(json);
                Rice = item.Rice;
                Wheat = item.Wheat;
                Pulses = item.Pulses;                
                Console.WriteLine("Enter option to see details\n1. Rice\n2. Wheat\n3. Pulses");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        foreach (var data in Rice)
                        {
                            Console.WriteLine("Name:" + data.Name + ", Price:" + data.Price + ", Weight:" + data.Weight);
                        }
                        break;
                    case 2:
                        foreach (var data in Wheat)
                        {
                            Console.WriteLine("Name:" + data.Name + ", Price:" + data.Price + ", Weight:" + data.Weight);
                        }
                        break;
                    case 3:
                        foreach (var data in Pulses)
                        {
                            Console.WriteLine("Name:" + data.Name + ", Price:" + data.Price + ", Weight:" + data.Weight);
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }
    }
}
