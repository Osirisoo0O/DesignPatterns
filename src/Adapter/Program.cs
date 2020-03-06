using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IThreeHole threehole = new PowerAdapter();
            threehole.Request();
            Console.ReadLine();
        }
    }
}
