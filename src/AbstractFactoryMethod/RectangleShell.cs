using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryMethod
{
    public class RectangleShell : Shell
    {
        public override void Make()
        {
            Console.WriteLine("-----------RectangleShell done--------------");
        }
    }
}
