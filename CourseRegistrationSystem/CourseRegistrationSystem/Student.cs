using System;

namespace CourseRegistrationSystem
{
    public class Student
    {
        string studentID;
        string studentFirstName;
        string studentLastName;
        string password;
        string emailAddress;

        string holdStatus;

        string[] completedCoursesStrings = new string[1];
        string[] currentCoursesStrings = new string[1];

        Course[] completedCourses = new Course[1];
        Course[] currentCourses = new Course[1];

        public Student()
        {
        }

        public void fillStudent(string fileName)
        {
            char tempChar;
            int counter = 0;

            System.IO.StreamReader fromDat = new System.IO.StreamReader(@fileName + ".dat");

            studentID = fromDat.ReadLine();
            studentFirstName = fromDat.ReadLine();
            studentLastName = fromDat.ReadLine();
            password = fromDat.ReadLine();
            emailAddress = fromDat.ReadLine();
            holdStatus = fromDat.ReadLine();
            
            fromDat.Read();
            tempChar = (char)fromDat.Peek();

            while (tempChar != '}' || fromDat.EndOfStream)
            {
                fromDat.Read(completedCoursesStrings[counter].ToCharArray(), 0, 6);
                counter++;
                tempChar = (char)fromDat.Read();
                Array.Resize(ref completedCoursesStrings, completedCoursesStrings.Length + 1);
            }

            fromDat.ReadLine();

            fromDat.Read();
            tempChar = (char)fromDat.Peek();

            while (tempChar != '}' || fromDat.EndOfStream)
            {
                fromDat.Read(currentCoursesStrings[counter].ToCharArray(), 0, 6);
                counter++;
                tempChar = (char)fromDat.Read();
                Array.Resize(ref currentCoursesStrings, completedCoursesStrings.Length + 1);
            }

            fromDat.ReadLine();

            fromDat.Close();
        }

        public bool addCourse(Course courseToAdd)
        {
            bool canAdd = true;

            if (prereqsMet(courseToAdd) && courseToAdd.isOpen())
                canAdd = true;

            if (canAdd)
                courseToAdd.addStudent();

            return canAdd;
        }

        public bool dropCourse(Course courseToDrop)
        {
            bool canDrop = false;

            for (int a = 0; a < currentCourses.Length && canDrop == false; a++)
            {
                if (courseToDrop == currentCourses[a])
                    canDrop = true;
            }

            if (canDrop)
                courseToDrop.removeStudent();

            return canDrop;
        }

        public bool prereqsMet(Course courseToAdd)
        {
            bool areMet = false;

            Course[] requiredCourses = courseToAdd.getPrereqs();

            if (requiredCourses.Length == 0)
                areMet = true;
            else
            {
                for (int a = 0; a < requiredCourses.Length && areMet == true; a++)
                {
                    for (int c = 0; c < completedCourses.Length; c++)
                    {
                        if (requiredCourses[a] == completedCourses[c])
                            areMet = true;
                        else
                            areMet = false;
                    }
                }
            }

            return areMet;
        }

        public bool timeOverlap(Course courseToAdd)
        {
            bool isOverlapping = false;

            if (currentCourses.Length == 0)
                isOverlapping = false;
            else
            {
                for (int a = 0; a < currentCourses.Length && isOverlapping == true; a++)
                {
                    if (courseToAdd.getStartTime() > currentCourses[a].getStartTime() && courseToAdd.getStartTime() < currentCourses[a].getEndTime())
                        isOverlapping = true;
                    else
                        isOverlapping = false;

                    if (courseToAdd.getEndTime() > currentCourses[a].getStartTime() && courseToAdd.getStartTime() < currentCourses[a].getEndTime())
                        isOverlapping = true;
                    else
                        isOverlapping = false;
                }
            }

            return isOverlapping;
        }

        public string getStudentID()
        {
            return studentID;
        }
        public string getStudentFirstName()
        {
            return studentFirstName;
        }
        public string getStudentLastName()
        {
            return studentLastName;
        }
        public string getPassword()
        {
            return password;
        }
        public string getEmailAddress()
        {
            return emailAddress;
        }
        public bool getHoldStatus()
        {
            bool tempStatus = false;
            if (holdStatus == "1")
                tempStatus = true;
            return tempStatus;
        }
    }
}