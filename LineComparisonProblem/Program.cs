using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    internal class Program
    {
        public static int x1, x2, x3, x4,y1, y2, y3, y4;
        public static double lengthOfLine = 0, lengthOfLine2 = 0;
        static void Main(string[] args)
        {
            CalculatelengthOfLine();
            CalculateLengthOfLine2();
            CompareOfTwoLine();
            Console.ReadLine();
        }
        public static void CalculatelengthOfLine()
        {

            Console.WriteLine("Enter the value of x1 and y1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x2 and y2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            lengthOfLine = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of line:" + lengthOfLine);
        }

            public static void CalculateLengthOfLine2() 
            {
                Console.WriteLine("\nEnter the value of x3 and y3");
                int x3 = Convert.ToInt32(Console.ReadLine());
                int y3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the value of x4 and y4");
                int x4 = Convert.ToInt32(Console.ReadLine());
                int y4 = Convert.ToInt32(Console.ReadLine());

                lengthOfLine2 = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
                Console.WriteLine("Length of line:" + lengthOfLine2);
            }
        public static void CompareOfTwoLine() 
        {
            if (lengthOfLine.CompareTo(lengthOfLine2) > 0)
            {
                Console.WriteLine("first line is greater than second line");
            }
            else if (lengthOfLine.CompareTo(lengthOfLine2) < 0)
            {
                Console.WriteLine("first line is less than second line");
            }
            else
            {
                Console.WriteLine("Both lines are equal");
            }
        }
            
        
    }
}
