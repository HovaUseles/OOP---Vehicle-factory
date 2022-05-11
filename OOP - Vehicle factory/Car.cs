using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Vehicle_factory
{
    class Car : Vehicle
    {
        private string registrationNumber;
        private string registrationYear;
        private IEngine engine;

        public void Start() { }


        internal Car() { }

        public Car(string color) { }

        public Car(string color, float size) { }
        protected override void TurnLeft(float degrees)
        {
            
        }

    }
}
