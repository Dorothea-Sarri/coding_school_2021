using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicse3 {
    class Schedule {
        private DateTime callendar;
        private string scheduleid;
        public DateTime Callendar { get; set; }
        public Schedule(DateTime Callendar,string personid, string courseid) {
            callendar = Callendar;
           
             scheduleid = Guid.NewGuid().ToString();
        }
    }
}
