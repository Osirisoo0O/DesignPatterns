using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryMethod
{
    public class SmallCarFactory : AbstractFactory
    {
        public override Shell CreateShell()
        {
            return new EllipseShell();
        }

        public override Wheel CreateWheel()
        {
            return new SmallWheel();
        }
    }
}
