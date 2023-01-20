namespace LibUniversity {
    public class Schedule {

        // Properties
        public Guid ID { get; set; }
        public Guid CourseID { get; set; }
        public Guid ProfessorID { get; set; }
        public DateTime Calendar { get; set; }

        // Constructors
        public Schedule(Guid courseID, Guid profID, DateTime cal) {
            ID = Guid.NewGuid();
            CourseID = courseID;
            ProfessorID = profID;
            Calendar = cal;
        }

    }
}