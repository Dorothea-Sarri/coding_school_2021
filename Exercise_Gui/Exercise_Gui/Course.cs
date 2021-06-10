using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Gui {
   
    class Course {
        public Guid ID { get; set; }
        public string Code { get; set; }
        public string Subject { get; set; }
        public Course() {
            ID = Guid.NewGuid();
        }
        public void SetCode(String code) {
            Code = code;
        }
        public void SetSubject(String subject) {
            Subject = subject;
        }
    }
}
