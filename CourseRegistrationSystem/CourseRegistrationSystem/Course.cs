using System;

namespace CourseRegistrationSystem
{
    public class Course
    {
        //----------------------
        // Private Data Members
        //----------------------
        int courseNumber;
        int startTime;
        int endTime;
        int currentEnrolled;
        int maxEnrolled;

        string courseName;
        string subject;
        string fourDigits;
        string days;

        string[] prereqsStrings = new string[1];
        Course[] prereqs = new Course[1];


        //---------------------
        // Default constructor
        //---------------------
        public Course()
        {
            courseNumber = 123456;
            startTime = 1200;
            endTime = 1345;
            currentEnrolled = 20;
            maxEnrolled = 40;

            courseName = "Calculus I";
            subject = "Math";
            fourDigits = "2402";
            days = "MW";
        }

        public Course(string fileName)
        {
            char tempChar;
            int counter = 0;

            System.IO.StreamReader fromDat = new System.IO.StreamReader("Courses\\" + @fileName + ".dat");

            courseNumber = int.Parse(fromDat.ReadLine());
            startTime = int.Parse(fromDat.ReadLine());
            endTime = int.Parse(fromDat.ReadLine());
            currentEnrolled = int.Parse(fromDat.ReadLine());
            maxEnrolled = int.Parse(fromDat.ReadLine());
            courseName = fromDat.ReadLine();
            subject = fromDat.ReadLine();
            fourDigits = fromDat.ReadLine();
            days = fromDat.ReadLine();

            fromDat.Read();
            tempChar = (char)fromDat.Peek();

            while (tempChar != '}' && !fromDat.EndOfStream)
            {
                while (fromDat.Peek() != ',' && fromDat.Peek() != '}')
                {
                    prereqsStrings[counter] += (char)fromDat.Read();
                }
                counter++;
                tempChar = (char)fromDat.Read();
                Array.Resize(ref prereqsStrings, prereqsStrings.Length + 1);
            }

            fromDat.Close();
            Array.Resize(ref prereqsStrings, prereqsStrings.Length - 1);
        }

        //-------------------------
        // Public member functions
        //-------------------------

        // reads information from the filename path to fill the data members
        // dat files should be in the following format
        /*
         * course number
         * start time
         * end time
         * current number of students enrolled
         * maximum possible students enrolled
         * course name
         * subject
         * class code
         * days of the week
         * prerequisites
         */
        public void fillCourse(string fileName)
        {
            char tempChar;
            int counter = 0;

            System.IO.StreamReader fromDat = new System.IO.StreamReader("Courses\\" + @fileName + ".dat");

            courseNumber = int.Parse(fromDat.ReadLine());
            startTime = int.Parse(fromDat.ReadLine());
            endTime = int.Parse(fromDat.ReadLine());
            currentEnrolled = int.Parse(fromDat.ReadLine());
            maxEnrolled = int.Parse(fromDat.ReadLine());
            courseName = fromDat.ReadLine();
            subject = fromDat.ReadLine();
            fourDigits = fromDat.ReadLine();
            days = fromDat.ReadLine();

            fromDat.Read();
            tempChar = (char)fromDat.Peek();

            while (tempChar != '}' && !fromDat.EndOfStream)
            {
                while (fromDat.Peek() != ',' && fromDat.Peek() != '}')
                {
                    prereqsStrings[counter] += (char)fromDat.Read();
                }
                counter++;
                tempChar = (char)fromDat.Read();
                Array.Resize(ref prereqsStrings, prereqsStrings.Length + 1);
            }

            fromDat.Close();
            Array.Resize(ref prereqsStrings, prereqsStrings.Length - 1);
        }

        // returns ture if there is room for another student
        public bool isOpen()
        {
            bool isRoom = false;

            if (maxEnrolled - currentEnrolled > 0)
                isRoom = true;

            return isRoom;
        }

        public string toString()
        {
            return courseNumber + " " + subject + " " + fourDigits + " " + courseName + " " + startTime + "-" + endTime + " " + days + "\n";
        }

        //--------------------
        // Standard accessors
        //--------------------
        public int getOpenSeats()
        {
            return maxEnrolled - currentEnrolled;
        }
        public int getCourseNumber()
        {
            return courseNumber;
        }

        public int getStartTime()
        {
            return startTime;
        }

        public int getEndTime()
        {
            return endTime;
        }

        public string getCourseName()
        {
            return courseName;
        }

        public string getSubject()
        {
            return subject;
        }

        public string getfourDigits()
        {
            return fourDigits;
        }

        public string getDays()
        {
            return days;
        }

        public string[] getPrereqsStrings()
        {
            return prereqsStrings;
        }

        // Increments class enrollment by 1, writes new total to the course dat file
        public void addStudent()
        {
            currentEnrolled++;
            string[] fileContents = System.IO.File.ReadAllLines("Courses\\" + courseNumber.ToString() + ".dat");
            fileContents[3] = currentEnrolled.ToString();
            System.IO.File.WriteAllLines("Courses\\" + courseNumber.ToString() + ".dat", fileContents);
        }
        // Decreases class enrollment by 1, writes new total to the course dat file
        public void removeStudent()
        {
            currentEnrolled--;
            string[] fileContents = System.IO.File.ReadAllLines("Courses\\" + courseNumber.ToString() + ".dat");
            fileContents[3] = currentEnrolled.ToString();
            System.IO.File.WriteAllLines("Courses\\" + courseNumber.ToString() + ".dat", fileContents);
        }
    }
}