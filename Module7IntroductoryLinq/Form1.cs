using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module7IntroductoryLinq
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
            InitializeData();
            PopulateProgramComboBox();
            DisplayStudents(students);
        }

        private void InitializeData()
        {
            // Add at least 10 sample students across multiple programs
            students = new List<Student>
            {
                new Student{ StudentId=1001, FirstName="Jordan", LastName="Lee", ProgramName="Software Development", GPA=3.7 },
                new Student{ StudentId=1002, FirstName="Morgan", LastName="Reed", ProgramName="Software Development", GPA=3.45 },
                new Student{ StudentId=1003, FirstName="Alex", LastName="Chen", ProgramName="Networking", GPA=2.9 },
                new Student{ StudentId=1004, FirstName="Taylor", LastName="Nguyen", ProgramName="Cybersecurity", GPA=3.9 },
                new Student{ StudentId=1005, FirstName="Riley", LastName="Patel", ProgramName="Software Development", GPA=3.2 },
                new Student{ StudentId=1006, FirstName="Casey", LastName="Garcia", ProgramName="Networking", GPA=2.5 },
                new Student{ StudentId=1007, FirstName="Jamie", LastName="Brown", ProgramName="Cybersecurity", GPA=3.6 },
                new Student{ StudentId=1008, FirstName="Avery", LastName="Smith", ProgramName="Information Systems", GPA=3.1 },
                new Student{ StudentId=1009, FirstName="Drew", LastName="Wilson", ProgramName="Information Systems", GPA=2.8 },
                new Student{ StudentId=1010, FirstName="Sam", LastName="Lopez", ProgramName="Cybersecurity", GPA=3.85 }
            };
        }

        private void PopulateProgramComboBox()
        {
            var programs = students
                .Select(s => s.ProgramName)
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(p => p)
                .ToList();

            cboProgram.Items.Clear();
            cboProgram.Items.AddRange(programs.ToArray());
            if (cboProgram.Items.Count > 0)
                cboProgram.SelectedIndex = 0;
        }

        private void DisplayStudents(List<Student> records)
        {
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = records;
            lblResults.Text = $"Results: {records.Count} matching students";
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            DisplayStudents(students);
        }

        private void btnFilterProgram_Click(object sender, EventArgs e)
        {
            FilterByProgram();
        }

        private void FilterByProgram()
        {
            if (cboProgram.SelectedItem == null)
            {
                MessageBox.Show("Please select a program.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string selectedProgram = cboProgram.SelectedItem.ToString();
            var results = students
                .Where(s => string.Equals(s.ProgramName, selectedProgram, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (results.Count == 0)
            {
                lblResults.Text = "No students found for the selected program.";
            }

            DisplayStudents(results);
        }

        private void btnFilterGpa_Click(object sender, EventArgs e)
        {
            FilterByGpa();
        }

        private void FilterByGpa()
        {
            double minGpa = (double)nudMinimumGpa.Value;
            if (minGpa < 0.0 || minGpa > 4.0)
            {
                MessageBox.Show("Enter a GPA between 0.0 and 4.0.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var results = students
                .Where(s => s.GPA >= minGpa)
                .ToList();

            if (results.Count == 0)
            {
                lblResults.Text = "No students meet the GPA requirement.";
            }

            DisplayStudents(results);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchStudents();
        }

        private void SearchStudents()
        {
            string text = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Enter a student ID or name to search.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Try ID parse
            if (int.TryParse(text, out int id))
            {
                var student = students.FirstOrDefault(s => s.StudentId == id);
                if (student == null)
                {
                    lblResults.Text = "Student not found by ID.";
                    DisplayStudents(new List<Student>());
                }
                else
                {
                    DisplayStudents(new List<Student> { student });
                }
                return;
            }

            // Search by name
            var results = students
                .Where(s => s.FirstName.IndexOf(text, StringComparison.OrdinalIgnoreCase) >= 0
                         || s.LastName.IndexOf(text, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            if (results.Count == 0)
            {
                lblResults.Text = "No students found with that name.";
            }

            DisplayStudents(results);
        }

        private void btnSortName_Click(object sender, EventArgs e)
        {
            SortByName();
        }

        private void SortByName()
        {
            var results = students
                .OrderBy(s => s.LastName)
                .ThenBy(s => s.FirstName)
                .ToList();

            DisplayStudents(results);
        }

        private void btnSortGpa_Click(object sender, EventArgs e)
        {
            SortByGpa();
        }

        private void SortByGpa()
        {
            var results = students
                .OrderByDescending(s => s.GPA)
                .ToList();

            DisplayStudents(results);

            var top = results.FirstOrDefault();
            if (top != null)
            {
                lblResults.Text = $"Top student: {top.FullName} (GPA: {top.GPA:F2}) - {results.Count} displayed";
            }
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            DisplaySummary();
        }

        private void DisplaySummary()
        {
            if (students == null || students.Count == 0)
            {
                lblResults.Text = "No student records are available.";
                return;
            }

            int total = students.Count;
            double average = students.Average(s => s.GPA);
            double highest = students.Max(s => s.GPA);
            double lowest = students.Min(s => s.GPA);
            int countAbove3 = students.Count(s => s.GPA >= 3.0);

            string summary = $"Total students: {total}\r\n" +
                             $"Average GPA: {average:F2}\r\n" +
                             $"Highest GPA: {highest:F2}\r\n" +
                             $"Lowest GPA: {lowest:F2}\r\n" +
                             $"Students with GPA >= 3.0: {countAbove3}";

            MessageBox.Show(summary, "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblResults.Text = $"Summary displayed. Total: {total}, Avg GPA: {average:F2}";
        }
    }
}
