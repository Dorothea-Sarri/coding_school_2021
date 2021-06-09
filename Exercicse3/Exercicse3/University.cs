using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicse3 {
    class University : Institute {
        
        Courses[] course = new Courses[20];
        Student[] students = new Student[20];
        Grades[] grades = new Grades[20];
        Schedule[] scheduleCourse = new Schedule[20];
        public University(string Name, int YearsInServices) {
           

        }
        public  Student[] GetStudents() {

            
            return students;

        }
        public Grades[] GetGrades() {


            return grades;

        }
        public Courses[] GetCourses() {


            return course;

        }
        public static void SetSchedule(string courseid , string professorid, DateTime datetime) {

        }
    }
}
