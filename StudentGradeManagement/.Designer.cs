namespace StudentGradeManagement
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnHighLow;
        private System.Windows.Forms.ListBox lstStudents;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnHighLow = new System.Windows.Forms.Button();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            // lblName
            this.lblName.Location = new System.Drawing.Point(20, 20);
            this.lblName.Size = new System.Drawing.Size(120, 25);
            this.lblName.Text = "Student Name:";

            // txtName
            this.txtName.Location = new System.Drawing.Point(150, 20);
            this.txtName.Size = new System.Drawing.Size(200, 26);

            // lblGrade
            this.lblGrade.Location = new System.Drawing.Point(20, 60);
            this.lblGrade.Size = new System.Drawing.Size(120, 25);
            this.lblGrade.Text = "Grade:";

            // txtGrade
            this.txtGrade.Location = new System.Drawing.Point(150, 60);
            this.txtGrade.Size = new System.Drawing.Size(200, 26);

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(20, 100);
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.Text = "Add Student";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnDisplay
            this.btnDisplay.Location = new System.Drawing.Point(160, 100);
            this.btnDisplay.Size = new System.Drawing.Size(120, 40);
            this.btnDisplay.Text = "Display Students";
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);

            // btnSearch
            this.btnSearch.Location = new System.Drawing.Point(300, 100);
            this.btnSearch.Size = new System.Drawing.Size(120, 40);
            this.btnSearch.Text = "Search Student";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // btnAverage
            this.btnAverage.Location = new System.Drawing.Point(20, 150);
            this.btnAverage.Size = new System.Drawing.Size(120, 40);
            this.btnAverage.Text = "Calculate Average";
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);

            // btnHighLow
            this.btnHighLow.Location = new System.Drawing.Point(160, 150);
            this.btnHighLow.Size = new System.Drawing.Size(120, 40);
            this.btnHighLow.Text = "Highest & Lowest";
            this.btnHighLow.Click += new System.EventHandler(this.btnHighLow_Click);

            // lstStudents
            this.lstStudents.Location = new System.Drawing.Point(20, 200);
            this.lstStudents.Size = new System.Drawing.Size(400, 200);

            // MainForm
            this.ClientSize = new System.Drawing.Size(450, 420);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.btnHighLow);
            this.Controls.Add(this.lstStudents);
            this.Text = "Student Grade Management";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
