using System.Drawing;
using System.Windows.Forms;

namespace SchoolJournalApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TabControl tabControl1;
        private TabPage tabPageStudents;
        private TabPage tabPageGrades;
        private TabPage tabPageStatistics;
        private DataGridView dataGridViewStudents;
        private DataGridView dataGridViewGrades;
        private GroupBox groupBoxAddStudent;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private ComboBox cmbClass;
        private DateTimePicker dtpBirthDate;
        private Button btnAddStudent;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBoxAddGrade;
        private ComboBox cmbStudent;
        private ComboBox cmbSubject;
        private NumericUpDown nudGrade;
        private TextBox txtComment;
        private DateTimePicker dtpGradeDate;
        private Button btnAddGrade;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private GroupBox groupBoxStatistics;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label lblTotalStudents;
        private Label lblTotalGrades;
        private Label lblAverageGrade;
        private DataGridView dataGridViewStudentGrades;
        private Label label13;
        private Label lblStudentAverage;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnClearSearch;
        private Label label14;
        private Button btnDeleteStudent;
        private Button btnDeleteGrade;
        private Button btnExit;
        private DataGridView dataGridViewRating;
        private Label label15;
        private Label lblBestStudent;
        private Label label16;
        private Label lblWorstStudent;
        private Label label17;
        private Label lblStudentName;
        private Label label18;
        private Label lblStudentClass;
        private Label label19;
        private Label lblStudentBirthDate;
        private Label label20;
        private Label lblStudentTotalGrades;
        private DataGridView dataGridViewSubjectStats;
        private Label label21;
        private Panel panel1;
        private Panel panel2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPageStudents = new TabPage();
            panel1 = new Panel();
            btnDeleteStudent = new Button();
            btnClearSearch = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label14 = new Label();
            groupBoxAddStudent = new GroupBox();
            label4 = new Label();
            dtpBirthDate = new DateTimePicker();
            label3 = new Label();
            cmbClass = new ComboBox();
            label2 = new Label();
            txtLastName = new TextBox();
            label1 = new Label();
            txtFirstName = new TextBox();
            btnAddStudent = new Button();
            dataGridViewStudents = new DataGridView();
            tabPageGrades = new TabPage();
            btnDeleteGrade = new Button();
            groupBoxAddGrade = new GroupBox();
            label9 = new Label();
            txtComment = new TextBox();
            label8 = new Label();
            dtpGradeDate = new DateTimePicker();
            label7 = new Label();
            nudGrade = new NumericUpDown();
            label6 = new Label();
            cmbSubject = new ComboBox();
            label5 = new Label();
            cmbStudent = new ComboBox();
            btnAddGrade = new Button();
            dataGridViewGrades = new DataGridView();
            tabPageStatistics = new TabPage();
            panel2 = new Panel();
            label21 = new Label();
            dataGridViewSubjectStats = new DataGridView();
            label20 = new Label();
            lblStudentTotalGrades = new Label();
            label19 = new Label();
            lblStudentBirthDate = new Label();
            label18 = new Label();
            lblStudentClass = new Label();
            label17 = new Label();
            lblStudentName = new Label();
            label16 = new Label();
            lblWorstStudent = new Label();
            label15 = new Label();
            lblBestStudent = new Label();
            dataGridViewRating = new DataGridView();
            label13 = new Label();
            lblStudentAverage = new Label();
            dataGridViewStudentGrades = new DataGridView();
            groupBoxStatistics = new GroupBox();
            lblAverageGrade = new Label();
            lblTotalGrades = new Label();
            lblTotalStudents = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            btnExit = new Button();
            tabControl1.SuspendLayout();
            tabPageStudents.SuspendLayout();
            panel1.SuspendLayout();
            groupBoxAddStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            tabPageGrades.SuspendLayout();
            groupBoxAddGrade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudGrade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrades).BeginInit();
            tabPageStatistics.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubjectStats).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRating).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudentGrades).BeginInit();
            groupBoxStatistics.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPageStudents);
            tabControl1.Controls.Add(tabPageGrades);
            tabControl1.Controls.Add(tabPageStatistics);
            tabControl1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tabControl1.ItemSize = new Size(120, 30);
            tabControl1.Location = new Point(10, 10);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(964, 640);
            tabControl1.TabIndex = 0;
            // 
            // tabPageStudents
            // 
            tabPageStudents.BackColor = Color.FromArgb(32, 32, 32);
            tabPageStudents.Controls.Add(panel1);
            tabPageStudents.Controls.Add(groupBoxAddStudent);
            tabPageStudents.Controls.Add(dataGridViewStudents);
            tabPageStudents.Location = new Point(4, 34);
            tabPageStudents.Name = "tabPageStudents";
            tabPageStudents.Padding = new Padding(3);
            tabPageStudents.Size = new Size(956, 602);
            tabPageStudents.TabIndex = 0;
            tabPageStudents.Text = "👥 Ученики";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(40, 40, 40);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnDeleteStudent);
            panel1.Controls.Add(btnClearSearch);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(label14);
            panel1.Location = new Point(8, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(940, 53);
            panel1.TabIndex = 2;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteStudent.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnDeleteStudent.Location = new Point(798, 10);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(130, 38);
            btnDeleteStudent.TabIndex = 7;
            btnDeleteStudent.Text = "🗑️ Удалить";
            btnDeleteStudent.UseVisualStyleBackColor = true;
            btnDeleteStudent.Click += btnDeleteStudent_Click;
            // 
            // btnClearSearch
            // 
            btnClearSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClearSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnClearSearch.Location = new Point(662, 10);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(130, 38);
            btnClearSearch.TabIndex = 6;
            btnClearSearch.Text = "❌ Очистить";
            btnClearSearch.UseVisualStyleBackColor = true;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSearch.Location = new Point(526, 10);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(130, 38);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "🔍 Поиск";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtSearch.Location = new Point(153, 13);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(367, 23);
            txtSearch.TabIndex = 4;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label14.Location = new Point(10, 16);
            label14.Name = "label14";
            label14.Size = new Size(100, 15);
            label14.TabIndex = 3;
            label14.Text = "Поиск учеников:";
            // 
            // groupBoxAddStudent
            // 
            groupBoxAddStudent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxAddStudent.BackColor = Color.Transparent;
            groupBoxAddStudent.Controls.Add(label4);
            groupBoxAddStudent.Controls.Add(dtpBirthDate);
            groupBoxAddStudent.Controls.Add(label3);
            groupBoxAddStudent.Controls.Add(cmbClass);
            groupBoxAddStudent.Controls.Add(label2);
            groupBoxAddStudent.Controls.Add(txtLastName);
            groupBoxAddStudent.Controls.Add(label1);
            groupBoxAddStudent.Controls.Add(txtFirstName);
            groupBoxAddStudent.Controls.Add(btnAddStudent);
            groupBoxAddStudent.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxAddStudent.Location = new Point(8, 8);
            groupBoxAddStudent.Name = "groupBoxAddStudent";
            groupBoxAddStudent.Size = new Size(940, 106);
            groupBoxAddStudent.TabIndex = 1;
            groupBoxAddStudent.TabStop = false;
            groupBoxAddStudent.Text = "Добавить нового ученика";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(680, 32);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 11;
            label4.Text = "Дата рождения:";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(799, 29);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(120, 23);
            dtpBirthDate.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(530, 32);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 9;
            label3.Text = "Класс:";
            // 
            // cmbClass
            // 
            cmbClass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbClass.FormattingEnabled = true;
            cmbClass.Items.AddRange(new object[] { "10А", "10Б", "11А", "11Б", "9А", "9Б" });
            cmbClass.Location = new Point(588, 29);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(80, 23);
            cmbClass.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(290, 32);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 7;
            label2.Text = "Фамилия:";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtLastName.Location = new Point(372, 29);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(140, 23);
            txtLastName.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(30, 32);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 5;
            label1.Text = "Имя:";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtFirstName.Location = new Point(80, 29);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(140, 23);
            txtFirstName.TabIndex = 4;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddStudent.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAddStudent.Location = new Point(799, 60);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(120, 40);
            btnAddStudent.TabIndex = 8;
            btnAddStudent.Text = "➕ Добавить";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.AllowUserToAddRows = false;
            dataGridViewStudents.AllowUserToDeleteRows = false;
            dataGridViewStudents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Location = new Point(8, 179);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.ReadOnly = true;
            dataGridViewStudents.RowHeadersWidth = 51;
            dataGridViewStudents.RowTemplate.Height = 29;
            dataGridViewStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStudents.Size = new Size(940, 415);
            dataGridViewStudents.TabIndex = 0;
            dataGridViewStudents.CellFormatting += dataGridViewStudents_CellFormatting;
            dataGridViewStudents.SelectionChanged += dataGridViewStudents_SelectionChanged;
            // 
            // tabPageGrades
            // 
            tabPageGrades.BackColor = Color.FromArgb(32, 32, 32);
            tabPageGrades.Controls.Add(btnDeleteGrade);
            tabPageGrades.Controls.Add(groupBoxAddGrade);
            tabPageGrades.Controls.Add(dataGridViewGrades);
            tabPageGrades.Location = new Point(4, 34);
            tabPageGrades.Name = "tabPageGrades";
            tabPageGrades.Padding = new Padding(3);
            tabPageGrades.Size = new Size(956, 602);
            tabPageGrades.TabIndex = 1;
            tabPageGrades.Text = "📊 Оценки";
            // 
            // btnDeleteGrade
            // 
            btnDeleteGrade.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteGrade.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnDeleteGrade.Location = new Point(818, 555);
            btnDeleteGrade.Name = "btnDeleteGrade";
            btnDeleteGrade.Size = new Size(130, 41);
            btnDeleteGrade.TabIndex = 3;
            btnDeleteGrade.Text = "🗑️ Удалить";
            btnDeleteGrade.UseVisualStyleBackColor = true;
            btnDeleteGrade.Click += btnDeleteGrade_Click;
            // 
            // groupBoxAddGrade
            // 
            groupBoxAddGrade.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxAddGrade.BackColor = Color.Transparent;
            groupBoxAddGrade.Controls.Add(label9);
            groupBoxAddGrade.Controls.Add(txtComment);
            groupBoxAddGrade.Controls.Add(label8);
            groupBoxAddGrade.Controls.Add(dtpGradeDate);
            groupBoxAddGrade.Controls.Add(label7);
            groupBoxAddGrade.Controls.Add(nudGrade);
            groupBoxAddGrade.Controls.Add(label6);
            groupBoxAddGrade.Controls.Add(cmbSubject);
            groupBoxAddGrade.Controls.Add(label5);
            groupBoxAddGrade.Controls.Add(cmbStudent);
            groupBoxAddGrade.Controls.Add(btnAddGrade);
            groupBoxAddGrade.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxAddGrade.Location = new Point(8, 8);
            groupBoxAddGrade.Name = "groupBoxAddGrade";
            groupBoxAddGrade.Size = new Size(940, 140);
            groupBoxAddGrade.TabIndex = 1;
            groupBoxAddGrade.TabStop = false;
            groupBoxAddGrade.Text = "Добавить новую оценку";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.Location = new Point(20, 103);
            label9.Name = "label9";
            label9.Size = new Size(87, 15);
            label9.TabIndex = 12;
            label9.Text = "Комментарий:";
            // 
            // txtComment
            // 
            txtComment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtComment.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtComment.Location = new Point(120, 100);
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(690, 23);
            txtComment.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(640, 63);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 10;
            label8.Text = "Дата:";
            // 
            // dtpGradeDate
            // 
            dtpGradeDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dtpGradeDate.Format = DateTimePickerFormat.Short;
            dtpGradeDate.Location = new Point(694, 60);
            dtpGradeDate.Name = "dtpGradeDate";
            dtpGradeDate.Size = new Size(116, 23);
            dtpGradeDate.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(440, 63);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 8;
            label7.Text = "Оценка:";
            // 
            // nudGrade
            // 
            nudGrade.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nudGrade.Location = new Point(510, 60);
            nudGrade.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudGrade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudGrade.Name = "nudGrade";
            nudGrade.Size = new Size(80, 23);
            nudGrade.TabIndex = 7;
            nudGrade.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(20, 63);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 6;
            label6.Text = "Предмет:";
            // 
            // cmbSubject
            // 
            cmbSubject.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Items.AddRange(new object[] { "Математика", "Физика", "Химия", "Биология", "История", "Литература", "Русский язык", "Английский язык", "Информатика", "Физкультура" });
            cmbSubject.Location = new Point(100, 60);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(200, 23);
            cmbSubject.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(20, 23);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 4;
            label5.Text = "Ученик:";
            // 
            // cmbStudent
            // 
            cmbStudent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbStudent.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(94, 20);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(716, 23);
            cmbStudent.TabIndex = 3;
            // 
            // btnAddGrade
            // 
            btnAddGrade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddGrade.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAddGrade.Location = new Point(816, 94);
            btnAddGrade.Name = "btnAddGrade";
            btnAddGrade.Size = new Size(110, 33);
            btnAddGrade.TabIndex = 2;
            btnAddGrade.Text = "➕ Добавить";
            btnAddGrade.UseVisualStyleBackColor = true;
            btnAddGrade.Click += btnAddGrade_Click;
            // 
            // dataGridViewGrades
            // 
            dataGridViewGrades.AllowUserToAddRows = false;
            dataGridViewGrades.AllowUserToDeleteRows = false;
            dataGridViewGrades.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewGrades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGrades.Location = new Point(8, 154);
            dataGridViewGrades.Name = "dataGridViewGrades";
            dataGridViewGrades.ReadOnly = true;
            dataGridViewGrades.RowHeadersWidth = 51;
            dataGridViewGrades.RowTemplate.Height = 29;
            dataGridViewGrades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGrades.Size = new Size(940, 395);
            dataGridViewGrades.TabIndex = 0;
            dataGridViewGrades.CellFormatting += dataGridViewGrades_CellFormatting;
            dataGridViewGrades.SelectionChanged += dataGridViewGrades_SelectionChanged;
            // 
            // tabPageStatistics
            // 
            tabPageStatistics.BackColor = Color.FromArgb(32, 32, 32);
            tabPageStatistics.Controls.Add(panel2);
            tabPageStatistics.Controls.Add(groupBoxStatistics);
            tabPageStatistics.Location = new Point(4, 34);
            tabPageStatistics.Name = "tabPageStatistics";
            tabPageStatistics.Size = new Size(956, 602);
            tabPageStatistics.TabIndex = 2;
            tabPageStatistics.Text = "📈 Статистика";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(40, 40, 40);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label21);
            panel2.Controls.Add(dataGridViewSubjectStats);
            panel2.Controls.Add(label20);
            panel2.Controls.Add(lblStudentTotalGrades);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(lblStudentBirthDate);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(lblStudentClass);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(lblStudentName);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(lblWorstStudent);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(lblBestStudent);
            panel2.Controls.Add(dataGridViewRating);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(lblStudentAverage);
            panel2.Controls.Add(dataGridViewStudentGrades);
            panel2.Location = new Point(8, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(940, 458);
            panel2.TabIndex = 24;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label21.Location = new Point(10, 153);
            label21.Name = "label21";
            label21.Size = new Size(170, 19);
            label21.TabIndex = 22;
            label21.Text = "Статистика предметов:";
            // 
            // dataGridViewSubjectStats
            // 
            dataGridViewSubjectStats.AllowUserToAddRows = false;
            dataGridViewSubjectStats.AllowUserToDeleteRows = false;
            dataGridViewSubjectStats.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewSubjectStats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSubjectStats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSubjectStats.Location = new Point(10, 187);
            dataGridViewSubjectStats.Name = "dataGridViewSubjectStats";
            dataGridViewSubjectStats.ReadOnly = true;
            dataGridViewSubjectStats.RowHeadersWidth = 51;
            dataGridViewSubjectStats.RowTemplate.Height = 29;
            dataGridViewSubjectStats.Size = new Size(920, 92);
            dataGridViewSubjectStats.TabIndex = 23;
            dataGridViewSubjectStats.CellFormatting += dataGridViewSubjectStats_CellFormatting;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label20.Location = new Point(376, 317);
            label20.Name = "label20";
            label20.Size = new Size(84, 15);
            label20.TabIndex = 21;
            label20.Text = "Всего оценок:";
            // 
            // lblStudentTotalGrades
            // 
            lblStudentTotalGrades.AutoSize = true;
            lblStudentTotalGrades.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblStudentTotalGrades.Location = new Point(468, 317);
            lblStudentTotalGrades.Name = "lblStudentTotalGrades";
            lblStudentTotalGrades.Size = new Size(14, 15);
            lblStudentTotalGrades.TabIndex = 20;
            lblStudentTotalGrades.Text = "0";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label19.Location = new Point(119, 317);
            label19.Name = "label19";
            label19.Size = new Size(93, 15);
            label19.TabIndex = 19;
            label19.Text = "Дата рождения:";
            // 
            // lblStudentBirthDate
            // 
            lblStudentBirthDate.AutoSize = true;
            lblStudentBirthDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblStudentBirthDate.Location = new Point(245, 317);
            lblStudentBirthDate.Name = "lblStudentBirthDate";
            lblStudentBirthDate.Size = new Size(12, 15);
            lblStudentBirthDate.TabIndex = 18;
            lblStudentBirthDate.Text = "-";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label18.Location = new Point(10, 317);
            label18.Name = "label18";
            label18.Size = new Size(42, 15);
            label18.TabIndex = 17;
            label18.Text = "Класс:";
            // 
            // lblStudentClass
            // 
            lblStudentClass.AutoSize = true;
            lblStudentClass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblStudentClass.Location = new Point(65, 317);
            lblStudentClass.Name = "lblStudentClass";
            lblStudentClass.Size = new Size(12, 15);
            lblStudentClass.TabIndex = 16;
            lblStudentClass.Text = "-";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label17.Location = new Point(10, 292);
            label17.Name = "label17";
            label17.Size = new Size(76, 15);
            label17.TabIndex = 15;
            label17.Text = "Выбранный:";
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblStudentName.Location = new Point(119, 292);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(86, 19);
            lblStudentName.TabIndex = 14;
            lblStudentName.Text = "Не выбран";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label16.Location = new Point(490, 10);
            label16.Name = "label16";
            label16.Size = new Size(96, 15);
            label16.TabIndex = 13;
            label16.Text = "Худший ученик:";
            // 
            // lblWorstStudent
            // 
            lblWorstStudent.AutoSize = true;
            lblWorstStudent.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblWorstStudent.Location = new Point(618, 8);
            lblWorstStudent.Name = "lblWorstStudent";
            lblWorstStudent.Size = new Size(92, 19);
            lblWorstStudent.TabIndex = 12;
            lblWorstStudent.Text = "Нет данных";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label15.Location = new Point(490, 40);
            label15.Name = "label15";
            label15.Size = new Size(98, 15);
            label15.TabIndex = 11;
            label15.Text = "Лучший ученик:";
            // 
            // lblBestStudent
            // 
            lblBestStudent.AutoSize = true;
            lblBestStudent.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblBestStudent.Location = new Point(618, 38);
            lblBestStudent.Name = "lblBestStudent";
            lblBestStudent.Size = new Size(92, 19);
            lblBestStudent.TabIndex = 10;
            lblBestStudent.Text = "Нет данных";
            // 
            // dataGridViewRating
            // 
            dataGridViewRating.AllowUserToAddRows = false;
            dataGridViewRating.AllowUserToDeleteRows = false;
            dataGridViewRating.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRating.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRating.Location = new Point(10, 3);
            dataGridViewRating.Name = "dataGridViewRating";
            dataGridViewRating.ReadOnly = true;
            dataGridViewRating.RowHeadersWidth = 51;
            dataGridViewRating.RowTemplate.Height = 29;
            dataGridViewRating.Size = new Size(470, 140);
            dataGridViewRating.TabIndex = 9;
            dataGridViewRating.CellFormatting += dataGridViewRating_CellFormatting;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label13.Location = new Point(10, 341);
            label13.Name = "label13";
            label13.Size = new Size(171, 19);
            label13.TabIndex = 2;
            label13.Text = "Средняя оценка ученика:";
            // 
            // lblStudentAverage
            // 
            lblStudentAverage.AutoSize = true;
            lblStudentAverage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblStudentAverage.Location = new Point(219, 341);
            lblStudentAverage.Name = "lblStudentAverage";
            lblStudentAverage.Size = new Size(41, 21);
            lblStudentAverage.TabIndex = 3;
            lblStudentAverage.Text = "0.00";
            // 
            // dataGridViewStudentGrades
            // 
            dataGridViewStudentGrades.AllowUserToAddRows = false;
            dataGridViewStudentGrades.AllowUserToDeleteRows = false;
            dataGridViewStudentGrades.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewStudentGrades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStudentGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudentGrades.Location = new Point(10, 365);
            dataGridViewStudentGrades.Name = "dataGridViewStudentGrades";
            dataGridViewStudentGrades.ReadOnly = true;
            dataGridViewStudentGrades.RowHeadersWidth = 51;
            dataGridViewStudentGrades.RowTemplate.Height = 29;
            dataGridViewStudentGrades.Size = new Size(920, 92);
            dataGridViewStudentGrades.TabIndex = 4;
            // 
            // groupBoxStatistics
            // 
            groupBoxStatistics.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxStatistics.BackColor = Color.Transparent;
            groupBoxStatistics.Controls.Add(lblAverageGrade);
            groupBoxStatistics.Controls.Add(lblTotalGrades);
            groupBoxStatistics.Controls.Add(lblTotalStudents);
            groupBoxStatistics.Controls.Add(label12);
            groupBoxStatistics.Controls.Add(label11);
            groupBoxStatistics.Controls.Add(label10);
            groupBoxStatistics.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxStatistics.Location = new Point(8, 8);
            groupBoxStatistics.Name = "groupBoxStatistics";
            groupBoxStatistics.Size = new Size(940, 120);
            groupBoxStatistics.TabIndex = 0;
            groupBoxStatistics.TabStop = false;
            groupBoxStatistics.Text = "Общая статистика";
            // 
            // lblAverageGrade
            // 
            lblAverageGrade.AutoSize = true;
            lblAverageGrade.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblAverageGrade.Location = new Point(400, 50);
            lblAverageGrade.Name = "lblAverageGrade";
            lblAverageGrade.Size = new Size(83, 45);
            lblAverageGrade.TabIndex = 5;
            lblAverageGrade.Text = "0.00";
            // 
            // lblTotalGrades
            // 
            lblTotalGrades.AutoSize = true;
            lblTotalGrades.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTotalGrades.Location = new Point(220, 50);
            lblTotalGrades.Name = "lblTotalGrades";
            lblTotalGrades.Size = new Size(38, 45);
            lblTotalGrades.TabIndex = 4;
            lblTotalGrades.Text = "0";
            // 
            // lblTotalStudents
            // 
            lblTotalStudents.AutoSize = true;
            lblTotalStudents.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTotalStudents.Location = new Point(40, 50);
            lblTotalStudents.Name = "lblTotalStudents";
            lblTotalStudents.Size = new Size(38, 45);
            lblTotalStudents.TabIndex = 3;
            lblTotalStudents.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label12.Location = new Point(400, 20);
            label12.Name = "label12";
            label12.Size = new Size(112, 19);
            label12.TabIndex = 2;
            label12.Text = "Средняя оценка";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label11.Location = new Point(220, 20);
            label11.Name = "label11";
            label11.Size = new Size(93, 19);
            label11.TabIndex = 1;
            label11.Text = "Всего оценок";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.Location = new Point(40, 20);
            label10.Name = "label10";
            label10.Size = new Size(107, 19);
            label10.TabIndex = 0;
            label10.Text = "Всего учеников";
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnExit.Location = new Point(844, 658);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(130, 39);
            btnExit.TabIndex = 1;
            btnExit.Text = "🚪 Выход";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(984, 701);
            Controls.Add(btnExit);
            Controls.Add(tabControl1);
            ForeColor = Color.FromArgb(240, 240, 240);
            MinimumSize = new Size(1000, 740);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "📚 Школьный журнал";
            tabControl1.ResumeLayout(false);
            tabPageStudents.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBoxAddStudent.ResumeLayout(false);
            groupBoxAddStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            tabPageGrades.ResumeLayout(false);
            groupBoxAddGrade.ResumeLayout(false);
            groupBoxAddGrade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudGrade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrades).EndInit();
            tabPageStatistics.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubjectStats).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRating).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudentGrades).EndInit();
            groupBoxStatistics.ResumeLayout(false);
            groupBoxStatistics.PerformLayout();
            ResumeLayout(false);
        }
    }
}