using AccountApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AccountApp.Model
{
    internal class Account
    {
        public int Id { get; set; }
        public string? Iban { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public decimal Balance { get; set; }
        public string? Ssn { get; set; }

        // Public API method for deposit.

        
        /// <summary>
        /// Deposits the scpecified amount into the account. 
        /// </summary>
        /// <param name="amount">The specified amount of money</param>
        /// <exception cref="ArgumentException"></exception>
        public void Deposit(decimal amount)
        {
            try
            {
                if (amount < 0)
                {
                    throw new NegativeAmountException("Deposit amount must be positive.");
                }

                Balance += amount;
            }
            catch (NegativeAmountException ex)
            {
                Console.Error.WriteLine(ex.Message);
                throw; // Rethrow the exception to be handled by the caller.
            }
        }

        public void Withdraw(decimal amount, string ssn)
        {
            try
            {
                if (string.IsNullOrEmpty(Ssn)) throw new InvalidSSNException("Ssn must not be empty");
                if (ssn != Ssn) throw new InvalidSSNException("Ssn does not match account holder's Ssn");
                if (amount < 0) throw new NegativeAmountException("Withdrawal amount must be positive.");
                if (amount > Balance) throw new InsufficientBalanceException("Insufficient funds for withdrawal.");
                Balance -= amount;

            }
            catch (Exception ex) when (ex is NegativeAmountException
                                        or InvalidSSNException                  // > C# 11.0 pattern matching with 'or' operator
                                        || ex is InsufficientBalanceException) // Older syntax for catching multiple exceptions
            {
                Console.Error.WriteLine(ex.Message);
                throw; // Rethrow the exception to be handled by the caller.



            }


        }


        public decimal GetBalance(string ssn)
        {
            try
            {
                if (string.IsNullOrEmpty(Ssn)) throw new InvalidSSNException("Ssn must not be empty");
                if (Ssn != Ssn) throw new InvalidSSNException("Ssn does not match account holder's Ssn");
                return Balance;

            }
            catch (InvalidSSNException ex)
            {
                Console.Error.WriteLine(ex.Message);
                throw; // Rethrow the exception to be handled by the caller.
            }

        }


    }


    
}
