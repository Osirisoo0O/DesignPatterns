using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexGraphics complex = new ComplexGraphics("一个复杂图形和两条线段");

            complex.Add(new Line("线段A"));
            ComplexGraphics complex1 = new ComplexGraphics("复杂图形");
            complex1.Add(new Circle("圆"));
            complex1.Add(new Line("线段B"));
            complex.Add(complex1);
            Line l = new Line("线段C");
            complex.Add(l); 


            Console.WriteLine("复杂图形画法如下：");
            Console.WriteLine("--------------");
            complex.Draw();
            Console.WriteLine("复杂图形绘制完成");
            Console.WriteLine("--------------");
            Console.WriteLine();

            complex.Remove(l); 
            Console.WriteLine("移除C后复杂图形画法如下：");
            Console.WriteLine("--------------");
            complex.Draw();
            Console.WriteLine("复杂图形绘制完成");
            Console.WriteLine("--------------");
            Console.WriteLine();
        }
    }
}
