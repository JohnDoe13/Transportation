using System;
using System.Collections.Generic;
using System.Linq;

namespace FunWithListArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            string[] names = new string[] { "Anna", "Karen", "Benny", "George", "Elisabeth", "George", "Noa", "Gerald", "Herman", "Geraldine" };

            Console.WriteLine("Foreach-loop");
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            var ListOfNames = new List<string>();
            Console.WriteLine("---List of names---");
            ListOfNames.AddRange(names);
            foreach(string ListOfName in ListOfNames)
            {
                Console.WriteLine(ListOfName);
            }

            Console.WriteLine("---Finding---");
            int iCount = 0;
            string sFind = ListOfNames.Find(item => item == "George");
            //for (int i = 0; i < sFind.Count; i++)
            //{
            //    Console.WriteLine(sFind);
            //    iCount += 1;
            //}
            Console.WriteLine(sFind);
            //Console.WriteLine();
            Console.WriteLine("---Dictionary---");
            var cities = new Dictionary<int, string>();
            cities.Add(0, "Miami");
            cities.Add(1, "Detroit");
            cities.Add(2, "Phoenix");
            cities.Add(3,"Miami");
            cities.Add(4, "Los Angeles");

            foreach(var ct in cities)
            {
                Console.WriteLine(ct.Key + " "+ct.Value);
            }

            bool citi = cities.ContainsValue("Miami");

            foreach(var city in cities)
            {
                Console.WriteLine(cities.GetType());
            }

            Console.WriteLine(citi);

            //Console.WriteLine($"Found {iCount} occurences of {sFind}.");
        }
    } 
}
