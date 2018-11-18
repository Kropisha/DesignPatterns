using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class ModernCoffeTable : CoffeTable
    {
        public override void forDinner()
        {
            Console.WriteLine("No food on it.");
        }

        public override void hasLegs()
        {
            Console.WriteLine("Has 2 legs.");
        }

        public override void sitOn()
        {
            Console.WriteLine("You can sit on it.");
        }
    }
}
