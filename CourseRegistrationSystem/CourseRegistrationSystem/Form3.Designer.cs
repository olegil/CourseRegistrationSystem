namespace CourseRegistrationSystem
{
    partial class CatalogForm
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
            this.CatalogListBox = new System.Windows.Forms.ListBox();
            this.CatalogListView = new System.Windows.Forms.ListView();
            this.CourseNumberColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubjectColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FourDigitsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CourseNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartTimeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndTimeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DaysColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrereqsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // CatalogListBox
            // 
            this.CatalogListBox.ColumnWidth = 4;
            this.CatalogListBox.FormattingEnabled = true;
            this.CatalogListBox.ItemHeight = 16;
            this.CatalogListBox.Location = new System.Drawing.Point(12, 12);
            this.CatalogListBox.Name = "CatalogListBox";
            this.CatalogListBox.Size = new System.Drawing.Size(316, 452);
            this.CatalogListBox.TabIndex = 0;
            // 
            // CatalogListView
            // 
            this.CatalogListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CourseNumberColumn,
            this.SubjectColumn,
            this.FourDigitsColumn,
            this.CourseNameColumn,
            this.StartTimeColumn,
            this.EndTimeColumn,
            this.DaysColumn,
            this.PrereqsColumn});
            this.CatalogListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CatalogListView.FullRowSelect = true;
            this.CatalogListView.GridLines = true;
            this.CatalogListView.Location = new System.Drawing.Point(0, 0);
            this.CatalogListView.Name = "CatalogListView";
            this.CatalogListView.Size = new System.Drawing.Size(782, 555);
            this.CatalogListView.TabIndex = 1;
            this.CatalogListView.UseCompatibleStateImageBehavior = false;
            this.CatalogListView.View = System.Windows.Forms.View.Details;
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
            // PrereqsColumn
            // 
            this.PrereqsColumn.Text = "Prerequisites";
            this.PrereqsColumn.Width = 600;
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.CatalogListView);
            this.Controls.Add(this.CatalogListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "CatalogForm";
            this.Text = "Course Catalog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CatalogListBox;
        private System.Windows.Forms.ListView CatalogListView;
        private System.Windows.Forms.ColumnHeader CourseNumberColumn;
        private System.Windows.Forms.ColumnHeader SubjectColumn;
        private System.Windows.Forms.ColumnHeader FourDigitsColumn;
        private System.Windows.Forms.ColumnHeader CourseNameColumn;
        private System.Windows.Forms.ColumnHeader StartTimeColumn;
        private System.Windows.Forms.ColumnHeader EndTimeColumn;
        private System.Windows.Forms.ColumnHeader DaysColumn;
        private System.Windows.Forms.ColumnHeader PrereqsColumn;
    }
}