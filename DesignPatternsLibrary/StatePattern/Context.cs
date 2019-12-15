using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.StatePattern
{
    /// <summary>
    /// 状态拥有者
    /// </summary>
   public class Context
    {
        State _State = null;
        /// <summary>
        /// 状态方法调用
        /// </summary>
        /// <param name="value"></param>
        public void Request(int value)
        {
            _State.handle(value);
        }
        /// <summary>
        /// 状态设置
        /// </summary>
        /// <param name="theState"></param>
        public void SetState(State theState)
        {
            _State = theState;
        }
    }
}
