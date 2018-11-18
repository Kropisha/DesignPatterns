using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class ModernSofa : Sofa
    {
        public override void canSleep()
        {
            Console.WriteLine("You can sleep here.");
        }

        public override void hasLegs()
        {
            Console.WriteLine("No legs. It's fashhion.");
        }

        public override void sitOn()
        {
            Console.WriteLine("You can sit here.");
        }
    }
}
