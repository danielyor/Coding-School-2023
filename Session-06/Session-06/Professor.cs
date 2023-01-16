using System;
using PersonNS;
using CourseNS;
using GradeNS;

namespace ProfessorNS {
    public class Professor : Person {

        // Properties
        public string Rank { get; set; }
        public Course[] Courses { get; set; }

        // Constructors
        public Professor(Guid id, string name, int age, string rank, Course[] courses) : base(id, name, age) {
            Rank = rank;
            Courses = courses;
        }

        // Methods
        public void Teach(Course course, DateTime date) {

        }
        public void SetGrade(Guid studentID, Guid courseID, Grade grade) {
            
        }
        public void GetName() {

        }

    }
}
