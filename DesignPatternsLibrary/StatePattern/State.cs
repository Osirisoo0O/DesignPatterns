using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.StatePattern
{
    /// <summary>
    /// 状态接口
    /// </summary>
   public abstract class State
    {
        protected Context _Context = null;
        public State(Context context)
        {
            _Context = context;
        }
        /// <summary>
        /// 通用执行方法
        /// </summary>
        /// <param name="value"></param>
        public abstract void handle(int value);
    }
}
