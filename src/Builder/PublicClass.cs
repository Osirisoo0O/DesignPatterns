using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    /// <summary>
    /// 指挥者
    /// </summary>
    public class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartCPU();
            builder.BuildPartMainBoard();
        }
    }
    /// <summary>
    /// 电脑类
    /// </summary>
    public class Computer
    {
        private List<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }
        public void Show()
        {
            Console.WriteLine("电脑开始组装------");
            foreach (var it in parts)
            {
                Console.WriteLine($"组件{it}已安装完成");
            }
            Console.WriteLine("电脑组装完成");
        }
    }

    /// <summary>
    /// 抽象建造者
    /// </summary>
    public abstract class Builder
    {
        // 装CPU
        public abstract void BuildPartCPU();
        // 装主板
        public abstract void BuildPartMainBoard();
        // 当然还有装硬盘，电源等组件，这里省略

        // 获得组装好的电脑
        public abstract Computer GetComputer();
    }

    public class ConcerteBuilder1 : Builder
    {
        Computer computer = new Computer();
        public override void BuildPartCPU()
        {
            computer.Add("Intel Xeon");
        }

        public override void BuildPartMainBoard()
        {
            computer.Add("ASUS X470");
        }

        public override Computer GetComputer()
        {
            return computer;
        }
    }
    public class ConcerteBuilder2 : Builder
    {
        Computer computer = new Computer();
        public override void BuildPartCPU()
        {
            computer.Add("AMD 3950X");
        }

        public override void BuildPartMainBoard()
        {
            computer.Add("MSI X570");
        }

        public override Computer GetComputer()
        {
            return computer;
        }
    }
}

