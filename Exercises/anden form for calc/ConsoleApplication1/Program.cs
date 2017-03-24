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
            Console.WriteLine("Velkommen til Calculatron");
            Calc();
        }

        static void Calc()
        {
            GreetUser();
            int MitValg = GetInt();

            switch (MitValg)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine("Du valgte at lægge sammen");
                    int sum = AddNumbers(GetInt(), GetInt());
                    Console.WriteLine("Det bliver: " + sum);
                    Console.WriteLine("");
                    Calc();
                    break;
                default:
                    break;
            }
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

        static int AddNumbers(int valg1,int valg2)
        {
            return valg1 + valg2;
        }
    }
}
