using System;
using System.Collections.Generic;
using System.Text;
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
            if(bll.onFileCheck() == false)
            {
                Console.WriteLine("-------------File doesn't exist or is empty-------------");
            }
            else
            {
                Console.Write('\n');
                GPADTO e = bll.getgpa();
                Console.Write("Name: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(e.Name);
                Console.ResetColor();

                Console.Write("RollNumber: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(e.RollNumber);
                Console.ResetColor();

                Console.Write("Subject: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(e.Subject);
                Console.ResetColor();

                Console.Write("GPA: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(e.GPA);
                Console.ResetColor();
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
