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
            this.SuspendLayout();
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(693, 31);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(77, 27);
            this.LogOutButton.TabIndex = 1;
            this.LogOutButton.Text = "Logout";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // CatalogButton
            // 
            this.CatalogButton.Location = new System.Drawing.Point(667, 64);
            this.CatalogButton.Name = "CatalogButton";
            this.CatalogButton.Size = new System.Drawing.Size(107, 29);
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
            this.LastNameLabel.Location = new System.Drawing.Point(14, 125);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(80, 17);
            this.LastNameLabel.TabIndex = 3;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(14, 81);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(80, 17);
            this.FirstNameLabel.TabIndex = 4;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // HoldsLabel
            // 
            this.HoldsLabel.AutoSize = true;
            this.HoldsLabel.Location = new System.Drawing.Point(14, 170);
            this.HoldsLabel.Name = "HoldsLabel";
            this.HoldsLabel.Size = new System.Drawing.Size(48, 17);
            this.HoldsLabel.TabIndex = 5;
            this.HoldsLabel.Text = "Holds:";
            // 
            // CurrentScheduleLabel
            // 
            this.CurrentScheduleLabel.AutoSize = true;
            this.CurrentScheduleLabel.Location = new System.Drawing.Point(12, 354);
            this.CurrentScheduleLabel.Name = "CurrentScheduleLabel";
            this.CurrentScheduleLabel.Size = new System.Drawing.Size(122, 17);
            this.CurrentScheduleLabel.TabIndex = 6;
            this.CurrentScheduleLabel.Text = "Current Schedule:";
            // 
            // CompletedCoursesLabel
            // 
            this.CompletedCoursesLabel.AutoSize = true;
            this.CompletedCoursesLabel.Location = new System.Drawing.Point(361, 29);
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
            this.FirstNameTextBox.Location = new System.Drawing.Point(114, 81);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.ReadOnly = true;
            this.FirstNameTextBox.Size = new System.Drawing.Size(166, 22);
            this.FirstNameTextBox.TabIndex = 9;
            // 
            // HoldsTextBox
            // 
            this.HoldsTextBox.Location = new System.Drawing.Point(114, 170);
            this.HoldsTextBox.Name = "HoldsTextBox";
            this.HoldsTextBox.ReadOnly = true;
            this.HoldsTextBox.Size = new System.Drawing.Size(166, 22);
            this.HoldsTextBox.TabIndex = 10;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(114, 125);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.ReadOnly = true;
            this.LastNameTextBox.Size = new System.Drawing.Size(166, 22);
            this.LastNameTextBox.TabIndex = 11;
            // 
            // CompletedCoursesTextBox
            // 
            this.CompletedCoursesTextBox.Location = new System.Drawing.Point(364, 49);
            this.CompletedCoursesTextBox.Multiline = true;
            this.CompletedCoursesTextBox.Name = "CompletedCoursesTextBox";
            this.CompletedCoursesTextBox.ReadOnly = true;
            this.CompletedCoursesTextBox.Size = new System.Drawing.Size(132, 236);
            this.CompletedCoursesTextBox.TabIndex = 13;
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.Location = new System.Drawing.Point(673, 129);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(97, 24);
            this.AddCourseButton.TabIndex = 2;
            this.AddCourseButton.Text = "Add Course";
            this.AddCourseButton.UseVisualStyleBackColor = true;
            // 
            // DropCourseButton
            // 
            this.DropCourseButton.Location = new System.Drawing.Point(619, 99);
            this.DropCourseButton.Name = "DropCourseButton";
            this.DropCourseButton.Size = new System.Drawing.Size(155, 24);
            this.DropCourseButton.TabIndex = 3;
            this.DropCourseButton.Text = "Drop Selected Course";
            this.DropCourseButton.UseVisualStyleBackColor = true;
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
            this.CurrentCoursesListView.Location = new System.Drawing.Point(12, 374);
            this.CurrentCoursesListView.Name = "CurrentCoursesListView";
            this.CurrentCoursesListView.Size = new System.Drawing.Size(590, 169);
            this.CurrentCoursesListView.TabIndex = 14;
            this.CurrentCoursesListView.UseCompatibleStateImageBehavior = false;
            this.CurrentCoursesListView.View = System.Windows.Forms.View.Details;
            // 
            // CourseNumberColumn
            // 
            this.CourseNumberColumn.Text = "CRN";
            // 
            // SubjectColumn
            // 
            this.SubjectColumn.Text = "Subject";
            this.SubjectColumn.Width = 125;
            // 
            // FourDigitsColumn
            // 
            this.FourDigitsColumn.Text = "Level";
            this.FourDigitsColumn.Width = 50;
            // 
            // CourseNameColumn
            // 
            this.CourseNameColumn.Text = "Course Name";
            this.CourseNameColumn.Width = 200;
            // 
            // StartTimeColumn
            // 
            this.StartTimeColumn.Text = "Starts";
            this.StartTimeColumn.Width = 50;
            // 
            // EndTimeColumn
            // 
            this.EndTimeColumn.Text = "Ends";
            this.EndTimeColumn.Width = 50;
            // 
            // DaysColumn
            // 
            this.DaysColumn.Text = "Days";
            this.DaysColumn.Width = 50;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.ControlBox = false;
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

    }
}