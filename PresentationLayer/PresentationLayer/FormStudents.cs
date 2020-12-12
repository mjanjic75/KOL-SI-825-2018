using BusinessLayer;
using Shared.Interfaces.Business;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer {
	public partial class FormStudents : Form {
		private readonly IStudentBusiness studentBusiness;
		private List<(TextBox, Label)> inputs;
		private Color errorColor = Color.FromArgb(255, 130, 125);

		private decimal d = 0m;
		// vrednost prema kojoj će se prikazivati studenti sa prosečnom ocenom većom od "d"

		public FormStudents(IStudentBusiness student_business) {
			studentBusiness = student_business;
			InitializeComponent();
			inputs = new List<(TextBox, Label)> {
				(textBoxStudentName, labelErrorName),
				(textBoxStudentIndexNumber, labelErrorIndex),
				(textBoxStudentAverageMark, labelErrorGrade),
				(textBoxStudentEmail, labelErrorEmail)
			};
		}

		private void FormStudents_Load(object sender, EventArgs e) {
			GetAllStudents();

			ValidateInputs(sender, e);

			foreach (var tb in inputs) {
				tb.Item1.Click += ValidateInputs;
				tb.Item1.TextChanged += ValidateInputs;
			}
		}

		private void ValidateInputs(object sender, EventArgs e) {
			foreach (var tb in inputs) {
				tb.Item1.BackColor = string.IsNullOrEmpty(tb.Item1.Text) ? errorColor : Color.White;
				tb.Item2.Visible = string.IsNullOrEmpty(tb.Item1.Text);
			}

			if (Regex.IsMatch(textBoxStudentIndexNumber.Text, @"^[1-9]?[0-9]{2}/2[0-9]{3}$")) {
				textBoxStudentIndexNumber.BackColor = Color.White;
			} else if (!string.IsNullOrEmpty(textBoxStudentIndexNumber.Text)) {
				textBoxStudentIndexNumber.BackColor = errorColor;
				labelErrorIndex.Text = "Indeks nije odgovarajuceg formata";
				labelErrorIndex.Visible = true;
			} else {
				labelErrorIndex.Text = "Ovo polje je obavezno";
			}

			if (Regex.IsMatch(textBoxStudentEmail.Text, @"^[1-9]?[0-9]{2}-2[0-9]{3}(m|ms)?@ftn\.edu\.rs$")) {
				textBoxStudentEmail.BackColor = Color.White;
			} else if (!string.IsNullOrEmpty(textBoxStudentEmail.Text)) {
				textBoxStudentEmail.BackColor = errorColor;
				labelErrorEmail.Text = "Email nije odgovarajuceg formata";
				labelErrorEmail.Visible = true;
			} else {
				labelErrorEmail.Text = "Ovo polje je obavezno";
			}

			buttonInsertStudent.Enabled = !inputs.Any(x => string.IsNullOrEmpty(x.Item1.Text));
		}

		private void GetAllStudents() {
			listBoxStudents.Items.Clear();

			List<Student> listOfStudents;

			if (textBoxStudentFilterByAverageMark.Text == "") {
				listOfStudents = this.studentBusiness.GetAllStudents();
				// Ako je tekstualno polje za prosečnu ocenu prazno, nema filtriranja
			} else {
				d = Convert.ToDecimal(textBoxStudentFilterByAverageMark.Text);

				listOfStudents = this.studentBusiness.GetStudentsWithAverageLargerThan(d);
				// Ako je uneta prosečna ocena za filtriranje, poziva se sa biznis sloja
				// metoda koja vraća samo studente sa prosečnom ocenom većom od "d"

				// U realnom projektu za ovo tekstualno polje treba izvršiti proveru 
				// da li je uneta vrednost u dozvoljenom opsegu, 
				// o čemu će biti reči na nekim od narednih vežbi.
			}


			foreach (Student s in listOfStudents) {
				listBoxStudents.Items.Add(s.Id + ". " + s.Name + " – " + s.IndexNumber + " — " + s.AverageMark);
			}
		}


		private void buttonInsertStudent_Click(object sender, EventArgs e) {
			Student s = new Student {
				Name = textBoxStudentName.Text,
				IndexNumber = textBoxStudentIndexNumber.Text,
				AverageMark = Convert.ToDecimal(textBoxStudentAverageMark.Text)
			};

			labelMessages.Text = studentBusiness.InsertStudent(s).ToString();

			GetAllStudents();

			foreach (var tb in inputs)
				tb.Item1.Text = string.Empty;

			inputs[0].Item1.Focus();
		}

		// Pošto je pri učitavanju forme polje za prosečnu ocenu prazno,
		// kreiramo posebnu metodu koja se poziva klikom na odgovarajući taster, 
		// a koja ponovo poziva metodu GetAllStudents() na Formi i prikazuje
		// studente koji imaju prosečnu ocenu veću od one zadate u tekstualnom polju.
		private void buttonStudentRefreshListBox_Click(object sender, EventArgs e) {
			GetAllStudents();
		}
	}
}
