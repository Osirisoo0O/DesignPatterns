using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryMethod
{
    public abstract class AbstractFactory
    {
        public abstract Wheel CreateWheel();

        public abstract Shell CreateShell();

    }
}
