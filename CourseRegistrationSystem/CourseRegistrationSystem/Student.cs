using System;

namespace CourseRegistrationSystem
{
    public class Student
    {
        //----------------------
        // Private Data Members
        //----------------------
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

        //---------------------
        // Default constructor
        //---------------------
        public Student()
        {
        }

        // reads information from the filename path to fill the data members
        // dat files should be in the following format
        /*
         * student id
         * student first name
         * student last name
         * password
         * email address
         * hold status
         * {completed class 1, completed class 2, ..., completed class n}
         * {current course 1, current course 2, ..., current course n}
         */
        public void fillStudent(string fileName)
        {
            char tempChar;
            int counter = 0;

            System.IO.StreamReader fromDat = new System.IO.StreamReader("Users\\" + @fileName + ".dat");

            // Fills out the data members of the student object 
            studentID = fromDat.ReadLine();
            studentFirstName = fromDat.ReadLine();
            studentLastName = fromDat.ReadLine();
            password = fromDat.ReadLine();
            emailAddress = fromDat.ReadLine();
            holdStatus = fromDat.ReadLine();
            
            // Parses the completed courses for the student
            fromDat.Read();
            tempChar = (char)fromDat.Peek();

            while (tempChar != '}' && !fromDat.EndOfStream)
            {
                while (fromDat.Peek() != ',' && fromDat.Peek() != '}')
                {
                    completedCoursesStrings[counter] += (char)fromDat.Read();
                }
                counter++;
                tempChar = (char)fromDat.Read();
                Array.Resize(ref completedCoursesStrings, completedCoursesStrings.Length + 1);
            }
            counter = 0;
            fromDat.ReadLine();

            // Parses the current courses for the student
            fromDat.Read();
            tempChar = (char)fromDat.Peek();
            while (tempChar != '}' && !fromDat.EndOfStream)
            {
                while (fromDat.Peek() != ',' && fromDat.Peek() != '}')
                {
                    currentCoursesStrings[counter] += (char)fromDat.Read();
                }
                counter++;
                tempChar = (char)fromDat.Read();
                Array.Resize(ref currentCoursesStrings, currentCoursesStrings.Length + 1);
            }
            counter = 0;
            fromDat.ReadLine();

            fromDat.Close();

            // Trimming null spots from arrays
            Array.Resize(ref completedCoursesStrings, completedCoursesStrings.Length - 1);
            Array.Resize(ref currentCoursesStrings, currentCoursesStrings.Length - 1);
        }
        
        // Adds a course object to the students current courses array
        public bool addCourse(Course courseToAdd)
        {
            //System.IO.StreamReader fromDat = new System.IO.StreamReader("Users\\" + studentLastName + studentFirstName[0] + studentID[studentID.Length - 1]+ ".dat");


            bool canAdd = false;

            if (prereqsMet(courseToAdd) && courseToAdd.isOpen() && !timeOverlap(courseToAdd))
            {
                string[] fileContents = System.IO.File.ReadAllLines("Users\\" + studentLastName + studentFirstName[0] + studentID[studentID.Length - 1] + ".dat");
                fileContents[7] = "{";
                canAdd = true;
                Array.Resize(ref currentCourses, currentCourses.Length + 1);
                currentCourses[currentCourses.Length - 1] = courseToAdd;
                courseToAdd.addStudent();
                for (int n = 0; n < currentCourses.Length; n++)
                {
                    fileContents[7] += currentCourses[n].getCourseNumber().ToString();
                    if (n < currentCourses.Length - 1)
                        fileContents[7] += ",";
                }
                        fileContents[7] += "}";
                System.IO.File.WriteAllLines("Users\\" + studentLastName + studentFirstName[0] + studentID[studentID.Length - 1] + ".dat", fileContents);
            }

            return canAdd;
        }

