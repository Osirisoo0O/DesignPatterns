using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = SimpleCarFactory.CreateCar("BMW");
            car1.Assemble();
            Console.WriteLine("---------------------------");
            var car2 = SimpleCarFactory.CreateCar("Ford");
            car2.Assemble();
            Console.WriteLine("--------------------------------------------------------------------------");
            var factory1 = new BMWCarFactory();
            var car3 =factory1.Assemble();
            car3.Assemble();
            Console.WriteLine("---------------------------");
            var factory2 = new FordCarFactory();
            var car4 = factory2.Assemble();
            car4.Assemble();

            Console.ReadKey();
        }
    }
}
