using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Vehicle_factory
{
    class Factory
    {
        public static void Instance() { }

        private Factory() { }

        public Vehicle Create(int type) 
        {
            return new Car();
        }
    }
}
