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


        //-------------------------
        // Public member functions
        //-------------------------

        // returns ture if there is room for another student
        public bool isOpen()
        {
            bool isRoom = false;

            if (maxEnrolled - currentEnrolled > 0)
                isRoom = true;

            return isRoom;
        }

        //--------------------
        // Standard accessors
        //--------------------
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

        public Course[] getPrereqs()
        {
            return prereqs;
        }

        // Increments class enrollment by 1
        public void addStudent()
        {
            currentEnrolled++;
        }
        // Decreases class enrollment by 1
        public void removeStudent()
        {
            currentEnrolled--;
        }
    }
}