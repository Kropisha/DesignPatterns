using System;

namespace DesignPatterns
{
    class ModernFurnitureFactory : FurnitureFactory
    {
        public override Chair createChair()
        {
            ModernChair modernChair = new ModernChair();
            Console.WriteLine("Get your modern chair.");
            return modernChair;
        }

        public override CoffeTable createCoffeTable()
        {
            ModernCoffeTable modernCoffeTable = new ModernCoffeTable();
            Console.WriteLine("Get your modern coffe table.");
            return modernCoffeTable;
        }

        public override Sofa createSofa()
        {
            ModernSofa modernSofa = new ModernSofa();
            Console.WriteLine("Get your modern sofa.");
            return modernSofa;
        }
    }
}
