using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercises.Encapsulation
{
    internal class EncapsulationSample
    {
        public static void Run()
        {
            ConsoleColor defaultColor = Console.ForegroundColor;


            DateTime expiryDate = new DateTime(2030, 10, 31);
            BankAccount bankAccount = new BankAccount(12345, "John Doe", AccountType.Savings, 680, 6789, expiryDate);

            Console.WriteLine($"Welcome {bankAccount.AccountHolder}");
            Console.WriteLine($"Your balance is {bankAccount.Balance:C}");
            Console.WriteLine("-----------------------------------");

            bool exitApp = false;

            while (!exitApp)

            {

                Console.WriteLine("Would you like to make a transaction (Y/N)");
                string userInput = Console.ReadLine();

                if (userInput.ToUpper() == "Y")
                {
                    if (bankAccount.Transactions.Count > 0)
                    {
                        Transaction lastTransaction = bankAccount.Transactions[bankAccount.Transactions.Count - 1];


                        Console.WriteLine($"Last Transaction: Amount {lastTransaction.Amount} Description {lastTransaction.Description} ");

                    }
                    else
                    {
                        Console.WriteLine("No previous transactions found.");
                    }


                    Console.WriteLine("1. Deposit");
                    Console.WriteLine("2. Withdrawal");
                    Console.WriteLine("3. Bank Statement");

                    userInput = Console.ReadLine();

                    if (userInput == "1")
                    {
                        Console.WriteLine("How much do you want to deposit?");
                        string userAmount = Console.ReadLine();

                        Console.WriteLine("What is the reference?");
                        string userReference = Console.ReadLine();

                        Console.WriteLine("What is the description?");
                        string userDescription = Console.ReadLine();

                        TransactionResult transactionResult = bankAccount.MakeDeposit(decimal.Parse(userAmount), userReference, userDescription);

                        if (transactionResult == TransactionResult.Successful)
                        {
                            Console.WriteLine($"Transaction Successful!! Your New Balance is: {bankAccount.Balance} ");
                        }
                        else
                        {
                            Console.WriteLine("Transaction denied!");
                        }
                    }
                    else if (userInput == "2")
                    {
                        Console.WriteLine("How much do you want to withdraw?");
                        string userAmount = Console.ReadLine();

                        Console.WriteLine("What is the reference?");
                        string userReference = Console.ReadLine();

                        Console.WriteLine("What is the description?");
                        string userDescription = Console.ReadLine();

                        TransactionResult transactionResult = bankAccount.MakeWithdrawal(decimal.Parse(userAmount), userReference, userDescription);

                        if (transactionResult == TransactionResult.Successful)
                        {
                            Console.WriteLine($"Transaction Successful!! Your New Balance is: {bankAccount.Balance} ");
                        }
                        else if (transactionResult == TransactionResult.InsufficientFunds)
                        {
                            Console.WriteLine($"Insufficient Funds! Your Balance is: {bankAccount.Balance}");
                        }
                        else
                        {
                            Console.WriteLine("Transaction denied!");
                        }
                    }
                    else if (userInput == "3")

                    {
                        Console.WriteLine("Bank Statement");

                        foreach (Transaction transaction in bankAccount.Transactions)
                        {
                            if (transaction.TransactionType == TransactionType.Deposit)
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }

                            Console.WriteLine($"Transaction Date: {transaction.TransactionDateTime} Amount: {transaction.Amount} Reference: {transaction.Reference} Description: {transaction.Description} Transaction Type: {transaction.TransactionType} ");

                            Console.ForegroundColor = defaultColor;
                        }
                    }

                }
                else
                {
                    Console.WriteLine($"Goodbye Have a lovely day, {bankAccount.AccountHolder}");
                    exitApp = true;
                }

            }

        }
    }
}