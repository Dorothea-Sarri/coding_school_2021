using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicse3 {
    class Institute {
        private string name;
        private int yearsInService;
        private string instituteid;
        public string Name { get; set; }
        public int YearsInServices { get; set; }

        public Institute(string Name, int YearsInServices) {
            name = Name;
           yearsInService = YearsInServices;
            instituteid = Guid.NewGuid().ToString();
        }
        public Institute() {
            
        }

    }
}
