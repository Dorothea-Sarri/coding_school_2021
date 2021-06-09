using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicse3 {
    class Professor : Person {

        private string rank; 
        public string Rank { get; set; }
        Courses[] course = new Courses[20] ;
        public Professor( string Name, int Age,string Rank) {
            rank = Rank;

        }
        static void Teach(Courses course,DateTime date) {
           
        }
        static void SetGrade(string personid, string courseid,int grade) {

        }
    }
}
