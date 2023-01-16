using System;

namespace CourseNS {
    public class Course {

        // Properties
        public Guid ID { get; set; }
        public string Code { get; set; }
        public string Subject { get; set; }

        // Constructors
        public Course(Guid id, string code, string subject) {
            ID = id;
            Code = code;
            Subject = subject;
        }

    }
}
