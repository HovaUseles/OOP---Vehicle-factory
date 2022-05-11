﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Vehicle_factory
{
    abstract class Vehicle
    {

        protected abstract void TurnLeft(float degrees);

        protected void MoveForward() { }
    }
}
