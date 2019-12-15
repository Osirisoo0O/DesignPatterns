using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.StatePattern
{
    /// <summary>
    /// 具体状态
    /// </summary>
    public class ConcreteState : State
    {
        public override void handle(int value)
        {
            throw new NotImplementedException();
        }
    }
}
