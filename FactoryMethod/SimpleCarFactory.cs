using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    /// <summary>
    /// 负责生产汽车
    /// </summary>
    public class SimpleCarFactory
    {
        public static Car CreateCar(string CarBand)
        {
            Car car = null;
            if (CarBand.Equals("BMW"))
            {
                car = new BMWCar();
            }else if (CarBand.Equals("Ford"))
            {
                car = new FordCar();
            }
            return car;
        }
    }
}
