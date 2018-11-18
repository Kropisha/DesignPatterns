using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    abstract class FurnitureFactory
    {
        public abstract Chair createChair();

        public abstract Sofa createSofa();

        public abstract CoffeTable createCoffeTable();
    }
}
