using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    /// <summary>
    /// 抽象工厂
    /// </summary>
    public abstract class CarFactory
    {
        /// <summary>
        /// 组装方法
        /// </summary>
        /// <returns></returns>
        public abstract Car Assemble();        
    }
}