        // Removes a course object from the students current courses array
        public bool dropCourse(Course courseToDrop)
        {
            bool canDrop = false;

            for (int a = 0; a < currentCourses.Length && canDrop == false; a++)
            {
                if (courseToDrop == currentCourses[a])
                {
                    canDrop = true;

                    for (int n = a; n < currentCourses.Length - 1; n++)
                    {
                        currentCourses[n] = currentCourses[n + 1];
                    }
                }
            }

            if (canDrop)
            {
                string[] fileContents = System.IO.File.ReadAllLines("Users\\" + studentLastName + studentFirstName[0] + studentID[studentID.Length - 1] + ".dat");
                fileContents[7] = "{";
                Array.Resize(ref currentCourses, currentCourses.Length - 1);
                courseToDrop.removeStudent();
                for (int n = 0; n < currentCourses.Length; n++)
                {
                    fileContents[7] += currentCourses[n].getCourseNumber().ToString();
                    if (n < currentCourses.Length - 1)
                        fileContents[7] += ",";                        
                }
                    fileContents[7] += "}";
                System.IO.File.WriteAllLines("Users\\" + studentLastName + studentFirstName[0] + studentID[studentID.Length - 1] + ".dat", fileContents);
            }

            return canDrop;
        }

        // Compares the prerequisits of the input course with the completed courses array to determine if the prereqs are met
        public bool prereqsMet(Course courseToAdd)
        {
            bool allReqsMet = true;
            string[] requiredCourses = courseToAdd.getPrereqsStrings();
            bool[] areMet = new bool[requiredCourses.Length];

            for (int b = 0; b < requiredCourses.Length; b++)
            {
                areMet[b] = false;
            }

            if (requiredCourses.Length != 0)
            {
                for (int a = 0; a < requiredCourses.Length; a++)
                {
                    for (int c = 0; c < completedCoursesStrings.Length; c++)
                    {
                        if (requiredCourses[a] == completedCoursesStrings[c])
                            areMet[a] = true;
                    }
                }
            }

            for (int n = 0; n < requiredCourses.Length; n++)
            {
                allReqsMet = allReqsMet & areMet[n];
            }
            return allReqsMet;
        }

        // Compares the current schedule of the student and the propsed class to add to check for time conflictions
        public bool timeOverlap(Course courseToAdd)
        {
            bool isOverlapping = false;

            if (currentCourses.Length == 0)
                isOverlapping = false;
            else
            {
                for (int a = 0; a < currentCourses.Length && isOverlapping == false; a++)
                {
                    if (   (courseToAdd.getStartTime() >= currentCourses[a].getStartTime() && courseToAdd.getStartTime() <= currentCourses[a].getEndTime() && (courseToAdd.getDays() == currentCourses[a].getDays()))
                        || (courseToAdd.getStartTime() == currentCourses[a].getStartTime() && (courseToAdd.getDays() == currentCourses[a].getDays()))
                        || (courseToAdd.getStartTime() == currentCourses[a].getEndTime() && (courseToAdd.getDays() == currentCourses[a].getDays()))
                        || (courseToAdd.getEndTime() >= currentCourses[a].getStartTime() && courseToAdd.getStartTime() <= currentCourses[a].getEndTime() && (courseToAdd.getDays() == currentCourses[a].getDays()))
                        || (courseToAdd.getEndTime() == currentCourses[a].getEndTime() && (courseToAdd.getDays() == currentCourses[a].getDays()))
                        || (courseToAdd.getEndTime() == currentCourses[a].getStartTime() && (courseToAdd.getDays() == currentCourses[a].getDays())))
                        isOverlapping = true;
                }
            }
            return isOverlapping;
        }

        //--------------------
        // Standard accessors
        //--------------------
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
        public string[] getCurrentSchedule()
        {
            return currentCoursesStrings;
        }

        public Course[] getCurrentCourses()
        {
            return currentCourses;
        }

        public string[] getCompletedCourses()
        {
            return completedCoursesStrings;
        }

        public void setCurrentCourses(Course[] courses)
        {
            currentCourses = courses;
        }
    }
}