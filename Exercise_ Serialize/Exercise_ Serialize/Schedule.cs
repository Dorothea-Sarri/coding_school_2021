using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise__Serialize.Base;

namespace Exercise__Serialize.Impl {
    class Schedule : Entity {
        public Guid CourseID { get; set; }
        public Guid ProfessorID { get; set; }

        public DateTime Callendar { get; set; }

        // CONSTRUCTOR
        public Schedule()
            : base() {

        }
    }
}
