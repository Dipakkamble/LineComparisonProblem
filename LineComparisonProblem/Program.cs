using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            double lengthOfLine = 0,lengthOfLine2 = 0;
            Console.WriteLine("Welcome to line comparison problem");

            Console.WriteLine("Enter the value of x1 and y1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x2 and y2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            lengthOfLine = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of line:" +lengthOfLine);

            Console.WriteLine("\nEnter the value of x3 and y3");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x4 and y4");
            int x4 = Convert.ToInt32(Console.ReadLine());
            int y4 = Convert.ToInt32(Console.ReadLine());

            lengthOfLine2 = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            Console.WriteLine("Length of line:" + lengthOfLine2);
            if (lengthOfLine.Equals(lengthOfLine2))
            {
                Console.WriteLine("Both the lines are equal");
            }
            else
            {
                Console.WriteLine("lines are not equal");
            }
            Console.ReadLine();
        }
    }
}
