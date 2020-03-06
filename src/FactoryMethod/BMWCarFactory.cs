using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class BMWCarFactory : CarFactory
    {
        public override Car Assemble()
        {
            return new BMWCar();
        }
    }
}
