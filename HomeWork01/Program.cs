using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using PatientClassLibrary;

namespace HomeWork1
{
    class Program
    {
        static void Main(String[] args)
        {
            Patients p = new Patients
            {
                ID = Convert.ToInt32(args[0]),
                Name = Convert.ToString(args[1]),
                Cnic = Convert.ToString(args[2]),
                Phone = Convert.ToString(args[3]),
                Disease = Convert.ToString(args[4]),
                Isadmityn = Convert.ToString(args[5])
            };
            Console.WriteLine(p.ToString());
        }
    }
}