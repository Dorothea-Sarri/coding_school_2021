using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicse3 {
    class Student :Person {
        private int registrationNumber;
        public int RegistrationNumber { get; set; }
        Courses[] course = new Courses[20];
        public Student(string Name, int Age,int RegistrationNumber) {
            this.registrationNumber = RegistrationNumber;

        }
        static void Attend(Courses course, DateTime date) {

        }
        static void WritteExam(Courses course, DateTime date) {

        }
    }
}
