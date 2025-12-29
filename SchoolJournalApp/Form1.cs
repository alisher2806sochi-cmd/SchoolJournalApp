using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SchoolJournalApp
{
    public partial class Form1 : Form
    {
        public struct GradeRecord
        {
            public int StudentId;
            public string Subject;
            public DateTime Date;
            public int Grade;
            public string Comment;
        }
        public struct Student
        {
            public int Id;
            public string FirstName;
            public string LastName;
            public string Class;
            public DateTime BirthDate;
        }
        private List<Student> students = new List<Student>();
        private List<GradeRecord> grades = new List<GradeRecord>();
        private DataTable studentsTable;
        private DataTable gradesTable;
        private Color primaryColor = Color.FromArgb(30, 30, 30);
        private Color secondaryColor = Color.FromArgb(45, 45, 45);
        private Color accentColor = Color.FromArgb(0, 120, 215);
        private Color successColor = Color.FromArgb(16, 137, 62);
        private Color warningColor = Color.FromArgb(218, 59, 1);
        private Color dangerColor = Color.FromArgb(196, 43, 28);
        private Color backgroundColor = Color.FromArgb(25, 25, 25);
        private Color panelColor = Color.FromArgb(32, 32, 32);
        private Color textColor = Color.FromArgb(240, 240, 240);
        private Color borderColor = Color.FromArgb(64, 64, 64);
        public Form1()
        {
            InitializeComponent();
            InitializeData();
            LoadSampleData();
            UpdateStatistics();
            ApplyDarkDesign();
        }
        private void InitializeData()
        {
            studentsTable = new DataTable();
            studentsTable.Columns.Add("ID", typeof(int));
            studentsTable.Columns.Add("Имя", typeof(string));
            studentsTable.Columns.Add("Фамилия", typeof(string));
            studentsTable.Columns.Add("Класс", typeof(string));
            studentsTable.Columns.Add("Дата рождения", typeof(DateTime));
            dataGridViewStudents.DataSource = studentsTable;
            dataGridViewStudents.Columns["Дата рождения"].DefaultCellStyle.Format = "dd.MM.yyyy";
            gradesTable = new DataTable();
            gradesTable.Columns.Add("ID ученика", typeof(int));
            gradesTable.Columns.Add("Предмет", typeof(string));
            gradesTable.Columns.Add("Дата", typeof(DateTime));
            gradesTable.Columns.Add("Оценка", typeof(int));
            gradesTable.Columns.Add("Комментарий", typeof(string));
            dataGridViewGrades.DataSource = gradesTable;
            dataGridViewGrades.Columns["Дата"].DefaultCellStyle.Format = "dd.MM.yyyy";
            InitializeStatisticsTables();
        }
        private void InitializeStatisticsTables()
        {
            dataGridViewRating.Columns.Clear();
            dataGridViewRating.Columns.Add("Место", "Место");
            dataGridViewRating.Columns.Add("Ученик", "Ученик");
            dataGridViewRating.Columns.Add("Средний балл", "Средний балл");
            dataGridViewRating.Columns.Add("Кол-во оценок", "Кол-во оценок");
            dataGridViewRating.Columns.Add("Уровень", "Уровень");
            dataGridViewSubjectStats.Columns.Clear();
            dataGridViewSubjectStats.Columns.Add("Предмет", "Предмет");
            dataGridViewSubjectStats.Columns.Add("Кол-во оценок", "Кол-во оценок");
            dataGridViewSubjectStats.Columns.Add("Средний балл", "Средний балл");
            dataGridViewSubjectStats.Columns.Add("Макс", "Макс");
            dataGridViewSubjectStats.Columns.Add("Мин", "Мин");
            dataGridViewStudentGrades.Columns.Clear();
            dataGridViewStudentGrades.Columns.Add("Предмет", "Предмет");
            dataGridViewStudentGrades.Columns.Add("Дата", "Дата");
            dataGridViewStudentGrades.Columns.Add("Оценка", "Оценка");
            dataGridViewStudentGrades.Columns.Add("Комментарий", "Комментарий");
            dataGridViewStudentGrades.Columns["Дата"].DefaultCellStyle.Format = "dd.MM.yyyy";
        }
        private void LoadSampleData()
        {
            students.Add(new Student { Id = 1, FirstName = "Иван", LastName = "Иванов", Class = "10А", BirthDate = new DateTime(2007, 5, 15) });
            students.Add(new Student { Id = 2, FirstName = "Мария", LastName = "Петрова", Class = "10А", BirthDate = new DateTime(2007, 8, 22) });
            students.Add(new Student { Id = 3, FirstName = "Алексей", LastName = "Сидоров", Class = "10Б", BirthDate = new DateTime(2007, 3, 10) });
            students.Add(new Student { Id = 4, FirstName = "Екатерина", LastName = "Козлова", Class = "10Б", BirthDate = new DateTime(2007, 11, 5) });
            students.Add(new Student { Id = 5, FirstName = "Дмитрий", LastName = "Смирнов", Class = "10А", BirthDate = new DateTime(2007, 7, 30) });
            grades.Add(new GradeRecord { StudentId = 1, Subject = "Математика", Date = DateTime.Now.AddDays(-5), Grade = 5, Comment = "Отличная работа" });
            grades.Add(new GradeRecord { StudentId = 1, Subject = "Физика", Date = DateTime.Now.AddDays(-3), Grade = 4, Comment = "Хорошо, но можно лучше" });
            grades.Add(new GradeRecord { StudentId = 2, Subject = "Математика", Date = DateTime.Now.AddDays(-5), Grade = 4, Comment = "" });
            grades.Add(new GradeRecord { StudentId = 2, Subject = "Литература", Date = DateTime.Now.AddDays(-2), Grade = 5, Comment = "Отличное сочинение" });
            grades.Add(new GradeRecord { StudentId = 3, Subject = "Физика", Date = DateTime.Now.AddDays(-4), Grade = 3, Comment = "Нужно повторить материал" });
            grades.Add(new GradeRecord { StudentId = 4, Subject = "Математика", Date = DateTime.Now.AddDays(-1), Grade = 5, Comment = "" });
            grades.Add(new GradeRecord { StudentId = 5, Subject = "История", Date = DateTime.Now.AddDays(-6), Grade = 4, Comment = "Хороший ответ" });
            grades.Add(new GradeRecord { StudentId = 5, Subject = "Математика", Date = DateTime.Now.AddDays(-2), Grade = 3, Comment = "Нужно подтянуть" });
            RefreshStudentsTable();
            RefreshGradesTable();
        }
        private void RefreshStudentsTable()
        {
            studentsTable.Rows.Clear();
            foreach (var student in students.OrderBy(s => s.LastName).ThenBy(s => s.FirstName))
            {
                studentsTable.Rows.Add(student.Id, student.FirstName, student.LastName, student.Class, student.BirthDate);
            }
        }
        private void RefreshGradesTable()
        {
            gradesTable.Rows.Clear();
            foreach (var grade in grades.OrderByDescending(g => g.Date))
            {
                gradesTable.Rows.Add(grade.StudentId, grade.Subject, grade.Date, grade.Grade, grade.Comment);
            }
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Пожалуйста, заполните имя и фамилию ученика.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(cmbClass.Text))
            {
                MessageBox.Show("Пожалуйста, выберите класс.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int newId = students.Count > 0 ? students.Max(s => s.Id) + 1 : 1;
            Student newStudent = new Student
            {
                Id = newId,
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                Class = cmbClass.Text,
                BirthDate = dtpBirthDate.Value.Date
            };
            students.Add(newStudent);
            RefreshStudentsTable();
            ClearStudentForm();
            UpdateStatistics();
            MessageBox.Show($"Ученик {newStudent.FirstName} {newStudent.LastName} успешно добавлен.",
                "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            if (cmbStudent.SelectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста, выберите ученика.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(cmbSubject.Text))
            {
                MessageBox.Show("Пожалуйста, выберите предмет.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (nudGrade.Value < 1 || nudGrade.Value > 5)
            {
                MessageBox.Show("Оценка должна быть в диапазоне от 1 до 5.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string selectedStudent = cmbStudent.SelectedItem.ToString();
            int studentId = int.Parse(selectedStudent.Split('.')[0]);
            GradeRecord newGrade = new GradeRecord
            {
                StudentId = studentId,
                Subject = cmbSubject.Text,
                Date = dtpGradeDate.Value.Date,
                Grade = (int)nudGrade.Value,
                Comment = txtComment.Text.Trim()
            };
            grades.Add(newGrade);
            RefreshGradesTable();
            ClearGradeForm();
            UpdateStatistics();
            MessageBox.Show($"Оценка по предмету {newGrade.Subject} успешно добавлена.",
                "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ClearStudentForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            cmbClass.SelectedIndex = -1;
            dtpBirthDate.Value = DateTime.Now.AddYears(-15);
        }
        private void ClearGradeForm()
        {
            cmbStudent.SelectedIndex = -1;
            cmbSubject.SelectedIndex = -1;
            nudGrade.Value = 5;
            txtComment.Clear();
            dtpGradeDate.Value = DateTime.Now;
        }
        private void UpdateStatistics()
        {
            lblTotalStudents.Text = students.Count.ToString();
            lblTotalGrades.Text = grades.Count.ToString();

            if (grades.Count > 0)
            {
                double averageGrade = grades.Average(g => g.Grade);
                lblAverageGrade.Text = averageGrade.ToString("F2");
            }
            else
            {
                lblAverageGrade.Text = "0.00";
            }
            cmbStudent.Items.Clear();
            foreach (var student in students.OrderBy(s => s.LastName).ThenBy(s => s.FirstName))
            {
                cmbStudent.Items.Add($"{student.Id}. {student.LastName} {student.FirstName} ({student.Class})");
            }
            UpdatePerformanceRating();
            UpdateSubjectStatistics();

            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                int studentId = Convert.ToInt32(dataGridViewStudents.SelectedRows[0].Cells["ID"].Value);
                DisplayStudentGrades(studentId);
            }
        }
        private void UpdatePerformanceRating()
        {
            dataGridViewRating.Rows.Clear();
            var studentRatings = new List<(int Id, string Name, double Average, int Count)>();
            foreach (var student in students)
            {
                var studentGrades = grades.Where(g => g.StudentId == student.Id).ToList();
                if (studentGrades.Count > 0)
                {
                    double average = studentGrades.Average(g => g.Grade);
                    studentRatings.Add((student.Id, $"{student.LastName} {student.FirstName}", average, studentGrades.Count));
                }
            }
            var sortedRatings = studentRatings
                .OrderByDescending(r => r.Average)
                .ThenByDescending(r => r.Count)
                .ToList();
            int place = 1;
            foreach (var rating in sortedRatings)
            {
                dataGridViewRating.Rows.Add(
                    place++,
                    rating.Name,
                    rating.Average.ToString("F2"),
                    rating.Count,
                    GetPerformanceLevel(rating.Average)
                );
            }
            if (sortedRatings.Count > 0)
            {
                var best = sortedRatings.First();
                var worst = sortedRatings.Last();

                lblBestStudent.Text = $"{best.Name} ({best.Average:F2})";
                lblWorstStudent.Text = $"{worst.Name} ({worst.Average:F2})";
            }
            else
            {
                lblBestStudent.Text = "Нет данных";
                lblWorstStudent.Text = "Нет данных";
            }
        }
        private string GetPerformanceLevel(double average)
        {
            if (average >= 4.5) return "Отличник";
            if (average >= 4.0) return "Хорошист";
            if (average >= 3.0) return "Удовлетворительно";
            return "Неуспевающий";
        }
        private void UpdateSubjectStatistics()
        {
            dataGridViewSubjectStats.Rows.Clear();
            var subjectGroups = grades.GroupBy(g => g.Subject);
            foreach (var group in subjectGroups.OrderBy(g => g.Key))
            {
                int totalGrades = group.Count();
                double average = group.Average(g => g.Grade);
                int maxGrade = group.Max(g => g.Grade);
                int minGrade = group.Min(g => g.Grade);
                dataGridViewSubjectStats.Rows.Add(
                    group.Key,
                    totalGrades,
                    average.ToString("F2"),
                    maxGrade,
                    minGrade
                );
            }
        }
        private void DisplayStudentGrades(int studentId)
        {
            var studentGrades = grades.Where(g => g.StudentId == studentId).ToList();
            dataGridViewStudentGrades.Rows.Clear();
            if (studentGrades.Count > 0)
            {
                foreach (var grade in studentGrades.OrderByDescending(g => g.Date))
                {
                    dataGridViewStudentGrades.Rows.Add(
                        grade.Subject,
                        grade.Date,
                        grade.Grade,
                        grade.Comment
                    );
                }
                double studentAverage = studentGrades.Average(g => g.Grade);
                lblStudentAverage.Text = studentAverage.ToString("F2");
                lblStudentAverage.ForeColor = GetGradeColor(studentAverage);
                var student = students.FirstOrDefault(s => s.Id == studentId);
                if (student.Id != 0)
                {
                    lblStudentName.Text = $"{student.LastName} {student.FirstName}";
                    lblStudentClass.Text = student.Class;
                    lblStudentBirthDate.Text = student.BirthDate.ToString("dd.MM.yyyy");
                    lblStudentTotalGrades.Text = studentGrades.Count.ToString();
                }
            }
            else
            {
                lblStudentAverage.Text = "Нет оценок";
                lblStudentAverage.ForeColor = Color.Gray;
                lblStudentName.Text = "Не выбран";
                lblStudentClass.Text = "-";
                lblStudentBirthDate.Text = "-";
                lblStudentTotalGrades.Text = "0";
            }
        }
        private Color GetGradeColor(double grade)
        {
            if (grade >= 4.5) return successColor;
            if (grade >= 3.5) return Color.FromArgb(255, 193, 7);
            return dangerColor;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.ToLower();
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                RefreshStudentsTable();
                return;
            }
            var filteredStudents = students.Where(s =>
                s.FirstName.ToLower().Contains(searchTerm) ||
                s.LastName.ToLower().Contains(searchTerm) ||
                s.Class.ToLower().Contains(searchTerm)).ToList();
            studentsTable.Rows.Clear();
            foreach (var student in filteredStudents.OrderBy(s => s.LastName).ThenBy(s => s.FirstName))
            {
                studentsTable.Rows.Add(student.Id, student.FirstName, student.LastName, student.Class, student.BirthDate);
            }
        }
        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            RefreshStudentsTable();
        }
        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите ученика для удаления.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int studentId = Convert.ToInt32(dataGridViewStudents.SelectedRows[0].Cells["ID"].Value);
            var student = students.FirstOrDefault(s => s.Id == studentId);
            if (student.Id == 0)
            {
                MessageBox.Show("Ученик не найден.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить ученика {student.FirstName} {student.LastName}?",
                "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                grades.RemoveAll(g => g.StudentId == studentId);
                students.Remove(student);
                RefreshStudentsTable();
                RefreshGradesTable();
                UpdateStatistics();
                MessageBox.Show("Ученик успешно удален.", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dataGridViewGrades_SelectionChanged(object sender, EventArgs e)
        {
            btnDeleteGrade.Enabled = dataGridViewGrades.SelectedRows.Count > 0;
        }
        private void btnDeleteGrade_Click(object sender, EventArgs e)
        {
            if (dataGridViewGrades.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите оценку для удаления.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int studentId = Convert.ToInt32(dataGridViewGrades.SelectedRows[0].Cells["ID ученика"].Value);
            string subject = dataGridViewGrades.SelectedRows[0].Cells["Предмет"].Value.ToString();
            DateTime date = Convert.ToDateTime(dataGridViewGrades.SelectedRows[0].Cells["Дата"].Value);
            int gradeValue = Convert.ToInt32(dataGridViewGrades.SelectedRows[0].Cells["Оценка"].Value);
            DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить оценку {gradeValue} по предмету {subject}?",
                "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                grades.RemoveAll(g => g.StudentId == studentId &&
                                      g.Subject == subject &&
                                      g.Date == date &&
                                      g.Grade == gradeValue);
                RefreshGradesTable();
                UpdateStatistics();
                MessageBox.Show("Оценка успешно удалена.", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти из приложения?",
                "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void dataGridViewStudents_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridViewStudents.Columns[e.ColumnIndex].Name == "Класс" && e.Value != null)
            {
                string className = e.Value.ToString();
                if (className.Contains("10А"))
                {
                    dataGridViewStudents.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 60);
                }
                else if (className.Contains("10Б"))
                {
                    dataGridViewStudents.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(60, 40, 40);
                }
            }
        }
        private void dataGridViewGrades_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridViewGrades.Columns[e.ColumnIndex].Name == "Оценка" && e.Value != null)
            {
                int gradeValue = Convert.ToInt32(e.Value);
                switch (gradeValue)
                {
                    case 5:
                        e.CellStyle.BackColor = Color.FromArgb(40, 60, 40);
                        e.CellStyle.ForeColor = successColor;
                        break;
                    case 4:
                        e.CellStyle.BackColor = Color.FromArgb(60, 60, 40);
                        e.CellStyle.ForeColor = Color.FromArgb(255, 193, 7);
                        break;
                    case 3:
                        e.CellStyle.BackColor = Color.FromArgb(60, 50, 40);
                        e.CellStyle.ForeColor = warningColor;
                        break;
                    case 2:
                        e.CellStyle.BackColor = Color.FromArgb(60, 40, 40);
                        e.CellStyle.ForeColor = dangerColor;
                        break;
                    case 1:
                        e.CellStyle.BackColor = Color.FromArgb(50, 30, 30);
                        e.CellStyle.ForeColor = dangerColor;
                        break;
                }
                e.CellStyle.Font = new Font(dataGridViewGrades.Font, FontStyle.Bold);
            }
        }
        private void dataGridViewRating_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridViewRating.Columns[e.ColumnIndex].Name == "Место" && e.Value != null)
                {
                    int place = Convert.ToInt32(e.Value);
                    if (place == 1)
                    {
                        e.CellStyle.BackColor = Color.FromArgb(60, 50, 40);
                        e.CellStyle.ForeColor = Color.Gold;
                    }
                    else if (place == 2)
                    {
                        e.CellStyle.BackColor = Color.FromArgb(50, 50, 50);
                        e.CellStyle.ForeColor = Color.Silver;
                    }
                    else if (place == 3)
                    {
                        e.CellStyle.BackColor = Color.FromArgb(50, 40, 30);
                        e.CellStyle.ForeColor = Color.FromArgb(205, 127, 50);
                    }
                }
                else if (dataGridViewRating.Columns[e.ColumnIndex].Name == "Средний балл" && e.Value != null)
                {
                    double grade = Convert.ToDouble(e.Value);
                    e.CellStyle.ForeColor = GetGradeColor(grade);
                }
                else if (dataGridViewRating.Columns[e.ColumnIndex].Name == "Уровень" && e.Value != null)
                {
                    string level = e.Value.ToString();
                    switch (level)
                    {
                        case "Отличник":
                            e.CellStyle.ForeColor = successColor;
                            break;
                        case "Хорошист":
                            e.CellStyle.ForeColor = Color.FromArgb(255, 193, 7);
                            break;
                        case "Удовлетворительно":
                            e.CellStyle.ForeColor = warningColor;
                            break;
                        case "Неуспевающий":
                            e.CellStyle.ForeColor = dangerColor;
                            break;
                    }
                }
            }
        }
        private void dataGridViewSubjectStats_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridViewSubjectStats.Columns[e.ColumnIndex].Name == "Средний балл" && e.Value != null)
            {
                double grade = Convert.ToDouble(e.Value);
                e.CellStyle.ForeColor = GetGradeColor(grade);
            }
        }
        private void ApplyDarkDesign()
        {
            this.BackColor = backgroundColor;
            this.ForeColor = textColor;
            ApplyControlStyles(this);
            ConfigureDataGridView(dataGridViewStudents);
            ConfigureDataGridView(dataGridViewGrades);
            ConfigureDataGridView(dataGridViewRating);
            ConfigureDataGridView(dataGridViewSubjectStats);
            ConfigureDataGridView(dataGridViewStudentGrades);
            tabControl1.BackColor = panelColor;
            tabControl1.ForeColor = textColor;
            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                tabPage.BackColor = panelColor;
                tabPage.ForeColor = textColor;
            }
        }
        private void ApplyControlStyles(Control control)
        {
            if (control is Button button)
            {
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 1;
                button.FlatAppearance.BorderColor = borderColor;
                button.BackColor = secondaryColor;
                button.ForeColor = textColor;
                button.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                button.Cursor = Cursors.Hand;
                button.Padding = new Padding(10, 5, 10, 5);
                if (button.Name.Contains("Delete"))
                {
                    button.BackColor = dangerColor;
                }
                else if (button.Name.Contains("Add"))
                {
                    button.BackColor = successColor;
                }
                else if (button.Name == "btnExit")
                {
                    button.BackColor = Color.FromArgb(80, 80, 80);
                }
                button.MouseEnter += (s, e) =>
                {
                    var btn = s as Button;
                    btn.BackColor = ControlPaint.Light(btn.BackColor, 0.2f);
                };
                button.MouseLeave += (s, e) =>
                {
                    var btn = s as Button;
                    if (btn.Name.Contains("Delete"))
                        btn.BackColor = dangerColor;
                    else if (btn.Name.Contains("Add"))
                        btn.BackColor = successColor;
                    else if (btn.Name == "btnExit")
                        btn.BackColor = Color.FromArgb(80, 80, 80);
                    else
                        btn.BackColor = secondaryColor;
                };
            }
            else if (control is GroupBox groupBox)
            {
                groupBox.ForeColor = textColor;
                groupBox.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                groupBox.BackColor = Color.Transparent;
            }
            else if (control is Label label)
            {
                label.ForeColor = textColor;
                label.BackColor = Color.Transparent;
            }
            else if (control is TextBox textBox)
            {
                textBox.BackColor = secondaryColor;
                textBox.ForeColor = textColor;
                textBox.BorderStyle = BorderStyle.FixedSingle;
                textBox.Font = new Font("Segoe UI", 9);
            }
            else if (control is ComboBox comboBox)
            {
                comboBox.BackColor = secondaryColor;
                comboBox.ForeColor = textColor;
                comboBox.FlatStyle = FlatStyle.Flat;
                comboBox.Font = new Font("Segoe UI", 9);
            }
            else if (control is DateTimePicker dateTimePicker)
            {
                dateTimePicker.BackColor = secondaryColor;
                dateTimePicker.ForeColor = textColor;
                dateTimePicker.CalendarMonthBackground = secondaryColor;
                dateTimePicker.CalendarTitleBackColor = primaryColor;
                dateTimePicker.CalendarForeColor = textColor;
                dateTimePicker.Format = DateTimePickerFormat.Short;
                dateTimePicker.Font = new Font("Segoe UI", 9);
            }
            else if (control is NumericUpDown numericUpDown)
            {
                numericUpDown.BackColor = secondaryColor;
                numericUpDown.ForeColor = textColor;
                numericUpDown.BorderStyle = BorderStyle.FixedSingle;
                numericUpDown.Font = new Font("Segoe UI", 9);
            }
            foreach (Control child in control.Controls)
            {
                ApplyControlStyles(child);
            }
        }
        private void ConfigureDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = panelColor;
            dgv.ForeColor = textColor;
            dgv.BorderStyle = BorderStyle.FixedSingle;
            dgv.GridColor = borderColor;
            dgv.Font = new Font("Segoe UI", 9);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = primaryColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = textColor;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersHeight = 35;
            dgv.RowHeadersVisible = false;
            dgv.RowTemplate.Height = 30;
            dgv.DefaultCellStyle.BackColor = panelColor;
            dgv.DefaultCellStyle.ForeColor = textColor;
            dgv.DefaultCellStyle.SelectionBackColor = accentColor;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dataGridViewStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                int studentId = Convert.ToInt32(dataGridViewStudents.SelectedRows[0].Cells["ID"].Value);
                DisplayStudentGrades(studentId);
            }
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch.PerformClick();
                e.Handled = true;
            }
        }
    }
}