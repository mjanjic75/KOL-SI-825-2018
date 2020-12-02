using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormStudents : Form
    {
        private StudentBusiness studentBusiness = new StudentBusiness();

        private decimal d = 0m;
        // vrednost prema kojoj će se prikazivati studenti sa prosečnom ocenom većom od "d"

        public FormStudents()
        {
            InitializeComponent();
        }

        private void FormStudents_Load(object sender, EventArgs e)
        {
            GetAllStudents();
        }

        private void GetAllStudents()
        {
            listBoxStudents.Items.Clear();

            List<Student> listOfStudents;

            if (textBoxStudentFilterByAverageMark.Text == "")
            {
                listOfStudents = this.studentBusiness.GetAllStudents();
                // Ako je tekstualno polje za prosečnu ocenu prazno, nema filtriranja
            }
            else
            {
                d = Convert.ToDecimal(textBoxStudentFilterByAverageMark.Text);

                listOfStudents = this.studentBusiness.GetStudentsWithAverageLargerThan(d);
                // Ako je uneta prosečna ocena za filtriranje, poziva se sa biznis sloja
                // metoda koja vraća samo studente sa prosečnom ocenom većom od "d"

                // U realnom projektu za ovo tekstualno polje treba izvršiti proveru 
                // da li je uneta vrednost u dozvoljenom opsegu, 
                // o čemu će biti reči na nekim od narednih vežbi.
            }


            foreach (Student s in listOfStudents)
            {
                listBoxStudents.Items.Add(s.Id + ". " + s.Name + " – " + s.IndexNumber + " — " + s.AverageMark);
            }
        }

        private void buttonInsertStudent_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Name = textBoxStudentName.Text;
            s.IndexNumber = textBoxStudentIndexNumber.Text;
            s.AverageMark = Convert.ToDecimal(textBoxStudentAverageMark.Text);

            labelMessages.Text = this.studentBusiness.InsertStudent(s);

            GetAllStudents();

        }

        // Pošto je pri učitavanju forme polje za prosečnu ocenu prazno,
        // kreiramo posebnu metodu koja se poziva klikom na odgovarajući taster, 
        // a koja ponovo poziva metodu GetAllStudents() na Formi i prikazuje
        // studente koji imaju prosečnu ocenu veću od one zadate u tekstualnom polju.
        private void buttonStudentRefreshListBox_Click(object sender, EventArgs e)
        {
            GetAllStudents();
        }
    }
}
