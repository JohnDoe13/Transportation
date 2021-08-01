using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithInterfaces
{
    public class Truck : Wheels,IWheels
   
    {
        private string country;
        private string manufacturer;
        private int price;

        public string Country { get { return Country; } set { country = value; } }
        public string Manufacturer { get { return Manufacturer; } set { manufacturer = value; } }
        public int Price { get { return Price; } set { price = value; } }
        public Truck()
        {
            this.Country = country;
            this.Manufacturer = manufacturer;
            this.Price = price;

        }

        public void DisplayTruck()
        {
            Console.WriteLine($"Your truck is from {country}, made by {manufacturer} and costs ${price} color {Color} from  {Year}.");
        }

        public void Hello(string hello)
        {
            //throw new NotImplementedException();
        }

        public void PedalToTheMetal()
        {
            //throw new NotImplementedException();
            Console.WriteLine("What comes around...");
            Console.WriteLine(this.country, this.manufacturer, this.price);
        }

        //internal void DisplayTruck()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
