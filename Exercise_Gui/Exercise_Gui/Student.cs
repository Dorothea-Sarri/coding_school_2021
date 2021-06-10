using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Gui {
    class Student : Person {

        public int RegistrationNumber { get; set; }
         
        public Student() {

        }


     
        public void SetRegistrationNumber(int registrationNumber) {
            RegistrationNumber = registrationNumber;
        }
    }
}