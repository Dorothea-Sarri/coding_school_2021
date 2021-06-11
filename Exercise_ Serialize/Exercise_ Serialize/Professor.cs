using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise__Serialize.Impl;
namespace Exercise__Serialize.Impl {
    public class Professor : Person {
        public string Rank { get; set; }
        public List<Course> Courses { get; set; }
        public Professor() {
            Courses = new List<Course>();
        }
    }
}
