using System;
using InstituteNS;
using StudentNS;
using CourseNS;
using GradeNS;
using ScheduleNS;


namespace UniversityNS {
    public class University : Institute {

        // Properties
        public Student[] Students { get; set; }
        public Course[] Courses { get; set; }
        public Grade[] Grades { get; set; }
        public Schedule[] ScheduledCourse { get; set; }

        // Constructors
        public University(Guid id, string name, int years, Student[] students, Course[] courses, Grade[] grades, Schedule[] scheduledCourse) : base(id, name, years) {
            Students = students;
            Courses = courses;
            Grades = grades;
            ScheduledCourse = scheduledCourse;
        }

        // Methods
        public void GetName() {

        }
        public void SetName(string name) {
            Name = name;
        }

    }
}
