using System;

namespace Adapter
{
    class Auto : ITransport
    {
        public Auto()
        {
            Console.WriteLine("Машина едет по дороге");
        }
        public void Drive()
        {
            Console.WriteLine("Теперь я еду на машине.");
        }
    }
}
