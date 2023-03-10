using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ExceptionPractice.ExceptionHandlingD;

namespace ExceptionPractice
{
    internal class Circle
    {
        public double Radius { get; set; }
           
        public Circle(double radius)
        {
            if (radius > 0)
            {
                Radius = radius;
            }
            else if (radius < 0)
            {
                throw new InvalidRadiusException();
            }
            else 
            { 
                throw new ZeroRadiusException(); 
            }
        }

        public double ToString(double radius)
        {
            return radius;
        }
    }
}
