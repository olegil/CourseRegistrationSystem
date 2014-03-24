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

        // logs the current user out and returns to the login screen
        private void LogOutButton_Click(object sender, EventArgs e)
        {
            myLoginForm.Show();
            this.Close();
        }

        // Opens the catalog form
        private void CatalogButton_Click(object sender, EventArgs e)
        {
            loadCourses();
            myCatalogForm = new CatalogForm(courseList);
            myCatalogForm.Show();
        }

        // Updates the loaded students information into the text boxes and listview
        public void updateInfo()
        {
            StudentIDTextBox.Text = currentStudent.getStudentID();
            FirstNameTextBox.Text = currentStudent.getStudentFirstName();
            LastNameTextBox.Text = currentStudent.getStudentLastName();
            HoldsTextBox.Text = currentStudent.getHoldStatus().ToString();
            fillCurrentCoursesListView();
            ListViewItem completedCoursesListViewItems;

            for (int n = 0; n < currentStudent.getCompletedCourses().Length; n++)
            {
                completedCoursesListViewItems = new ListViewItem(currentStudent.getCompletedCourses()[n]);
                CompletedCoursesListView.Items.Add(completedCoursesListViewItems);
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

        // Given a string (the course number), will return the course with that CRN
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

        // On click, removes the course from the users current courses in their dat file and reduces occupied seats in the course dat file
        private void DropCourseButton_Click(object sender, EventArgs e)
        {
            if (CurrentCoursesListView.SelectedItems.Count != 0)
            {
                Course courseToDrop = getCourseFromString(CurrentCoursesListView.SelectedItems[0].Text);
                currentStudent.dropCourse(courseToDrop);
                fillCurrentCoursesListView();
            }
        }

        // On click, adds the course in the courseInputTextBox to the users current courses, and in their dat file.  Increments occupied seats in course dat file
        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            bool courseAdded = currentStudent.addCourse(getCourseFromString(CourseInputTextBox.Text));
            
            if(courseAdded == false && CourseInputTextBox.Text != "")
            {
                MessageBox.Show("Could not add course.\nPlease make sure you don't have holds, you have the prerequisites completed, and there is not a time conflict.");
            }
            fillCurrentCoursesListView();
            CourseInputTextBox.Text = "";
        }

        // On button click, emails the courses listed under "current schedule" to the user at the email address provided in the dat file
        private void EmailScheduleButton_Click(object sender, EventArgs e)
        {
            System.Net.Mail.SmtpClient mySmtp = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
            System.Net.NetworkCredential myCreds = new System.Net.NetworkCredential("TeamFusionSystems@gmail.com", "courseregistration");
            mySmtp.Credentials = myCreds;
            mySmtp.EnableSsl = true;

            string emailBody = "";

            emailBody = "<table border=\"1\" bordercolor=\"#FFCC00\" style=\"background-color:#00BFFF\" width=\"100%\" cellpadding=\"3\" cellspacing=\"2\">";

            emailBody +=
                        "<tr>"
                      + "<td align=\"center\">" + "<b>CRN" + "</td>"
                      + "<td align=\"center\">" + "<b>Class" + "</td>"
                      + "<td align=\"center\">" + "<b>Course Name" + "</td>"
                      + "<td align=\"center\">" + "<b>Starts" + "-" + "Ends" + "</td>"
                      + "<td align=\"center\">" + "<b>Days" + "</td>"
                      + "</tr>";
            for(int n = 0; n < currentStudent.getCurrentCourses().Length; n++)
            {
                emailBody +=
                        "<tr>"
                      + "<td align=\"center\">" + currentStudent.getCurrentCourses()[n].getCourseNumber() + "</td>"
                      + "<td align=\"center\">" + currentStudent.getCurrentCourses()[n].getSubject() + " " + currentStudent.getCurrentCourses()[n].getfourDigits() + "</td>"
                      + "<td align=\"center\">" + currentStudent.getCurrentCourses()[n].getCourseName() + "</td>"
                      + "<td align=\"center\">" + currentStudent.getCurrentCourses()[n].getStartTime() + "-" + currentStudent.getCurrentCourses()[n].getEndTime() + "</td>"
                      + "<td align=\"center\">" + currentStudent.getCurrentCourses()[n].getDays() + "</td>"
                      + "</tr>";
            }

            emailBody += "</table>";

            System.Net.Mail.MailMessage myEmail = new System.Net.Mail.MailMessage("TeamFusionSystems@gmail.com", currentStudent.getEmailAddress(), "Your Requested School Schedule", emailBody);
            myEmail.IsBodyHtml = true;
            mySmtp.Send(myEmail);

            MessageBox.Show("Email has been sent to " + currentStudent.getEmailAddress());
        }
    }
    
}
