using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class FordCarFactory : CarFactory
    {
        public override Car Assemble()
        {
            return new FordCar();
        }
    }
}
