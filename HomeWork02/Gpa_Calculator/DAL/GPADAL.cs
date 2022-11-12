using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DAL
{
    public class GPADAL : BaseDAL
    {
        public void SaveGPA(GPADTO dto)
        {
            string jsonString = JsonSerializer.Serialize(dto);
            Save("data.txt", jsonString);
        }
        //public List<GPADTO> GetAllRecords()
        //{
        //    List<string> list = Read("data.txt");
        //    List<GPADTO> gpas = new List<GPADTO>();
        //    foreach (var e in list)
        //    {
        //        string[] data = e.Split(';');
        //        GPADTO gpa = new GPADTO
        //        {
        //            Name = data[0],
        //            RollNumber = data[1],
        //            Subject = data[2],
        //            Marks = int.Parse(data[3]),
        //            GPA = float.Parse(data[4])
        //        };
        //        gpas.Add(gpa);
        //    }
        //    return gpas;
        //}

        public GPADTO ReadData()
        {
            string data = Read("data.txt");
            GPADTO gpa = JsonSerializer.Deserialize<GPADTO>(data);
            return gpa;
        }

        public bool FileCheck()
        {
            if (File.Exists("data.txt"))
            {
                if(new FileInfo("data.txt").Length == 0)
                {
                    return false;
                }
                return true;
            }
            return false;
        }

    }
}
