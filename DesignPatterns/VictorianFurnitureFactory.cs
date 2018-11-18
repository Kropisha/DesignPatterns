using System;
namespace DesignPatterns
{
    class VictorianFurnitureFactory : FurnitureFactory
    {
        public override Chair createChair()
        {
            VictorianChair victorianChair = new VictorianChair();
            Console.WriteLine("Get your victorian chair.");
            return victorianChair;
        }

        public override CoffeTable createCoffeTable()
        {
            VictorianCoffeTable victorianCoffeTable = new VictorianCoffeTable();
            Console.WriteLine("Get your victorian coffe table.");
            return victorianCoffeTable;
        }

        public override Sofa createSofa()
        {
            VictorianSofa victorianSofa = new VictorianSofa();
            Console.WriteLine("Get your victorian sofa.");
            return victorianSofa;
        }
    }
}
