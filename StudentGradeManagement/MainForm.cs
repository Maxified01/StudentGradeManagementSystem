using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentGradeManagement
{
    public partial class MainForm : Form
    {
        private List<Student> students = new List<Student>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (!double.TryParse(txtGrade.Text.Trim(), out double grade))
            {
                MessageBox.Show("Please enter a valid grade.");
                return;
            }

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter student name.");
                return;
            }

            students.Add(new Student(name, grade));
            txtName.Clear();
            txtGrade.Clear();

            MessageBox.Show("Student added successfully.");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lstStudents.Items.Clear();
            foreach (var s in students)
            {
                lstStudents.Items.Add(s);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtName.Text.Trim();
            var student = students.FirstOrDefault(s => s.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));

            if (student != null)
                MessageBox.Show($"Found: {student.Name} - {student.Grade}");
            else
                MessageBox.Show("Student not found.");
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            if (!students.Any())
            {
                MessageBox.Show("No students available.");
                return;
            }

            double avg = students.Average(s => s.Grade);
            MessageBox.Show($"Average grade: {avg:F2}");
        }

        private void btnHighLow_Click(object sender, EventArgs e)
        {
            if (!students.Any())
            {
                MessageBox.Show("No students available.");
                return;
            }

            var highest = students.OrderByDescending(s => s.Grade).First();
            var lowest = students.OrderBy(s => s.Grade).First();

            MessageBox.Show($"Highest: {highest.Name} ({highest.Grade})\nLowest: {lowest.Name} ({lowest.Grade})");
        }
    }
}