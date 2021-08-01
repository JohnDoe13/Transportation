using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithInterfaces
{
    public class Wheels : IWheels
    {
        private string model;
        private string color;
        private int year;
        
       public string Model { get { return model; } set { model = value; } }
        public string Color { get { return color; }set { color = value; } }
        public int Year { get { return year; } set { year = value; } }
            
           
        public Wheels(string model, string color, int year)
        {
            
        }

        public Wheels()
        {
            this.Model = model;
            this.Color = color;
            this.Year = year;
        }

        //public string Drive()
        //{
        //    Console.WriteLine($"You are driving {this.Model}, color {this.Color} from {this.Year}");
        //}

        public void PedalToTheMetal()
        {
            Console.WriteLine($"Your car is a {model} with {color} color from {year}");
        }

        public void Hello(string hello)
        {

            Console.WriteLine("Here is your car:"+hello);
        }
       //class Truck : Wheels
       // {
       //     public string Country = "Brazil";
       //     public string Manufacturer = "Scania";
       //     public int Price = 700000;
       // }
    } 
}       

//public Vehicle(string licenseplate, string color, int numofwheels, string type)
//{
//    this.Licenseplate = licenseplate;
//    this.Color = color;
//    this.Numofwheels = numofwheels;
//    this.Vtype = type;
//}