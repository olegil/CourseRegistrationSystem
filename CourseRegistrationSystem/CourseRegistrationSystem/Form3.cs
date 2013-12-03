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
    public partial class CatalogForm : Form
    {
        string[] courseList;
        Course[] courseListObjects;

        public CatalogForm(Course[] courses)
        {
            courseListObjects = courses;
            courseList = new string[courses.Length];

            for (int n = 0; n < courseList.Length; n++)
            {
                courseList[n] = courses[n].toString();
            }

            InitializeComponent();
            //CatalogListBox.Items.AddRange(courseList);
            fillCatalog();
            
        }

        public void fillCatalog()
        {
            //CatalogListView.s
            //CatalogListView.Columns.Add("CRN", 60, HorizontalAlignment.Left);
            for (int n = 0; n < courseListObjects.Length; n++ )
            {
                CatalogListView.Items.Add((courseListObjects[n].getCourseNumber().ToString()));
            }

            //CatalogListView.Columns.Add("Subject", 100, HorizontalAlignment.Left);
            for (int n = 0; n < courseListObjects.Length; n++)
            {
                CatalogListView.Items.Add((courseListObjects[n].getSubject().ToString()));
            }

            //CatalogListView.Columns.Add("Level", 40, HorizontalAlignment.Left);
            for (int n = 0; n < courseListObjects.Length; n++)
            {
                CatalogListView.Items.Add((courseListObjects[n].getfourDigits().ToString()));
            }

            //CatalogListView.Columns.Add("Course Name", 100, HorizontalAlignment.Left);
            for (int n = 0; n < courseListObjects.Length; n++)
            {
                CatalogListView.Items.Add((courseListObjects[n].getCourseName().ToString()));
            }

            //CatalogListView.Columns.Add("Starts", 60, HorizontalAlignment.Left);
            for (int n = 0; n < courseListObjects.Length; n++)
            {
                CatalogListView.Items.Add((courseListObjects[n].getStartTime().ToString()));
            }

            //CatalogListView.Columns.Add("Ends", 60, HorizontalAlignment.Left);
            for (int n = 0; n < courseListObjects.Length; n++)
            {
                CatalogListView.Items.Add((courseListObjects[n].getEndTime().ToString()));
            }
            
            //CatalogListView.Columns.Add("Days", 60, HorizontalAlignment.Left);
            for (int n = 0; n < courseListObjects.Length; n++)
            {
                CatalogListView.Items.Add((courseListObjects[n].getDays().ToString()));
            }
            
            //CatalogListView.Columns.Add("Prerequisites", 60, HorizontalAlignment.Left);
            for (int n = 0; n < courseListObjects.Length; n++)
            {
                for (int b = 0; b < courseListObjects[n].getPrereqsStrings().Length; b++)
                {
                    CatalogListView.Items.Add((courseListObjects[n].getPrereqsStrings()[b]));
                }
            }
        }
    }
}
