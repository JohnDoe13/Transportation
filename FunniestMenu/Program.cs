using System;

namespace FunniestMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("---Third Time Lucky---");
            int selection;

            do
            {
                Console.Clear();
                Console.WriteLine("Your menu of choices.\nAlways press Enter to return to menu.");
                Console.WriteLine("1) Not so funny.");
                Console.WriteLine("2) Getting there.");
                Console.WriteLine("3) Now we are talking.");
                Console.WriteLine("0) So you want to quit?");
                Console.WriteLine("Pick a number");
                selection = int.Parse(Console.ReadLine());
                FunniestMethods fm = new FunniestMethods();
                switch (selection)
                {

                    case 1:

                        fm.Boring();
                        Console.ReadLine();
                        break;

                    case 2:
                        fm.GettingThere();
                        Console.ReadLine();
                        break;
                    case 3:
                        fm.WeAreThere();
                        Console.ReadLine();
                        break;
                    case 0:
                        try
                        {
                            Console.WriteLine("Enter age");
                            int ages  = int.Parse(Console.ReadLine());
                            //Console.WriteLine("Enter firstname:");
                            //string fname = Console.ReadLine();
                            


                        }
                        catch (Exception fx)
                        {

                            Console.WriteLine("Wrong format.",fx.Message);
                        }

                        //catch (Exception exception)
                        //{
                        //    Console.WriteLine($"Oops, something went wrong. {exception.Message}");
                        //    //Result = 1;
                        //}

                        //include if-statement
                        //System.Environment.Exit(0);
                        break;
                        default:
                            Console.WriteLine("Ooops, something went wrong.");
                        break;
                }


                } while (selection!=0);

            //static int A(string argument
            //{
            //    if(argument == null)
            //    {
            //        throw new ArgumentNullException("argument");
            //    }

            //    if (argument.Length == 0)
            //    {
            //        throw new ArgumentException("Zero length is invalid", argument);
            //    }
            //}

                /*Exceptionhandling that works
                try
                {
                    Console.WriteLine("How old are you?");
                    int age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second age:");
                    int secAge = int.Parse(Console.ReadLine());

                    Console.WriteLine(age/secAge);

                }

                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                */


            }    

    }
}

