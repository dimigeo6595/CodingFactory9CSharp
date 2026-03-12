using System;
using System.Collections.Generic;
using System.Text;

namespace AccountApp.Exceptions
{
    internal class InvalidSSNException : Exception
    {

        public InvalidSSNException() 
            : base("Invalid Social Security Number (SSN) provided.")
        { }

        public InvalidSSNException(string message) 
            : base(message)
        { }
         public InvalidSSNException(string message, Exception innerException) 
            : base(message, innerException)
        { }
    }
}
