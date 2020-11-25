using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class StudentRepository
    {
        public List<Student> GetAllStudents()
        {
            using (SqlConnection dataConnection = new SqlConnection(Constants.connString))
            {
                dataConnection.Open();

                SqlCommand dataCommand = new SqlCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT * FROM Students";

                SqlDataReader dataReader = dataCommand.ExecuteReader();

                List<Student> listOfStudent = new List<Student>();

                while (dataReader.Read())
                {
                    Student s = new Student();
                    s.Id = dataReader.GetInt32(0);
                    s.Name = dataReader.GetString(1);
                    s.IndexNumber = dataReader.GetString(2);
                    s.AverageMark = dataReader.GetDecimal(3);

                    listOfStudent.Add(s);
                }

                return listOfStudent;
            }
        }

        public int InsertStudent(Student s)
        {
            using (SqlConnection dataConnection = new SqlConnection(Constants.connString))
            {
                dataConnection.Open();

                SqlCommand dataCommand = new SqlCommand();
                dataCommand.Connection = dataConnection;

                dataCommand.CommandText = string.Format("INSERT INTO Student VALUES('{0}','{1}',{2})",
                    s.Name, s.IndexNumber, s.AverageMark);

                return dataCommand.ExecuteNonQuery();

            }
        }
    }
}
