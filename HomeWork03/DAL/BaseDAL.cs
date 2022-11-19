using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using DTO;

namespace DAL
{
    public class BaseDAL
    {
        protected int Save(GPADTO gpa)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=grades;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string querry = $"INSERT INTO grades (Name, RollNo, Subject, Grade) VALUES (@name, @rollno, @subject, @grades)";
            cmd.CommandText= querry ;
            SqlParameter p1 = new SqlParameter("name", gpa.Name) ;
            SqlParameter p2 = new SqlParameter("rollno", gpa.RollNumber);
            SqlParameter p3 = new SqlParameter("subject", gpa.Subject);
            SqlParameter p4 = new SqlParameter("grades", gpa.Grade);

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);

            con.Open();
            int count = cmd.ExecuteNonQuery();
            con.Close();
            return count;

        }

        //protected string Read(string filenemae)
        //{
        //    StreamReader sr = new StreamReader(filenemae);
        //    string data = sr.ReadLine();
        //    sr.Close();
        //    return data;
        //}

        protected List<GPADTO> Read()
        {
            List<GPADTO> list = new List<GPADTO>();
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=grades;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string querry = $"SELECT * FROM grades";
            cmd.CommandText= querry ;
            con.Open();

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                GPADTO dto = new GPADTO();
                dto.Name = rd.GetString(1);
                dto.RollNumber = rd.GetString(2);
                dto.Subject = rd.GetString(3);
                dto.Grade = rd.GetString(4);
                list.Add(dto);
            }
            con.Close() ;
            return list;
        }

        protected bool CheckInfo()
        {
            bool point = false;
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=grades;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string querry = $"SELECT * from grades";
            cmd.CommandText= querry ;
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows) 
            { 
                point = true;
            }
            con.Close();
            return point;
        }
    }
}
