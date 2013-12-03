﻿using System;
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
            loadCourses();
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
            CurrentScheduleListBox.Items.AddRange(currentStudent.getCurrentSchedule());
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
                else
                    Console.WriteLine(tempCourse + " file does not exist...");
                tempCourse = "";
            }
            
            fromDat.Close();

            Array.Resize(ref courseList, courseList.Length - 1);
        }
    }
}
