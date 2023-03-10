using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ExceptionPractice.ExceptionHandlingD;

namespace ExceptionPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius1 = 0;

            try
            {
                Circle circle1 = new Circle(radius1);
                Console.WriteLine(circle1.ToString(radius1));
            }
            catch (InvalidRadiusException e) 
            {
                Console.WriteLine(radius1);
                Console.WriteLine(e.Message);
            }
            catch (ZeroRadiusException e)
            {
                Console.WriteLine(radius1);
                Console.WriteLine(e.Message);
            }
        }
    }
}
