using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            VictorianFurnitureFactory victorianFurniture = new VictorianFurnitureFactory();
            victorianFurniture.createSofa();
            victorianFurniture.createCoffeTable();
            Console.WriteLine();

            ModernFurnitureFactory modernFurnitureFactory = new ModernFurnitureFactory();
            modernFurnitureFactory.createChair();

            Console.ReadKey();
        }
    }
}
