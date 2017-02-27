using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektier7marts
{
    class Program
    {
        static void Main(string[] args)
        {
            MyHelloWorld();
            Console.WriteLine(Biggerthan10(9));

            Console.Write("What is your name? ");
            CurrentUser(Console.ReadLine());

            Console.Write("Skriv dit første tal: ");
            int firstTal = Int32.Parse(Console.ReadLine());
            Console.Write("Skriv dit andet tal: ");
            int secondTal = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Tilsammen er det: " + Plus2Tal(firstTal, secondTal));

            metode1();
            Console.WriteLine("metode1 sluttet og nu tilbage i main metode");

            Console.ReadKey();
        }

        static void MyHelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        static Boolean Biggerthan10(int heltal)
        {
            if (heltal > 10)
            {
                return true;
            }else
            {
                return false;
            }
                
        }

        static string CurrentUser(string navnet)
        {
            Console.WriteLine("Hallo " + navnet + ", nice to meet you!");
            return navnet;
        }

        static int Plus2Tal(int first, int second)
        {
            int sum = first + second;
            return sum;
        }

        static void metode1()
        {
            Console.WriteLine("metode1 begyndt .. ");
            metode2();
            Console.WriteLine("metode2 sluttet og nu tilbage i metode 1");
        }
        static void metode2()
        {
            Console.WriteLine("metode2 begyndt .. ");
            metode3();
            Console.WriteLine("metode3 slut og tilbage i metode2 ..  ");
        }
        static void metode3()
        {
            Console.WriteLine("metode3 begyndt .. ");
            CurrentUser("metode3");
        }
    }
}
