using System;

namespace ScheduleNS {
    public class Schedule {

        // Properties
        public Guid ID { get; set; }
        public Guid CourseID { get; set; }
        public Guid ProfessorID { get; set; }
        public DateTime Calendar { get; set; }

        // Constructors
        public Schedule(Guid id, Guid courseID, Guid profID, DateTime cal) {
            ID = id;
            CourseID = courseID;
            ProfessorID = profID;
            Calendar = cal;
        }

    }
}
