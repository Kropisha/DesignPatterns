using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class ModernChair : Chair
    {
        public override void hasLegs()
        {
            Console.WriteLine("Has no legs.");
        }

        public override void sitOn()
        {
            Console.WriteLine("You can sit on it.");
        }
    }
}
