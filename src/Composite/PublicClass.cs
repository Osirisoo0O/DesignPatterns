using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
   public abstract class Graphics
    {
        public string Name { get; set; }

        public Graphics(string name)
        {
            this.Name = name;
        }

        public abstract void Draw();
        //public abstract void Add(Graphics g);
        //public abstract void Remove(Graphics g);
    }

    public class Line : Graphics
    {

        public Line(string name):base(name)
        {

        }

        public override void Draw()
        {
            Console.WriteLine("画" + Name);
        }
        //public override void Add(Graphics g)
        //{
        //    throw new Exception("不能向简单图形Line添加其他图形");
        //}

        //public override void Remove(Graphics g)
        //{
        //    throw new Exception("不能向简单图形Line移除其他图形");
        //}
    }

    public class Circle : Graphics
    {
        public Circle(string name):base(name)
        {

        }
        public override void Draw()
        {
            Console.WriteLine("画"+Name);
        }

        //public override void Add(Graphics g)
        //{
        //    throw new Exception("不能向简单图形Circle添加其他图形");
        //}


        //public override void Remove(Graphics g)
        //{
        //    throw new Exception("不能向简单图形Circle移除其他图形");
        //}
    }

    public class ComplexGraphics : Graphics
    {
        private readonly List<Graphics> Graphicses = new List<Graphics>();
        public ComplexGraphics(string name):base(name)
        {

        }


        public override void Draw()
        {
            foreach (var item in Graphicses)
            {
                item.Draw();
            }
        }
        public void Add(Graphics g)
        {
            Graphicses.Add(g);
        }

        public void Remove(Graphics g)
        {
            Graphicses.Remove(g);
        }
    }
}
