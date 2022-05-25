using System;

namespace ObjectOrientedPrograms
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Json First Program");
            InventoryDataMain json = new InventoryDataMain();
            json.Convert(@"D:\BridgeLabs\ObjectOrientedPrograms\ObjectOrientedPrograms\ObjectOrientedPrograms\InventoryData.json");
        }
    }
}