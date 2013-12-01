namespace CourseRegistrationSystem
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogOutButton = new System.Windows.Forms.Button();
            this.CatalogButton = new System.Windows.Forms.Button();
            this.StudentIDLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.HoldsLabel = new System.Windows.Forms.Label();
            this.CurrentScheduleLabel = new System.Windows.Forms.Label();
            this.CompletedCoursesLabel = new System.Windows.Forms.Label();
            this.StudentIDTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.HoldsTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(582, 119);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(77, 27);
            this.LogOutButton.TabIndex = 0;
            this.LogOutButton.Text = "Logout";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // CatalogButton
            // 
            this.CatalogButton.Location = new System.Drawing.Point(568, 50);
            this.CatalogButton.Name = "CatalogButton";
            this.CatalogButton.Size = new System.Drawing.Size(107, 29);
            this.CatalogButton.TabIndex = 1;
            this.CatalogButton.Text = "Open Catalog";
            this.CatalogButton.UseVisualStyleBackColor = true;
            this.CatalogButton.Click += new System.EventHandler(this.CatalogButton_Click);
            // 
            // StudentIDLabel
            // 
            this.StudentIDLabel.AutoSize = true;
            this.StudentIDLabel.Location = new System.Drawing.Point(50, 50);
            this.StudentIDLabel.Name = "StudentIDLabel";
            this.StudentIDLabel.Size = new System.Drawing.Size(78, 17);
            this.StudentIDLabel.TabIndex = 2;
            this.StudentIDLabel.Text = "Student ID:";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(50, 144);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(80, 17);
            this.LastNameLabel.TabIndex = 3;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(50, 100);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(80, 17);
            this.FirstNameLabel.TabIndex = 4;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // HoldsLabel
            // 
            this.HoldsLabel.AutoSize = true;
            this.HoldsLabel.Location = new System.Drawing.Point(50, 189);
            this.HoldsLabel.Name = "HoldsLabel";
            this.HoldsLabel.Size = new System.Drawing.Size(48, 17);
            this.HoldsLabel.TabIndex = 5;
            this.HoldsLabel.Text = "Holds:";
            // 
            // CurrentScheduleLabel
            // 
            this.CurrentScheduleLabel.AutoSize = true;
            this.CurrentScheduleLabel.Location = new System.Drawing.Point(50, 250);
            this.CurrentScheduleLabel.Name = "CurrentScheduleLabel";
            this.CurrentScheduleLabel.Size = new System.Drawing.Size(122, 17);
            this.CurrentScheduleLabel.TabIndex = 6;
            this.CurrentScheduleLabel.Text = "Current Schedule:";
            // 
            // CompletedCoursesLabel
            // 
            this.CompletedCoursesLabel.AutoSize = true;
            this.CompletedCoursesLabel.Location = new System.Drawing.Point(400, 250);
            this.CompletedCoursesLabel.Name = "CompletedCoursesLabel";
            this.CompletedCoursesLabel.Size = new System.Drawing.Size(135, 17);
            this.CompletedCoursesLabel.TabIndex = 7;
            this.CompletedCoursesLabel.Text = "Completed Courses:";
            // 
            // StudentIDTextBox
            // 
            this.StudentIDTextBox.Location = new System.Drawing.Point(150, 50);
            this.StudentIDTextBox.Name = "StudentIDTextBox";
            this.StudentIDTextBox.ReadOnly = true;
            this.StudentIDTextBox.Size = new System.Drawing.Size(166, 22);
            this.StudentIDTextBox.TabIndex = 8;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(150, 100);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.ReadOnly = true;
            this.FirstNameTextBox.Size = new System.Drawing.Size(166, 22);
            this.FirstNameTextBox.TabIndex = 9;
            // 
            // HoldsTextBox
            // 
            this.HoldsTextBox.Location = new System.Drawing.Point(150, 189);
            this.HoldsTextBox.Name = "HoldsTextBox";
            this.HoldsTextBox.ReadOnly = true;
            this.HoldsTextBox.Size = new System.Drawing.Size(166, 22);
            this.HoldsTextBox.TabIndex = 10;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(150, 144);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.ReadOnly = true;
            this.LastNameTextBox.Size = new System.Drawing.Size(166, 22);
            this.LastNameTextBox.TabIndex = 11;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.ControlBox = false;
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.HoldsTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.StudentIDTextBox);
            this.Controls.Add(this.CompletedCoursesLabel);
            this.Controls.Add(this.CurrentScheduleLabel);
            this.Controls.Add(this.HoldsLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.StudentIDLabel);
            this.Controls.Add(this.CatalogButton);
            this.Controls.Add(this.LogOutButton);
            this.MaximizeBox = false;
            this.Name = "RegistrationForm";
            this.Text = "Course Registration System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button CatalogButton;
        private System.Windows.Forms.Label StudentIDLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label HoldsLabel;
        private System.Windows.Forms.Label CurrentScheduleLabel;
        private System.Windows.Forms.Label CompletedCoursesLabel;
        private System.Windows.Forms.TextBox StudentIDTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox HoldsTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;

    }
}