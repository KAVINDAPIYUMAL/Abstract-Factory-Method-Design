using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Method
{
    public class MiniCar : Car
    {
        public MiniCar(Location location) : base(CarType.MINI, location)
        {
            Construct();
        }

        public override void Construct()
        {
            Console.WriteLine("Connecting to Mini car");
        }
    }

}
