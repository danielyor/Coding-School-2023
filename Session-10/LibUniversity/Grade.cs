namespace LibUniversity {
    public class Grade {

        // Properties
        public Guid ID { get; set; }
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        public int Grading { get; set; }

        // Constructors
        public Grade(Guid studentID, Guid courseID, int grade) {
            ID = Guid.NewGuid();
            StudentID = studentID;
            CourseID = courseID;
            Grading = grade;
        }
        public Grade(Guid gradeID, Guid studentID, Guid courseID, int grade) {
            ID = gradeID;
            StudentID = studentID;
            CourseID = courseID;
            Grading = grade;
        }
        public Grade() {

        }

    }
}