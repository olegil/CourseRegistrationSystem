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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextbox.Text;
            Student newStudent = new Student();
            if (File.Exists("Users\\" + @username + ".dat"))
            {
                newStudent.fillStudent(username);

                if (PasswordTextBox.Text == newStudent.getPassword())
                {
                    RegistrationForm MyRegister = new RegistrationForm(this, newStudent);
                    MyRegister.Show();
                    UsernameTextbox.Text = "";
                    PasswordTextBox.Text = "";
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password.");
                    PasswordTextBox.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password.");
                PasswordTextBox.Text = "";
            }
        }
    }
}
