using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPractice 
{
    internal class ExceptionHandlingD
    {
        internal class InvalidRadiusException: Exception 
        {
            //constructor
            public InvalidRadiusException() : base("Negative radius. Invalid") 
            { 
                
            }

        }

        internal class ZeroRadiusException: Exception
        {
            public ZeroRadiusException() : base("Zero radius. Invalid")
            {

            }
        }
    }
}
