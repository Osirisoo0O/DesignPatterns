using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    /// <summary>
    /// 手机抽象类
    /// </summary>
    public abstract class Phone
    {
        public abstract void Print();
    }

    public class iPhone : Phone
    {
        public override void Print()
        {
            Console.WriteLine("开始执行具体对象：iPhone");
        }
    }

    public abstract class Decorator : Phone
    {
        private Phone phone;

        public Decorator(Phone p)
        {
            this.phone = p;
        }
        public override void Print()
        {
            if (phone!=null)
            {
                phone.Print();
            }
        }

    }

    public class Sticker : Decorator
    {
        public Sticker(Phone p):base(p)
        {

        }

        public override void Print()
        {
            base.Print();
            AddSticker();
        }

        private void AddSticker()
        {
            Console.WriteLine("iPhone已贴膜");
        }
    }

    public class Accessories : Decorator
    {
        public Accessories(Phone p):base(p)
        {

        }
        public override void Print()
        {
            base.Print();

            AddAccessories();
        }

        private void AddAccessories()
        {
            Console.WriteLine("iPhone已有挂件");
        }
    }









}
