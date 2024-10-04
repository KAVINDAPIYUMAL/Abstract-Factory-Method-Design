﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Method
{
    public class CarFactory
    {
        private CarFactory()
        {
        }

        public static Car BuildCar(CarType type)
        {
            Location location = Location.INDIA;

            switch (location)
            {
                case Location.USA:
                    return USACarFactory.BuildCar(type);

                case Location.INDIA:
                    return INDIACarFactory.BuildCar(type);

                default:
                    return DefaultCarFactory.BuildCar(type);
            }
        }
    }
}
