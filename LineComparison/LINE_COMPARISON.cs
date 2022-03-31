using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class LINE_COMPARISON
    {
        public double X_START, X_END;
        public double Y_START, Y_END;

        public void ValuesofPoints()
        {
            Console.WriteLine("Enter X start point : ");
            X_START = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter X end point : ");
            X_END = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y start point : ");
            Y_START = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y start point : ");
            Y_END = Convert.ToDouble(Console.ReadLine());
        }

        public void FindLength()
        {
            double power1 = Math.Pow((X_END - X_START), 2);
            double power2 = Math.Pow((Y_END - Y_START), 2);
            double Lenght = Math.Sqrt(power1 + power2);
        }

    }
}
