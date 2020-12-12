using DataLayer;
using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer {
	public class StudentBusiness : IStudentBusiness {
		private readonly IStudentRepository studentRepository;

		public StudentBusiness(IStudentRepository student_repository) => studentRepository = student_repository;

		public List<Student> GetAllStudents() => studentRepository.GetAllStudents();

		public List<Student> GetStudentsWithAverageLargerThan(decimal d) => studentRepository.GetAllStudents().
				Where(s => s.AverageMark > d).ToList();

		public string InsertStudent(Student s) => studentRepository.InsertStudent(s) > 0 ? "Uspešan unos u bazu podataka!" : "Neuspešan unos, došlo je do greške!";
	}
}
