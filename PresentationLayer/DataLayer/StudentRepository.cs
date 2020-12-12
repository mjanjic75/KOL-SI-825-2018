using Shared.Interfaces.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer {
	public class StudentRepository : IStudentRepository {
		public List<Student> GetAllStudents() {
			using (var dataConnection = new SqlConnection(Constants.connString)) {
				dataConnection.Open();

				var dataCommand = new SqlCommand {
					Connection = dataConnection,
					CommandText = "SELECT * FROM Students"
				};

				var dataReader = dataCommand.ExecuteReader();

				var listOfStudent = new List<Student>();

				while (dataReader.Read()) {
					Student s = new Student {
						Id = dataReader.GetInt32(0),
						Name = dataReader.GetString(1),
						IndexNumber = dataReader.GetString(2),
						AverageMark = dataReader.GetDecimal(3)
					};

					listOfStudent.Add(s);
				}

				return listOfStudent;
			}
		}

		public int InsertStudent(Student s) {
			using (var dataConnection = new SqlConnection(Constants.connString)) {
				dataConnection.Open();

				var dataCommand = new SqlCommand {
					Connection = dataConnection,
					CommandText = string.Format("INSERT INTO Students VALUES('{0}','{1}',{2})",
					s.Name, s.IndexNumber, s.AverageMark)
				};

				return dataCommand.ExecuteNonQuery();

			}
		}
	}
}
