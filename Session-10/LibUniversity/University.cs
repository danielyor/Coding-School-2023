namespace LibUniversity {
    public class University : Institute {

        // Properties
        public Student[] Students { get; set; }
        public Course[] Courses { get; set; }
        public Grade[] Grades { get; set; }
        public Schedule[] ScheduledCourse { get; set; }

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