using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Laptop : Product
    {
        public Laptop()
        {
            str_type = "Laptop";
            str_cpu = "1.8 GHz, 2 cores";
            str_gpu = "Integrated grapics";
            str_ram = "8 GB";
        }
    }

    class Desktop : Product
    {
        public Desktop()
        {
            str_type = "Desktop";
            str_cpu = "3.4 GHz, 4 cores";
            str_gpu = "8 GB vRAM";
            str_ram = "16 GB";
        }
    }
}
