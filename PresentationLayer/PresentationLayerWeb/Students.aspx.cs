using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentationLayerWeb
{
    public partial class WebFormStudents : System.Web.UI.Page
    {
        private StudentBusiness studentBusiness = new StudentBusiness();

        private decimal d = 0m;
        // vrednost prema kojoj će se prikazivati studenti sa prosečnom ocenom većom od "d"

        protected void Page_Load(object sender, EventArgs e)
        {
            GetAllStudents();
        }

        private void GetAllStudents()
        {
            ListBoxStudent.Items.Clear();

            List<Student> listOfStudents = this.studentBusiness.GetAllStudents();

            if (TextBoxStudentFilterByAverageMark.Text == "")
            {
                listOfStudents = this.studentBusiness.GetAllStudents();
                // Ako je tekstualno polje za prosečnu ocenu prazno, nema filtriranja
            }
            else
            {
                d = Convert.ToDecimal(TextBoxStudentFilterByAverageMark.Text);

                listOfStudents = this.studentBusiness.GetStudentsWithAverageLargerThan(d);
                // Ako je uneta prosečna ocena za filtriranje, poziva se sa biznis sloja
                // metoda koja vraća samo studente sa prosečnom ocenom većom od "d"

                // U realnom projektu za ovo tekstualno polje treba izvršiti proveru 
                // da li je uneta vrednost u dozvoljenom opsegu, 
                // o čemu će biti reči na nekim od narednih vežbi.
            }


            foreach (Student s in listOfStudents)
            {
                ListBoxStudent.Items.Add(s.Id + ". " + s.Name + " – " + s.IndexNumber + " — " + s.AverageMark);
            }
        }

        protected void ButtonStudentInsert_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Name = TextBoxStudentName.Text;
            s.IndexNumber = TextBoxStudentIndexNumber.Text;
            s.AverageMark = Convert.ToDecimal(TextBoxStudentAverageMark.Text);

            LabelMessages.Text = this.studentBusiness.InsertStudent(s);

            GetAllStudents();
        }


        // Pošto je pri učitavanju forme polje za prosečnu ocenu prazno,
        // kreiramo posebnu metodu koja se poziva klikom na odgovarajući taster, 
        // a koja ponovo poziva metodu GetAllStudents() na Formi i prikazuje
        // studente koji imaju prosečnu ocenu veću od one zadate u tekstualnom polju.
        protected void ButtonStudentRefreshListBoxStudent_Click(object sender, EventArgs e)
        {
            GetAllStudents();
        }
    }
}