using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicse3 {
    class Person {
       
        public string Name { get; set;}
        public int Age {get;set;}

        private Guid personid;

        public Person(string Name, int Age) {
           
           // personid = Guid.NewGuid().ToString();
        }
        public Person() {
            
        }
        public  string GetName() {
            return Name;
        }
    }

}

