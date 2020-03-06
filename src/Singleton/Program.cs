using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"-------------{Cat.Instance.Miao()}---------------");
            Console.ReadKey();
        }
    }
}
