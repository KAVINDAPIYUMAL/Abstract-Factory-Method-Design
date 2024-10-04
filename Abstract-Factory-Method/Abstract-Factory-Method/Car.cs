using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Method
{
    public abstract class Car
    {
        protected Car(CarType model, Location location)
        {
            Model = model;
            Location = location;
        }

        public CarType Model { get; }
        public Location Location { get; }

        public abstract void Construct();

        public override string ToString()
        {
            return $"CarModel - {Model} located in {Location}";
        }
    }
}
