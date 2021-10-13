﻿using System;

namespace OOP_basics
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount1 = new BankAccount(AccountType.Credit);
            bankAccount1.Print();
            Console.WriteLine();

            BankAccount bankAccount2 = new BankAccount(100);
            bankAccount2.Print();
            Console.WriteLine();

            BankAccount bankAccount3 = new BankAccount(200, AccountType.Deposit);
            bankAccount3.Print();
            Console.WriteLine();
        }
    }
}