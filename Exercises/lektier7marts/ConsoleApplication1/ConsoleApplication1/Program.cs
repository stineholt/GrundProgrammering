using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til Calculatron ;)");
            Calculatron();
        }

        static void Calculatron()
        {
            GreetUser();
            int MitValg = GetInt();

            if (MitValg == 0)
            {
                return;
            }
            else if (MitValg == 1)
            {
                AddNumbers();
            }
            else if (MitValg == 2)
            {
                Substraktion();
            }
            else if (MitValg == 3)
            {
                Multiplikation();
            }
            else if (MitValg == 4)
            {
                Division();
            }

            Console.WriteLine("");
            Calculatron();
        }

        static int GetInt()
        {
            Console.Write("indtast tal: ");
            int input = Int32.Parse(Console.ReadLine());
            return input;
        }

        static void GreetUser()
        {
            Console.WriteLine("Hvad skal jeg gøre for dig?");
            Console.WriteLine("Tast 0 for at lukke programmet");
            Console.WriteLine("Tast 1 for addition");
            Console.WriteLine("Tast 2 for substraktion");
            Console.WriteLine("Tast 3 for multiplikation");
            Console.WriteLine("Tast 4 for divistion");
        }

        static void AddNumbers()
        {
            Console.WriteLine("");
            Console.WriteLine("Det bare skønt, giv mig de tal du vil ligge sammen: ");
            int firstNumber = GetInt();
            int secondNumber = GetInt();
            int Sum = firstNumber + secondNumber;
            Console.WriteLine("Okay, lad os se "+firstNumber+ " + " + secondNumber+ " = " + Sum);
        }

        static void Substraktion()
        {
            Console.WriteLine("");
            Console.WriteLine("Jamen så det da det vi gør, giv mig de tal du vil trække fra hinanden sammen: ");
            int firstNumber = GetInt();
            int secondNumber = GetInt();
            int Sum = firstNumber - secondNumber;
            Console.WriteLine("Okay, lad os se " + firstNumber + " - " + secondNumber + " = " + Sum);
        }

        static void Multiplikation()
        {
            Console.WriteLine("");
            Console.WriteLine("Jamen så det da det vi gør, giv mig de tal du vil gange sammen: ");
            int firstNumber = GetInt();
            int secondNumber = GetInt();
            int Sum = firstNumber * secondNumber;
            Console.WriteLine("Okay, lad os se " + firstNumber + " * " + secondNumber + " = " + Sum);
        }

        static void Division()
        {
            Console.WriteLine("");
            Console.WriteLine("Jamen så det da det vi gør, giv mig de tal du vil dividere med hinanden: ");
            int firstNumber = GetInt();
            int secondNumber = GetInt();
            int Sum = firstNumber / secondNumber;
            Console.WriteLine("Okay, lad os se " + firstNumber + " / " + secondNumber + " = " + Sum);
        }
    }
}
