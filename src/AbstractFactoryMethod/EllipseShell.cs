using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryMethod
{
    public class EllipseShell : Shell
    {
        public override void Make()
        {
            Console.WriteLine("-----------EllipseShell done-------------");
        }
    }
}
