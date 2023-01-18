using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(string wheels)
        {
            switch (wheels.ToLower())
            { 
                case "4":
                case "four":
                case "Four":
                    return new Car();
                case "2":
                case "two":
                case "Two":
                    return new Motorcycle();
                default:
                    return new Car();
            }
        }

        
    }
}
