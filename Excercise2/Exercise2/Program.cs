using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class Program {
        static void Main(string[] args) {
             Question1();
             Question2();
             Question3();
             Question4();
             Question5();
             Question6();
            Console.ReadLine();
        }

        static void Question1() {
            Console.WriteLine("\nQuestion1");
            int count = 0;
            string bigger = "";
            string sentence = "lorem ipsum dolor sit amet consectetur adipiscing elit";
            foreach (string word in sentence.Split(' ')) {
                if (count < word.Length) {
                    count = word.Length;
                    bigger = word;
                }
            }
            Console.WriteLine("The bigger word in the text is: "+bigger);

        }
        static void Question2() {
            Console.WriteLine("\nQuestion2");
            string word = "EpsilonNet";
            int i;
            var reversed = new StringBuilder();
            for ( i = word.Length-1; i >= 0; i--) {
                reversed = reversed.Append(word[i]); 
            }
            Console.WriteLine("Normal word: " + word);
            Console.WriteLine("Reversed word: "+ reversed);
        }
        static void Question3() {
            int menu;
            Console.WriteLine("\nQuestion3");
            do {
                int  i, sum = 0, product = 1;
                Console.WriteLine("Enter the Number:");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("**MENU**");
                Console.WriteLine("SELECT THE NUMBER FROM THE MENU");
                Console.WriteLine("1.SUM");
                Console.WriteLine("2.PRODUCT");
                Console.WriteLine("0.EXIT");
                //Console.WriteLine("**MENU**");
                menu = Convert.ToInt32(Console.ReadLine());
                if (menu == 1) {
                    for (i = 1; i <= number; i++) {
                        sum = sum + i;
                    }
                    Console.WriteLine("The result is:" + " " + sum);
                } else if (menu == 2) {
                    for (i = 1; i <= number; i++) {
                        product=product*i;
                    }
                    Console.WriteLine("The result is:" + " " + product);
                    }
            } while (menu != 0) ;
            }
        static void Question4() {
            Console.WriteLine("\nQuestion4");
            int i, x;
            Console.WriteLine("Enter the Number:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int num = 1; num <= n; num++) {
                x = 0;
                for (i = 2; i <= num / 2; i++) {
                    if (num % i == 0) {
                        x++;
                        break;
                    }
                }
                if (x == 0 && num != 1)
                    Console.Write("{0} ", num);
            }
        }
        static void Question5() {
            Console.WriteLine("\nQuestion5");
            int result=0 ;
            int[] table1 = { 2, 4, 9, 12 };
            int[] table2 = { 1, 3, 7, 10 };
          
            for (int i = 0; i < table1.Length; i++) {
                for (int j = 0; j < table2.Length; j++) {
                    result = table1[i] * table2[j];
                    Console.Write(result + " ");
                }
            }  
        }
        static void Question6() {
            Console.WriteLine("\nQuestion6");
            int[] table = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };
            Array.Sort(table);
            foreach (int value in table) {
                Console.Write(value + " ");
            }
        }
      
       

        }
    }
     




