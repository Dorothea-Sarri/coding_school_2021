using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicse3 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine( Question1(10));
            Console.ReadLine();
        }
       
      static int Question1(int number) {

            if (number == 0)
                return 0;
            else
                return number % 2 + 10 * Question1(number / 2);
        }
    }
    
}
