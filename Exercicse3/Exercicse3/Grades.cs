using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicse3 {
    class Grades {
        public int Grade { get; set; }
        private int grade;
        private string gradeid;
        public Grades(int Grade, string personid, string courseid) {//?????
            grade = Grade;
             gradeid = Guid.NewGuid().ToString();
        }
    }
}
