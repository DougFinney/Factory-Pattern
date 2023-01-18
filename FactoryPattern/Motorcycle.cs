using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
            Console.WriteLine("Building a new motorcycle!\n");
        }

        public void Drive()
        {
            Console.WriteLine("Your motorcycle is built and ready to drive!\n");

        }
        
    }
}

