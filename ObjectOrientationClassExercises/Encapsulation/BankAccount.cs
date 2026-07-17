using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercises.Encapsulation
{
    internal class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public AccountType AccountType { get; set; }

        public decimal Balance { get; set; }

        public int CardNumber { get; set; }

        public DateTime CardExpiryDate { get; set; }

        public List<Transaction> transactions { get; set; }

        public BankAccount(int accountNumber, string accountHolder, AccountType accountType, decimal balance, int cardNumber, DateTime cardExpiryDate)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            AccountType = accountType;
            Balance = balance;
            CardNumber = cardNumber;
            CardExpiryDate = cardExpiryDate;


        }
        
    }

}
