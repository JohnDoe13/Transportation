using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
namespace FunWithInterfaces
{
    class Program
    {
        public static object Pontiac { get; private set; }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Wheels w = new Wheels();
            w.Model = "Pontiac";
            w.Color = "Black";
            w.Year = 2010;
            w.Hello("Ted Bundy");
            w.PedalToTheMetal();

            //class Truck: Wheels
            //{

            //}

            List<string> Town = new List<string>();
            Town.Add("Kandahar");
            Town.Add("Bristol");
            Town.Add("Chicago");
            Town.Add("Perth");
            Town.Add("Lyon");

            //Town.Insert(3, "null");
            //if (Town[1] == "Bristol") 
            //{
            //    Console.WriteLine(Town[1].Replace("Bristol", "null"));
            //}

            Town[4]=Town[4].Replace("Lyon", "null");

            Console.WriteLine("Using a Foreach-lopp. On my bucketlist:");
            foreach(var twn in Town)
            {
                
                Console.WriteLine(twn.ToUpper()+" "+twn.Length);
            }

            Console.WriteLine("For-loop");
            for(int i = 0; i < Town.Count; i++)
            {
                if (Town[i] == "null")
                {
                    Console.WriteLine($"Oops, there's a null-value at position {i}.");
                }
                else
                {
                    Console.WriteLine($"Number {i+1} on my bucket list is {Town[i]}");
                }
                
            }


            Truck t= new Truck();
            t.Hello("Ted Bundy");
            t.Country = "Sweden";
            t.Manufacturer = "Volvo";
            t.Price = 230000;
            t.Color = "Orange";
            t.Year = 2021;
            Console.WriteLine("---Pedal To the Metal---");
            t.DisplayTruck();
            //t.PedalToTheMetal();
                        

            Airplane air = new Airplane();
            air.Airline = "South West Airline";
            air.Capacity = 356;
            air.Type = "Boeing 747";
            air.FlyingHigh();

            Boat b = new Boat();
            b.boatline = "Viking Line";
            Console.WriteLine($"Sailaway with {b.boatline}");
            b.Airline = "Soutwest Airline";
            b.Capacity = 340;
            b.Type = "Boeing 737";
            b.Price = 2400;
           
            //Just checking if it works to call any method and it does.
            b.FlyingHigh();
            Console.WriteLine($"Manufacturer:{b.Manufacturer ="Airbus"}.");

            b.IamSailing();

            //Console.Read();

            //Console.WriteLine("Simulate a parking garage with 10 spaces.");
            int[] parkingspace = new int[10];
            //parkingspace[2] = 1;
            //parkingspace[6] = 1;
            //Console.WriteLine("Are we here yet?");
            /*This Works
            for(int k = 0+1; k < parkingspace.Length; k++)
            {
                if (parkingspace[k] == 1)
                {
                    Console.WriteLine($"{k} is not available");
                }
                else
                {
                   Console.WriteLine($"Number {k} is empty.");

                }
            }
            ...to here.*/
            Console.WriteLine();
            Console.WriteLine("***A prototype for the Garage.***");
            /*Below is a nested For-loop. The For-loop (k) will create ten sections of parkingspace. 
             The second For-loop (kk) will randomly "block" spaces and also tell which ones are available.*/
            
            int itotal = 0;
            for (int k = 0; k < parkingspace.Length;k++)
            {
                int sum = 0;
                Console.WriteLine($"Level {k+1}");
                for(int kk = 0; kk < parkingspace.Length; kk++)
                {
                    
                    Random r = new Random();
                int rInt = r.Next(0,2);
                //Check if this is necessary
                //int range = 10;
                    
                    parkingspace[kk] = rInt;

                    if (parkingspace[kk] == 0)
                    {
                        Console.WriteLine($"Space {kk+1} is available.");
                        sum = sum + 1;
                        
                    }
                    
                    //else
                    //{
                    //    Console.WriteLine(parkingspace[kk]);
                        
                    //}
                    
                    
                }
                Console.WriteLine($">>> {sum} space(s) are available. <<<");
                Console.WriteLine("===============");
                itotal = itotal + sum;
                
            }
            Console.WriteLine($"Available space {itotal} ");

            //Random r = new Random();
            //int rInt = r.Next(0, 100); //for ints
            //int range = 100;
            //double rDouble = r.NextDouble() * range; //for doubles
        }

    }
}
