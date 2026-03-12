using System;
using System.Collections.Generic;
using System.Text;

namespace AccountApp.Exceptions
{
    internal class InsufficientBalanceException : Exception
    {
        /// <summary>
        /// Standard exception pattern for custom exceptions in C#. 
        /// This constructor allows you to create an instance of the 
        /// exception with a default message indicating that the balance is insufficient. 
        /// It calls the base class constructor
        /// </summary>
        public InsufficientBalanceException() 
            : base("Insufficient balance")
        { }

        public InsufficientBalanceException(string message) 
            : base(message)
        { }
         public InsufficientBalanceException(string message, Exception innerException) 
            : base(message, innerException)
        { }
    }
}
