using System;

namespace AbstractFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory1 = new BigCarFactory();
            var wheel1 = factory1.CreateWheel();
            wheel1.Make();
            var shell1 = factory1.CreateShell();
            shell1.Make();
            Console.WriteLine("-------------------------------");
            var factory2 = new SmallCarFactory();
            var wheel2 = factory2.CreateWheel();
            wheel2.Make();
            var shell2 = factory2.CreateShell();
            shell2.Make();
            Console.ReadKey();
        }
    }
}
