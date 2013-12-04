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
            loadCourses();
            fillStudentCurrentCoursesObject();
            updateInfo();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            myLoginForm.Show();
            this.Close();
        }

        private void CatalogButton_Click(object sender, EventArgs e)
        {
            myCatalogForm = new CatalogForm(courseList);
            myCatalogForm.Show();
        }

        public void updateInfo()
        {
            StudentIDTextBox.Text = currentStudent.getStudentID();
            FirstNameTextBox.Text = currentStudent.getStudentFirstName();
            LastNameTextBox.Text = currentStudent.getStudentLastName();
            HoldsTextBox.Text = currentStudent.getHoldStatus().ToString();
            fillCurrentCoursesListView();
            for (int n = 0; n < currentStudent.getCompletedCourses().Length; n++)
            {
                CompletedCoursesTextBox.Text += currentStudent.getCompletedCourses()[n] + "\n";
            }
        }

        // Loads the courses into the courseList array
        public void loadCourses()
        {
            int counter = 0;
            string tempCourse = "";

            System.IO.StreamReader fromDat = new System.IO.StreamReader("Courses\\courselist.dat");

            while (fromDat.Peek() != '*')
            {
                while (fromDat.Peek() != '\n' && fromDat.Peek() != 13)
                {
                    tempCourse += (char)fromDat.Read();
                }
                fromDat.ReadLine();
                if (File.Exists("Courses\\" + @tempCourse + ".dat"))
                {
                    courseList[counter] = new Course(tempCourse);
                    Array.Resize(ref courseList, courseList.Length + 1);
                    counter++;
                }
                tempCourse = "";
            }
            
            fromDat.Close();

            Array.Resize(ref courseList, courseList.Length - 1);
        }

        // Uses the students coursesFromString and adds Course objects to the students currentCourses array
        public void fillStudentCurrentCoursesObject()
        {
            Course[] coursesFromString = new Course[currentStudent.getCurrentSchedule().Length];
            for (int n = 0; n < coursesFromString.Length; n++)
            {
                for (int b = 0; b < courseList.Length; b++)
                {
                    if (currentStudent.getCurrentSchedule()[n] == courseList[b].getCourseNumber().ToString())
                    {
                        coursesFromString[n] = courseList[b];
                    }
                }
            }

            currentStudent.setCurrentCourses(coursesFromString);
        }

        // Fills the listview with the students current courses
        public void fillCurrentCoursesListView()
        {
            CurrentCoursesListView.Items.Clear(); 
            ListViewItem courseListViewItems;
            for (int n = 0; n < currentStudent.getCurrentCourses().Length; n++)
            {
                courseListViewItems = new ListViewItem((currentStudent.getCurrentCourses()[n].getCourseNumber().ToString()));
                courseListViewItems.SubItems.Add((currentStudent.getCurrentCourses()[n].getSubject().ToString()));
                courseListViewItems.SubItems.Add((currentStudent.getCurrentCourses()[n].getfourDigits().ToString()));
                courseListViewItems.SubItems.Add((currentStudent.getCurrentCourses()[n].getCourseName().ToString()));
                courseListViewItems.SubItems.Add((currentStudent.getCurrentCourses()[n].getStartTime().ToString()));
                courseListViewItems.SubItems.Add((currentStudent.getCurrentCourses()[n].getEndTime().ToString()));
                courseListViewItems.SubItems.Add((currentStudent.getCurrentCourses()[n].getDays().ToString()));

                CurrentCoursesListView.Items.Add(courseListViewItems);
            }

        }
        public Course getCourseFromString(string courseString)
        {
            Course tempCourse = new Course();

            for (int n = 0; n < courseList.Length; n++ )
            {
                if (courseList[n].getCourseNumber().ToString() == courseString)
                    tempCourse = courseList[n];
            }

            return tempCourse;
        }
        private void DropCourseButton_Click(object sender, EventArgs e)
        {
            if (CurrentCoursesListView.SelectedItems.Count != 0)
            {
                Course courseToDrop = getCourseFromString(CurrentCoursesListView.SelectedItems[0].Text);
                currentStudent.dropCourse(courseToDrop);
                fillCurrentCoursesListView();
            }
        }

        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            bool courseAdded = currentStudent.addCourse(getCourseFromString(CourseInputTextBox.Text));
            
            if(courseAdded == false)
            {
                MessageBox.Show("Could not add course.\nPlease make sure you don't have holds, you have the prerequisites completed, and there is not a time conflict.");
            }
            fillCurrentCoursesListView();
            CourseInputTextBox.Text = "";
        }
    }
    
}
