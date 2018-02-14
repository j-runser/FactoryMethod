using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Product
    {
        protected string str_type;
        protected string str_cpu;
        protected string str_gpu;
        protected string str_ram;

        public string GetType { get { return str_type; } }
        public string GetRAM { get { return str_ram; } }
        public string GetCPU { get { return str_cpu; } }
        public string GetGPU { get { return str_gpu; } }
    }
}
