using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryMethod
{
    public class BigCarFactory : AbstractFactory
    {
        public override Shell CreateShell()
        {
            return new RectangleShell();
        }

        public override Wheel CreateWheel()
        {
            return new BigWheel();
        }
    }
}
