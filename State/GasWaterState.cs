using System;

namespace State
{
    class GasWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Повышаем температуру водяного пара");
        }

        public void Frost(Water water)
        {
            Console.WriteLine("Превращаем пар в жидкость");
            water.State = new LiquidWaterState();
        }
    }
}
