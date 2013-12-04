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
            fillCatalog();
            
        }

        // Fills the catalog listview
        public void fillCatalog()
        {
            ListViewItem courseListViewItems;
            string prereqs = "";

            for (int n = 0; n < courseListObjects.Length; n++ )
            {
                courseListViewItems = new ListViewItem((courseListObjects[n].getCourseNumber().ToString()));
                courseListViewItems.SubItems.Add((courseListObjects[n].getSubject().ToString()));
                courseListViewItems.SubItems.Add((courseListObjects[n].getfourDigits().ToString()));
                courseListViewItems.SubItems.Add((courseListObjects[n].getCourseName().ToString()));
                courseListViewItems.SubItems.Add((courseListObjects[n].getStartTime().ToString()));
                courseListViewItems.SubItems.Add((courseListObjects[n].getEndTime().ToString()));
                courseListViewItems.SubItems.Add((courseListObjects[n].getDays().ToString()));
                courseListViewItems.SubItems.Add(courseListObjects[n].getOpenSeats().ToString());

                for (int b = 0; b < courseListObjects[n].getPrereqsStrings().Length; b++)
                {
                    prereqs += " " + courseListObjects[n].getPrereqsStrings()[b];
                }
                courseListViewItems.SubItems.Add(prereqs);

                CatalogListView.Items.Add(courseListViewItems);
                prereqs = "";
            }
            
        }
    }
}
