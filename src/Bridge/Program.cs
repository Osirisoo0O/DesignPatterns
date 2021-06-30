using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl rc = new ConcreteRemoteControl
            {
                Implementor = new TCL()
            };
            rc.On();
            rc.SetChannel();
            rc.Off();
            Console.WriteLine("------------------------");

            rc.Implementor = new Samsung();
            rc.On();
            rc.SetChannel();
            rc.Off();
            Console.Read();
        }
    }
}
