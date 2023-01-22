namespace LibUniversity {
    public class Student : Person {

        // Properties
        public int RegistrationNumber { get; set; }
        public List<Course> Courses { get; set; }

        // Constructors
        public Student() : base() {

        }

        // Methods
        public void Attend(Course course, DateTime date) {

        }
        public void WriteExam(Course course, DateTime date) {

        }

    }
}