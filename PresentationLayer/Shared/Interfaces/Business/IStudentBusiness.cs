using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business {
    public interface IStudentBusiness {
        List<Student> GetAllStudents();
        string InsertStudent(Student s);
		List<Student> GetStudentsWithAverageLargerThan(decimal average_mark);
	}
}