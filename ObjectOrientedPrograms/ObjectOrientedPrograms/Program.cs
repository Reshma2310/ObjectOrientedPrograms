using System;

namespace ObjectOrientedPrograms
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Json First Program");
            ObjectOrientedPrograms.InventoryDataMain json = new ObjectOrientedPrograms.InventoryDataMain();
            json.MethodToConvert(@"D:\BridgeLabs\ObjectOrientedPrograms\ObjectOrientedPrograms\ObjectOrientedPrograms\InventoryData.json");
        }
    }
}