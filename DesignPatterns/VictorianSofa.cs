using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class VictorianSofa : Sofa
    {
        public override void canSleep()
        {
            Console.WriteLine("You better sleep in other place.");
        }

        public override void hasLegs()
        {
            Console.WriteLine("Has 4 legs.");
        }

        public override void sitOn()
        {
            Console.WriteLine("You can sit here.");
        }
    }
}
