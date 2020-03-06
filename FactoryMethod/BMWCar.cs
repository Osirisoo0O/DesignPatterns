using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class BMWCar : Car
    {
        public override void Assemble()
        {
            Console.WriteLine($"-----------BMW组装成功-------------");
        }
    }
}
