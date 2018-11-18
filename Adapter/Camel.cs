using System;

namespace Adapter
{
    class Camel
    {
        public Camel()
        {
            Console.WriteLine("Верблюд идет по пескам пустыни");
        }

        public void Move()
        {
            Console.WriteLine("Теперь я еду на верблюде.");
        }
    }
}
