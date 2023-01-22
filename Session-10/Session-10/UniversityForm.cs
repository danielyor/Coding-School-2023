using LibUniversity;
using LibSerializer;

namespace Session_10 {
    public partial class UniversityForm : Form {
        public University uni { get; set; }
        public UniversityForm() {
            InitializeComponent();
        }

        private void loadDemoDataBtn_Click(object sender, EventArgs e) {
            // Load students
            Course mathCourse = new("M100", "Discrete Mathematics");
            Course comparchCourse = new("CS100", "Computer Architecture");
            Course hciCourse = new("CS110", "Human-Computer Interaction");

            Student student1 = new Student() {
                Name = "John Johnson",
                Age = 20,
                RegistrationNumber = 2021001,
                Courses = new List<Course> { mathCourse, comparchCourse }
            };

            Student student2 = new Student() {
                Name = "Maria Papadopoulou",
                Age = 19,
                RegistrationNumber = 2022039,
                Courses = new List<Course> { mathCourse, hciCourse }
            };

            List<Student> students = new();
            students.Add(student1);
            students.Add(student2);

            studentsGridView.DataSource = students;

            // Load Grades
            Grade grade1 = new(student1.ID, mathCourse.ID, 10);
            Grade grade2 = new(student2.ID, hciCourse.ID, 9);

            List<Grade> grades = new();
            grades.Add(grade1);
            grades.Add(grade2);

            gradesGridView.DataSource = grades;

            // Load Courses
            List<Course> courses = new();
            courses.Add(mathCourse);
            courses.Add(comparchCourse);
            courses.Add(hciCourse);

            coursesGridView.DataSource = courses;

            // Load courses Schedule
            Professor prof = new Professor() {
                Name = "Richard Richardson",
                Age = 50,
                Rank = "Associate Professor",
                Courses = new List<Course> { mathCourse, comparchCourse, hciCourse }
            };

            Schedule schedule1 = new(hciCourse.ID, prof.ID, DateTime.Parse("23/2/2023 4:30:00 PM"));
            Schedule schedule2 = new(comparchCourse.ID, prof.ID, DateTime.Parse("18/2/2023 7:00:00 PM"));

            List<Schedule> schedules = new();
            schedules.Add(schedule1);
            schedules.Add(schedule2);

            scheduledCoursesGridView.DataSource = schedules;

            // Update University entity
            uni = new University() {
                Name = "Epsilon University",
                Students = students,
                Courses = courses,
                Grades = grades,
                ScheduledCourse = schedules
            };
            uniGroupBox.Text = uni.Name;

        }

        private void saveBtn_Click(object sender, EventArgs e) {
            Serializer serializer = new();
            serializer.SerializeToFile(uni, "saved-data.json");

            MessageBox.Show("Save to file complete!", "Alert", MessageBoxButtons.OK);
        }

        private void loadBtn_Click(object sender, EventArgs e) {
            Serializer serializer = new();
            uni = serializer.Deserialize<University>("saved-data.json");

            studentsGridView.DataSource = uni.Students;
            gradesGridView.DataSource = uni.Grades;
            coursesGridView.DataSource = uni.Courses;
            scheduledCoursesGridView.DataSource = uni.ScheduledCourse;

            MessageBox.Show("Load from file complete!", "Alert", MessageBoxButtons.OK);
        }
    }
}