using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Vehicle_factory
{
    class Bicycle : IBreakable
    {
        private string registrationNumber;

        public Bicycle(int numberOfWheels) { }

        public void Brake() { }
    }
}
