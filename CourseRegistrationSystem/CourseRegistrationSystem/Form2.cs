using System;
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

        public RegistrationForm(LoginForm previousForm, Student newStudent)
        {
            currentStudent = newStudent;
            myLoginForm = previousForm;
            InitializeComponent();
            updateInfo();
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

        }
    }
}
