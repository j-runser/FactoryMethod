using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class LaptopFactory : Factory
    {
        public override Product CreateComputer()
        {
            return new Laptop();
        }
    }

    class DesktopFactory : Factory
    {
        public override Product CreateComputer()
        {
            return new Desktop();
        }
    }
}
