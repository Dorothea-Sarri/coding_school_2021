using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicse3 {
    class Courses {
        private string subject;
        private string code;
        private string courseid;
        public string Code { get; set; }
        public string Subject { get; set; }
        public Courses(string Code, string Subject) {
            subject = Subject;
            code = Code;
             courseid = Guid.NewGuid().ToString();
        }
    }
}
