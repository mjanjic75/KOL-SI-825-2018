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
            }
            else
            {
                d = Convert.ToDecimal(textBoxStudentFilterByAverageMark.Text);

                listOfStudents = this.studentBusiness.GetStudentsWithAverageLargerThan(d);
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
    }
}
