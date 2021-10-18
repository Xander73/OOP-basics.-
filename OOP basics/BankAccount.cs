using System;

namespace OOP_basics
{
    public enum AccountType { Current, Settlement, Credit, Deposit};

    public class BankAccount
    {
        private static long _numberAccount;

        private double _balance;
        AccountType _accountType;


        public BankAccount() => AddNumberAccount();

        public BankAccount (double balance, AccountType accountType)
        {
            AddNumberAccount();
            _balance = balance;
            _accountType = accountType;
        }


        public BankAccount(double balance) : this (balance, default)
        {

        }

        public BankAccount(AccountType accountType) : this(default, accountType)
        {

        }

        public double Balance
        {
            get => _balance;
            set => _balance = value;
        }


        public AccountType AccountType
        {
            get => _accountType;
            set => _accountType = value;
        }


        private static void AddNumberAccount() => ++_numberAccount;


        public string PutMoney(double money)
        {
            if (money <= 0)
            {
                return "Необходимо внести сумму больше 0.";
            }
            Balance += money;
            return $"Текущая сумма на счете {Balance}.";
        }


        public string Withdrawmoney (double money)
        {
            if (money <= 0)
            {
                return "Необходимо внести сумму больше 0.";
            }
            if (money > Balance)
            {
                return "На счете недостаточно средств.";
            }
            Balance -= money;
            return $"Текущая сумма на счете {Balance}.";
        }


        public void Print ()
        {
            Console.WriteLine($"Account number - {_numberAccount}");
            Console.WriteLine($"Balance - {Balance}");
            Console.WriteLine($"Account type - {AccountType}");
        }


        public string TransferMoney (BankAccount bankAccount, double amount)
        {
            if (bankAccount.Balance > amount)
            {
                Balance += amount;
                bankAccount.Balance -= amount;
                return $"Сумма {amount} переведена на счет.\nБаланс счета - {Balance}.";  
            }
            return "Недостаточно средств для перевода.";
                
        }


        //public long GetNumberAccount() => _numberAccount;
        //public string GetBalance() => _balance;
        //public AccountType GetAccountType() => _accountType;
        //public void SetBalance(string balance) => _balance = balance;
        //public void SetAccountType(AccountType accountType) => _accountType = accountType;
        //private static void AddNumberAccount() => ++_numberAccount;
    }
}
