using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class GPABLL
    {
        public void AddMarks(GPADTO dto)
        {
            //dto.GPA = CalculateGPA(dto.Marks);
            dto.Grade = CalculateGrade(dto.Marks);
            GPADAL dal = new GPADAL();
            dal.SaveGPA(dto);
        }

        private string CalculateGrade(int marks)
        {
            if (marks < 50)
            {
                return "F";
            }
            else if (marks >= 50 && marks < 55)
            {
                return "D";
            }
            else if (marks >= 55 && marks < 58)
            {
                return "C-";
            }
            else if (marks >= 58 && marks < 61)
            {
                return "C";
            }
            else if (marks >= 61 && marks < 65)
            {
                return "C+";
            }
            else if (marks >= 65 && marks < 70)
            {
                return "B-";
            }
            else if (marks >= 70 && marks < 75)
            {
                return "B";
            }
            else if (marks >= 75 && marks < 80)
            {
                return "B+";
            }
            else if (marks >= 80 && marks < 85)
            {
                return "A-";
            }
            else if (marks >= 85 && marks < 101)
            {
                return "A";
            }
            return "";
        }
        public List<GPADTO> getgpa()
        {
            GPADAL data = new GPADAL();
            List<GPADTO> gpadtos = new List<GPADTO>();
            gpadtos = data.ReadData();
            foreach(GPADTO gpadata in gpadtos)
            {
                gpadata.GPA = CalculateGPA(gpadata.Grade);
            }
            return gpadtos;
        }
        private String CalculateGPA(string grades)
        {
            if (grades.Equals("A"))
            {
                return 4.00f.ToString("0.00");
            }
            else if (grades.Equals("A-"))
            {
                return 3.70f.ToString("0.00");
            }
            else if (grades.Equals("B+"))
            {
                return 3.30f.ToString("0.00");
            }
            else if (grades.Equals("B"))
            {
                return 3.00f.ToString("0.00");
            }
            else if (grades.Equals("B-"))
            {
                return 2.70f.ToString("0.00");
            }
            else if (grades.Equals("C+"))
            {
                return 2.30f.ToString("0.00");
            }
            else if (grades.Equals("C"))
            {
                return 2.00f.ToString("0.00");
            }
            else if (grades.Equals("C-"))
            {
                return 1.70f.ToString("0.00");
            }
            else if (grades.Equals("D"))
            {
                return 1.00f.ToString("0.00");
            }
            else if (grades.Equals("F"))
            {
                return 0.00f.ToString("0.00");
            }
            return " ";
        }
        //public List<GPADTO> GetGPAs()
        //{
        //    GPADAL dal = new GPADAL();
        //    return dal.GetAllRecords();
        //}
        public bool onFileCheck()
        {
            GPADAL check = new GPADAL();
            return check.DBCheck();
        }
    }
}