using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculator();
            
        }

        static void Calculator()
        {
            Console.WriteLine("Hvad skal vi regne?");
            Console.Write("Enter value no 1. ");
            int value1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter value no 2. ");
            int value2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Vælg hvad du vil: (A)dd, (S)ubstract, (M)ultiply, (D)ivide");
            Console.Write("Dit valg (skriv med stort): ");
            string valgt = Console.ReadLine();

            switch (valgt)
            {
                case "A":
                    Console.WriteLine("Resultatet er: " + AddNumbers(value1, value2));
                    break;
                case "S":
                    Console.WriteLine("Resultatet er: " + SubtractNumbers(value1, value2));
                    break;
                case "M":
                    Console.WriteLine("Resultatet er: " + MultipleNumbers(value1, value2));
                    break;
                case "D":
                    Console.WriteLine("Resultatet er: " + DivideNumbers(value1, value2));
                    break;
                default:
                    break;
            }
            Console.WriteLine();
            Calculator();
        }

        static int AddNumbers(int tal1, int tal2)
        {
            return tal1 + tal2;
        }
        static int SubtractNumbers(int tal1, int tal2)
        {
            return tal1 - tal2;
        }
        static int MultipleNumbers(int tal1, int tal2)
        {
            return tal1 * tal2;
        }
        static int DivideNumbers(int tal1, int tal2)
        {
            return tal1 / tal2;
        }
    }
}
