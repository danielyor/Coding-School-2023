namespace LibUniversity {
    public class Professor : Person {

        // Properties
        public string Rank { get; set; }
        public List<Course> Courses { get; set; }

        // Constructors
        public Professor() : base() {

        }

        // Methods
        public void Teach(Course course, DateTime date) {

        }
        public void SetGrade(Guid stuID, Guid courseID, int grade) {

        }
        public void GetName() {
        
        }

    }
}