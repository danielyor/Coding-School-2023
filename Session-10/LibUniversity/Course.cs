namespace LibUniversity {
    public class Course {

        // Properties
        public Guid ID { get; set; }
        public string Code { get; set; }
        public string Subject { get; set; }

        // Constructors
        public Course(string code, string subject) {
            ID = Guid.NewGuid();
            Code = code;
            Subject = subject;
        }

    }
}