using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryMethod
{
    public class SmallWheel : Wheel
    {
        public override void Make()
        {
            Console.WriteLine("--------------SmallWheel done----------------");
        }
    }
}
