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

            bool eqvality = COMPARE_LENGTHS(Lenghtof1stLine, Lenghtof2ndLine);
            if (eqvality)
            {
                Console.WriteLine("Lengths of both the Lines are eqval.");
            }
            else
                Console.WriteLine("Lengths of both the Lines are Different.");
        }

        public static Boolean COMPARE_LENGTHS(double firstlength, double secondlrngth)
        {
            return firstlength.Equals(secondlrngth);
        }

        //Console.ReadLine();
        
    }
}
