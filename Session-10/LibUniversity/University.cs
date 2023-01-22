namespace LibUniversity {
    public class University : Institute {

        // Properties
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
        public List<Grade> Grades { get; set; }
        public List<Schedule> ScheduledCourse { get; set; }

        // Constructors
        public University() : base() {
            
        }

        // Methods
        public void GetName() {

        }
        public void SetName(string name) {
            Name = name;
        }

    }
}