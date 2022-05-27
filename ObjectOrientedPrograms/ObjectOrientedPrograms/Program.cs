using System;

namespace ObjectOrientedPrograms
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Select an option\n1. Inventory Data Management\n2. Stock Account Management");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    InventoryDataMain json = new InventoryDataMain();
                    json.MethodToConvert(@"D:\BridgeLabs\ObjectOrientedPrograms\ObjectOrientedPrograms\ObjectOrientedPrograms\InventoryData.json");
                    break;
                case 2:
                    StockDataMain jsonS = new StockDataMain();
                    jsonS.GettingStock(@"D:\BridgeLabs\ObjectOrientedPrograms\ObjectOrientedPrograms\ObjectOrientedPrograms\StockData.json");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }            
        }
    }
}