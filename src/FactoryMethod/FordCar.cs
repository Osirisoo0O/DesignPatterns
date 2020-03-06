using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class FordCar : Car
    {
        public override void Assemble()
        {
            Console.WriteLine($"-----------Ford组装成功-------------");
        }
    }
}
