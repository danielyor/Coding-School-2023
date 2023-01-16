using System;

namespace GradeNS {
    public class Grade {

        // Properties
        public Guid ID { get; set; }
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        public int Grading { get; set; }

        // Constructors
        public Grade(Guid id, Guid studentID, Guid courseID, int grade) {
            ID = id;
            StudentID = studentID;
            CourseID = courseID;
            Grading = grade;
        }

    }
}
