using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class StudentBusiness
    {
        StudentRepository studentRepository = new StudentRepository();

        public List<Student> GetAllStudents()
        {
            return this.studentRepository.GetAllStudents();
        }

        public List<Student> GetStudentsWithAverageLargerThan(decimal d)
        {
            return this.studentRepository.GetAllStudents().
                Where(s => s.AverageMark > d).ToList();

            //List<Student> allStudents = this.studentRepository.GetAllStudents();

            //List<Student> StudensWithAverageMark = new List<Student>();

            //foreach(Student s in allStudents)
            //{
            //    if (s.AverageMark > d)
            //    {
            //        StudensWithAverageMark.Add(s);
            //    }
            //}
            //return StudensWithAverageMark;
        }

        public string InsertStudent(Student s)
        {
            int rowAffected = this.studentRepository.InsertStudent(s);

            if (rowAffected > 0)
            {
                return "Uspešan unos u bazu podataka!";
            }
            else
            {
                return "Neuspešan unos, došlo je do greške!";
            }
        }
    }
}
