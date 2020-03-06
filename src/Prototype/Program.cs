using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            MonkeyKing monkey = new ConcreteClone("MonkeyKing");
            for(int i = 0; i < 10; i++)
            {
            MonkeyKing clone=monkey.Clone() as ConcreteClone;
            Console.WriteLine($"---Cloned{i}:\t{clone.Id}  第{i+1}个");
            }
            Console.ReadKey();
        }
    }
}
