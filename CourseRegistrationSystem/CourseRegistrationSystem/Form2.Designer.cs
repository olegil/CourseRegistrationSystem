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
            this.CompletedCoursesTextBox = new System.Windows.Forms.TextBox();
            this.AddCourseButton = new System.Windows.Forms.Button();
            this.DropCourseButton = new System.Windows.Forms.Button();
            this.CurrentCoursesListView = new System.Windows.Forms.ListView();
            this.CourseNumberColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubjectColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FourDigitsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CourseNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartTimeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndTimeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DaysColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmailScheduleButton = new System.Windows.Forms.Button();
            this.CourseInputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(643, 79);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(77, 25);
            this.LogOutButton.TabIndex = 1;
            this.LogOutButton.Text = "Logout";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // CatalogButton
            // 
            this.CatalogButton.Location = new System.Drawing.Point(613, 114);
            this.CatalogButton.Name = "CatalogButton";
            this.CatalogButton.Size = new System.Drawing.Size(107, 25);
            this.CatalogButton.TabIndex = 0;
            this.CatalogButton.Text = "Open Catalog";
            this.CatalogButton.UseVisualStyleBackColor = true;
            this.CatalogButton.Click += new System.EventHandler(this.CatalogButton_Click);
            // 
            // StudentIDLabel
            // 
            this.StudentIDLabel.AutoSize = true;
            this.StudentIDLabel.Location = new System.Drawing.Point(14, 31);
            this.StudentIDLabel.Name = "StudentIDLabel";
            this.StudentIDLabel.Size = new System.Drawing.Size(78, 17);
            this.StudentIDLabel.TabIndex = 2;
            this.StudentIDLabel.Text = "Student ID:";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(14, 145);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(80, 17);
            this.LastNameLabel.TabIndex = 3;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(14, 87);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(80, 17);
            this.FirstNameLabel.TabIndex = 4;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // HoldsLabel
            // 
            this.HoldsLabel.AutoSize = true;
            this.HoldsLabel.Location = new System.Drawing.Point(14, 198);
            this.HoldsLabel.Name = "HoldsLabel";
            this.HoldsLabel.Size = new System.Drawing.Size(48, 17);
            this.HoldsLabel.TabIndex = 5;
            this.HoldsLabel.Text = "Holds:";
            // 
            // CurrentScheduleLabel
            // 
            this.CurrentScheduleLabel.AutoSize = true;
            this.CurrentScheduleLabel.Location = new System.Drawing.Point(14, 228);
            this.CurrentScheduleLabel.Name = "CurrentScheduleLabel";
            this.CurrentScheduleLabel.Size = new System.Drawing.Size(122, 17);
            this.CurrentScheduleLabel.TabIndex = 6;
            this.CurrentScheduleLabel.Text = "Current Schedule:";
            // 
            // CompletedCoursesLabel
            // 
            this.CompletedCoursesLabel.AutoSize = true;
            this.CompletedCoursesLabel.Location = new System.Drawing.Point(305, 8);
            this.CompletedCoursesLabel.Name = "CompletedCoursesLabel";
            this.CompletedCoursesLabel.Size = new System.Drawing.Size(135, 17);
            this.CompletedCoursesLabel.TabIndex = 7;
            this.CompletedCoursesLabel.Text = "Completed Courses:";
            // 
            // StudentIDTextBox
            // 
            this.StudentIDTextBox.Location = new System.Drawing.Point(114, 31);
            this.StudentIDTextBox.Name = "StudentIDTextBox";
            this.StudentIDTextBox.ReadOnly = true;
            this.StudentIDTextBox.Size = new System.Drawing.Size(166, 22);
            this.StudentIDTextBox.TabIndex = 8;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(114, 87);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.ReadOnly = true;
            this.FirstNameTextBox.Size = new System.Drawing.Size(166, 22);
            this.FirstNameTextBox.TabIndex = 9;
            // 
            // HoldsTextBox
            // 
            this.HoldsTextBox.Location = new System.Drawing.Point(114, 198);
            this.HoldsTextBox.Name = "HoldsTextBox";
            this.HoldsTextBox.ReadOnly = true;
            this.HoldsTextBox.Size = new System.Drawing.Size(166, 22);
            this.HoldsTextBox.TabIndex = 10;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(114, 145);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.ReadOnly = true;
            this.LastNameTextBox.Size = new System.Drawing.Size(166, 22);
            this.LastNameTextBox.TabIndex = 11;
            // 
            // CompletedCoursesTextBox
            // 
            this.CompletedCoursesTextBox.Location = new System.Drawing.Point(308, 31);
            this.CompletedCoursesTextBox.Multiline = true;
            this.CompletedCoursesTextBox.Name = "CompletedCoursesTextBox";
            this.CompletedCoursesTextBox.ReadOnly = true;
            this.CompletedCoursesTextBox.Size = new System.Drawing.Size(132, 189);
            this.CompletedCoursesTextBox.TabIndex = 13;
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.Location = new System.Drawing.Point(623, 197);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(97, 25);
            this.AddCourseButton.TabIndex = 2;
            this.AddCourseButton.Text = "Add Course";
            this.AddCourseButton.UseVisualStyleBackColor = true;
            this.AddCourseButton.Click += new System.EventHandler(this.AddCourseButton_Click);
            // 
            // DropCourseButton
            // 
            this.DropCourseButton.Location = new System.Drawing.Point(565, 145);
            this.DropCourseButton.Name = "DropCourseButton";
            this.DropCourseButton.Size = new System.Drawing.Size(155, 25);
            this.DropCourseButton.TabIndex = 3;
            this.DropCourseButton.Text = "Drop Selected Course";
            this.DropCourseButton.UseVisualStyleBackColor = true;
            this.DropCourseButton.Click += new System.EventHandler(this.DropCourseButton_Click);
            // 
            // CurrentCoursesListView
            // 
            this.CurrentCoursesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CourseNumberColumn,
            this.SubjectColumn,
            this.FourDigitsColumn,
            this.CourseNameColumn,
            this.StartTimeColumn,
            this.EndTimeColumn,
            this.DaysColumn});
            this.CurrentCoursesListView.FullRowSelect = true;
            this.CurrentCoursesListView.GridLines = true;
            this.CurrentCoursesListView.Location = new System.Drawing.Point(14, 248);
            this.CurrentCoursesListView.Name = "CurrentCoursesListView";
            this.CurrentCoursesListView.Size = new System.Drawing.Size(706, 169);
            this.CurrentCoursesListView.TabIndex = 14;
            this.CurrentCoursesListView.UseCompatibleStateImageBehavior = false;
            this.CurrentCoursesListView.View = System.Windows.Forms.View.Details;
            // 
            // CourseNumberColumn
            // 
            this.CourseNumberColumn.Text = "CRN";
            this.CourseNumberColumn.Width = 72;
            // 
            // SubjectColumn
            // 
            this.SubjectColumn.Text = "Subject";
            this.SubjectColumn.Width = 139;
            // 
            // FourDigitsColumn
            // 
            this.FourDigitsColumn.Text = "Level";
            this.FourDigitsColumn.Width = 50;
            // 
            // CourseNameColumn
            // 
            this.CourseNameColumn.Text = "Course Name";
            this.CourseNameColumn.Width = 252;
            // 
            // StartTimeColumn
            // 
            this.StartTimeColumn.Text = "Starts";
            this.StartTimeColumn.Width = 66;
            // 
            // EndTimeColumn
            // 
            this.EndTimeColumn.Text = "Ends";
            // 
            // DaysColumn
            // 
            this.DaysColumn.Text = "Days";
            this.DaysColumn.Width = 62;
            // 
            // EmailScheduleButton
            // 
            this.EmailScheduleButton.Location = new System.Drawing.Point(607, 48);
            this.EmailScheduleButton.Name = "EmailScheduleButton";
            this.EmailScheduleButton.Size = new System.Drawing.Size(113, 25);
            this.EmailScheduleButton.TabIndex = 15;
            this.EmailScheduleButton.Text = "Email Schedule";
            this.EmailScheduleButton.UseVisualStyleBackColor = true;
            this.EmailScheduleButton.Click += new System.EventHandler(this.EmailScheduleButton_Click);
            // 
            // CourseInputTextBox
            // 
            this.CourseInputTextBox.Location = new System.Drawing.Point(491, 198);
            this.CourseInputTextBox.Name = "CourseInputTextBox";
            this.CourseInputTextBox.Size = new System.Drawing.Size(112, 22);
            this.CourseInputTextBox.TabIndex = 16;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 431);
            this.ControlBox = false;
            this.Controls.Add(this.CourseInputTextBox);
            this.Controls.Add(this.EmailScheduleButton);
            this.Controls.Add(this.CurrentCoursesListView);
            this.Controls.Add(this.DropCourseButton);
            this.Controls.Add(this.AddCourseButton);
            this.Controls.Add(this.CompletedCoursesTextBox);
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
        private System.Windows.Forms.TextBox CompletedCoursesTextBox;
        private System.Windows.Forms.Button AddCourseButton;
        private System.Windows.Forms.Button DropCourseButton;
        private System.Windows.Forms.ListView CurrentCoursesListView;
        private System.Windows.Forms.ColumnHeader CourseNumberColumn;
        private System.Windows.Forms.ColumnHeader SubjectColumn;
        private System.Windows.Forms.ColumnHeader FourDigitsColumn;
        private System.Windows.Forms.ColumnHeader CourseNameColumn;
        private System.Windows.Forms.ColumnHeader StartTimeColumn;
        private System.Windows.Forms.ColumnHeader EndTimeColumn;
        private System.Windows.Forms.ColumnHeader DaysColumn;
        private System.Windows.Forms.Button EmailScheduleButton;
        private System.Windows.Forms.TextBox CourseInputTextBox;

    }
}