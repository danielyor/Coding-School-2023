using System;
using PersonNS;
using CourseNS;
using GradeNS;

namespace StudentNS {
    public class Student : Person {

        // Properties
        public int RegistrationNumber { get; set; }
        public Course[] Courses { get; set; }

        // Constructors
        public Student(Guid id, string name, int age, int regNum, Course[] courses) : base(id, name, age) {
            RegistrationNumber = regNum;
            Courses = courses;
        }

        // Methods
        public void Attend(Course course, DateTime date) {

        }
        public void WriteExam(Course course, DateTime date) {

        }

    }
}
