using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    /// <summary>
    /// 猫
    /// </summary>
    public class Cat
    {
        private static Cat instance = null;
        private static readonly object locker = new object();

        /// <summary>
        /// 双层锁实例化
        /// </summary>
        public static Cat Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (locker)
                    {
                        if (instance == null)
                        {
                            instance = new Cat();
                        }
                    }
                }
                return instance;
            }
        }

        /// <summary>
        /// 猫叫
        /// </summary>
        /// <returns></returns>
        public string Miao()
        {
            return "Miao~";
        }
    }
}
