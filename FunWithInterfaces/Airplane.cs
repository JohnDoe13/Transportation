using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithInterfaces
{
    public class Airplane : Truck, IWheels
        
    {
        private string airline;
        private string type;
        private int capacity;

        public string Airline { get { return airline; } set { airline = value; } }
        public string Type { get { return type; } set { type = value; } }
        
        public int Capacity { get { return capacity; } set { capacity = value; } }

        public void FlyingHigh()
        {
            Console.WriteLine($"Flying high with {airline}, type {type} and capacity i.e. seats {capacity}");
        }

    }
}
