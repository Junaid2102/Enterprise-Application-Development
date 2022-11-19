using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class GPADAL : BaseDAL
    {
        public int SaveGPA(GPADTO dto)
        {
            int count = Save(dto);
            return count;
        }
        public List<GPADTO> ReadData()
        {
            List<GPADTO> dtos = Read();
            return dtos;
        }

        //public GPADTO ReadData()
        //{
        //    string data = Read("data.txt");
        //    GPADTO gpa = JsonSerializer.Deserialize<GPADTO>(data);
        //    return gpa;
        //}

        public bool DBCheck()
        {
            return CheckInfo();
        }

    }
}
