using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise__Serialize.Base;

namespace Exercise__Serialize.Impl
    {
     public class Course : Entity {

        // PROPERTIES
        public string Subject { get; set; }
        public int Hours { get; set; }
        public CoursesCategoryEnum Category { get; set; }

        // CONSTRUCTOR
        public Course()
            : base() {

        }

        // METHODS
    }
}
