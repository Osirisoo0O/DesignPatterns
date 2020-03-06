using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryMethod
{
    public class BigWheel : Wheel
    {
        public override void Make()
        {
            Console.WriteLine("------------BigWheel done-------------");
        }
    }
}
