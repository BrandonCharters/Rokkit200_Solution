using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rokkit200_Solution.Classes
{
    public class CustomException : Exception
    {
        /// <summary>
        /// This class is to allow custom exceptions to be made throughout the app
        /// </summary>
        public CustomException() { }

        public CustomException(string Message)
            : base(String.Format(Message))
        {

        }
//*********************************************************ooo METHOD END ooo*********************************************************//
    }
//*********************************************************ooo CLASS END ooo*********************************************************//
}
//*********************************************************ooo APP END ooo*********************************************************//
