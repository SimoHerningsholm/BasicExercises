using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_CSharp_Exercises_SimonHC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave 01
            Console.WriteLine("Opgave 1");
            Console.WriteLine(AddAndMultiply(2, 4, 5));
            //Opgave 02
            Console.WriteLine("Opgave 2");
            Console.WriteLine(CelsiusToFahrenheit(0));
            Console.WriteLine(CelsiusToFahrenheit(100));
            Console.WriteLine(CelsiusToFahrenheit(-271.15));
            //Opgave 03
            Console.WriteLine("Opgave 3");
            Console.WriteLine(ElementaryOperations(3, 8));
            //Opgave 04
            Console.WriteLine("Opgave 4");
            Console.WriteLine(IsResultTheSame(2 + 2, 2 * 2));
            Console.WriteLine(IsResultTheSame(9/3, 16-1));
            //Opgave 05
            Console.WriteLine("Opgave 5");
            Console.WriteLine(ModuloOperations(8, 5, 2));
            //Opgave06
            Console.WriteLine("Opgave 6");
            Console.WriteLine(CubeOf(2));
            Console.WriteLine(CubeOf(-5.5));
            //Opgave07
            Console.WriteLine("Opgave 7");
            SwapTwoIntegers(87, 45);
            SwapTwoIntegers(-13, 2);
            Console.ReadLine();
        }
        static void SwapTwoIntegers(int a, int b)
        {
            //Først udskrives hvilke integer variable har hvilke værdier til at starte med
            Console.WriteLine("Before: Variable A: " + a.ToString() + " variable B: " + b.ToString());
            //værdien a "lægges i en container" før den bliver overskrevet.
            int temp = a;
            //a overskrives med b
            a = b;
            //b overskrives med værdien af a før a blev overskrevet.
            b = temp;
            //Til sidst udskrives hvilke integer variable har hvilke værdier efter værdiombytning
            Console.WriteLine("After: Variable A: " + a.ToString() + " variable B: " + b.ToString());
        }
        static double CubeOf(double a)
        {
            //Hvis a fortolkes som en længde, returneres den cube denne længde udgør i 3 dimensioner.
            return a * a * a;
        }
        static int ModuloOperations(int a, int b, int c)
        {
            //Der returneres remainderen af division mellem a og b --> (a/b), og remainderen af divisionen mellem remainderen af (a/b) og c --> (a/b)/c 
            return a % b % c;
        }
        static bool IsResultTheSame(double a, double b)
        {
            //Hvis argumenterne udregnes til at være ens returneres der sand, ellers falsk.
            return a == b;
        }
        static string ElementaryOperations(double a, double b)
        {
            //Resultatet af de 4 basis regneoperationer concatineres sammen til en streng der returneres.
            return (a + b).ToString() + " " + (a - b).ToString() + " " + (a * b).ToString() + " " + (a / b).ToString();
        }
        static string CelsiusToFahrenheit(double c)
        {
            if(c > -271.15)
            {
                //Hvis temperaturen i celsius er over det absolutte nulpunkt, returneres temperaturen i fahrenheit
                return (c*9/5 + 32).ToString() + " F";
            }
            else
            {
                //Hvis temperaturen er under det absolutte nulpunkt returneres en fejlmeddelelse.
                return "Temperaturen er under det absolutte nulpunkt";
            }

        }
        static int AddAndMultiply(int a, int b, int c)
        {
            //der returneres produktet af c ganget med summen af a og b
            return (a + b) * c;
        }
    }
}
