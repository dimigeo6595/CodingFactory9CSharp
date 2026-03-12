using System;
using System.Collections.Generic;
using System.Text;

namespace AccountApp.Exceptions
{
    internal class NegativeAmountException : Exception
    {

        public NegativeAmountException() 
            : base("Amount cannot be negative")
        { }

        public NegativeAmountException(string message) 
            : base(message)
        { }
         public NegativeAmountException(string message, Exception innerException) 
            : base(message, innerException)
        { }


    }
}
