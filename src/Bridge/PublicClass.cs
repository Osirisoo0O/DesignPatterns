using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    /// <summary>
    /// 遥控器
    /// </summary>
    public abstract class RemoteControl
    {

        private TV _Implementor;
        /// <summary>
        /// 实现
        /// </summary>
        public TV Implementor
        {
            get { return _Implementor; }
            set
            {
                _Implementor = value;                
            }
        }
        public virtual void On()
        {
            Implementor.On();
        }
        public virtual void Off()
        {
            Implementor.Off();
        }
        public virtual void SetChannel()
        {
            Implementor.TurnChannel();
        }
    }

    /// <summary>
    /// 具体实现
    /// </summary>
    public class ConcreteRemoteControl : RemoteControl
    {
        public override void SetChannel()
        {
            Console.WriteLine("---------------------");
            base.SetChannel();
            Console.WriteLine("---------------------");
        }
    }

    public abstract class TV
    {
        public abstract void On();
        public abstract void Off();
        public abstract void TurnChannel();
    }

    public class TCL : TV
    {
        public override void Off()
        {
            Console.WriteLine("TCL电视关闭了");
        }

        public override void On()
        {
            Console.WriteLine("TCL电视打开了");
        }

        public override void TurnChannel()
        {
            Console.WriteLine("TCL电视换频道");
        }
    }
    public class Samsung : TV
    {
        public override void Off()
        {
            Console.WriteLine("Samsung 电视关闭了");
        }

        public override void On()
        {
            Console.WriteLine("Samsung 电视打开了");
        }

        public override void TurnChannel()
        {
            Console.WriteLine("Samsung 电视换频道");
        }
    }
}
