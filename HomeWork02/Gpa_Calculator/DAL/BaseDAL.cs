using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DAL
{
    public class BaseDAL
    {
        protected void Save(string filename, string line)
        {
            StreamWriter sw = new StreamWriter(filename, append: false);
            sw.WriteLine(line);
            sw.Close();
        }

        protected string Read(string filenemae)
        {
            StreamReader sr = new StreamReader(filenemae);
            string data = sr.ReadLine();
            sr.Close();
            return data;
        }

        //protected List<string> Read(string filename)
        //{
        //    List<string> list = new List<string>();
        //    StreamReader sr = new StreamReader(filename);
        //    string data = sr.ReadLine();
        //    while (data != null)
        //    {
        //        list.Add(data);
        //        data = sr.ReadLine();
        //    }
        //    sr.Close();
        //    return list;
        //}
    }
}
