using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseRegistrationSystem
{
    
    public partial class RegistrationForm : Form
    {
        LoginForm myLoginForm;
        CatalogForm myCatalogForm;
        Student currentStudent;
        Course[] courseList = new Course[1];

        public RegistrationForm(LoginForm previousForm, Student newStudent)
        {
            currentStudent = newStudent;
            myLoginForm = previousForm;
            InitializeComponent();
            updateInfo();
            //loadCourses();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            myLoginForm.Show();
            this.Close();
        }

        private void CatalogButton_Click(object sender, EventArgs e)
        {
            myCatalogForm = new CatalogForm();
            myCatalogForm.Show();
        }

        public void updateInfo()
        {
            StudentIDTextBox.Text = currentStudent.getStudentID();
            FirstNameTextBox.Text = currentStudent.getStudentFirstName();
            LastNameTextBox.Text = currentStudent.getStudentLastName();
            HoldsTextBox.Text = currentStudent.getHoldStatus().ToString();

        }

        public void loadCourses()
        {
            int counter = 0;
            string tempCourse = "";

            System.IO.StreamReader fromDat = new System.IO.StreamReader("courselist.dat");

            while (fromDat.EndOfStream)
            {
                fromDat.Read(tempCourse.ToCharArray(), 0, 6);
                if (File.Exists(@tempCourse + ".dat"))
                {
                    courseList[counter].fillCourse(tempCourse);
                    Array.Resize(ref courseList, courseList.Length + 1);
                    counter++;
                    fromDat.ReadLine();
                }
            }

            fromDat.Close();
        }
    }
}
