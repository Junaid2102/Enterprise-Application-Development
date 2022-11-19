using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BLL;

namespace PL
{
    public class GPAview
    {
        public void inputdetails()
        {
            Console.Write("Enter Name: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string name = Console.ReadLine();
            Console.ResetColor();

            Console.Write("Enter RollNumber: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string rollno = Console.ReadLine();
            Console.ResetColor();

            Console.Write("Enter Subject title: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string sub = Console.ReadLine();
            Console.ResetColor();

            Console.Write("Enter marks (out of 100): ");
            Console.ForegroundColor = ConsoleColor.Green;
            int marks = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();

            GPADTO dto = new GPADTO
            {
                Name = name,
                RollNumber = rollno,
                Subject = sub,
                Marks = marks
            };
            GPABLL bll = new GPABLL();
            bll.AddMarks(dto);
        }

        public void ShowData()
        {
            GPABLL bll = new GPABLL();
            if (bll.onFileCheck() == false)
            {
                Console.WriteLine("-------------DataBase is Empty-------------");
            }
            else
            {
                List<GPADTO> gpaDTOS = bll.getgpa();
                foreach(GPADTO data in gpaDTOS)
                {
                    Console.Write('\n');
                    Console.Write("Name: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(data.Name);
                    Console.ResetColor();

                    Console.Write("RollNumber: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(data.RollNumber);
                    Console.ResetColor();

                    Console.Write("Subject: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(data.Subject);
                    Console.ResetColor();

                    Console.Write("GPA: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(data.GPA);
                    Console.ResetColor();

                    Console.WriteLine("\n-------------------------------------------------------\n");
                }
                //Console.WriteLine($"Name: {e.Name}");
                //Console.WriteLine($"Roll Number: {e.RollNumber}");
                //Console.WriteLine($"Subject: {e.Subject}");
                //Console.WriteLine($"GPA: {e.GPA}");
            }

        }

        //public void ShowGPAs()
        //{
        //    GPABLL bll = new GPABLL();
        //    List<GPADTO> gpas = bll.GetGPAs();
        //    foreach (var e in gpas)
        //    {
        //        Console.WriteLine($"Name: {e.Name}");
        //        Console.WriteLine($"Roll Number: {e.RollNumber}");
        //        Console.WriteLine($"Subject: {e.Subject}");
        //        Console.WriteLine($"Marks: {e.Marks}");
        //        Console.WriteLine($"GPA: {e.GPA}");
        //        Console.WriteLine($"--------------------------------------------");
        //    }
        //}

    }
}