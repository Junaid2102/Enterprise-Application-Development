using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
namespace PatientClassLibrary
{
    public class Patients
    {
        public static List<Patients> list = new List<Patients>();
        public static int count = 0;

        private int id;
        public Patients()
        {
            this.id = ++count;
        }
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public String Name { get; set; }
        public String Cnic { get; set; }
        public String Phone { get; set; }
        public String Disease { get; set; }
        public String Isadmityn { get; set; }

        public static void AddPatient(Patients p)
        {
            list.Add(p);
            FileStream fout = new FileStream("Patients.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fout);

            sw.WriteLine(p.ID + "," + p.Name + "," + p.Cnic + "," + p.Phone + "," + p.Disease + "," + p.Isadmityn);
            sw.Close();
            fout.Close();
        }

        public static void DeletePatient(int id)
        {
            for(int i = 0; i<= list.Count; i++)
            {
                if(list[i].ID == id)
                {
                    list.RemoveAt(i);
                    return;
                }
            }
            //Console.WriteLine("Record Unavailable");
        }

        public static void UpdatePatient(int id, Patients p)
        {
            for(int i=0; i<=list.Count; i++)
            {
                list.RemoveAt(i);
                list.Insert(i, p);
                return;
            }
            //Console.WriteLine("Record not FOund");
        }
        public static void SearchPatient(int id)
        {
            for(int i=0; i<=list.Count; i++)
            {
                if(id == list[i].ID)
                {
                    Console.WriteLine(list[i].ToString());
                }
            }
        }

        public static void DisplayAll()
        {
            Console.WriteLine("Your result: ");
            foreach(Patients p in list)
            {
                Console.WriteLine(p);
            }
        }

        public override string ToString()
        {
            return "\nID: " + this.ID + "\nName: " + this.Name + "\nCNIC: " + this.Cnic + "\nPhone Number: " + this.Phone + "\nDisease: " + this.Disease + "\nCurrently Admitted: " + this.Isadmityn;
        }

    }
}
