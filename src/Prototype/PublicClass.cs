using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public abstract class MonkeyKing
    {
        public string Id { get; set; }
        public MonkeyKing(string Id)
        {
            this.Id = Id;
        }


        public abstract MonkeyKing Clone();
    }

    public class ConcreteClone : MonkeyKing
    {
        public ConcreteClone(string Id):base(Id)
        {           
        }

        public override MonkeyKing Clone()
        {
            return (MonkeyKing)this.MemberwiseClone(); //浅拷贝
        }
    }
}
