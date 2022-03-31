using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");

            LINE_COMPARISON FIRST_LINE = new LINE_COMPARISON();
            LINE_COMPARISON SECOND_LINE = new LINE_COMPARISON();

            FIRST_LINE.ValuesofPoints();
            double Lenghtof1stLine = FIRST_LINE.FindLength();
            Console.WriteLine("Lenght of the first line is eqval to : {0}", Lenghtof1stLine);

            SECOND_LINE.ValuesofPoints();
            double Lenghtof2ndLine = SECOND_LINE.FindLength();
            Console.WriteLine("Lenght of the second line is eqval to : {0}", Lenghtof2ndLine);
            Console.ReadLine();
            int eqvality = COMPARE_LENGTHS(Lenghtof1stLine, Lenghtof2ndLine);
            if (eqvality > 0)
            {
                Console.WriteLine("Lengths of 1st line is greater.");
            }
            else if (eqvality < 0)
                Console.WriteLine("Length of 2nd Line is greater.");
            else
                Console.WriteLine("Both the Lines are eqval.");
        }

        public static int COMPARE_LENGTHS(double firstlength, double secondlrngth)
        {
            return firstlength.CompareTo(secondlrngth);
        }

        //Console.ReadLine();
        
    }
}
