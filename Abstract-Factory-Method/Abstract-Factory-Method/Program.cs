using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CarFactory.BuildCar(CarType.MICRO));
            Console.WriteLine(CarFactory.BuildCar(CarType.MINI));
            Console.WriteLine(CarFactory.BuildCar(CarType.LUXURY));
            Console.ReadLine();
        }
    }
}
