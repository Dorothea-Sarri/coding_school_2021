using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Gui {
    class Person {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
         public Person() {
            ID = Guid.NewGuid();
        }
   public void SetName (String name) {
            Name = name;
        }
        public void SetSurname(String surname) {
            Surname = surname;
        }
        public void SetAge(int age) {
            Age = age;
        }
    }
}


