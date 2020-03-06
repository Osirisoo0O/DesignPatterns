using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var b1 = new ConcerteBuilder1();
            var b2 = new ConcerteBuilder2();

            director.Construct(b1);
            var c1 = b1.GetComputer();
            c1.Show();
            director.Construct(b2);
            var c2 = b2.GetComputer();
            c2.Show();

            Console.Read();
        }
    }
}
