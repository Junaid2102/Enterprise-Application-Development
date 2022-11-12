using System;
using PL;

namespace Gpa_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            do
            {
                Console.WriteLine("\nWelcome to GPA Calculator");
                Console.WriteLine("1---Enter Student Data");
                Console.WriteLine("2---Output Student Data");
                Console.WriteLine("3---Exit");
                Console.WriteLine("\nPlease choose one option from above: ");
                input = Convert.ToInt32(Console.ReadLine());

                if (input == 1)
                {
                    GPAview view = new GPAview();
                    view.inputdetails();
                }
                if (input == 2)
                {
                    GPAview view = new GPAview();
                    view.ShowData();
                    Console.WriteLine("Press any key to go to main menu……...");
                    Console.ReadKey(true);
                }
            } while (input != 3);
        }
    }
}
