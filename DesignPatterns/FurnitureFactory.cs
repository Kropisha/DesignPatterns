namespace DesignPatterns
{
    abstract class FurnitureFactory
    {
        public abstract Chair createChair();

        public abstract Sofa createSofa();

        public abstract CoffeTable createCoffeTable();
    }
}
