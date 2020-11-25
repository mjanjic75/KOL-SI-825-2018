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
    public partial class WebForm1 : System.Web.UI.Page
    {
        private StudentBusiness studentBusiness = new StudentBusiness();

        protected void Page_Load(object sender, EventArgs e)
        {
            GetAllStudents();
        }

        private void GetAllStudents()
        {
            ListBoxStudent.Items.Clear();

            List<Student> listOfStudents = this.studentBusiness.GetAllStudents();           

            foreach (Student s in listOfStudents)
            {
                ListBoxStudent.Items.Add(s.Id + ". " + s.Name + " – " + s.IndexNumber + " — " + s.AverageMark);
            }
        }
    }
}