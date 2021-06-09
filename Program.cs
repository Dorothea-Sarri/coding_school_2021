using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise1 {
    class Program {
        static void Main(string[] args) {
            //Question1() ;
            // Question2(5,10);
            // Question3();
           //  Question4();
             //Question5();
            // Question6();
            //Question7();
            //Question8();
            //Question9();
            Question10();
            
            Console.ReadLine();
        }
        static void Question1() {
            String word = "Hello";
            String space = " ";
            String name = "Dorothea";
            String phrase = word + space + name;
            Console.WriteLine(phrase);

        }
        static void Question2(int number1, int number2) { 
            int sum = number1 + number2;
            decimal div = (decimal)number1 / (decimal)number2;
            Console.WriteLine("To athrisma twn arithmwn 5 kai 10 einai:" + " " + sum + " " + "To piliko einai: " + " " + div);
           

        }
        static void Question3() { 
            int number1 = -1;
            int number2 = 5;
            int number3 = 6;
            int operation1 = number1 + number2 * number3;
            Console.WriteLine("To apotelesma ths ptwths praxis einai:" + " " + operation1);
            int number4 = 38;
            int number5 = 7;
            decimal operation2 = number4 + (decimal)number2 % number5;
            Console.WriteLine("To apotelesma ths deyterhs praxis einai: " + " " + operation2);
            int number6 = 14;
            int number7 = -3;
            decimal operation3 = number6 + ((decimal)number7 * (decimal)number3) / number5;
            Console.WriteLine("To apotelesma ths tritis praxis einai: " + " " + operation3);
            int number8 = 2;
            int number9 = 13;
            double x = Math.Sqrt(number5);
            decimal operation4 = number8 + (((decimal)number9 / number3) * number3) +  (decimal) x;
          Console.WriteLine("To apotelesma ths tetarths praxis einai: " + " " + operation4);
            int number10 = 4;
            int number11 = 9;
            double y = Math.Pow(number3,number10);
            double z= Math.Pow(number2, number5);
            decimal operation5 = (decimal)(y + z)/ ((decimal)number11 % number10) ;
            Console.WriteLine("To apotelesma ths pempths praxis einai: " + " " + operation5);
        }
        static void Question4() {
            Console.WriteLine("Dwse ton 1o aritmo");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dwse ton 2o aritmo");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dwse ton 3o aritmo");
            int number3 = Convert.ToInt32(Console.ReadLine());
            int sum = number1 * number2 * number3;
            Console.WriteLine("To ginomeno twn arithmwn einai:" + " " + sum);


        }
        static void Question5() {
            Console.WriteLine("Dwse ton 1o aritmo");
            decimal number1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Dwse ton 2o aritmo");
            decimal number2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Dwse ton 3o aritmo");
            decimal number3 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Dwse ton 4o aritmo");
            decimal number4 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Dwse ton 5o aritmo");
            decimal number5 = Convert.ToDecimal(Console.ReadLine());
            decimal average = (number1 + number2 + number3 + number4 + number5) / 5;
            Console.WriteLine("O mesos oros twn arithmwn einai:" + " " + average);


        }
        static void Question6() {
            Console.WriteLine("Dwse thn hlikia sou");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dwse to fulo sou");
            string gender = Console.ReadLine();
            Console.WriteLine("You are " + gender + " and look younger than " + age);

            
        }
        static void Question7() {
            Console.WriteLine("Dwse enan arithmo");
            int number = Convert.ToInt32(Console.ReadLine());
            decimal minutes = (decimal)(number / 60);
            decimal hours = (decimal)(minutes /60);
            decimal day = (decimal)(hours / 24);
            decimal year = (decimal)(day / 365);
            Console.WriteLine( "Oi meres einai: "  + day + " " + "Oi wres einai: " +  hours + " " + "Ta lepta einai: " +  minutes + " " + "Ta etoi einai: " + year);
        }
        static void Question8() {
            Console.WriteLine("Dwse enan arithmo");
            int number = Convert.ToInt32(Console.ReadLine());
            decimal minutes = (decimal)(number / 60);
            decimal hours = (decimal)(minutes / 60);
            decimal day = (decimal)(hours / 24);
            decimal year = (decimal)(day / 365);
            Console.WriteLine("Oi meres einai: " + day + " " + "Oi wres einai: " + hours + " " + "Ta lepta einai: " + minutes + " " + "Ta etoi einai: " + year);
        }
        static void Question9() {
            Console.Write("Dwse timi se celsius ");
            decimal celsius = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Kelvin = {0}", celsius + 273);
            Console.WriteLine("Fahrenheit = {0}",  celsius * 18 / 10 + 32);
        }
        static void Question10() {
            Console.WriteLine("Dwse mia lexi");
            string lexi = Console.ReadLine();
            string x =  lexi.Replace("a", "");
            Console.WriteLine(x);
            
        }
    }
   
}
